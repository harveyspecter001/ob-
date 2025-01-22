using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D95 RID: 3477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KOTHUpdateEvent : IMessage<KOTHUpdateEvent>, IMessage, IEquatable<KOTHUpdateEvent>, IDeepCloneable<KOTHUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600A7AC RID: 42924 RVA: 0x00294A74 File Offset: 0x00292C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KOTHUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x00294A84 File Offset: 0x00292C84
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

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600A7AE RID: 42926 RVA: 0x00294A94 File Offset: 0x00292C94
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

		// Token: 0x0600A7AF RID: 42927 RVA: 0x00294AA4 File Offset: 0x00292CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHUpdateEvent()
		{
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x00294AB4 File Offset: 0x00292CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHUpdateEvent(KOTHUpdateEvent other)
		{
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x00294AC4 File Offset: 0x00292CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KOTHUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x0600A7B2 RID: 42930 RVA: 0x00294AD4 File Offset: 0x00292CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation> KothAllianceInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x00294AE4 File Offset: 0x00292CE4
		// (set) Token: 0x0600A7B4 RID: 42932 RVA: 0x00294AF4 File Offset: 0x00292CF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string StartingAvaTimestamp
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

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x00294B04 File Offset: 0x00292D04
		// (set) Token: 0x0600A7B6 RID: 42934 RVA: 0x00294B14 File Offset: 0x00292D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long NextTickTime
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

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x00294B24 File Offset: 0x00292D24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x00294B34 File Offset: 0x00292D34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(KOTHUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x00294B44 File Offset: 0x00292D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x00294B54 File Offset: 0x00292D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x00294B64 File Offset: 0x00292D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x00294B74 File Offset: 0x00292D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x00294B84 File Offset: 0x00292D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x00294B94 File Offset: 0x00292D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(KOTHUpdateEvent other)
		{
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x00294BA4 File Offset: 0x00292DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x00294BB4 File Offset: 0x00292DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x00294BC4 File Offset: 0x00292DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static KOTHUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					KOTHUpdateEvent._parser = new MessageParser<KOTHUpdateEvent>(() => null);
					num2 = 3;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					KOTHUpdateEvent._repeated_kothAllianceInformation_codec = FieldCodec.ForMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation>(10U, tmZKyK3RWFhn7n2qZvqq.XVInXhlssT(tmZKyK3RWFhn7n2qZvqq.Fi83RhqOfGP));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x00294CCC File Offset: 0x00292ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qu4ZpFJlviGwaN1kJaYE()
		{
			return true;
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x00294CD4 File Offset: 0x00292ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KOTHUpdateEvent LQ6TxDJloaSF4RMQ9Jci()
		{
			return null;
		}

		// Token: 0x04003DAD RID: 15789
		private static readonly MessageParser<KOTHUpdateEvent> _parser;

		// Token: 0x04003DAE RID: 15790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DAF RID: 15791
		public const int KothAllianceInformationFieldNumber = 1;

		// Token: 0x04003DB0 RID: 15792
		private static readonly FieldCodec<KOTHUpdateEvent.Types.KOTHAllianceInformation> _repeated_kothAllianceInformation_codec;

		// Token: 0x04003DB1 RID: 15793
		private readonly RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation> kothAllianceInformation_;

		// Token: 0x04003DB2 RID: 15794
		public const int StartingAvaTimestampFieldNumber = 2;

		// Token: 0x04003DB3 RID: 15795
		private string startingAvaTimestamp_;

		// Token: 0x04003DB4 RID: 15796
		public const int NextTickTimeFieldNumber = 3;

		// Token: 0x04003DB5 RID: 15797
		private long nextTickTime_;

		// Token: 0x04003DB6 RID: 15798
		private static KOTHUpdateEvent JknuqQJlU6wHcG1phgRO;

		// Token: 0x02000D96 RID: 3478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600A7C4 RID: 42948 RVA: 0x002F117C File Offset: 0x002EF37C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000D97 RID: 3479
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class KOTHAllianceInformation : IMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation>, IMessage, IEquatable<KOTHUpdateEvent.Types.KOTHAllianceInformation>, IDeepCloneable<KOTHUpdateEvent.Types.KOTHAllianceInformation>, IBufferMessage
			{
				// Token: 0x17001F21 RID: 7969
				// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x0030ED0C File Offset: 0x0030CF0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001F22 RID: 7970
				// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x0030ED1C File Offset: 0x0030CF1C
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

				// Token: 0x17001F23 RID: 7971
				// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x0030ED2C File Offset: 0x0030CF2C
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

				// Token: 0x0600A7C8 RID: 42952 RVA: 0x0030ED3C File Offset: 0x0030CF3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public KOTHAllianceInformation()
				{
				}

				// Token: 0x0600A7C9 RID: 42953 RVA: 0x0030ED4C File Offset: 0x0030CF4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public KOTHAllianceInformation(KOTHUpdateEvent.Types.KOTHAllianceInformation other)
				{
				}

				// Token: 0x0600A7CA RID: 42954 RVA: 0x0030ED5C File Offset: 0x0030CF5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public KOTHUpdateEvent.Types.KOTHAllianceInformation Clone()
				{
					return null;
				}

				// Token: 0x17001F24 RID: 7972
				// (get) Token: 0x0600A7CB RID: 42955 RVA: 0x0030ED6C File Offset: 0x0030CF6C
				// (set) Token: 0x0600A7CC RID: 42956 RVA: 0x0030ED7C File Offset: 0x0030CF7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public AllianceInformation Alliance
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

				// Token: 0x17001F25 RID: 7973
				// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x0030ED8C File Offset: 0x0030CF8C
				// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x0030ED9C File Offset: 0x0030CF9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long MemberCount
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

				// Token: 0x17001F26 RID: 7974
				// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x0030EDAC File Offset: 0x0030CFAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber> KothRoles
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001F27 RID: 7975
				// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x0030EDBC File Offset: 0x0030CFBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore> Scores
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001F28 RID: 7976
				// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x0030EDCC File Offset: 0x0030CFCC
				// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x0030EDDC File Offset: 0x0030CFDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int MatchDominationScores
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

				// Token: 0x0600A7D3 RID: 42963 RVA: 0x0030EDEC File Offset: 0x0030CFEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600A7D4 RID: 42964 RVA: 0x0030EDFC File Offset: 0x0030CFFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(KOTHUpdateEvent.Types.KOTHAllianceInformation other)
				{
					return true;
				}

				// Token: 0x0600A7D5 RID: 42965 RVA: 0x0030EE0C File Offset: 0x0030D00C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600A7D6 RID: 42966 RVA: 0x0030EE1C File Offset: 0x0030D01C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600A7D7 RID: 42967 RVA: 0x0030EE2C File Offset: 0x0030D02C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600A7D8 RID: 42968 RVA: 0x0030EE3C File Offset: 0x0030D03C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600A7D9 RID: 42969 RVA: 0x0030EE4C File Offset: 0x0030D04C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600A7DA RID: 42970 RVA: 0x0030EE5C File Offset: 0x0030D05C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(KOTHUpdateEvent.Types.KOTHAllianceInformation other)
				{
				}

				// Token: 0x0600A7DB RID: 42971 RVA: 0x0030EE6C File Offset: 0x0030D06C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600A7DC RID: 42972 RVA: 0x0030EE7C File Offset: 0x0030D07C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600A7DD RID: 42973 RVA: 0x0030EE8C File Offset: 0x0030D08C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static KOTHAllianceInformation()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							KOTHUpdateEvent.Types.KOTHAllianceInformation._repeated_scores_codec = FieldCodec.ForMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore>(34U, myHXdo3R0pyWhcHnewGq.XVInXhlssT(myHXdo3R0pyWhcHnewGq.NA23RC0L5D2));
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 6:
							KOTHUpdateEvent.Types.KOTHAllianceInformation._repeated_kothRoles_codec = FieldCodec.ForMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber>(26U, ngmN9I3RrRR0mYOAPkoc.XVInXhlssT(ngmN9I3RrRR0mYOAPkoc.fpN3RVBcmfv));
							num2 = 5;
							continue;
						}
						KOTHUpdateEvent.Types.KOTHAllianceInformation._parser = new MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation>(() => null);
						num2 = 6;
					}
				}

				// Token: 0x0600A7DE RID: 42974 RVA: 0x0030EFCC File Offset: 0x0030D1CC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool hZ7ioaGqE5cGJfwRwF18()
				{
					return true;
				}

				// Token: 0x0600A7DF RID: 42975 RVA: 0x0030EFD4 File Offset: 0x0030D1D4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static KOTHUpdateEvent.Types.KOTHAllianceInformation TE5A2bGqXThmaOIYr0eN()
				{
					return null;
				}

				// Token: 0x04003DB7 RID: 15799
				private static readonly MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation> _parser;

				// Token: 0x04003DB8 RID: 15800
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003DB9 RID: 15801
				public const int AllianceFieldNumber = 1;

				// Token: 0x04003DBA RID: 15802
				private AllianceInformation alliance_;

				// Token: 0x04003DBB RID: 15803
				public const int MemberCountFieldNumber = 2;

				// Token: 0x04003DBC RID: 15804
				private long memberCount_;

				// Token: 0x04003DBD RID: 15805
				public const int KothRolesFieldNumber = 3;

				// Token: 0x04003DBE RID: 15806
				private static readonly FieldCodec<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber> _repeated_kothRoles_codec;

				// Token: 0x04003DBF RID: 15807
				private readonly RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber> kothRoles_;

				// Token: 0x04003DC0 RID: 15808
				public const int ScoresFieldNumber = 4;

				// Token: 0x04003DC1 RID: 15809
				private static readonly FieldCodec<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore> _repeated_scores_codec;

				// Token: 0x04003DC2 RID: 15810
				private readonly RepeatedField<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore> scores_;

				// Token: 0x04003DC3 RID: 15811
				public const int MatchDominationScoresFieldNumber = 5;

				// Token: 0x04003DC4 RID: 15812
				private int matchDominationScores_;

				// Token: 0x04003DC5 RID: 15813
				internal static KOTHUpdateEvent.Types.KOTHAllianceInformation av4E99Gq2JSRyqfNbGmE;

				// Token: 0x02000D98 RID: 3480
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600A7E0 RID: 42976 RVA: 0x0031A6E4 File Offset: 0x003188E4
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000D99 RID: 3481
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class KOTHAllianceRoleNumber : IMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber>, IMessage, IEquatable<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber>, IDeepCloneable<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber>, IBufferMessage
					{
						// Token: 0x17001F29 RID: 7977
						// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x00320000 File Offset: 0x0031E200
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001F2A RID: 7978
						// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x00320010 File Offset: 0x0031E210
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

						// Token: 0x17001F2B RID: 7979
						// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x00320020 File Offset: 0x0031E220
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

						// Token: 0x0600A7E4 RID: 42980 RVA: 0x00320030 File Offset: 0x0031E230
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHAllianceRoleNumber()
						{
						}

						// Token: 0x0600A7E5 RID: 42981 RVA: 0x00320040 File Offset: 0x0031E240
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHAllianceRoleNumber(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber other)
						{
						}

						// Token: 0x0600A7E6 RID: 42982 RVA: 0x00320050 File Offset: 0x0031E250
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber Clone()
						{
							return null;
						}

						// Token: 0x17001F2C RID: 7980
						// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x00320060 File Offset: 0x0031E260
						// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x00320070 File Offset: 0x0031E270
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public long MemberCount
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

						// Token: 0x17001F2D RID: 7981
						// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x00320080 File Offset: 0x0031E280
						// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x00320090 File Offset: 0x0031E290
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int KothRole
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

						// Token: 0x0600A7EB RID: 42987 RVA: 0x003200A0 File Offset: 0x0031E2A0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600A7EC RID: 42988 RVA: 0x003200B0 File Offset: 0x0031E2B0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber other)
						{
							return true;
						}

						// Token: 0x0600A7ED RID: 42989 RVA: 0x003200C0 File Offset: 0x0031E2C0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600A7EE RID: 42990 RVA: 0x003200D0 File Offset: 0x0031E2D0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600A7EF RID: 42991 RVA: 0x003200E0 File Offset: 0x0031E2E0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600A7F0 RID: 42992 RVA: 0x003200F0 File Offset: 0x0031E2F0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600A7F1 RID: 42993 RVA: 0x00320100 File Offset: 0x0031E300
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600A7F2 RID: 42994 RVA: 0x00320110 File Offset: 0x0031E310
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber other)
						{
						}

						// Token: 0x0600A7F3 RID: 42995 RVA: 0x00320120 File Offset: 0x0031E320
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600A7F4 RID: 42996 RVA: 0x00320130 File Offset: 0x0031E330
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600A7F5 RID: 42997 RVA: 0x00320140 File Offset: 0x0031E340
						[MethodImpl(MethodImplOptions.NoInlining)]
						static KOTHAllianceRoleNumber()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber._parser = new MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 2;
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 3;
									continue;
								}
								break;
							}
						}

						// Token: 0x0600A7F6 RID: 42998 RVA: 0x0032020C File Offset: 0x0031E40C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool tBGW4sgGwuwQQEYxeILK()
						{
							return true;
						}

						// Token: 0x0600A7F7 RID: 42999 RVA: 0x00320214 File Offset: 0x0031E414
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber tnQlhQgGQxUuOaEgPL7E()
						{
							return null;
						}

						// Token: 0x04003DC6 RID: 15814
						private static readonly MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber> _parser;

						// Token: 0x04003DC7 RID: 15815
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003DC8 RID: 15816
						public const int MemberCountFieldNumber = 1;

						// Token: 0x04003DC9 RID: 15817
						private long memberCount_;

						// Token: 0x04003DCA RID: 15818
						public const int KothRoleFieldNumber = 2;

						// Token: 0x04003DCB RID: 15819
						private int kothRole_;

						// Token: 0x04003DCC RID: 15820
						internal static KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHAllianceRoleNumber cMMtsPgGtb38x2Ack1As;
					}

					// Token: 0x02000D9B RID: 3483
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class KOTHScore : IMessage<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore>, IMessage, IEquatable<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore>, IDeepCloneable<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore>, IBufferMessage
					{
						// Token: 0x17001F2E RID: 7982
						// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x0032021C File Offset: 0x0031E41C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001F2F RID: 7983
						// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x0032022C File Offset: 0x0031E42C
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

						// Token: 0x17001F30 RID: 7984
						// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x0032023C File Offset: 0x0031E43C
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

						// Token: 0x0600A800 RID: 43008 RVA: 0x0032024C File Offset: 0x0031E44C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHScore()
						{
						}

						// Token: 0x0600A801 RID: 43009 RVA: 0x0032025C File Offset: 0x0031E45C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHScore(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore other)
						{
						}

						// Token: 0x0600A802 RID: 43010 RVA: 0x0032026C File Offset: 0x0031E46C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore Clone()
						{
							return null;
						}

						// Token: 0x17001F31 RID: 7985
						// (get) Token: 0x0600A803 RID: 43011 RVA: 0x0032027C File Offset: 0x0031E47C
						// (set) Token: 0x0600A804 RID: 43012 RVA: 0x00320290 File Offset: 0x0031E490
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore.Types.KOTHScoreType ScoreType
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore.Types.KOTHScoreType)null;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17001F32 RID: 7986
						// (get) Token: 0x0600A805 RID: 43013 RVA: 0x003202A0 File Offset: 0x0031E4A0
						// (set) Token: 0x0600A806 RID: 43014 RVA: 0x003202B0 File Offset: 0x0031E4B0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int RoundScores
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

						// Token: 0x17001F33 RID: 7987
						// (get) Token: 0x0600A807 RID: 43015 RVA: 0x003202C0 File Offset: 0x0031E4C0
						// (set) Token: 0x0600A808 RID: 43016 RVA: 0x003202D0 File Offset: 0x0031E4D0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int CumulatedScores
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

						// Token: 0x0600A809 RID: 43017 RVA: 0x003202E0 File Offset: 0x0031E4E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600A80A RID: 43018 RVA: 0x003202F0 File Offset: 0x0031E4F0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore other)
						{
							return true;
						}

						// Token: 0x0600A80B RID: 43019 RVA: 0x00320300 File Offset: 0x0031E500
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600A80C RID: 43020 RVA: 0x00320310 File Offset: 0x0031E510
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600A80D RID: 43021 RVA: 0x00320320 File Offset: 0x0031E520
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600A80E RID: 43022 RVA: 0x00320330 File Offset: 0x0031E530
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600A80F RID: 43023 RVA: 0x00320340 File Offset: 0x0031E540
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600A810 RID: 43024 RVA: 0x00320350 File Offset: 0x0031E550
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore other)
						{
						}

						// Token: 0x0600A811 RID: 43025 RVA: 0x00320360 File Offset: 0x0031E560
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600A812 RID: 43026 RVA: 0x00320370 File Offset: 0x0031E570
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600A813 RID: 43027 RVA: 0x00320380 File Offset: 0x0031E580
						[MethodImpl(MethodImplOptions.NoInlining)]
						static KOTHScore()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore._parser = new MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore>(() => null);
									num2 = 3;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								case 3:
									return;
								case 4:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								}
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
								{
									num2 = 4;
								}
							}
						}

						// Token: 0x0600A814 RID: 43028 RVA: 0x00320478 File Offset: 0x0031E678
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool mkvTI3gGTiAKZsCOZpJc()
						{
							return true;
						}

						// Token: 0x0600A815 RID: 43029 RVA: 0x00320480 File Offset: 0x0031E680
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore pdDWfggGp0mjV84YHAbT()
						{
							return null;
						}

						// Token: 0x04003DCF RID: 15823
						private static readonly MessageParser<KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore> _parser;

						// Token: 0x04003DD0 RID: 15824
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003DD1 RID: 15825
						public const int ScoreTypeFieldNumber = 1;

						// Token: 0x04003DD2 RID: 15826
						private KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore.Types.KOTHScoreType scoreType_;

						// Token: 0x04003DD3 RID: 15827
						public const int RoundScoresFieldNumber = 2;

						// Token: 0x04003DD4 RID: 15828
						private int roundScores_;

						// Token: 0x04003DD5 RID: 15829
						public const int CumulatedScoresFieldNumber = 3;

						// Token: 0x04003DD6 RID: 15830
						private int cumulatedScores_;

						// Token: 0x04003DD7 RID: 15831
						private static KOTHUpdateEvent.Types.KOTHAllianceInformation.Types.KOTHScore jVCwyPgG7FQrvdjtAVCY;

						// Token: 0x02000D9C RID: 3484
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x0600A816 RID: 43030 RVA: 0x00322CB0 File Offset: 0x00320EB0
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x02000D9D RID: 3485
							public enum KOTHScoreType
							{
								// Token: 0x04003DD9 RID: 15833
								[OriginalName("FIGHT")]
								Fight,
								// Token: 0x04003DDA RID: 15834
								[OriginalName("DOMINATION")]
								Domination,
								// Token: 0x04003DDB RID: 15835
								[OriginalName("PRISM")]
								Prism
							}
						}
					}
				}
			}
		}
	}
}
