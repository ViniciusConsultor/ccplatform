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
    /// 实体类 t_ChannelState，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_ChannelState : ICloneable
    {
        public t_ChannelState()
        { }
        
        /// <summary>
        /// 构造函数 t_ChannelState
        /// </summary>
        /// <param name="iChID">iChID</param>
        /// <param name="sChState">sChState</param>
        /// <param name="iChType">iChType</param>
        /// <param name="sCaller">sCaller</param>
        /// <param name="sDTMF">sDTMF</param>
        /// <param name="iTimeElapse">iTimeElapse</param>
        public t_ChannelState(int? iChID, string sChState, int? iChType, string sCaller, string sDTMF, int? iTimeElapse)
        {
            this.iChID = iChID;
            this.sChState = sChState;
            this.iChType = iChType;
            this.sCaller = sCaller;
            this.sDTMF = sDTMF;
            this.iTimeElapse = iTimeElapse;
        }
        
        #region 实体属性
        /// <summary>
        /// iChID
        /// </summary>
        public int? iChID { get; set; }
        
        /// <summary>
        /// sChState
        /// </summary>
        public string sChState { get; set; }
        
        /// <summary>
        /// iChType
        /// </summary>
        public int? iChType { get; set; }
        
        /// <summary>
        /// sCaller
        /// </summary>
        public string sCaller { get; set; }
        
        /// <summary>
        /// sDTMF
        /// </summary>
        public string sDTMF { get; set; }
        
        /// <summary>
        /// iTimeElapse
        /// </summary>
        public int? iTimeElapse { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_ChannelState model = obj as ZSystem.Model.t_ChannelState;
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
    