using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
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
            NetworkInterface netInterface = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up
                        && n.NetworkInterfaceType != NetworkInterfaceType.Loopback
                        && !n.Name.Contains("VMware")).FirstOrDefault();

            var gwAddress = netInterface.GetIPProperties().GatewayAddresses.FirstOrDefault().Address.ToString();
        }
    }
}
