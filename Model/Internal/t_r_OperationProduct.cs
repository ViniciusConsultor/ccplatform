/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:00
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;

namespace ZSystem.Model
{
    /// <summary>
    /// ʵ���� t_r_OperationProduct���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_r_OperationProduct : ICloneable
    {
        public t_r_OperationProduct()
        { }
        
        /// <summary>
        /// ���캯�� t_r_OperationProduct
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
        
        #region ʵ������
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
    
        #region ICloneable ��Ա
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
    