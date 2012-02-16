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
    /// 实体类 t_Client，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_Client : ICloneable
    {
        public t_Client()
        { }
        
        /// <summary>
        /// 构造函数 t_Client
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sClientName">sClientName</param>
        /// <param name="sAddress">sAddress</param>
        /// <param name="sMobiPhone">sMobiPhone</param>
        /// <param name="sTelPhone">sTelPhone</param>
        /// <param name="createUserID">CreateUserID</param>
        /// <param name="memo">Memo</param>
        public t_Client(string keyID, string sClientName, string sAddress, string sMobiPhone, string sTelPhone, string createUserID, string memo)
        {
            this.KeyID = keyID;
            this.sClientName = sClientName;
            this.sAddress = sAddress;
            this.sMobiPhone = sMobiPhone;
            this.sTelPhone = sTelPhone;
            this.CreateUserID = createUserID;
            this.Memo = memo;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sClientName
        /// </summary>
        public string sClientName { get; set; }
        
        /// <summary>
        /// sAddress
        /// </summary>
        public string sAddress { get; set; }
        
        /// <summary>
        /// sMobiPhone
        /// </summary>
        public string sMobiPhone { get; set; }
        
        /// <summary>
        /// sTelPhone
        /// </summary>
        public string sTelPhone { get; set; }
        
        /// <summary>
        /// CreateUserID
        /// </summary>
        public string CreateUserID { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }

        public bool? IsEnable { get; set; }

        public DateTime? LastUpdate { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Client model = obj as ZSystem.Model.t_Client;
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
    