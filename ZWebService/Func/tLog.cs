using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tLog
    {
        static ZSystem.BLL.t_Log bLog = new ZSystem.BLL.t_Log();
        static public void AddLog(string sContent, eLogType LogType)
        {
            if (string.IsNullOrEmpty(sContent))
                return;

            t_Log mLog = new t_Log();
            mLog.ID = "Log:" + DateTime.Now.Ticks;
            mLog.LogTime = DateTime.Now;
            mLog.sContent = sContent;
            mLog.sType = LogType.ToString();

            bLog.Add(mLog);


        }

    }
}