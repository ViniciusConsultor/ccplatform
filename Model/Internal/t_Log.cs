/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.4.1.0 自动创建于 2012/2/11 15:06:22
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;

namespace ZSystem.Model
{
    /// <summary>
    /// 实体类 t_Log，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_Log : ICloneable
    {
        public t_Log()
        { }
        
        /// <summary>
        /// 构造函数 t_Log
        /// </summary>
        /// <param name="iD">ID</param>
        /// <param name="sContent">sContent</param>
        /// <param name="sType">sType</param>
        /// <param name="logTime">LogTime</param>
        public t_Log(string iD, string sContent, string sType, DateTime? logTime)
        {
            this.ID = iD;
            this.sContent = sContent;
            this.sType = sType;
            this.LogTime = logTime;
        }
        
        #region 实体属性
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        
        /// <summary>
        /// sContent
        /// </summary>
        public string sContent { get; set; }
        
        /// <summary>
        /// sType
        /// </summary>
        public string sType { get; set; }
        
        /// <summary>
        /// LogTime
        /// </summary>
        public DateTime? LogTime { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Log model = obj as ZSystem.Model.t_Log;
            if (model != null && model.ID == this.ID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
    