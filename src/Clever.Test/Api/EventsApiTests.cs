/* 
 * Clever API
 *
 * The Clever API
 *
 * OpenAPI spec version: 3.0.0
 * 
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

using Clever.Client;
using Clever.Api;
using Clever.Model;

namespace Clever.Test
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EventsApiTests
    {
        private EventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EventsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventsApi
            //Assert.IsInstanceOfType(typeof(EventsApi), instance, "instance is a EventsApi");
        }

        
        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Test]
        public void GetEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEvent(id);
            //Assert.IsInstanceOf<EventResponse> (response, "response is EventResponse");
        }
        
        /// <summary>
        /// Test GetEvents
        /// </summary>
        [Test]
        public void GetEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //string school = null;
            //List<string> recordType = null;
            //var response = instance.GetEvents(limit, startingAfter, endingBefore, school, recordType);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
    }

}
