/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:11:26
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
    /// ʵ���� t_SysUserState���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_SysUserState : ICloneable
    {
        public t_SysUserState()
        { }
        
        /// <summary>
        /// ���캯�� t_SysUserState
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="userID">UserID</param>
        /// <param name="iState">iState</param>
        /// <param name="lastDate">LastDate</param>
        public t_SysUserState(string keyID, string userID, int? iState, DateTime? lastDate)
        {
            this.KeyID = keyID;
            this.UserID = userID;
            this.iState = iState;
            this.LastDate = lastDate;
        }
        
        #region ʵ������
        /// <summary>
        /// KeyID
        /// </summary>
        public string KeyID { get; set; }
        
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// iState
        /// </summary>
        public int? iState { get; set; }
        
        /// <summary>
        /// LastDate
        /// </summary>
        public DateTime? LastDate { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_SysUserState model = obj as ZSystem.Model.t_SysUserState;
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
    