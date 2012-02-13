using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardTest
{
	static class BoardControl
	{
		#region Property
		
		static eBoardState _BoardStatus = eBoardState.UnInit;
        static eCardState _CardStatus = eCardState.UnInit;

		static int _ChNumTotal = 0;
        static int _ChNumAvailable = 0;

		static List<LineInfo> _Llineinfo = new List<LineInfo>();

        public static int ChNumAvailable
        {
            get { return BoardControl._ChNumAvailable; }
        }

		/// <summary>
		/// 线路信息
		/// </summary>
		public static List<LineInfo> Llineinfo
		{
			get { return BoardControl._Llineinfo; }
		}
		
        /// <summary>
        /// 板卡驱动状态，调用LOADDRV获取
        /// </summary>
        public static eBoardState BoardStatus
		{
			get { return BoardControl._BoardStatus; }
		}

        /// <summary>
        /// InitCh获取卡状态,必须先LOADDRV
        /// </summary>
        public static eCardState CardStatus
        {
            get { return BoardControl._CardStatus; }
        }

		public static int ChNumTotal
		{
			get { return BoardControl._ChNumTotal; }
		}

		#endregion

		public static eBoardState LoadDrv()
		{
			_BoardStatus = (eBoardState)Enum.Parse(typeof(eBoardState), DJDBDK.Tc08a32.LoadDRV().ToString());
			return _BoardStatus;
		}

		public static eCardState InitCh()
		{
            _ChNumTotal = DJDBDK.Tc08a32.CheckValidCh();

            for (int i = 0; i < _ChNumTotal; i++)
			{
				eChannelType chType = (eChannelType)Enum.Parse(typeof(eChannelType), DJDBDK.Tc08a32.CheckChType(i).ToString());
				LineInfo NewLine = new LineInfo();
				
				NewLine.Type = chType;
                NewLine.iChID = i;
                Llineinfo.Add(NewLine);
			}
            _CardStatus = (eCardState)Enum.Parse(typeof(eCardState), DJDBDK.Tc08a32.EnableCard(ChNumTotal, 1024 * ChNumTotal).ToString());
            
            if (CardStatus!=eCardState.Success)
                FreeDrv();

            _ChNumAvailable = Llineinfo.Where(n => n.Type != eChannelType.Empty).ToList().Count;
            return CardStatus;
		}

        /// <summary>
        /// 初始化信号 接在InitCH()后使用
        /// </summary>
        /// <returns></returns>
        public static bool InitSig()
        {
            int iResult= DJDBDK.NewSig.Sig_Init(0);
            if (iResult == 0)
                return false;

            return true;
        }

        public static void DoWork()
        {
            List<LineInfo> Lcheck = Llineinfo.Where(n => n.Type != eChannelType.Empty).ToList();
            if (Lcheck==null|| Lcheck.Count==0)
                return;

            DJDBDK.Tc08a32.PUSH_PLAY();
            DJDBDK.Tc08a32.FeedSigFunc();

            for (int i = 0; i < Lcheck.Count; i++)
            {
                CheckLineState(Lcheck[i]);
                //if (Lcheck[i].Type ==eChannelType.Trunk && Lcheck[i].State !=eChannelState.CH_FREE)
                //{
                    //WORD wSigCheckResult=ReadCheckResult(i,PLAY_CHECK);
                    //if(wSigCheckResult==R_BUSY)
                    //if (DJDBDK.Tc08a32.Sig_CheckBusy(i))
                    //{
                    //    switch (Lines[i].State)
                    //    {

                    //        case CH_WELCOME:
                    //        case CH_ACCOUNT:
                    //        case CH_PASSWORD:
                    //        case CH_SELECT:
                    //            StopPlayFile(i);
                    //            break;
                    //        case CH_PLAYRESULT:
                    //            StopIndexPlayFile(i);
                    //            break;
                    //    }
                    //    ResetChannel(i);
                    //}
                //}
                //else if (Lines[i].nType == CHTYPE_USER && Lines[i].State != CH_FREE)
                //{
                //    if (!RingDetect(i))
                //    {
                //        switch (Lines[i].State)
                //        {

                //            case CH_WELCOME:
                //            case CH_ACCOUNT:
                //            case CH_PASSWORD:
                //            case CH_SELECT:
                //                StopPlayFile(i);
                //                break;
                //            case CH_PLAYRESULT:
                //                StopIndexPlayFile(i);
                //                break;
                //        }
                //        yzResetChannel(i);
                //    }
                //}
            }
        }

        private static void CheckLineState(LineInfo mLineInfo)
        {
            switch (mLineInfo.State)
            {
                case eChannelState.CH_FREE:
                    Ch_FreeHandle(mLineInfo);
                    break;
                case eChannelState.CH_RECEIVEID:
                    CH_ReceiveidHandle(mLineInfo);
                    break;
                case eChannelState.CH_WAITSECONDRING:
                    if (DJDBDK.Tc08a32.RingDetect(mLineInfo.iChID))
                    {
                        DJDBDK.Tc08a32.OffHook(mLineInfo.iChID);
                        DJDBDK.Tc08a32.StartSigCheck(mLineInfo.iChID);
                        mLineInfo.State = eChannelState.CH_OFFHOOK;
                    }
                    break;
                case eChannelState.CH_WELCOME:
                    short code = DJDBDK.Tc08a32.GetDtmfCode(mLineInfo.iChID);
			        if(code!=-1)
			        {
                        DJDBDK.Tc08a32.StopPlayFile(mLineInfo.iChID);
                        mLineInfo.Dtmf[0] = ConvertDtmf(code);
                        mLineInfo.Dtmf[1] = '0';
                        mLineInfo.State = eChannelState.CH_ACCOUNT1;
				        break;
			        }
			        if(DJDBDK.Tc08a32.CheckPlayEnd(mLineInfo.iChID))
			        {
                        //DJDBDK.Tc08a32.StopPlayFile(mLineInfo.iChID);
                        //strcpy(FileName,VoicePath);
                        //strcat(FileName,"bank.002");
                        //StartPlayFile(i,FileName,0L);
                        //Lines[i].State=CH_ACCOUNT;
			        }
                    break;
                case eChannelState.CH_ACCOUNT:
                    //code=GetDtmfCode(i);
                    //if(code!=-1)
                    //{
                    //    StopPlayFile(i);
                    //    Lines[i].Dtmf[0]=yzConvertDtmf(code);
                    //    Lines[i].Dtmf[1]=0;
                    //    Lines[i].State=CH_ACCOUNT1;
                    //    break;
                    //}
                    //if(CheckPlayEnd(i))
                    //{
                    //    StopPlayFile(i);					
                    //    Lines[i].State=CH_ACCOUNT1;
                    //}
                    break;
                case eChannelState.CH_ACCOUNT1:
                //    len = strlen(Lines[i].Dtmf);
                //    while ((code = GetDtmfCode(i)) != -1)
                //    {
                //        Lines[i].Dtmf[len++] = yzConvertDtmf(code);
                //    }
                //    Lines[i].Dtmf[len] = 0;
                //    if (len >= 8)
                //    {
                //        //				code=GetDtmfCode(i);
                //        Lines[i].Dtmf[0] = 0;
                //        strcpy(FileName, VoicePath);
                //        strcat(FileName, "bank.003");
                //        StartPlayFile(i, FileName, 0L);
                //        Lines[i].State = CH_PASSWORD;
                //    }
                //    break;
                //case CH_PASSWORD:
                //    code = GetDtmfCode(i);
                //    if (code != -1)
                //    {
                //        StopPlayFile(i);
                //        Lines[i].Dtmf[0] = yzConvertDtmf(code);
                //        Lines[i].Dtmf[1] = 0;
                //        Lines[i].State = CH_PASSWORD1;
                //        break;
                //    }
                //    if (CheckPlayEnd(i))
                //    {
                //        StopPlayFile(i);
                //        Lines[i].State = CH_PASSWORD1;
                //    }
                    break;
                case eChannelState.CH_PASSWORD:
                    break;
                case eChannelState.CH_PASSWORD1:
                    break;
                case eChannelState.CH_SELECT:
                    break;
                case eChannelState.CH_SELECT1:
                    break;
                case eChannelState.CH_PLAYRESULT:
                    if (DJDBDK.Tc08a32.CheckIndexPlayFile(mLineInfo.iChID))
                    {
                        DJDBDK.Tc08a32.StopIndexPlayFile(mLineInfo.iChID);
                        if (mLineInfo.Type == eChannelType.Trunk) 
                            ResetChannel(mLineInfo.iChID);
                        else
                        {
                            DJDBDK.Tc08a32.StartPlaySignal(mLineInfo.iChID, (ushort)eSigType.BUSY1);
                            mLineInfo.State = eChannelState.CH_WAITUSERONHOOK;
                        }
                    }
                    break;
                case eChannelState.CH_RECORDFILE:
                    break;
                case eChannelState.CH_PLAYRECORD:
                    break;
                case eChannelState.CH_OFFHOOK:
                    break;
                case eChannelState.CH_WAITUSERONHOOK:
                    if (!DJDBDK.Tc08a32.RingDetect(mLineInfo.iChID))
                    {
                        DJDBDK.Tc08a32.StartPlaySignal(mLineInfo.iChID, (int)eSigType.STOP);
                        ResetChannel(mLineInfo.iChID);
                    }
                    break;
                default:
                    break;
            }
        }

        #region CH_Handle
        
        private static void CH_ReceiveidHandle(LineInfo mLineInfo)
        {
            bool bOffHook = false;
            if (mLineInfo.nTimeElapse > 2000 && DJDBDK.Tc08a32.RingDetect(mLineInfo.iChID))
                bOffHook = true;
            if (mLineInfo.nTimeElapse > 7000)
                bOffHook = true;
            StringBuilder CallerID = new StringBuilder();
            CallerID.Append(mLineInfo.CallerID);
            int a = DJDBDK.Tc08a32.GetCallerIDStr(mLineInfo.iChID, CallerID);

            mLineInfo.CallerID = CallerID.ToString().ToCharArray();
            if (a == 3)
            {
                bOffHook = true;

            }
            else if (a == 4)//效验错误
            {
                mLineInfo.CallerID = new char[32];//清除接收的数据
                //LoadString(hInst, eIDS.CallerID_ERROR, mLineInfo.CallerID, 32);
                bOffHook = true;
            }

            if (bOffHook)
            {
                DJDBDK.Tc08a32.OffHook(mLineInfo.iChID);
                DJDBDK.Tc08a32.StartSigCheck(mLineInfo.iChID);
                mLineInfo.State = eChannelState.CH_OFFHOOK;
            }
            mLineInfo.nTimeElapse += 50;
        }

        private static void Ch_FreeHandle(LineInfo mLineInfo)
        {
            if (DJDBDK.Tc08a32.RingDetect(mLineInfo.iChID))//检测到响铃
            {
                if (mLineInfo.Type == eChannelType.User)
                    mLineInfo.State = eChannelState.CH_OFFHOOK;
                else
                {
                    mLineInfo.State = eChannelState.CH_RECEIVEID;
                    DJDBDK.Tc08a32.ResetCallerIDBuffer(mLineInfo.iChID);
                    mLineInfo.nTimeElapse = 0;
                }
            }
        }

        #endregion

        public static void FreeDrv()
		{
			DJDBDK.Tc08a32.DisableCard();
			DJDBDK.Tc08a32.FreeDRV();
            Llineinfo.Clear();
		}

        static void ResetChannel(int channelID)
        {
            if (Llineinfo[channelID].Type ==eChannelType.Trunk)
            {
                DJDBDK.Tc08a32.HangUp(channelID);
                DJDBDK.NewSig.Sig_ResetCheck(channelID);
                DJDBDK.Tc08a32.StartSigCheck(channelID);
                //StopSigCheck(channelID);
            }
            Llineinfo[channelID].Dtmf[0] = '0';
            Llineinfo[channelID].CallerID[0] = '0';
            Llineinfo[channelID].State = eChannelState.CH_FREE;
        }
		static char ConvertDtmf(int ch)
		{
			char c;

			switch (ch)
			{
				case 10:
					c = '0';
					break;
				case 11:
					c = '*';
					break;
				case 12:
					c = '#';
					break;
				case 13:
				case 14:
				case 15:
					c = (char)(ch - 13 + 97);
					break;
				case 0:
					c = 'd';
					break;
				default:
					c = (char)(ch + 48);//change DTMF from number to ASCII
					break;
			}
			return c;
		}
	}

	public enum eBoardState
	{
		Success=0,
		UnInit=1,
		ReadFileFail=-2,
		ConfigError=-3,
		LoadDSPFail=-4,
		BoardNumErrorInConfig=-5,
		D010AR_DSPFail=-6

	}
    public enum eCardState
    {
        Success=0,
        UnInit=1,
        LoadDrvFail=-1,
        CacheFail=-2,
    }
	public enum eChannelState {
	CH_FREE,
	CH_RECEIVEID,
	CH_WAITSECONDRING,
	CH_WELCOME,
	CH_ACCOUNT,
	CH_ACCOUNT1,
	CH_PASSWORD,
	CH_PASSWORD1,
	CH_SELECT,
	CH_SELECT1,
	CH_PLAYRESULT,
	CH_RECORDFILE,
	CH_PLAYRECORD,
	CH_OFFHOOK,
	CH_WAITUSERONHOOK,
};
	public enum eChannelType
	{
		User=0,
		Trunk=1,
		Empty=2,
		Record=3,
		CS=4,
		EMCtrl=5,
		EM4Voc=6,
		Em2Vov=7
	}
    public enum eSigType
    {
        STOP = 0,
        DIALTONE = 1,
        BUSY1 = 2,
        BUSY2 = 3,
        RINGBACK = 4,
        CUIGUA = 5,
        STOP_NEW = 10,
        DOUBLE_RINGBACK = 20
    }
    public enum eIDS
    {
        CHANNEL_NO=1,
        CHANNEL_TYPE=2,
        FLOW = 3,
        CALLER_ID = 4,
        TRUNK = 5,
        USER = 6,
        EMPTY = 7,
        CH_FREE = 8,
        CH_RECEIVEID = 9,
        CH_WAITSECONDRING = 10,
        CH_WELCOME = 11,
        CH_ACCOUNT = 12,
        CH_PINNUMBER = 13,
        CH_SELECT = 14,
        CH_LEAVEMSG = 15,
        CH_PLAYRESULT = 16,
        CH_PLAYRECORD = 17,
        CH_OFFHOOK = 18,
        CH_WAITUSERONHOOK = 19,
        CallerID_ERROR = 20,
        RECORD = 21,
        STATELIST = 1000,
        OK = 1001,
        TIME = 1002,
        TAB_DETAILS = 1016
    }

	public class LineInfo 
	{
		eChannelType _Type;
        eChannelState _State = eChannelState.CH_FREE;
		char[] _CallerID = new char[32];
		char[] _Dtmf = new char[32];
		int _nTimeElapse = 0;
        int _iChID = -1;


        /// <summary>
        /// 通道号
        /// </summary>
        public int iChID
        {
            get { return _iChID; }
            set { _iChID = value; }
        }

		/// <summary>
		/// 通话时长
		/// </summary>
		public int nTimeElapse
		{
			get { return _nTimeElapse; }
			set { _nTimeElapse = value; }
		}

		/// <summary>
		/// DTMF按键
		/// </summary>
		public char[] Dtmf
		{
			get { return _Dtmf; }
			set { _Dtmf = value; }
		}

		/// <summary>
		/// 通道类型
		/// </summary>
		public eChannelType Type
		{
			get { return _Type; }
			set { _Type = value; }
		}

		/// <summary>
		/// 通道状态
		/// </summary>
		public eChannelState State
		{
			get { return _State; }
			set { _State = value; }
		}

		/// <summary>
		/// 主叫号码
		/// </summary>
		public char[] CallerID
		{
			get { return _CallerID; }
			set { _CallerID = value; }
		}
		
	}

}
