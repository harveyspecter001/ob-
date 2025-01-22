using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006E6 RID: 1766
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangePlayerRequest : IMessage<ExchangePlayerRequest>, IMessage, IEquatable<ExchangePlayerRequest>, IDeepCloneable<ExchangePlayerRequest>, IBufferMessage
	{
		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x00213A9C File Offset: 0x00211C9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangePlayerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x00213AAC File Offset: 0x00211CAC
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x00213ABC File Offset: 0x00211CBC
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

		// Token: 0x06005665 RID: 22117 RVA: 0x00213ACC File Offset: 0x00211CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerRequest()
		{
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00213ADC File Offset: 0x00211CDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerRequest(ExchangePlayerRequest other)
		{
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00213AEC File Offset: 0x00211CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangePlayerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06005668 RID: 22120 RVA: 0x00213AFC File Offset: 0x00211CFC
		// (set) Token: 0x06005669 RID: 22121 RVA: 0x00213B0C File Offset: 0x00211D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00213B1C File Offset: 0x00211D1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x00213B2C File Offset: 0x00211D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangePlayerRequest other)
		{
			return true;
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00213B3C File Offset: 0x00211D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00213B4C File Offset: 0x00211D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x00213B5C File Offset: 0x00211D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x00213B6C File Offset: 0x00211D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x00213B7C File Offset: 0x00211D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00213B8C File Offset: 0x00211D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangePlayerRequest other)
		{
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00213B9C File Offset: 0x00211D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00213BAC File Offset: 0x00211DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00213BBC File Offset: 0x00211DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangePlayerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				ExchangePlayerRequest._parser = new MessageParser<ExchangePlayerRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00213CA4 File Offset: 0x00211EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eJCbmLOML9qqElNH7IJV()
		{
			return true;
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00213CAC File Offset: 0x00211EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangePlayerRequest Fmy1qJOMWUjLjq86Rdjv()
		{
			return null;
		}

		// Token: 0x04001E4A RID: 7754
		private static readonly MessageParser<ExchangePlayerRequest> _parser;

		// Token: 0x04001E4B RID: 7755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E4C RID: 7756
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04001E4D RID: 7757
		private long targetId_;

		// Token: 0x04001E4E RID: 7758
		internal static ExchangePlayerRequest z76JfrOM6unfHD2x1sog;
	}
}
