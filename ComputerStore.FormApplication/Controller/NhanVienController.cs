using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ComputerStore.FormApplication.Controller
{
    public class NhanVienController
    {
        private string baseUrl;

        public NhanVienController(string ip, string port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/NhanVienService/";
        }

        public async Task<int> Authenticate(string pId, string pPass)
        {
            RequestController<int> controller = new RequestController<int>();
            controller.Url = baseUrl + "/Auth";
            object obj = new
            {
                id = pId,
                pass = pPass
            };
            int respond = await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return respond;
        }
    }
}
