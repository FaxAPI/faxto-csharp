# IO.Swagger.Api.UserManagementApi

All URIs are relative to *https://api.fax.to/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubUserPost**](UserManagementApi.md#subuserpost) | **POST** /subuser | This API creates a subuser
[**UserLoginPost**](UserManagementApi.md#userloginpost) | **POST** /user/login | This API is used for logging in on an existing user account
[**UserPost**](UserManagementApi.md#userpost) | **POST** /user | This API registers a new user account


<a name="subuserpost"></a>
# **SubUserPost**
> InlineResponse2006 SubUserPost ( email,  password, string apiKey)

This API creates a subuser

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubUserPostExample
    {
        public void main()
        {
            var apiInstance = new UserManagementApi();
            var email = new (); //  | The unique email of the user
            var password = new (); //  | The password of the subuser
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API creates a subuser
                InlineResponse2006 result = apiInstance.SubUserPost(email, password, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserManagementApi.SubUserPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [****](.md)| The unique email of the user | 
 **password** | [****](.md)| The password of the subuser | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userloginpost"></a>
# **UserLoginPost**
> InlineResponse2005 UserLoginPost ( email,  password)

This API is used for logging in on an existing user account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserLoginPostExample
    {
        public void main()
        {
            var apiInstance = new UserManagementApi();
            var email = new (); //  | The unique email of the user
            var password = new (); //  | The password of the user

            try
            {
                // This API is used for logging in on an existing user account
                InlineResponse2005 result = apiInstance.UserLoginPost(email, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserManagementApi.UserLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [****](.md)| The unique email of the user | 
 **password** | [****](.md)| The password of the user | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userpost"></a>
# **UserPost**
> InlineResponse2005 UserPost ( email,  password)

This API registers a new user account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPostExample
    {
        public void main()
        {
            var apiInstance = new UserManagementApi();
            var email = new (); //  | The unique email of the user
            var password = new (); //  | The password of the user

            try
            {
                // This API registers a new user account
                InlineResponse2005 result = apiInstance.UserPost(email, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserManagementApi.UserPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [****](.md)| The unique email of the user | 
 **password** | [****](.md)| The password of the user | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

