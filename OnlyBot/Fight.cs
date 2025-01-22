using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000E63 RID: 3683
	[NullableContext(1)]
	[Nullable(0)]
	internal class Fight
	{
		// Token: 0x0600B057 RID: 45143 RVA: 0x002A1C18 File Offset: 0x0029FE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Fight(int pid, Action<string, Color> sendConsole)
		{
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x002A1C28 File Offset: 0x0029FE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Combat()
		{
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x002A1C38 File Offset: 0x0029FE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartCombat()
		{
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x002A1C48 File Offset: 0x0029FE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool Verif_Combat()
		{
			return true;
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x002A1C58 File Offset: 0x0029FE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool Verif_CombatChasse()
		{
			return true;
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x002A1C68 File Offset: 0x0029FE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Script_Ahk(string scriptName)
		{
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x002A1C94 File Offset: 0x0029FE94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool Verif_MonTour()
		{
			return true;
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x002A1CC0 File Offset: 0x0029FEC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Rapprocher()
		{
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x002A1CE0 File Offset: 0x0029FEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<int> GetNonDiagonalCells(int playerCellId)
		{
			return null;
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x002A1CF0 File Offset: 0x0029FEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetNextCell(List<int> directions, int targetCellId)
		{
			return 0;
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x002A1D00 File Offset: 0x0029FF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LancerSpell()
		{
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x002A1D5C File Offset: 0x0029FF5C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ChasseAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x002A1D6C File Offset: 0x0029FF6C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task StartCombatChasseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x002A1D7C File Offset: 0x0029FF7C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task LancerSpellChasseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002A1D8C File Offset: 0x0029FF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Chasse()
		{
			return true;
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002A1D9C File Offset: 0x0029FF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartCombatChasse()
		{
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x002A1DAC File Offset: 0x0029FFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LancerSpellChasse()
		{
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x002A1DD8 File Offset: 0x0029FFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IntPtr FindWindowByPid(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B069 RID: 45161
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out Fight.RECT lpRect);

		// Token: 0x0600B06A RID: 45162
		[DllImport("user32.dll")]
		private static extern bool EnumWindows(Fight.EnumWindowsProc lpEnumFunc, IntPtr lParam);

		// Token: 0x0600B06B RID: 45163
		[DllImport("user32.dll")]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x0600B06C RID: 45164
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x0600B06D RID: 45165
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x0600B06E RID: 45166 RVA: 0x002A1DEC File Offset: 0x0029FFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BringWindowToFront(IntPtr hWnd)
		{
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x002A1DFC File Offset: 0x0029FFFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Bitmap CaptureWindow(IntPtr hwnd)
		{
			return null;
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x002A1E1C File Offset: 0x002A001C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckForColorPixels(int pid, int red, int green, int blue, int tolerance, int minClusterSize)
		{
			return true;
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x002A1E48 File Offset: 0x002A0048
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Fight()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x002A1E5C File Offset: 0x002A005C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool db6OpNJvHCjONMCLEPjc()
		{
			return true;
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x002A1E64 File Offset: 0x002A0064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Fight UqbZYmJvYF2XcEA6yR9c()
		{
			return null;
		}

		// Token: 0x0400410D RID: 16653
		private int pid;

		// Token: 0x0400410E RID: 16654
		private Action<string, Color> sendConsole;

		// Token: 0x0400410F RID: 16655
		private object fightManager;

		// Token: 0x04004110 RID: 16656
		private object NomPerso;

		// Token: 0x04004111 RID: 16657
		private int currentRound;

		// Token: 0x04004112 RID: 16658
		internal static object HMX16tJvpEuLfFcnOLbO;

		// Token: 0x02000E64 RID: 3684
		[NullableContext(0)]
		public struct RECT
		{
			// Token: 0x04004113 RID: 16659
			public int Left;

			// Token: 0x04004114 RID: 16660
			public int Top;

			// Token: 0x04004115 RID: 16661
			public int Right;

			// Token: 0x04004116 RID: 16662
			public int Bottom;
		}

		// Token: 0x02000E65 RID: 3685
		[NullableContext(0)]
		private sealed class EnumWindowsProc : MulticastDelegate
		{
			// Token: 0x0600B074 RID: 45172
			public extern EnumWindowsProc(object @object, IntPtr method);

			// Token: 0x0600B075 RID: 45173
			public extern bool Invoke(IntPtr hWnd, IntPtr lParam);

			// Token: 0x0600B076 RID: 45174
			public extern IAsyncResult BeginInvoke(IntPtr hWnd, IntPtr lParam, AsyncCallback callback, object @object);

			// Token: 0x0600B077 RID: 45175
			public extern bool EndInvoke(IAsyncResult result);

			// Token: 0x0600B078 RID: 45176 RVA: 0x002F4E08 File Offset: 0x002F3008
			[MethodImpl(MethodImplOptions.NoInlining)]
			static EnumWindowsProc()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}
		}
	}
}
