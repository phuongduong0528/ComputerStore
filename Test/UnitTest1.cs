using System;
using System.Collections.Generic;
using ComputerStore.FormApplication.Controller;
using ComputerStore.Manager.Manager;
using ComputerStore.Manager.Models;
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
            SellingManager sellingManager = new SellingManager();
            MatHangDuocBan matHangDuocBan = new MatHangDuocBan();
            matHangDuocBan.MaSP = "0000000001";
            matHangDuocBan.KhuyenMai = 0;
            List<MatHangDuocBan> list = new List<MatHangDuocBan>();
            list.Add(matHangDuocBan);
            var c = sellingManager.BanHang(list, "0000000001","0000000000");
        }
    }
}
