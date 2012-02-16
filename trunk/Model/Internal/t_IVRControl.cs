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
    /// 实体类 t_IVRControl，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_IVRControl : ICloneable
    {
        public t_IVRControl()
        { }
        
        /// <summary>
        /// 构造函数 t_IVRControl
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sFileName">sFileName</param>
        /// <param name="iKeyNum">iKeyNum</param>
        /// <param name="subID">SubID</param>
        /// <param name="sIVRName">sIVRName</param>
        /// <param name="isEnable">IsEnable</param>
        /// <param name="beginDate">BeginDate</param>
        /// <param name="endDate">EndDate</param>
        /// <param name="lastUpdate">LastUpdate</param>
        public t_IVRControl(string keyID, string sFileName, int? iKeyNum, string subID, string sIVRName, bool? isEnable, DateTime? beginDate, DateTime? endDate, DateTime? lastUpdate)
        {
            this.KeyID = keyID;
            this.sFileName = sFileName;
            this.iKeyNum = iKeyNum;
            this.SubID = subID;
            this.sIVRName = sIVRName;
            this.IsEnable = isEnable;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.LastUpdate = lastUpdate;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sFileName
        /// </summary>
        public string sFileName { get; set; }
        
        /// <summary>
        /// iKeyNum
        /// </summary>
        public int? iKeyNum { get; set; }
        
        /// <summary>
        /// SubID
        /// </summary>
        public string SubID { get; set; }
        
        /// <summary>
        /// sIVRName
        /// </summary>
        public string sIVRName { get; set; }
        
        /// <summary>
        /// IsEnable
        /// </summary>
        public bool? IsEnable { get; set; }
        
        /// <summary>
        /// BeginDate
        /// </summary>
        public DateTime? BeginDate { get; set; }
        
        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime? EndDate { get; set; }
        
        /// <summary>
        /// LastUpdate
        /// </summary>
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
            ZSystem.Model.t_IVRControl model = obj as ZSystem.Model.t_IVRControl;
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
    