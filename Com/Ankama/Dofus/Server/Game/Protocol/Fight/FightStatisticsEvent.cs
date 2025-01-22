using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000645 RID: 1605
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightStatisticsEvent : IMessage<FightStatisticsEvent>, IMessage, IEquatable<FightStatisticsEvent>, IDeepCloneable<FightStatisticsEvent>, IBufferMessage
	{
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x002039CC File Offset: 0x00201BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightStatisticsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x002039DC File Offset: 0x00201BDC
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x002039EC File Offset: 0x00201BEC
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

		// Token: 0x06004DE1 RID: 19937 RVA: 0x002039FC File Offset: 0x00201BFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStatisticsEvent()
		{
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00203A0C File Offset: 0x00201C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStatisticsEvent(FightStatisticsEvent other)
		{
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x00203A1C File Offset: 0x00201C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStatisticsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004DE4 RID: 19940 RVA: 0x00203A2C File Offset: 0x00201C2C
		// (set) Token: 0x06004DE5 RID: 19941 RVA: 0x00203A3C File Offset: 0x00201C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BaseStatistics Base
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x00203A4C File Offset: 0x00201C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry> DetailedStatisticsByFighter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00203A5C File Offset: 0x00201C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00203A6C File Offset: 0x00201C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightStatisticsEvent other)
		{
			return true;
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00203A7C File Offset: 0x00201C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00203A8C File Offset: 0x00201C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00203A9C File Offset: 0x00201C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00203AAC File Offset: 0x00201CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00203ABC File Offset: 0x00201CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00203ACC File Offset: 0x00201CCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightStatisticsEvent other)
		{
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00203ADC File Offset: 0x00201CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x00203AEC File Offset: 0x00201CEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00203AFC File Offset: 0x00201CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightStatisticsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					break;
				case 4:
					FightStatisticsEvent._repeated_detailedStatisticsByFighter_codec = FieldCodec.ForMessage<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry>(18U, nCynwXmu9BxLCjyDZu1B.XVInXhlssT(nCynwXmu9BxLCjyDZu1B.GZHmu2EVTmZ));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					FightStatisticsEvent._parser = new MessageParser<FightStatisticsEvent>(() => null);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00203BEC File Offset: 0x00201DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Us0xqsOio4BaUhXn42Yt()
		{
			return true;
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00203BF4 File Offset: 0x00201DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightStatisticsEvent oPCE4MOi1LBB0I0rZPS9()
		{
			return null;
		}

		// Token: 0x04001B3A RID: 6970
		private static readonly MessageParser<FightStatisticsEvent> _parser;

		// Token: 0x04001B3B RID: 6971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B3C RID: 6972
		public const int BaseFieldNumber = 1;

		// Token: 0x04001B3D RID: 6973
		private BaseStatistics base_;

		// Token: 0x04001B3E RID: 6974
		public const int DetailedStatisticsByFighterFieldNumber = 2;

		// Token: 0x04001B3F RID: 6975
		private static readonly FieldCodec<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry> _repeated_detailedStatisticsByFighter_codec;

		// Token: 0x04001B40 RID: 6976
		private readonly RepeatedField<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry> detailedStatisticsByFighter_;

		// Token: 0x04001B41 RID: 6977
		internal static FightStatisticsEvent mFsoi0OivPT6gal4XcTh;

		// Token: 0x02000646 RID: 1606
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06004DF4 RID: 19956 RVA: 0x002C9A68 File Offset: 0x002C7C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000647 RID: 1607
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DetailedStatisticsByFighterEntry : IMessage<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry>, IMessage, IEquatable<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry>, IDeepCloneable<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry>, IBufferMessage
			{
				// Token: 0x17000E15 RID: 3605
				// (get) Token: 0x06004DF5 RID: 19957 RVA: 0x00301FF0 File Offset: 0x003001F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E16 RID: 3606
				// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x00302000 File Offset: 0x00300200
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

				// Token: 0x17000E17 RID: 3607
				// (get) Token: 0x06004DF7 RID: 19959 RVA: 0x00302010 File Offset: 0x00300210
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

				// Token: 0x06004DF8 RID: 19960 RVA: 0x00302020 File Offset: 0x00300220
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatisticsByFighterEntry()
				{
				}

				// Token: 0x06004DF9 RID: 19961 RVA: 0x00302030 File Offset: 0x00300230
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatisticsByFighterEntry(FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry other)
				{
				}

				// Token: 0x06004DFA RID: 19962 RVA: 0x00302040 File Offset: 0x00300240
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry Clone()
				{
					return null;
				}

				// Token: 0x17000E18 RID: 3608
				// (get) Token: 0x06004DFB RID: 19963 RVA: 0x00302050 File Offset: 0x00300250
				// (set) Token: 0x06004DFC RID: 19964 RVA: 0x00302060 File Offset: 0x00300260
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long Key
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

				// Token: 0x17000E19 RID: 3609
				// (get) Token: 0x06004DFD RID: 19965 RVA: 0x00302070 File Offset: 0x00300270
				// (set) Token: 0x06004DFE RID: 19966 RVA: 0x00302080 File Offset: 0x00300280
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public DetailedStatistics Value
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

				// Token: 0x06004DFF RID: 19967 RVA: 0x00302090 File Offset: 0x00300290
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004E00 RID: 19968 RVA: 0x003020A0 File Offset: 0x003002A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry other)
				{
					return true;
				}

				// Token: 0x06004E01 RID: 19969 RVA: 0x003020B0 File Offset: 0x003002B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004E02 RID: 19970 RVA: 0x003020C0 File Offset: 0x003002C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004E03 RID: 19971 RVA: 0x003020D0 File Offset: 0x003002D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004E04 RID: 19972 RVA: 0x003020E0 File Offset: 0x003002E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004E05 RID: 19973 RVA: 0x003020F0 File Offset: 0x003002F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004E06 RID: 19974 RVA: 0x00302100 File Offset: 0x00300300
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry other)
				{
				}

				// Token: 0x06004E07 RID: 19975 RVA: 0x00302110 File Offset: 0x00300310
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004E08 RID: 19976 RVA: 0x00302120 File Offset: 0x00300320
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004E09 RID: 19977 RVA: 0x00302130 File Offset: 0x00300330
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DetailedStatisticsByFighterEntry()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry._parser = new MessageParser<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry>(() => null);
							num2 = 4;
							continue;
						case 4:
							return;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06004E0A RID: 19978 RVA: 0x00302214 File Offset: 0x00300414
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Y48F6jGPn3sT5Wa00Nj5()
				{
					return true;
				}

				// Token: 0x06004E0B RID: 19979 RVA: 0x0030221C File Offset: 0x0030041C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry b4AlovGPm1iiTW0Scxib()
				{
					return null;
				}

				// Token: 0x04001B42 RID: 6978
				private static readonly MessageParser<FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry> _parser;

				// Token: 0x04001B43 RID: 6979
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001B44 RID: 6980
				public const int KeyFieldNumber = 1;

				// Token: 0x04001B45 RID: 6981
				private long key_;

				// Token: 0x04001B46 RID: 6982
				public const int ValueFieldNumber = 2;

				// Token: 0x04001B47 RID: 6983
				private DetailedStatistics value_;

				// Token: 0x04001B48 RID: 6984
				internal static FightStatisticsEvent.Types.DetailedStatisticsByFighterEntry BVmF1vGPfAC1Tga4SRBZ;
			}
		}
	}
}
