using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000150 RID: 336
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayersMapAttackableStatusUpdateEvent : IMessage<PlayersMapAttackableStatusUpdateEvent>, IMessage, IEquatable<PlayersMapAttackableStatusUpdateEvent>, IDeepCloneable<PlayersMapAttackableStatusUpdateEvent>, IBufferMessage
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0019CD20 File Offset: 0x0019AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayersMapAttackableStatusUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0019CD30 File Offset: 0x0019AF30
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0019CD40 File Offset: 0x0019AF40
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

		// Token: 0x06000F6B RID: 3947 RVA: 0x0019CD50 File Offset: 0x0019AF50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayersMapAttackableStatusUpdateEvent()
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0019CD60 File Offset: 0x0019AF60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayersMapAttackableStatusUpdateEvent(PlayersMapAttackableStatusUpdateEvent other)
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0019CD70 File Offset: 0x0019AF70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayersMapAttackableStatusUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0019CD80 File Offset: 0x0019AF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus> PvpPlayers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0019CD90 File Offset: 0x0019AF90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0019CDA0 File Offset: 0x0019AFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayersMapAttackableStatusUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0019CDB0 File Offset: 0x0019AFB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0019CDC0 File Offset: 0x0019AFC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0019CDD0 File Offset: 0x0019AFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0019CDE0 File Offset: 0x0019AFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0019CDF0 File Offset: 0x0019AFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0019CE00 File Offset: 0x0019B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayersMapAttackableStatusUpdateEvent other)
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0019CE10 File Offset: 0x0019B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0019CE20 File Offset: 0x0019B020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0019CE30 File Offset: 0x0019B030
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayersMapAttackableStatusUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					PlayersMapAttackableStatusUpdateEvent._parser = new MessageParser<PlayersMapAttackableStatusUpdateEvent>(() => null);
					num2 = 5;
					break;
				case 4:
					return;
				case 5:
					PlayersMapAttackableStatusUpdateEvent._repeated_pvpPlayers_codec = FieldCodec.ForMessage<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus>(10U, o8xP2vrNk2SpkdP9wuC.XVInXhlssT(o8xP2vrNk2SpkdP9wuC.KUErxRLkjV));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0019CF38 File Offset: 0x0019B138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dEhYoTOUvbyQXnKwUAlw()
		{
			return true;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0019CF40 File Offset: 0x0019B140
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayersMapAttackableStatusUpdateEvent EQR9AnOUoSqoIXFmsxyg()
		{
			return null;
		}

		// Token: 0x0400059B RID: 1435
		private static readonly MessageParser<PlayersMapAttackableStatusUpdateEvent> _parser;

		// Token: 0x0400059C RID: 1436
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400059D RID: 1437
		public const int PvpPlayersFieldNumber = 1;

		// Token: 0x0400059E RID: 1438
		private static readonly FieldCodec<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus> _repeated_pvpPlayers_codec;

		// Token: 0x0400059F RID: 1439
		private readonly RepeatedField<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus> pvpPlayers_;

		// Token: 0x040005A0 RID: 1440
		private static PlayersMapAttackableStatusUpdateEvent m9WLkDOUUOU1oAeQa5Tc;

		// Token: 0x02000151 RID: 337
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06000F7C RID: 3964 RVA: 0x002ACBA8 File Offset: 0x002AADA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000152 RID: 338
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AttackableStatus : IMessage<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus>, IMessage, IEquatable<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus>, IDeepCloneable<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus>, IBufferMessage
			{
				// Token: 0x170002B8 RID: 696
				// (get) Token: 0x06000F7D RID: 3965 RVA: 0x002F7634 File Offset: 0x002F5834
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170002B9 RID: 697
				// (get) Token: 0x06000F7E RID: 3966 RVA: 0x002F7644 File Offset: 0x002F5844
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

				// Token: 0x170002BA RID: 698
				// (get) Token: 0x06000F7F RID: 3967 RVA: 0x002F7654 File Offset: 0x002F5854
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

				// Token: 0x06000F80 RID: 3968 RVA: 0x002F7664 File Offset: 0x002F5864
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AttackableStatus()
				{
				}

				// Token: 0x06000F81 RID: 3969 RVA: 0x002F7674 File Offset: 0x002F5874
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AttackableStatus(PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus other)
				{
				}

				// Token: 0x06000F82 RID: 3970 RVA: 0x002F7684 File Offset: 0x002F5884
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus Clone()
				{
					return null;
				}

				// Token: 0x170002BB RID: 699
				// (get) Token: 0x06000F83 RID: 3971 RVA: 0x002F7694 File Offset: 0x002F5894
				// (set) Token: 0x06000F84 RID: 3972 RVA: 0x002F76A4 File Offset: 0x002F58A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long CharacterId
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

				// Token: 0x170002BC RID: 700
				// (get) Token: 0x06000F85 RID: 3973 RVA: 0x002F76B4 File Offset: 0x002F58B4
				// (set) Token: 0x06000F86 RID: 3974 RVA: 0x002F76C8 File Offset: 0x002F58C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus Status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170002BD RID: 701
				// (get) Token: 0x06000F87 RID: 3975 RVA: 0x002F76D8 File Offset: 0x002F58D8
				// (set) Token: 0x06000F88 RID: 3976 RVA: 0x002F76E8 File Offset: 0x002F58E8
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

				// Token: 0x170002BE RID: 702
				// (get) Token: 0x06000F89 RID: 3977 RVA: 0x002F76F8 File Offset: 0x002F58F8
				// (set) Token: 0x06000F8A RID: 3978 RVA: 0x002F7708 File Offset: 0x002F5908
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int PictoScore
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

				// Token: 0x170002BF RID: 703
				// (get) Token: 0x06000F8B RID: 3979 RVA: 0x002F7718 File Offset: 0x002F5918
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasPictoScore
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06000F8C RID: 3980 RVA: 0x002F7728 File Offset: 0x002F5928
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearPictoScore()
				{
				}

				// Token: 0x06000F8D RID: 3981 RVA: 0x002F7738 File Offset: 0x002F5938
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06000F8E RID: 3982 RVA: 0x002F7748 File Offset: 0x002F5948
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus other)
				{
					return true;
				}

				// Token: 0x06000F8F RID: 3983 RVA: 0x002F7758 File Offset: 0x002F5958
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06000F90 RID: 3984 RVA: 0x002F7768 File Offset: 0x002F5968
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06000F91 RID: 3985 RVA: 0x002F7778 File Offset: 0x002F5978
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06000F92 RID: 3986 RVA: 0x002F7788 File Offset: 0x002F5988
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06000F93 RID: 3987 RVA: 0x002F7798 File Offset: 0x002F5998
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06000F94 RID: 3988 RVA: 0x002F77A8 File Offset: 0x002F59A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus other)
				{
				}

				// Token: 0x06000F95 RID: 3989 RVA: 0x002F77B8 File Offset: 0x002F59B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06000F96 RID: 3990 RVA: 0x002F77C8 File Offset: 0x002F59C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06000F97 RID: 3991 RVA: 0x002F77D8 File Offset: 0x002F59D8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AttackableStatus()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus._parser = new MessageParser<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus>(() => null);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 3:
							PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus.PictoScoreDefaultValue = 0;
							num2 = 5;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 5:
							return;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
					}
				}

				// Token: 0x06000F98 RID: 3992 RVA: 0x002F78D0 File Offset: 0x002F5AD0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool AgW0t7Gpg4PFANWjNbtG()
				{
					return true;
				}

				// Token: 0x06000F99 RID: 3993 RVA: 0x002F78D8 File Offset: 0x002F5AD8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus q3ot4rGpsbLEfJ7DFMjw()
				{
					return null;
				}

				// Token: 0x040005A1 RID: 1441
				private static readonly MessageParser<PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus> _parser;

				// Token: 0x040005A2 RID: 1442
				private UnknownFieldSet _unknownFields;

				// Token: 0x040005A3 RID: 1443
				private int _hasBits0;

				// Token: 0x040005A4 RID: 1444
				public const int CharacterIdFieldNumber = 1;

				// Token: 0x040005A5 RID: 1445
				private long characterId_;

				// Token: 0x040005A6 RID: 1446
				public const int StatusFieldNumber = 2;

				// Token: 0x040005A7 RID: 1447
				private Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus status_;

				// Token: 0x040005A8 RID: 1448
				public const int KothRoleFieldNumber = 3;

				// Token: 0x040005A9 RID: 1449
				private int kothRole_;

				// Token: 0x040005AA RID: 1450
				public const int PictoScoreFieldNumber = 4;

				// Token: 0x040005AB RID: 1451
				private static readonly int PictoScoreDefaultValue;

				// Token: 0x040005AC RID: 1452
				private int pictoScore_;

				// Token: 0x040005AD RID: 1453
				private static PlayersMapAttackableStatusUpdateEvent.Types.AttackableStatus O67mVmGpGLOA9eJRo4Ds;
			}
		}
	}
}
