/* 
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Api.Client.Sdk.Client;
using Api.Client.Sdk.Api;
using Api.Client.Sdk.Model;

namespace Api.Client.Sdk.Test
{
    /// <summary>
    ///  Class for testing WeatherForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WeatherForecastApiTests : IDisposable
    {
        private WeatherForecastApi instance;

        public WeatherForecastApiTests()
        {
            instance = new WeatherForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WeatherForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WeatherForecastApi
            //Assert.IsType(typeof(WeatherForecastApi), instance, "instance is a WeatherForecastApi");
        }

        
        /// <summary>
        /// Test WeatherForecastGet
        /// </summary>
        [Fact]
        public void WeatherForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WeatherForecastGet();
            //Assert.IsType<List<WeatherForecast>> (response, "response is List<WeatherForecast>");
        }
        
    }

}