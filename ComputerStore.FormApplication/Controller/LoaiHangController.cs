using ComputerStore.Services.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class LoaiHangController
    {
        private string baseUrl;

        public LoaiHangController(string ip, int port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/LoaiHangService";
        }

        public async Task<List<LoaiHangDto>> GetAllLoaiHang()
        {
            RequestController<List<LoaiHangDto>> controller = new RequestController<List<LoaiHangDto>>();
            controller.Url = baseUrl + "/LoaiHang";
            List<LoaiHangDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<List<NhaPhanPhoiDto>> GetAllNhaPhanPhoi()
        {
            RequestController<List<NhaPhanPhoiDto>> controller = new RequestController<List<NhaPhanPhoiDto>>();
            controller.Url = baseUrl + "/NhaPhanPhoi";
            List<NhaPhanPhoiDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<List<HangSanXuatDto>> GetAllHangSanXuat()
        {
            RequestController<List<HangSanXuatDto>> controller = new RequestController<List<HangSanXuatDto>>();
            controller.Url = baseUrl + "/HSX";
            List<HangSanXuatDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<LoaiHangDto> GetLoaiHang(string id)
        {
            RequestController<LoaiHangDto> controller = new RequestController<LoaiHangDto>();
            controller.Url = baseUrl + "/LoaiHang/{id}";
            LoaiHangDto respond = await controller.GetData();
            return respond;
        }

        public async Task<NhaPhanPhoiDto> GetNhaPhanPhoi(string id)
        {
            RequestController<NhaPhanPhoiDto> controller = new RequestController<NhaPhanPhoiDto>();
            controller.Url = baseUrl + "/NhaPhanPhoi/{id}";
            NhaPhanPhoiDto respond = await controller.GetData();
            return respond;
        }

        public async Task<HangSanXuatDto> GetHangSanXuat(string id)
        {
            RequestController<HangSanXuatDto> controller = new RequestController<HangSanXuatDto>();
            controller.Url = baseUrl + "/HangSanXuat/{id}";
            HangSanXuatDto respond = await controller.GetData();
            return respond;
        }

        public async Task<bool> AddNhaPhanPhoi(NhaPhanPhoiDto nhaPhanPhoiDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/NhaPhanPhoi";
            //bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(nhaPhanPhoiDto));
            bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, DtoSerializer.SerializeNhaPhanPhoiDto(nhaPhanPhoiDto));
            return respond;
        }

    }
}
