using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog
{
	// Token: 0x020007E8 RID: 2024
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeAppearanceDialogLeave : IMessage<ChangeAppearanceDialogLeave>, IMessage, IEquatable<ChangeAppearanceDialogLeave>, IDeepCloneable<ChangeAppearanceDialogLeave>, IBufferMessage
	{
		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x00223900 File Offset: 0x00221B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeAppearanceDialogLeave> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x00223910 File Offset: 0x00221B10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x00223920 File Offset: 0x00221B20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x00223930 File Offset: 0x00221B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogLeave()
		{
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x00223940 File Offset: 0x00221B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogLeave(ChangeAppearanceDialogLeave other)
		{
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00223950 File Offset: 0x00221B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogLeave Clone()
		{
			return null;
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x00223960 File Offset: 0x00221B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x00223970 File Offset: 0x00221B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChangeAppearanceDialogLeave other)
		{
			return true;
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x00223980 File Offset: 0x00221B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x00223990 File Offset: 0x00221B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x002239A0 File Offset: 0x00221BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x002239B0 File Offset: 0x00221BB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x002239C0 File Offset: 0x00221BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x002239D0 File Offset: 0x00221BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChangeAppearanceDialogLeave other)
		{
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x002239E0 File Offset: 0x00221BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x002239F0 File Offset: 0x00221BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x00223A00 File Offset: 0x00221C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChangeAppearanceDialogLeave()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ChangeAppearanceDialogLeave._parser = new MessageParser<ChangeAppearanceDialogLeave>(() => null);
						num2 = 4;
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_82;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 1;
					}
				}
				IL_82:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00223AD0 File Offset: 0x00221CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kR1o27OFMm3AqWNHjB5Y()
		{
			return true;
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x00223AD8 File Offset: 0x00221CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChangeAppearanceDialogLeave xpDeTFOFuhm0YWcSYmbD()
		{
			return null;
		}

		// Token: 0x040022BF RID: 8895
		private static readonly MessageParser<ChangeAppearanceDialogLeave> _parser;

		// Token: 0x040022C0 RID: 8896
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C1 RID: 8897
		internal static ChangeAppearanceDialogLeave YhINiKOFSWd0GVIYql9l;
	}
}
