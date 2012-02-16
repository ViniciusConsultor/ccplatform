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
    /// ʵ���� t_ChannelStateStatic���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_ChannelStateStatic : ICloneable
    {
        public t_ChannelStateStatic()
        { }
        
        /// <summary>
        /// ���캯�� t_ChannelStateStatic
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
        
        #region ʵ������
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
    
        #region ICloneable ��Ա
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
    