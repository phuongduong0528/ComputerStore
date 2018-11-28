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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKhachHangService" in both code and config file together.
    [ServiceContract]
    public interface IKhachHangService
    {
        [OperationContract]
        [WebInvoke(
            UriTemplate = "/KhachHang",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddKhachHang(KhachHangDto khachHangDto);

        [OperationContract]
        [WebGet(
            UriTemplate = "/KhachHang/All",
            ResponseFormat = WebMessageFormat.Json)]
        List<KhachHangDto> GetAllKhachHang();

        [OperationContract]
        [WebGet(
            UriTemplate = "/KhachHang/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        KhachHangDto GetKhachHang(string id);
    }
}
