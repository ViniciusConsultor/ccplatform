/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:06:59
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
    /// 实体类 t_SystemUser，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_SystemUser : ICloneable
    {
        public t_SystemUser()
        { }
        
        /// <summary>
        /// 构造函数 t_SystemUser
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sUserName">sUserName</param>
        /// <param name="sLoginName">sLoginName</param>
        /// <param name="sPassword">sPassword</param>
        /// <param name="lastUpdate">LastUpdate</param>
        public t_SystemUser(string keyID, string sUserName, string sLoginName, string sPassword, DateTime? lastUpdate,bool IsEnable)
        {
            this.KeyID = keyID;
            this.sUserName = sUserName;
            this.sLoginName = sLoginName;
            this.sPassword = sPassword;
            this.LastUpdate = lastUpdate;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sUserName
        /// </summary>
        public string sUserName { get; set; }
        
        /// <summary>
        /// sLoginName
        /// </summary>
        public string sLoginName { get; set; }
        
        /// sPassword
        /// </summary>
        public string sPassword { get; set; }
        
        /// <summary>
        /// LastUpdate
        /// </summary>
        public DateTime? LastUpdate { get; set; }

        public bool IsEnable { get; set; }

        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_SystemUser model = obj as ZSystem.Model.t_SystemUser;
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
    