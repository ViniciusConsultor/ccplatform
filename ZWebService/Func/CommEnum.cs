using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZWebService
{
    public class CommEnum
    {
    }
    public enum eUserAuth
    {
        SuperAdmin=1,
        Admin=10,
        Manager=15,
        ClientUser=20,
        User=30
    }

    public enum eSysUserState
    {
        OffLine=0,
        Online=20,
        Leave=10,

        Login=90,
        Logoff=91,
    }
    public enum eLogType
    {
        信息=0,
        警告=1,
        错误=2,

    }


}