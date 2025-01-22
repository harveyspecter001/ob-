using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;
using FontAwesome.Sharp;

namespace OnlyBot.Forms
{
	// Token: 0x02000EB6 RID: 3766
	[Nullable(0)]
	[NullableContext(1)]
	public partial class ConsoleForm : Form
	{
		// Token: 0x0600B2D4 RID: 45780 RVA: 0x002A46B8 File Offset: 0x002A28B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleForm(int pid, string personnageName)
		{
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x002A46C8 File Offset: 0x002A28C8
		public static bool IsPaused
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x002A46D8 File Offset: 0x002A28D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeConsole()
		{
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x002A46E8 File Offset: 0x002A28E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeControls()
		{
		}

		// Token: 0x0600B2D8 RID: 45784 RVA: 0x002A46F8 File Offset: 0x002A28F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendConsole(string message, Color couleur)
		{
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x002A4708 File Offset: 0x002A2908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadConsoleHistory()
		{
		}

		// Token: 0x0600B2DA RID: 45786 RVA: 0x002A4718 File Offset: 0x002A2918
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BtnExplorer_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x002A4728 File Offset: 0x002A2928
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BtnPlayStop_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x002A4754 File Offset: 0x002A2954
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BtnPauseResume_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x002A47A0 File Offset: 0x002A29A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConsoleForm()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x002A47B4 File Offset: 0x002A29B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jcYc4UJoPgkG87n4kvkP()
		{
			return true;
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x002A47BC File Offset: 0x002A29BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConsoleForm xlA34aJoSBjwTmkTDCY0()
		{
			return null;
		}

		// Token: 0x04004319 RID: 17177
		private int pid;

		// Token: 0x0400431A RID: 17178
		private string personnageName;

		// Token: 0x0400431B RID: 17179
		private RichTextBox richTextBoxConsole;

		// Token: 0x0400431C RID: 17180
		private bool isScriptRunning;

		// Token: 0x0400431D RID: 17181
		private string loadedScriptPath;

		// Token: 0x0400431E RID: 17182
		private Thread scriptThread;

		// Token: 0x0400431F RID: 17183
		private static bool isPaused;

		// Token: 0x04004320 RID: 17184
		private IconButton btnPauseResume;

		// Token: 0x04004321 RID: 17185
		private CancellationTokenSource cancellationTokenSource;

		// Token: 0x04004322 RID: 17186
		private CancellationToken token;

		// Token: 0x04004323 RID: 17187
		[Nullable(0)]
		private IContainer components;

		// Token: 0x04004324 RID: 17188
		private static ConsoleForm yS1ftLJoi2V3xKZ2KLKQ;
	}
}
