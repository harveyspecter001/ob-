using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000705 RID: 1797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseSearchRequest : IMessage<ExchangeBidHouseSearchRequest>, IMessage, IEquatable<ExchangeBidHouseSearchRequest>, IDeepCloneable<ExchangeBidHouseSearchRequest>, IBufferMessage
	{
		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060057DB RID: 22491 RVA: 0x00215670 File Offset: 0x00213870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHouseSearchRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x00215680 File Offset: 0x00213880
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x00215690 File Offset: 0x00213890
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

		// Token: 0x060057DE RID: 22494 RVA: 0x002156A0 File Offset: 0x002138A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseSearchRequest()
		{
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x002156B0 File Offset: 0x002138B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseSearchRequest(ExchangeBidHouseSearchRequest other)
		{
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x002156C0 File Offset: 0x002138C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseSearchRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x002156D0 File Offset: 0x002138D0
		// (set) Token: 0x060057E2 RID: 22498 RVA: 0x002156E0 File Offset: 0x002138E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectGid
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

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x002156F0 File Offset: 0x002138F0
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00215700 File Offset: 0x00213900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Follow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00215710 File Offset: 0x00213910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x00215720 File Offset: 0x00213920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseSearchRequest other)
		{
			return true;
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00215730 File Offset: 0x00213930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00215740 File Offset: 0x00213940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x00215750 File Offset: 0x00213950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x00215760 File Offset: 0x00213960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00215770 File Offset: 0x00213970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00215780 File Offset: 0x00213980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseSearchRequest other)
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00215790 File Offset: 0x00213990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x002157A0 File Offset: 0x002139A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x002157B0 File Offset: 0x002139B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseSearchRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ExchangeBidHouseSearchRequest._parser = new MessageParser<ExchangeBidHouseSearchRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x0021587C File Offset: 0x00213A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SvBRlvOusJlCTjS3WwOH()
		{
			return true;
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x00215884 File Offset: 0x00213A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseSearchRequest EbSAstOudiP5DgjTdsRY()
		{
			return null;
		}

		// Token: 0x04001ED1 RID: 7889
		private static readonly MessageParser<ExchangeBidHouseSearchRequest> _parser;

		// Token: 0x04001ED2 RID: 7890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ED3 RID: 7891
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001ED4 RID: 7892
		private int objectGid_;

		// Token: 0x04001ED5 RID: 7893
		public const int FollowFieldNumber = 2;

		// Token: 0x04001ED6 RID: 7894
		private bool follow_;

		// Token: 0x04001ED7 RID: 7895
		private static ExchangeBidHouseSearchRequest bgb49XOugQgDog2GGAQ5;
	}
}
