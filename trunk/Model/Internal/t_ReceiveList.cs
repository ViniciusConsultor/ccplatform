/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:07:00
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
    /// 实体类 t_ReceiveList，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_ReceiveList : ICloneable
    {
        public t_ReceiveList()
        { }
        
        /// <summary>
        /// 构造函数 t_ReceiveList
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sCallerID">sCallerID</param>
        /// <param name="clientID">ClientID</param>
        /// <param name="sysUserID">SysUserID</param>
        /// <param name="iTimeElapse">iTimeElapse</param>
        /// <param name="receiveDate">ReceiveDate</param>
        /// <param name="memo">Memo</param>
        public t_ReceiveList(string keyID, string sCallerID, string clientID, string sysUserID, int? iTimeElapse, DateTime? receiveDate, string memo)
        {
            this.KeyID = keyID;
            this.sCallerID = sCallerID;
            this.ClientID = clientID;
            this.SysUserID = sysUserID;
            this.iTimeElapse = iTimeElapse;
            this.ReceiveDate = receiveDate;
            this.Memo = memo;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sCallerID
        /// </summary>
        public string sCallerID { get; set; }
        
        /// <summary>
        /// ClientID
        /// </summary>
        public string ClientID { get; set; }
        
        /// <summary>
        /// SysUserID
        /// </summary>
        public string SysUserID { get; set; }
        
        /// <summary>
        /// iTimeElapse
        /// </summary>
        public int? iTimeElapse { get; set; }
        
        /// <summary>
        /// ReceiveDate
        /// </summary>
        public DateTime? ReceiveDate { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_ReceiveList model = obj as ZSystem.Model.t_ReceiveList;
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
    