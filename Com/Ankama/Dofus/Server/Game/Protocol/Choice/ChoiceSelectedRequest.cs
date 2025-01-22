using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008C1 RID: 2241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChoiceSelectedRequest : IMessage<ChoiceSelectedRequest>, IMessage, IEquatable<ChoiceSelectedRequest>, IDeepCloneable<ChoiceSelectedRequest>, IBufferMessage
	{
		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x00233ABC File Offset: 0x00231CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceSelectedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x00233ACC File Offset: 0x00231CCC
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

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06006CE3 RID: 27875 RVA: 0x00233ADC File Offset: 0x00231CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00233AEC File Offset: 0x00231CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectedRequest()
		{
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00233AFC File Offset: 0x00231CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectedRequest(ChoiceSelectedRequest other)
		{
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00233B0C File Offset: 0x00231D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectedRequest Clone()
		{
			return null;
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06006CE7 RID: 27879 RVA: 0x00233B1C File Offset: 0x00231D1C
		// (set) Token: 0x06006CE8 RID: 27880 RVA: 0x00233B2C File Offset: 0x00231D2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00233B3C File Offset: 0x00231D3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x00233B4C File Offset: 0x00231D4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChoiceSelectedRequest other)
		{
			return true;
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00233B5C File Offset: 0x00231D5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00233B6C File Offset: 0x00231D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00233B7C File Offset: 0x00231D7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00233B8C File Offset: 0x00231D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00233B9C File Offset: 0x00231D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00233BAC File Offset: 0x00231DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChoiceSelectedRequest other)
		{
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00233BBC File Offset: 0x00231DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00233BCC File Offset: 0x00231DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00233BDC File Offset: 0x00231DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChoiceSelectedRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 2:
					ChoiceSelectedRequest._parser = new MessageParser<ChoiceSelectedRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00233CA8 File Offset: 0x00231EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f1MWYSJANpbP16k1MAI0()
		{
			return true;
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00233CB0 File Offset: 0x00231EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChoiceSelectedRequest s5iXx1JAxsFhZD0KpBYD()
		{
			return null;
		}

		// Token: 0x040025FB RID: 9723
		private static readonly MessageParser<ChoiceSelectedRequest> _parser;

		// Token: 0x040025FC RID: 9724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025FD RID: 9725
		public const int PositionFieldNumber = 1;

		// Token: 0x040025FE RID: 9726
		private int position_;

		// Token: 0x040025FF RID: 9727
		internal static ChoiceSelectedRequest gJpMDOJAXdhgCBqomwx1;
	}
}
