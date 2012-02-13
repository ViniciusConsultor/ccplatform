using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DJDBDK
{
	public class NewSig
	{
		public const int SIG_CADENCE_BUSY = 1;		//busy
		public const int SIG_CADENCE_RINGBACK = 2;	//ring back
		
		//0 not debug 1 debug dial 2 debug dial and busy check
		[DllImport("NewSig.dll")]public static extern int Sig_Init(int wPara);
        [DllImport("NewSig.dll")]public static extern int Sig_CheckBusy(int wChNo);
		[DllImport("NewSig.dll")]public static extern int Sig_StartDial(int  wChNo,string DialNum,string PreDialNum,ushort  wMode);
		[DllImport("NewSig.dll")]public static extern int Sig_CheckDial(int  wChNo);
		[DllImport("NewSig.dll")]public static extern int Sig_GetDialStep(int  wChNo);
		[DllImport("NewSig.dll")]public static extern int Sig_GetCadenceCount(int  wChNo,int nCadenceType);
		[DllImport("NewSig.dll")]public static extern void Sig_ResetCheck(int wChNo);
		//add for test only 
		
		// add in 2004.09.18
		public const int CNT_REASON_POLARITY = 1;
		public const int CNT_REASON_VOICE = 2;
		public const int CNT_REASON_CADENCE_BREAK =	3;
		[DllImport("NewSig.dll")]public static extern int Sig_CheckBusy_New ( int wChNo, ref long plBusyType, ref long plBusyCount );
		[DllImport("NewSig.dll")]public static extern int Sig_CheckDial_New ( int wChNo, ref int plConnectReason );
		// add for test only

		//add in 2005.10.09 by yezhimin.
		[DllImport("NewSig.dll")]public static extern int Sig_StartDialEx(int wChNo, string PreDialNum, ushort wMode);
		[DllImport("NewSig.dll")]public static extern int Sig_CheckDialTone(int wChNo);
		//end add
	}
}