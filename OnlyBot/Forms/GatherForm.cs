using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CeFcm4kuMpCvdFmV8C;
using Only_xy;

namespace OnlyBot.Forms
{
	// Token: 0x02000EBA RID: 3770
	[Nullable(0)]
	[NullableContext(1)]
	public partial class GatherForm : Form
	{
		// Token: 0x0600B2F1 RID: 45809 RVA: 0x002A47C4 File Offset: 0x002A29C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GatherForm(int pid, string personnageName)
		{
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x002A47D4 File Offset: 0x002A29D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeForm()
		{
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x002A47E4 File Offset: 0x002A29E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SearchTimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x002A47F4 File Offset: 0x002A29F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SaveButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x002A4820 File Offset: 0x002A2A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float GetScalingFactor()
		{
			return (float)0;
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x002A4840 File Offset: 0x002A2A40
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InsertResourceIntoDatabase(int idGather, string nomGather, string mapPos, int x, int y, int r, int g, int b)
		{
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x002A4850 File Offset: 0x002A2A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetLicenseKey()
		{
			return null;
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x002A487C File Offset: 0x002A2A7C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VerifyButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x002A488C File Offset: 0x002A2A8C
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TesterButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2FA RID: 45818 RVA: 0x002A489C File Offset: 0x002A2A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void buttonToggleOnlyXY_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x002A48AC File Offset: 0x002A2AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnlyXYForm_PositionSelected(int x, int y)
		{
		}

		// Token: 0x0600B2FC RID: 45820
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x0600B2FD RID: 45821
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600B2FE RID: 45822 RVA: 0x002A48BC File Offset: 0x002A2ABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetProcessId(IntPtr hWnd)
		{
			return 0;
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x002A48CC File Offset: 0x002A2ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdatePosition(int posX, int posY, string mapPos, string mapid, int pid)
		{
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x002A4914 File Offset: 0x002A2B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GatherForm()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x002A4928 File Offset: 0x002A2B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R932w9JouV46udpfoZd2()
		{
			return true;
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x002A4930 File Offset: 0x002A2B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GatherForm yFJijLJo8Lx3iK8YBNF6()
		{
			return null;
		}

		// Token: 0x04004330 RID: 17200
		private Timer searchTimer;

		// Token: 0x04004331 RID: 17201
		private int pid;

		// Token: 0x04004332 RID: 17202
		private string personnageName;

		// Token: 0x04004333 RID: 17203
		private OnlyXYForm onlyXYForm;

		// Token: 0x04004334 RID: 17204
		private Dictionary<int, string> resources;

		// Token: 0x04004335 RID: 17205
		private ComboBox cbResource;

		// Token: 0x04004336 RID: 17206
		private TextBox txtX;

		// Token: 0x04004337 RID: 17207
		private TextBox txtY;

		// Token: 0x04004338 RID: 17208
		private TextBox txtMapPos;

		// Token: 0x04004339 RID: 17209
		private TextBox txtColor;

		// Token: 0x0400433A RID: 17210
		private Button btnSave;

		// Token: 0x0400433B RID: 17211
		private Button btnVerify;

		// Token: 0x0400433C RID: 17212
		private Button btnTester;

		// Token: 0x0400433D RID: 17213
		private Panel colorPanel;

		// Token: 0x0400433E RID: 17214
		[Nullable(0)]
		private IContainer components;

		// Token: 0x0400433F RID: 17215
		[Nullable(0)]
		private Button buttonToggleOnlyXY;

		// Token: 0x04004340 RID: 17216
		internal static GatherForm qQtbnlJoMWUslQMd8OM7;

		// Token: 0x02000EBB RID: 3771
		[Nullable(0)]
		public class Resource
		{
			// Token: 0x170020E0 RID: 8416
			// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002F6378 File Offset: 0x002F4578
			// (set) Token: 0x0600B308 RID: 45832 RVA: 0x002F6380 File Offset: 0x002F4580
			public string id
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020E1 RID: 8417
			// (get) Token: 0x0600B309 RID: 45833 RVA: 0x002F6390 File Offset: 0x002F4590
			// (set) Token: 0x0600B30A RID: 45834 RVA: 0x002F6398 File Offset: 0x002F4598
			public string id_gather
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020E2 RID: 8418
			// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002F63A8 File Offset: 0x002F45A8
			// (set) Token: 0x0600B30C RID: 45836 RVA: 0x002F63B0 File Offset: 0x002F45B0
			public string nom_gather
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020E3 RID: 8419
			// (get) Token: 0x0600B30D RID: 45837 RVA: 0x002F63C0 File Offset: 0x002F45C0
			// (set) Token: 0x0600B30E RID: 45838 RVA: 0x002F63C8 File Offset: 0x002F45C8
			public string map_Pos
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020E4 RID: 8420
			// (get) Token: 0x0600B30F RID: 45839 RVA: 0x002F63D8 File Offset: 0x002F45D8
			// (set) Token: 0x0600B310 RID: 45840 RVA: 0x002F63E0 File Offset: 0x002F45E0
			public string x
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020E5 RID: 8421
			// (get) Token: 0x0600B311 RID: 45841 RVA: 0x002F63F0 File Offset: 0x002F45F0
			// (set) Token: 0x0600B312 RID: 45842 RVA: 0x002F63F8 File Offset: 0x002F45F8
			public string y
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B313 RID: 45843 RVA: 0x002F6408 File Offset: 0x002F4608
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetX()
			{
				return 0;
			}

			// Token: 0x0600B314 RID: 45844 RVA: 0x002F6418 File Offset: 0x002F4618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetY()
			{
				return 0;
			}

			// Token: 0x0600B315 RID: 45845 RVA: 0x002F6428 File Offset: 0x002F4628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Resource()
			{
			}

			// Token: 0x0600B316 RID: 45846 RVA: 0x002F6438 File Offset: 0x002F4638
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Resource()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B317 RID: 45847 RVA: 0x002F644C File Offset: 0x002F464C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool OXga6rG71Wb3OW3pDVtD()
			{
				return true;
			}

			// Token: 0x0600B318 RID: 45848 RVA: 0x002F6454 File Offset: 0x002F4654
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static GatherForm.Resource Jvs4fuG7aeeL7rSf5TO3()
			{
				return null;
			}

			// Token: 0x04004347 RID: 17223
			private static GatherForm.Resource CGg4BvG7oHyda4YiVMEy;
		}
	}
}
