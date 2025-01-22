using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000506 RID: 1286
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildLogbookEvent : IMessage<GuildLogbookEvent>, IMessage, IEquatable<GuildLogbookEvent>, IDeepCloneable<GuildLogbookEvent>, IBufferMessage
	{
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x001EA104 File Offset: 0x001E8304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildLogbookEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x001EA114 File Offset: 0x001E8314
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x001EA124 File Offset: 0x001E8324
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

		// Token: 0x06003D8B RID: 15755 RVA: 0x001EA134 File Offset: 0x001E8334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEvent()
		{
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x001EA144 File Offset: 0x001E8344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEvent(GuildLogbookEvent other)
		{
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x001EA154 File Offset: 0x001E8354
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEvent Clone()
		{
			return null;
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x001EA164 File Offset: 0x001E8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuildLogbookEntry> GlobalActivities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x001EA174 File Offset: 0x001E8374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuildLogbookEntry> ChestActivities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x001EA184 File Offset: 0x001E8384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x001EA194 File Offset: 0x001E8394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildLogbookEvent other)
		{
			return true;
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x001EA1A4 File Offset: 0x001E83A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x001EA1B4 File Offset: 0x001E83B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x001EA1C4 File Offset: 0x001E83C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x001EA1D4 File Offset: 0x001E83D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x001EA1E4 File Offset: 0x001E83E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x001EA1F4 File Offset: 0x001E83F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildLogbookEvent other)
		{
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x001EA204 File Offset: 0x001E8404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x001EA214 File Offset: 0x001E8414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x001EA224 File Offset: 0x001E8424
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildLogbookEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						GuildLogbookEvent._parser = new MessageParser<GuildLogbookEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 3:
						goto IL_73;
					case 4:
						return;
					case 5:
						GuildLogbookEvent._repeated_chestActivities_codec = FieldCodec.ForMessage<GuildLogbookEntry>(18U, hNM5vcmkO0BRvhOntePI.XVInXhlssT(hNM5vcmkO0BRvhOntePI.UPamkJ7fnk5));
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 6:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 6;
					}
				}
				IL_73:
				GuildLogbookEvent._repeated_globalActivities_codec = FieldCodec.ForMessage<GuildLogbookEntry>(10U, hNM5vcmkO0BRvhOntePI.XVInXhlssT(hNM5vcmkO0BRvhOntePI.UPamkJ7fnk5));
				num = 5;
			}
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001EA37C File Offset: 0x001E857C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nuKPhyOTsSYLkAETCo8I()
		{
			return true;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x001EA384 File Offset: 0x001E8584
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildLogbookEvent fBkMbsOTdJNCUmO6cY5y()
		{
			return null;
		}

		// Token: 0x04001555 RID: 5461
		private static readonly MessageParser<GuildLogbookEvent> _parser;

		// Token: 0x04001556 RID: 5462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001557 RID: 5463
		public const int GlobalActivitiesFieldNumber = 1;

		// Token: 0x04001558 RID: 5464
		private static readonly FieldCodec<GuildLogbookEntry> _repeated_globalActivities_codec;

		// Token: 0x04001559 RID: 5465
		private readonly RepeatedField<GuildLogbookEntry> globalActivities_;

		// Token: 0x0400155A RID: 5466
		public const int ChestActivitiesFieldNumber = 2;

		// Token: 0x0400155B RID: 5467
		private static readonly FieldCodec<GuildLogbookEntry> _repeated_chestActivities_codec;

		// Token: 0x0400155C RID: 5468
		private readonly RepeatedField<GuildLogbookEntry> chestActivities_;

		// Token: 0x0400155D RID: 5469
		internal static GuildLogbookEvent gqPd9vOTgay1p8TM1LqZ;
	}
}
