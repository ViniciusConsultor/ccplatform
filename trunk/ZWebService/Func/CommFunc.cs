using System;
using System.Collections.Generic;
using System.Linq;

namespace ZWebService
{
    static public class CommFunc
    {

        internal static string DecryptTransString(string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.DecryptKey = DateTime.Now.ToString("yyyy-MM-dd");
            Mydes.InputString = sValue;
            Mydes.DesDecrypt();
            
            return Mydes.OutString;
        }

        internal static string EncryptTransString(string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.EncryptKey = DateTime.Now.ToString("yyyy-MM-dd");
            Mydes.InputString = sValue;
            Mydes.DesEncrypt();

            return Mydes.OutString;
        }

        internal static string EncryptStorageSring(string sKey, string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.EncryptKey = sKey;
            Mydes.InputString = sValue;
            
            Mydes.DesEncrypt();

            return Mydes.OutString;
        }

        internal static string DecryptStorageString(string sKey, string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.DecryptKey = sKey;
            Mydes.InputString = sValue;
            Mydes.DesDecrypt();

            return Mydes.OutString;
        }

    }
}