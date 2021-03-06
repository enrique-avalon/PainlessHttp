﻿using System.Threading.Tasks;
using PainlessHttp.Http;
using PainlessHttp.Http.Contracts;

namespace PainlessHttp.Client.Contracts
{
	interface IHttpClient
	{
		IHttpResponse<T> Get<T>(string url, object query = null) where T : class;
		Task<IHttpResponse<T>> GetAsync<T>(string url, object query = null) where T : class;

		IHttpResponse<T> Post<T>(string url, object data, object query = null, ContentType type = ContentType.Negotiated) where T : class;
		Task<IHttpResponse<T>> PostAsync<T>(string url, object data, object query = null, ContentType type = ContentType.Negotiated) where T : class;

		IHttpResponse<T> Put<T>(string url, object data, object query = null, ContentType type = ContentType.Negotiated) where T : class;
		Task<IHttpResponse<T>> PutAsync<T>(string url, object data, object query = null, ContentType type = ContentType.Negotiated) where T : class;

		IHttpResponse<T> Delete<T>(string url, object data = null, object query = null, ContentType type = ContentType.Negotiated) where T : class;
		Task<IHttpResponse<T>> DeleteAsync<T>(string url, object data = null, object query = null, ContentType type = ContentType.Negotiated) where T : class;
	}
}	
