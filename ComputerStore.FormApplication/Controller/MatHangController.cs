using ComputerStore.Services.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class MatHangController
    {
        private string baseUrl;

        public MatHangController(string ip, int port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/MatHangService";
        }

        public async Task<List<MatHangDto>> GetAllMatHang()
        {
            RequestController<List<MatHangDto>> controller = new RequestController<List<MatHangDto>>();
            controller.Url = baseUrl + "/MatHang";
            List<MatHangDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<MatHangDto> GetMatHang(string id)
        {
            RequestController<MatHangDto> controller = new RequestController<MatHangDto>();
            controller.Url = baseUrl + "/MatHang/" + id;
            MatHangDto respond = await controller.GetData();
            return respond;
        }

        public async Task<bool> AddMatHang(MatHangDto matHangDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/MatHang/";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, DtoSerializer.SerializeMatHangDto(matHangDto));
            return respond;
        }

        public async Task<bool> EditMatHang(MatHangDto matHangDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/MatHang/";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.PUT, DtoSerializer.SerializeMatHangDto(matHangDto));
            return respond;
        }

        public async Task<List<SanPhamDto>> GetAllSanPham()
        {
            RequestController<List<SanPhamDto>> controller = new RequestController<List<SanPhamDto>>();
            controller.Url = baseUrl + "/SanPham";
            List<SanPhamDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<List<SanPhamDto>> GetSanPhamByMatHang(string pidmh, int pstatus)
        {
            RequestController<List<SanPhamDto>> controller = new RequestController<List<SanPhamDto>>();
            controller.Url = baseUrl + $"/SanPham/Filter";
            object obj = new
            {
                idmh = pidmh,
                status = pstatus
            };
            List<SanPhamDto> respond =
                await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return respond;
        }

        public async Task<List<MatHangDto>> GetMatHangFilter(string pname, string plh, string phsx)
        {
            RequestController<List<MatHangDto>> controller = new RequestController<List<MatHangDto>>();
            controller.Url = baseUrl + $"/MatHang/Filter";
            object obj = new
            {
                name = pname,
                lh = plh,
                hsx = phsx
            };
            List<MatHangDto> respond = 
                await controller.SubmitDataJson(RestSharp.Method.POST,JsonConvert.SerializeObject(obj));
            return respond;
        }

        public async Task<SanPhamDto> GetSanPham(string id)
        {
            RequestController<SanPhamDto> controller = new RequestController<SanPhamDto>();
            controller.Url = baseUrl + "/SanPham/" + id;
            SanPhamDto respond = await controller.GetData();
            return respond;
        }

        public async Task<bool> AddSanPham(SanPhamDto sanPhamDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/SanPham";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.POST, DtoSerializer.SerializeSanPhamDto(sanPhamDto));
            return respond;
        }

        public async Task<bool> EditSanPham(SanPhamDto sanPhamDto)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/SanPham";
            bool respond = await controller.SubmitDataJson(RestSharp.Method.PUT, DtoSerializer.SerializeSanPhamDto(sanPhamDto));
            return respond;
        }
    }
}
