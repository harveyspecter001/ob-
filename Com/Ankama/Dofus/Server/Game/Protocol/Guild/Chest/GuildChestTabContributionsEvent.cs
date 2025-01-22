using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000542 RID: 1346
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabContributionsEvent : IMessage<GuildChestTabContributionsEvent>, IMessage, IEquatable<GuildChestTabContributionsEvent>, IDeepCloneable<GuildChestTabContributionsEvent>, IBufferMessage
	{
		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x001EECE8 File Offset: 0x001ECEE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildChestTabContributionsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x001EECF8 File Offset: 0x001ECEF8
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x001EED08 File Offset: 0x001ECF08
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

		// Token: 0x060040A0 RID: 16544 RVA: 0x001EED18 File Offset: 0x001ECF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsEvent()
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x001EED28 File Offset: 0x001ECF28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsEvent(GuildChestTabContributionsEvent other)
		{
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x001EED38 File Offset: 0x001ECF38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabContributionsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x001EED48 File Offset: 0x001ECF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuildChestTabContributionsEvent.Types.Contribution> Contributions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x001EED58 File Offset: 0x001ECF58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x001EED68 File Offset: 0x001ECF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabContributionsEvent other)
		{
			return true;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x001EED78 File Offset: 0x001ECF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x001EED88 File Offset: 0x001ECF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x001EED98 File Offset: 0x001ECF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x001EEDA8 File Offset: 0x001ECFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x001EEDB8 File Offset: 0x001ECFB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x001EEDC8 File Offset: 0x001ECFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabContributionsEvent other)
		{
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x001EEDD8 File Offset: 0x001ECFD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x001EEDE8 File Offset: 0x001ECFE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x001EEDF8 File Offset: 0x001ECFF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabContributionsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GuildChestTabContributionsEvent._repeated_contributions_codec = FieldCodec.ForMessage<GuildChestTabContributionsEvent.Types.Contribution>(10U, Q6tX6Smo1I1Gmhgn6GPX.XVInXhlssT(Q6tX6Smo1I1Gmhgn6GPX.VQvmoasx7B0));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					GuildChestTabContributionsEvent._parser = new MessageParser<GuildChestTabContributionsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 3;
					}
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				}
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x001EEF00 File Offset: 0x001ED100
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zpRFCXOptmEMIGRW1VVv()
		{
			return true;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001EEF08 File Offset: 0x001ED108
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabContributionsEvent xaSByBOpw84Tk4Wo5PxN()
		{
			return null;
		}

		// Token: 0x0400164D RID: 5709
		private static readonly MessageParser<GuildChestTabContributionsEvent> _parser;

		// Token: 0x0400164E RID: 5710
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400164F RID: 5711
		public const int ContributionsFieldNumber = 1;

		// Token: 0x04001650 RID: 5712
		private static readonly FieldCodec<GuildChestTabContributionsEvent.Types.Contribution> _repeated_contributions_codec;

		// Token: 0x04001651 RID: 5713
		private readonly RepeatedField<GuildChestTabContributionsEvent.Types.Contribution> contributions_;

		// Token: 0x04001652 RID: 5714
		internal static GuildChestTabContributionsEvent HsySDEOpDN2h5CcbLwEE;

		// Token: 0x02000543 RID: 1347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060040B1 RID: 16561 RVA: 0x002C5610 File Offset: 0x002C3810
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000544 RID: 1348
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Contribution : IMessage<GuildChestTabContributionsEvent.Types.Contribution>, IMessage, IEquatable<GuildChestTabContributionsEvent.Types.Contribution>, IDeepCloneable<GuildChestTabContributionsEvent.Types.Contribution>, IBufferMessage
			{
				// Token: 0x17000B81 RID: 2945
				// (get) Token: 0x060040B2 RID: 16562 RVA: 0x002FC59C File Offset: 0x002FA79C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildChestTabContributionsEvent.Types.Contribution> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000B82 RID: 2946
				// (get) Token: 0x060040B3 RID: 16563 RVA: 0x002FC5AC File Offset: 0x002FA7AC
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

				// Token: 0x17000B83 RID: 2947
				// (get) Token: 0x060040B4 RID: 16564 RVA: 0x002FC5BC File Offset: 0x002FA7BC
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

				// Token: 0x060040B5 RID: 16565 RVA: 0x002FC5CC File Offset: 0x002FA7CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Contribution()
				{
				}

				// Token: 0x060040B6 RID: 16566 RVA: 0x002FC5DC File Offset: 0x002FA7DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Contribution(GuildChestTabContributionsEvent.Types.Contribution other)
				{
				}

				// Token: 0x060040B7 RID: 16567 RVA: 0x002FC5EC File Offset: 0x002FA7EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildChestTabContributionsEvent.Types.Contribution Clone()
				{
					return null;
				}

				// Token: 0x17000B84 RID: 2948
				// (get) Token: 0x060040B8 RID: 16568 RVA: 0x002FC5FC File Offset: 0x002FA7FC
				// (set) Token: 0x060040B9 RID: 16569 RVA: 0x002FC60C File Offset: 0x002FA80C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long ContributorId
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

				// Token: 0x17000B85 RID: 2949
				// (get) Token: 0x060040BA RID: 16570 RVA: 0x002FC61C File Offset: 0x002FA81C
				// (set) Token: 0x060040BB RID: 16571 RVA: 0x002FC62C File Offset: 0x002FA82C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string ContributorName
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

				// Token: 0x17000B86 RID: 2950
				// (get) Token: 0x060040BC RID: 16572 RVA: 0x002FC63C File Offset: 0x002FA83C
				// (set) Token: 0x060040BD RID: 16573 RVA: 0x002FC64C File Offset: 0x002FA84C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Amount
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

				// Token: 0x060040BE RID: 16574 RVA: 0x002FC65C File Offset: 0x002FA85C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060040BF RID: 16575 RVA: 0x002FC66C File Offset: 0x002FA86C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildChestTabContributionsEvent.Types.Contribution other)
				{
					return true;
				}

				// Token: 0x060040C0 RID: 16576 RVA: 0x002FC67C File Offset: 0x002FA87C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060040C1 RID: 16577 RVA: 0x002FC68C File Offset: 0x002FA88C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060040C2 RID: 16578 RVA: 0x002FC69C File Offset: 0x002FA89C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060040C3 RID: 16579 RVA: 0x002FC6AC File Offset: 0x002FA8AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060040C4 RID: 16580 RVA: 0x002FC6BC File Offset: 0x002FA8BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060040C5 RID: 16581 RVA: 0x002FC6CC File Offset: 0x002FA8CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildChestTabContributionsEvent.Types.Contribution other)
				{
				}

				// Token: 0x060040C6 RID: 16582 RVA: 0x002FC6DC File Offset: 0x002FA8DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060040C7 RID: 16583 RVA: 0x002FC6EC File Offset: 0x002FA8EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060040C8 RID: 16584 RVA: 0x002FC6FC File Offset: 0x002FA8FC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Contribution()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GuildChestTabContributionsEvent.Types.Contribution._parser = new MessageParser<GuildChestTabContributionsEvent.Types.Contribution>(() => null);
						num2 = 3;
					}
				}

				// Token: 0x060040C9 RID: 16585 RVA: 0x002FC7C8 File Offset: 0x002FA9C8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ejfLAGGbm2hSsPUuZsqQ()
				{
					return true;
				}

				// Token: 0x060040CA RID: 16586 RVA: 0x002FC7D0 File Offset: 0x002FA9D0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildChestTabContributionsEvent.Types.Contribution CsqbjBGbAqDQsB2lORic()
				{
					return null;
				}

				// Token: 0x04001653 RID: 5715
				private static readonly MessageParser<GuildChestTabContributionsEvent.Types.Contribution> _parser;

				// Token: 0x04001654 RID: 5716
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001655 RID: 5717
				public const int ContributorIdFieldNumber = 1;

				// Token: 0x04001656 RID: 5718
				private long contributorId_;

				// Token: 0x04001657 RID: 5719
				public const int ContributorNameFieldNumber = 2;

				// Token: 0x04001658 RID: 5720
				private string contributorName_;

				// Token: 0x04001659 RID: 5721
				public const int AmountFieldNumber = 3;

				// Token: 0x0400165A RID: 5722
				private long amount_;

				// Token: 0x0400165B RID: 5723
				internal static GuildChestTabContributionsEvent.Types.Contribution iWV8EbGbnOG41bdJ6qgr;
			}
		}
	}
}
