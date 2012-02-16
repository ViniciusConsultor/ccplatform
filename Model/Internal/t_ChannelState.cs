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
    /// ʵ���� t_ChannelState���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_ChannelState : ICloneable
    {
        public t_ChannelState()
        { }
        
        /// <summary>
        /// ���캯�� t_ChannelState
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
        
        #region ʵ������
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
    
        #region ICloneable ��Ա
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
    