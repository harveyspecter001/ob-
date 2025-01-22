using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly
{
	// Token: 0x02000CE1 RID: 3297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AnomalySubareaInformationEvent : IMessage<AnomalySubareaInformationEvent>, IMessage, IEquatable<AnomalySubareaInformationEvent>, IDeepCloneable<AnomalySubareaInformationEvent>, IBufferMessage
	{
		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x0028455C File Offset: 0x0028275C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AnomalySubareaInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06009EB2 RID: 40626 RVA: 0x0028456C File Offset: 0x0028276C
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

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x0028457C File Offset: 0x0028277C
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

		// Token: 0x06009EB4 RID: 40628 RVA: 0x0028458C File Offset: 0x0028278C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationEvent()
		{
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x0028459C File Offset: 0x0028279C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationEvent(AnomalySubareaInformationEvent other)
		{
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x002845AC File Offset: 0x002827AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x002845BC File Offset: 0x002827BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation> Subareas
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x002845CC File Offset: 0x002827CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x002845DC File Offset: 0x002827DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AnomalySubareaInformationEvent other)
		{
			return true;
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x002845EC File Offset: 0x002827EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x002845FC File Offset: 0x002827FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x0028460C File Offset: 0x0028280C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x0028461C File Offset: 0x0028281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x0028462C File Offset: 0x0028282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x0028463C File Offset: 0x0028283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AnomalySubareaInformationEvent other)
		{
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x0028464C File Offset: 0x0028284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x0028465C File Offset: 0x0028285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x0028466C File Offset: 0x0028286C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnomalySubareaInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AnomalySubareaInformationEvent._parser = new MessageParser<AnomalySubareaInformationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				}
				AnomalySubareaInformationEvent._repeated_subareas_codec = FieldCodec.ForMessage<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation>(10U, r4ivSreiEdqFsKhajaJB.XVInXhlssT(r4ivSreiEdqFsKhajaJB.JwHeiXTPxgr));
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x00284774 File Offset: 0x00282974
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wGmWCpJjJqLNkGLCQHtM()
		{
			return true;
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x0028477C File Offset: 0x0028297C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AnomalySubareaInformationEvent ocDoCVJjG2PjQj9m6aa6()
		{
			return null;
		}

		// Token: 0x04003ACB RID: 15051
		private static readonly MessageParser<AnomalySubareaInformationEvent> _parser;

		// Token: 0x04003ACC RID: 15052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ACD RID: 15053
		public const int SubareasFieldNumber = 1;

		// Token: 0x04003ACE RID: 15054
		private static readonly FieldCodec<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation> _repeated_subareas_codec;

		// Token: 0x04003ACF RID: 15055
		private readonly RepeatedField<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation> subareas_;

		// Token: 0x04003AD0 RID: 15056
		internal static AnomalySubareaInformationEvent J5FFSPJjOfM3PkPSGNCn;

		// Token: 0x02000CE2 RID: 3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06009EC5 RID: 40645 RVA: 0x002EC19C File Offset: 0x002EA39C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000CE3 RID: 3299
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AnomalySubareaInformation : IMessage<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation>, IMessage, IEquatable<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation>, IDeepCloneable<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation>, IBufferMessage
			{
				// Token: 0x17001D95 RID: 7573
				// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x0030EA98 File Offset: 0x0030CC98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001D96 RID: 7574
				// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x0030EAA8 File Offset: 0x0030CCA8
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

				// Token: 0x17001D97 RID: 7575
				// (get) Token: 0x06009EC8 RID: 40648 RVA: 0x0030EAB8 File Offset: 0x0030CCB8
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

				// Token: 0x06009EC9 RID: 40649 RVA: 0x0030EAC8 File Offset: 0x0030CCC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AnomalySubareaInformation()
				{
				}

				// Token: 0x06009ECA RID: 40650 RVA: 0x0030EAD8 File Offset: 0x0030CCD8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AnomalySubareaInformation(AnomalySubareaInformationEvent.Types.AnomalySubareaInformation other)
				{
				}

				// Token: 0x06009ECB RID: 40651 RVA: 0x0030EAE8 File Offset: 0x0030CCE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AnomalySubareaInformationEvent.Types.AnomalySubareaInformation Clone()
				{
					return null;
				}

				// Token: 0x17001D98 RID: 7576
				// (get) Token: 0x06009ECC RID: 40652 RVA: 0x0030EAF8 File Offset: 0x0030CCF8
				// (set) Token: 0x06009ECD RID: 40653 RVA: 0x0030EB08 File Offset: 0x0030CD08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SubareaId
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

				// Token: 0x17001D99 RID: 7577
				// (get) Token: 0x06009ECE RID: 40654 RVA: 0x0030EB18 File Offset: 0x0030CD18
				// (set) Token: 0x06009ECF RID: 40655 RVA: 0x0030EB28 File Offset: 0x0030CD28
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int RewardRate
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

				// Token: 0x17001D9A RID: 7578
				// (get) Token: 0x06009ED0 RID: 40656 RVA: 0x0030EB38 File Offset: 0x0030CD38
				// (set) Token: 0x06009ED1 RID: 40657 RVA: 0x0030EB48 File Offset: 0x0030CD48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasAnomaly
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

				// Token: 0x17001D9B RID: 7579
				// (get) Token: 0x06009ED2 RID: 40658 RVA: 0x0030EB58 File Offset: 0x0030CD58
				// (set) Token: 0x06009ED3 RID: 40659 RVA: 0x0030EB68 File Offset: 0x0030CD68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long AnomalyClosingTime
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

				// Token: 0x06009ED4 RID: 40660 RVA: 0x0030EB78 File Offset: 0x0030CD78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009ED5 RID: 40661 RVA: 0x0030EB88 File Offset: 0x0030CD88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AnomalySubareaInformationEvent.Types.AnomalySubareaInformation other)
				{
					return true;
				}

				// Token: 0x06009ED6 RID: 40662 RVA: 0x0030EB98 File Offset: 0x0030CD98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009ED7 RID: 40663 RVA: 0x0030EBA8 File Offset: 0x0030CDA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009ED8 RID: 40664 RVA: 0x0030EBB8 File Offset: 0x0030CDB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009ED9 RID: 40665 RVA: 0x0030EBC8 File Offset: 0x0030CDC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009EDA RID: 40666 RVA: 0x0030EBD8 File Offset: 0x0030CDD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009EDB RID: 40667 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AnomalySubareaInformationEvent.Types.AnomalySubareaInformation other)
				{
				}

				// Token: 0x06009EDC RID: 40668 RVA: 0x0030EBF8 File Offset: 0x0030CDF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009EDD RID: 40669 RVA: 0x0030EC08 File Offset: 0x0030CE08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009EDE RID: 40670 RVA: 0x0030EC18 File Offset: 0x0030CE18
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AnomalySubareaInformation()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							AnomalySubareaInformationEvent.Types.AnomalySubareaInformation._parser = new MessageParser<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation>(() => null);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06009EDF RID: 40671 RVA: 0x0030ECFC File Offset: 0x0030CEFC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool McxNkpGqB4WfJDkyxcQo()
				{
					return true;
				}

				// Token: 0x06009EE0 RID: 40672 RVA: 0x0030ED04 File Offset: 0x0030CF04
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AnomalySubareaInformationEvent.Types.AnomalySubareaInformation OUntSZGqetEmIcTq8lg8()
				{
					return null;
				}

				// Token: 0x04003AD1 RID: 15057
				private static readonly MessageParser<AnomalySubareaInformationEvent.Types.AnomalySubareaInformation> _parser;

				// Token: 0x04003AD2 RID: 15058
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003AD3 RID: 15059
				public const int SubareaIdFieldNumber = 1;

				// Token: 0x04003AD4 RID: 15060
				private int subareaId_;

				// Token: 0x04003AD5 RID: 15061
				public const int RewardRateFieldNumber = 2;

				// Token: 0x04003AD6 RID: 15062
				private int rewardRate_;

				// Token: 0x04003AD7 RID: 15063
				public const int HasAnomalyFieldNumber = 3;

				// Token: 0x04003AD8 RID: 15064
				private bool hasAnomaly_;

				// Token: 0x04003AD9 RID: 15065
				public const int AnomalyClosingTimeFieldNumber = 4;

				// Token: 0x04003ADA RID: 15066
				private long anomalyClosingTime_;

				// Token: 0x04003ADB RID: 15067
				internal static AnomalySubareaInformationEvent.Types.AnomalySubareaInformation GwYQprGqA94LTGQQgvQp;
			}
		}
	}
}
