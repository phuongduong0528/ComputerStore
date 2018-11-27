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
            //SellingService sellingService = new SellingService();
            //MatHangService matHangService = new MatHangService();
            //var x = sellingService.GetHoaDonFilter("0","01/01/1900","28/11/2018");
            DateTime d = DateTime.Now;
            var y = d.ToString(@"dd/MM/yyyy HH\:mm\:ss");
            d = DateTime.ParseExact("27/11/2018 00:00:59", @"dd/MM/yyyy HH\:mm\:ss",CultureInfo.InvariantCulture);
        }
    }
}
