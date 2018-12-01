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
            string from = "20/1/2018 05:00:00";
            DateTime dtFrom = DateTime.ParseExact(from, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture);
        }
    }
}
