/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:01
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
    /// ʵ���� t_OperationState���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class t_OperationState : ICloneable
    {
        public t_OperationState()
        { }
        
        /// <summary>
        /// ���캯�� t_OperationState
        /// </summary>
        /// <param name="keyID">KeyID</param>
        /// <param name="sStatusName">sStatusName</param>
        /// <param name="iIndex">iIndex</param>
        public t_OperationState(int? keyID, string sStatusName, int? iIndex)
        {
            this.KeyID = keyID;
            this.sStatusName = sStatusName;
            this.iIndex = iIndex;
        }
        
        #region ʵ������
        /// <summary>
        /// KeyID
        /// </summary>
        public int? KeyID { get; set; }
        
        /// <summary>
        /// sStatusName
        /// </summary>
        public string sStatusName { get; set; }
        
        /// <summary>
        /// iIndex
        /// </summary>
        public int? iIndex { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            ZSystem.Model.t_OperationState model = obj as ZSystem.Model.t_OperationState;
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
    