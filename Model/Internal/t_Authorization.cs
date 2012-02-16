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
    /// 实体类 t_Authorization，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_Authorization : ICloneable
    {
        public t_Authorization()
        { }
        
        /// <summary>
        /// 构造函数 t_Authorization
        /// </summary>
        /// <param name="userID">UserID</param>
        /// <param name="iUserLevel">iUserLevel</param>
        public t_Authorization(string userID, int? iUserLevel)
        {
            this.UserID = userID;
            this.iUserLevel = iUserLevel;
        }
        
        #region 实体属性
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// iUserLevel
        /// </summary>
        public int? iUserLevel { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Authorization model = obj as ZSystem.Model.t_Authorization;
            if (model != null && model.UserID == this.UserID && model.iUserLevel == this.iUserLevel)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return UserID.GetHashCode() ^ iUserLevel.GetHashCode();
        }
    }
}
    