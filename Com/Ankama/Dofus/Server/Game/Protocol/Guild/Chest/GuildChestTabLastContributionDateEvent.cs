using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000547 RID: 1351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabLastContributionDateEvent : IMessage<GuildChestTabLastContributionDateEvent>, IMessage, IEquatable<GuildChestTabLastContributionDateEvent>, IDeepCloneable<GuildChestTabLastContributionDateEvent>, IBufferMessage
	{
		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x001EEF10 File Offset: 0x001ED110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildChestTabLastContributionDateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x001EEF20 File Offset: 0x001ED120
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

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x001EEF30 File Offset: 0x001ED130
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

		// Token: 0x060040D8 RID: 16600 RVA: 0x001EEF40 File Offset: 0x001ED140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabLastContributionDateEvent()
		{
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x001EEF50 File Offset: 0x001ED150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabLastContributionDateEvent(GuildChestTabLastContributionDateEvent other)
		{
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x001EEF60 File Offset: 0x001ED160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabLastContributionDateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x001EEF70 File Offset: 0x001ED170
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x001EEF80 File Offset: 0x001ED180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastContributionDate
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

		// Token: 0x060040DD RID: 16605 RVA: 0x001EEF90 File Offset: 0x001ED190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x001EEFA0 File Offset: 0x001ED1A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabLastContributionDateEvent other)
		{
			return true;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x001EEFB0 File Offset: 0x001ED1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x001EEFC0 File Offset: 0x001ED1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x001EEFD0 File Offset: 0x001ED1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x001EEFE0 File Offset: 0x001ED1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x001EEFF0 File Offset: 0x001ED1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x001EF000 File Offset: 0x001ED200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabLastContributionDateEvent other)
		{
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x001EF010 File Offset: 0x001ED210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x001EF020 File Offset: 0x001ED220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x001EF030 File Offset: 0x001ED230
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabLastContributionDateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				GuildChestTabLastContributionDateEvent._parser = new MessageParser<GuildChestTabLastContributionDateEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x001EF128 File Offset: 0x001ED328
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yv5h71Op7Tv0tnWOGW1w()
		{
			return true;
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x001EF130 File Offset: 0x001ED330
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabLastContributionDateEvent Je451ROpTAjnMtb2K0La()
		{
			return null;
		}

		// Token: 0x04001660 RID: 5728
		private static readonly MessageParser<GuildChestTabLastContributionDateEvent> _parser;

		// Token: 0x04001661 RID: 5729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001662 RID: 5730
		public const int LastContributionDateFieldNumber = 1;

		// Token: 0x04001663 RID: 5731
		private long lastContributionDate_;

		// Token: 0x04001664 RID: 5732
		internal static GuildChestTabLastContributionDateEvent GcZ7bLOpQTxssEFFYOSL;
	}
}
