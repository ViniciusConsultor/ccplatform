/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-16 17:11:05
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
    /// ʵ���� t_CallList���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_CallList : ICloneable
    {
        public t_CallList()
        { }
        
        /// <summary>
        /// ���캯�� t_CallList
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sCallOutNum">sCallOutNum</param>
        /// <param name="iTimeElapse">iTimeElapse</param>
        /// <param name="iCallUserCH">iCallUserCH</param>
        /// <param name="sysUserID">SysUserID</param>
        /// <param name="clientID">ClientID</param>
        /// <param name="memo">Memo</param>
        /// <param name="callDate">CallDate</param>
        public t_CallList(string keyID, string sCallOutNum, int? iTimeElapse, int? iCallUserCH, string sysUserID, string clientID, string memo, DateTime? callDate)
        {
            this.KeyID = keyID;
            this.sCallOutNum = sCallOutNum;
            this.iTimeElapse = iTimeElapse;
            this.iCallUserCH = iCallUserCH;
            this.SysUserID = sysUserID;
            this.ClientID = clientID;
            this.Memo = memo;
            this.CallDate = callDate;
        }
        
        #region ʵ������
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// sCallOutNum
        /// </summary>
        public string sCallOutNum { get; set; }
        
        /// <summary>
        /// iTimeElapse
        /// </summary>
        public int? iTimeElapse { get; set; }
        
        /// <summary>
        /// iCallUserCH
        /// </summary>
        public int? iCallUserCH { get; set; }
        
        /// <summary>
        /// SysUserID
        /// </summary>
        public string SysUserID { get; set; }
        
        /// <summary>
        /// ClientID
        /// </summary>
        public string ClientID { get; set; }
        
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }
        
        /// <summary>
        /// CallDate
        /// </summary>
        public DateTime? CallDate { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_CallList model = obj as ZSystem.Model.t_CallList;
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
    