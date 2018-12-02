using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityControllers.Controllers;

namespace UtilityUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ทดสอบการดึงข้อมูลzipcode()
        {
            UtilityController service = new UtilityController();
            var result = service.getAmphurData("กรุงเทพมหานคร");
            Assert.IsNotNull(result);
            result = service.getTambonData("กรุงเทพมหานคร", "ดินแดง");
            Assert.IsNotNull(result);
        }
    }
}
