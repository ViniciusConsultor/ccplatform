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
    /// 实体类 t_r_OperationProduct，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class t_r_OperationProduct : ICloneable
    {
        public t_r_OperationProduct()
        { }
        
        /// <summary>
        /// 构造函数 t_r_OperationProduct
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="operationID">OperationID</param>
        /// <param name="productID">ProductID</param>
        /// <param name="iPrice">iPrice</param>
        /// <param name="iDiscount">iDiscount</param>
        /// <param name="iCurrentPrice">iCurrentPrice</param>
        public t_r_OperationProduct(string keyID, string operationID, string productID, double? iPrice, int? iDiscount, double? iCurrentPrice)
        {
            this.KeyID = keyID;
            this.OperationID = operationID;
            this.ProductID = productID;
            this.iPrice = iPrice;
            this.iDiscount = iDiscount;
            this.iCurrentPrice = iCurrentPrice;
        }
        
        #region 实体属性
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// OperationID
        /// </summary>
        public string OperationID { get; set; }
        
        /// <summary>
        /// ProductID
        /// </summary>
        public string ProductID { get; set; }
        
        /// <summary>
        /// iPrice
        /// </summary>
        public double? iPrice { get; set; }
        
        /// <summary>
        /// iDiscount
        /// </summary>
        public int? iDiscount { get; set; }
        
        /// <summary>
        /// iCurrentPrice
        /// </summary>
        public double? iCurrentPrice { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_r_OperationProduct model = obj as ZSystem.Model.t_r_OperationProduct;
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
    