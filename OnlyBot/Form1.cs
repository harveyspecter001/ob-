using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;
using OnlyBot.Btn;

namespace OnlyBot
{
	// Token: 0x02000E85 RID: 3717
	[Nullable(0)]
	[NullableContext(1)]
	public partial class Form1 : Form
	{
		// Token: 0x0600B18C RID: 45452
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600B18D RID: 45453
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600B18E RID: 45454 RVA: 0x002A22F8 File Offset: 0x002A04F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Image LoadEmbeddedImage(string resourcePath)
		{
			return null;
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x002A2318 File Offset: 0x002A0518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Form1()
		{
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x002A2328 File Offset: 0x002A0528
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartPingOnLicense()
		{
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x002A2338 File Offset: 0x002A0538
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTimerElapsed(string licenceKey)
		{
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x002A2348 File Offset: 0x002A0548
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PingApi(string licenceKey)
		{
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x002A2358 File Offset: 0x002A0558
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Icon LoadEmbeddedIcon(string resourceName)
		{
			return null;
		}

		// Token: 0x0600B194 RID: 45460 RVA: 0x002A2378 File Offset: 0x002A0578
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnNewCharacterDetected(int pid)
		{
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x002A2388 File Offset: 0x002A0588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPersonnageButton(int pid)
		{
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x002A2398 File Offset: 0x002A0598
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemovePersonnageButton(BtnPersonnage btnPersonnage)
		{
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x002A23A8 File Offset: 0x002A05A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RepositionnerBoutons()
		{
		}

		// Token: 0x0600B198 RID: 45464 RVA: 0x002A23C8 File Offset: 0x002A05C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddDebugMessage(string message)
		{
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x002A23D8 File Offset: 0x002A05D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IntegrateFormInPanel(Form form)
		{
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x002A23E8 File Offset: 0x002A05E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddCustomButtons()
		{
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x002A23F8 File Offset: 0x002A05F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x002A2428 File Offset: 0x002A0628
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Form1()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x002A243C File Offset: 0x002A063C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lbQK4EJvMylpwxdKtlAp()
		{
			return true;
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x002A2444 File Offset: 0x002A0644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Form1 DWthTiJvuPSCNwpDSYpf()
		{
			return null;
		}

		// Token: 0x040041B4 RID: 16820
		public Size defaultSize;

		// Token: 0x040041B5 RID: 16821
		private DofusProcessScanner dofusScanner;

		// Token: 0x040041B6 RID: 16822
		private int lastButtonYPosition;

		// Token: 0x040041B7 RID: 16823
		private List<BtnPersonnage> boutonsPersonnages;

		// Token: 0x040041B8 RID: 16824
		private Panel mainPanel;

		// Token: 0x040041B9 RID: 16825
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040041BA RID: 16826
		public const int HTCAPTION = 2;

		// Token: 0x040041BB RID: 16827
		private PidWatcher pidWatcher;

		// Token: 0x040041BC RID: 16828
		private System.Timers.Timer apiPingTimer;

		// Token: 0x040041BD RID: 16829
		[Nullable(0)]
		private IContainer components;

		// Token: 0x040041BE RID: 16830
		internal static Form1 irmMmiJvS8IDDBRQ4yXk;
	}
}
