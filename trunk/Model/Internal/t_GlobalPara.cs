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
    /// ʵ���� t_GlobalPara���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_GlobalPara : ICloneable
    {
        public t_GlobalPara()
        { }
        
        /// <summary>
        /// ���캯�� t_GlobalPara
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sValue">sValue</param>
        /// <param name="memo">Memo</param>
        public t_GlobalPara(int? keyID, string sValue, string memo)
        {
            this.KeyID = keyID;
            this.sValue = sValue;
            this.Memo = memo;
        }
        
        #region ʵ������
        /// <summary>
        /// KeyID
        /// </summary>
        public int? KeyID { get; set; }
        
        /// <summary>
        /// sValue
        /// </summary>
        public string sValue { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_GlobalPara model = obj as ZSystem.Model.t_GlobalPara;
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
    