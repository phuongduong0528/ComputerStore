using System;
using ComputerStore.FormApplication.Controller;
using ComputerStore.Services.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient("http://localhost:8733/ComputerStore.Services/NhanVienService/NhanVien/0000000001");
            var request = new RestRequest(Method.GET);
            IRestResponse<NhanVienDto> response  = client.Execute<NhanVienDto>(request);
            var result = response.Data;
        }
    }
}
