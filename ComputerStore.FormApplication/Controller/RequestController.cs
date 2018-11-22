﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace ComputerStore.FormApplication.Controller
{
    class RequestController<T>
    {
        private RestClient client;
        private RestRequest request;
        public string Url { get; set; }

        public async Task<T> SubmitData(RestSharp.Method method, object obj)
        {
            client = new RestClient(Url);
            request = new RestRequest(method);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(obj);
            IRestResponse<T> response =
                await client.ExecuteTaskAsync<T>(request);
            return response.Data;
        }

        public async Task<T> SubmitDataJson(RestSharp.Method method, string json)
        {
            client = new RestClient(Url);
            request = new RestRequest(method);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse<T> response =
                await client.ExecuteTaskAsync<T>(request);
            return response.Data;
        }

        public async Task<T> GetData()
        {
            client = new RestClient(Url);
            request = new RestRequest(Method.GET);
            IRestResponse<T> response =
                await client.ExecuteTaskAsync<T>(request);
            return response.Data;
        }
    }
}
