/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:06:22
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
    /// ʵ���� t_Log���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_Log : ICloneable
    {
        public t_Log()
        { }
        
        /// <summary>
        /// ���캯�� t_Log
        /// </summary>
        /// <param name="iD">ID</param>
        /// <param name="sContent">sContent</param>
        /// <param name="sType">sType</param>
        /// <param name="logTime">LogTime</param>
        public t_Log(string iD, string sContent, string sType, DateTime? logTime)
        {
            this.ID = iD;
            this.sContent = sContent;
            this.sType = sType;
            this.LogTime = logTime;
        }
        
        #region ʵ������
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        
        /// <summary>
        /// sContent
        /// </summary>
        public string sContent { get; set; }
        
        /// <summary>
        /// sType
        /// </summary>
        public string sType { get; set; }
        
        /// <summary>
        /// LogTime
        /// </summary>
        public DateTime? LogTime { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_Log model = obj as ZSystem.Model.t_Log;
            if (model != null && model.ID == this.ID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
    