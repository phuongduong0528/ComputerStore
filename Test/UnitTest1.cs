using System;
using System.Collections.Generic;
using System.Globalization;
using ComputerStore.FormApplication.Controller;
using ComputerStore.Manager.Manager;
using ComputerStore.Manager.Models;
using ComputerStore.Services;
using ComputerStore.Services.Adaptor;
using ComputerStore.Services.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            KhachHangDto khdto = new KhachHangDto();
            khdto.TenKH = "Nguyen Van Ba";
            khdto.NgaySinh = "12/12/1995";
            khdto.DiaChi = "Ha Noi";
            khdto.Email = "ba987@yahoo.com";
            khdto.Sdt = "0987412563";
            KhachHangService khachHangService = new KhachHangService();
            khachHangService.AddKhachHang(khdto);
        }
    }
}
