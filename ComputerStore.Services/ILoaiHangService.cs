using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ComputerStore.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoaiHangService" in both code and config file together.
    [ServiceContract]
    public interface ILoaiHangService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/LoaiHang",
            ResponseFormat = WebMessageFormat.Json)]
        List<LoaiHangDto> GetAllLoaiHang();

        [OperationContract]
        [WebGet(
            UriTemplate = "/NhaPhanPhoi",
            ResponseFormat = WebMessageFormat.Json)]
        List<NhaPhanPhoiDto> GetAllNhaPhanPhoi();

        [OperationContract]
        [WebGet(
            UriTemplate = "/HSX",
            ResponseFormat = WebMessageFormat.Json)]
        List<HangSanXuatDto> GetAllHangSanXuat();

        [OperationContract]
        [WebGet(
            UriTemplate = "/LoaiHang/{id}",
            RequestFormat = WebMessageFormat.Json)]
        LoaiHangDto GetLoaiHang(string id);

        [OperationContract]
        [WebGet(
            UriTemplate = "/NhaPhanPhoi/{id}",
            RequestFormat = WebMessageFormat.Json)]
        NhaPhanPhoiDto GetNhaPhanPhoi(string id);

        [OperationContract]
        [WebGet(
            UriTemplate = "/HSX/{id}",
            RequestFormat = WebMessageFormat.Json)]
        HangSanXuatDto GetHangSanXuat(string id);

        [WebInvoke(
            UriTemplate = "/NhaPhanPhoi",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddNhaPhanPhoi(NhaPhanPhoiDto nhaPhanPhoiDto);
    }
}
