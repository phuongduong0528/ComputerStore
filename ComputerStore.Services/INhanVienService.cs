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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INhanVienService" in both code and config file together.
    [ServiceContract]
    public interface INhanVienService
    {
        [OperationContract]
        [WebInvoke(
            UriTemplate = "/Auth",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        int Authenticate(string id, string pass);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/NhanVien",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddNhanVien(NhanVienDto nhanVien);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/NhanVien",
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json)]
        bool EditNhanVien(NhanVienDto nhanVien);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/NhanVien/Lock",
            Method = "PUT",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        bool LockAccount(string id);

        [OperationContract]
        [WebGet(
            UriTemplate = "/NhanVien",
            ResponseFormat = WebMessageFormat.Json)]
        List<NhanVienDto> GetAllNhanVien();

        [OperationContract]
        [WebGet(
            UriTemplate = "/NhanVien/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        NhanVienDto GetNhanVien(string id);
    }
}
