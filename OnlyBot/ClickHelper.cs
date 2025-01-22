using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000E60 RID: 3680
	public static class ClickHelper
	{
		// Token: 0x0600B049 RID: 45129
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600B04A RID: 45130
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int X, int Y);

		// Token: 0x0600B04B RID: 45131
		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hwnd, out ClickHelper.RECT rect);

		// Token: 0x0600B04C RID: 45132 RVA: 0x002A1BB0 File Offset: 0x0029FDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr GetDofusWindowHandle(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x002A1BC4 File Offset: 0x0029FDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SimulateClick(int pid, int x, int y, bool isLeftClick)
		{
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x002A1BD4 File Offset: 0x0029FDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float GetScalingFactor()
		{
			return (float)0;
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x002A1BF4 File Offset: 0x0029FDF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ClickHelper()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x002A1C08 File Offset: 0x0029FE08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VhBlZ4Jv7Q0UsXr4YHpp()
		{
			return true;
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x002A1C10 File Offset: 0x0029FE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClickHelper mWEkSoJvTiqo3QFTfiTN()
		{
			return null;
		}

		// Token: 0x04004106 RID: 16646
		internal static ClickHelper LUiAw8JvQg3XbidX83DZ;

		// Token: 0x02000E61 RID: 3681
		public struct RECT
		{
			// Token: 0x04004107 RID: 16647
			public int Left;

			// Token: 0x04004108 RID: 16648
			public int Top;

			// Token: 0x04004109 RID: 16649
			public int Right;

			// Token: 0x0400410A RID: 16650
			public int Bottom;
		}
	}
}
