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
    /// 实体类 t_OperationState，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_OperationState : ICloneable
    {
        public t_OperationState()
        { }
        
        /// <summary>
        /// 构造函数 t_OperationState
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sStatusName">sStatusName</param>
        /// <param name="iIndex">iIndex</param>
        public t_OperationState(int? keyID, string sStatusName, int? iIndex)
        {
            this.KeyID = keyID;
            this.sStatusName = sStatusName;
            this.iIndex = iIndex;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public int? KeyID { get; set; }
        
        /// <summary>
        /// sStatusName
        /// </summary>
        public string sStatusName { get; set; }
        
        /// <summary>
        /// iIndex
        /// </summary>
        public int? iIndex { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_OperationState model = obj as ZSystem.Model.t_OperationState;
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
    