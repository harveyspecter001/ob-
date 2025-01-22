using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000E5D RID: 3677
	[NullableContext(1)]
	[Nullable(0)]
	public class PidWatcher
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600B034 RID: 45108 RVA: 0x002A1AF8 File Offset: 0x0029FCF8
		// (remove) Token: 0x0600B035 RID: 45109 RVA: 0x002A1B08 File Offset: 0x0029FD08
		public event Action OnScanCompleted
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x002A1B18 File Offset: 0x0029FD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PidWatcher(Form1 form, Action<int> newCharacterDetectedAction)
		{
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x002A1B20 File Offset: 0x0029FD20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartWatching()
		{
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x002A1B30 File Offset: 0x0029FD30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WatchForNewCharacters()
		{
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x002A1B5C File Offset: 0x0029FD5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopWatching()
		{
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x002A1B6C File Offset: 0x0029FD6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsRunning()
		{
			return true;
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x002A1B8C File Offset: 0x0029FD8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PidWatcher()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x002A1BA0 File Offset: 0x0029FDA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rssmTvJvtgIekXBH1WwI()
		{
			return true;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x002A1BA8 File Offset: 0x0029FDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PidWatcher aGidS9JvwbTTyBwPqbwR()
		{
			return null;
		}

		// Token: 0x040040F8 RID: 16632
		private Thread pidWatcherThread;

		// Token: 0x040040F9 RID: 16633
		private bool isRunning;

		// Token: 0x040040FA RID: 16634
		private Timer scanTimer;

		// Token: 0x040040FB RID: 16635
		private Form1 parentForm;

		// Token: 0x040040FC RID: 16636
		private Action<int> onNewCharacterDetected;

		// Token: 0x040040FD RID: 16637
		private List<int> alreadyConnectedPIDs;

		// Token: 0x040040FF RID: 16639
		private static PidWatcher hGmsKDJvDKYcIK85wsgm;
	}
}
