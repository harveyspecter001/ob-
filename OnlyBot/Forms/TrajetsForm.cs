using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot.Forms
{
	// Token: 0x02000ECD RID: 3789
	public partial class TrajetsForm : Form
	{
		// Token: 0x0600B397 RID: 45975 RVA: 0x002A4DE4 File Offset: 0x002A2FE4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrajetsForm(int pid, string personnageName)
		{
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x002A4DF4 File Offset: 0x002A2FF4
		[NullableContext(1)]
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleScriptExecution(Button btnPlayStop, TextBox huntInput)
		{
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x002A4E04 File Offset: 0x002A3004
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateButtonState(Button button, string text, Color color)
		{
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x002A4E14 File Offset: 0x002A3014
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowMessage(string message, string title, MessageBoxIcon icon)
		{
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x002A4E24 File Offset: 0x002A3024
		[DebuggerStepThrough]
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> IsUserPremiumAsync(string licenseKey)
		{
			return null;
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x002A4E34 File Offset: 0x002A3034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateHuntProgress(int currentHunt)
		{
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x002A4E64 File Offset: 0x002A3064
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ComboBoxSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x002A4E74 File Offset: 0x002A3074
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowTreasureHuntPanel(Panel parentPanel)
		{
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x002A4E84 File Offset: 0x002A3084
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TrajetsForm()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x002A4E98 File Offset: 0x002A3098
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z5ekIDJ12oVClhTvrTFM()
		{
			return true;
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x002A4EA0 File Offset: 0x002A30A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TrajetsForm C5B4meJ1EuofcZd32gfv()
		{
			return null;
		}

		// Token: 0x0400440B RID: 17419
		private int pid;

		// Token: 0x0400440C RID: 17420
		[Nullable(1)]
		private string personnageName;

		// Token: 0x0400440D RID: 17421
		private bool isScriptRunning;

		// Token: 0x0400440E RID: 17422
		[Nullable(1)]
		private CancellationTokenSource cancellationTokenSource;

		// Token: 0x0400440F RID: 17423
		private IContainer components;

		// Token: 0x04004410 RID: 17424
		private ComboBox comboBoxSelector;

		// Token: 0x04004411 RID: 17425
		private Panel optionPanel;

		// Token: 0x04004412 RID: 17426
		private Label huntProgressLabel;

		// Token: 0x04004413 RID: 17427
		internal static TrajetsForm zdNoJqJ19f3JRoyFJXqY;
	}
}
