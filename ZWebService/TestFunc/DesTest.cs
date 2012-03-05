using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace ZWebService.TestFunc
{
    [TestFixture]
    public class DesTest
    {
        [Test]
        public void TestDesEncy()
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.EncryptKey = "Client2";
            Mydes.InputString = "1234567890";
            
            Mydes.DesEncrypt();

            string sResult = Mydes.OutString;

            Assert.IsNotNullOrEmpty(sResult);
        }
    }
}