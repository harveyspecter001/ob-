using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008DC RID: 2268
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubscribeMultipleChannelRequest : IMessage<SubscribeMultipleChannelRequest>, IMessage, IEquatable<SubscribeMultipleChannelRequest>, IDeepCloneable<SubscribeMultipleChannelRequest>, IBufferMessage
	{
		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x002362EC File Offset: 0x002344EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubscribeMultipleChannelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x002362FC File Offset: 0x002344FC
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

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x0023630C File Offset: 0x0023450C
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

		// Token: 0x06006E31 RID: 28209 RVA: 0x0023631C File Offset: 0x0023451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeMultipleChannelRequest()
		{
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x0023632C File Offset: 0x0023452C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeMultipleChannelRequest(SubscribeMultipleChannelRequest other)
		{
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x0023633C File Offset: 0x0023453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscribeMultipleChannelRequest Clone()
		{
			return null;
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x0023634C File Offset: 0x0023454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Channel> ChannelEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0023635C File Offset: 0x0023455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Channel> ChannelDisabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x0023636C File Offset: 0x0023456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x0023637C File Offset: 0x0023457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubscribeMultipleChannelRequest other)
		{
			return true;
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x0023638C File Offset: 0x0023458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x0023639C File Offset: 0x0023459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x002363AC File Offset: 0x002345AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x002363BC File Offset: 0x002345BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x002363CC File Offset: 0x002345CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x002363DC File Offset: 0x002345DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubscribeMultipleChannelRequest other)
		{
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x002363EC File Offset: 0x002345EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x002363FC File Offset: 0x002345FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x0023640C File Offset: 0x0023460C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubscribeMultipleChannelRequest()
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
					num2 = 5;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					SubscribeMultipleChannelRequest._repeated_channelEnabled_codec = FieldCodec.ForEnum<Channel>(10U, (Channel x) => 0, (int x) => (Channel)null);
					num2 = 4;
					continue;
				case 4:
					SubscribeMultipleChannelRequest._repeated_channelDisabled_codec = FieldCodec.ForEnum<Channel>(18U, (Channel x) => 0, (int x) => (Channel)null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 6;
					continue;
				case 6:
					SubscribeMultipleChannelRequest._parser = new MessageParser<SubscribeMultipleChannelRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x00236564 File Offset: 0x00234764
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SCT0SkJA8GUq0RAW3gmS()
		{
			return true;
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x0023656C File Offset: 0x0023476C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubscribeMultipleChannelRequest gHKdDbJAZCWKOe8iNOAG()
		{
			return null;
		}

		// Token: 0x0400269D RID: 9885
		private static readonly MessageParser<SubscribeMultipleChannelRequest> _parser;

		// Token: 0x0400269E RID: 9886
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400269F RID: 9887
		public const int ChannelEnabledFieldNumber = 1;

		// Token: 0x040026A0 RID: 9888
		private static readonly FieldCodec<Channel> _repeated_channelEnabled_codec;

		// Token: 0x040026A1 RID: 9889
		private readonly RepeatedField<Channel> channelEnabled_;

		// Token: 0x040026A2 RID: 9890
		public const int ChannelDisabledFieldNumber = 2;

		// Token: 0x040026A3 RID: 9891
		private static readonly FieldCodec<Channel> _repeated_channelDisabled_codec;

		// Token: 0x040026A4 RID: 9892
		private readonly RepeatedField<Channel> channelDisabled_;

		// Token: 0x040026A5 RID: 9893
		private static SubscribeMultipleChannelRequest resvtAJAug9TNDyXGk8Z;
	}
}
