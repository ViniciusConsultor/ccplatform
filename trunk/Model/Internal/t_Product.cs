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
    /// ʵ���� t_Product���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_Product : ICloneable
    {
        public t_Product()
        { }
        
        /// <summary>
        /// ���캯�� t_Product
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sProductName">sProductName</param>
        /// <param name="iPrice">iPrice</param>
        /// <param name="memo">Memo</param>
        /// <param name="iDiscount">iDiscount</param>
        /// <param name="isEnable">IsEnable</param>
        /// <param name="begindate">Begindate</param>
        /// <param name="enddate">Enddate</param>
        /// <param name="lastUpdate">LastUpdate</param>
        public t_Product(Guid? keyID, string sProductName, double? iPrice, string memo, int? iDiscount, bool? isEnable, DateTime? begindate, DateTime? enddate, DateTime? lastUpdate)
        {
            this.KeyID = keyID;
            this.sProductName = sProductName;
            this.iPrice = iPrice;
            this.Memo = memo;
            this.iDiscount = iDiscount;
            this.IsEnable = isEnable;
            this.Begindate = begindate;
            this.Enddate = enddate;
            this.LastUpdate = lastUpdate;
        }
        
        #region ʵ������
        /// <summary>
        /// KeyID
        /// </summary>
        public Guid? KeyID { get; set; }
        
        /// <summary>
        /// sProductName
        /// </summary>
        public string sProductName { get; set; }
        
        /// <summary>
        /// iPrice
        /// </summary>
        public double? iPrice { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }
        
        /// <summary>
        /// iDiscount
        /// </summary>
        public int? iDiscount { get; set; }
        
        /// <summary>
        /// IsEnable
        /// </summary>
        public bool? IsEnable { get; set; }
        
        /// <summary>
        /// Begindate
        /// </summary>
        public DateTime? Begindate { get; set; }
        
        /// <summary>
        /// Enddate
        /// </summary>
        public DateTime? Enddate { get; set; }
        
        /// <summary>
        /// LastUpdate
        /// </summary>
        public DateTime? LastUpdate { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Product model = obj as ZSystem.Model.t_Product;
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
    