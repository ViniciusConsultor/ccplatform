/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.4.1.0 自动创建于 2012/2/11 15:11:26
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
    /// 实体类 t_SysUserState，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_SysUserState : ICloneable
    {
        public t_SysUserState()
        { }
        
        /// <summary>
        /// 构造函数 t_SysUserState
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="userID">UserID</param>
        /// <param name="iState">iState</param>
        /// <param name="lastDate">LastDate</param>
        public t_SysUserState(string keyID, string userID, int? iState, DateTime? lastDate)
        {
            this.KeyID = keyID;
            this.UserID = userID;
            this.iState = iState;
            this.LastDate = lastDate;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// iState
        /// </summary>
        public int? iState { get; set; }
        
        /// <summary>
        /// LastDate
        /// </summary>
        public DateTime? LastDate { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_SysUserState model = obj as ZSystem.Model.t_SysUserState;
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
    