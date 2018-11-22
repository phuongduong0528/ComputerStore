﻿using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ComputerStore.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISellingService" in both code and config file together.
    [ServiceContract]
    public interface ISellingService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/HoaDon",
            ResponseFormat = WebMessageFormat.Json)]
        List<HoaDonDto> GetAllHoaDon();

        [OperationContract]
        [WebGet(
            UriTemplate = "/HoaDon/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        HoaDonDto GetHoaDon(string id);

        [OperationContract]
        [WebGet(
            UriTemplate = "/MHDB",
            ResponseFormat = WebMessageFormat.Json)]
        List<MatHangDuocBanDto> GetMatHangDuocBan(string idHD);

        //[OperationContract]
        //[WebGet(
        //    UriTemplate = "/MHDB/{id}/{km}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //MatHangDuocBanDto CreateTempMatHangDuocBan(string id, int km);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/BanHang",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json)]
        bool BanHang(List<MatHangDuocBanDto> mhdbDtos, string idNV, string idKH);
    }
}