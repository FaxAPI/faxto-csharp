# IO.Swagger.Api.FaxSendingApi

All URIs are relative to *https://api.fax.to/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaxDocumentIdCostsGet**](FaxSendingApi.md#faxdocumentidcostsget) | **GET** /fax/{document_id}/costs | This API is for computing the cost of the fax to be sent
[**FaxHistoryGet**](FaxSendingApi.md#faxhistoryget) | **GET** /fax-history | This API gets the history of a fax
[**FaxJobIdStatusGet**](FaxSendingApi.md#faxjobidstatusget) | **GET** /fax/{fax_job_id}/status | This API gets the status of a fax
[**FaxPost**](FaxSendingApi.md#faxpost) | **POST** /fax | This API is for sending a new fax in any fax numbers anywhere in the world
[**FileCleanGet**](FaxSendingApi.md#filecleanget) | **GET** /file-clean | This API is used for cleaning a document
[**FileGeneratePreviewGet**](FaxSendingApi.md#filegeneratepreviewget) | **GET** /file-generate-preview | This API generates a preview of a document
[**FilesDocumentIDDelete**](FaxSendingApi.md#filesdocumentiddelete) | **DELETE** /files/{document_id} | This API deletes a document
[**FilesGet**](FaxSendingApi.md#filesget) | **GET** /files | This API gets all the files of a certain user


<a name="faxdocumentidcostsget"></a>
# **FaxDocumentIdCostsGet**
> InlineResponse2001 FaxDocumentIdCostsGet (int? documentId, string apiKey, string faxNumber = null)

This API is for computing the cost of the fax to be sent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FaxDocumentIdCostsGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var documentId = 56;  // int? | The id of the document to be sent
            var apiKey = apiKey_example;  // string | 
            var faxNumber = faxNumber_example;  // string | The fax number of the recipient (optional) 

            try
            {
                // This API is for computing the cost of the fax to be sent
                InlineResponse2001 result = apiInstance.FaxDocumentIdCostsGet(documentId, apiKey, faxNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FaxDocumentIdCostsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **int?**| The id of the document to be sent | 
 **apiKey** | **string**|  | 
 **faxNumber** | **string**| The fax number of the recipient | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxhistoryget"></a>
# **FaxHistoryGet**
> InlineResponse2003 FaxHistoryGet (string apiKey, string limit = null, string page = null)

This API gets the history of a fax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FaxHistoryGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var apiKey = apiKey_example;  // string | 
            var limit = limit_example;  // string | The number of record to return (optional) 
            var page = page_example;  // string | The page you want to get (optional) 

            try
            {
                // This API gets the history of a fax
                InlineResponse2003 result = apiInstance.FaxHistoryGet(apiKey, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FaxHistoryGet: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxjobidstatusget"></a>
# **FaxJobIdStatusGet**
> InlineResponse2002 FaxJobIdStatusGet (int? faxJobId, string apiKey)

This API gets the status of a fax

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FaxJobIdStatusGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var faxJobId = 56;  // int? | The id of the fax job
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API gets the status of a fax
                InlineResponse2002 result = apiInstance.FaxJobIdStatusGet(faxJobId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FaxJobIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **faxJobId** | **int?**| The id of the fax job | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxpost"></a>
# **FaxPost**
> InlineResponse200 FaxPost ( faxNumber,  documentId, string apiKey)

This API is for sending a new fax in any fax numbers anywhere in the world

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FaxPostExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var faxNumber = new (); //  | The fax number of the recipient
            var documentId = new (); //  | The id of the document to be sent
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API is for sending a new fax in any fax numbers anywhere in the world
                InlineResponse200 result = apiInstance.FaxPost(faxNumber, documentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FaxPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **faxNumber** | [****](.md)| The fax number of the recipient | 
 **documentId** | [****](.md)| The id of the document to be sent | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filecleanget"></a>
# **FileCleanGet**
> InlineResponse2009 FileCleanGet (int? documentId, string apiKey)

This API is used for cleaning a document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FileCleanGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var documentId = 56;  // int? | The id of the document
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API is used for cleaning a document
                InlineResponse2009 result = apiInstance.FileCleanGet(documentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FileCleanGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **int?**| The id of the document | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filegeneratepreviewget"></a>
# **FileGeneratePreviewGet**
> InlineResponse20010 FileGeneratePreviewGet (int? documentId, string apiKey)

This API generates a preview of a document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FileGeneratePreviewGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var documentId = 56;  // int? | The id of the document
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API generates a preview of a document
                InlineResponse20010 result = apiInstance.FileGeneratePreviewGet(documentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FileGeneratePreviewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **int?**| The id of the document | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesdocumentiddelete"></a>
# **FilesDocumentIDDelete**
> InlineResponse20011 FilesDocumentIDDelete (int? documentId, string apiKey)

This API deletes a document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilesDocumentIDDeleteExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var documentId = 56;  // int? | The id of the document
            var apiKey = apiKey_example;  // string | 

            try
            {
                // This API deletes a document
                InlineResponse20011 result = apiInstance.FilesDocumentIDDelete(documentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FilesDocumentIDDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **int?**| The id of the document | 
 **apiKey** | **string**|  | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesget"></a>
# **FilesGet**
> InlineResponse2008 FilesGet (string apiKey, string limit = null, string page = null)

This API gets all the files of a certain user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FilesGetExample
    {
        public void main()
        {
            var apiInstance = new FaxSendingApi();
            var apiKey = apiKey_example;  // string | 
            var limit = limit_example;  // string | The number of record to return (optional) 
            var page = page_example;  // string | The page you want to get (optional) 

            try
            {
                // This API gets all the files of a certain user
                InlineResponse2008 result = apiInstance.FilesGet(apiKey, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxSendingApi.FilesGet: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

