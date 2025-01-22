using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004C0 RID: 1216
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRankCreateRequest : IMessage<GuildRankCreateRequest>, IMessage, IEquatable<GuildRankCreateRequest>, IDeepCloneable<GuildRankCreateRequest>, IBufferMessage
	{
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x001E33C4 File Offset: 0x001E15C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRankCreateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x001E33D4 File Offset: 0x001E15D4
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x001E33E4 File Offset: 0x001E15E4
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

		// Token: 0x06003A16 RID: 14870 RVA: 0x001E33F4 File Offset: 0x001E15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankCreateRequest()
		{
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x001E3404 File Offset: 0x001E1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankCreateRequest(GuildRankCreateRequest other)
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x001E3414 File Offset: 0x001E1614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankCreateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x001E3424 File Offset: 0x001E1624
		// (set) Token: 0x06003A1A RID: 14874 RVA: 0x001E3434 File Offset: 0x001E1634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ParentRankId
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x001E3444 File Offset: 0x001E1644
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x001E3454 File Offset: 0x001E1654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GfxId
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x001E3464 File Offset: 0x001E1664
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x001E3474 File Offset: 0x001E1674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001E3484 File Offset: 0x001E1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001E3494 File Offset: 0x001E1694
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRankCreateRequest other)
		{
			return true;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x001E34A4 File Offset: 0x001E16A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x001E34B4 File Offset: 0x001E16B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001E34C4 File Offset: 0x001E16C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001E34D4 File Offset: 0x001E16D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001E34E4 File Offset: 0x001E16E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x001E34F4 File Offset: 0x001E16F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRankCreateRequest other)
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x001E3504 File Offset: 0x001E1704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x001E3514 File Offset: 0x001E1714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001E3524 File Offset: 0x001E1724
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRankCreateRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GuildRankCreateRequest._parser = new MessageParser<GuildRankCreateRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x001E35F0 File Offset: 0x001E17F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O0pTKROQ6GKRcEm7q6tM()
		{
			return true;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x001E35F8 File Offset: 0x001E17F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRankCreateRequest qlXCdsOQLpJBJKRfGgUX()
		{
			return null;
		}

		// Token: 0x0400142D RID: 5165
		private static readonly MessageParser<GuildRankCreateRequest> _parser;

		// Token: 0x0400142E RID: 5166
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400142F RID: 5167
		public const int ParentRankIdFieldNumber = 1;

		// Token: 0x04001430 RID: 5168
		private int parentRankId_;

		// Token: 0x04001431 RID: 5169
		public const int GfxIdFieldNumber = 2;

		// Token: 0x04001432 RID: 5170
		private int gfxId_;

		// Token: 0x04001433 RID: 5171
		public const int NameFieldNumber = 3;

		// Token: 0x04001434 RID: 5172
		private string name_;

		// Token: 0x04001435 RID: 5173
		private static GuildRankCreateRequest vDUOeGOQyNE6qycmVL4O;
	}
}
