using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas
{
	// Token: 0x02000C00 RID: 3072
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CompassUpdateEvent : IMessage<CompassUpdateEvent>, IMessage, IEquatable<CompassUpdateEvent>, IDeepCloneable<CompassUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060093B4 RID: 37812 RVA: 0x00273AA0 File Offset: 0x00271CA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CompassUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x00273AB0 File Offset: 0x00271CB0
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

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060093B6 RID: 37814 RVA: 0x00273AC0 File Offset: 0x00271CC0
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

		// Token: 0x060093B7 RID: 37815 RVA: 0x00273AD0 File Offset: 0x00271CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassUpdateEvent()
		{
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00273AE0 File Offset: 0x00271CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassUpdateEvent(CompassUpdateEvent other)
		{
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00273AF0 File Offset: 0x00271CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x060093BA RID: 37818 RVA: 0x00273B00 File Offset: 0x00271D00
		// (set) Token: 0x060093BB RID: 37819 RVA: 0x00273B14 File Offset: 0x00271D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CompassType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CompassType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x060093BC RID: 37820 RVA: 0x00273B24 File Offset: 0x00271D24
		// (set) Token: 0x060093BD RID: 37821 RVA: 0x00273B34 File Offset: 0x00271D34
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

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x060093BE RID: 37822 RVA: 0x00273B44 File Offset: 0x00271D44
		// (set) Token: 0x060093BF RID: 37823 RVA: 0x00273B54 File Offset: 0x00271D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompassUpdateEvent.Types.PartyMember PartyMember
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

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x060093C0 RID: 37824 RVA: 0x00273B64 File Offset: 0x00271D64
		// (set) Token: 0x060093C1 RID: 37825 RVA: 0x00273B74 File Offset: 0x00271D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompassUpdateEvent.Types.PvpSeek PvpSeek
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

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x060093C2 RID: 37826 RVA: 0x00273B84 File Offset: 0x00271D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompassUpdateEvent.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CompassUpdateEvent.ComplementOneofCase)null;
			}
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00273B98 File Offset: 0x00271D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x00273BA8 File Offset: 0x00271DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x00273BB8 File Offset: 0x00271DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CompassUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x00273BC8 File Offset: 0x00271DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x00273BD8 File Offset: 0x00271DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x00273BE8 File Offset: 0x00271DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00273BF8 File Offset: 0x00271DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x00273C08 File Offset: 0x00271E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x00273C18 File Offset: 0x00271E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CompassUpdateEvent other)
		{
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x00273C28 File Offset: 0x00271E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x00273C38 File Offset: 0x00271E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x00273C48 File Offset: 0x00271E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CompassUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						continue;
					case 4:
						goto IL_AC;
					}
					CompassUpdateEvent._parser = new MessageParser<CompassUpdateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 1;
					}
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x00273D18 File Offset: 0x00271F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mvY6VEJEzDkv2jZc9Jc8()
		{
			return true;
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00273D20 File Offset: 0x00271F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CompassUpdateEvent YoBm0iJXf4ID44vMoJkx()
		{
			return null;
		}

		// Token: 0x040036FC RID: 14076
		private static readonly MessageParser<CompassUpdateEvent> _parser;

		// Token: 0x040036FD RID: 14077
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036FE RID: 14078
		public const int TypeFieldNumber = 1;

		// Token: 0x040036FF RID: 14079
		private CompassType type_;

		// Token: 0x04003700 RID: 14080
		public const int CoordinatesFieldNumber = 2;

		// Token: 0x04003701 RID: 14081
		private MapCoordinates coordinates_;

		// Token: 0x04003702 RID: 14082
		public const int PartyMemberFieldNumber = 3;

		// Token: 0x04003703 RID: 14083
		public const int PvpSeekFieldNumber = 4;

		// Token: 0x04003704 RID: 14084
		private object complement_;

		// Token: 0x04003705 RID: 14085
		private CompassUpdateEvent.ComplementOneofCase complementCase_;

		// Token: 0x04003706 RID: 14086
		internal static CompassUpdateEvent HxqReHJEFwwpjyhegEpE;

		// Token: 0x02000C01 RID: 3073
		public enum ComplementOneofCase
		{
			// Token: 0x04003708 RID: 14088
			None,
			// Token: 0x04003709 RID: 14089
			PartyMember = 3,
			// Token: 0x0400370A RID: 14090
			PvpSeek
		}

		// Token: 0x02000C02 RID: 3074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060093D1 RID: 37841 RVA: 0x002E74D4 File Offset: 0x002E56D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C03 RID: 3075
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PartyMember : IMessage<CompassUpdateEvent.Types.PartyMember>, IMessage, IEquatable<CompassUpdateEvent.Types.PartyMember>, IDeepCloneable<CompassUpdateEvent.Types.PartyMember>, IBufferMessage
			{
				// Token: 0x17001BA0 RID: 7072
				// (get) Token: 0x060093D2 RID: 37842 RVA: 0x0030D0FC File Offset: 0x0030B2FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CompassUpdateEvent.Types.PartyMember> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001BA1 RID: 7073
				// (get) Token: 0x060093D3 RID: 37843 RVA: 0x0030D10C File Offset: 0x0030B30C
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

				// Token: 0x17001BA2 RID: 7074
				// (get) Token: 0x060093D4 RID: 37844 RVA: 0x0030D11C File Offset: 0x0030B31C
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

				// Token: 0x060093D5 RID: 37845 RVA: 0x0030D12C File Offset: 0x0030B32C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PartyMember()
				{
				}

				// Token: 0x060093D6 RID: 37846 RVA: 0x0030D13C File Offset: 0x0030B33C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PartyMember(CompassUpdateEvent.Types.PartyMember other)
				{
				}

				// Token: 0x060093D7 RID: 37847 RVA: 0x0030D14C File Offset: 0x0030B34C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CompassUpdateEvent.Types.PartyMember Clone()
				{
					return null;
				}

				// Token: 0x17001BA3 RID: 7075
				// (get) Token: 0x060093D8 RID: 37848 RVA: 0x0030D15C File Offset: 0x0030B35C
				// (set) Token: 0x060093D9 RID: 37849 RVA: 0x0030D16C File Offset: 0x0030B36C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long MemberId
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

				// Token: 0x17001BA4 RID: 7076
				// (get) Token: 0x060093DA RID: 37850 RVA: 0x0030D17C File Offset: 0x0030B37C
				// (set) Token: 0x060093DB RID: 37851 RVA: 0x0030D18C File Offset: 0x0030B38C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Active
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

				// Token: 0x060093DC RID: 37852 RVA: 0x0030D19C File Offset: 0x0030B39C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060093DD RID: 37853 RVA: 0x0030D1AC File Offset: 0x0030B3AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CompassUpdateEvent.Types.PartyMember other)
				{
					return true;
				}

				// Token: 0x060093DE RID: 37854 RVA: 0x0030D1BC File Offset: 0x0030B3BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060093DF RID: 37855 RVA: 0x0030D1CC File Offset: 0x0030B3CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060093E0 RID: 37856 RVA: 0x0030D1DC File Offset: 0x0030B3DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060093E1 RID: 37857 RVA: 0x0030D1EC File Offset: 0x0030B3EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060093E2 RID: 37858 RVA: 0x0030D1FC File Offset: 0x0030B3FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060093E3 RID: 37859 RVA: 0x0030D20C File Offset: 0x0030B40C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CompassUpdateEvent.Types.PartyMember other)
				{
				}

				// Token: 0x060093E4 RID: 37860 RVA: 0x0030D21C File Offset: 0x0030B41C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060093E5 RID: 37861 RVA: 0x0030D22C File Offset: 0x0030B42C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060093E6 RID: 37862 RVA: 0x0030D23C File Offset: 0x0030B43C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PartyMember()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						}
						IL_9B:
						CompassUpdateEvent.Types.PartyMember._parser = new MessageParser<CompassUpdateEvent.Types.PartyMember>(() => null);
						num = 3;
						continue;
						goto IL_9B;
					}
				}

				// Token: 0x060093E7 RID: 37863 RVA: 0x0030D30C File Offset: 0x0030B50C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool JlSeFjGZU7IFgaaUPBQL()
				{
					return true;
				}

				// Token: 0x060093E8 RID: 37864 RVA: 0x0030D314 File Offset: 0x0030B514
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CompassUpdateEvent.Types.PartyMember mLV5EZGZvtAuk0lnIjti()
				{
					return null;
				}

				// Token: 0x0400370B RID: 14091
				private static readonly MessageParser<CompassUpdateEvent.Types.PartyMember> _parser;

				// Token: 0x0400370C RID: 14092
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400370D RID: 14093
				public const int MemberIdFieldNumber = 1;

				// Token: 0x0400370E RID: 14094
				private long memberId_;

				// Token: 0x0400370F RID: 14095
				public const int ActiveFieldNumber = 2;

				// Token: 0x04003710 RID: 14096
				private bool active_;

				// Token: 0x04003711 RID: 14097
				internal static CompassUpdateEvent.Types.PartyMember dFvDKrGZcUxW2W1puWtg;
			}

			// Token: 0x02000C05 RID: 3077
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PvpSeek : IMessage<CompassUpdateEvent.Types.PvpSeek>, IMessage, IEquatable<CompassUpdateEvent.Types.PvpSeek>, IDeepCloneable<CompassUpdateEvent.Types.PvpSeek>, IBufferMessage
			{
				// Token: 0x17001BA5 RID: 7077
				// (get) Token: 0x060093EE RID: 37870 RVA: 0x0030D31C File Offset: 0x0030B51C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CompassUpdateEvent.Types.PvpSeek> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001BA6 RID: 7078
				// (get) Token: 0x060093EF RID: 37871 RVA: 0x0030D32C File Offset: 0x0030B52C
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

				// Token: 0x17001BA7 RID: 7079
				// (get) Token: 0x060093F0 RID: 37872 RVA: 0x0030D33C File Offset: 0x0030B53C
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

				// Token: 0x060093F1 RID: 37873 RVA: 0x0030D34C File Offset: 0x0030B54C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PvpSeek()
				{
				}

				// Token: 0x060093F2 RID: 37874 RVA: 0x0030D35C File Offset: 0x0030B55C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PvpSeek(CompassUpdateEvent.Types.PvpSeek other)
				{
				}

				// Token: 0x060093F3 RID: 37875 RVA: 0x0030D36C File Offset: 0x0030B56C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CompassUpdateEvent.Types.PvpSeek Clone()
				{
					return null;
				}

				// Token: 0x17001BA8 RID: 7080
				// (get) Token: 0x060093F4 RID: 37876 RVA: 0x0030D37C File Offset: 0x0030B57C
				// (set) Token: 0x060093F5 RID: 37877 RVA: 0x0030D38C File Offset: 0x0030B58C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long TargetId
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

				// Token: 0x17001BA9 RID: 7081
				// (get) Token: 0x060093F6 RID: 37878 RVA: 0x0030D39C File Offset: 0x0030B59C
				// (set) Token: 0x060093F7 RID: 37879 RVA: 0x0030D3AC File Offset: 0x0030B5AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string TargetName
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

				// Token: 0x060093F8 RID: 37880 RVA: 0x0030D3BC File Offset: 0x0030B5BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060093F9 RID: 37881 RVA: 0x0030D3CC File Offset: 0x0030B5CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CompassUpdateEvent.Types.PvpSeek other)
				{
					return true;
				}

				// Token: 0x060093FA RID: 37882 RVA: 0x0030D3DC File Offset: 0x0030B5DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060093FB RID: 37883 RVA: 0x0030D3EC File Offset: 0x0030B5EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060093FC RID: 37884 RVA: 0x0030D3FC File Offset: 0x0030B5FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060093FD RID: 37885 RVA: 0x0030D40C File Offset: 0x0030B60C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060093FE RID: 37886 RVA: 0x0030D41C File Offset: 0x0030B61C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060093FF RID: 37887 RVA: 0x0030D42C File Offset: 0x0030B62C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CompassUpdateEvent.Types.PvpSeek other)
				{
				}

				// Token: 0x06009400 RID: 37888 RVA: 0x0030D43C File Offset: 0x0030B63C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009401 RID: 37889 RVA: 0x0030D44C File Offset: 0x0030B64C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009402 RID: 37890 RVA: 0x0030D45C File Offset: 0x0030B65C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PvpSeek()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
							{
								num2 = 2;
							}
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 3;
							}
							break;
						case 3:
							CompassUpdateEvent.Types.PvpSeek._parser = new MessageParser<CompassUpdateEvent.Types.PvpSeek>(() => null);
							num2 = 4;
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x06009403 RID: 37891 RVA: 0x0030D540 File Offset: 0x0030B740
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool GaKGCsGZ13XwSOcSo41d()
				{
					return true;
				}

				// Token: 0x06009404 RID: 37892 RVA: 0x0030D548 File Offset: 0x0030B748
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CompassUpdateEvent.Types.PvpSeek bDZWn0GZadDmgqn9LK27()
				{
					return null;
				}

				// Token: 0x04003714 RID: 14100
				private static readonly MessageParser<CompassUpdateEvent.Types.PvpSeek> _parser;

				// Token: 0x04003715 RID: 14101
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003716 RID: 14102
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04003717 RID: 14103
				private long targetId_;

				// Token: 0x04003718 RID: 14104
				public const int TargetNameFieldNumber = 2;

				// Token: 0x04003719 RID: 14105
				private string targetName_;

				// Token: 0x0400371A RID: 14106
				private static CompassUpdateEvent.Types.PvpSeek JdVpgfGZotIk52lwmSDh;
			}
		}
	}
}
