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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMatHangService" in both code and config file together.
    [ServiceContract]
    public interface IMatHangService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/MatHang",
            ResponseFormat = WebMessageFormat.Json)]
        List<MatHangDto> GetAllMatHang();

        [OperationContract]
        [WebGet(
            UriTemplate = "/MatHang/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        MatHangDto GetMatHang(string id);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/MatHang",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddMatHang(MatHangDto matHangDto);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/MatHang",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json)]
        bool EditMatHang(MatHangDto matHangDto);

        [OperationContract]
        [WebGet(
            UriTemplate = "/SanPham",
            ResponseFormat = WebMessageFormat.Json)]
        List<SanPhamDto> GetAllSanPham();

        [OperationContract]
        [WebGet(
            UriTemplate = "/SanPham/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        SanPhamDto GetSanPham(string id);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/SanPham",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddSanPham(SanPhamDto sanPhamDto);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/SanPham",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json)]
        bool EditSanPham(SanPhamDto sanPhamDto);
    }
}
