using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000538 RID: 1336
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabContributionsRequest : IMessage<GuildChestTabContributionsRequest>, IMessage, IEquatable<GuildChestTabContributionsRequest>, IDeepCloneable<GuildChestTabContributionsRequest>, IBufferMessage
	{
		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x001EE350 File Offset: 0x001EC550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestTabContributionsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x001EE360 File Offset: 0x001EC560
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x001EE370 File Offset: 0x001EC570
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

		// Token: 0x06004028 RID: 16424 RVA: 0x001EE380 File Offset: 0x001EC580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsRequest()
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x001EE390 File Offset: 0x001EC590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsRequest(GuildChestTabContributionsRequest other)
		{
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001EE3A0 File Offset: 0x001EC5A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsRequest Clone()
		{
			return null;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001EE3B0 File Offset: 0x001EC5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001EE3C0 File Offset: 0x001EC5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabContributionsRequest other)
		{
			return true;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x001EE3D0 File Offset: 0x001EC5D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001EE3E0 File Offset: 0x001EC5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001EE3F0 File Offset: 0x001EC5F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x001EE400 File Offset: 0x001EC600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001EE410 File Offset: 0x001EC610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001EE420 File Offset: 0x001EC620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabContributionsRequest other)
		{
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x001EE430 File Offset: 0x001EC630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x001EE440 File Offset: 0x001EC640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x001EE450 File Offset: 0x001EC650
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabContributionsRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildChestTabContributionsRequest._parser = new MessageParser<GuildChestTabContributionsRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001EE534 File Offset: 0x001EC734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YaApy6OpvGASV6Ve20ea()
		{
			return true;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x001EE53C File Offset: 0x001EC73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabContributionsRequest qi5WiyOpoa8EsHXQ6dtu()
		{
			return null;
		}

		// Token: 0x04001634 RID: 5684
		private static readonly MessageParser<GuildChestTabContributionsRequest> _parser;

		// Token: 0x04001635 RID: 5685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001636 RID: 5686
		private static GuildChestTabContributionsRequest H5trGTOpUGe8xgwwKJgj;
	}
}
