using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x0200032D RID: 813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcsMapQuestStatusUpdateEvent : IMessage<NpcsMapQuestStatusUpdateEvent>, IMessage, IEquatable<NpcsMapQuestStatusUpdateEvent>, IDeepCloneable<NpcsMapQuestStatusUpdateEvent>, IBufferMessage
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x001C2D94 File Offset: 0x001C0F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcsMapQuestStatusUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x001C2DA4 File Offset: 0x001C0FA4
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x001C2DB4 File Offset: 0x001C0FB4
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

		// Token: 0x06002637 RID: 9783 RVA: 0x001C2DC4 File Offset: 0x001C0FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcsMapQuestStatusUpdateEvent()
		{
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x001C2DD4 File Offset: 0x001C0FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcsMapQuestStatusUpdateEvent(NpcsMapQuestStatusUpdateEvent other)
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x001C2DE4 File Offset: 0x001C0FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcsMapQuestStatusUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x001C2DF4 File Offset: 0x001C0FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest> MapInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x001C2E04 File Offset: 0x001C1004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x001C2E14 File Offset: 0x001C1014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcsMapQuestStatusUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x001C2E24 File Offset: 0x001C1024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x001C2E34 File Offset: 0x001C1034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x001C2E44 File Offset: 0x001C1044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x001C2E54 File Offset: 0x001C1054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x001C2E64 File Offset: 0x001C1064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x001C2E74 File Offset: 0x001C1074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcsMapQuestStatusUpdateEvent other)
		{
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x001C2E84 File Offset: 0x001C1084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x001C2E94 File Offset: 0x001C1094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x001C2EA4 File Offset: 0x001C10A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcsMapQuestStatusUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					NpcsMapQuestStatusUpdateEvent._repeated_mapInformation_codec = FieldCodec.ForMessage<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest>(10U, OLS78tn6saNBTekxCMXK.XVInXhlssT(OLS78tn6saNBTekxCMXK.GVBn6dIDCqg));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				NpcsMapQuestStatusUpdateEvent._parser = new MessageParser<NpcsMapQuestStatusUpdateEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x001C2F94 File Offset: 0x001C1194
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dh8UqjOWHJj10aXVgte2()
		{
			return true;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x001C2F9C File Offset: 0x001C119C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcsMapQuestStatusUpdateEvent pbbM70OWYvlhhs2EW64d()
		{
			return null;
		}

		// Token: 0x04000D92 RID: 3474
		private static readonly MessageParser<NpcsMapQuestStatusUpdateEvent> _parser;

		// Token: 0x04000D93 RID: 3475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D94 RID: 3476
		public const int MapInformationFieldNumber = 1;

		// Token: 0x04000D95 RID: 3477
		private static readonly FieldCodec<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest> _repeated_mapInformation_codec;

		// Token: 0x04000D96 RID: 3478
		private readonly RepeatedField<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest> mapInformation_;

		// Token: 0x04000D97 RID: 3479
		private static NpcsMapQuestStatusUpdateEvent xOs7NLOWpBnnMFmq2maO;

		// Token: 0x0200032E RID: 814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002648 RID: 9800 RVA: 0x002B78E4 File Offset: 0x002B5AE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200032F RID: 815
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MapNpcQuest : IMessage<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest>, IMessage, IEquatable<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest>, IDeepCloneable<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest>, IBufferMessage
			{
				// Token: 0x170006DD RID: 1757
				// (get) Token: 0x06002649 RID: 9801 RVA: 0x002FAF90 File Offset: 0x002F9190
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170006DE RID: 1758
				// (get) Token: 0x0600264A RID: 9802 RVA: 0x002FAFA0 File Offset: 0x002F91A0
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

				// Token: 0x170006DF RID: 1759
				// (get) Token: 0x0600264B RID: 9803 RVA: 0x002FAFB0 File Offset: 0x002F91B0
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

				// Token: 0x0600264C RID: 9804 RVA: 0x002FAFC0 File Offset: 0x002F91C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MapNpcQuest()
				{
				}

				// Token: 0x0600264D RID: 9805 RVA: 0x002FAFD0 File Offset: 0x002F91D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MapNpcQuest(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest other)
				{
				}

				// Token: 0x0600264E RID: 9806 RVA: 0x002FAFE0 File Offset: 0x002F91E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest Clone()
				{
					return null;
				}

				// Token: 0x170006E0 RID: 1760
				// (get) Token: 0x0600264F RID: 9807 RVA: 0x002FAFF0 File Offset: 0x002F91F0
				// (set) Token: 0x06002650 RID: 9808 RVA: 0x002FB000 File Offset: 0x002F9200
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x170006E1 RID: 1761
				// (get) Token: 0x06002651 RID: 9809 RVA: 0x002FB010 File Offset: 0x002F9210
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest> NpcsWithQuests
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06002652 RID: 9810 RVA: 0x002FB020 File Offset: 0x002F9220
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002653 RID: 9811 RVA: 0x002FB030 File Offset: 0x002F9230
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest other)
				{
					return true;
				}

				// Token: 0x06002654 RID: 9812 RVA: 0x002FB040 File Offset: 0x002F9240
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002655 RID: 9813 RVA: 0x002FB050 File Offset: 0x002F9250
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002656 RID: 9814 RVA: 0x002FB060 File Offset: 0x002F9260
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002657 RID: 9815 RVA: 0x002FB070 File Offset: 0x002F9270
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002658 RID: 9816 RVA: 0x002FB080 File Offset: 0x002F9280
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002659 RID: 9817 RVA: 0x002FB090 File Offset: 0x002F9290
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest other)
				{
				}

				// Token: 0x0600265A RID: 9818 RVA: 0x002FB0A0 File Offset: 0x002F92A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600265B RID: 9819 RVA: 0x002FB0B0 File Offset: 0x002F92B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600265C RID: 9820 RVA: 0x002FB0C0 File Offset: 0x002F92C0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MapNpcQuest()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest._parser = new MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest>(() => null);
							num2 = 3;
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest._repeated_npcsWithQuests_codec = FieldCodec.ForMessage<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest>(18U, WfyDban695nmwQiD4QO3.XVInXhlssT(WfyDban695nmwQiD4QO3.E7dn62HwvL9));
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 5:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 4;
							continue;
						}
						break;
					}
				}

				// Token: 0x0600265D RID: 9821 RVA: 0x002FB1C8 File Offset: 0x002F93C8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool h4tgKsGYdqOUI7WoroU6()
				{
					return true;
				}

				// Token: 0x0600265E RID: 9822 RVA: 0x002FB1D0 File Offset: 0x002F93D0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest AgbhF5GY9SX76PNvROAD()
				{
					return null;
				}

				// Token: 0x04000D98 RID: 3480
				private static readonly MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest> _parser;

				// Token: 0x04000D99 RID: 3481
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000D9A RID: 3482
				public const int MapIdFieldNumber = 1;

				// Token: 0x04000D9B RID: 3483
				private long mapId_;

				// Token: 0x04000D9C RID: 3484
				public const int NpcsWithQuestsFieldNumber = 2;

				// Token: 0x04000D9D RID: 3485
				private static readonly FieldCodec<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest> _repeated_npcsWithQuests_codec;

				// Token: 0x04000D9E RID: 3486
				private readonly RepeatedField<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest> npcsWithQuests_;

				// Token: 0x04000D9F RID: 3487
				private static NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest bNNtb6GYsYo3Viffc8l4;

				// Token: 0x02000330 RID: 816
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x0600265F RID: 9823 RVA: 0x0031231C File Offset: 0x0031051C
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000331 RID: 817
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class NpcWithQuest : IMessage<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest>, IMessage, IEquatable<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest>, IDeepCloneable<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest>, IBufferMessage
					{
						// Token: 0x170006E2 RID: 1762
						// (get) Token: 0x06002660 RID: 9824 RVA: 0x0031BB44 File Offset: 0x00319D44
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170006E3 RID: 1763
						// (get) Token: 0x06002661 RID: 9825 RVA: 0x0031BB54 File Offset: 0x00319D54
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

						// Token: 0x170006E4 RID: 1764
						// (get) Token: 0x06002662 RID: 9826 RVA: 0x0031BB64 File Offset: 0x00319D64
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

						// Token: 0x06002663 RID: 9827 RVA: 0x0031BB74 File Offset: 0x00319D74
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public NpcWithQuest()
						{
						}

						// Token: 0x06002664 RID: 9828 RVA: 0x0031BB84 File Offset: 0x00319D84
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public NpcWithQuest(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest other)
						{
						}

						// Token: 0x06002665 RID: 9829 RVA: 0x0031BB94 File Offset: 0x00319D94
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest Clone()
						{
							return null;
						}

						// Token: 0x170006E5 RID: 1765
						// (get) Token: 0x06002666 RID: 9830 RVA: 0x0031BBA4 File Offset: 0x00319DA4
						// (set) Token: 0x06002667 RID: 9831 RVA: 0x0031BBB4 File Offset: 0x00319DB4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int NpcId
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

						// Token: 0x170006E6 RID: 1766
						// (get) Token: 0x06002668 RID: 9832 RVA: 0x0031BBC4 File Offset: 0x00319DC4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<int> QuestsToValidate
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170006E7 RID: 1767
						// (get) Token: 0x06002669 RID: 9833 RVA: 0x0031BBD4 File Offset: 0x00319DD4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public RepeatedField<int> QuestsToStart
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x0600266A RID: 9834 RVA: 0x0031BBE4 File Offset: 0x00319DE4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600266B RID: 9835 RVA: 0x0031BBF4 File Offset: 0x00319DF4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest other)
						{
							return true;
						}

						// Token: 0x0600266C RID: 9836 RVA: 0x0031BC04 File Offset: 0x00319E04
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600266D RID: 9837 RVA: 0x0031BC14 File Offset: 0x00319E14
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600266E RID: 9838 RVA: 0x0031BC24 File Offset: 0x00319E24
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600266F RID: 9839 RVA: 0x0031BC34 File Offset: 0x00319E34
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06002670 RID: 9840 RVA: 0x0031BC44 File Offset: 0x00319E44
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06002671 RID: 9841 RVA: 0x0031BC54 File Offset: 0x00319E54
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest other)
						{
						}

						// Token: 0x06002672 RID: 9842 RVA: 0x0031BC64 File Offset: 0x00319E64
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06002673 RID: 9843 RVA: 0x0031BC74 File Offset: 0x00319E74
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06002674 RID: 9844 RVA: 0x0031BC84 File Offset: 0x00319E84
						[MethodImpl(MethodImplOptions.NoInlining)]
						static NpcWithQuest()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 6;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									return;
								case 2:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
									{
										num2 = 3;
										continue;
									}
									continue;
								case 3:
									NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest._parser = new MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 4:
									NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest._repeated_questsToStart_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 5:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 2;
									continue;
								case 6:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
									{
										num2 = 5;
										continue;
									}
									continue;
								}
								NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest._repeated_questsToValidate_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 4;
							}
						}

						// Token: 0x06002675 RID: 9845 RVA: 0x0031BDB8 File Offset: 0x00319FB8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool JfsSe4gOFokiA1afoR5J()
						{
							return true;
						}

						// Token: 0x06002676 RID: 9846 RVA: 0x0031BDC0 File Offset: 0x00319FC0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest lb0LYKgOz5mA5HsNNGst()
						{
							return null;
						}

						// Token: 0x04000DA0 RID: 3488
						private static readonly MessageParser<NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest> _parser;

						// Token: 0x04000DA1 RID: 3489
						private UnknownFieldSet _unknownFields;

						// Token: 0x04000DA2 RID: 3490
						public const int NpcIdFieldNumber = 1;

						// Token: 0x04000DA3 RID: 3491
						private int npcId_;

						// Token: 0x04000DA4 RID: 3492
						public const int QuestsToValidateFieldNumber = 2;

						// Token: 0x04000DA5 RID: 3493
						private static readonly FieldCodec<int> _repeated_questsToValidate_codec;

						// Token: 0x04000DA6 RID: 3494
						private readonly RepeatedField<int> questsToValidate_;

						// Token: 0x04000DA7 RID: 3495
						public const int QuestsToStartFieldNumber = 3;

						// Token: 0x04000DA8 RID: 3496
						private static readonly FieldCodec<int> _repeated_questsToStart_codec;

						// Token: 0x04000DA9 RID: 3497
						private readonly RepeatedField<int> questsToStart_;

						// Token: 0x04000DAA RID: 3498
						private static NpcsMapQuestStatusUpdateEvent.Types.MapNpcQuest.Types.NpcWithQuest CAJgNPgOqN7SaYvA7Pri;
					}
				}
			}
		}
	}
}
