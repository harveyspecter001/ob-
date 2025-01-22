using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009C5 RID: 2501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActorPositionInformation : IMessage<ActorPositionInformation>, IMessage, IEquatable<ActorPositionInformation>, IDeepCloneable<ActorPositionInformation>, IBufferMessage
	{
		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x0025BAE0 File Offset: 0x00259CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActorPositionInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x0025BAF0 File Offset: 0x00259CF0
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

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x0025BB00 File Offset: 0x00259D00
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

		// Token: 0x06007758 RID: 30552 RVA: 0x0025BB10 File Offset: 0x00259D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActorPositionInformation()
		{
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x0025BB20 File Offset: 0x00259D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActorPositionInformation(ActorPositionInformation other)
		{
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x0025BB30 File Offset: 0x00259D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActorPositionInformation Clone()
		{
			return null;
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x0025BB40 File Offset: 0x00259D40
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x0025BB50 File Offset: 0x00259D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActorId
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

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x0025BB60 File Offset: 0x00259D60
		// (set) Token: 0x0600775E RID: 30558 RVA: 0x0025BB70 File Offset: 0x00259D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityDisposition Disposition
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

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x0025BB80 File Offset: 0x00259D80
		// (set) Token: 0x06007760 RID: 30560 RVA: 0x0025BB90 File Offset: 0x00259D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorPositionInformation.Types.ActorInformation ActorInformation
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

		// Token: 0x06007761 RID: 30561 RVA: 0x0025BBA0 File Offset: 0x00259DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x0025BBB0 File Offset: 0x00259DB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ActorPositionInformation other)
		{
			return true;
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x0025BBC0 File Offset: 0x00259DC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x0025BBD0 File Offset: 0x00259DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x0025BBE0 File Offset: 0x00259DE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x0025BBF0 File Offset: 0x00259DF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x0025BC00 File Offset: 0x00259E00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x0025BC10 File Offset: 0x00259E10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ActorPositionInformation other)
		{
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x0025BC20 File Offset: 0x00259E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x0025BC30 File Offset: 0x00259E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x0025BC40 File Offset: 0x00259E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ActorPositionInformation()
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
					default:
						goto IL_35;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						ActorPositionInformation._parser = new MessageParser<ActorPositionInformation>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 3;
						}
						break;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x0025BD28 File Offset: 0x00259F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ndJmQQJGny5jmq9wEcZR()
		{
			return true;
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x0025BD30 File Offset: 0x00259F30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ActorPositionInformation DQSZ06JGmZx5Wh3SbEyE()
		{
			return null;
		}

		// Token: 0x04002A8D RID: 10893
		private static readonly MessageParser<ActorPositionInformation> _parser;

		// Token: 0x04002A8E RID: 10894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A8F RID: 10895
		public const int ActorIdFieldNumber = 1;

		// Token: 0x04002A90 RID: 10896
		private long actorId_;

		// Token: 0x04002A91 RID: 10897
		public const int DispositionFieldNumber = 2;

		// Token: 0x04002A92 RID: 10898
		private EntityDisposition disposition_;

		// Token: 0x04002A93 RID: 10899
		public const int ActorInformationFieldNumber = 3;

		// Token: 0x04002A94 RID: 10900
		private ActorPositionInformation.Types.ActorInformation actorInformation_;

		// Token: 0x04002A95 RID: 10901
		private static ActorPositionInformation eKKXj3JGfvLi7w1CGdPn;

		// Token: 0x020009C6 RID: 2502
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600776E RID: 30574 RVA: 0x002DECDC File Offset: 0x002DCEDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020009C7 RID: 2503
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ActorInformation : IMessage<ActorPositionInformation.Types.ActorInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation>, IBufferMessage
			{
				// Token: 0x17001563 RID: 5475
				// (get) Token: 0x0600776F RID: 30575 RVA: 0x00306EB0 File Offset: 0x003050B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ActorPositionInformation.Types.ActorInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001564 RID: 5476
				// (get) Token: 0x06007770 RID: 30576 RVA: 0x00306EC0 File Offset: 0x003050C0
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

				// Token: 0x17001565 RID: 5477
				// (get) Token: 0x06007771 RID: 30577 RVA: 0x00306ED0 File Offset: 0x003050D0
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

				// Token: 0x06007772 RID: 30578 RVA: 0x00306EE0 File Offset: 0x003050E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ActorInformation()
				{
				}

				// Token: 0x06007773 RID: 30579 RVA: 0x00306EF0 File Offset: 0x003050F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ActorInformation(ActorPositionInformation.Types.ActorInformation other)
				{
				}

				// Token: 0x06007774 RID: 30580 RVA: 0x00306F00 File Offset: 0x00305100
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ActorPositionInformation.Types.ActorInformation Clone()
				{
					return null;
				}

				// Token: 0x17001566 RID: 5478
				// (get) Token: 0x06007775 RID: 30581 RVA: 0x00306F10 File Offset: 0x00305110
				// (set) Token: 0x06007776 RID: 30582 RVA: 0x00306F20 File Offset: 0x00305120
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EntityLook Look
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

				// Token: 0x17001567 RID: 5479
				// (get) Token: 0x06007777 RID: 30583 RVA: 0x00306F30 File Offset: 0x00305130
				// (set) Token: 0x06007778 RID: 30584 RVA: 0x00306F40 File Offset: 0x00305140
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor RolePlayActor
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

				// Token: 0x17001568 RID: 5480
				// (get) Token: 0x06007779 RID: 30585 RVA: 0x00306F50 File Offset: 0x00305150
				// (set) Token: 0x0600777A RID: 30586 RVA: 0x00306F60 File Offset: 0x00305160
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation Fighter
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

				// Token: 0x17001569 RID: 5481
				// (get) Token: 0x0600777B RID: 30587 RVA: 0x00306F70 File Offset: 0x00305170
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ActorPositionInformation.Types.ActorInformation.InformationOneofCase InformationCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (ActorPositionInformation.Types.ActorInformation.InformationOneofCase)null;
					}
				}

				// Token: 0x0600777C RID: 30588 RVA: 0x00306F84 File Offset: 0x00305184
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearInformation()
				{
				}

				// Token: 0x0600777D RID: 30589 RVA: 0x00306F94 File Offset: 0x00305194
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600777E RID: 30590 RVA: 0x00306FA4 File Offset: 0x003051A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ActorPositionInformation.Types.ActorInformation other)
				{
					return true;
				}

				// Token: 0x0600777F RID: 30591 RVA: 0x00306FB4 File Offset: 0x003051B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007780 RID: 30592 RVA: 0x00306FC4 File Offset: 0x003051C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007781 RID: 30593 RVA: 0x00306FD4 File Offset: 0x003051D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007782 RID: 30594 RVA: 0x00306FE4 File Offset: 0x003051E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007783 RID: 30595 RVA: 0x00306FF4 File Offset: 0x003051F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007784 RID: 30596 RVA: 0x00307004 File Offset: 0x00305204
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ActorPositionInformation.Types.ActorInformation other)
				{
				}

				// Token: 0x06007785 RID: 30597 RVA: 0x00307014 File Offset: 0x00305214
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007786 RID: 30598 RVA: 0x00307024 File Offset: 0x00305224
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007787 RID: 30599 RVA: 0x00307034 File Offset: 0x00305234
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ActorInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						ActorPositionInformation.Types.ActorInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06007788 RID: 30600 RVA: 0x0030712C File Offset: 0x0030532C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool SFDJIVGMpjDwo45KN0th()
				{
					return true;
				}

				// Token: 0x06007789 RID: 30601 RVA: 0x00307134 File Offset: 0x00305334
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ActorPositionInformation.Types.ActorInformation DSXP94GMHHQ4CxoADtCw()
				{
					return null;
				}

				// Token: 0x04002A96 RID: 10902
				private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation> _parser;

				// Token: 0x04002A97 RID: 10903
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002A98 RID: 10904
				public const int LookFieldNumber = 1;

				// Token: 0x04002A99 RID: 10905
				private EntityLook look_;

				// Token: 0x04002A9A RID: 10906
				public const int RolePlayActorFieldNumber = 2;

				// Token: 0x04002A9B RID: 10907
				public const int FighterFieldNumber = 3;

				// Token: 0x04002A9C RID: 10908
				private object information_;

				// Token: 0x04002A9D RID: 10909
				private ActorPositionInformation.Types.ActorInformation.InformationOneofCase informationCase_;

				// Token: 0x04002A9E RID: 10910
				internal static ActorPositionInformation.Types.ActorInformation AeMpvHGMT432VpZC1gCo;

				// Token: 0x020009C8 RID: 2504
				public enum InformationOneofCase
				{
					// Token: 0x04002AA0 RID: 10912
					None,
					// Token: 0x04002AA1 RID: 10913
					RolePlayActor = 2,
					// Token: 0x04002AA2 RID: 10914
					Fighter
				}

				// Token: 0x020009C9 RID: 2505
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600778A RID: 30602 RVA: 0x003172C8 File Offset: 0x003154C8
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x020009CA RID: 2506
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class RolePlayActor : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor>, IBufferMessage
					{
						// Token: 0x1700156A RID: 5482
						// (get) Token: 0x0600778B RID: 30603 RVA: 0x0031CF64 File Offset: 0x0031B164
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700156B RID: 5483
						// (get) Token: 0x0600778C RID: 30604 RVA: 0x0031CF74 File Offset: 0x0031B174
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

						// Token: 0x1700156C RID: 5484
						// (get) Token: 0x0600778D RID: 30605 RVA: 0x0031CF84 File Offset: 0x0031B184
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

						// Token: 0x0600778E RID: 30606 RVA: 0x0031CF94 File Offset: 0x0031B194
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public RolePlayActor()
						{
						}

						// Token: 0x0600778F RID: 30607 RVA: 0x0031CFA4 File Offset: 0x0031B1A4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public RolePlayActor(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor other)
						{
						}

						// Token: 0x06007790 RID: 30608 RVA: 0x0031CFB4 File Offset: 0x0031B1B4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor Clone()
						{
							return null;
						}

						// Token: 0x1700156D RID: 5485
						// (get) Token: 0x06007791 RID: 30609 RVA: 0x0031CFC4 File Offset: 0x0031B1C4
						// (set) Token: 0x06007792 RID: 30610 RVA: 0x0031CFD4 File Offset: 0x0031B1D4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor NamedActor
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

						// Token: 0x1700156E RID: 5486
						// (get) Token: 0x06007793 RID: 30611 RVA: 0x0031CFE4 File Offset: 0x0031B1E4
						// (set) Token: 0x06007794 RID: 30612 RVA: 0x0031CFF4 File Offset: 0x0031B1F4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor TaxCollectorActor
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

						// Token: 0x1700156F RID: 5487
						// (get) Token: 0x06007795 RID: 30613 RVA: 0x0031D004 File Offset: 0x0031B204
						// (set) Token: 0x06007796 RID: 30614 RVA: 0x0031D014 File Offset: 0x0031B214
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor MonsterGroupActor
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

						// Token: 0x17001570 RID: 5488
						// (get) Token: 0x06007797 RID: 30615 RVA: 0x0031D024 File Offset: 0x0031B224
						// (set) Token: 0x06007798 RID: 30616 RVA: 0x0031D034 File Offset: 0x0031B234
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation NpcActor
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

						// Token: 0x17001571 RID: 5489
						// (get) Token: 0x06007799 RID: 30617 RVA: 0x0031D044 File Offset: 0x0031B244
						// (set) Token: 0x0600779A RID: 30618 RVA: 0x0031D054 File Offset: 0x0031B254
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public PrismInformation PrismActor
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

						// Token: 0x17001572 RID: 5490
						// (get) Token: 0x0600779B RID: 30619 RVA: 0x0031D064 File Offset: 0x0031B264
						// (set) Token: 0x0600779C RID: 30620 RVA: 0x0031D074 File Offset: 0x0031B274
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public PortalInformation PortalActor
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

						// Token: 0x17001573 RID: 5491
						// (get) Token: 0x0600779D RID: 30621 RVA: 0x0031D084 File Offset: 0x0031B284
						// (set) Token: 0x0600779E RID: 30622 RVA: 0x0031D094 File Offset: 0x0031B294
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int TreasureHuntNpcId
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

						// Token: 0x17001574 RID: 5492
						// (get) Token: 0x0600779F RID: 30623 RVA: 0x0031D0A4 File Offset: 0x0031B2A4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public bool HasTreasureHuntNpcId
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
						}

						// Token: 0x060077A0 RID: 30624 RVA: 0x0031D0B4 File Offset: 0x0031B2B4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearTreasureHuntNpcId()
						{
						}

						// Token: 0x17001575 RID: 5493
						// (get) Token: 0x060077A1 RID: 30625 RVA: 0x0031D0C4 File Offset: 0x0031B2C4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.ActorOneofCase ActorCase
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.ActorOneofCase)null;
							}
						}

						// Token: 0x060077A2 RID: 30626 RVA: 0x0031D0D8 File Offset: 0x0031B2D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearActor()
						{
						}

						// Token: 0x060077A3 RID: 30627 RVA: 0x0031D0E8 File Offset: 0x0031B2E8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060077A4 RID: 30628 RVA: 0x0031D0F8 File Offset: 0x0031B2F8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor other)
						{
							return true;
						}

						// Token: 0x060077A5 RID: 30629 RVA: 0x0031D108 File Offset: 0x0031B308
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060077A6 RID: 30630 RVA: 0x0031D118 File Offset: 0x0031B318
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060077A7 RID: 30631 RVA: 0x0031D128 File Offset: 0x0031B328
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060077A8 RID: 30632 RVA: 0x0031D138 File Offset: 0x0031B338
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060077A9 RID: 30633 RVA: 0x0031D148 File Offset: 0x0031B348
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060077AA RID: 30634 RVA: 0x0031D158 File Offset: 0x0031B358
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor other)
						{
						}

						// Token: 0x060077AB RID: 30635 RVA: 0x0031D168 File Offset: 0x0031B368
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060077AC RID: 30636 RVA: 0x0031D178 File Offset: 0x0031B378
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060077AD RID: 30637 RVA: 0x0031D188 File Offset: 0x0031B388
						[MethodImpl(MethodImplOptions.NoInlining)]
						static RolePlayActor()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									return;
								case 1:
									ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
									{
										num2 = 0;
									}
									break;
								case 2:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
									{
										num2 = 1;
									}
									break;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 2;
									break;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 3;
									break;
								}
							}
						}

						// Token: 0x060077AE RID: 30638 RVA: 0x0031D254 File Offset: 0x0031B454
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool jUt4EOgJvkKcbgNZMmTB()
						{
							return true;
						}

						// Token: 0x060077AF RID: 30639 RVA: 0x0031D25C File Offset: 0x0031B45C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor Xf9hiPgJoVRMjRYRb9xm()
						{
							return null;
						}

						// Token: 0x04002AA3 RID: 10915
						private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor> _parser;

						// Token: 0x04002AA4 RID: 10916
						private UnknownFieldSet _unknownFields;

						// Token: 0x04002AA5 RID: 10917
						public const int NamedActorFieldNumber = 4;

						// Token: 0x04002AA6 RID: 10918
						public const int TaxCollectorActorFieldNumber = 5;

						// Token: 0x04002AA7 RID: 10919
						public const int MonsterGroupActorFieldNumber = 6;

						// Token: 0x04002AA8 RID: 10920
						public const int NpcActorFieldNumber = 7;

						// Token: 0x04002AA9 RID: 10921
						public const int PrismActorFieldNumber = 8;

						// Token: 0x04002AAA RID: 10922
						public const int PortalActorFieldNumber = 9;

						// Token: 0x04002AAB RID: 10923
						public const int TreasureHuntNpcIdFieldNumber = 10;

						// Token: 0x04002AAC RID: 10924
						private object actor_;

						// Token: 0x04002AAD RID: 10925
						private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.ActorOneofCase actorCase_;

						// Token: 0x04002AAE RID: 10926
						private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor XPmMRWgJU9vhPZJDWkYP;

						// Token: 0x020009CB RID: 2507
						public enum ActorOneofCase
						{
							// Token: 0x04002AB0 RID: 10928
							None,
							// Token: 0x04002AB1 RID: 10929
							NamedActor = 4,
							// Token: 0x04002AB2 RID: 10930
							TaxCollectorActor,
							// Token: 0x04002AB3 RID: 10931
							MonsterGroupActor,
							// Token: 0x04002AB4 RID: 10932
							NpcActor,
							// Token: 0x04002AB5 RID: 10933
							PrismActor,
							// Token: 0x04002AB6 RID: 10934
							PortalActor,
							// Token: 0x04002AB7 RID: 10935
							TreasureHuntNpcId
						}

						// Token: 0x020009CC RID: 2508
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x060077B0 RID: 30640 RVA: 0x00321748 File Offset: 0x0031F948
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x020009CD RID: 2509
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class NamedActor : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor>, IBufferMessage
							{
								// Token: 0x17001576 RID: 5494
								// (get) Token: 0x060077B1 RID: 30641 RVA: 0x0032347C File Offset: 0x0032167C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17001577 RID: 5495
								// (get) Token: 0x060077B2 RID: 30642 RVA: 0x0032348C File Offset: 0x0032168C
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

								// Token: 0x17001578 RID: 5496
								// (get) Token: 0x060077B3 RID: 30643 RVA: 0x0032349C File Offset: 0x0032169C
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

								// Token: 0x060077B4 RID: 30644 RVA: 0x003234AC File Offset: 0x003216AC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NamedActor()
								{
								}

								// Token: 0x060077B5 RID: 30645 RVA: 0x003234BC File Offset: 0x003216BC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NamedActor(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor other)
								{
								}

								// Token: 0x060077B6 RID: 30646 RVA: 0x003234CC File Offset: 0x003216CC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor Clone()
								{
									return null;
								}

								// Token: 0x17001579 RID: 5497
								// (get) Token: 0x060077B7 RID: 30647 RVA: 0x003234DC File Offset: 0x003216DC
								// (set) Token: 0x060077B8 RID: 30648 RVA: 0x003234EC File Offset: 0x003216EC
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public string Name
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

								// Token: 0x1700157A RID: 5498
								// (get) Token: 0x060077B9 RID: 30649 RVA: 0x003234FC File Offset: 0x003216FC
								// (set) Token: 0x060077BA RID: 30650 RVA: 0x0032350C File Offset: 0x0032170C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid HumanoidInformation
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

								// Token: 0x1700157B RID: 5499
								// (get) Token: 0x060077BB RID: 30651 RVA: 0x0032351C File Offset: 0x0032171C
								// (set) Token: 0x060077BC RID: 30652 RVA: 0x0032352C File Offset: 0x0032172C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount MountInformation
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

								// Token: 0x1700157C RID: 5500
								// (get) Token: 0x060077BD RID: 30653 RVA: 0x0032353C File Offset: 0x0032173C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.ActorOneofCase ActorCase
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.ActorOneofCase)null;
									}
								}

								// Token: 0x060077BE RID: 30654 RVA: 0x00323550 File Offset: 0x00321750
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void ClearActor()
								{
								}

								// Token: 0x060077BF RID: 30655 RVA: 0x00323560 File Offset: 0x00321760
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x060077C0 RID: 30656 RVA: 0x00323570 File Offset: 0x00321770
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor other)
								{
									return true;
								}

								// Token: 0x060077C1 RID: 30657 RVA: 0x00323580 File Offset: 0x00321780
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x060077C2 RID: 30658 RVA: 0x00323590 File Offset: 0x00321790
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x060077C3 RID: 30659 RVA: 0x003235A0 File Offset: 0x003217A0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x060077C4 RID: 30660 RVA: 0x003235B0 File Offset: 0x003217B0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x060077C5 RID: 30661 RVA: 0x003235C0 File Offset: 0x003217C0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x060077C6 RID: 30662 RVA: 0x003235D0 File Offset: 0x003217D0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor other)
								{
								}

								// Token: 0x060077C7 RID: 30663 RVA: 0x003235E0 File Offset: 0x003217E0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x060077C8 RID: 30664 RVA: 0x003235F0 File Offset: 0x003217F0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x060077C9 RID: 30665 RVA: 0x00323600 File Offset: 0x00321800
								[MethodImpl(MethodImplOptions.NoInlining)]
								static NamedActor()
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
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
												{
													num2 = 0;
													continue;
												}
												continue;
											case 2:
												return;
											case 3:
												ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor>(() => null);
												num2 = 2;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
												{
													num2 = 2;
													continue;
												}
												continue;
											case 4:
												UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
												num2 = 3;
												continue;
											}
											break;
										}
										IL_49:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num = 4;
										continue;
										goto IL_49;
									}
								}

								// Token: 0x060077CA RID: 30666 RVA: 0x003236D0 File Offset: 0x003218D0
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool qR1x0OgdLmf9WMVwlo4h()
								{
									return true;
								}

								// Token: 0x060077CB RID: 30667 RVA: 0x003236D8 File Offset: 0x003218D8
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor VyE5icgdWpvCneUEiCcM()
								{
									return null;
								}

								// Token: 0x04002AB8 RID: 10936
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor> _parser;

								// Token: 0x04002AB9 RID: 10937
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002ABA RID: 10938
								public const int NameFieldNumber = 1;

								// Token: 0x04002ABB RID: 10939
								private string name_;

								// Token: 0x04002ABC RID: 10940
								public const int HumanoidInformationFieldNumber = 2;

								// Token: 0x04002ABD RID: 10941
								public const int MountInformationFieldNumber = 3;

								// Token: 0x04002ABE RID: 10942
								private object actor_;

								// Token: 0x04002ABF RID: 10943
								private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.ActorOneofCase actorCase_;

								// Token: 0x04002AC0 RID: 10944
								private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor o6K1iHgd6VRan26B76If;

								// Token: 0x020009CE RID: 2510
								public enum ActorOneofCase
								{
									// Token: 0x04002AC2 RID: 10946
									None,
									// Token: 0x04002AC3 RID: 10947
									HumanoidInformation = 2,
									// Token: 0x04002AC4 RID: 10948
									MountInformation
								}

								// Token: 0x020009CF RID: 2511
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static class Types
								{
									// Token: 0x060077CC RID: 30668 RVA: 0x00325190 File Offset: 0x00323390
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x020009D0 RID: 2512
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class Humanoid : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid>, IBufferMessage
									{
										// Token: 0x1700157D RID: 5501
										// (get) Token: 0x060077CD RID: 30669 RVA: 0x00325CB4 File Offset: 0x00323EB4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700157E RID: 5502
										// (get) Token: 0x060077CE RID: 30670 RVA: 0x00325CC4 File Offset: 0x00323EC4
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

										// Token: 0x1700157F RID: 5503
										// (get) Token: 0x060077CF RID: 30671 RVA: 0x00325CD4 File Offset: 0x00323ED4
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

										// Token: 0x060077D0 RID: 30672 RVA: 0x00325CE4 File Offset: 0x00323EE4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Humanoid()
										{
										}

										// Token: 0x060077D1 RID: 30673 RVA: 0x00325CF4 File Offset: 0x00323EF4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Humanoid(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid other)
										{
										}

										// Token: 0x060077D2 RID: 30674 RVA: 0x00325D04 File Offset: 0x00323F04
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid Clone()
										{
											return null;
										}

										// Token: 0x17001580 RID: 5504
										// (get) Token: 0x060077D3 RID: 30675 RVA: 0x00325D14 File Offset: 0x00323F14
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public RepeatedField<Restriction> Restrictions
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x17001581 RID: 5505
										// (get) Token: 0x060077D4 RID: 30676 RVA: 0x00325D24 File Offset: 0x00323F24
										// (set) Token: 0x060077D5 RID: 30677 RVA: 0x00325D38 File Offset: 0x00323F38
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public Gender Gender
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return (Gender)null;
											}
											[MethodImpl(MethodImplOptions.NoInlining)]
											set
											{
											}
										}

										// Token: 0x17001582 RID: 5506
										// (get) Token: 0x060077D6 RID: 30678 RVA: 0x00325D48 File Offset: 0x00323F48
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public RepeatedField<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption> Options
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x17001583 RID: 5507
										// (get) Token: 0x060077D7 RID: 30679 RVA: 0x00325D58 File Offset: 0x00323F58
										// (set) Token: 0x060077D8 RID: 30680 RVA: 0x00325D68 File Offset: 0x00323F68
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public long AccountId
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

										// Token: 0x17001584 RID: 5508
										// (get) Token: 0x060077D9 RID: 30681 RVA: 0x00325D78 File Offset: 0x00323F78
										// (set) Token: 0x060077DA RID: 30682 RVA: 0x00325D88 File Offset: 0x00323F88
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public AlignmentInformation AlignmentInformation
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

										// Token: 0x17001585 RID: 5509
										// (get) Token: 0x060077DB RID: 30683 RVA: 0x00325D98 File Offset: 0x00323F98
										// (set) Token: 0x060077DC RID: 30684 RVA: 0x00325DA8 File Offset: 0x00323FA8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation MutantInformation
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

										// Token: 0x060077DD RID: 30685 RVA: 0x00325DB8 File Offset: 0x00323FB8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x060077DE RID: 30686 RVA: 0x00325DC8 File Offset: 0x00323FC8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid other)
										{
											return true;
										}

										// Token: 0x060077DF RID: 30687 RVA: 0x00325DD8 File Offset: 0x00323FD8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x060077E0 RID: 30688 RVA: 0x00325DE8 File Offset: 0x00323FE8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x060077E1 RID: 30689 RVA: 0x00325DF8 File Offset: 0x00323FF8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x060077E2 RID: 30690 RVA: 0x00325E08 File Offset: 0x00324008
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x060077E3 RID: 30691 RVA: 0x00325E18 File Offset: 0x00324018
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x060077E4 RID: 30692 RVA: 0x00325E28 File Offset: 0x00324028
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid other)
										{
										}

										// Token: 0x060077E5 RID: 30693 RVA: 0x00325E38 File Offset: 0x00324038
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x060077E6 RID: 30694 RVA: 0x00325E48 File Offset: 0x00324048
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x060077E7 RID: 30695 RVA: 0x00325E58 File Offset: 0x00324058
										[MethodImpl(MethodImplOptions.NoInlining)]
										static Humanoid()
										{
											uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
											int num = 4;
											int num2 = num;
											for (;;)
											{
												switch (num2)
												{
												case 1:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid._repeated_options_codec = FieldCodec.ForMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption>(26U, VZRymlBjsIvUq3isxiQ9.XVInXhlssT(VZRymlBjsIvUq3isxiQ9.d3UBjdUiHnB));
													num2 = 5;
													continue;
												case 3:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 4:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 3;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
													{
														num2 = 3;
														continue;
													}
													continue;
												case 5:
													return;
												case 6:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid._repeated_restrictions_codec = FieldCodec.ForEnum<Restriction>(10U, (Restriction x) => 0, (int x) => (Restriction)null);
													num2 = 2;
													continue;
												}
												ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid>(() => null);
												num2 = 6;
											}
										}

										// Token: 0x060077E8 RID: 30696 RVA: 0x00325F98 File Offset: 0x00324198
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool rnZijZg2lYDgEMtfLDB2()
										{
											return true;
										}

										// Token: 0x060077E9 RID: 30697 RVA: 0x00325FA0 File Offset: 0x003241A0
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid BBb3Q7g2cfNBHEWGtgSt()
										{
											return null;
										}

										// Token: 0x04002AC5 RID: 10949
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid> _parser;

										// Token: 0x04002AC6 RID: 10950
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002AC7 RID: 10951
										public const int RestrictionsFieldNumber = 1;

										// Token: 0x04002AC8 RID: 10952
										private static readonly FieldCodec<Restriction> _repeated_restrictions_codec;

										// Token: 0x04002AC9 RID: 10953
										private readonly RepeatedField<Restriction> restrictions_;

										// Token: 0x04002ACA RID: 10954
										public const int GenderFieldNumber = 2;

										// Token: 0x04002ACB RID: 10955
										private Gender gender_;

										// Token: 0x04002ACC RID: 10956
										public const int OptionsFieldNumber = 3;

										// Token: 0x04002ACD RID: 10957
										private static readonly FieldCodec<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption> _repeated_options_codec;

										// Token: 0x04002ACE RID: 10958
										private readonly RepeatedField<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption> options_;

										// Token: 0x04002ACF RID: 10959
										public const int AccountIdFieldNumber = 4;

										// Token: 0x04002AD0 RID: 10960
										private long accountId_;

										// Token: 0x04002AD1 RID: 10961
										public const int AlignmentInformationFieldNumber = 5;

										// Token: 0x04002AD2 RID: 10962
										private AlignmentInformation alignmentInformation_;

										// Token: 0x04002AD3 RID: 10963
										public const int MutantInformationFieldNumber = 6;

										// Token: 0x04002AD4 RID: 10964
										private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation mutantInformation_;

										// Token: 0x04002AD5 RID: 10965
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid T3CpKpg2kxPrHU9GPWot;

										// Token: 0x020009D1 RID: 2513
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static class Types
										{
											// Token: 0x060077EA RID: 30698 RVA: 0x00327F9C File Offset: 0x0032619C
											[MethodImpl(MethodImplOptions.NoInlining)]
											static Types()
											{
												uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
												xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											}

											// Token: 0x020009D2 RID: 2514
											[DebuggerDisplay("{ToString(),nq}")]
											public sealed class HumanOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption>, IBufferMessage
											{
												// Token: 0x17001586 RID: 5510
												// (get) Token: 0x060077EB RID: 30699 RVA: 0x00328D2C File Offset: 0x00326F2C
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption> Parser
												{
													[MethodImpl(MethodImplOptions.NoInlining)]
													get
													{
														return null;
													}
												}

												// Token: 0x17001587 RID: 5511
												// (get) Token: 0x060077EC RID: 30700 RVA: 0x00328D3C File Offset: 0x00326F3C
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

												// Token: 0x17001588 RID: 5512
												// (get) Token: 0x060077ED RID: 30701 RVA: 0x00328D4C File Offset: 0x00326F4C
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

												// Token: 0x060077EE RID: 30702 RVA: 0x00328D5C File Offset: 0x00326F5C
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public HumanOption()
												{
												}

												// Token: 0x060077EF RID: 30703 RVA: 0x00328D6C File Offset: 0x00326F6C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public HumanOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption other)
												{
												}

												// Token: 0x060077F0 RID: 30704 RVA: 0x00328D7C File Offset: 0x00326F7C
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption Clone()
												{
													return null;
												}

												// Token: 0x17001589 RID: 5513
												// (get) Token: 0x060077F1 RID: 30705 RVA: 0x00328D8C File Offset: 0x00326F8C
												// (set) Token: 0x060077F2 RID: 30706 RVA: 0x00328D9C File Offset: 0x00326F9C
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption Followers
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

												// Token: 0x1700158A RID: 5514
												// (get) Token: 0x060077F3 RID: 30707 RVA: 0x00328DAC File Offset: 0x00326FAC
												// (set) Token: 0x060077F4 RID: 30708 RVA: 0x00328DBC File Offset: 0x00326FBC
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public GuildInformation GuildInformation
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

												// Token: 0x1700158B RID: 5515
												// (get) Token: 0x060077F5 RID: 30709 RVA: 0x00328DCC File Offset: 0x00326FCC
												// (set) Token: 0x060077F6 RID: 30710 RVA: 0x00328DDC File Offset: 0x00326FDC
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption AllianceInformation
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

												// Token: 0x1700158C RID: 5516
												// (get) Token: 0x060077F7 RID: 30711 RVA: 0x00328DEC File Offset: 0x00326FEC
												// (set) Token: 0x060077F8 RID: 30712 RVA: 0x00328DFC File Offset: 0x00326FFC
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption EmoteOption
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

												// Token: 0x1700158D RID: 5517
												// (get) Token: 0x060077F9 RID: 30713 RVA: 0x00328E0C File Offset: 0x0032700C
												// (set) Token: 0x060077FA RID: 30714 RVA: 0x00328E1C File Offset: 0x0032701C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption TitleOption
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

												// Token: 0x1700158E RID: 5518
												// (get) Token: 0x060077FB RID: 30715 RVA: 0x00328E2C File Offset: 0x0032702C
												// (set) Token: 0x060077FC RID: 30716 RVA: 0x00328E3C File Offset: 0x0032703C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption OrnamentOption
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

												// Token: 0x1700158F RID: 5519
												// (get) Token: 0x060077FD RID: 30717 RVA: 0x00328E4C File Offset: 0x0032704C
												// (set) Token: 0x060077FE RID: 30718 RVA: 0x00328E5C File Offset: 0x0032705C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption ObjectUseOption
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

												// Token: 0x17001590 RID: 5520
												// (get) Token: 0x060077FF RID: 30719 RVA: 0x00328E6C File Offset: 0x0032706C
												// (set) Token: 0x06007800 RID: 30720 RVA: 0x00328E7C File Offset: 0x0032707C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption SkillUseOption
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

												// Token: 0x17001591 RID: 5521
												// (get) Token: 0x06007801 RID: 30721 RVA: 0x00328E8C File Offset: 0x0032708C
												// (set) Token: 0x06007802 RID: 30722 RVA: 0x00328E9C File Offset: 0x0032709C
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public int SpeedMultiplier
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

												// Token: 0x17001592 RID: 5522
												// (get) Token: 0x06007803 RID: 30723 RVA: 0x00328EAC File Offset: 0x003270AC
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public bool HasSpeedMultiplier
												{
													[MethodImpl(MethodImplOptions.NoInlining)]
													get
													{
														return true;
													}
												}

												// Token: 0x06007804 RID: 30724 RVA: 0x00328EBC File Offset: 0x003270BC
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void ClearSpeedMultiplier()
												{
												}

												// Token: 0x17001593 RID: 5523
												// (get) Token: 0x06007805 RID: 30725 RVA: 0x00328ECC File Offset: 0x003270CC
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.OptionOneofCase OptionCase
												{
													[MethodImpl(MethodImplOptions.NoInlining)]
													get
													{
														return (ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.OptionOneofCase)null;
													}
												}

												// Token: 0x06007806 RID: 30726 RVA: 0x00328EE0 File Offset: 0x003270E0
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void ClearOption()
												{
												}

												// Token: 0x06007807 RID: 30727 RVA: 0x00328EF0 File Offset: 0x003270F0
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override bool Equals(object other)
												{
													return true;
												}

												// Token: 0x06007808 RID: 30728 RVA: 0x00328F00 File Offset: 0x00327100
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption other)
												{
													return true;
												}

												// Token: 0x06007809 RID: 30729 RVA: 0x00328F10 File Offset: 0x00327110
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override int GetHashCode()
												{
													return 0;
												}

												// Token: 0x0600780A RID: 30730 RVA: 0x00328F20 File Offset: 0x00327120
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override string ToString()
												{
													return null;
												}

												// Token: 0x0600780B RID: 30731 RVA: 0x00328F30 File Offset: 0x00327130
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void WriteTo(CodedOutputStream output)
												{
												}

												// Token: 0x0600780C RID: 30732 RVA: 0x00328F40 File Offset: 0x00327140
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												void IBufferMessage.InternalWriteTo(ref WriteContext output)
												{
												}

												// Token: 0x0600780D RID: 30733 RVA: 0x00328F50 File Offset: 0x00327150
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public int CalculateSize()
												{
													return 0;
												}

												// Token: 0x0600780E RID: 30734 RVA: 0x00328F60 File Offset: 0x00327160
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption other)
												{
												}

												// Token: 0x0600780F RID: 30735 RVA: 0x00328F70 File Offset: 0x00327170
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void MergeFrom(CodedInputStream input)
												{
												}

												// Token: 0x06007810 RID: 30736 RVA: 0x00328F80 File Offset: 0x00327180
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												void IBufferMessage.InternalMergeFrom(ref ParseContext input)
												{
												}

												// Token: 0x06007811 RID: 30737 RVA: 0x00328F90 File Offset: 0x00327190
												[MethodImpl(MethodImplOptions.NoInlining)]
												static HumanOption()
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
															if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
															{
																num2 = 0;
																continue;
															}
															continue;
														case 2:
															xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
															num2 = 1;
															if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
															{
																num2 = 1;
																continue;
															}
															continue;
														case 3:
															ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption>(() => null);
															num2 = 4;
															if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
															{
																num2 = 1;
																continue;
															}
															continue;
														case 4:
															return;
														}
														UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
														num2 = 3;
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
														{
															num2 = 3;
														}
													}
												}

												// Token: 0x06007812 RID: 30738 RVA: 0x00329088 File Offset: 0x00327288
												[MethodImpl(MethodImplOptions.NoInlining)]
												internal static bool CqNGeKgEP34rPijyQAma()
												{
													return true;
												}

												// Token: 0x06007813 RID: 30739 RVA: 0x00329090 File Offset: 0x00327290
												[MethodImpl(MethodImplOptions.NoInlining)]
												internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption yhymLHgES0KdmCDO2RKJ()
												{
													return null;
												}

												// Token: 0x04002AD6 RID: 10966
												private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption> _parser;

												// Token: 0x04002AD7 RID: 10967
												private UnknownFieldSet _unknownFields;

												// Token: 0x04002AD8 RID: 10968
												public const int FollowersFieldNumber = 3;

												// Token: 0x04002AD9 RID: 10969
												public const int GuildInformationFieldNumber = 4;

												// Token: 0x04002ADA RID: 10970
												public const int AllianceInformationFieldNumber = 5;

												// Token: 0x04002ADB RID: 10971
												public const int EmoteOptionFieldNumber = 6;

												// Token: 0x04002ADC RID: 10972
												public const int TitleOptionFieldNumber = 7;

												// Token: 0x04002ADD RID: 10973
												public const int OrnamentOptionFieldNumber = 8;

												// Token: 0x04002ADE RID: 10974
												public const int ObjectUseOptionFieldNumber = 9;

												// Token: 0x04002ADF RID: 10975
												public const int SkillUseOptionFieldNumber = 10;

												// Token: 0x04002AE0 RID: 10976
												public const int SpeedMultiplierFieldNumber = 11;

												// Token: 0x04002AE1 RID: 10977
												private object option_;

												// Token: 0x04002AE2 RID: 10978
												private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.OptionOneofCase optionCase_;

												// Token: 0x04002AE3 RID: 10979
												internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption ibCk5hgEi0UEJbG1Nlqm;

												// Token: 0x020009D3 RID: 2515
												public enum OptionOneofCase
												{
													// Token: 0x04002AE5 RID: 10981
													None,
													// Token: 0x04002AE6 RID: 10982
													Followers = 3,
													// Token: 0x04002AE7 RID: 10983
													GuildInformation,
													// Token: 0x04002AE8 RID: 10984
													AllianceInformation,
													// Token: 0x04002AE9 RID: 10985
													EmoteOption,
													// Token: 0x04002AEA RID: 10986
													TitleOption,
													// Token: 0x04002AEB RID: 10987
													OrnamentOption,
													// Token: 0x04002AEC RID: 10988
													ObjectUseOption,
													// Token: 0x04002AED RID: 10989
													SkillUseOption,
													// Token: 0x04002AEE RID: 10990
													SpeedMultiplier
												}

												// Token: 0x020009D4 RID: 2516
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public static class Types
												{
													// Token: 0x06007814 RID: 30740 RVA: 0x003292B4 File Offset: 0x003274B4
													[MethodImpl(MethodImplOptions.NoInlining)]
													static Types()
													{
														uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
														xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													}

													// Token: 0x020009D5 RID: 2517
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class FollowingCharactersOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption>, IBufferMessage
													{
														// Token: 0x17001594 RID: 5524
														// (get) Token: 0x06007815 RID: 30741 RVA: 0x00329490 File Offset: 0x00327690
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x17001595 RID: 5525
														// (get) Token: 0x06007816 RID: 30742 RVA: 0x003294A0 File Offset: 0x003276A0
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

														// Token: 0x17001596 RID: 5526
														// (get) Token: 0x06007817 RID: 30743 RVA: 0x003294B0 File Offset: 0x003276B0
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

														// Token: 0x06007818 RID: 30744 RVA: 0x003294C0 File Offset: 0x003276C0
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public FollowingCharactersOption()
														{
														}

														// Token: 0x06007819 RID: 30745 RVA: 0x003294D0 File Offset: 0x003276D0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public FollowingCharactersOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption other)
														{
														}

														// Token: 0x0600781A RID: 30746 RVA: 0x003294E0 File Offset: 0x003276E0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption Clone()
														{
															return null;
														}

														// Token: 0x17001597 RID: 5527
														// (get) Token: 0x0600781B RID: 30747 RVA: 0x003294F0 File Offset: 0x003276F0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public RepeatedField<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook> FollowingCharactersLooks
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x0600781C RID: 30748 RVA: 0x00329500 File Offset: 0x00327700
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x0600781D RID: 30749 RVA: 0x00329510 File Offset: 0x00327710
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption other)
														{
															return true;
														}

														// Token: 0x0600781E RID: 30750 RVA: 0x00329520 File Offset: 0x00327720
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x0600781F RID: 30751 RVA: 0x00329530 File Offset: 0x00327730
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x06007820 RID: 30752 RVA: 0x00329540 File Offset: 0x00327740
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x06007821 RID: 30753 RVA: 0x00329550 File Offset: 0x00327750
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x06007822 RID: 30754 RVA: 0x00329560 File Offset: 0x00327760
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x06007823 RID: 30755 RVA: 0x00329570 File Offset: 0x00327770
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption other)
														{
														}

														// Token: 0x06007824 RID: 30756 RVA: 0x00329580 File Offset: 0x00327780
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x06007825 RID: 30757 RVA: 0x00329590 File Offset: 0x00327790
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x06007826 RID: 30758 RVA: 0x003295A0 File Offset: 0x003277A0
														[MethodImpl(MethodImplOptions.NoInlining)]
														static FollowingCharactersOption()
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
																	num2 = 4;
																	continue;
																case 2:
																	AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																	num2 = 1;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
																	{
																		num2 = 1;
																		continue;
																	}
																	continue;
																case 3:
																	xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																	num2 = 2;
																	continue;
																case 4:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption>(() => null);
																	num2 = 5;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
																	{
																		num2 = 3;
																		continue;
																	}
																	continue;
																case 5:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption._repeated_followingCharactersLooks_codec = FieldCodec.ForMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook>(10U, F0HB5KBjEGMkjusoLmX0.XVInXhlssT(F0HB5KBjEGMkjusoLmX0.b3EBjXvjTfj));
																	num2 = 0;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
																	{
																		num2 = 0;
																		continue;
																	}
																	continue;
																}
																break;
															}
														}

														// Token: 0x06007827 RID: 30759 RVA: 0x003296A8 File Offset: 0x003278A8
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool OfghijgXsev3awa9O7Wv()
														{
															return true;
														}

														// Token: 0x06007828 RID: 30760 RVA: 0x003296B0 File Offset: 0x003278B0
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption oFh6WqgXdeN2jnN7RWcA()
														{
															return null;
														}

														// Token: 0x04002AEF RID: 10991
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption> _parser;

														// Token: 0x04002AF0 RID: 10992
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002AF1 RID: 10993
														public const int FollowingCharactersLooksFieldNumber = 1;

														// Token: 0x04002AF2 RID: 10994
														private static readonly FieldCodec<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook> _repeated_followingCharactersLooks_codec;

														// Token: 0x04002AF3 RID: 10995
														private readonly RepeatedField<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook> followingCharactersLooks_;

														// Token: 0x04002AF4 RID: 10996
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption GmUU2EgXgM4ARFJqM8X2;

														// Token: 0x020009D6 RID: 2518
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public static class Types
														{
															// Token: 0x06007829 RID: 30761 RVA: 0x0032A584 File Offset: 0x00328784
															[MethodImpl(MethodImplOptions.NoInlining)]
															static Types()
															{
																uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
																xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
															}

															// Token: 0x020009D7 RID: 2519
															[DebuggerDisplay("{ToString(),nq}")]
															public sealed class IndexedEntityLook : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook>, IBufferMessage
															{
																// Token: 0x17001598 RID: 5528
																// (get) Token: 0x0600782A RID: 30762 RVA: 0x0032AC64 File Offset: 0x00328E64
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook> Parser
																{
																	[MethodImpl(MethodImplOptions.NoInlining)]
																	get
																	{
																		return null;
																	}
																}

																// Token: 0x17001599 RID: 5529
																// (get) Token: 0x0600782B RID: 30763 RVA: 0x0032AC74 File Offset: 0x00328E74
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

																// Token: 0x1700159A RID: 5530
																// (get) Token: 0x0600782C RID: 30764 RVA: 0x0032AC84 File Offset: 0x00328E84
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

																// Token: 0x0600782D RID: 30765 RVA: 0x0032AC94 File Offset: 0x00328E94
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public IndexedEntityLook()
																{
																}

																// Token: 0x0600782E RID: 30766 RVA: 0x0032ACA4 File Offset: 0x00328EA4
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public IndexedEntityLook(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook other)
																{
																}

																// Token: 0x0600782F RID: 30767 RVA: 0x0032ACB4 File Offset: 0x00328EB4
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook Clone()
																{
																	return null;
																}

																// Token: 0x1700159B RID: 5531
																// (get) Token: 0x06007830 RID: 30768 RVA: 0x0032ACC4 File Offset: 0x00328EC4
																// (set) Token: 0x06007831 RID: 30769 RVA: 0x0032ACD4 File Offset: 0x00328ED4
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																public EntityLook Look
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

																// Token: 0x1700159C RID: 5532
																// (get) Token: 0x06007832 RID: 30770 RVA: 0x0032ACE4 File Offset: 0x00328EE4
																// (set) Token: 0x06007833 RID: 30771 RVA: 0x0032ACF4 File Offset: 0x00328EF4
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																public int Index
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

																// Token: 0x06007834 RID: 30772 RVA: 0x0032AD04 File Offset: 0x00328F04
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public override bool Equals(object other)
																{
																	return true;
																}

																// Token: 0x06007835 RID: 30773 RVA: 0x0032AD14 File Offset: 0x00328F14
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook other)
																{
																	return true;
																}

																// Token: 0x06007836 RID: 30774 RVA: 0x0032AD24 File Offset: 0x00328F24
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public override int GetHashCode()
																{
																	return 0;
																}

																// Token: 0x06007837 RID: 30775 RVA: 0x0032AD34 File Offset: 0x00328F34
																[GeneratedCode("protoc", null)]
																[DebuggerNonUserCode]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public override string ToString()
																{
																	return null;
																}

																// Token: 0x06007838 RID: 30776 RVA: 0x0032AD44 File Offset: 0x00328F44
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public void WriteTo(CodedOutputStream output)
																{
																}

																// Token: 0x06007839 RID: 30777 RVA: 0x0032AD54 File Offset: 0x00328F54
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																void IBufferMessage.InternalWriteTo(ref WriteContext output)
																{
																}

																// Token: 0x0600783A RID: 30778 RVA: 0x0032AD64 File Offset: 0x00328F64
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public int CalculateSize()
																{
																	return 0;
																}

																// Token: 0x0600783B RID: 30779 RVA: 0x0032AD74 File Offset: 0x00328F74
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook other)
																{
																}

																// Token: 0x0600783C RID: 30780 RVA: 0x0032AD84 File Offset: 0x00328F84
																[DebuggerNonUserCode]
																[GeneratedCode("protoc", null)]
																[MethodImpl(MethodImplOptions.NoInlining)]
																public void MergeFrom(CodedInputStream input)
																{
																}

																// Token: 0x0600783D RID: 30781 RVA: 0x0032AD94 File Offset: 0x00328F94
																[GeneratedCode("protoc", null)]
																[DebuggerNonUserCode]
																[MethodImpl(MethodImplOptions.NoInlining)]
																void IBufferMessage.InternalMergeFrom(ref ParseContext input)
																{
																}

																// Token: 0x0600783E RID: 30782 RVA: 0x0032ADA4 File Offset: 0x00328FA4
																[MethodImpl(MethodImplOptions.NoInlining)]
																static IndexedEntityLook()
																{
																	uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
																	int num = 3;
																	int num2 = num;
																	for (;;)
																	{
																		switch (num2)
																		{
																		case 1:
																			ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook>(() => null);
																			num2 = 0;
																			if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
																			{
																				num2 = 0;
																				continue;
																			}
																			continue;
																		case 2:
																			AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																			num2 = 4;
																			continue;
																		case 3:
																			xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																			num2 = 2;
																			continue;
																		case 4:
																			UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																			num2 = 1;
																			if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
																			{
																				num2 = 0;
																				continue;
																			}
																			continue;
																		}
																		break;
																	}
																}

																// Token: 0x0600783F RID: 30783 RVA: 0x0032AE70 File Offset: 0x00329070
																[MethodImpl(MethodImplOptions.NoInlining)]
																internal static bool Hx1cRegX8KCrhA8tvsMF()
																{
																	return true;
																}

																// Token: 0x06007840 RID: 30784 RVA: 0x0032AE78 File Offset: 0x00329078
																[MethodImpl(MethodImplOptions.NoInlining)]
																internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook gJAB1TgXZ0oZ2GJ1gyeQ()
																{
																	return null;
																}

																// Token: 0x04002AF5 RID: 10997
																private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook> _parser;

																// Token: 0x04002AF6 RID: 10998
																private UnknownFieldSet _unknownFields;

																// Token: 0x04002AF7 RID: 10999
																public const int LookFieldNumber = 1;

																// Token: 0x04002AF8 RID: 11000
																private EntityLook look_;

																// Token: 0x04002AF9 RID: 11001
																public const int IndexFieldNumber = 2;

																// Token: 0x04002AFA RID: 11002
																private int index_;

																// Token: 0x04002AFB RID: 11003
																internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.FollowingCharactersOption.Types.IndexedEntityLook OeNeXrgXuOVRSBoDrv9J;
															}
														}
													}

													// Token: 0x020009DA RID: 2522
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class AllianceOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption>, IBufferMessage
													{
														// Token: 0x1700159D RID: 5533
														// (get) Token: 0x0600784B RID: 30795 RVA: 0x003296B8 File Offset: 0x003278B8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x1700159E RID: 5534
														// (get) Token: 0x0600784C RID: 30796 RVA: 0x003296C8 File Offset: 0x003278C8
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

														// Token: 0x1700159F RID: 5535
														// (get) Token: 0x0600784D RID: 30797 RVA: 0x003296D8 File Offset: 0x003278D8
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

														// Token: 0x0600784E RID: 30798 RVA: 0x003296E8 File Offset: 0x003278E8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public AllianceOption()
														{
														}

														// Token: 0x0600784F RID: 30799 RVA: 0x003296F8 File Offset: 0x003278F8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public AllianceOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption other)
														{
														}

														// Token: 0x06007850 RID: 30800 RVA: 0x00329708 File Offset: 0x00327908
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption Clone()
														{
															return null;
														}

														// Token: 0x170015A0 RID: 5536
														// (get) Token: 0x06007851 RID: 30801 RVA: 0x00329718 File Offset: 0x00327918
														// (set) Token: 0x06007852 RID: 30802 RVA: 0x00329728 File Offset: 0x00327928
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public AllianceInformation AllianceInformation
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

														// Token: 0x170015A1 RID: 5537
														// (get) Token: 0x06007853 RID: 30803 RVA: 0x00329738 File Offset: 0x00327938
														// (set) Token: 0x06007854 RID: 30804 RVA: 0x0032974C File Offset: 0x0032794C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public AttackableStatus AttackableStatus
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return (AttackableStatus)null;
															}
															[MethodImpl(MethodImplOptions.NoInlining)]
															set
															{
															}
														}

														// Token: 0x06007855 RID: 30805 RVA: 0x0032975C File Offset: 0x0032795C
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x06007856 RID: 30806 RVA: 0x0032976C File Offset: 0x0032796C
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption other)
														{
															return true;
														}

														// Token: 0x06007857 RID: 30807 RVA: 0x0032977C File Offset: 0x0032797C
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x06007858 RID: 30808 RVA: 0x0032978C File Offset: 0x0032798C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x06007859 RID: 30809 RVA: 0x0032979C File Offset: 0x0032799C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x0600785A RID: 30810 RVA: 0x003297AC File Offset: 0x003279AC
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x0600785B RID: 30811 RVA: 0x003297BC File Offset: 0x003279BC
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x0600785C RID: 30812 RVA: 0x003297CC File Offset: 0x003279CC
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption other)
														{
														}

														// Token: 0x0600785D RID: 30813 RVA: 0x003297DC File Offset: 0x003279DC
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x0600785E RID: 30814 RVA: 0x003297EC File Offset: 0x003279EC
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x0600785F RID: 30815 RVA: 0x003297FC File Offset: 0x003279FC
														[MethodImpl(MethodImplOptions.NoInlining)]
														static AllianceOption()
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
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
																	{
																		num2 = 0;
																		continue;
																	}
																	continue;
																case 2:
																	xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																	num2 = 1;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
																	{
																		num2 = 1;
																		continue;
																	}
																	continue;
																case 3:
																	return;
																case 4:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption>(() => null);
																	num2 = 3;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
																	{
																		num2 = 2;
																		continue;
																	}
																	continue;
																}
																UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																num2 = 2;
																if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
																{
																	num2 = 4;
																}
															}
														}

														// Token: 0x06007860 RID: 30816 RVA: 0x003298F4 File Offset: 0x00327AF4
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool l1AQ5wgX26naWdQGwnuo()
														{
															return true;
														}

														// Token: 0x06007861 RID: 30817 RVA: 0x003298FC File Offset: 0x00327AFC
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption FYxKCAgXEgfAtH9iW7DI()
														{
															return null;
														}

														// Token: 0x04002B00 RID: 11008
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption> _parser;

														// Token: 0x04002B01 RID: 11009
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B02 RID: 11010
														public const int AllianceInformationFieldNumber = 1;

														// Token: 0x04002B03 RID: 11011
														private AllianceInformation allianceInformation_;

														// Token: 0x04002B04 RID: 11012
														public const int AttackableStatusFieldNumber = 2;

														// Token: 0x04002B05 RID: 11013
														private AttackableStatus attackableStatus_;

														// Token: 0x04002B06 RID: 11014
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.AllianceOption LUtyKJgX9SA1Fg8WJk2b;
													}

													// Token: 0x020009DC RID: 2524
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class EmoteOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption>, IBufferMessage
													{
														// Token: 0x170015A2 RID: 5538
														// (get) Token: 0x06007867 RID: 30823 RVA: 0x00329904 File Offset: 0x00327B04
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x170015A3 RID: 5539
														// (get) Token: 0x06007868 RID: 30824 RVA: 0x00329914 File Offset: 0x00327B14
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

														// Token: 0x170015A4 RID: 5540
														// (get) Token: 0x06007869 RID: 30825 RVA: 0x00329924 File Offset: 0x00327B24
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

														// Token: 0x0600786A RID: 30826 RVA: 0x00329934 File Offset: 0x00327B34
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public EmoteOption()
														{
														}

														// Token: 0x0600786B RID: 30827 RVA: 0x00329944 File Offset: 0x00327B44
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public EmoteOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption other)
														{
														}

														// Token: 0x0600786C RID: 30828 RVA: 0x00329954 File Offset: 0x00327B54
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption Clone()
														{
															return null;
														}

														// Token: 0x170015A5 RID: 5541
														// (get) Token: 0x0600786D RID: 30829 RVA: 0x00329964 File Offset: 0x00327B64
														// (set) Token: 0x0600786E RID: 30830 RVA: 0x00329974 File Offset: 0x00327B74
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public int EmoteId
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

														// Token: 0x170015A6 RID: 5542
														// (get) Token: 0x0600786F RID: 30831 RVA: 0x00329984 File Offset: 0x00327B84
														// (set) Token: 0x06007870 RID: 30832 RVA: 0x00329994 File Offset: 0x00327B94
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public string EmoteStartTime
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

														// Token: 0x06007871 RID: 30833 RVA: 0x003299A4 File Offset: 0x00327BA4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x06007872 RID: 30834 RVA: 0x003299B4 File Offset: 0x00327BB4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption other)
														{
															return true;
														}

														// Token: 0x06007873 RID: 30835 RVA: 0x003299C4 File Offset: 0x00327BC4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x06007874 RID: 30836 RVA: 0x003299D4 File Offset: 0x00327BD4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x06007875 RID: 30837 RVA: 0x003299E4 File Offset: 0x00327BE4
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x06007876 RID: 30838 RVA: 0x003299F4 File Offset: 0x00327BF4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x06007877 RID: 30839 RVA: 0x00329A04 File Offset: 0x00327C04
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x06007878 RID: 30840 RVA: 0x00329A14 File Offset: 0x00327C14
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption other)
														{
														}

														// Token: 0x06007879 RID: 30841 RVA: 0x00329A24 File Offset: 0x00327C24
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x0600787A RID: 30842 RVA: 0x00329A34 File Offset: 0x00327C34
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x0600787B RID: 30843 RVA: 0x00329A44 File Offset: 0x00327C44
														[MethodImpl(MethodImplOptions.NoInlining)]
														static EmoteOption()
														{
															uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
															int num = 2;
															int num2 = num;
															for (;;)
															{
																switch (num2)
																{
																default:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption>(() => null);
																	num2 = 3;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
																	{
																		num2 = 4;
																	}
																	break;
																case 1:
																	AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																	num2 = 3;
																	break;
																case 2:
																	xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																	num2 = 1;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
																	{
																		num2 = 0;
																	}
																	break;
																case 3:
																	UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																	num2 = 0;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
																	{
																		num2 = 0;
																	}
																	break;
																case 4:
																	return;
																}
															}
														}

														// Token: 0x0600787C RID: 30844 RVA: 0x00329B28 File Offset: 0x00327D28
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool ptthM7gXNa031ayFB1Fm()
														{
															return true;
														}

														// Token: 0x0600787D RID: 30845 RVA: 0x00329B30 File Offset: 0x00327D30
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption tieLvngXx0PcWDPa9QMG()
														{
															return null;
														}

														// Token: 0x04002B09 RID: 11017
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption> _parser;

														// Token: 0x04002B0A RID: 11018
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B0B RID: 11019
														public const int EmoteIdFieldNumber = 1;

														// Token: 0x04002B0C RID: 11020
														private int emoteId_;

														// Token: 0x04002B0D RID: 11021
														public const int EmoteStartTimeFieldNumber = 2;

														// Token: 0x04002B0E RID: 11022
														private string emoteStartTime_;

														// Token: 0x04002B0F RID: 11023
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.EmoteOption tpowYvgXXIU64SfeeUIC;
													}

													// Token: 0x020009DE RID: 2526
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class TitleOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption>, IBufferMessage
													{
														// Token: 0x170015A7 RID: 5543
														// (get) Token: 0x06007883 RID: 30851 RVA: 0x00329B38 File Offset: 0x00327D38
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x170015A8 RID: 5544
														// (get) Token: 0x06007884 RID: 30852 RVA: 0x00329B48 File Offset: 0x00327D48
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

														// Token: 0x170015A9 RID: 5545
														// (get) Token: 0x06007885 RID: 30853 RVA: 0x00329B58 File Offset: 0x00327D58
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

														// Token: 0x06007886 RID: 30854 RVA: 0x00329B68 File Offset: 0x00327D68
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public TitleOption()
														{
														}

														// Token: 0x06007887 RID: 30855 RVA: 0x00329B78 File Offset: 0x00327D78
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public TitleOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption other)
														{
														}

														// Token: 0x06007888 RID: 30856 RVA: 0x00329B88 File Offset: 0x00327D88
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption Clone()
														{
															return null;
														}

														// Token: 0x170015AA RID: 5546
														// (get) Token: 0x06007889 RID: 30857 RVA: 0x00329B98 File Offset: 0x00327D98
														// (set) Token: 0x0600788A RID: 30858 RVA: 0x00329BA8 File Offset: 0x00327DA8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public int TitleId
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

														// Token: 0x170015AB RID: 5547
														// (get) Token: 0x0600788B RID: 30859 RVA: 0x00329BB8 File Offset: 0x00327DB8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public bool HasTitleId
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return true;
															}
														}

														// Token: 0x0600788C RID: 30860 RVA: 0x00329BC8 File Offset: 0x00327DC8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void ClearTitleId()
														{
														}

														// Token: 0x170015AC RID: 5548
														// (get) Token: 0x0600788D RID: 30861 RVA: 0x00329BD8 File Offset: 0x00327DD8
														// (set) Token: 0x0600788E RID: 30862 RVA: 0x00329BE8 File Offset: 0x00327DE8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public string TitleParameter
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

														// Token: 0x170015AD RID: 5549
														// (get) Token: 0x0600788F RID: 30863 RVA: 0x00329BF8 File Offset: 0x00327DF8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public bool HasTitleParameter
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return true;
															}
														}

														// Token: 0x06007890 RID: 30864 RVA: 0x00329C08 File Offset: 0x00327E08
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void ClearTitleParameter()
														{
														}

														// Token: 0x06007891 RID: 30865 RVA: 0x00329C18 File Offset: 0x00327E18
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x06007892 RID: 30866 RVA: 0x00329C28 File Offset: 0x00327E28
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption other)
														{
															return true;
														}

														// Token: 0x06007893 RID: 30867 RVA: 0x00329C38 File Offset: 0x00327E38
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x06007894 RID: 30868 RVA: 0x00329C48 File Offset: 0x00327E48
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x06007895 RID: 30869 RVA: 0x00329C58 File Offset: 0x00327E58
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x06007896 RID: 30870 RVA: 0x00329C68 File Offset: 0x00327E68
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x06007897 RID: 30871 RVA: 0x00329C78 File Offset: 0x00327E78
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x06007898 RID: 30872 RVA: 0x00329C88 File Offset: 0x00327E88
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption other)
														{
														}

														// Token: 0x06007899 RID: 30873 RVA: 0x00329C98 File Offset: 0x00327E98
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x0600789A RID: 30874 RVA: 0x00329CA8 File Offset: 0x00327EA8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x0600789B RID: 30875 RVA: 0x00329CB8 File Offset: 0x00327EB8
														[MethodImpl(MethodImplOptions.NoInlining)]
														static TitleOption()
														{
															uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
															int num = 6;
															int num2 = num;
															for (;;)
															{
																switch (num2)
																{
																default:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption>(() => null);
																	num2 = 2;
																	break;
																case 1:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption.TitleParameterDefaultValue = "";
																	num2 = 3;
																	break;
																case 2:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption.TitleIdDefaultValue = 0;
																	num2 = 1;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
																	{
																		num2 = 0;
																	}
																	break;
																case 3:
																	return;
																case 4:
																	UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																	num2 = 0;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
																	{
																		num2 = 0;
																	}
																	break;
																case 5:
																	AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																	num2 = 4;
																	break;
																case 6:
																	xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																	num2 = 5;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
																	{
																		num2 = 5;
																	}
																	break;
																}
															}
														}

														// Token: 0x0600789C RID: 30876 RVA: 0x00329DC8 File Offset: 0x00327FC8
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool CVXY0QgXj07AU3YWeV1f()
														{
															return true;
														}

														// Token: 0x0600789D RID: 30877 RVA: 0x00329DD0 File Offset: 0x00327FD0
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption SkS6CfgXKdTSyhGSqDMi()
														{
															return null;
														}

														// Token: 0x04002B12 RID: 11026
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption> _parser;

														// Token: 0x04002B13 RID: 11027
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B14 RID: 11028
														private int _hasBits0;

														// Token: 0x04002B15 RID: 11029
														public const int TitleIdFieldNumber = 1;

														// Token: 0x04002B16 RID: 11030
														private static readonly int TitleIdDefaultValue;

														// Token: 0x04002B17 RID: 11031
														private int titleId_;

														// Token: 0x04002B18 RID: 11032
														public const int TitleParameterFieldNumber = 2;

														// Token: 0x04002B19 RID: 11033
														private static readonly string TitleParameterDefaultValue;

														// Token: 0x04002B1A RID: 11034
														private string titleParameter_;

														// Token: 0x04002B1B RID: 11035
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.TitleOption Tssh2IgX4su7ifBsqIWl;
													}

													// Token: 0x020009E0 RID: 2528
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class OrnamentOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption>, IBufferMessage
													{
														// Token: 0x170015AE RID: 5550
														// (get) Token: 0x060078A3 RID: 30883 RVA: 0x00329DD8 File Offset: 0x00327FD8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x170015AF RID: 5551
														// (get) Token: 0x060078A4 RID: 30884 RVA: 0x00329DE8 File Offset: 0x00327FE8
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

														// Token: 0x170015B0 RID: 5552
														// (get) Token: 0x060078A5 RID: 30885 RVA: 0x00329DF8 File Offset: 0x00327FF8
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

														// Token: 0x060078A6 RID: 30886 RVA: 0x00329E08 File Offset: 0x00328008
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public OrnamentOption()
														{
														}

														// Token: 0x060078A7 RID: 30887 RVA: 0x00329E18 File Offset: 0x00328018
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public OrnamentOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption other)
														{
														}

														// Token: 0x060078A8 RID: 30888 RVA: 0x00329E28 File Offset: 0x00328028
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption Clone()
														{
															return null;
														}

														// Token: 0x170015B1 RID: 5553
														// (get) Token: 0x060078A9 RID: 30889 RVA: 0x00329E38 File Offset: 0x00328038
														// (set) Token: 0x060078AA RID: 30890 RVA: 0x00329E48 File Offset: 0x00328048
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public int PlayerLevel
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

														// Token: 0x170015B2 RID: 5554
														// (get) Token: 0x060078AB RID: 30891 RVA: 0x00329E58 File Offset: 0x00328058
														// (set) Token: 0x060078AC RID: 30892 RVA: 0x00329E68 File Offset: 0x00328068
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public int OrnamentId
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

														// Token: 0x170015B3 RID: 5555
														// (get) Token: 0x060078AD RID: 30893 RVA: 0x00329E78 File Offset: 0x00328078
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public bool HasOrnamentId
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return true;
															}
														}

														// Token: 0x060078AE RID: 30894 RVA: 0x00329E88 File Offset: 0x00328088
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void ClearOrnamentId()
														{
														}

														// Token: 0x170015B4 RID: 5556
														// (get) Token: 0x060078AF RID: 30895 RVA: 0x00329E98 File Offset: 0x00328098
														// (set) Token: 0x060078B0 RID: 30896 RVA: 0x00329EA8 File Offset: 0x003280A8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public int LeagueId
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

														// Token: 0x170015B5 RID: 5557
														// (get) Token: 0x060078B1 RID: 30897 RVA: 0x00329EB8 File Offset: 0x003280B8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public bool HasLeagueId
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return true;
															}
														}

														// Token: 0x060078B2 RID: 30898 RVA: 0x00329EC8 File Offset: 0x003280C8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void ClearLeagueId()
														{
														}

														// Token: 0x170015B6 RID: 5558
														// (get) Token: 0x060078B3 RID: 30899 RVA: 0x00329ED8 File Offset: 0x003280D8
														// (set) Token: 0x060078B4 RID: 30900 RVA: 0x00329EE8 File Offset: 0x003280E8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public int LadderPosition
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

														// Token: 0x170015B7 RID: 5559
														// (get) Token: 0x060078B5 RID: 30901 RVA: 0x00329EF8 File Offset: 0x003280F8
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public bool HasLadderPosition
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return true;
															}
														}

														// Token: 0x060078B6 RID: 30902 RVA: 0x00329F08 File Offset: 0x00328108
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void ClearLadderPosition()
														{
														}

														// Token: 0x060078B7 RID: 30903 RVA: 0x00329F18 File Offset: 0x00328118
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x060078B8 RID: 30904 RVA: 0x00329F28 File Offset: 0x00328128
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption other)
														{
															return true;
														}

														// Token: 0x060078B9 RID: 30905 RVA: 0x00329F38 File Offset: 0x00328138
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x060078BA RID: 30906 RVA: 0x00329F48 File Offset: 0x00328148
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x060078BB RID: 30907 RVA: 0x00329F58 File Offset: 0x00328158
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x060078BC RID: 30908 RVA: 0x00329F68 File Offset: 0x00328168
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x060078BD RID: 30909 RVA: 0x00329F78 File Offset: 0x00328178
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x060078BE RID: 30910 RVA: 0x00329F88 File Offset: 0x00328188
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption other)
														{
														}

														// Token: 0x060078BF RID: 30911 RVA: 0x00329F98 File Offset: 0x00328198
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x060078C0 RID: 30912 RVA: 0x00329FA8 File Offset: 0x003281A8
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x060078C1 RID: 30913 RVA: 0x00329FB8 File Offset: 0x003281B8
														[MethodImpl(MethodImplOptions.NoInlining)]
														static OrnamentOption()
														{
															uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
															int num = 7;
															for (;;)
															{
																int num2 = num;
																for (;;)
																{
																	switch (num2)
																	{
																	case 1:
																		ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption.OrnamentIdDefaultValue = 0;
																		num2 = 4;
																		continue;
																	case 2:
																		ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption.LadderPositionDefaultValue = 0;
																		num2 = 3;
																		continue;
																	case 3:
																		return;
																	case 4:
																		goto IL_101;
																	case 5:
																		UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																		num2 = 0;
																		if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
																		{
																			num2 = 0;
																			continue;
																		}
																		continue;
																	case 6:
																		AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																		num2 = 5;
																		continue;
																	case 7:
																		xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																		num2 = 2;
																		if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
																		{
																			num2 = 6;
																			continue;
																		}
																		continue;
																	}
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption>(() => null);
																	num2 = 1;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
																	{
																		num2 = 0;
																	}
																}
																IL_101:
																ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption.LeagueIdDefaultValue = 0;
																num = 2;
															}
														}

														// Token: 0x060078C2 RID: 30914 RVA: 0x0032A0DC File Offset: 0x003282DC
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool eR7HpMgXksROpej4JOYn()
														{
															return true;
														}

														// Token: 0x060078C3 RID: 30915 RVA: 0x0032A0E4 File Offset: 0x003282E4
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption med0gygXlRExu4nRgohS()
														{
															return null;
														}

														// Token: 0x04002B1E RID: 11038
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption> _parser;

														// Token: 0x04002B1F RID: 11039
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B20 RID: 11040
														private int _hasBits0;

														// Token: 0x04002B21 RID: 11041
														public const int PlayerLevelFieldNumber = 2;

														// Token: 0x04002B22 RID: 11042
														private int playerLevel_;

														// Token: 0x04002B23 RID: 11043
														public const int OrnamentIdFieldNumber = 1;

														// Token: 0x04002B24 RID: 11044
														private static readonly int OrnamentIdDefaultValue;

														// Token: 0x04002B25 RID: 11045
														private int ornamentId_;

														// Token: 0x04002B26 RID: 11046
														public const int LeagueIdFieldNumber = 3;

														// Token: 0x04002B27 RID: 11047
														private static readonly int LeagueIdDefaultValue;

														// Token: 0x04002B28 RID: 11048
														private int leagueId_;

														// Token: 0x04002B29 RID: 11049
														public const int LadderPositionFieldNumber = 4;

														// Token: 0x04002B2A RID: 11050
														private static readonly int LadderPositionDefaultValue;

														// Token: 0x04002B2B RID: 11051
														private int ladderPosition_;

														// Token: 0x04002B2C RID: 11052
														private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.OrnamentOption Rjmk0ygXIBwvNqiTFj7h;
													}

													// Token: 0x020009E2 RID: 2530
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class ObjectUseOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption>, IBufferMessage
													{
														// Token: 0x170015B8 RID: 5560
														// (get) Token: 0x060078C9 RID: 30921 RVA: 0x0032A0EC File Offset: 0x003282EC
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x170015B9 RID: 5561
														// (get) Token: 0x060078CA RID: 30922 RVA: 0x0032A0FC File Offset: 0x003282FC
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

														// Token: 0x170015BA RID: 5562
														// (get) Token: 0x060078CB RID: 30923 RVA: 0x0032A10C File Offset: 0x0032830C
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

														// Token: 0x060078CC RID: 30924 RVA: 0x0032A11C File Offset: 0x0032831C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ObjectUseOption()
														{
														}

														// Token: 0x060078CD RID: 30925 RVA: 0x0032A12C File Offset: 0x0032832C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ObjectUseOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption other)
														{
														}

														// Token: 0x060078CE RID: 30926 RVA: 0x0032A13C File Offset: 0x0032833C
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption Clone()
														{
															return null;
														}

														// Token: 0x170015BB RID: 5563
														// (get) Token: 0x060078CF RID: 30927 RVA: 0x0032A14C File Offset: 0x0032834C
														// (set) Token: 0x060078D0 RID: 30928 RVA: 0x0032A160 File Offset: 0x00328360
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public DelayedActionType DelayedActionType
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return (DelayedActionType)null;
															}
															[MethodImpl(MethodImplOptions.NoInlining)]
															set
															{
															}
														}

														// Token: 0x170015BC RID: 5564
														// (get) Token: 0x060078D1 RID: 30929 RVA: 0x0032A170 File Offset: 0x00328370
														// (set) Token: 0x060078D2 RID: 30930 RVA: 0x0032A180 File Offset: 0x00328380
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public string EndDelay
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

														// Token: 0x170015BD RID: 5565
														// (get) Token: 0x060078D3 RID: 30931 RVA: 0x0032A190 File Offset: 0x00328390
														// (set) Token: 0x060078D4 RID: 30932 RVA: 0x0032A1A0 File Offset: 0x003283A0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public int ObjectGid
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

														// Token: 0x060078D5 RID: 30933 RVA: 0x0032A1B0 File Offset: 0x003283B0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x060078D6 RID: 30934 RVA: 0x0032A1C0 File Offset: 0x003283C0
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption other)
														{
															return true;
														}

														// Token: 0x060078D7 RID: 30935 RVA: 0x0032A1D0 File Offset: 0x003283D0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x060078D8 RID: 30936 RVA: 0x0032A1E0 File Offset: 0x003283E0
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x060078D9 RID: 30937 RVA: 0x0032A1F0 File Offset: 0x003283F0
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x060078DA RID: 30938 RVA: 0x0032A200 File Offset: 0x00328400
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x060078DB RID: 30939 RVA: 0x0032A210 File Offset: 0x00328410
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x060078DC RID: 30940 RVA: 0x0032A220 File Offset: 0x00328420
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption other)
														{
														}

														// Token: 0x060078DD RID: 30941 RVA: 0x0032A230 File Offset: 0x00328430
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x060078DE RID: 30942 RVA: 0x0032A240 File Offset: 0x00328440
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x060078DF RID: 30943 RVA: 0x0032A250 File Offset: 0x00328450
														[MethodImpl(MethodImplOptions.NoInlining)]
														static ObjectUseOption()
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
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
																	{
																		num2 = 0;
																		continue;
																	}
																	continue;
																case 2:
																	ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption>(() => null);
																	num2 = 3;
																	continue;
																case 3:
																	return;
																case 4:
																	UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																	num2 = 2;
																	if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
																	{
																		num2 = 1;
																		continue;
																	}
																	continue;
																}
																AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
																num2 = 4;
																if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
																{
																	num2 = 3;
																}
															}
														}

														// Token: 0x060078E0 RID: 30944 RVA: 0x0032A334 File Offset: 0x00328534
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool k6YuavgXU3nKCu8YdemI()
														{
															return true;
														}

														// Token: 0x060078E1 RID: 30945 RVA: 0x0032A33C File Offset: 0x0032853C
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption EKSOOjgXvNqvNbtMMAyL()
														{
															return null;
														}

														// Token: 0x04002B2F RID: 11055
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption> _parser;

														// Token: 0x04002B30 RID: 11056
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B31 RID: 11057
														public const int DelayedActionTypeFieldNumber = 1;

														// Token: 0x04002B32 RID: 11058
														private DelayedActionType delayedActionType_;

														// Token: 0x04002B33 RID: 11059
														public const int EndDelayFieldNumber = 2;

														// Token: 0x04002B34 RID: 11060
														private string endDelay_;

														// Token: 0x04002B35 RID: 11061
														public const int ObjectGidFieldNumber = 3;

														// Token: 0x04002B36 RID: 11062
														private int objectGid_;

														// Token: 0x04002B37 RID: 11063
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.ObjectUseOption l1JImGgXc751WWJP2Q7D;
													}

													// Token: 0x020009E4 RID: 2532
													[DebuggerDisplay("{ToString(),nq}")]
													public sealed class SkillUseOption : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption>, IBufferMessage
													{
														// Token: 0x170015BE RID: 5566
														// (get) Token: 0x060078E7 RID: 30951 RVA: 0x0032A344 File Offset: 0x00328544
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption> Parser
														{
															[MethodImpl(MethodImplOptions.NoInlining)]
															get
															{
																return null;
															}
														}

														// Token: 0x170015BF RID: 5567
														// (get) Token: 0x060078E8 RID: 30952 RVA: 0x0032A354 File Offset: 0x00328554
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

														// Token: 0x170015C0 RID: 5568
														// (get) Token: 0x060078E9 RID: 30953 RVA: 0x0032A364 File Offset: 0x00328564
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

														// Token: 0x060078EA RID: 30954 RVA: 0x0032A374 File Offset: 0x00328574
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public SkillUseOption()
														{
														}

														// Token: 0x060078EB RID: 30955 RVA: 0x0032A384 File Offset: 0x00328584
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public SkillUseOption(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption other)
														{
														}

														// Token: 0x060078EC RID: 30956 RVA: 0x0032A394 File Offset: 0x00328594
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption Clone()
														{
															return null;
														}

														// Token: 0x170015C1 RID: 5569
														// (get) Token: 0x060078ED RID: 30957 RVA: 0x0032A3A4 File Offset: 0x003285A4
														// (set) Token: 0x060078EE RID: 30958 RVA: 0x0032A3B4 File Offset: 0x003285B4
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														public int ElementId
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

														// Token: 0x170015C2 RID: 5570
														// (get) Token: 0x060078EF RID: 30959 RVA: 0x0032A3C4 File Offset: 0x003285C4
														// (set) Token: 0x060078F0 RID: 30960 RVA: 0x0032A3D4 File Offset: 0x003285D4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public int SkillId
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

														// Token: 0x170015C3 RID: 5571
														// (get) Token: 0x060078F1 RID: 30961 RVA: 0x0032A3E4 File Offset: 0x003285E4
														// (set) Token: 0x060078F2 RID: 30962 RVA: 0x0032A3F4 File Offset: 0x003285F4
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														public string SkillEndTime
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

														// Token: 0x060078F3 RID: 30963 RVA: 0x0032A404 File Offset: 0x00328604
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override bool Equals(object other)
														{
															return true;
														}

														// Token: 0x060078F4 RID: 30964 RVA: 0x0032A414 File Offset: 0x00328614
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption other)
														{
															return true;
														}

														// Token: 0x060078F5 RID: 30965 RVA: 0x0032A424 File Offset: 0x00328624
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override int GetHashCode()
														{
															return 0;
														}

														// Token: 0x060078F6 RID: 30966 RVA: 0x0032A434 File Offset: 0x00328634
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public override string ToString()
														{
															return null;
														}

														// Token: 0x060078F7 RID: 30967 RVA: 0x0032A444 File Offset: 0x00328644
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void WriteTo(CodedOutputStream output)
														{
														}

														// Token: 0x060078F8 RID: 30968 RVA: 0x0032A454 File Offset: 0x00328654
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalWriteTo(ref WriteContext output)
														{
														}

														// Token: 0x060078F9 RID: 30969 RVA: 0x0032A464 File Offset: 0x00328664
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public int CalculateSize()
														{
															return 0;
														}

														// Token: 0x060078FA RID: 30970 RVA: 0x0032A474 File Offset: 0x00328674
														[GeneratedCode("protoc", null)]
														[DebuggerNonUserCode]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption other)
														{
														}

														// Token: 0x060078FB RID: 30971 RVA: 0x0032A484 File Offset: 0x00328684
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														public void MergeFrom(CodedInputStream input)
														{
														}

														// Token: 0x060078FC RID: 30972 RVA: 0x0032A494 File Offset: 0x00328694
														[DebuggerNonUserCode]
														[GeneratedCode("protoc", null)]
														[MethodImpl(MethodImplOptions.NoInlining)]
														void IBufferMessage.InternalMergeFrom(ref ParseContext input)
														{
														}

														// Token: 0x060078FD RID: 30973 RVA: 0x0032A4A4 File Offset: 0x003286A4
														[MethodImpl(MethodImplOptions.NoInlining)]
														static SkillUseOption()
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
																		num2 = 3;
																		continue;
																	case 2:
																		xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
																		num2 = 0;
																		if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
																		{
																			num2 = 1;
																			continue;
																		}
																		continue;
																	case 3:
																		goto IL_98;
																	case 4:
																		ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption>(() => null);
																		num2 = 0;
																		if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
																		{
																			num2 = 0;
																			continue;
																		}
																		continue;
																	}
																	return;
																}
																IL_98:
																UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
																num = 4;
															}
														}

														// Token: 0x060078FE RID: 30974 RVA: 0x0032A574 File Offset: 0x00328774
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static bool sf8E5UgX1eGbaZFMBaNt()
														{
															return true;
														}

														// Token: 0x060078FF RID: 30975 RVA: 0x0032A57C File Offset: 0x0032877C
														[MethodImpl(MethodImplOptions.NoInlining)]
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption HrhIwagXaBdT5gnmVUFv()
														{
															return null;
														}

														// Token: 0x04002B3A RID: 11066
														private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption> _parser;

														// Token: 0x04002B3B RID: 11067
														private UnknownFieldSet _unknownFields;

														// Token: 0x04002B3C RID: 11068
														public const int ElementIdFieldNumber = 1;

														// Token: 0x04002B3D RID: 11069
														private int elementId_;

														// Token: 0x04002B3E RID: 11070
														public const int SkillIdFieldNumber = 2;

														// Token: 0x04002B3F RID: 11071
														private int skillId_;

														// Token: 0x04002B40 RID: 11072
														public const int SkillEndTimeFieldNumber = 3;

														// Token: 0x04002B41 RID: 11073
														private string skillEndTime_;

														// Token: 0x04002B42 RID: 11074
														internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.HumanOption.Types.SkillUseOption PNMGktgXononYajYpY5w;
													}
												}
											}

											// Token: 0x020009E7 RID: 2535
											[DebuggerDisplay("{ToString(),nq}")]
											public sealed class MutantInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation>, IBufferMessage
											{
												// Token: 0x170015C4 RID: 5572
												// (get) Token: 0x0600790A RID: 30986 RVA: 0x00329098 File Offset: 0x00327298
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation> Parser
												{
													[MethodImpl(MethodImplOptions.NoInlining)]
													get
													{
														return null;
													}
												}

												// Token: 0x170015C5 RID: 5573
												// (get) Token: 0x0600790B RID: 30987 RVA: 0x003290A8 File Offset: 0x003272A8
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

												// Token: 0x170015C6 RID: 5574
												// (get) Token: 0x0600790C RID: 30988 RVA: 0x003290B8 File Offset: 0x003272B8
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

												// Token: 0x0600790D RID: 30989 RVA: 0x003290C8 File Offset: 0x003272C8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public MutantInformation()
												{
												}

												// Token: 0x0600790E RID: 30990 RVA: 0x003290D8 File Offset: 0x003272D8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public MutantInformation(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation other)
												{
												}

												// Token: 0x0600790F RID: 30991 RVA: 0x003290E8 File Offset: 0x003272E8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation Clone()
												{
													return null;
												}

												// Token: 0x170015C7 RID: 5575
												// (get) Token: 0x06007910 RID: 30992 RVA: 0x003290F8 File Offset: 0x003272F8
												// (set) Token: 0x06007911 RID: 30993 RVA: 0x00329108 File Offset: 0x00327308
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												public int MonsterId
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

												// Token: 0x170015C8 RID: 5576
												// (get) Token: 0x06007912 RID: 30994 RVA: 0x00329118 File Offset: 0x00327318
												// (set) Token: 0x06007913 RID: 30995 RVA: 0x00329128 File Offset: 0x00327328
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												public int PowerLevel
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

												// Token: 0x06007914 RID: 30996 RVA: 0x00329138 File Offset: 0x00327338
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override bool Equals(object other)
												{
													return true;
												}

												// Token: 0x06007915 RID: 30997 RVA: 0x00329148 File Offset: 0x00327348
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation other)
												{
													return true;
												}

												// Token: 0x06007916 RID: 30998 RVA: 0x00329158 File Offset: 0x00327358
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override int GetHashCode()
												{
													return 0;
												}

												// Token: 0x06007917 RID: 30999 RVA: 0x00329168 File Offset: 0x00327368
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public override string ToString()
												{
													return null;
												}

												// Token: 0x06007918 RID: 31000 RVA: 0x00329178 File Offset: 0x00327378
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void WriteTo(CodedOutputStream output)
												{
												}

												// Token: 0x06007919 RID: 31001 RVA: 0x00329188 File Offset: 0x00327388
												[DebuggerNonUserCode]
												[GeneratedCode("protoc", null)]
												[MethodImpl(MethodImplOptions.NoInlining)]
												void IBufferMessage.InternalWriteTo(ref WriteContext output)
												{
												}

												// Token: 0x0600791A RID: 31002 RVA: 0x00329198 File Offset: 0x00327398
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public int CalculateSize()
												{
													return 0;
												}

												// Token: 0x0600791B RID: 31003 RVA: 0x003291A8 File Offset: 0x003273A8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation other)
												{
												}

												// Token: 0x0600791C RID: 31004 RVA: 0x003291B8 File Offset: 0x003273B8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												public void MergeFrom(CodedInputStream input)
												{
												}

												// Token: 0x0600791D RID: 31005 RVA: 0x003291C8 File Offset: 0x003273C8
												[GeneratedCode("protoc", null)]
												[DebuggerNonUserCode]
												[MethodImpl(MethodImplOptions.NoInlining)]
												void IBufferMessage.InternalMergeFrom(ref ParseContext input)
												{
												}

												// Token: 0x0600791E RID: 31006 RVA: 0x003291D8 File Offset: 0x003273D8
												[MethodImpl(MethodImplOptions.NoInlining)]
												static MutantInformation()
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
															if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
															{
																num2 = 0;
																continue;
															}
															continue;
														case 2:
															xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
															num2 = 1;
															if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
															{
																num2 = 1;
																continue;
															}
															continue;
														case 3:
															ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation>(() => null);
															num2 = 4;
															continue;
														case 4:
															return;
														}
														UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
														num2 = 3;
													}
												}

												// Token: 0x0600791F RID: 31007 RVA: 0x003292A4 File Offset: 0x003274A4
												[MethodImpl(MethodImplOptions.NoInlining)]
												internal static bool Ocxq0QgEu1ZIwGLMIeKx()
												{
													return true;
												}

												// Token: 0x06007920 RID: 31008 RVA: 0x003292AC File Offset: 0x003274AC
												[MethodImpl(MethodImplOptions.NoInlining)]
												internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation WZQnBdgE8tbdb6N5TbcK()
												{
													return null;
												}

												// Token: 0x04002B47 RID: 11079
												private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation> _parser;

												// Token: 0x04002B48 RID: 11080
												private UnknownFieldSet _unknownFields;

												// Token: 0x04002B49 RID: 11081
												public const int MonsterIdFieldNumber = 1;

												// Token: 0x04002B4A RID: 11082
												private int monsterId_;

												// Token: 0x04002B4B RID: 11083
												public const int PowerLevelFieldNumber = 2;

												// Token: 0x04002B4C RID: 11084
												private int powerLevel_;

												// Token: 0x04002B4D RID: 11085
												internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Humanoid.Types.MutantInformation QkKwcWgEMiqxmxQbUeHy;
											}
										}
									}

									// Token: 0x020009EA RID: 2538
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class Mount : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount>, IBufferMessage
									{
										// Token: 0x170015C9 RID: 5577
										// (get) Token: 0x0600792D RID: 31021 RVA: 0x00325FA8 File Offset: 0x003241A8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170015CA RID: 5578
										// (get) Token: 0x0600792E RID: 31022 RVA: 0x00325FB8 File Offset: 0x003241B8
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

										// Token: 0x170015CB RID: 5579
										// (get) Token: 0x0600792F RID: 31023 RVA: 0x00325FC8 File Offset: 0x003241C8
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

										// Token: 0x06007930 RID: 31024 RVA: 0x00325FD8 File Offset: 0x003241D8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Mount()
										{
										}

										// Token: 0x06007931 RID: 31025 RVA: 0x00325FE8 File Offset: 0x003241E8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Mount(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount other)
										{
										}

										// Token: 0x06007932 RID: 31026 RVA: 0x00325FF8 File Offset: 0x003241F8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount Clone()
										{
											return null;
										}

										// Token: 0x170015CC RID: 5580
										// (get) Token: 0x06007933 RID: 31027 RVA: 0x00326008 File Offset: 0x00324208
										// (set) Token: 0x06007934 RID: 31028 RVA: 0x00326018 File Offset: 0x00324218
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public string OwnerName
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

										// Token: 0x170015CD RID: 5581
										// (get) Token: 0x06007935 RID: 31029 RVA: 0x00326028 File Offset: 0x00324228
										// (set) Token: 0x06007936 RID: 31030 RVA: 0x00326038 File Offset: 0x00324238
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int Level
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

										// Token: 0x06007937 RID: 31031 RVA: 0x00326048 File Offset: 0x00324248
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007938 RID: 31032 RVA: 0x00326058 File Offset: 0x00324258
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount other)
										{
											return true;
										}

										// Token: 0x06007939 RID: 31033 RVA: 0x00326068 File Offset: 0x00324268
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x0600793A RID: 31034 RVA: 0x00326078 File Offset: 0x00324278
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x0600793B RID: 31035 RVA: 0x00326088 File Offset: 0x00324288
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x0600793C RID: 31036 RVA: 0x00326098 File Offset: 0x00324298
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x0600793D RID: 31037 RVA: 0x003260A8 File Offset: 0x003242A8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x0600793E RID: 31038 RVA: 0x003260B8 File Offset: 0x003242B8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount other)
										{
										}

										// Token: 0x0600793F RID: 31039 RVA: 0x003260C8 File Offset: 0x003242C8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007940 RID: 31040 RVA: 0x003260D8 File Offset: 0x003242D8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007941 RID: 31041 RVA: 0x003260E8 File Offset: 0x003242E8
										[MethodImpl(MethodImplOptions.NoInlining)]
										static Mount()
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
													num2 = 4;
													continue;
												case 2:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
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
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount>(() => null);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												}
												break;
											}
										}

										// Token: 0x06007942 RID: 31042 RVA: 0x003261B4 File Offset: 0x003243B4
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool v9TfB1g2vjNHOwascemv()
										{
											return true;
										}

										// Token: 0x06007943 RID: 31043 RVA: 0x003261BC File Offset: 0x003243BC
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount jgJAM3g2opm3MwHyvZNO()
										{
											return null;
										}

										// Token: 0x04002B52 RID: 11090
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount> _parser;

										// Token: 0x04002B53 RID: 11091
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002B54 RID: 11092
										public const int OwnerNameFieldNumber = 1;

										// Token: 0x04002B55 RID: 11093
										private string ownerName_;

										// Token: 0x04002B56 RID: 11094
										public const int LevelFieldNumber = 2;

										// Token: 0x04002B57 RID: 11095
										private int level_;

										// Token: 0x04002B58 RID: 11096
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NamedActor.Types.Mount hw67NZg2UxfakkA5sRK0;
									}
								}
							}

							// Token: 0x020009ED RID: 2541
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class TaxCollectorActor : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor>, IBufferMessage
							{
								// Token: 0x170015CE RID: 5582
								// (get) Token: 0x0600794E RID: 31054 RVA: 0x003236E0 File Offset: 0x003218E0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x170015CF RID: 5583
								// (get) Token: 0x0600794F RID: 31055 RVA: 0x003236F0 File Offset: 0x003218F0
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

								// Token: 0x170015D0 RID: 5584
								// (get) Token: 0x06007950 RID: 31056 RVA: 0x00323700 File Offset: 0x00321900
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

								// Token: 0x06007951 RID: 31057 RVA: 0x00323710 File Offset: 0x00321910
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public TaxCollectorActor()
								{
								}

								// Token: 0x06007952 RID: 31058 RVA: 0x00323720 File Offset: 0x00321920
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public TaxCollectorActor(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor other)
								{
								}

								// Token: 0x06007953 RID: 31059 RVA: 0x00323730 File Offset: 0x00321930
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor Clone()
								{
									return null;
								}

								// Token: 0x170015D1 RID: 5585
								// (get) Token: 0x06007954 RID: 31060 RVA: 0x00323740 File Offset: 0x00321940
								// (set) Token: 0x06007955 RID: 31061 RVA: 0x00323750 File Offset: 0x00321950
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public TaxCollectorStaticInformation Identification
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

								// Token: 0x170015D2 RID: 5586
								// (get) Token: 0x06007956 RID: 31062 RVA: 0x00323760 File Offset: 0x00321960
								// (set) Token: 0x06007957 RID: 31063 RVA: 0x00323770 File Offset: 0x00321970
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int Attack
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

								// Token: 0x06007958 RID: 31064 RVA: 0x00323780 File Offset: 0x00321980
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007959 RID: 31065 RVA: 0x00323790 File Offset: 0x00321990
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor other)
								{
									return true;
								}

								// Token: 0x0600795A RID: 31066 RVA: 0x003237A0 File Offset: 0x003219A0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x0600795B RID: 31067 RVA: 0x003237B0 File Offset: 0x003219B0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x0600795C RID: 31068 RVA: 0x003237C0 File Offset: 0x003219C0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x0600795D RID: 31069 RVA: 0x003237D0 File Offset: 0x003219D0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x0600795E RID: 31070 RVA: 0x003237E0 File Offset: 0x003219E0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x0600795F RID: 31071 RVA: 0x003237F0 File Offset: 0x003219F0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor other)
								{
								}

								// Token: 0x06007960 RID: 31072 RVA: 0x00323800 File Offset: 0x00321A00
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007961 RID: 31073 RVA: 0x00323810 File Offset: 0x00321A10
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007962 RID: 31074 RVA: 0x00323820 File Offset: 0x00321A20
								[MethodImpl(MethodImplOptions.NoInlining)]
								static TaxCollectorActor()
								{
									uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
									int num = 3;
									int num2 = num;
									for (;;)
									{
										switch (num2)
										{
										case 1:
											return;
										case 2:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 4;
											continue;
										case 3:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 4:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										}
										ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor>(() => null);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
										{
											num2 = 0;
										}
									}
								}

								// Token: 0x06007963 RID: 31075 RVA: 0x00323904 File Offset: 0x00321B04
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool LFLeoKgdrjja91qhLyy9()
								{
									return true;
								}

								// Token: 0x06007964 RID: 31076 RVA: 0x0032390C File Offset: 0x00321B0C
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor RuQy6wgdVbJq6VHQ6XUA()
								{
									return null;
								}

								// Token: 0x04002B5D RID: 11101
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor> _parser;

								// Token: 0x04002B5E RID: 11102
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002B5F RID: 11103
								public const int IdentificationFieldNumber = 1;

								// Token: 0x04002B60 RID: 11104
								private TaxCollectorStaticInformation identification_;

								// Token: 0x04002B61 RID: 11105
								public const int AttackFieldNumber = 2;

								// Token: 0x04002B62 RID: 11106
								private int attack_;

								// Token: 0x04002B63 RID: 11107
								private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.TaxCollectorActor NIK7uNgdhwsvMdYFJQ8l;
							}

							// Token: 0x020009EF RID: 2543
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class MonsterGroupActor : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor>, IBufferMessage
							{
								// Token: 0x170015D3 RID: 5587
								// (get) Token: 0x0600796A RID: 31082 RVA: 0x00323914 File Offset: 0x00321B14
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x170015D4 RID: 5588
								// (get) Token: 0x0600796B RID: 31083 RVA: 0x00323924 File Offset: 0x00321B24
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

								// Token: 0x170015D5 RID: 5589
								// (get) Token: 0x0600796C RID: 31084 RVA: 0x00323934 File Offset: 0x00321B34
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

								// Token: 0x0600796D RID: 31085 RVA: 0x00323944 File Offset: 0x00321B44
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public MonsterGroupActor()
								{
								}

								// Token: 0x0600796E RID: 31086 RVA: 0x00323954 File Offset: 0x00321B54
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public MonsterGroupActor(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor other)
								{
								}

								// Token: 0x0600796F RID: 31087 RVA: 0x00323964 File Offset: 0x00321B64
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor Clone()
								{
									return null;
								}

								// Token: 0x170015D6 RID: 5590
								// (get) Token: 0x06007970 RID: 31088 RVA: 0x00323974 File Offset: 0x00321B74
								// (set) Token: 0x06007971 RID: 31089 RVA: 0x00323984 File Offset: 0x00321B84
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public MonsterGroupStaticInformation Identification
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

								// Token: 0x170015D7 RID: 5591
								// (get) Token: 0x06007972 RID: 31090 RVA: 0x00323994 File Offset: 0x00321B94
								// (set) Token: 0x06007973 RID: 31091 RVA: 0x003239A4 File Offset: 0x00321BA4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int LootShare
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

								// Token: 0x170015D8 RID: 5592
								// (get) Token: 0x06007974 RID: 31092 RVA: 0x003239B4 File Offset: 0x00321BB4
								// (set) Token: 0x06007975 RID: 31093 RVA: 0x003239C8 File Offset: 0x00321BC8
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public Alignment Alignment
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (Alignment)null;
									}
									[MethodImpl(MethodImplOptions.NoInlining)]
									set
									{
									}
								}

								// Token: 0x170015D9 RID: 5593
								// (get) Token: 0x06007976 RID: 31094 RVA: 0x003239D8 File Offset: 0x00321BD8
								// (set) Token: 0x06007977 RID: 31095 RVA: 0x003239E8 File Offset: 0x00321BE8
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation WaveInformation
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

								// Token: 0x06007978 RID: 31096 RVA: 0x003239F8 File Offset: 0x00321BF8
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007979 RID: 31097 RVA: 0x00323A08 File Offset: 0x00321C08
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor other)
								{
									return true;
								}

								// Token: 0x0600797A RID: 31098 RVA: 0x00323A18 File Offset: 0x00321C18
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x0600797B RID: 31099 RVA: 0x00323A28 File Offset: 0x00321C28
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x0600797C RID: 31100 RVA: 0x00323A38 File Offset: 0x00321C38
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x0600797D RID: 31101 RVA: 0x00323A48 File Offset: 0x00321C48
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x0600797E RID: 31102 RVA: 0x00323A58 File Offset: 0x00321C58
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x0600797F RID: 31103 RVA: 0x00323A68 File Offset: 0x00321C68
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor other)
								{
								}

								// Token: 0x06007980 RID: 31104 RVA: 0x00323A78 File Offset: 0x00321C78
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007981 RID: 31105 RVA: 0x00323A88 File Offset: 0x00321C88
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007982 RID: 31106 RVA: 0x00323A98 File Offset: 0x00321C98
								[MethodImpl(MethodImplOptions.NoInlining)]
								static MonsterGroupActor()
								{
									uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
									int num = 3;
									int num2 = num;
									for (;;)
									{
										switch (num2)
										{
										case 1:
											ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor>(() => null);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 4;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 3:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 4:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
											{
												num2 = 1;
												continue;
											}
											continue;
										}
										break;
									}
								}

								// Token: 0x06007983 RID: 31107 RVA: 0x00323B90 File Offset: 0x00321D90
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool Rm95ragdCGuyjqefa5PB()
								{
									return true;
								}

								// Token: 0x06007984 RID: 31108 RVA: 0x00323B98 File Offset: 0x00321D98
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor G4bymSgdDH3PMFKHBDRc()
								{
									return null;
								}

								// Token: 0x04002B66 RID: 11110
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor> _parser;

								// Token: 0x04002B67 RID: 11111
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002B68 RID: 11112
								public const int IdentificationFieldNumber = 1;

								// Token: 0x04002B69 RID: 11113
								private MonsterGroupStaticInformation identification_;

								// Token: 0x04002B6A RID: 11114
								public const int LootShareFieldNumber = 2;

								// Token: 0x04002B6B RID: 11115
								private int lootShare_;

								// Token: 0x04002B6C RID: 11116
								public const int AlignmentFieldNumber = 3;

								// Token: 0x04002B6D RID: 11117
								private Alignment alignment_;

								// Token: 0x04002B6E RID: 11118
								public const int WaveInformationFieldNumber = 4;

								// Token: 0x04002B6F RID: 11119
								private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation waveInformation_;

								// Token: 0x04002B70 RID: 11120
								private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor OUdCT9gd0yvFklahtx54;

								// Token: 0x020009F0 RID: 2544
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static class Types
								{
									// Token: 0x06007985 RID: 31109 RVA: 0x00325388 File Offset: 0x00323588
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x020009F1 RID: 2545
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class WaveInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation>, IBufferMessage
									{
										// Token: 0x170015DA RID: 5594
										// (get) Token: 0x06007986 RID: 31110 RVA: 0x003261C4 File Offset: 0x003243C4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170015DB RID: 5595
										// (get) Token: 0x06007987 RID: 31111 RVA: 0x003261D4 File Offset: 0x003243D4
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

										// Token: 0x170015DC RID: 5596
										// (get) Token: 0x06007988 RID: 31112 RVA: 0x003261E4 File Offset: 0x003243E4
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

										// Token: 0x06007989 RID: 31113 RVA: 0x003261F4 File Offset: 0x003243F4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public WaveInformation()
										{
										}

										// Token: 0x0600798A RID: 31114 RVA: 0x00326204 File Offset: 0x00324404
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public WaveInformation(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation other)
										{
										}

										// Token: 0x0600798B RID: 31115 RVA: 0x00326214 File Offset: 0x00324414
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation Clone()
										{
											return null;
										}

										// Token: 0x170015DD RID: 5597
										// (get) Token: 0x0600798C RID: 31116 RVA: 0x00326224 File Offset: 0x00324424
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public RepeatedField<MonsterGroupStaticInformation> Alternatives
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170015DE RID: 5598
										// (get) Token: 0x0600798D RID: 31117 RVA: 0x00326234 File Offset: 0x00324434
										// (set) Token: 0x0600798E RID: 31118 RVA: 0x00326244 File Offset: 0x00324444
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int WaveCount
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

										// Token: 0x170015DF RID: 5599
										// (get) Token: 0x0600798F RID: 31119 RVA: 0x00326254 File Offset: 0x00324454
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public bool HasWaveCount
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return true;
											}
										}

										// Token: 0x06007990 RID: 31120 RVA: 0x00326264 File Offset: 0x00324464
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void ClearWaveCount()
										{
										}

										// Token: 0x06007991 RID: 31121 RVA: 0x00326274 File Offset: 0x00324474
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007992 RID: 31122 RVA: 0x00326284 File Offset: 0x00324484
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation other)
										{
											return true;
										}

										// Token: 0x06007993 RID: 31123 RVA: 0x00326294 File Offset: 0x00324494
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007994 RID: 31124 RVA: 0x003262A4 File Offset: 0x003244A4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007995 RID: 31125 RVA: 0x003262B4 File Offset: 0x003244B4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007996 RID: 31126 RVA: 0x003262C4 File Offset: 0x003244C4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007997 RID: 31127 RVA: 0x003262D4 File Offset: 0x003244D4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007998 RID: 31128 RVA: 0x003262E4 File Offset: 0x003244E4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation other)
										{
										}

										// Token: 0x06007999 RID: 31129 RVA: 0x003262F4 File Offset: 0x003244F4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x0600799A RID: 31130 RVA: 0x00326304 File Offset: 0x00324504
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x0600799B RID: 31131 RVA: 0x00326314 File Offset: 0x00324514
										[MethodImpl(MethodImplOptions.NoInlining)]
										static WaveInformation()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 4;
													continue;
												case 3:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation.WaveCountDefaultValue = 0;
													num2 = 5;
													continue;
												case 4:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation>(() => null);
													num2 = 6;
													continue;
												case 5:
													return;
												case 6:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation._repeated_alternatives_codec = FieldCodec.ForMessage<MonsterGroupStaticInformation>(18U, MHgXa4BkZ5TUsxPh1nJh.XVInXhlssT(MHgXa4BkZ5TUsxPh1nJh.clHBkqyFr6W));
													num2 = 3;
													continue;
												}
												AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
												num2 = 0;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
												{
													num2 = 2;
												}
											}
										}

										// Token: 0x0600799C RID: 31132 RVA: 0x00326418 File Offset: 0x00324618
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool TvmcqKg2aq9UaIWNbyVH()
										{
											return true;
										}

										// Token: 0x0600799D RID: 31133 RVA: 0x00326420 File Offset: 0x00324620
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation hAdNvCg25ZilcElE4TTf()
										{
											return null;
										}

										// Token: 0x04002B71 RID: 11121
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation> _parser;

										// Token: 0x04002B72 RID: 11122
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002B73 RID: 11123
										private int _hasBits0;

										// Token: 0x04002B74 RID: 11124
										public const int AlternativesFieldNumber = 2;

										// Token: 0x04002B75 RID: 11125
										private static readonly FieldCodec<MonsterGroupStaticInformation> _repeated_alternatives_codec;

										// Token: 0x04002B76 RID: 11126
										private readonly RepeatedField<MonsterGroupStaticInformation> alternatives_;

										// Token: 0x04002B77 RID: 11127
										public const int WaveCountFieldNumber = 1;

										// Token: 0x04002B78 RID: 11128
										private static readonly int WaveCountDefaultValue;

										// Token: 0x04002B79 RID: 11129
										private int waveCount_;

										// Token: 0x04002B7A RID: 11130
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.MonsterGroupActor.Types.WaveInformation cPvSqLg21JwehfleHBws;
									}
								}
							}

							// Token: 0x020009F4 RID: 2548
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class NpcStaticInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation>, IBufferMessage
							{
								// Token: 0x170015E0 RID: 5600
								// (get) Token: 0x060079A8 RID: 31144 RVA: 0x00323BA0 File Offset: 0x00321DA0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x170015E1 RID: 5601
								// (get) Token: 0x060079A9 RID: 31145 RVA: 0x00323BB0 File Offset: 0x00321DB0
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

								// Token: 0x170015E2 RID: 5602
								// (get) Token: 0x060079AA RID: 31146 RVA: 0x00323BC0 File Offset: 0x00321DC0
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

								// Token: 0x060079AB RID: 31147 RVA: 0x00323BD0 File Offset: 0x00321DD0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NpcStaticInformation()
								{
								}

								// Token: 0x060079AC RID: 31148 RVA: 0x00323BE0 File Offset: 0x00321DE0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NpcStaticInformation(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation other)
								{
								}

								// Token: 0x060079AD RID: 31149 RVA: 0x00323BF0 File Offset: 0x00321DF0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation Clone()
								{
									return null;
								}

								// Token: 0x170015E3 RID: 5603
								// (get) Token: 0x060079AE RID: 31150 RVA: 0x00323C00 File Offset: 0x00321E00
								// (set) Token: 0x060079AF RID: 31151 RVA: 0x00323C10 File Offset: 0x00321E10
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

								// Token: 0x170015E4 RID: 5604
								// (get) Token: 0x060079B0 RID: 31152 RVA: 0x00323C20 File Offset: 0x00321E20
								// (set) Token: 0x060079B1 RID: 31153 RVA: 0x00323C34 File Offset: 0x00321E34
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public Gender Gender
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (Gender)null;
									}
									[MethodImpl(MethodImplOptions.NoInlining)]
									set
									{
									}
								}

								// Token: 0x170015E5 RID: 5605
								// (get) Token: 0x060079B2 RID: 31154 RVA: 0x00323C44 File Offset: 0x00321E44
								// (set) Token: 0x060079B3 RID: 31155 RVA: 0x00323C54 File Offset: 0x00321E54
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int SpecialArtworkId
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

								// Token: 0x170015E6 RID: 5606
								// (get) Token: 0x060079B4 RID: 31156 RVA: 0x00323C64 File Offset: 0x00321E64
								// (set) Token: 0x060079B5 RID: 31157 RVA: 0x00323C74 File Offset: 0x00321E74
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests Quests
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

								// Token: 0x060079B6 RID: 31158 RVA: 0x00323C84 File Offset: 0x00321E84
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x060079B7 RID: 31159 RVA: 0x00323C94 File Offset: 0x00321E94
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation other)
								{
									return true;
								}

								// Token: 0x060079B8 RID: 31160 RVA: 0x00323CA4 File Offset: 0x00321EA4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x060079B9 RID: 31161 RVA: 0x00323CB4 File Offset: 0x00321EB4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x060079BA RID: 31162 RVA: 0x00323CC4 File Offset: 0x00321EC4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x060079BB RID: 31163 RVA: 0x00323CD4 File Offset: 0x00321ED4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x060079BC RID: 31164 RVA: 0x00323CE4 File Offset: 0x00321EE4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x060079BD RID: 31165 RVA: 0x00323CF4 File Offset: 0x00321EF4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation other)
								{
								}

								// Token: 0x060079BE RID: 31166 RVA: 0x00323D04 File Offset: 0x00321F04
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x060079BF RID: 31167 RVA: 0x00323D14 File Offset: 0x00321F14
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x060079C0 RID: 31168 RVA: 0x00323D24 File Offset: 0x00321F24
								[MethodImpl(MethodImplOptions.NoInlining)]
								static NpcStaticInformation()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
											{
												num2 = 1;
												continue;
											}
											continue;
										case 3:
											ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation>(() => null);
											num2 = 4;
											continue;
										case 4:
											return;
										}
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 3;
									}
								}

								// Token: 0x060079C1 RID: 31169 RVA: 0x00323DF0 File Offset: 0x00321FF0
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool EQQqLlgdwcVVaiBCYgaA()
								{
									return true;
								}

								// Token: 0x060079C2 RID: 31170 RVA: 0x00323DF8 File Offset: 0x00321FF8
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation vZPdJ5gdQoW8ZC57agYx()
								{
									return null;
								}

								// Token: 0x04002B7F RID: 11135
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation> _parser;

								// Token: 0x04002B80 RID: 11136
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002B81 RID: 11137
								public const int NpcIdFieldNumber = 1;

								// Token: 0x04002B82 RID: 11138
								private int npcId_;

								// Token: 0x04002B83 RID: 11139
								public const int GenderFieldNumber = 2;

								// Token: 0x04002B84 RID: 11140
								private Gender gender_;

								// Token: 0x04002B85 RID: 11141
								public const int SpecialArtworkIdFieldNumber = 3;

								// Token: 0x04002B86 RID: 11142
								private int specialArtworkId_;

								// Token: 0x04002B87 RID: 11143
								public const int QuestsFieldNumber = 4;

								// Token: 0x04002B88 RID: 11144
								private ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests quests_;

								// Token: 0x04002B89 RID: 11145
								private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation CuwNMCgdtJVUttmh2CVJ;

								// Token: 0x020009F5 RID: 2549
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static class Types
								{
									// Token: 0x060079C3 RID: 31171 RVA: 0x00325480 File Offset: 0x00323680
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x020009F6 RID: 2550
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class Quests : IMessage<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests>, IBufferMessage
									{
										// Token: 0x170015E7 RID: 5607
										// (get) Token: 0x060079C4 RID: 31172 RVA: 0x00326428 File Offset: 0x00324628
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170015E8 RID: 5608
										// (get) Token: 0x060079C5 RID: 31173 RVA: 0x00326438 File Offset: 0x00324638
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

										// Token: 0x170015E9 RID: 5609
										// (get) Token: 0x060079C6 RID: 31174 RVA: 0x00326448 File Offset: 0x00324648
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

										// Token: 0x060079C7 RID: 31175 RVA: 0x00326458 File Offset: 0x00324658
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Quests()
										{
										}

										// Token: 0x060079C8 RID: 31176 RVA: 0x00326468 File Offset: 0x00324668
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Quests(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests other)
										{
										}

										// Token: 0x060079C9 RID: 31177 RVA: 0x00326478 File Offset: 0x00324678
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests Clone()
										{
											return null;
										}

										// Token: 0x170015EA RID: 5610
										// (get) Token: 0x060079CA RID: 31178 RVA: 0x00326488 File Offset: 0x00324688
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public RepeatedField<int> QuestsToValid
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170015EB RID: 5611
										// (get) Token: 0x060079CB RID: 31179 RVA: 0x00326498 File Offset: 0x00324698
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

										// Token: 0x060079CC RID: 31180 RVA: 0x003264A8 File Offset: 0x003246A8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x060079CD RID: 31181 RVA: 0x003264B8 File Offset: 0x003246B8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests other)
										{
											return true;
										}

										// Token: 0x060079CE RID: 31182 RVA: 0x003264C8 File Offset: 0x003246C8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x060079CF RID: 31183 RVA: 0x003264D8 File Offset: 0x003246D8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x060079D0 RID: 31184 RVA: 0x003264E8 File Offset: 0x003246E8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x060079D1 RID: 31185 RVA: 0x003264F8 File Offset: 0x003246F8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x060079D2 RID: 31186 RVA: 0x00326508 File Offset: 0x00324708
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x060079D3 RID: 31187 RVA: 0x00326518 File Offset: 0x00324718
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests other)
										{
										}

										// Token: 0x060079D4 RID: 31188 RVA: 0x00326528 File Offset: 0x00324728
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x060079D5 RID: 31189 RVA: 0x00326538 File Offset: 0x00324738
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x060079D6 RID: 31190 RVA: 0x00326548 File Offset: 0x00324748
										[MethodImpl(MethodImplOptions.NoInlining)]
										static Quests()
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
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests>(() => null);
													num2 = 6;
													continue;
												case 3:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 4:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 3;
													continue;
												case 5:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests._repeated_questsToStart_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
													{
														num2 = 1;
														continue;
													}
													continue;
												case 6:
													ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests._repeated_questsToValid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
													num2 = 5;
													continue;
												}
												UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
												num2 = 2;
											}
										}

										// Token: 0x060079D7 RID: 31191 RVA: 0x00326654 File Offset: 0x00324854
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool ELhFWNg26NsATjJZhyic()
										{
											return true;
										}

										// Token: 0x060079D8 RID: 31192 RVA: 0x0032665C File Offset: 0x0032485C
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests xWCtyUg2Lb4tUG2bMTAp()
										{
											return null;
										}

										// Token: 0x04002B8A RID: 11146
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests> _parser;

										// Token: 0x04002B8B RID: 11147
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002B8C RID: 11148
										public const int QuestsToValidFieldNumber = 1;

										// Token: 0x04002B8D RID: 11149
										private static readonly FieldCodec<int> _repeated_questsToValid_codec;

										// Token: 0x04002B8E RID: 11150
										private readonly RepeatedField<int> questsToValid_;

										// Token: 0x04002B8F RID: 11151
										public const int QuestsToStartFieldNumber = 2;

										// Token: 0x04002B90 RID: 11152
										private static readonly FieldCodec<int> _repeated_questsToStart_codec;

										// Token: 0x04002B91 RID: 11153
										private readonly RepeatedField<int> questsToStart_;

										// Token: 0x04002B92 RID: 11154
										private static ActorPositionInformation.Types.ActorInformation.Types.RolePlayActor.Types.NpcStaticInformation.Types.Quests qPRZoMg2yVmCDeRuLTTx;
									}
								}
							}
						}
					}

					// Token: 0x020009FA RID: 2554
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class FightFighterInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation>, IBufferMessage
					{
						// Token: 0x170015EC RID: 5612
						// (get) Token: 0x060079E8 RID: 31208 RVA: 0x0031D264 File Offset: 0x0031B464
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170015ED RID: 5613
						// (get) Token: 0x060079E9 RID: 31209 RVA: 0x0031D274 File Offset: 0x0031B474
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

						// Token: 0x170015EE RID: 5614
						// (get) Token: 0x060079EA RID: 31210 RVA: 0x0031D284 File Offset: 0x0031B484
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

						// Token: 0x060079EB RID: 31211 RVA: 0x0031D294 File Offset: 0x0031B494
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightFighterInformation()
						{
						}

						// Token: 0x060079EC RID: 31212 RVA: 0x0031D2A4 File Offset: 0x0031B4A4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightFighterInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation other)
						{
						}

						// Token: 0x060079ED RID: 31213 RVA: 0x0031D2B4 File Offset: 0x0031B4B4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation Clone()
						{
							return null;
						}

						// Token: 0x170015EF RID: 5615
						// (get) Token: 0x060079EE RID: 31214 RVA: 0x0031D2C4 File Offset: 0x0031B4C4
						// (set) Token: 0x060079EF RID: 31215 RVA: 0x0031D2D4 File Offset: 0x0031B4D4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public SpawnInformation SpawnInformation
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

						// Token: 0x170015F0 RID: 5616
						// (get) Token: 0x060079F0 RID: 31216 RVA: 0x0031D2E4 File Offset: 0x0031B4E4
						// (set) Token: 0x060079F1 RID: 31217 RVA: 0x0031D2F4 File Offset: 0x0031B4F4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int Wave
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

						// Token: 0x170015F1 RID: 5617
						// (get) Token: 0x060079F2 RID: 31218 RVA: 0x0031D304 File Offset: 0x0031B504
						// (set) Token: 0x060079F3 RID: 31219 RVA: 0x0031D314 File Offset: 0x0031B514
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public FightCharacteristics Stats
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

						// Token: 0x170015F2 RID: 5618
						// (get) Token: 0x060079F4 RID: 31220 RVA: 0x0031D324 File Offset: 0x0031B524
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<int> PreviousPositions
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170015F3 RID: 5619
						// (get) Token: 0x060079F5 RID: 31221 RVA: 0x0031D334 File Offset: 0x0031B534
						// (set) Token: 0x060079F6 RID: 31222 RVA: 0x0031D344 File Offset: 0x0031B544
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation NamedFighter
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

						// Token: 0x170015F4 RID: 5620
						// (get) Token: 0x060079F7 RID: 31223 RVA: 0x0031D354 File Offset: 0x0031B554
						// (set) Token: 0x060079F8 RID: 31224 RVA: 0x0031D364 File Offset: 0x0031B564
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation AiFighter
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

						// Token: 0x170015F5 RID: 5621
						// (get) Token: 0x060079F9 RID: 31225 RVA: 0x0031D374 File Offset: 0x0031B574
						// (set) Token: 0x060079FA RID: 31226 RVA: 0x0031D384 File Offset: 0x0031B584
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation EntityFighter
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

						// Token: 0x170015F6 RID: 5622
						// (get) Token: 0x060079FB RID: 31227 RVA: 0x0031D394 File Offset: 0x0031B594
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.FighterInformationOneofCase FighterInformationCase
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.FighterInformationOneofCase)null;
							}
						}

						// Token: 0x060079FC RID: 31228 RVA: 0x0031D3A8 File Offset: 0x0031B5A8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearFighterInformation()
						{
						}

						// Token: 0x060079FD RID: 31229 RVA: 0x0031D3B8 File Offset: 0x0031B5B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060079FE RID: 31230 RVA: 0x0031D3C8 File Offset: 0x0031B5C8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation other)
						{
							return true;
						}

						// Token: 0x060079FF RID: 31231 RVA: 0x0031D3D8 File Offset: 0x0031B5D8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06007A00 RID: 31232 RVA: 0x0031D3E8 File Offset: 0x0031B5E8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06007A01 RID: 31233 RVA: 0x0031D3F8 File Offset: 0x0031B5F8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06007A02 RID: 31234 RVA: 0x0031D408 File Offset: 0x0031B608
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06007A03 RID: 31235 RVA: 0x0031D418 File Offset: 0x0031B618
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06007A04 RID: 31236 RVA: 0x0031D428 File Offset: 0x0031B628
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation other)
						{
						}

						// Token: 0x06007A05 RID: 31237 RVA: 0x0031D438 File Offset: 0x0031B638
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06007A06 RID: 31238 RVA: 0x0031D448 File Offset: 0x0031B648
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06007A07 RID: 31239 RVA: 0x0031D458 File Offset: 0x0031B658
						[MethodImpl(MethodImplOptions.NoInlining)]
						static FightFighterInformation()
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
									num2 = 3;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
									{
										num2 = 3;
										continue;
									}
									continue;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 3:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 4;
									continue;
								case 4:
									ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation>(() => null);
									num2 = 5;
									continue;
								case 5:
									ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation._repeated_previousPositions_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								break;
							}
						}

						// Token: 0x06007A08 RID: 31240 RVA: 0x0031D558 File Offset: 0x0031B758
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool OwReIwgJa5qW4IiPJu8k()
						{
							return true;
						}

						// Token: 0x06007A09 RID: 31241 RVA: 0x0031D560 File Offset: 0x0031B760
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation fYpokUgJ5D4QScpqB2Po()
						{
							return null;
						}

						// Token: 0x04002B99 RID: 11161
						private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation> _parser;

						// Token: 0x04002B9A RID: 11162
						private UnknownFieldSet _unknownFields;

						// Token: 0x04002B9B RID: 11163
						public const int SpawnInformationFieldNumber = 1;

						// Token: 0x04002B9C RID: 11164
						private SpawnInformation spawnInformation_;

						// Token: 0x04002B9D RID: 11165
						public const int WaveFieldNumber = 2;

						// Token: 0x04002B9E RID: 11166
						private int wave_;

						// Token: 0x04002B9F RID: 11167
						public const int StatsFieldNumber = 3;

						// Token: 0x04002BA0 RID: 11168
						private FightCharacteristics stats_;

						// Token: 0x04002BA1 RID: 11169
						public const int PreviousPositionsFieldNumber = 4;

						// Token: 0x04002BA2 RID: 11170
						private static readonly FieldCodec<int> _repeated_previousPositions_codec;

						// Token: 0x04002BA3 RID: 11171
						private readonly RepeatedField<int> previousPositions_;

						// Token: 0x04002BA4 RID: 11172
						public const int NamedFighterFieldNumber = 5;

						// Token: 0x04002BA5 RID: 11173
						public const int AiFighterFieldNumber = 6;

						// Token: 0x04002BA6 RID: 11174
						public const int EntityFighterFieldNumber = 7;

						// Token: 0x04002BA7 RID: 11175
						private object fighterInformation_;

						// Token: 0x04002BA8 RID: 11176
						private ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.FighterInformationOneofCase fighterInformationCase_;

						// Token: 0x04002BA9 RID: 11177
						internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation mhMLHjgJ17JaNVAL7ht6;

						// Token: 0x020009FB RID: 2555
						public enum FighterInformationOneofCase
						{
							// Token: 0x04002BAB RID: 11179
							None,
							// Token: 0x04002BAC RID: 11180
							NamedFighter = 5,
							// Token: 0x04002BAD RID: 11181
							AiFighter,
							// Token: 0x04002BAE RID: 11182
							EntityFighter
						}

						// Token: 0x020009FC RID: 2556
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x06007A0A RID: 31242 RVA: 0x00321840 File Offset: 0x0031FA40
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x020009FD RID: 2557
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class NamedFighterInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation>, IBufferMessage
							{
								// Token: 0x170015F7 RID: 5623
								// (get) Token: 0x06007A0B RID: 31243 RVA: 0x00323E00 File Offset: 0x00322000
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x170015F8 RID: 5624
								// (get) Token: 0x06007A0C RID: 31244 RVA: 0x00323E10 File Offset: 0x00322010
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

								// Token: 0x170015F9 RID: 5625
								// (get) Token: 0x06007A0D RID: 31245 RVA: 0x00323E20 File Offset: 0x00322020
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

								// Token: 0x06007A0E RID: 31246 RVA: 0x00323E30 File Offset: 0x00322030
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NamedFighterInformation()
								{
								}

								// Token: 0x06007A0F RID: 31247 RVA: 0x00323E40 File Offset: 0x00322040
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public NamedFighterInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation other)
								{
								}

								// Token: 0x06007A10 RID: 31248 RVA: 0x00323E50 File Offset: 0x00322050
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation Clone()
								{
									return null;
								}

								// Token: 0x170015FA RID: 5626
								// (get) Token: 0x06007A11 RID: 31249 RVA: 0x00323E60 File Offset: 0x00322060
								// (set) Token: 0x06007A12 RID: 31250 RVA: 0x00323E70 File Offset: 0x00322070
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public string Name
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

								// Token: 0x170015FB RID: 5627
								// (get) Token: 0x06007A13 RID: 31251 RVA: 0x00323E80 File Offset: 0x00322080
								// (set) Token: 0x06007A14 RID: 31252 RVA: 0x00323E90 File Offset: 0x00322090
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public CharacterStatus Status
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

								// Token: 0x170015FC RID: 5628
								// (get) Token: 0x06007A15 RID: 31253 RVA: 0x00323EA0 File Offset: 0x003220A0
								// (set) Token: 0x06007A16 RID: 31254 RVA: 0x00323EB0 File Offset: 0x003220B0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int LeagueId
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

								// Token: 0x170015FD RID: 5629
								// (get) Token: 0x06007A17 RID: 31255 RVA: 0x00323EC0 File Offset: 0x003220C0
								// (set) Token: 0x06007A18 RID: 31256 RVA: 0x00323ED0 File Offset: 0x003220D0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int LadderPosition
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

								// Token: 0x170015FE RID: 5630
								// (get) Token: 0x06007A19 RID: 31257 RVA: 0x00323EE0 File Offset: 0x003220E0
								// (set) Token: 0x06007A1A RID: 31258 RVA: 0x00323EF0 File Offset: 0x003220F0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public bool HiddenInPreFight
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

								// Token: 0x170015FF RID: 5631
								// (get) Token: 0x06007A1B RID: 31259 RVA: 0x00323F00 File Offset: 0x00322100
								// (set) Token: 0x06007A1C RID: 31260 RVA: 0x00323F10 File Offset: 0x00322110
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation CharacterInformation
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

								// Token: 0x17001600 RID: 5632
								// (get) Token: 0x06007A1D RID: 31261 RVA: 0x00323F20 File Offset: 0x00322120
								// (set) Token: 0x06007A1E RID: 31262 RVA: 0x00323F30 File Offset: 0x00322130
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation MutantInformation
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

								// Token: 0x17001601 RID: 5633
								// (get) Token: 0x06007A1F RID: 31263 RVA: 0x00323F40 File Offset: 0x00322140
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.FighterInformationOneofCase FighterInformationCase
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.FighterInformationOneofCase)null;
									}
								}

								// Token: 0x06007A20 RID: 31264 RVA: 0x00323F54 File Offset: 0x00322154
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void ClearFighterInformation()
								{
								}

								// Token: 0x06007A21 RID: 31265 RVA: 0x00323F64 File Offset: 0x00322164
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007A22 RID: 31266 RVA: 0x00323F74 File Offset: 0x00322174
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation other)
								{
									return true;
								}

								// Token: 0x06007A23 RID: 31267 RVA: 0x00323F84 File Offset: 0x00322184
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06007A24 RID: 31268 RVA: 0x00323F94 File Offset: 0x00322194
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06007A25 RID: 31269 RVA: 0x00323FA4 File Offset: 0x003221A4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06007A26 RID: 31270 RVA: 0x00323FB4 File Offset: 0x003221B4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06007A27 RID: 31271 RVA: 0x00323FC4 File Offset: 0x003221C4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06007A28 RID: 31272 RVA: 0x00323FD4 File Offset: 0x003221D4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation other)
								{
								}

								// Token: 0x06007A29 RID: 31273 RVA: 0x00323FE4 File Offset: 0x003221E4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007A2A RID: 31274 RVA: 0x00323FF4 File Offset: 0x003221F4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007A2B RID: 31275 RVA: 0x00324004 File Offset: 0x00322204
								[MethodImpl(MethodImplOptions.NoInlining)]
								static NamedFighterInformation()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											return;
										case 3:
											ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation>(() => null);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 4:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 3;
											continue;
										}
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 4;
									}
								}

								// Token: 0x06007A2C RID: 31276 RVA: 0x003240D0 File Offset: 0x003222D0
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool APwF69gdTvfytsFRRj9d()
								{
									return true;
								}

								// Token: 0x06007A2D RID: 31277 RVA: 0x003240D8 File Offset: 0x003222D8
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation oBipDYgdpKueuWK3qJ8i()
								{
									return null;
								}

								// Token: 0x04002BAF RID: 11183
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation> _parser;

								// Token: 0x04002BB0 RID: 11184
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002BB1 RID: 11185
								public const int NameFieldNumber = 1;

								// Token: 0x04002BB2 RID: 11186
								private string name_;

								// Token: 0x04002BB3 RID: 11187
								public const int StatusFieldNumber = 2;

								// Token: 0x04002BB4 RID: 11188
								private CharacterStatus status_;

								// Token: 0x04002BB5 RID: 11189
								public const int LeagueIdFieldNumber = 3;

								// Token: 0x04002BB6 RID: 11190
								private int leagueId_;

								// Token: 0x04002BB7 RID: 11191
								public const int LadderPositionFieldNumber = 4;

								// Token: 0x04002BB8 RID: 11192
								private int ladderPosition_;

								// Token: 0x04002BB9 RID: 11193
								public const int HiddenInPreFightFieldNumber = 5;

								// Token: 0x04002BBA RID: 11194
								private bool hiddenInPreFight_;

								// Token: 0x04002BBB RID: 11195
								public const int CharacterInformationFieldNumber = 6;

								// Token: 0x04002BBC RID: 11196
								public const int MutantInformationFieldNumber = 7;

								// Token: 0x04002BBD RID: 11197
								private object fighterInformation_;

								// Token: 0x04002BBE RID: 11198
								private ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.FighterInformationOneofCase fighterInformationCase_;

								// Token: 0x04002BBF RID: 11199
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation bBcmGogd7T6isdaAabig;

								// Token: 0x020009FE RID: 2558
								public enum FighterInformationOneofCase
								{
									// Token: 0x04002BC1 RID: 11201
									None,
									// Token: 0x04002BC2 RID: 11202
									CharacterInformation = 6,
									// Token: 0x04002BC3 RID: 11203
									MutantInformation
								}

								// Token: 0x020009FF RID: 2559
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static class Types
								{
									// Token: 0x06007A2E RID: 31278 RVA: 0x00325590 File Offset: 0x00323790
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x02000A00 RID: 2560
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class FightCharacterInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation>, IBufferMessage
									{
										// Token: 0x17001602 RID: 5634
										// (get) Token: 0x06007A2F RID: 31279 RVA: 0x00326664 File Offset: 0x00324864
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x17001603 RID: 5635
										// (get) Token: 0x06007A30 RID: 31280 RVA: 0x00326674 File Offset: 0x00324874
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

										// Token: 0x17001604 RID: 5636
										// (get) Token: 0x06007A31 RID: 31281 RVA: 0x00326684 File Offset: 0x00324884
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

										// Token: 0x06007A32 RID: 31282 RVA: 0x00326694 File Offset: 0x00324894
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightCharacterInformation()
										{
										}

										// Token: 0x06007A33 RID: 31283 RVA: 0x003266A4 File Offset: 0x003248A4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightCharacterInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation other)
										{
										}

										// Token: 0x06007A34 RID: 31284 RVA: 0x003266B4 File Offset: 0x003248B4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation Clone()
										{
											return null;
										}

										// Token: 0x17001605 RID: 5637
										// (get) Token: 0x06007A35 RID: 31285 RVA: 0x003266C4 File Offset: 0x003248C4
										// (set) Token: 0x06007A36 RID: 31286 RVA: 0x003266D4 File Offset: 0x003248D4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int Level
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

										// Token: 0x17001606 RID: 5638
										// (get) Token: 0x06007A37 RID: 31287 RVA: 0x003266E4 File Offset: 0x003248E4
										// (set) Token: 0x06007A38 RID: 31288 RVA: 0x003266F4 File Offset: 0x003248F4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public AlignmentInformation AlignmentInformation
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

										// Token: 0x17001607 RID: 5639
										// (get) Token: 0x06007A39 RID: 31289 RVA: 0x00326704 File Offset: 0x00324904
										// (set) Token: 0x06007A3A RID: 31290 RVA: 0x00326714 File Offset: 0x00324914
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int BreedId
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

										// Token: 0x17001608 RID: 5640
										// (get) Token: 0x06007A3B RID: 31291 RVA: 0x00326724 File Offset: 0x00324924
										// (set) Token: 0x06007A3C RID: 31292 RVA: 0x00326738 File Offset: 0x00324938
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public Gender Gender
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return (Gender)null;
											}
											[MethodImpl(MethodImplOptions.NoInlining)]
											set
											{
											}
										}

										// Token: 0x06007A3D RID: 31293 RVA: 0x00326748 File Offset: 0x00324948
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007A3E RID: 31294 RVA: 0x00326758 File Offset: 0x00324958
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation other)
										{
											return true;
										}

										// Token: 0x06007A3F RID: 31295 RVA: 0x00326768 File Offset: 0x00324968
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007A40 RID: 31296 RVA: 0x00326778 File Offset: 0x00324978
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007A41 RID: 31297 RVA: 0x00326788 File Offset: 0x00324988
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007A42 RID: 31298 RVA: 0x00326798 File Offset: 0x00324998
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007A43 RID: 31299 RVA: 0x003267A8 File Offset: 0x003249A8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007A44 RID: 31300 RVA: 0x003267B8 File Offset: 0x003249B8
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation other)
										{
										}

										// Token: 0x06007A45 RID: 31301 RVA: 0x003267C8 File Offset: 0x003249C8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007A46 RID: 31302 RVA: 0x003267D8 File Offset: 0x003249D8
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007A47 RID: 31303 RVA: 0x003267E8 File Offset: 0x003249E8
										[MethodImpl(MethodImplOptions.NoInlining)]
										static FightCharacterInformation()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation>(() => null);
													num2 = 3;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
													{
														num2 = 1;
														continue;
													}
													continue;
												case 3:
													return;
												case 4:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 2;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												}
												AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
												num2 = 4;
											}
										}

										// Token: 0x06007A48 RID: 31304 RVA: 0x003268CC File Offset: 0x00324ACC
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool HL9UFgg2hTk0stZd3iM8()
										{
											return true;
										}

										// Token: 0x06007A49 RID: 31305 RVA: 0x003268D4 File Offset: 0x00324AD4
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation edr6u5g2rUbwugRoq8Ta()
										{
											return null;
										}

										// Token: 0x04002BC4 RID: 11204
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation> _parser;

										// Token: 0x04002BC5 RID: 11205
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002BC6 RID: 11206
										public const int LevelFieldNumber = 1;

										// Token: 0x04002BC7 RID: 11207
										private int level_;

										// Token: 0x04002BC8 RID: 11208
										public const int AlignmentInformationFieldNumber = 2;

										// Token: 0x04002BC9 RID: 11209
										private AlignmentInformation alignmentInformation_;

										// Token: 0x04002BCA RID: 11210
										public const int BreedIdFieldNumber = 3;

										// Token: 0x04002BCB RID: 11211
										private int breedId_;

										// Token: 0x04002BCC RID: 11212
										public const int GenderFieldNumber = 4;

										// Token: 0x04002BCD RID: 11213
										private Gender gender_;

										// Token: 0x04002BCE RID: 11214
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightCharacterInformation q9CACcg2WkmcWCX9n0cf;
									}

									// Token: 0x02000A02 RID: 2562
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class FightMutantInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation>, IBufferMessage
									{
										// Token: 0x17001609 RID: 5641
										// (get) Token: 0x06007A4F RID: 31311 RVA: 0x003268DC File Offset: 0x00324ADC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700160A RID: 5642
										// (get) Token: 0x06007A50 RID: 31312 RVA: 0x003268EC File Offset: 0x00324AEC
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

										// Token: 0x1700160B RID: 5643
										// (get) Token: 0x06007A51 RID: 31313 RVA: 0x003268FC File Offset: 0x00324AFC
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

										// Token: 0x06007A52 RID: 31314 RVA: 0x0032690C File Offset: 0x00324B0C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightMutantInformation()
										{
										}

										// Token: 0x06007A53 RID: 31315 RVA: 0x0032691C File Offset: 0x00324B1C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightMutantInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation other)
										{
										}

										// Token: 0x06007A54 RID: 31316 RVA: 0x0032692C File Offset: 0x00324B2C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation Clone()
										{
											return null;
										}

										// Token: 0x1700160C RID: 5644
										// (get) Token: 0x06007A55 RID: 31317 RVA: 0x0032693C File Offset: 0x00324B3C
										// (set) Token: 0x06007A56 RID: 31318 RVA: 0x0032694C File Offset: 0x00324B4C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int PowerLevel
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

										// Token: 0x06007A57 RID: 31319 RVA: 0x0032695C File Offset: 0x00324B5C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007A58 RID: 31320 RVA: 0x0032696C File Offset: 0x00324B6C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation other)
										{
											return true;
										}

										// Token: 0x06007A59 RID: 31321 RVA: 0x0032697C File Offset: 0x00324B7C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007A5A RID: 31322 RVA: 0x0032698C File Offset: 0x00324B8C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007A5B RID: 31323 RVA: 0x0032699C File Offset: 0x00324B9C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007A5C RID: 31324 RVA: 0x003269AC File Offset: 0x00324BAC
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007A5D RID: 31325 RVA: 0x003269BC File Offset: 0x00324BBC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007A5E RID: 31326 RVA: 0x003269CC File Offset: 0x00324BCC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation other)
										{
										}

										// Token: 0x06007A5F RID: 31327 RVA: 0x003269DC File Offset: 0x00324BDC
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007A60 RID: 31328 RVA: 0x003269EC File Offset: 0x00324BEC
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007A61 RID: 31329 RVA: 0x003269FC File Offset: 0x00324BFC
										[MethodImpl(MethodImplOptions.NoInlining)]
										static FightMutantInformation()
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
														goto IL_AC;
													case 2:
														xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
														num2 = 1;
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
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
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
														{
															num2 = 0;
															continue;
														}
														continue;
													}
													ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation>(() => null);
													num2 = 3;
												}
												IL_AC:
												AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
												num = 4;
											}
										}

										// Token: 0x06007A62 RID: 31330 RVA: 0x00326ACC File Offset: 0x00324CCC
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool FF3LuWg20hsfUoX5T4eh()
										{
											return true;
										}

										// Token: 0x06007A63 RID: 31331 RVA: 0x00326AD4 File Offset: 0x00324CD4
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation bVmRLcg2C6H9mrt63cYE()
										{
											return null;
										}

										// Token: 0x04002BD1 RID: 11217
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation> _parser;

										// Token: 0x04002BD2 RID: 11218
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002BD3 RID: 11219
										public const int PowerLevelFieldNumber = 1;

										// Token: 0x04002BD4 RID: 11220
										private int powerLevel_;

										// Token: 0x04002BD5 RID: 11221
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.NamedFighterInformation.Types.FightMutantInformation gxILp2g2VgjGtVMoSvmE;
									}
								}
							}

							// Token: 0x02000A05 RID: 2565
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class AIFighterInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation>, IBufferMessage
							{
								// Token: 0x1700160D RID: 5645
								// (get) Token: 0x06007A6E RID: 31342 RVA: 0x003240E0 File Offset: 0x003222E0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x1700160E RID: 5646
								// (get) Token: 0x06007A6F RID: 31343 RVA: 0x003240F0 File Offset: 0x003222F0
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

								// Token: 0x1700160F RID: 5647
								// (get) Token: 0x06007A70 RID: 31344 RVA: 0x00324100 File Offset: 0x00322300
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

								// Token: 0x06007A71 RID: 31345 RVA: 0x00324110 File Offset: 0x00322310
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public AIFighterInformation()
								{
								}

								// Token: 0x06007A72 RID: 31346 RVA: 0x00324120 File Offset: 0x00322320
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public AIFighterInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation other)
								{
								}

								// Token: 0x06007A73 RID: 31347 RVA: 0x00324130 File Offset: 0x00322330
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation Clone()
								{
									return null;
								}

								// Token: 0x17001610 RID: 5648
								// (get) Token: 0x06007A74 RID: 31348 RVA: 0x00324140 File Offset: 0x00322340
								// (set) Token: 0x06007A75 RID: 31349 RVA: 0x00324150 File Offset: 0x00322350
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter MonsterFighterInformation
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

								// Token: 0x17001611 RID: 5649
								// (get) Token: 0x06007A76 RID: 31350 RVA: 0x00324160 File Offset: 0x00322360
								// (set) Token: 0x06007A77 RID: 31351 RVA: 0x00324170 File Offset: 0x00322370
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter TaxCollectorInformation
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

								// Token: 0x17001612 RID: 5650
								// (get) Token: 0x06007A78 RID: 31352 RVA: 0x00324180 File Offset: 0x00322380
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.AiFighterInformationOneofCase AiFighterInformationCase
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.AiFighterInformationOneofCase)null;
									}
								}

								// Token: 0x06007A79 RID: 31353 RVA: 0x00324194 File Offset: 0x00322394
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void ClearAiFighterInformation()
								{
								}

								// Token: 0x06007A7A RID: 31354 RVA: 0x003241A4 File Offset: 0x003223A4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007A7B RID: 31355 RVA: 0x003241B4 File Offset: 0x003223B4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation other)
								{
									return true;
								}

								// Token: 0x06007A7C RID: 31356 RVA: 0x003241C4 File Offset: 0x003223C4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06007A7D RID: 31357 RVA: 0x003241D4 File Offset: 0x003223D4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06007A7E RID: 31358 RVA: 0x003241E4 File Offset: 0x003223E4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06007A7F RID: 31359 RVA: 0x003241F4 File Offset: 0x003223F4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06007A80 RID: 31360 RVA: 0x00324204 File Offset: 0x00322404
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06007A81 RID: 31361 RVA: 0x00324214 File Offset: 0x00322414
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation other)
								{
								}

								// Token: 0x06007A82 RID: 31362 RVA: 0x00324224 File Offset: 0x00322424
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007A83 RID: 31363 RVA: 0x00324234 File Offset: 0x00322434
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007A84 RID: 31364 RVA: 0x00324244 File Offset: 0x00322444
								[MethodImpl(MethodImplOptions.NoInlining)]
								static AIFighterInformation()
								{
									uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
									int num = 4;
									int num2 = num;
									for (;;)
									{
										switch (num2)
										{
										case 1:
											ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation>(() => null);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 2:
											return;
										case 3:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 4:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
											{
												num2 = 3;
												continue;
											}
											continue;
										}
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
										{
											num2 = 1;
										}
									}
								}

								// Token: 0x06007A85 RID: 31365 RVA: 0x0032433C File Offset: 0x0032253C
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool QuST2sgdYV1XRO6h5SMa()
								{
									return true;
								}

								// Token: 0x06007A86 RID: 31366 RVA: 0x00324344 File Offset: 0x00322544
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation SASDnSgdbgLyrKLHjKur()
								{
									return null;
								}

								// Token: 0x04002BDA RID: 11226
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation> _parser;

								// Token: 0x04002BDB RID: 11227
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002BDC RID: 11228
								public const int MonsterFighterInformationFieldNumber = 1;

								// Token: 0x04002BDD RID: 11229
								public const int TaxCollectorInformationFieldNumber = 2;

								// Token: 0x04002BDE RID: 11230
								private object aiFighterInformation_;

								// Token: 0x04002BDF RID: 11231
								private ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.AiFighterInformationOneofCase aiFighterInformationCase_;

								// Token: 0x04002BE0 RID: 11232
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation TH7eLxgdHjwrCVpKf6BD;

								// Token: 0x02000A06 RID: 2566
								public enum AiFighterInformationOneofCase
								{
									// Token: 0x04002BE2 RID: 11234
									None,
									// Token: 0x04002BE3 RID: 11235
									MonsterFighterInformation,
									// Token: 0x04002BE4 RID: 11236
									TaxCollectorInformation
								}

								// Token: 0x02000A07 RID: 2567
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static class Types
								{
									// Token: 0x06007A87 RID: 31367 RVA: 0x003256A0 File Offset: 0x003238A0
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x02000A08 RID: 2568
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class MonsterFighter : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter>, IBufferMessage
									{
										// Token: 0x17001613 RID: 5651
										// (get) Token: 0x06007A88 RID: 31368 RVA: 0x00326ADC File Offset: 0x00324CDC
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x17001614 RID: 5652
										// (get) Token: 0x06007A89 RID: 31369 RVA: 0x00326AEC File Offset: 0x00324CEC
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

										// Token: 0x17001615 RID: 5653
										// (get) Token: 0x06007A8A RID: 31370 RVA: 0x00326AFC File Offset: 0x00324CFC
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

										// Token: 0x06007A8B RID: 31371 RVA: 0x00326B0C File Offset: 0x00324D0C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public MonsterFighter()
										{
										}

										// Token: 0x06007A8C RID: 31372 RVA: 0x00326B1C File Offset: 0x00324D1C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public MonsterFighter(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter other)
										{
										}

										// Token: 0x06007A8D RID: 31373 RVA: 0x00326B2C File Offset: 0x00324D2C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter Clone()
										{
											return null;
										}

										// Token: 0x17001616 RID: 5654
										// (get) Token: 0x06007A8E RID: 31374 RVA: 0x00326B3C File Offset: 0x00324D3C
										// (set) Token: 0x06007A8F RID: 31375 RVA: 0x00326B4C File Offset: 0x00324D4C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int MonsterGid
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

										// Token: 0x17001617 RID: 5655
										// (get) Token: 0x06007A90 RID: 31376 RVA: 0x00326B5C File Offset: 0x00324D5C
										// (set) Token: 0x06007A91 RID: 31377 RVA: 0x00326B6C File Offset: 0x00324D6C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int CreatureGrade
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

										// Token: 0x17001618 RID: 5656
										// (get) Token: 0x06007A92 RID: 31378 RVA: 0x00326B7C File Offset: 0x00324D7C
										// (set) Token: 0x06007A93 RID: 31379 RVA: 0x00326B8C File Offset: 0x00324D8C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int CreatureLevel
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

										// Token: 0x17001619 RID: 5657
										// (get) Token: 0x06007A94 RID: 31380 RVA: 0x00326B9C File Offset: 0x00324D9C
										// (set) Token: 0x06007A95 RID: 31381 RVA: 0x00326BAC File Offset: 0x00324DAC
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public AlignmentInformation AlignmentInformation
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

										// Token: 0x06007A96 RID: 31382 RVA: 0x00326BBC File Offset: 0x00324DBC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007A97 RID: 31383 RVA: 0x00326BCC File Offset: 0x00324DCC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter other)
										{
											return true;
										}

										// Token: 0x06007A98 RID: 31384 RVA: 0x00326BDC File Offset: 0x00324DDC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007A99 RID: 31385 RVA: 0x00326BEC File Offset: 0x00324DEC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007A9A RID: 31386 RVA: 0x00326BFC File Offset: 0x00324DFC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007A9B RID: 31387 RVA: 0x00326C0C File Offset: 0x00324E0C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007A9C RID: 31388 RVA: 0x00326C1C File Offset: 0x00324E1C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007A9D RID: 31389 RVA: 0x00326C2C File Offset: 0x00324E2C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter other)
										{
										}

										// Token: 0x06007A9E RID: 31390 RVA: 0x00326C3C File Offset: 0x00324E3C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007A9F RID: 31391 RVA: 0x00326C4C File Offset: 0x00324E4C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007AA0 RID: 31392 RVA: 0x00326C5C File Offset: 0x00324E5C
										[MethodImpl(MethodImplOptions.NoInlining)]
										static MonsterFighter()
										{
											uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
											int num = 3;
											int num2 = num;
											for (;;)
											{
												switch (num2)
												{
												case 1:
													return;
												case 2:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 4;
													continue;
												case 3:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
													{
														num2 = 2;
														continue;
													}
													continue;
												case 4:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												}
												ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter>(() => null);
												num2 = 1;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
												{
													num2 = 1;
												}
											}
										}

										// Token: 0x06007AA1 RID: 31393 RVA: 0x00326D40 File Offset: 0x00324F40
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool owe9Cyg2tc84pw8QSMo5()
										{
											return true;
										}

										// Token: 0x06007AA2 RID: 31394 RVA: 0x00326D48 File Offset: 0x00324F48
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter TkegfPg2wovO6lbPYfH4()
										{
											return null;
										}

										// Token: 0x04002BE5 RID: 11237
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter> _parser;

										// Token: 0x04002BE6 RID: 11238
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002BE7 RID: 11239
										public const int MonsterGidFieldNumber = 1;

										// Token: 0x04002BE8 RID: 11240
										private int monsterGid_;

										// Token: 0x04002BE9 RID: 11241
										public const int CreatureGradeFieldNumber = 2;

										// Token: 0x04002BEA RID: 11242
										private int creatureGrade_;

										// Token: 0x04002BEB RID: 11243
										public const int CreatureLevelFieldNumber = 3;

										// Token: 0x04002BEC RID: 11244
										private int creatureLevel_;

										// Token: 0x04002BED RID: 11245
										public const int AlignmentInformationFieldNumber = 4;

										// Token: 0x04002BEE RID: 11246
										private AlignmentInformation alignmentInformation_;

										// Token: 0x04002BEF RID: 11247
										private static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.MonsterFighter jwqPB0g2Dg4r7ssnyeUV;
									}

									// Token: 0x02000A0A RID: 2570
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class TaxCollectorFighter : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter>, IBufferMessage
									{
										// Token: 0x1700161A RID: 5658
										// (get) Token: 0x06007AA8 RID: 31400 RVA: 0x00326D50 File Offset: 0x00324F50
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700161B RID: 5659
										// (get) Token: 0x06007AA9 RID: 31401 RVA: 0x00326D60 File Offset: 0x00324F60
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

										// Token: 0x1700161C RID: 5660
										// (get) Token: 0x06007AAA RID: 31402 RVA: 0x00326D70 File Offset: 0x00324F70
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

										// Token: 0x06007AAB RID: 31403 RVA: 0x00326D80 File Offset: 0x00324F80
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public TaxCollectorFighter()
										{
										}

										// Token: 0x06007AAC RID: 31404 RVA: 0x00326D90 File Offset: 0x00324F90
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public TaxCollectorFighter(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter other)
										{
										}

										// Token: 0x06007AAD RID: 31405 RVA: 0x00326DA0 File Offset: 0x00324FA0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter Clone()
										{
											return null;
										}

										// Token: 0x1700161D RID: 5661
										// (get) Token: 0x06007AAE RID: 31406 RVA: 0x00326DB0 File Offset: 0x00324FB0
										// (set) Token: 0x06007AAF RID: 31407 RVA: 0x00326DC0 File Offset: 0x00324FC0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int FirstNameId
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

										// Token: 0x1700161E RID: 5662
										// (get) Token: 0x06007AB0 RID: 31408 RVA: 0x00326DD0 File Offset: 0x00324FD0
										// (set) Token: 0x06007AB1 RID: 31409 RVA: 0x00326DE0 File Offset: 0x00324FE0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int LastNameId
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

										// Token: 0x06007AB2 RID: 31410 RVA: 0x00326DF0 File Offset: 0x00324FF0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007AB3 RID: 31411 RVA: 0x00326E00 File Offset: 0x00325000
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter other)
										{
											return true;
										}

										// Token: 0x06007AB4 RID: 31412 RVA: 0x00326E10 File Offset: 0x00325010
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007AB5 RID: 31413 RVA: 0x00326E20 File Offset: 0x00325020
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007AB6 RID: 31414 RVA: 0x00326E30 File Offset: 0x00325030
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007AB7 RID: 31415 RVA: 0x00326E40 File Offset: 0x00325040
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007AB8 RID: 31416 RVA: 0x00326E50 File Offset: 0x00325050
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007AB9 RID: 31417 RVA: 0x00326E60 File Offset: 0x00325060
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter other)
										{
										}

										// Token: 0x06007ABA RID: 31418 RVA: 0x00326E70 File Offset: 0x00325070
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007ABB RID: 31419 RVA: 0x00326E80 File Offset: 0x00325080
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007ABC RID: 31420 RVA: 0x00326E90 File Offset: 0x00325090
										[MethodImpl(MethodImplOptions.NoInlining)]
										static TaxCollectorFighter()
										{
											uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
											int num = 3;
											int num2 = num;
											for (;;)
											{
												switch (num2)
												{
												case 1:
													return;
												case 2:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 4;
													continue;
												case 3:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 2;
													continue;
												case 4:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												}
												ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter>(() => null);
												num2 = 0;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
												{
													num2 = 1;
												}
											}
										}

										// Token: 0x06007ABD RID: 31421 RVA: 0x00326F5C File Offset: 0x0032515C
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool emo7EKg27TEt9S4wm36B()
										{
											return true;
										}

										// Token: 0x06007ABE RID: 31422 RVA: 0x00326F64 File Offset: 0x00325164
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter b3fcCEg2TItkc5mucShA()
										{
											return null;
										}

										// Token: 0x04002BF2 RID: 11250
										private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter> _parser;

										// Token: 0x04002BF3 RID: 11251
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002BF4 RID: 11252
										public const int FirstNameIdFieldNumber = 1;

										// Token: 0x04002BF5 RID: 11253
										private int firstNameId_;

										// Token: 0x04002BF6 RID: 11254
										public const int LastNameIdFieldNumber = 2;

										// Token: 0x04002BF7 RID: 11255
										private int lastNameId_;

										// Token: 0x04002BF8 RID: 11256
										private static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.AIFighterInformation.Types.TaxCollectorFighter UdV3Xsg2QcNIwtdTsKyx;
									}
								}
							}

							// Token: 0x02000A0D RID: 2573
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class EntityFighterInformation : IMessage<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation>, IMessage, IEquatable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation>, IDeepCloneable<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation>, IBufferMessage
							{
								// Token: 0x1700161F RID: 5663
								// (get) Token: 0x06007AC9 RID: 31433 RVA: 0x0032434C File Offset: 0x0032254C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17001620 RID: 5664
								// (get) Token: 0x06007ACA RID: 31434 RVA: 0x0032435C File Offset: 0x0032255C
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

								// Token: 0x17001621 RID: 5665
								// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0032436C File Offset: 0x0032256C
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

								// Token: 0x06007ACC RID: 31436 RVA: 0x0032437C File Offset: 0x0032257C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public EntityFighterInformation()
								{
								}

								// Token: 0x06007ACD RID: 31437 RVA: 0x0032438C File Offset: 0x0032258C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public EntityFighterInformation(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation other)
								{
								}

								// Token: 0x06007ACE RID: 31438 RVA: 0x0032439C File Offset: 0x0032259C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation Clone()
								{
									return null;
								}

								// Token: 0x17001622 RID: 5666
								// (get) Token: 0x06007ACF RID: 31439 RVA: 0x003243AC File Offset: 0x003225AC
								// (set) Token: 0x06007AD0 RID: 31440 RVA: 0x003243BC File Offset: 0x003225BC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int EntityModelId
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

								// Token: 0x17001623 RID: 5667
								// (get) Token: 0x06007AD1 RID: 31441 RVA: 0x003243CC File Offset: 0x003225CC
								// (set) Token: 0x06007AD2 RID: 31442 RVA: 0x003243DC File Offset: 0x003225DC
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int Level
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

								// Token: 0x17001624 RID: 5668
								// (get) Token: 0x06007AD3 RID: 31443 RVA: 0x003243EC File Offset: 0x003225EC
								// (set) Token: 0x06007AD4 RID: 31444 RVA: 0x003243FC File Offset: 0x003225FC
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public long MasterId
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

								// Token: 0x06007AD5 RID: 31445 RVA: 0x0032440C File Offset: 0x0032260C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007AD6 RID: 31446 RVA: 0x0032441C File Offset: 0x0032261C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation other)
								{
									return true;
								}

								// Token: 0x06007AD7 RID: 31447 RVA: 0x0032442C File Offset: 0x0032262C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06007AD8 RID: 31448 RVA: 0x0032443C File Offset: 0x0032263C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06007AD9 RID: 31449 RVA: 0x0032444C File Offset: 0x0032264C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06007ADA RID: 31450 RVA: 0x0032445C File Offset: 0x0032265C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06007ADB RID: 31451 RVA: 0x0032446C File Offset: 0x0032266C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06007ADC RID: 31452 RVA: 0x0032447C File Offset: 0x0032267C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation other)
								{
								}

								// Token: 0x06007ADD RID: 31453 RVA: 0x0032448C File Offset: 0x0032268C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007ADE RID: 31454 RVA: 0x0032449C File Offset: 0x0032269C
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007ADF RID: 31455 RVA: 0x003244AC File Offset: 0x003226AC
								[MethodImpl(MethodImplOptions.NoInlining)]
								static EntityFighterInformation()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 4;
											continue;
										case 3:
											return;
										case 4:
											ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation._parser = new MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation>(() => null);
											num2 = 3;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										}
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
										{
											num2 = 2;
										}
									}
								}

								// Token: 0x06007AE0 RID: 31456 RVA: 0x00324590 File Offset: 0x00322790
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool DxAqn6gdPGW8ZmD19n6X()
								{
									return true;
								}

								// Token: 0x06007AE1 RID: 31457 RVA: 0x00324598 File Offset: 0x00322798
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation XQXeiRgdSNhqc70HeULx()
								{
									return null;
								}

								// Token: 0x04002BFD RID: 11261
								private static readonly MessageParser<ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation> _parser;

								// Token: 0x04002BFE RID: 11262
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002BFF RID: 11263
								public const int EntityModelIdFieldNumber = 1;

								// Token: 0x04002C00 RID: 11264
								private int entityModelId_;

								// Token: 0x04002C01 RID: 11265
								public const int LevelFieldNumber = 2;

								// Token: 0x04002C02 RID: 11266
								private int level_;

								// Token: 0x04002C03 RID: 11267
								public const int MasterIdFieldNumber = 3;

								// Token: 0x04002C04 RID: 11268
								private long masterId_;

								// Token: 0x04002C05 RID: 11269
								internal static ActorPositionInformation.Types.ActorInformation.Types.FightFighterInformation.Types.EntityFighterInformation gN9DpagdiABpunE62VjA;
							}
						}
					}
				}
			}
		}
	}
}
