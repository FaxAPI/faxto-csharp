# IO.Swagger.Api.FaxReceivingApi

All URIs are relative to *https://api.fax.to/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AreaCodesCountryCodeStateIdGet**](FaxReceivingApi.md#areacodescountrycodestateidget) | **GET** /areacodes/{COUNTRY_CODE}/{STATE_ID} | This API gets a list of countries with its area code
[**CountriesCountryCodeDidGroupsGet**](FaxReceivingApi.md#countriescountrycodedidgroupsget) | **GET** /countries/{countryCode}/didgroups | This API gets a list of DID groups
[**CountriesGet**](FaxReceivingApi.md#countriesget) | **GET** /countries | This API gets a list of countries available in the Fax.to coverage
[**IncomingFaxesGet**](FaxReceivingApi.md#incomingfaxesget) | **GET** /incoming-faxes | This API gets a list of incoming faxes
[**IncomingFaxesRecipientGet**](FaxReceivingApi.md#incomingfaxesrecipientget) | **GET** /incoming-faxes/{recipient} | This API gets a list of incoming faxes for a specific recipient
[**NumbersGet**](FaxReceivingApi.md#numbersget) | **GET** /numbers | This API gets a list of numbers to get the current configuration of one or multiple number
[**ProvisionNumbersGet**](FaxReceivingApi.md#provisionnumbersget) | **GET** /countries/didgroups/{did_group_id}/provision | This API gets a list of provisioned numbers
[**StatesCountryCodeGet**](FaxReceivingApi.md#statescountrycodeget) | **GET** /states/{COUNTRY_CODE} | This API gets a list of states of a given country available in the Fax.to coverage


<a name="areacodescountrycodestateidget"></a>
# **AreaCodesCountryCodeStateIdGet**
> InlineResponse20014 AreaCodesCountryCodeStateIdGet (int? COUNTRY_CODE, int? STATE_ID, string apiKey)

This API gets a list of countries with its area code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AreaCodesCountryCodeStateIdGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var COUNTRY_CODE = 56;  // int? | Indicates the country code in its ISO 3166-1 alpha-3 format
            var STATE_ID = 56;  // int? | The numerical identifier for the state
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets a list of countries with its area code
                InlineResponse20014 result = apiInstance.AreaCodesCountryCodeStateIdGet(COUNTRY_CODE, STATE_ID, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.AreaCodesCountryCodeStateIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **COUNTRY_CODE** | **int?**| Indicates the country code in its ISO 3166-1 alpha-3 format | 
 **STATE_ID** | **int?**| The numerical identifier for the state | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countriescountrycodedidgroupsget"></a>
# **CountriesCountryCodeDidGroupsGet**
> InlineResponse20015 CountriesCountryCodeDidGroupsGet (int? COUNTRY_CODE, int? areaCode, string apiKey, int? didGroupIds = null, int? stateId = null, int? cityNamePattern = null)

This API gets a list of DID groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountriesCountryCodeDidGroupsGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var COUNTRY_CODE = 56;  // int? | Indicates the country code of the DID group in its ISO 3166-1 alpha-3 format
            var areaCode = 56;  // int? | The area code of the DID group
            var apiKey = apiKey_example;  // string | 
            var didGroupIds = 56;  // int? | Used to display more information about specific DID groups (optional) 
            var stateId = 56;  // int? | The numerical identifier for the didGroup's state (optional) 
            var cityNamePattern = 56;  // int? | A string pattern for the beginning of city name (optional) 

            try
            {
                // This API gets a list of DID groups
                InlineResponse20015 result = apiInstance.CountriesCountryCodeDidGroupsGet(COUNTRY_CODE, areaCode, apiKey, didGroupIds, stateId, cityNamePattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.CountriesCountryCodeDidGroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **COUNTRY_CODE** | **int?**| Indicates the country code of the DID group in its ISO 3166-1 alpha-3 format | 
 **areaCode** | **int?**| The area code of the DID group | 
 **apiKey** | **string**|  | 
 **didGroupIds** | **int?**| Used to display more information about specific DID groups | [optional] 
 **stateId** | **int?**| The numerical identifier for the didGroup&#39;s state | [optional] 
 **cityNamePattern** | **int?**| A string pattern for the beginning of city name | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countriesget"></a>
# **CountriesGet**
> InlineResponse20012 CountriesGet (string apiKey)

This API gets a list of countries available in the Fax.to coverage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountriesGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets a list of countries available in the Fax.to coverage
                InlineResponse20012 result = apiInstance.CountriesGet(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.CountriesGet: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomingfaxesget"></a>
# **IncomingFaxesGet**
> InlineResponse2004 IncomingFaxesGet (string apiKey, string limit = null, string page = null)

This API gets a list of incoming faxes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IncomingFaxesGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var apiKey = apiKey_example;  // string | 
            var limit = limit_example;  // string | The number of record to return (optional) 
            var page = page_example;  // string | The page you want to get (optional) 

            try
            {
                // This API gets a list of incoming faxes
                InlineResponse2004 result = apiInstance.IncomingFaxesGet(apiKey, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.IncomingFaxesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **limit** | **string**| The number of record to return | [optional] 
 **page** | **string**| The page you want to get | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomingfaxesrecipientget"></a>
# **IncomingFaxesRecipientGet**
> InlineResponse2004 IncomingFaxesRecipientGet (int? recipient, string apiKey, string limit = null, string page = null)

This API gets a list of incoming faxes for a specific recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IncomingFaxesRecipientGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var recipient = 56;  // int? | The recipient's fax number
            var apiKey = apiKey_example;  // string | 
            var limit = limit_example;  // string | The number of record to return (optional) 
            var page = page_example;  // string | The page you want to get (optional) 

            try
            {
                // This API gets a list of incoming faxes for a specific recipient
                InlineResponse2004 result = apiInstance.IncomingFaxesRecipientGet(recipient, apiKey, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.IncomingFaxesRecipientGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipient** | **int?**| The recipient&#39;s fax number | 
 **apiKey** | **string**|  | 
 **limit** | **string**| The number of record to return | [optional] 
 **page** | **string**| The page you want to get | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="numbersget"></a>
# **NumbersGet**
> InlineResponse20017 NumbersGet (string apiKey, string limit = null, string page = null)

This API gets a list of numbers to get the current configuration of one or multiple number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NumbersGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var apiKey = apiKey_example;  // string | 
            var limit = limit_example;  // string | The number of record to return (optional) 
            var page = page_example;  // string | The page you want to get (optional) 

            try
            {
                // This API gets a list of numbers to get the current configuration of one or multiple number
                InlineResponse20017 result = apiInstance.NumbersGet(apiKey, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.NumbersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **limit** | **string**| The number of record to return | [optional] 
 **page** | **string**| The page you want to get | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="provisionnumbersget"></a>
# **ProvisionNumbersGet**
> InlineResponse20016 ProvisionNumbersGet (int? didGroupId, string apiKey)

This API gets a list of provisioned numbers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProvisionNumbersGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var didGroupId = 56;  // int? | The id of the did group
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets a list of provisioned numbers
                InlineResponse20016 result = apiInstance.ProvisionNumbersGet(didGroupId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.ProvisionNumbersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **didGroupId** | **int?**| The id of the did group | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statescountrycodeget"></a>
# **StatesCountryCodeGet**
> InlineResponse20013 StatesCountryCodeGet (int? COUNTRY_CODE, string apiKey)

This API gets a list of states of a given country available in the Fax.to coverage

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StatesCountryCodeGetExample
    {
        public void main()
        {
            var apiInstance = new FaxReceivingApi();
            var COUNTRY_CODE = 56;  // int? | Indicates the country code in its ISO 3166-1 alpha-3 format
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets a list of states of a given country available in the Fax.to coverage
                InlineResponse20013 result = apiInstance.StatesCountryCodeGet(COUNTRY_CODE, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxReceivingApi.StatesCountryCodeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **COUNTRY_CODE** | **int?**| Indicates the country code in its ISO 3166-1 alpha-3 format | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

