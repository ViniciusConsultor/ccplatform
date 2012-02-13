using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace DJDBDK
{
	//*******************************************************************************
	//**************************    ANALOG VOICE   **********************************
	//*******************************************************************************
	public class Tc08a32
	{
		public const int MAX_CARD_NO = 16;
		public const int MAX_CHANNEL_NO = 16*MAX_CARD_NO;
		// add for support 256 channel, 2001.11.14
		public const int MAX_CHANNEL_NO_256 = (16 * MAX_CARD_NO);		
		public const int LEN_FILEPATH = 70;

		// the value of every card-type
		public const int	CARD_TYPE_T5_64 = 1;
		public const int	CARD_TYPE_T5_128 = 2;
		public const int	CARD_TYPE_T5_REC = 3;
		
		public const int	CARD_TYPE_T5_128_NT = 10;
		public const int	CARD_TYPE_T5_REC_NT = 11;
		public const int	CARD_TYPE_T5_ID_NT = 12;

		// new-d160a
		public const int CARD_TYPE_D160A_NT = 30;
		// d160an	
		public const int	CARD_TYPE_D160A_NT_NEW = 31;
		
		//YY ADD FOR PCI SUPPORT 2000.10.16
		public const int CARD_TYPE_D160A_PCI = 50;
		//YY ADD FOR PCI SUPPORT 2000.10.16

		public const int CHTYPE_USER = 0;
		public const int CHTYPE_TRUNK = 1;
		public const int CHTYPE_EMPTY = 2;
		public const int CHTYPE_RECORD = 3;
		public const int CHTYPE_CS = 4;
		public const int CHTYPE_EM_CTRL = 5;
		public const int CHTYPE_EM_4VOC = 6;
		public const int CHTYPE_EM_2VOC = 7;
		
		public const int NODTMF = -1;
		public const int DTMF_CODE_0 = 10;
		public const int DTMF_CODE_1 = 1;
		public const int DTMF_CODE_2 = 2;
		public const int DTMF_CODE_3 = 3;
		public const int DTMF_CODE_4 = 4;
		public const int DTMF_CODE_5 = 5;
		public const int DTMF_CODE_6 = 6;
		public const int DTMF_CODE_7 = 7;
		public const int DTMF_CODE_8 = 8;
		public const int DTMF_CODE_9 = 9;
		public const int DTMF_CODE_STAR = 11;
		public const int DTMF_CODE_SHARP = 12;
		public const int DTMF_CODE_A = 13;
		public const int DTMF_CODE_B = 14;
		public const int DTMF_CODE_C = 15;
		public const int DTMF_CODE_D = 16;

		public const int RECORD_CHECK = 01;
		public const int PLAY_CHECK = 02;
		public const int SEND_CHECK = 03;
		public const int SEND_READY_CHECK = 04;
		
		public const int R_BUSY = 0x21;
		public const int R_OTHER = 0x20;
		
		public const int	S_NODIALTONE = 0x0F;
		public const int S_NORESULT = 0x10;
		public const int S_BUSY = 0x11;
		public const int S_NOBODY = 0x13;
		public const int S_CONNECT = 0x14;
		public const int S_NOSIGNAL = 0x15;
		
		public const int S_DIALSIG = 0x30;		
		
		public const int PACK_64KBPS = 0;
		public const int PACK_32KBPS = 1;
		public const int PACK_16KBPS = 2;
		public const int PACK_8KBPS = 3;
		public const int PACK_8KBPS_G729 = 4;

		// NEW ADD for Feed and Signal
		public const int SIG_STOP = 0;
		public const int SIG_DIALTONE = 1;
		public const int SIG_BUSY1 = 2;
		public const int SIG_BUSY2 = 3;
		public const int SIG_RINGBACK = 4;
		public const int SIG_CUIGUA = 5;
		public const int SIG_STOP_NEW = 10;
		public const int SIG_DOUBLE_RINGBACK = 20;
		
		public const int HANG_UP_FLAG_FALSE = 0;
		public const int HANG_UP_FLAG_TRUE = 1;
		public const int HANG_UP_FLAG_START = 2;
		public const int HANG_UP_FLAG_PRESS_R = 3;

		// caller-ID
		public const int	ID_STEP_NONE = 0;
		public const int	ID_STEP_HEAD = 1;
		public const int	ID_STEP_ID = 2;
		public const int	ID_STEP_OK = 3;
		public const int	ID_STEP_FAIL = 4;
		public const int	ID_STEP_LEN = 5;
		// end of caller-ID
		
		// add by syl
		public const int DJ_DIAL_LEN = 64;
		public const int DIAL_MAX_NO = DJ_DIAL_LEN;
		public const int MAX_SPK_STR = DJ_DIAL_LEN;
		// end by syl

		public struct TPD_RPB
		{
			public ushort PlayFlag;
			public ushort RecordFlag;
			public ushort PlayCount;
			public ushort RecordCount;
			public ushort DtmfCount;
			public ushort DialFlag;
			public ushort SigCount;
			public ushort SigStartPoint;
			public StringBuilder SigBuf;
		}
		
		public struct TPD_WPB
		{
			public byte Busy1Count1Low;
			public byte  Busy1Count1High;
			public byte  Busy1Count0Low;
			public byte  Busy1Count0High;		
			public ushort  BusySigCount;
			public ushort  BusySigLen;		
			public ushort  SendReadyLen;		
			public byte  SendBusy1Count1Low;
			public byte  SendBusy1Count1High;
			public byte  SendBusy1Count0Low;
			public byte  SendBusy1Count0High;		
			public byte  SendSigCount1Low;
			public byte  SendSigCount1High;
			public byte  SendSigCount0Low;
			public byte  SendSigCount0High;		
			public ushort  SendNoSignalLen;		
			public byte  MaxRingTimes;
		}
	
		//use play index file	
		public struct TPD_PIF
		{
			public string FileName;//T
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]public IntPtr[] gHandle;
			public UInt32 FileCount;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]public int[] FileFlag;
		}
		
		/*******************************************
			define struct & type
		********************************************/
		public struct TC_INI_TYPE
		{
			// get from "TC08A-V.INI"
			public ushort wCardNo;
			public ushort wCardType;
			public ushort wConnect;
			public ushort wIRQ;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.LEN_FILEPATH)]public char[] cbDir;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CARD_NO)]public ushort[] wAddress;
			
			// get from driver
			public ushort wMajorVer;
			public ushort wMinorVer;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public ushort[] wChType;
		
			public ushort wMachineNo;
		}

        /// <summary>
        /// 载入驱动
        /// </summary>
        /// <returns>0-正常 </returns>
		[DllImport("Tc08a32.dll")]public static extern int LoadDRV();
		
        /// <summary>
        /// 释放驱动
        /// </summary>
        [DllImport("Tc08a32.dll")]public static extern void FreeDRV();
		
		[DllImport("Tc08a32.dll")]public static extern void GetSysInfo(ref TC_INI_TYPE TmpIni);
		[DllImport("Tc08a32.dll")]public static extern ushort CheckValidCh();
		[DllImport("Tc08a32.dll")]public static extern ushort CheckChType(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool IsSupportCallerID();
		
		[DllImport("Tc08a32.dll")]public static extern int EnableCard(int wUsedCh, int wFileBufLen);
		[DllImport("Tc08a32.dll")]public static extern void DisableCard();
		[DllImport("Tc08a32.dll")]public static extern void SetPackRate ( ushort wPackRate );		
		
		[DllImport("Tc08a32.dll")]public static extern void PUSH_PLAY ();
		
		[DllImport("Tc08a32.dll")]public static extern bool RingDetect(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool CheckRingEnd(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool CheckPolarity(int wChnlNo);        
		[DllImport("Tc08a32.dll")]public static extern void OffHook(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern void HangUp(int wChnlNo);
		
		[DllImport("Tc08a32.dll")]public static extern int SetLink ( int wOne, int wAnother );
		[DllImport("Tc08a32.dll")]public static extern int ClearLink ( int wOne, int wAnother );
		[DllImport("Tc08a32.dll")]public static extern int LinkOneToAnother ( int wOne, int wAnother );
		[DllImport("Tc08a32.dll")]public static extern int ClearOneFromAnother ( int wOne, int wAnother );
		[DllImport("Tc08a32.dll")]public static extern int LinkThree( int wOne, int wTwo, int wThree);
		[DllImport("Tc08a32.dll")]public static extern int ClearThree( int wOne, int wTwo, int wThree);
		
		[DllImport("Tc08a32.dll")]public static extern void InitDtmfBuf(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern short GetDtmfCode( int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool DtmfHit(int wChnlNo);
		
		[DllImport("Tc08a32.dll")]public static extern void StartSigCheck ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void StopSigCheck ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern int ReadCheckResult(int wChnlNo, ushort wMode);
		[DllImport("Tc08a32.dll")]public static extern int ReadBusyCount();
		
		[DllImport("Tc08a32.dll")]public static extern void SetBusyPara( ushort BusyLen );
		[DllImport("Tc08a32.dll")]public static extern void SetDialPara ( ushort RingBack1, ushort RingBack0, ushort BusyLen, ushort RingTimes );
		[DllImport("Tc08a32.dll")]public static extern void ReadSigBuf ( int wChnlNo, ref ushort pwStartPoint, ref ushort pwCount, ref byte SigBuf );
		
		[DllImport("Tc08a32.dll")]public static extern void StartPlay ( int wChnlNo, byte[] PlayBuf, UInt32 dwStartPos, UInt32 dwPlayLen);//T
		[DllImport("Tc08a32.dll")]public static extern void StopPlay ( int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool CheckPlayEnd ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void ReadStatus ( int wChnlNo, ref TPD_RPB TmpRead );
		
		[DllImport("Tc08a32.dll")]public static extern bool StartPlayFile ( int wChnlNo, string FileName, UInt32 StartPos );
		[DllImport("Tc08a32.dll")]public static extern void StopPlayFile (int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int GetPlayFileOffset(int wChnlNo);
		
		// index play file
		[DllImport("Tc08a32.dll")]public static extern void RsetIndexPlayFile(int Line);
		[DllImport("Tc08a32.dll")]public static extern bool AddIndexPlayFile(int Line, string FileName);
		[DllImport("Tc08a32.dll")]public static extern bool StartIndexPlayFile( int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool CheckIndexPlayFile(int ChnlNo);
		[DllImport("Tc08a32.dll")]public static extern void StopIndexPlayFile(int wChnlNo);
		
		[DllImport("Tc08a32.dll")]public static extern void ResetIndex ();
		[DllImport("Tc08a32.dll")]public static extern bool SetIndex ( StringBuilder VocBuf, UInt32 dwVocLen);
		[DllImport("Tc08a32.dll")]public static extern void StartPlayIndex( int wChnlNo, ref ushort pIndexTable, ushort wIndexLen);
		
		[DllImport("Tc08a32.dll")]public static extern void SendDtmfBuf(int wChnlNo, string DialNum);
		[DllImport("Tc08a32.dll")]public static extern bool CheckSendEnd(int wChnlNo);
		
		//static int StopRecord(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool StartRecordFile ( int wChnlNo, string FileName, UInt32 dwRecordLen );
		[DllImport("Tc08a32.dll")]public static extern bool CheckRecordEnd ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void StopRecordFile (int wChnlNo);

		[DllImport("Tc08a32.dll")]public static extern void FeedSigFunc ();
		[DllImport("Tc08a32.dll")]public static extern void StartTimer(int wChnlNo, ushort ClockType);
		[DllImport("Tc08a32.dll")]public static extern int ElapseTime ( int wChnlNo, ushort ClockType );
		[DllImport("Tc08a32.dll")]public static extern void StartPlaySignal (int wChnlNo, ushort SigType );
		[DllImport("Tc08a32.dll")]public static extern void StartHangUpDetect ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern int HangUpDetect ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void FeedRing(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern void FeedRealRing(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern void FeedPower(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool OffHookDetect(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool ReadGenerateSigBuf (StringBuilder lpFileName);
		
		// caller-id
		[DllImport("Tc08a32.dll")]public static extern void ResetCallerIDBuffer(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int GetCallerIDRawStr (int wChnlNo, StringBuilder IDRawStr);
		[DllImport("Tc08a32.dll")]public static extern int GetCallerIDStr (int wChnlNo, StringBuilder IDStr);
		
		[DllImport("Tc08a32.dll")]public static extern bool StartRecordFileNew(int wChnlNo, string FileName, UInt32 dwRecordLen, UInt32 dwRecordStartPos); 
		[DllImport("Tc08a32.dll")]public static extern int NewReadPass ( int wCardNo );
		[DllImport("Tc08a32.dll")]public static extern int CheckSilence(int wChnlNo, ushort wCheckNum);
		
		// add about fast send dtmf
		[DllImport("Tc08a32.dll")]public static extern int SetSendPara ( int ToneLen, int SilenceLen );
		[DllImport("Tc08a32.dll")]public static extern void NewSendDtmfBuf(int ChannelNo, string DialNum);
		[DllImport("Tc08a32.dll")]public static extern int NewCheckSendEnd(int ChannelNo);

		// add for T5-REC-NT card
		public const int FREQWIDTH_ALL = 0;
		public const int FREQWIDTH_WIDE = 1;
		
		public const int SENSVAL_1_OF_16 = 00;
		public const int SENSVAL_1_OF_8 = 01;
		public const int SENSVAL_1_OF_4 = 02;
		public const int SENSVAL_1_OF_2 = 03;
		
		public const int SPEAKER_VOL_NONE  =  0;
		public const int SPEAKER_VOL_1 = 1;
		public const int SPEAKER_VOL_2 = 2;
		public const int SPEAKER_VOL_3 = 3;
		public const int SPEAKER_VOL_4 = 4;
		public const int SPEAKER_VOL_5 = 5;
		public const int SPEAKER_VOL_6 = 6;
		public const int SPEAKER_VOL_7 = 7;
		public const int SPEAKER_VOL_8 = 8;

		[DllImport("Tc08a32.dll")]public static extern void LinkZeroTo ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void ClearZeroLink ();
		[DllImport("Tc08a32.dll")]public static extern void SetSpkVol ( ushort wVol );
		//end of add

		//----------- add for convert FAX
		[DllImport("Tc08a32.dll")]public static extern int DJCvt_ClientStartConvert( int wFaxChnl, StringBuilder NowTxtName, StringBuilder NowFaxName, byte cbResolution, byte cbPageLineNo);
		[DllImport("Tc08a32.dll")]public static extern int DJCvt_ClientStopConvert( int wFaxChnl );
		[DllImport("Tc08a32.dll")]public static extern int DJCvt_ClientCheckCvt ( int wFaxChnl );

		// add for new-d160a
		public const int	WORK_MODE_DTMF = 0;
		public const int	DTMF_MODE_VAL_NORMAL = 0;
		public const int	DTMF_MODE_VAL_QUICK = 1;
		public const int	DTMF_MODE_VAL_SLOW = 2;
		public const int    WORK_MODE_TEST_DTMF = 1;
		public const int	WORK_MODE_TEST_FAX = 2;
		public const int	WORK_MODE_SET_SIG_PARA = 3;
		public const int	WORK_MODE_CHECK_RING = 4;
		public const int	CHECK_RING_MODE_VAL_NEW = 0;
		public const int	CHECK_RING_MODE_VAL_OLD = 1;
		public const int	WORK_MODE_REC_AGC = 5;
		public const int	REC_AGC_MODE_VAL_DISABLE = 0;
		public const int	REC_AGC_MODE_VAL_ENABLE = 1;

		public const int	WORK_MODE_AGC_PARAM_INCREASE = 6;
		public const int	WORK_MODE_AGC_PARAM_DECREASE = 7;

		[DllImport("Tc08a32.dll")]public static extern void D_SetWorkMode  ( int wChnl, char cbWorkMode, char cbModeVal );//T
		
		// add next in 2004.07.16
		[DllImport("Tc08a32.dll")]public static extern void D_SetDtmfParamEx  ( int wChnl, ushort wDtmf_OnTime, ushort wDTMF_OffTime );

		// more info function
		public struct TC_INI_TYPE_MORE
		{
			public ushort wMemAddr;		
			public ushort wCardNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CARD_NO)]public byte[] cbCardType;		// add for D160A, also mean Channel of this card type
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CARD_NO)]public byte[] cbCardNeiWai;		// add for D160A, TRUNK or USER		
			public ushort wChnlNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte[] cbChType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte[] cbChnlCardNo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte []cbChnlInternal;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte []cbConnectChnl;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte []cbConnectStream;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte []cbDtmfModeVal;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = Tc08a32.MAX_CHANNEL_NO)]public byte []cbIsSupportCallerID;
		}

		public const int	CARD_TYPE_D160A = 16;
		public const int	CARD_TYPE_D080A = 8;

		[DllImport("Tc08a32.dll")]public static extern ushort D_GetSysInfoMore( ref TC_INI_TYPE_MORE TmpMore);
		// end of add

		public const int	VOL_ADJUST_RECORD = 0;
		public const int	VOL_ADJUST_PLAY = 1;
		
		[DllImport("Tc08a32.dll")]public static extern int D_AdjustVocVol ( int wChnl, char cMode, char cVolAdjust );

		[DllImport("Tc08a32.dll")]public static extern int D_AdjustVocVol_D080A_R(int wChnl, byte cMode, byte cVolAdjust, bool bIsD080A_R);
		// add for D160A or D080A card
		[DllImport("Tc08a32.dll")]public static extern void ReadSigBufAll ( int wChnlNo,ref ushort pwStartPoint, ref ushort pwCount, ref byte SigBuf );
		[DllImport("Tc08a32.dll")]public static extern void SetSigFreqAll ( ushort wIndex, ushort wFreq );
		// end

		// add for-vr
		[DllImport("Tc08a32.dll")]public static extern int	VR_SetRefreshSize ( ushort wSize );
		[DllImport("Tc08a32.dll")]public static extern void VR_StartRecord ( int wChnlNo );
		[DllImport("Tc08a32.dll")]public static extern void VR_StopRecord(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int	VR_GetRecordData ( int wChnlNo, StringBuilder pBuffer );
		[DllImport("Tc08a32.dll")]public static extern void VR_ReadSigBuf ( int wChnlNo, ref ushort pwStartPoint, ref ushort pwCount, byte[] SigBuf );//T
		[DllImport("Tc08a32.dll")]public static extern void VR_SetEcrMode ( int wChnl, byte cbEnableFlag, ushort wParam1, ushort wParam2 );
		// end

		//for-tts
		[DllImport("Tc08a32.dll")]public static extern int	IsNowSupportTTS();
		
		// for hn, dyq, 2000.09.06
		[DllImport("Tc08a32.dll")]public static extern void NewSetBusyPara( ushort Busy1Low, ushort Busy1High,ushort Busy0Low, ushort Busy0High );
		
		// add for zyb, 2000.09.07
		[DllImport("Tc08a32.dll")]public static extern bool AddIndexPlayFile_ZYB(ushort Line, StringBuilder FileName, int DNum );
		
		//YY ADD FOR PCI 2000.11.26
		[DllImport("Tc08a32.dll")]public static extern int GetPciInfo();
		//YY ADD FOR PCI 2000.11.26
		
		// add for HZARKJ, 2000.10.19
		[DllImport("Tc08a32.dll")]public static extern int HZ_inp (ushort wPort);
		[DllImport("Tc08a32.dll")]public static extern void HZ_outp(ushort wPort, int DataByte );
		// end

		// add for-FSK, 2000.11.14
		[DllImport("Tc08a32.dll")]public static extern ushort D_GetFSKRawStr (int wChnlNo, StringBuilder FSKRawStr);
		[DllImport("Tc08a32.dll")]public static extern int D_GetFSKStr (int wChnlNo, StringBuilder IDStr);
		
		// add for SWT, 2001.04.28
		[DllImport("Tc08a32.dll")]public static extern UInt32 NewReadPass_SWT ( int wCardNo );
		
		//YY ADD FOR FSK 2001.7.2
		[DllImport("Tc08a32.dll")]public static extern int FSK_InitForFSK();
		[DllImport("Tc08a32.dll")]public static extern void FSK_ResetCallerIDBuffer(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int FSK_GetFSKRawStr (int wChnlNo, StringBuilder FSKRawStr);
		//YY ADD FOR FSK 2001.7.2
		// add in 2005.10.26
		[DllImport("Tc08a32.dll")]public static extern void FSK_SetSendEnd_ResetFlag(int wChnlNo);

		//YY ADD FOR BELL 103 2001.7.9
		[DllImport("Tc08a32.dll")]public static extern int Bell103_SetWorkMode(int wChnlNo, ushort wWorkMode);
		[DllImport("Tc08a32.dll")]public static extern int Bell103_GetRecvData(int wHandle, StringBuilder pData);//T
		[DllImport("Tc08a32.dll")]public static extern int Bell103_SendData(int wHandle, StringBuilder pData, ushort nLen);//T
		[DllImport("Tc08a32.dll")]public static extern int Bell103_Stop(int wHandle);
		//YY ADD FOR BELL 103 2001.7.9

		//YY ADD FOR DFM 2001.8.16
		[DllImport("Tc08a32.dll")]public static extern int D160PCI_GetTimeSlot(int wD160AChnl);
		[DllImport("Tc08a32.dll")]public static extern int D160PCI_ConnectFromTS(int wD160AChnl, int wChnlTS);
		[DllImport("Tc08a32.dll")]public static extern int D160PCI_DisconnectTS(int wD160AChnl);
		//YY ADD FOR DFM 2001.8.16
		
		// add for BJMR，2002.11.26
		[DllImport("Tc08a32.dll")]public static extern int D160PCI_CT_Connect_CT ( int wD160AChnl, byte input_stream, byte input_slot );
		
		// YY ADD for RealTime Memory Play, 2001.10.17
		[DllImport("Tc08a32.dll")]public static extern void SYS_StartLoopPlay ( int wChnlNo, UInt32 dwPlayLen, UInt32 dwStartPos );
		[DllImport("Tc08a32.dll")]public static extern void SYS_MoveBufToSys ( int wChnlNo, StringBuilder p, UInt32 dwMoveLen, UInt32 dwSysStartPos );//T
		// end of add
		
		// YY ADD for DFM support NADK, 2002.01.09
		[DllImport("Tc08a32.dll")]public static extern int	DFM_Fax_GetTimeSlot ( int	DFM_Fax_ChnlID );
		[DllImport("Tc08a32.dll")]public static extern int	DFM_Fax_ConnectFromTS ( int DFM_Fax_ChnlID, int iTS );
		[DllImport("Tc08a32.dll")]public static extern int	DFM_Fax_DisconnectTS ( int DFM_Fax_ChnlID );
		// end of add
		
		// HJN ADD FOR D160A-REV2 RECORD MODULE, 2002.06.28
		[DllImport("Tc08a32.dll")]public static extern ushort CheckChTypeNew(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool DRec_OffHookDetect(int wChnlNo);
		// END OF ADD

		[DllImport("Tc08a32.dll")]public static extern bool DRec_LineDetect(int wChnlNo);

		// add next function in 2003.04.21, just for "New M2R module, you can adjust threshold voltage"
		public const int NREC_MAX_VOLTAGE_LEVEL = 52;
		
		[DllImport("Tc08a32.dll")]public static extern bool DRec_IsVoltageAdjust(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool DRec_SetVoltageLevel(int wChnlNo, byte cbVoltageVal);
		[DllImport("Tc08a32.dll")]public static extern byte DRec_GetVoltageLevel(int wChnlNo);
		
		// add in 2003.05.21
		[DllImport("Tc08a32.dll")]public static extern byte DRec_FetchVoltageValue(int wChnlNo);
		// end of add

		// add next 2 function in 2003.04.30
		[DllImport("Tc08a32.dll")]public static extern bool StartRecordFile_Ex ( int wChnlNo, StringBuilder FileName, UInt32 dwRecordLen, bool IsShareOpen );
		[DllImport("Tc08a32.dll")]public static extern bool StartRecordFileNew_Ex ( int wChnlNo, StringBuilder FileName,UInt32 dwRecordLen,UInt32 dwRecordStartPos, bool IsShareOpen ); 
		// end of add

		// add next funcion in 2004/04/28
		[DllImport("Tc08a32.dll")]public static extern int GetCallerIDStrEx (int wChnlNo, StringBuilder strTime, StringBuilder strCallerID, StringBuilder strUser);
		
		// add next function in 2004.06.20
		[DllImport("Tc08a32.dll")]public static extern void SetSigParaOneChnl ( int wChnlNo, ushort wFreqWidth, ushort wSensVal );
		
		//add for new signal on 2004.10.18
		[DllImport("Tc08a32.dll")]public static extern int SetGenerateSigParam(int nSigType, int nFreq1, int nFreq2, double dbAmp1, double dbAmp2, int nOnTime, int nOffTime, int iSampleRate);
		
		[DllImport("Tc08a32.dll")]public static extern int SetGenerateSigParam_fordoubleringback(int nSigType, int nFreq1, int nFreq2, double dbAmp1, double dbAmp2,int nOnTime1, int nOffTime1, int nOnTime2, int nOffTime2, int iSampleRate);
		//add for check dial tone, 2004.11.05
		[DllImport("Tc08a32.dll")]public static extern void StartCheckDialTone(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int DialToneCheckResult(int wChnlNo);
		//add end.

		//add by yezm, 2005.05.09
		[DllImport("Tc08a32.dll")]public static extern void DRec_StartPreLoopRecord(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern bool DRec_StartRecordFile ( int wChnlNo, StringBuilder FileName, UInt32 dwRecordLen, int ForwardLen );
		//end of add
		
		// add next function in 2004.12.23 by HJN
		public const int		FSK_RCV_MODE_NONE = 0;
		public const int		FSK_RCV_MODE_NORMAL = 1;
		public const int		FSK_RCV_MODE_HJFY = 2;
		public const int		FSK_RCV_MODE_BIT = 3;
		public const int		FSK_RCV_MODE_BELL_103 = 103;
		
		[DllImport("Tc08a32.dll")]public static extern int	ChannelFSKRcvMode ( int wChnlNo );

		// add next function in 2005.08.10 for HYT delay
		[DllImport("Tc08a32.dll")]public static extern int D_Delay_LinkOneToAnother ( int wOne, int wAnother, UInt32 dwDelay );
		[DllImport("Tc08a32.dll")]public static extern int D_Delay_ClearOneFromAnother ( int wOne );

		[DllImport("Tc08a32.dll")]public static extern int D_Prepare_MSK_Filter(int wChnlNo, int wHandle);
		[DllImport("Tc08a32.dll")]public static extern int D_Cancel_MSK_Filter(int wChnlNo);

		// add next function in 2005.08.24 for VoIP Play
		[DllImport("Tc08a32.dll")]public static extern int	D160PCI_VOC_Connect_To_CT ( int wChnlNo, int wChnlTS);
		[DllImport("Tc08a32.dll")]public static extern int	D160PCI_VOC_Connect_From_CT ( int wChnlNo, int wChnlTS);

		// add next function in 2006.02.21 for shenzhen ruimeng
		[DllImport("Tc08a32.dll")]public static extern int  SetSignalPara(int iRbkOn, int iRbkOff, int iBusyOn, int iBusyOff, int iRbkOn_WC, int iRbkOff_WC, int iBusyOn_WC, int iBusyOff_WC);
		[DllImport("Tc08a32.dll")]public static extern void StartSigCheckEx(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern void StopSigCheckEx(int wChnlNo);
		[DllImport("Tc08a32.dll")]public static extern int CheckSendResult(int wChnlNo);

		[DllImport("Tc08a32.dll")]public static extern void StartCheckSingleFreqTone(int wChnlNo, int dwFreq);
		[DllImport("Tc08a32.dll")]public static extern int SingleFreqToneCheckResult(int wChnlNo);

	[DllImport("Tc08a32.dll")]public static extern int ConnectForDoubleChnlRecord( int wUserChnlNo, int wTrunkChnlTS );
	[DllImport("Tc08a32.dll")]public static extern int DisconnectForDoubleChnlRecord(int wUserChnlNo);

	[DllImport("Tc08a32.dll")]public static extern int ReadPromLastFourByte( int CardNo );

	public const int DATA_FORMAT_DIALOGIC_ADPCM = 0x01;
	public const int DATA_FORMAT_ALAW = 0x03;
	public const int DATA_FORMAT_PCM = 0x08;
	public const int DATA_FORMAT_G729 = 0x0c;

	[DllImport("Tc08a32.dll")]public static extern int DJLM_D160A_Init_New();
	[DllImport("Tc08a32.dll")]public static extern void DJLM_D160A_SetMonitorChnl(int wChnl, bool bMon);

	public struct TC_INI_TYPE_MORE_256
		{
		public byte  wMemAddr;
		public byte  wCardNum;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CARD_NO)]public byte[] cbCardType;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CARD_NO)]public byte[] cbCardNeiWai;
		public byte wChnlNum;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbChType;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbChnlCardNo;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbChnlInternal;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbConnectChnl;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbConnectStream;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbDtmfModeVal;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_NO_256)]public byte[] cbIsSupportCallerID;
	}

	[DllImport("Tc08a32.dll")]public static extern byte D_GetSysInfoMore_256( ref TC_INI_TYPE_MORE_256 pTmpMore);
	[DllImport("Tc08a32.dll")]public static extern int StartPlayMem(byte wChnlNo);
	[DllImport("Tc08a32.dll")]public static extern int SendToBuff(byte wChnlNo, string PlayBuf, int dwPlayLen);
	[DllImport("Tc08a32.dll")]public static extern int SendToBuffMuti(byte wChnlNo, string PlayBuf, int dwPlayLen, int nMode);
	[DllImport("Tc08a32.dll")]public static extern bool RingDetect_Ex(byte wChnlNo);
	}
}