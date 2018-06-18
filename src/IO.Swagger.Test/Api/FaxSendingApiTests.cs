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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FaxSendingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FaxSendingApiTests
    {
        private FaxSendingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxSendingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaxSendingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FaxSendingApi
            //Assert.IsInstanceOfType(typeof(FaxSendingApi), instance, "instance is a FaxSendingApi");
        }

        
        /// <summary>
        /// Test FaxDocumentIdCostsGet
        /// </summary>
        [Test]
        public void FaxDocumentIdCostsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? documentId = null;
            //string apiKey = null;
            //string faxNumber = null;
            //var response = instance.FaxDocumentIdCostsGet(documentId, apiKey, faxNumber);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test FaxHistoryGet
        /// </summary>
        [Test]
        public void FaxHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string limit = null;
            //string page = null;
            //var response = instance.FaxHistoryGet(apiKey, limit, page);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test FaxJobIdStatusGet
        /// </summary>
        [Test]
        public void FaxJobIdStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? faxJobId = null;
            //string apiKey = null;
            //var response = instance.FaxJobIdStatusGet(faxJobId, apiKey);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test FaxPost
        /// </summary>
        [Test]
        public void FaxPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            // faxNumber = null;
            // documentId = null;
            //string apiKey = null;
            //var response = instance.FaxPost(faxNumber, documentId, apiKey);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test FileCleanGet
        /// </summary>
        [Test]
        public void FileCleanGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? documentId = null;
            //string apiKey = null;
            //var response = instance.FileCleanGet(documentId, apiKey);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test FileGeneratePreviewGet
        /// </summary>
        [Test]
        public void FileGeneratePreviewGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? documentId = null;
            //string apiKey = null;
            //var response = instance.FileGeneratePreviewGet(documentId, apiKey);
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
        /// <summary>
        /// Test FilesDocumentIDDelete
        /// </summary>
        [Test]
        public void FilesDocumentIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? documentId = null;
            //string apiKey = null;
            //var response = instance.FilesDocumentIDDelete(documentId, apiKey);
            //Assert.IsInstanceOf<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test FilesGet
        /// </summary>
        [Test]
        public void FilesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string limit = null;
            //string page = null;
            //var response = instance.FilesGet(apiKey, limit, page);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
    }

}