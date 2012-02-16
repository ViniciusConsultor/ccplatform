/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:07:01
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
    /// 实体类 t_Operation，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_Operation : ICloneable
    {
        public t_Operation()
        { }
        
        /// <summary>
        /// 构造函数 t_Operation
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="clientID">ClientID</param>
        /// <param name="iStatus">iStatus</param>
        /// <param name="iTotalPrice">iTotalPrice</param>
        /// <param name="createUser">CreateUser</param>
        /// <param name="memo">Memo</param>
        public t_Operation(string keyID, string clientID, int? iStatus, double? iTotalPrice, string createUser, string memo)
        {
            this.KeyID = keyID;
            this.ClientID = clientID;
            this.iStatus = iStatus;
            this.iTotalPrice = iTotalPrice;
            this.CreateUser = createUser;
            this.Memo = memo;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// ClientID
        /// </summary>
        public string ClientID { get; set; }
        
        /// <summary>
        /// iStatus
        /// </summary>
        public int? iStatus { get; set; }
        
        /// <summary>
        /// iTotalPrice
        /// </summary>
        public double? iTotalPrice { get; set; }
        
        /// <summary>
        /// CreateUser
        /// </summary>
        public string CreateUser { get; set; }
        
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
            ZSystem.Model.t_Operation model = obj as ZSystem.Model.t_Operation;
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
    