# Api.Client.Sdk.Api.WeatherForecastApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WeatherForecastGet**](WeatherForecastApi.md#weatherforecastget) | **GET** /WeatherForecast | 


<a name="weatherforecastget"></a>
# **WeatherForecastGet**
> List&lt;WeatherForecast&gt; WeatherForecastGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api.Client.Sdk.Api;
using Api.Client.Sdk.Client;
using Api.Client.Sdk.Model;

namespace Example
{
    public class WeatherForecastGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WeatherForecastApi(config);

            try
            {
                List<WeatherForecast> result = apiInstance.WeatherForecastGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WeatherForecastApi.WeatherForecastGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;WeatherForecast&gt;**](WeatherForecast.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

