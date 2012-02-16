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
    /// ʵ���� t_Authorization���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_Authorization : ICloneable
    {
        public t_Authorization()
        { }
        
        /// <summary>
        /// ���캯�� t_Authorization
        /// </summary>
        /// <param name="userID">UserID</param>
        /// <param name="iUserLevel">iUserLevel</param>
        public t_Authorization(string userID, int? iUserLevel)
        {
            this.UserID = userID;
            this.iUserLevel = iUserLevel;
        }
        
        #region ʵ������
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// iUserLevel
        /// </summary>
        public int? iUserLevel { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Authorization model = obj as ZSystem.Model.t_Authorization;
            if (model != null && model.UserID == this.UserID && model.iUserLevel == this.iUserLevel)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return UserID.GetHashCode() ^ iUserLevel.GetHashCode();
        }
    }
}
    