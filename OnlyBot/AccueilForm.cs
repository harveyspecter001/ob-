using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;
using Only_xy;

namespace OnlyBot
{
	// Token: 0x02000E8A RID: 3722
	public partial class AccueilForm : Form
	{
		// Token: 0x0600B1B6 RID: 45494 RVA: 0x002A244C File Offset: 0x002A064C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccueilForm(int pid, string characterName)
		{
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x002A245C File Offset: 0x002A065C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateTimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x002A246C File Offset: 0x002A066C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFormInfo()
		{
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x002A247C File Offset: 0x002A067C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ButtonInPanelLog_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x002A2484 File Offset: 0x002A0684
		[NullableContext(1)]
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ButtonDetectMap_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x002A2494 File Offset: 0x002A0694
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetCharacterNameFromHandler(int pid)
		{
			return null;
		}

		// Token: 0x0600B1BC RID: 45500
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out AccueilForm.RECT lpRect);

		// Token: 0x0600B1BD RID: 45501
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600B1BE RID: 45502
		[DllImport("user32.dll")]
		private static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600B1BF RID: 45503
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x002A24C0 File Offset: 0x002A06C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x002A24D0 File Offset: 0x002A06D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IntPtr GetDofusWindowHandle(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x002A24E4 File Offset: 0x002A06E4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void buttonToggleOnlyXY_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x002A2514 File Offset: 0x002A0714
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccueilForm()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x002A2528 File Offset: 0x002A0728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool odCd12JvZW27DTlS09iW()
		{
			return true;
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x002A2530 File Offset: 0x002A0730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccueilForm RWndQMJvqy9eY16JFcY4()
		{
			return null;
		}

		// Token: 0x040041D5 RID: 16853
		private int pid;

		// Token: 0x040041D6 RID: 16854
		[Nullable(1)]
		private string characterName;

		// Token: 0x040041D7 RID: 16855
		[Nullable(1)]
		private Timer updateTimer;

		// Token: 0x040041D8 RID: 16856
		[Nullable(1)]
		private OnlyXYForm onlyXYForm;

		// Token: 0x040041D9 RID: 16857
		[Nullable(1)]
		private Search search;

		// Token: 0x040041DA RID: 16858
		private IContainer components;

		// Token: 0x040041DB RID: 16859
		private Label lblPid;

		// Token: 0x040041DC RID: 16860
		private Label lblName;

		// Token: 0x040041DD RID: 16861
		private TableLayoutPanel tableLayoutPanel;

		// Token: 0x040041DE RID: 16862
		private Panel panelData;

		// Token: 0x040041DF RID: 16863
		private Panel panelLog;

		// Token: 0x040041E0 RID: 16864
		private Panel panelClick;

		// Token: 0x040041E1 RID: 16865
		private Button button1;

		// Token: 0x040041E2 RID: 16866
		private Button buttonToggleOnlyXY;

		// Token: 0x040041E3 RID: 16867
		private Label labelX;

		// Token: 0x040041E4 RID: 16868
		private Label labelY;

		// Token: 0x040041E5 RID: 16869
		private TextBox textBoxX;

		// Token: 0x040041E6 RID: 16870
		private TextBox textBoxY;

		// Token: 0x040041E7 RID: 16871
		private RadioButton radioButtonLeft;

		// Token: 0x040041E8 RID: 16872
		private RadioButton radioButtonRight;

		// Token: 0x040041E9 RID: 16873
		private Button buttonInPanelLog;

		// Token: 0x040041EA RID: 16874
		private Button buttonDetectMap;

		// Token: 0x040041EB RID: 16875
		private static AccueilForm qblWagJv87lOfugJdliM;

		// Token: 0x02000E8B RID: 3723
		private struct RECT
		{
			// Token: 0x040041EC RID: 16876
			public int Left;

			// Token: 0x040041ED RID: 16877
			public int Top;

			// Token: 0x040041EE RID: 16878
			public int Right;

			// Token: 0x040041EF RID: 16879
			public int Bottom;
		}
	}
}
