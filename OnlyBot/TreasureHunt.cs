using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000E9E RID: 3742
	[Nullable(0)]
	[NullableContext(1)]
	public static class TreasureHunt
	{
		// Token: 0x0600B245 RID: 45637 RVA: 0x002A2FEC File Offset: 0x002A11EC
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task StartTreasureHuntAsync(int pid, int numberOfHunts, Action<int> onProgress, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x002A2FFC File Offset: 0x002A11FC
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task RecommencerAsync(int pid)
		{
			return null;
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x002A300C File Offset: 0x002A120C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task RecommencerDepuisDebut(int pid, int numberOfHunts, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x002A301C File Offset: 0x002A121C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Bitmap CaptureWindow(IntPtr hwnd)
		{
			return null;
		}

		// Token: 0x0600B249 RID: 45641
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out TreasureHunt.RECT lpRect);

		// Token: 0x0600B24A RID: 45642 RVA: 0x002A303C File Offset: 0x002A123C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[return: TupleElementNames(new string[]
		{
			"posX",
			"posY",
			"indice"
		})]
		public static Task<ValueTuple<int, int, string>> FindNearestPositionAsync(int objectId, int direction, string currentPos)
		{
			return null;
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x002A304C File Offset: 0x002A124C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool IsValidJson(object input)
		{
			return true;
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x002A306C File Offset: 0x002A126C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SimulateClick(int pid, object direction, Action<string, Color> sendConsole)
		{
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x002A307C File Offset: 0x002A127C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHunt()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TreasureHunt.isFullReset = false;
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					TreasureHunt.client = new HttpClient();
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x002A3178 File Offset: 0x002A1378
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QRbgdrJo4to036qcrYOX()
		{
			return true;
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x002A3180 File Offset: 0x002A1380
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHunt LTayZMJojF56ROWBI6cH()
		{
			return null;
		}

		// Token: 0x0400422A RID: 16938
		private static readonly HttpClient client;

		// Token: 0x0400422B RID: 16939
		private static bool isFullReset;

		// Token: 0x0400422C RID: 16940
		private static TreasureHunt X1xSblJoxJDTBmcE1Ixy;

		// Token: 0x02000E9F RID: 3743
		[NullableContext(0)]
		public struct RECT
		{
			// Token: 0x0400422D RID: 16941
			public int Left;

			// Token: 0x0400422E RID: 16942
			public int Top;

			// Token: 0x0400422F RID: 16943
			public int Right;

			// Token: 0x04004230 RID: 16944
			public int Bottom;
		}
	}
}
