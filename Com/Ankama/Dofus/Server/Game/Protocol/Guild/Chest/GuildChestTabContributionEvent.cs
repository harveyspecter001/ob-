using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000549 RID: 1353
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabContributionEvent : IMessage<GuildChestTabContributionEvent>, IMessage, IEquatable<GuildChestTabContributionEvent>, IDeepCloneable<GuildChestTabContributionEvent>, IBufferMessage
	{
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x001EF138 File Offset: 0x001ED338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestTabContributionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060040F0 RID: 16624 RVA: 0x001EF148 File Offset: 0x001ED348
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

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x001EF158 File Offset: 0x001ED358
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

		// Token: 0x060040F2 RID: 16626 RVA: 0x001EF168 File Offset: 0x001ED368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionEvent()
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x001EF178 File Offset: 0x001ED378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionEvent(GuildChestTabContributionEvent other)
		{
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x001EF188 File Offset: 0x001ED388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x001EF198 File Offset: 0x001ED398
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x001EF1A8 File Offset: 0x001ED3A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TabNumber
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

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x001EF1B8 File Offset: 0x001ED3B8
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x001EF1C8 File Offset: 0x001ED3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RequiredAmount
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x001EF1D8 File Offset: 0x001ED3D8
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x001EF1E8 File Offset: 0x001ED3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurrentAmount
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

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x001EF1F8 File Offset: 0x001ED3F8
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x001EF208 File Offset: 0x001ED408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChestContributionEnrollmentDelay
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

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x001EF218 File Offset: 0x001ED418
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x001EF228 File Offset: 0x001ED428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChestContributionDelay
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

		// Token: 0x060040FF RID: 16639 RVA: 0x001EF238 File Offset: 0x001ED438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x001EF248 File Offset: 0x001ED448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabContributionEvent other)
		{
			return true;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x001EF258 File Offset: 0x001ED458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x001EF268 File Offset: 0x001ED468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x001EF278 File Offset: 0x001ED478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x001EF288 File Offset: 0x001ED488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x001EF298 File Offset: 0x001ED498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x001EF2A8 File Offset: 0x001ED4A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabContributionEvent other)
		{
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x001EF2B8 File Offset: 0x001ED4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x001EF2C8 File Offset: 0x001ED4C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x001EF2D8 File Offset: 0x001ED4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabContributionEvent()
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
						GuildChestTabContributionEvent._parser = new MessageParser<GuildChestTabContributionEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 3:
						goto IL_97;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_97:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x001EF3C0 File Offset: 0x001ED5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ccNoRsOpHO4xvoHDr7bR()
		{
			return true;
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x001EF3C8 File Offset: 0x001ED5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabContributionEvent TVc5Y6OpYPK9Xf7hdTDf()
		{
			return null;
		}

		// Token: 0x04001667 RID: 5735
		private static readonly MessageParser<GuildChestTabContributionEvent> _parser;

		// Token: 0x04001668 RID: 5736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001669 RID: 5737
		public const int TabNumberFieldNumber = 1;

		// Token: 0x0400166A RID: 5738
		private int tabNumber_;

		// Token: 0x0400166B RID: 5739
		public const int RequiredAmountFieldNumber = 2;

		// Token: 0x0400166C RID: 5740
		private long requiredAmount_;

		// Token: 0x0400166D RID: 5741
		public const int CurrentAmountFieldNumber = 3;

		// Token: 0x0400166E RID: 5742
		private long currentAmount_;

		// Token: 0x0400166F RID: 5743
		public const int ChestContributionEnrollmentDelayFieldNumber = 4;

		// Token: 0x04001670 RID: 5744
		private long chestContributionEnrollmentDelay_;

		// Token: 0x04001671 RID: 5745
		public const int ChestContributionDelayFieldNumber = 5;

		// Token: 0x04001672 RID: 5746
		private long chestContributionDelay_;

		// Token: 0x04001673 RID: 5747
		internal static GuildChestTabContributionEvent NlqP1HOppGsKlbLSLtTr;
	}
}
