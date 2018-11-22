using System;
using ComputerStore.Manager.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NhanVienManager nhanVienManager = new NhanVienManager();
            var result = nhanVienManager.LockAccount("0000000001");
        }
    }
}
