using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Facebook.Api.Graph
{
    public abstract class GraphService<TEntity>
    {

        public bool Post(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(string id)
        {
            throw new NotImplementedException();
        }

        protected TConnection GetConnectionItem<TConnection>(string connection, long id)
        {
            return GetConnectionItem<TConnection>(connection, id.ToString());
        }

        protected TConnection GetConnectionItem<TConnection>(string connection, string id)
        {
            throw new NotImplementedException();
        }

        protected Collection<TConnection> GetConnectionItems<TConnection>(string connection, long id)
        {
            return GetConnectionItems<TConnection>(connection, id.ToString());
        }

        protected Collection<TConnection> GetConnectionItems<TConnection>(string connection, string id)
        {
            throw new NotImplementedException();
        }

    }
}
