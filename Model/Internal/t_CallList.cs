/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-16 17:11:05
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
    /// 实体类 t_CallList，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_CallList : ICloneable
    {
        public t_CallList()
        { }
        
        /// <summary>
        /// 构造函数 t_CallList
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sCallOutNum">sCallOutNum</param>
        /// <param name="iTimeElapse">iTimeElapse</param>
        /// <param name="iCallUserCH">iCallUserCH</param>
        /// <param name="sysUserID">SysUserID</param>
        /// <param name="clientID">ClientID</param>
        /// <param name="memo">Memo</param>
        /// <param name="callDate">CallDate</param>
        public t_CallList(string keyID, string sCallOutNum, int? iTimeElapse, int? iCallUserCH, string sysUserID, string clientID, string memo, DateTime? callDate)
        {
            this.KeyID = keyID;
            this.sCallOutNum = sCallOutNum;
            this.iTimeElapse = iTimeElapse;
            this.iCallUserCH = iCallUserCH;
            this.SysUserID = sysUserID;
            this.ClientID = clientID;
            this.Memo = memo;
            this.CallDate = callDate;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sCallOutNum
        /// </summary>
        public string sCallOutNum { get; set; }
        
        /// <summary>
        /// iTimeElapse
        /// </summary>
        public int? iTimeElapse { get; set; }
        
        /// <summary>
        /// iCallUserCH
        /// </summary>
        public int? iCallUserCH { get; set; }
        
        /// <summary>
        /// SysUserID
        /// </summary>
        public string SysUserID { get; set; }
        
        /// <summary>
        /// ClientID
        /// </summary>
        public string ClientID { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }
        
        /// <summary>
        /// CallDate
        /// </summary>
        public DateTime? CallDate { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_CallList model = obj as ZSystem.Model.t_CallList;
            if (model != null && model.KeyID == this.KeyID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return KeyID.GetHashCode();
        }
    }
}
    