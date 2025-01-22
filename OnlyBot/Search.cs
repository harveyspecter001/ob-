using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CeFcm4kuMpCvdFmV8C;
using OpenCvSharp;

namespace OnlyBot
{
	// Token: 0x02000E96 RID: 3734
	[Nullable(0)]
	[NullableContext(1)]
	public class Search
	{
		// Token: 0x0600B1FC RID: 45564
		[DllImport("user32.dll")]
		private static extern bool EnumWindows(Search.EnumWindowsProc enumProc, IntPtr lParam);

		// Token: 0x0600B1FD RID: 45565
		[DllImport("user32.dll")]
		private static extern void GetWindowThreadProcessId(IntPtr hwnd, out uint lpdwProcessId);

		// Token: 0x0600B1FE RID: 45566
		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hWnd, out Search.RECT lpRect);

		// Token: 0x0600B1FF RID: 45567
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x0600B200 RID: 45568 RVA: 0x002A2934 File Offset: 0x002A0B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Zaap(int pid, Image targetImage)
		{
			return true;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x002A2960 File Offset: 0x002A0B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float GetScalingFactor()
		{
			return (float)0;
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x002A2980 File Offset: 0x002A0B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetPixelColorAtMousePosition(int x, int y, int cursorOffsetX = -9, int cursorOffsetY = -10)
		{
			return (Color)null;
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x002A29C8 File Offset: 0x002A0BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetPixelColorChangeMap(int x, int y)
		{
			return (Color)null;
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x002A2A10 File Offset: 0x002A0C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Fight(int pid, Image targetImage, out OpenCvSharp.Point matchLocation)
		{
			return true;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x002A2A3C File Offset: 0x002A0C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Image(int pid, Image targetImage, out OpenCvSharp.Point matchLocation)
		{
			return true;
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x002A2A68 File Offset: 0x002A0C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ImageRectangle(int pid, Image targetImage, out OpenCvSharp.Point matchLocation)
		{
			return true;
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x002A2A94 File Offset: 0x002A0C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<OpenCvSharp.Point> FindAllMatches(int pid, Image targetImage)
		{
			return null;
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x002A2AB4 File Offset: 0x002A0CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr GetDofusWindowHandle(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x002A2AC8 File Offset: 0x002A0CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Gather(int pid, Image targetImage, Action<string, Color> sendConsole)
		{
			return true;
		}

		// Token: 0x0600B20A RID: 45578
		[DllImport("user32.dll")]
		private static extern bool GetClientRect(IntPtr hWnd, out Search.RECT lpRect);

		// Token: 0x0600B20B RID: 45579
		[DllImport("user32.dll")]
		private static extern bool ClientToScreen(IntPtr hWnd, ref System.Drawing.Point lpPoint);

		// Token: 0x0600B20C RID: 45580 RVA: 0x002A2AF4 File Offset: 0x002A0CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool InventairePods(int pid, Image targetImage)
		{
			return true;
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x002A2B20 File Offset: 0x002A0D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DetectAndHighlightPositions(int pid, [TupleElementNames(new string[]
		{
			"position",
			"name"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1
		})] List<ValueTuple<OpenCvSharp.Point, string>> resources)
		{
			return true;
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x002A2B4C File Offset: 0x002A0D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DetectAndClickPositions(int pid, [TupleElementNames(new string[]
		{
			"position",
			"name"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1
		})] List<ValueTuple<OpenCvSharp.Point, string>> resources)
		{
			return true;
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x002A2B78 File Offset: 0x002A0D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowResourceScreen(int pid, [TupleElementNames(new string[]
		{
			"position",
			"name"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1
		})] List<ValueTuple<OpenCvSharp.Point, string>> resources, OpenCvSharp.Point? newResource, string newResourceName)
		{
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x002A2B98 File Offset: 0x002A0D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightAllGreenAreas(IntPtr hwnd)
		{
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x002A2BA8 File Offset: 0x002A0DA8
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<int, OpenCvSharp.Point> CountGreenAreas(IntPtr hwnd, OpenCvSharp.Point targetPosition, int minTileSize = 25)
		{
			return null;
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<int, OpenCvSharp.Point> CountBlueAreas(IntPtr hwnd, OpenCvSharp.Point targetPosition, int minTileSize = 10)
		{
			return null;
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x002A2BC8 File Offset: 0x002A0DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowIsometricGrid(int pid, double tileHeight, int offsetX = 0, int offsetY = 0)
		{
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x002A2BD8 File Offset: 0x002A0DD8
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: TupleElementNames(new string[]
		{
			"x",
			"y"
		})]
		public ValueTuple<int, int> GetCellId(int pid, int cellNumber, double tileHeight, int offsetX = 0, int offsetY = 0, bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x002A2C04 File Offset: 0x002A0E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool VerifyAndUpdateMap(int pid, Action<string, Color> sendConsole, string changeMapValue)
		{
			return true;
		}

		// Token: 0x0600B216 RID: 45590 RVA: 0x002A2C24 File Offset: 0x002A0E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DetectColorRectangle(int pid, Scalar targetColor, int rectWidth, int rectHeight)
		{
			return true;
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x002A2C34 File Offset: 0x002A0E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DetectColorClusters(string imagePath, Scalar targetColor, int tolerance, int minClusterSize, out string annotatedImagePath)
		{
			return true;
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x002A2C44 File Offset: 0x002A0E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FindColorInRectangle(int pid, Scalar targetColor, int tolerance, Rect searchRegion, out OpenCvSharp.Point matchLocation)
		{
			return true;
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x002A2C54 File Offset: 0x002A0E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Bitmap CaptureWindow(IntPtr hwnd, int x, int y, int width, int height)
		{
			return null;
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x002A2CB0 File Offset: 0x002A0EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Mat BitmapToMat(Bitmap bitmap)
		{
			return null;
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x002A2CD0 File Offset: 0x002A0ED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IntPtr FindWindowByPid(int pid)
		{
			return (IntPtr)null;
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x002A2CE4 File Offset: 0x002A0EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Search()
		{
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x002A2CF4 File Offset: 0x002A0EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Search()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x002A2D08 File Offset: 0x002A0F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QjM5h5Jo9DIUa0SobIAk()
		{
			return true;
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x002A2D10 File Offset: 0x002A0F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Search IDLsCGJo2uPZkSgpCaMg()
		{
			return null;
		}

		// Token: 0x0400420B RID: 16907
		private static Search g4wMAHJoddOUy6E6RMk5;

		// Token: 0x02000E97 RID: 3735
		[NullableContext(0)]
		public struct RECT
		{
			// Token: 0x0400420C RID: 16908
			public int Left;

			// Token: 0x0400420D RID: 16909
			public int Top;

			// Token: 0x0400420E RID: 16910
			public int Right;

			// Token: 0x0400420F RID: 16911
			public int Bottom;
		}

		// Token: 0x02000E98 RID: 3736
		[NullableContext(0)]
		public sealed class EnumWindowsProc : MulticastDelegate
		{
			// Token: 0x0600B220 RID: 45600
			public extern EnumWindowsProc(object @object, IntPtr method);

			// Token: 0x0600B221 RID: 45601
			public extern bool Invoke(IntPtr hwnd, IntPtr lParam);

			// Token: 0x0600B222 RID: 45602
			public extern IAsyncResult BeginInvoke(IntPtr hwnd, IntPtr lParam, AsyncCallback callback, object @object);

			// Token: 0x0600B223 RID: 45603
			public extern bool EndInvoke(IAsyncResult result);

			// Token: 0x0600B224 RID: 45604 RVA: 0x002F5D5C File Offset: 0x002F3F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static EnumWindowsProc()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}
		}
	}
}
