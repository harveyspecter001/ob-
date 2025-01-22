using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CeFcm4kuMpCvdFmV8C;

namespace OnlyBot
{
	// Token: 0x02000E90 RID: 3728
	[NullableContext(1)]
	[Nullable(0)]
	internal class MouseHook
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600B1E2 RID: 45538 RVA: 0x002A2624 File Offset: 0x002A0824
		// (remove) Token: 0x0600B1E3 RID: 45539 RVA: 0x002A2634 File Offset: 0x002A0834
		public static event Action<int, int> OnLeftClick
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

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x002A2644 File Offset: 0x002A0844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetHook()
		{
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x002A2654 File Offset: 0x002A0854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Unhook()
		{
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x002A2664 File Offset: 0x002A0864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B1E7 RID: 45543
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, MouseHook.HookProc lpfn, IntPtr hMod, uint dwThreadId);

		// Token: 0x0600B1E8 RID: 45544
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		// Token: 0x0600B1E9 RID: 45545
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600B1EA RID: 45546
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600B1EB RID: 45547 RVA: 0x002A2678 File Offset: 0x002A0878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MouseHook()
		{
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x002A2688 File Offset: 0x002A0888
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MouseHook()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					MouseHook.mouseProc = new MouseHook.HookProc(MouseHook.HookCallback);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 5:
					MouseHook.hookId = IntPtr.Zero;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x002A2778 File Offset: 0x002A0978
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SFg11FJoepUS3eTRikyB()
		{
			return true;
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x002A2780 File Offset: 0x002A0980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MouseHook yyd5rWJo3oxueBVtiONA()
		{
			return null;
		}

		// Token: 0x040041FE RID: 16894
		private static object mouseProc;

		// Token: 0x040041FF RID: 16895
		private static IntPtr hookId;

		// Token: 0x04004201 RID: 16897
		private static object pUjWr1JoBiTxrYdV261a;

		// Token: 0x02000E91 RID: 3729
		[NullableContext(0)]
		private sealed class HookProc : MulticastDelegate
		{
			// Token: 0x0600B1EF RID: 45551
			public extern HookProc(object @object, IntPtr method);

			// Token: 0x0600B1F0 RID: 45552
			public extern IntPtr Invoke(int nCode, IntPtr wParam, IntPtr lParam);

			// Token: 0x0600B1F1 RID: 45553
			public extern IAsyncResult BeginInvoke(int nCode, IntPtr wParam, IntPtr lParam, AsyncCallback callback, object @object);

			// Token: 0x0600B1F2 RID: 45554
			public extern IntPtr EndInvoke(IAsyncResult result);

			// Token: 0x0600B1F3 RID: 45555 RVA: 0x002F5D48 File Offset: 0x002F3F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			static HookProc()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}
		}

		// Token: 0x02000E92 RID: 3730
		[NullableContext(0)]
		private struct MSLLHOOKSTRUCT
		{
			// Token: 0x04004202 RID: 16898
			public MouseHook.POINT pt;

			// Token: 0x04004203 RID: 16899
			public int mouseData;

			// Token: 0x04004204 RID: 16900
			public int flags;

			// Token: 0x04004205 RID: 16901
			public int time;

			// Token: 0x04004206 RID: 16902
			public IntPtr dwExtraInfo;
		}

		// Token: 0x02000E93 RID: 3731
		[NullableContext(0)]
		private struct POINT
		{
			// Token: 0x04004207 RID: 16903
			public int x;

			// Token: 0x04004208 RID: 16904
			public int y;
		}
	}
}
