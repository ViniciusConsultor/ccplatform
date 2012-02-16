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
    /// 实体类 t_ChannelStateStatic，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_ChannelStateStatic : ICloneable
    {
        public t_ChannelStateStatic()
        { }
        
        /// <summary>
        /// 构造函数 t_ChannelStateStatic
        /// </summary>
        /// <param name="iChID">iChID</param>
        /// <param name="iChtype">iChtype</param>
        /// <param name="iChNum">iChNum</param>
        public t_ChannelStateStatic(int? iChID, int? iChtype, int? iChNum)
        {
            this.iChID = iChID;
            this.iChtype = iChtype;
            this.iChNum = iChNum;
        }
        
        #region 实体属性
        /// <summary>
        /// iChID
        /// </summary>
        public int? iChID { get; set; }
        
        /// <summary>
        /// iChtype
        /// </summary>
        public int? iChtype { get; set; }
        
        /// <summary>
        /// iChNum
        /// </summary>
        public int? iChNum { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_ChannelStateStatic model = obj as ZSystem.Model.t_ChannelStateStatic;
            if (model != null && model.iChID == this.iChID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return iChID.GetHashCode();
        }
    }
}
    