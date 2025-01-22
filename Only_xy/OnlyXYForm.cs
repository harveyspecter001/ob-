using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;

namespace Only_xy
{
	// Token: 0x02000E59 RID: 3673
	[NullableContext(1)]
	[Nullable(0)]
	public partial class OnlyXYForm : Form
	{
		// Token: 0x0600B013 RID: 45075
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

		// Token: 0x0600B014 RID: 45076
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600B015 RID: 45077
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600B016 RID: 45078 RVA: 0x002A19A4 File Offset: 0x0029FBA4
		// (remove) Token: 0x0600B017 RID: 45079 RVA: 0x002A19B4 File Offset: 0x0029FBB4
		public event OnlyXYForm.PositionSelectedEventHandler PositionSelected
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

		// Token: 0x0600B018 RID: 45080 RVA: 0x002A19C4 File Offset: 0x0029FBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnlyXYForm(int pid)
		{
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x002A19D4 File Offset: 0x0029FBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnlyXYForm_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x002A19E4 File Offset: 0x0029FBE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Timer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x002A19F4 File Offset: 0x0029FBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetProcessId(IntPtr hWnd)
		{
			return 0;
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x002A1A04 File Offset: 0x0029FC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectPosition(int x, int y)
		{
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x002A1A14 File Offset: 0x0029FC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePosition()
		{
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x002A1A24 File Offset: 0x0029FC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float GetScalingFactor()
		{
			return (float)0;
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x002A1A54 File Offset: 0x0029FC54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OnlyXYForm()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x002A1A68 File Offset: 0x0029FC68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tc5RpaJvhcwycVqQVkgP()
		{
			return true;
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x002A1A70 File Offset: 0x0029FC70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OnlyXYForm ngmyw2Jvr6HZ5flDZj55()
		{
			return null;
		}

		// Token: 0x040040E9 RID: 16617
		private TextBox txtX;

		// Token: 0x040040EA RID: 16618
		private TextBox txtY;

		// Token: 0x040040EC RID: 16620
		private int pid;

		// Token: 0x040040ED RID: 16621
		[Nullable(0)]
		private Label labelPosition;

		// Token: 0x040040EE RID: 16622
		internal static OnlyXYForm xZg34FJvWTdBPuaS6YdJ;

		// Token: 0x02000E5A RID: 3674
		[NullableContext(0)]
		public sealed class PositionSelectedEventHandler : MulticastDelegate
		{
			// Token: 0x0600B023 RID: 45091
			public extern PositionSelectedEventHandler(object @object, IntPtr method);

			// Token: 0x0600B024 RID: 45092
			public extern void Invoke(int x, int y);

			// Token: 0x0600B025 RID: 45093
			public extern IAsyncResult BeginInvoke(int x, int y, AsyncCallback callback, object @object);

			// Token: 0x0600B026 RID: 45094
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0600B027 RID: 45095 RVA: 0x002F4C48 File Offset: 0x002F2E48
			[MethodImpl(MethodImplOptions.NoInlining)]
			static PositionSelectedEventHandler()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}
		}
	}
}
