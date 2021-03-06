/* 
 * Fax.to REST API client for C#
 *
 * This is Fax.to REST API client for C#.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: inquiries@fax.to
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This API creates a subuser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 SubUserPost ( email,  password, string apiKey);

        /// <summary>
        /// This API creates a subuser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> SubUserPostWithHttpInfo ( email,  password, string apiKey);
        /// <summary>
        /// This API is used for logging in on an existing user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserLoginPost ( email,  password);

        /// <summary>
        /// This API is used for logging in on an existing user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> UserLoginPostWithHttpInfo ( email,  password);
        /// <summary>
        /// This API registers a new user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserPost ( email,  password);

        /// <summary>
        /// This API registers a new user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> UserPostWithHttpInfo ( email,  password);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This API creates a subuser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> SubUserPostAsync ( email,  password, string apiKey);

        /// <summary>
        /// This API creates a subuser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> SubUserPostAsyncWithHttpInfo ( email,  password, string apiKey);
        /// <summary>
        /// This API is used for logging in on an existing user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> UserLoginPostAsync ( email,  password);

        /// <summary>
        /// This API is used for logging in on an existing user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UserLoginPostAsyncWithHttpInfo ( email,  password);
        /// <summary>
        /// This API registers a new user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> UserPostAsync ( email,  password);

        /// <summary>
        /// This API registers a new user account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UserPostAsyncWithHttpInfo ( email,  password);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserManagementApi : IUserManagementApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserManagementApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserManagementApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This API creates a subuser 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 SubUserPost ( email,  password, string apiKey)
        {
             ApiResponse<InlineResponse2006> localVarResponse = SubUserPostWithHttpInfo(email, password, apiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This API creates a subuser 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > SubUserPostWithHttpInfo ( email,  password, string apiKey)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->SubUserPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->SubUserPost");
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling UserManagementApi->SubUserPost");

            var localVarPath = "/subuser";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubUserPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// This API creates a subuser 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> SubUserPostAsync ( email,  password, string apiKey)
        {
             ApiResponse<InlineResponse2006> localVarResponse = await SubUserPostAsyncWithHttpInfo(email, password, apiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This API creates a subuser 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the subuser</param>
        /// <param name="apiKey"></param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> SubUserPostAsyncWithHttpInfo ( email,  password, string apiKey)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->SubUserPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->SubUserPost");
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling UserManagementApi->SubUserPost");

            var localVarPath = "/subuser";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubUserPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// This API is used for logging in on an existing user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 UserLoginPost ( email,  password)
        {
             ApiResponse<InlineResponse2005> localVarResponse = UserLoginPostWithHttpInfo(email, password);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This API is used for logging in on an existing user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > UserLoginPostWithHttpInfo ( email,  password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->UserLoginPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->UserLoginPost");

            var localVarPath = "/user/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UserLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// This API is used for logging in on an existing user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> UserLoginPostAsync ( email,  password)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await UserLoginPostAsyncWithHttpInfo(email, password);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This API is used for logging in on an existing user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UserLoginPostAsyncWithHttpInfo ( email,  password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->UserLoginPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->UserLoginPost");

            var localVarPath = "/user/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UserLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// This API registers a new user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 UserPost ( email,  password)
        {
             ApiResponse<InlineResponse2005> localVarResponse = UserPostWithHttpInfo(email, password);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This API registers a new user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > UserPostWithHttpInfo ( email,  password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->UserPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->UserPost");

            var localVarPath = "/user";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UserPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// This API registers a new user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> UserPostAsync ( email,  password)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await UserPostAsyncWithHttpInfo(email, password);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This API registers a new user account 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The unique email of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UserPostAsyncWithHttpInfo ( email,  password)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserManagementApi->UserPost");
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserManagementApi->UserPost");

            var localVarPath = "/user";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (password != null && password.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(password); // http body (model) parameter
            }
            else
            {
                localVarPostBody = password; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UserPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

    }
}
