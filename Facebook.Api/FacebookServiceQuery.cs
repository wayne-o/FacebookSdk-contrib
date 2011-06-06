using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime;
using System.Linq.Expressions;
using System.Data.Services.Client;

namespace Facebook.Api
{
    public abstract class FacebookServiceQuery : FacebookServiceRequest, IEnumerable, IQueryable
    {

        public abstract Expression Expression { get; }

        public abstract IQueryProvider Provider { get; }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public IEnumerable EndExecute(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }


        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public IEnumerable Execute()
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
