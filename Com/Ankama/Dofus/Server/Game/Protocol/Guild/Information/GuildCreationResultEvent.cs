using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200050E RID: 1294
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCreationResultEvent : IMessage<GuildCreationResultEvent>, IMessage, IEquatable<GuildCreationResultEvent>, IDeepCloneable<GuildCreationResultEvent>, IBufferMessage
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x001EAA54 File Offset: 0x001E8C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildCreationResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x001EAA64 File Offset: 0x001E8C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x001EAA74 File Offset: 0x001E8C74
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

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001EAA84 File Offset: 0x001E8C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationResultEvent()
		{
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x001EAA94 File Offset: 0x001E8C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationResultEvent(GuildCreationResultEvent other)
		{
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x001EAAA4 File Offset: 0x001E8CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x001EAAB4 File Offset: 0x001E8CB4
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x001EAAC8 File Offset: 0x001E8CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialGroupOperationResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupOperationResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x001EAAD8 File Offset: 0x001E8CD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x001EAAE8 File Offset: 0x001E8CE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCreationResultEvent other)
		{
			return true;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x001EAAF8 File Offset: 0x001E8CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x001EAB08 File Offset: 0x001E8D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x001EAB18 File Offset: 0x001E8D18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x001EAB28 File Offset: 0x001E8D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x001EAB38 File Offset: 0x001E8D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x001EAB48 File Offset: 0x001E8D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCreationResultEvent other)
		{
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x001EAB58 File Offset: 0x001E8D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x001EAB68 File Offset: 0x001E8D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001EAB78 File Offset: 0x001E8D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCreationResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					GuildCreationResultEvent._parser = new MessageParser<GuildCreationResultEvent>(() => null);
					num2 = 4;
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x001EAC5C File Offset: 0x001E8E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lxEuuTOTkOlH3HPVZmvF()
		{
			return true;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x001EAC64 File Offset: 0x001E8E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCreationResultEvent h8IKoHOTlrq1g0Vk9HhX()
		{
			return null;
		}

		// Token: 0x0400157C RID: 5500
		private static readonly MessageParser<GuildCreationResultEvent> _parser;

		// Token: 0x0400157D RID: 5501
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400157E RID: 5502
		public const int ResultFieldNumber = 1;

		// Token: 0x0400157F RID: 5503
		private SocialGroupOperationResult result_;

		// Token: 0x04001580 RID: 5504
		internal static GuildCreationResultEvent NA78W8OTIMyyM4LEuv1w;
	}
}
