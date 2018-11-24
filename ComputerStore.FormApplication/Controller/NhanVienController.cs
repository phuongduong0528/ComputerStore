using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ComputerStore.Services.Dto;

namespace ComputerStore.FormApplication.Controller
{
    public class NhanVienController
    {
        private string baseUrl;

        public NhanVienController(string ip, int port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/NhanVienService";
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

        public async Task<bool> AddNhanVien(NhanVienDto nhanVien)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/NhanVien";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, DtoSerializer.SerializeNhanVienDto(nhanVien));
            return respond;
        }

        public async Task<bool> EditNhanVien(NhanVienDto nhanVien)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/NhanVien";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.PUT, DtoSerializer.SerializeNhanVienDto(nhanVien));
            return respond;
        }

        public async Task<bool> LockAccount(string pId)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/NhanVien/Lock";
            object obj = new { id = pId };
            bool respond = await controller.SubmitDataJson(RestSharp.Method.PUT, JsonConvert.SerializeObject(obj));
            return respond;
        }

        public async Task<List<NhanVienDto>> GetAllNhanVien()
        {
            RequestController<List<NhanVienDto>> controller = new RequestController<List<NhanVienDto>>();
            controller.Url = baseUrl + "/NhanVien";
            List<NhanVienDto> respond =  await controller.GetData();
            return respond;
        }

        public async Task<NhanVienDto> GetNhanVien(string pId)
        {
            RequestController<NhanVienDto> controller = new RequestController<NhanVienDto>();
            controller.Url = baseUrl + "/NhanVien/" + pId;
            NhanVienDto respond = await controller.GetData();
            return respond;
        }
    }
}
