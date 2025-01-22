using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot.Utils
{
	// Token: 0x02000EAB RID: 3755
	public class AutoHotKeyHelper
	{
		// Token: 0x0600B294 RID: 45716 RVA: 0x002A3244 File Offset: 0x002A1444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoHotKeyHelper(int processId)
		{
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x002A3254 File Offset: 0x002A1454
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Script_Ahk(string scriptName)
		{
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x002A3280 File Offset: 0x002A1480
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GenerateAndRunAutoHotKeyScript(string key)
		{
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x002A32AC File Offset: 0x002A14AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAhkForResources([Nullable(new byte[]
		{
			1,
			0
		})] [TupleElementNames(new string[]
		{
			"x",
			"y"
		})] List<ValueTuple<int, int>> resourceCoordinates)
		{
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x002A32F0 File Offset: 0x002A14F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IntPtr FindWindowByPid(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B299 RID: 45721
		[NullableContext(1)]
		[DllImport("user32.dll")]
		private static extern bool EnumWindows(AutoHotKeyHelper.EnumWindowsProc lpEnumFunc, IntPtr lParam);

		// Token: 0x0600B29A RID: 45722
		[DllImport("user32.dll")]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x0600B29B RID: 45723
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x0600B29C RID: 45724
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x0600B29D RID: 45725 RVA: 0x002A3304 File Offset: 0x002A1504
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BringWindowToFront(IntPtr hWnd)
		{
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x002A3314 File Offset: 0x002A1514
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoHotKeyHelper()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x002A3328 File Offset: 0x002A1528
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WQYGKoJooJEGlGKRNjeo()
		{
			return true;
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x002A3330 File Offset: 0x002A1530
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoHotKeyHelper k68vAxJo1axmVRbBvbDo()
		{
			return null;
		}

		// Token: 0x040042F3 RID: 17139
		private int pid;

		// Token: 0x040042F4 RID: 17140
		internal static AutoHotKeyHelper elBbmEJovuhbo1vp5RqD;

		// Token: 0x02000EAC RID: 3756
		public struct RECT
		{
			// Token: 0x040042F5 RID: 17141
			public int Left;

			// Token: 0x040042F6 RID: 17142
			public int Top;

			// Token: 0x040042F7 RID: 17143
			public int Right;

			// Token: 0x040042F8 RID: 17144
			public int Bottom;
		}

		// Token: 0x02000EAD RID: 3757
		private sealed class EnumWindowsProc : MulticastDelegate
		{
			// Token: 0x0600B2A1 RID: 45729
			public extern EnumWindowsProc(object @object, IntPtr method);

			// Token: 0x0600B2A2 RID: 45730
			public extern bool Invoke(IntPtr hWnd, IntPtr lParam);

			// Token: 0x0600B2A3 RID: 45731
			public extern IAsyncResult BeginInvoke(IntPtr hWnd, IntPtr lParam, AsyncCallback callback, object @object);

			// Token: 0x0600B2A4 RID: 45732
			public extern bool EndInvoke(IAsyncResult result);

			// Token: 0x0600B2A5 RID: 45733 RVA: 0x002F6220 File Offset: 0x002F4420
			[MethodImpl(MethodImplOptions.NoInlining)]
			static EnumWindowsProc()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}
		}
	}
}
