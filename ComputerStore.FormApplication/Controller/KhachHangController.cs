using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class KhachHangController
    {
        private string baseUrl;
        public KhachHangController(string ip, int port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/KhachHangService";
        }

        public async Task<bool> AddKhachHang(KhachHangDto khachHangDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/KhachHang";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, DtoSerializer.SerializeKhachHangDto(khachHangDto));
            return respond;
        }

        public async Task<List<KhachHangDto>> GetAllKhachHang()
        {
            RequestController<List<KhachHangDto>> controller = new RequestController<List<KhachHangDto>>();
            controller.Url = baseUrl + "/KhachHang/All";
            List<KhachHangDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<KhachHangDto> GetKhachHang(string id)
        {
            RequestController<KhachHangDto> controller = new RequestController<KhachHangDto>();
            controller.Url = baseUrl + $"/KhachHang{id}";
            KhachHangDto respond = await controller.GetData();
            return respond;
        }
    }
}
