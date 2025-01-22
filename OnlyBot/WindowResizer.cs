using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000EA8 RID: 3752
	public class WindowResizer
	{
		// Token: 0x0600B27C RID: 45692
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x0600B27D RID: 45693
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x0600B27E RID: 45694
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x0600B27F RID: 45695
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x0600B280 RID: 45696
		[DllImport("user32.dll")]
		private static extern bool IsIconic(IntPtr hWnd);

		// Token: 0x0600B281 RID: 45697
		[DllImport("user32.dll")]
		private static extern bool IsZoomed(IntPtr hWnd);

		// Token: 0x0600B282 RID: 45698
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out WindowResizer.RECT lpRect);

		// Token: 0x0600B283 RID: 45699
		[DllImport("user32.dll")]
		private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

		// Token: 0x0600B284 RID: 45700
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

		// Token: 0x0600B285 RID: 45701
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int X, int Y);

		// Token: 0x0600B286 RID: 45702
		[DllImport("user32.dll")]
		private static extern bool mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x0600B287 RID: 45703 RVA: 0x002A3188 File Offset: 0x002A1388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WindowResizer(int pid)
		{
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x002A3198 File Offset: 0x002A1398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartResizingWindow()
		{
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x002A31A8 File Offset: 0x002A13A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SendAltEnter()
		{
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x002A31B8 File Offset: 0x002A13B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SimulateClick()
		{
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x002A31C8 File Offset: 0x002A13C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisableResize(IntPtr hWnd)
		{
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x002A31D8 File Offset: 0x002A13D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IntPtr GetWindowHandleByPid(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x002A31EC File Offset: 0x002A13EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WindowResizer()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x002A3200 File Offset: 0x002A1400
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ah6INXJoIse1MrvaXIor()
		{
			return true;
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x002A3208 File Offset: 0x002A1408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WindowResizer xw1WuiJokYPdllSYlJuc()
		{
			return null;
		}

		// Token: 0x040042EC RID: 17132
		private int pid;

		// Token: 0x040042ED RID: 17133
		private static WindowResizer ggLM5fJoKdVXYYRJw6S7;

		// Token: 0x02000EA9 RID: 3753
		private struct RECT
		{
			// Token: 0x040042EE RID: 17134
			public int Left;

			// Token: 0x040042EF RID: 17135
			public int Top;

			// Token: 0x040042F0 RID: 17136
			public int Right;

			// Token: 0x040042F1 RID: 17137
			public int Bottom;
		}
	}
}
