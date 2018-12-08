using ComputerStore.Services.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class SellingController
    {
        private string baseUrl;

        public SellingController(string ip, int port)
        {
            baseUrl = $"http://{ip}:{port}/ComputerStore.Services/SellingService";
        }

        public async Task<List<HoaDonDto>> GetAllHoaDon()
        {
            RequestController<List<HoaDonDto>> controller = new RequestController<List<HoaDonDto>>();
            controller.Url = baseUrl + "/HoaDon";
            List<HoaDonDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<List<HoaDonDto>> GetHoaDonFilter(string pmahd, string pfrom, string pto)
        {
            RequestController<List<HoaDonDto>> controller = new RequestController<List<HoaDonDto>>();
            controller.Url = baseUrl + "/HoaDonFilter";
            object obj = new
            {
                mahd = pmahd,
                from = pfrom,
                to = pto
            };
            List<HoaDonDto> respond = 
                await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return respond;
        }

        public async Task<HoaDonDto> GetHoaDon(string id)
        {
            RequestController<HoaDonDto> controller = new RequestController<HoaDonDto>();
            controller.Url = baseUrl + "/HoaDon/" + id;
            HoaDonDto respond = await controller.GetData();
            return respond;
        }

        public async Task<List<MatHangDuocBanDto>> GetMatHangDuocBan(string hdid)
        {
            RequestController<List<MatHangDuocBanDto>> controller = new RequestController<List<MatHangDuocBanDto>>();
            controller.Url = baseUrl + "/MHDB/" + hdid;
            List<MatHangDuocBanDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<bool> BanHangAsync(List<MatHangDuocBanDto> pmhdbDtos, string pidNV, string pidKH, long ptienkhachtra)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = baseUrl + "/BanHang";
            List<object> list = new List<object>();
            foreach(MatHangDuocBanDto mhdb in pmhdbDtos)
            {
                object o = new
                {
                    id = mhdb.ID,
                    tensp = mhdb.TenSP,
                    serial = mhdb.Serial,
                    khuyenmai = mhdb.KhuyenMai,
                    gia = mhdb.KhuyenMai,
                    mahd = mhdb.MaHD,
                    masp = mhdb.MaSP
                };
                list.Add(o);
            }

            object obj = new
            {
                mhdbDtos = list,
                idNV = pidNV,
                idKH = pidKH,
                tienkhachtra = ptienkhachtra
            };
            var test = JsonConvert.SerializeObject(obj);
            bool a = await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return a;
        }

        public async Task<List<BaoHanhDto>> GetBaoHanhByKhachHang(string pmakh)
        {
            RequestController<List<BaoHanhDto>> controller = new RequestController<List<BaoHanhDto>>();
            controller.Url = baseUrl + "/BaoHanh/" + pmakh;
            List<BaoHanhDto> respond =  await controller.GetData();
            return respond;
        }

        public async Task<List<MatHangDuocBanDto>> GetMatHangDuocBanByTime(int pmonth, int pyear)
        {
            RequestController<List<MatHangDuocBanDto>> controller = new RequestController<List<MatHangDuocBanDto>>();
            controller.Url = baseUrl + $"/MHDB/Time";
            object obj = new
            {
                month = pmonth,
                year = pyear
            };
            List<MatHangDuocBanDto> respond = await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return respond;
        }
    }
}
