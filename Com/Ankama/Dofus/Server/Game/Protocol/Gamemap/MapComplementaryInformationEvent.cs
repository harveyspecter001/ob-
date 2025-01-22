using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200059E RID: 1438
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapComplementaryInformationEvent : IMessage<MapComplementaryInformationEvent>, IMessage, IEquatable<MapComplementaryInformationEvent>, IDeepCloneable<MapComplementaryInformationEvent>, IBufferMessage
	{
		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x001F7960 File Offset: 0x001F5B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapComplementaryInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x001F7970 File Offset: 0x001F5B70
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x001F7980 File Offset: 0x001F5B80
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

		// Token: 0x06004564 RID: 17764 RVA: 0x001F7990 File Offset: 0x001F5B90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInformationEvent()
		{
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x001F79A0 File Offset: 0x001F5BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInformationEvent(MapComplementaryInformationEvent other)
		{
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x001F79B0 File Offset: 0x001F5BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapComplementaryInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x001F79C0 File Offset: 0x001F5BC0
		// (set) Token: 0x06004568 RID: 17768 RVA: 0x001F79D0 File Offset: 0x001F5BD0
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x001F79E0 File Offset: 0x001F5BE0
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x001F79F0 File Offset: 0x001F5BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x001F7A00 File Offset: 0x001F5C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<House> Houses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x001F7A10 File Offset: 0x001F5C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActorPositionInformation> Actors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x001F7A20 File Offset: 0x001F5C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InteractiveElement> InteractiveElements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x001F7A30 File Offset: 0x001F5C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<StatedElement> StatedElements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x001F7A40 File Offset: 0x001F5C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapObstacle> Obstacles
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x001F7A50 File Offset: 0x001F5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightCommonInformation> Fights
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x001F7A60 File Offset: 0x001F5C60
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x001F7A70 File Offset: 0x001F5C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAggressiveMonsters
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x001F7A80 File Offset: 0x001F5C80
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x001F7A90 File Offset: 0x001F5C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapComplementaryInHouseInformation InHouseInformation
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

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x001F7AA0 File Offset: 0x001F5CA0
		// (set) Token: 0x06004576 RID: 17782 RVA: 0x001F7AB0 File Offset: 0x001F5CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCoordinates Coordinates
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x001F7AC0 File Offset: 0x001F5CC0
		// (set) Token: 0x06004578 RID: 17784 RVA: 0x001F7AD0 File Offset: 0x001F5CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapComplementaryBreachInformation BreachInformation
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x001F7AE0 File Offset: 0x001F5CE0
		// (set) Token: 0x0600457A RID: 17786 RVA: 0x001F7AF0 File Offset: 0x001F5CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapComplementaryAnomalyInformation AnomalyInformation
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x001F7B00 File Offset: 0x001F5D00
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x001F7B10 File Offset: 0x001F5D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapComplementaryHavenBagInformation HavenBagInformation
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x001F7B20 File Offset: 0x001F5D20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapComplementaryInformationEvent.SpecificComplementaryInformationOneofCase SpecificComplementaryInformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MapComplementaryInformationEvent.SpecificComplementaryInformationOneofCase)null;
			}
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x001F7B34 File Offset: 0x001F5D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSpecificComplementaryInformation()
		{
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x001F7B44 File Offset: 0x001F5D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x001F7B54 File Offset: 0x001F5D54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapComplementaryInformationEvent other)
		{
			return true;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x001F7B64 File Offset: 0x001F5D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x001F7B74 File Offset: 0x001F5D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x001F7B84 File Offset: 0x001F5D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x001F7B94 File Offset: 0x001F5D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x001F7BA4 File Offset: 0x001F5DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001F7BB4 File Offset: 0x001F5DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapComplementaryInformationEvent other)
		{
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x001F7BC4 File Offset: 0x001F5DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x001F7BD4 File Offset: 0x001F5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x001F7BE4 File Offset: 0x001F5DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapComplementaryInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 9;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						MapComplementaryInformationEvent._repeated_fights_codec = FieldCodec.ForMessage<FightCommonInformation>(66U, apvNUEmDDg9d8sb14nyJ.XVInXhlssT(apvNUEmDDg9d8sb14nyJ.BWgmDt1bLH7));
						num2 = 6;
						continue;
					case 2:
						MapComplementaryInformationEvent._repeated_actors_codec = FieldCodec.ForMessage<ActorPositionInformation>(34U, qqeH7gmD07JZLA3m1WUC.XVInXhlssT(qqeH7gmD07JZLA3m1WUC.Nt8mDCI6NhO));
						num2 = 10;
						continue;
					case 3:
						MapComplementaryInformationEvent._repeated_obstacles_codec = FieldCodec.ForMessage<MapObstacle>(58U, wKWZk1mh5EAemHwVlZcf.XVInXhlssT(wKWZk1mh5EAemHwVlZcf.c74mhyuKkiw));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						MapComplementaryInformationEvent._repeated_houses_codec = FieldCodec.ForMessage<House>(26U, Qlb7XImRf9HtV6bHB6q0.XVInXhlssT(Qlb7XImRf9HtV6bHB6q0.eFnmRnonDuN));
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						MapComplementaryInformationEvent._repeated_statedElements_codec = FieldCodec.ForMessage<StatedElement>(50U, gBs1iOmmrdoiMMBR3Fcw.XVInXhlssT(gBs1iOmmrdoiMMBR3Fcw.LUKmmVvChuq));
						num2 = 3;
						continue;
					case 6:
						return;
					case 7:
						MapComplementaryInformationEvent._parser = new MessageParser<MapComplementaryInformationEvent>(() => null);
						num2 = 4;
						continue;
					case 8:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 9:
						goto IL_8D;
					case 10:
						MapComplementaryInformationEvent._repeated_interactiveElements_codec = FieldCodec.ForMessage<InteractiveElement>(42U, AVc6eFmm5J4Y7UUcgCBr.XVInXhlssT(AVc6eFmm5J4Y7UUcgCBr.gmlmmyBRi7i));
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 7;
					}
				}
				IL_8D:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 8;
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x001F7DCC File Offset: 0x001F5FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y2RWHKOYbC4uPXfs3s5W()
		{
			return true;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x001F7DD4 File Offset: 0x001F5FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapComplementaryInformationEvent iltddDOYioogpKTBabZ3()
		{
			return null;
		}

		// Token: 0x040017DF RID: 6111
		private static readonly MessageParser<MapComplementaryInformationEvent> _parser;

		// Token: 0x040017E0 RID: 6112
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017E1 RID: 6113
		public const int SubareaIdFieldNumber = 1;

		// Token: 0x040017E2 RID: 6114
		private int subareaId_;

		// Token: 0x040017E3 RID: 6115
		public const int MapIdFieldNumber = 2;

		// Token: 0x040017E4 RID: 6116
		private long mapId_;

		// Token: 0x040017E5 RID: 6117
		public const int HousesFieldNumber = 3;

		// Token: 0x040017E6 RID: 6118
		private static readonly FieldCodec<House> _repeated_houses_codec;

		// Token: 0x040017E7 RID: 6119
		private readonly RepeatedField<House> houses_;

		// Token: 0x040017E8 RID: 6120
		public const int ActorsFieldNumber = 4;

		// Token: 0x040017E9 RID: 6121
		private static readonly FieldCodec<ActorPositionInformation> _repeated_actors_codec;

		// Token: 0x040017EA RID: 6122
		private readonly RepeatedField<ActorPositionInformation> actors_;

		// Token: 0x040017EB RID: 6123
		public const int InteractiveElementsFieldNumber = 5;

		// Token: 0x040017EC RID: 6124
		private static readonly FieldCodec<InteractiveElement> _repeated_interactiveElements_codec;

		// Token: 0x040017ED RID: 6125
		private readonly RepeatedField<InteractiveElement> interactiveElements_;

		// Token: 0x040017EE RID: 6126
		public const int StatedElementsFieldNumber = 6;

		// Token: 0x040017EF RID: 6127
		private static readonly FieldCodec<StatedElement> _repeated_statedElements_codec;

		// Token: 0x040017F0 RID: 6128
		private readonly RepeatedField<StatedElement> statedElements_;

		// Token: 0x040017F1 RID: 6129
		public const int ObstaclesFieldNumber = 7;

		// Token: 0x040017F2 RID: 6130
		private static readonly FieldCodec<MapObstacle> _repeated_obstacles_codec;

		// Token: 0x040017F3 RID: 6131
		private readonly RepeatedField<MapObstacle> obstacles_;

		// Token: 0x040017F4 RID: 6132
		public const int FightsFieldNumber = 8;

		// Token: 0x040017F5 RID: 6133
		private static readonly FieldCodec<FightCommonInformation> _repeated_fights_codec;

		// Token: 0x040017F6 RID: 6134
		private readonly RepeatedField<FightCommonInformation> fights_;

		// Token: 0x040017F7 RID: 6135
		public const int HasAggressiveMonstersFieldNumber = 9;

		// Token: 0x040017F8 RID: 6136
		private bool hasAggressiveMonsters_;

		// Token: 0x040017F9 RID: 6137
		public const int InHouseInformationFieldNumber = 10;

		// Token: 0x040017FA RID: 6138
		public const int CoordinatesFieldNumber = 11;

		// Token: 0x040017FB RID: 6139
		public const int BreachInformationFieldNumber = 12;

		// Token: 0x040017FC RID: 6140
		public const int AnomalyInformationFieldNumber = 13;

		// Token: 0x040017FD RID: 6141
		public const int HavenBagInformationFieldNumber = 14;

		// Token: 0x040017FE RID: 6142
		private object specificComplementaryInformation_;

		// Token: 0x040017FF RID: 6143
		private MapComplementaryInformationEvent.SpecificComplementaryInformationOneofCase specificComplementaryInformationCase_;

		// Token: 0x04001800 RID: 6144
		private static MapComplementaryInformationEvent VFW2DvOYYoKnhPowx68b;

		// Token: 0x0200059F RID: 1439
		public enum SpecificComplementaryInformationOneofCase
		{
			// Token: 0x04001802 RID: 6146
			None,
			// Token: 0x04001803 RID: 6147
			InHouseInformation = 10,
			// Token: 0x04001804 RID: 6148
			Coordinates,
			// Token: 0x04001805 RID: 6149
			BreachInformation,
			// Token: 0x04001806 RID: 6150
			AnomalyInformation,
			// Token: 0x04001807 RID: 6151
			HavenBagInformation
		}
	}
}
