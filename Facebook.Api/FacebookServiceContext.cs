using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Services.Client;
using System.Runtime;
using System.Net;
using System.Collections.ObjectModel;

namespace Facebook.Api
{
    public class FacebookServiceContext
    {

        public FacebookServiceContext(Uri serviceRoot)
        {
            throw new NotImplementedException();
        }


        public bool ApplyingChanges
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Uri BaseUri
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICredentials Credentials { get; set; }

        public string DataNamespace { get; set; }

        public ReadOnlyCollection<EntityDescriptor> Entities
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IgnoreMissingProperties { get; set; }

        public bool IgnoreResourceNotFoundException { get; set; }

        public ReadOnlyCollection<LinkDescriptor> Links
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MergeOption MergeOption { get; set; }

        public Func<Type, string> ResolveName { get; set; }

        public Func<string, Type> ResolveType { get; set; }

        public SaveChangesOptions SaveChangesDefaultOptions { get; set; }

        public int Timeout { get; set; }

        public Uri TypeScheme { get; set; }

        public bool UsePostTunneling { get; set; }

        public event EventHandler<ReadingWritingEntityEventArgs> ReadingEntity;

        public event EventHandler<SendingRequestEventArgs> SendingRequest;

        public event EventHandler<ReadingWritingEntityEventArgs> WritingEntity;

        public void AddLink(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        public void AddObject(string entitySetName, object entity)
        {
            throw new NotImplementedException();
        }

        public void AddRelatedObject(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void AttachLink(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void AttachTo(string entitySetName, object entity)
        {
            throw new NotImplementedException();
        }

        public void AttachTo(string entitySetName, object entity, string etag)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginExecute<T>(DataServiceQueryContinuation<T> continuation, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginExecute<TElement>(Uri requestUri, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginExecuteBatch(AsyncCallback callback, object state, params DataServiceRequest[] queries)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginGetReadStream(object entity, DataServiceRequestArgs args, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public IAsyncResult BeginLoadProperty(object entity, string propertyName, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginLoadProperty(object entity, string propertyName, DataServiceQueryContinuation continuation, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginLoadProperty(object entity, string propertyName, Uri nextLinkUri, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginSaveChanges(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginSaveChanges(SaveChangesOptions options, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public FacebookServiceQuery<T> CreateQuery<T>(string entitySetName)
        {
            throw new NotImplementedException();
        }

        public void DeleteLink(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        public void DeleteObject(object entity)
        {
            throw new NotImplementedException();
        }

        public bool Detach(object entity)
        {
            throw new NotImplementedException();
        }

        public bool DetachLink(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> EndExecute<TElement>(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse EndExecuteBatch(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public DataServiceStreamResponse EndGetReadStream(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public QueryOperationResponse EndLoadProperty(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse EndSaveChanges(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public QueryOperationResponse<T> Execute<T>(DataServiceQueryContinuation<T> continuation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> Execute<TElement>(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse ExecuteBatch(params DataServiceRequest[] queries)
        {
            throw new NotImplementedException();
        }

        public EntityDescriptor GetEntityDescriptor(object entity)
        {
            throw new NotImplementedException();
        }

        public LinkDescriptor GetLinkDescriptor(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        public Uri GetMetadataUri()
        {
            throw new NotImplementedException();
        }

        public DataServiceStreamResponse GetReadStream(object entity)
        {
            throw new NotImplementedException();
        }

        public DataServiceStreamResponse GetReadStream(object entity, DataServiceRequestArgs args)
        {
            throw new NotImplementedException();
        }

        public DataServiceStreamResponse GetReadStream(object entity, string acceptContentType)
        {
            throw new NotImplementedException();
        }

        public Uri GetReadStreamUri(object entity)
        {
            throw new NotImplementedException();
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public QueryOperationResponse LoadProperty(object entity, string propertyName)
        {
            throw new NotImplementedException();
        }

        public QueryOperationResponse<T> LoadProperty<T>(object entity, string propertyName, DataServiceQueryContinuation<T> continuation)
        {
            throw new NotImplementedException();
        }

        public QueryOperationResponse LoadProperty(object entity, string propertyName, DataServiceQueryContinuation continuation)
        {
            throw new NotImplementedException();
        }

        public QueryOperationResponse LoadProperty(object entity, string propertyName, Uri nextLinkUri)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse SaveChanges(SaveChangesOptions options)
        {
            throw new NotImplementedException();
        }

        public void SetLink(object source, string sourceProperty, object target)
        {
            throw new NotImplementedException();
        }

        public void SetSaveStream(object entity, Stream stream, bool closeStream, DataServiceRequestArgs args)
        {
            throw new NotImplementedException();
        }

        public void SetSaveStream(object entity, Stream stream, bool closeStream, string contentType, string slug)
        {
            throw new NotImplementedException();
        }

        public bool TryGetEntity<TEntity>(Uri identity, out TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public bool TryGetUri(object entity, out Uri identity)
        {
            throw new NotImplementedException();
        }

        public void UpdateObject(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
