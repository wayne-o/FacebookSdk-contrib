
namespace Facebook.Api
{
    using IQToolkit.Data.Common;
    using IQToolkit.Data;
    using System.Linq.Expressions;
    using System.Reflection;
    using IQToolkit;

    public class FqlLanguage : QueryLanguage
    {
        DbTypeSystem typeSystem = new DbTypeSystem();

        public FqlLanguage()
        {
        }

        public override QueryTypeSystem TypeSystem
        {
            get { return this.typeSystem; }
        }

        public override bool AllowsMultipleCommands
        {
            get { return false; }
        }

        public override bool AllowDistinctInAggregates
        {
            get { return true; }
        }

        public override string Quote(string name)
        {
            return name;
        }

        private static readonly char[] splitChars = new char[] { '.' };

        public override Expression GetGeneratedIdExpression(MemberInfo member)
        {
            return new FunctionExpression(TypeHelper.GetMemberType(member), "LAST_INSERT_ID()", null);
        }

        public override Expression GetRowsAffectedExpression(Expression command)
        {
            return new FunctionExpression(typeof(int), "ROW_COUNT()", null);
        }

        public override bool IsRowsAffectedExpressions(Expression expression)
        {
            FunctionExpression fex = expression as FunctionExpression;
            return fex != null && fex.Name == "ROW_COUNT()";
        }

        public override QueryLinguist CreateLinguist(QueryTranslator translator)
        {
            return new FqlLinguist(this, translator);
        }

        class FqlLinguist : QueryLinguist
        {
            public FqlLinguist(FqlLanguage language, QueryTranslator translator)
                : base(language, translator)
            {
            }

            public override Expression Translate(Expression expression)
            {
                // fix up any order-by's
                expression = OrderByRewriter.Rewrite(this.Language, expression);

                expression = base.Translate(expression);

                expression = UnusedColumnRemover.Remove(expression);

                //expression = DistinctOrderByRewriter.Rewrite(expression);

                return expression;
            }

            public override string Format(Expression expression)
            {
                return FqlFormatter.Format(expression, this.Language);
            }
        }

        public static readonly QueryLanguage Default = new FqlLanguage();
    }
}