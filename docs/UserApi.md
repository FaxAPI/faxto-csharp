# IO.Swagger.Api.UserApi

All URIs are relative to *https://api.fax.to/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BalanceGet**](UserApi.md#balanceget) | **GET** /balance | This API gets the balance of a user account


<a name="balanceget"></a>
# **BalanceGet**
> InlineResponse2007 BalanceGet (string apiKey)

This API gets the balance of a user account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BalanceGetExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets the balance of a user account
                InlineResponse2007 result = apiInstance.BalanceGet(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.BalanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

