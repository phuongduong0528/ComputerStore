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
        private string url;

        public SellingController(string ip, int port)
        {
            url = $"http://{ip}:{port}/ComputerStore.Services/SellingService";
        }

        public async Task<List<HoaDonDto>> GetAllHoaDon()
        {
            RequestController<List<HoaDonDto>> controller = new RequestController<List<HoaDonDto>>();
            controller.Url = url = "/HoaDon";
            List<HoaDonDto> respond = await controller.GetData();
            return respond;
        }

        public async Task<HoaDonDto> GetHoaDon(string id)
        {
            RequestController<HoaDonDto> controller = new RequestController<HoaDonDto>();
            controller.Url = url = "/HoaDon/" + id;
            HoaDonDto respond = await controller.GetData();
            return respond;
        }

        public async Task<MatHangDuocBanDto> GetMatHangDuocBan(string hdid)
        {
            RequestController<MatHangDuocBanDto> controller = new RequestController<MatHangDuocBanDto>();
            controller.Url = url = "/MHDB/" + hdid;
            MatHangDuocBanDto respond = await controller.GetData();
            return respond;
        }

        public async Task<bool> BanHangAsync(List<MatHangDuocBanDto> pmhdbDtos, string pidNV, string pidKH)
        {
            RequestController<bool> controller = new RequestController<bool>();
            controller.Url = url + "/BanHang";
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
                idKH = pidKH
            };

            bool a = await controller.SubmitDataJson(RestSharp.Method.POST, JsonConvert.SerializeObject(obj));
            return a;
        }
    }
}
