using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AFA RID: 2810
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInformation : IMessage<GuildInformation>, IMessage, IEquatable<GuildInformation>, IDeepCloneable<GuildInformation>, IBufferMessage
	{
		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x0600865C RID: 34396 RVA: 0x002654B0 File Offset: 0x002636B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x002654C0 File Offset: 0x002636C0
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600865E RID: 34398 RVA: 0x002654D0 File Offset: 0x002636D0
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

		// Token: 0x0600865F RID: 34399 RVA: 0x002654E0 File Offset: 0x002636E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformation()
		{
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x002654F0 File Offset: 0x002636F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformation(GuildInformation other)
		{
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x00265500 File Offset: 0x00263700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformation Clone()
		{
			return null;
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06008662 RID: 34402 RVA: 0x00265510 File Offset: 0x00263710
		// (set) Token: 0x06008663 RID: 34403 RVA: 0x00265520 File Offset: 0x00263720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x00265530 File Offset: 0x00263730
		// (set) Token: 0x06008665 RID: 34405 RVA: 0x00265540 File Offset: 0x00263740
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

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x00265550 File Offset: 0x00263750
		// (set) Token: 0x06008667 RID: 34407 RVA: 0x00265560 File Offset: 0x00263760
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

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06008668 RID: 34408 RVA: 0x00265570 File Offset: 0x00263770
		// (set) Token: 0x06008669 RID: 34409 RVA: 0x00265580 File Offset: 0x00263780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation.Types.GuildSocialInformation SocialInformation
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

		// Token: 0x0600866A RID: 34410 RVA: 0x00265590 File Offset: 0x00263790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x002655A0 File Offset: 0x002637A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInformation other)
		{
			return true;
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x002655B0 File Offset: 0x002637B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x002655C0 File Offset: 0x002637C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x002655D0 File Offset: 0x002637D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x002655E0 File Offset: 0x002637E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x002655F0 File Offset: 0x002637F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00265600 File Offset: 0x00263800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInformation other)
		{
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00265610 File Offset: 0x00263810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x00265620 File Offset: 0x00263820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x00265630 File Offset: 0x00263830
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GuildInformation._parser = new MessageParser<GuildInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
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

		// Token: 0x06008675 RID: 34421 RVA: 0x002656FC File Offset: 0x002638FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HZiqHdJs8GWNsddw92RU()
		{
			return true;
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00265704 File Offset: 0x00263904
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInformation K2E7A2JsZsiKJWIcHIXm()
		{
			return null;
		}

		// Token: 0x04003139 RID: 12601
		private static readonly MessageParser<GuildInformation> _parser;

		// Token: 0x0400313A RID: 12602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400313B RID: 12603
		public const int IdFieldNumber = 1;

		// Token: 0x0400313C RID: 12604
		private int id_;

		// Token: 0x0400313D RID: 12605
		public const int NameFieldNumber = 2;

		// Token: 0x0400313E RID: 12606
		private string name_;

		// Token: 0x0400313F RID: 12607
		public const int LevelFieldNumber = 3;

		// Token: 0x04003140 RID: 12608
		private int level_;

		// Token: 0x04003141 RID: 12609
		public const int SocialInformationFieldNumber = 4;

		// Token: 0x04003142 RID: 12610
		private GuildInformation.Types.GuildSocialInformation socialInformation_;

		// Token: 0x04003143 RID: 12611
		private static GuildInformation ysn0FdJsuvXtCNjueAkF;

		// Token: 0x02000AFB RID: 2811
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008677 RID: 34423 RVA: 0x002E2880 File Offset: 0x002E0A80
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000AFC RID: 2812
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class GuildSocialInformation : IMessage<GuildInformation.Types.GuildSocialInformation>, IMessage, IEquatable<GuildInformation.Types.GuildSocialInformation>, IDeepCloneable<GuildInformation.Types.GuildSocialInformation>, IBufferMessage
			{
				// Token: 0x170018BD RID: 6333
				// (get) Token: 0x06008678 RID: 34424 RVA: 0x00309528 File Offset: 0x00307728
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GuildInformation.Types.GuildSocialInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170018BE RID: 6334
				// (get) Token: 0x06008679 RID: 34425 RVA: 0x00309538 File Offset: 0x00307738
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

				// Token: 0x170018BF RID: 6335
				// (get) Token: 0x0600867A RID: 34426 RVA: 0x00309548 File Offset: 0x00307748
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

				// Token: 0x0600867B RID: 34427 RVA: 0x00309558 File Offset: 0x00307758
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildSocialInformation()
				{
				}

				// Token: 0x0600867C RID: 34428 RVA: 0x00309568 File Offset: 0x00307768
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildSocialInformation(GuildInformation.Types.GuildSocialInformation other)
				{
				}

				// Token: 0x0600867D RID: 34429 RVA: 0x00309578 File Offset: 0x00307778
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildInformation.Types.GuildSocialInformation Clone()
				{
					return null;
				}

				// Token: 0x170018C0 RID: 6336
				// (get) Token: 0x0600867E RID: 34430 RVA: 0x00309588 File Offset: 0x00307788
				// (set) Token: 0x0600867F RID: 34431 RVA: 0x00309598 File Offset: 0x00307798
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public SocialEmblem Emblem
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

				// Token: 0x170018C1 RID: 6337
				// (get) Token: 0x06008680 RID: 34432 RVA: 0x003095A8 File Offset: 0x003077A8
				// (set) Token: 0x06008681 RID: 34433 RVA: 0x003095B8 File Offset: 0x003077B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation DetailedInformation
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

				// Token: 0x06008682 RID: 34434 RVA: 0x003095C8 File Offset: 0x003077C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008683 RID: 34435 RVA: 0x003095D8 File Offset: 0x003077D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildInformation.Types.GuildSocialInformation other)
				{
					return true;
				}

				// Token: 0x06008684 RID: 34436 RVA: 0x003095E8 File Offset: 0x003077E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008685 RID: 34437 RVA: 0x003095F8 File Offset: 0x003077F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008686 RID: 34438 RVA: 0x00309608 File Offset: 0x00307808
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008687 RID: 34439 RVA: 0x00309618 File Offset: 0x00307818
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008688 RID: 34440 RVA: 0x00309628 File Offset: 0x00307828
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008689 RID: 34441 RVA: 0x00309638 File Offset: 0x00307838
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildInformation.Types.GuildSocialInformation other)
				{
				}

				// Token: 0x0600868A RID: 34442 RVA: 0x00309648 File Offset: 0x00307848
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600868B RID: 34443 RVA: 0x00309658 File Offset: 0x00307858
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600868C RID: 34444 RVA: 0x00309668 File Offset: 0x00307868
				[MethodImpl(MethodImplOptions.NoInlining)]
				static GuildSocialInformation()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
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
							return;
						}
						GuildInformation.Types.GuildSocialInformation._parser = new MessageParser<GuildInformation.Types.GuildSocialInformation>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x0600868D RID: 34445 RVA: 0x0030974C File Offset: 0x0030794C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool F7qTxpGuZ5nNeqL8yIeP()
				{
					return true;
				}

				// Token: 0x0600868E RID: 34446 RVA: 0x00309754 File Offset: 0x00307954
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildInformation.Types.GuildSocialInformation xJyXF1Guq0cmblADYZaA()
				{
					return null;
				}

				// Token: 0x04003144 RID: 12612
				private static readonly MessageParser<GuildInformation.Types.GuildSocialInformation> _parser;

				// Token: 0x04003145 RID: 12613
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003146 RID: 12614
				public const int EmblemFieldNumber = 1;

				// Token: 0x04003147 RID: 12615
				private SocialEmblem emblem_;

				// Token: 0x04003148 RID: 12616
				public const int DetailedInformationFieldNumber = 2;

				// Token: 0x04003149 RID: 12617
				private GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation detailedInformation_;

				// Token: 0x0400314A RID: 12618
				private static GuildInformation.Types.GuildSocialInformation U59USjGu8UTdKTywY23w;

				// Token: 0x02000AFD RID: 2813
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x0600868F RID: 34447 RVA: 0x00318248 File Offset: 0x00316448
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000AFE RID: 2814
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class GuildDetailedInformation : IMessage<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation>, IMessage, IEquatable<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation>, IDeepCloneable<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation>, IBufferMessage
					{
						// Token: 0x170018C2 RID: 6338
						// (get) Token: 0x06008690 RID: 34448 RVA: 0x0031E464 File Offset: 0x0031C664
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170018C3 RID: 6339
						// (get) Token: 0x06008691 RID: 34449 RVA: 0x0031E474 File Offset: 0x0031C674
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

						// Token: 0x170018C4 RID: 6340
						// (get) Token: 0x06008692 RID: 34450 RVA: 0x0031E484 File Offset: 0x0031C684
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

						// Token: 0x06008693 RID: 34451 RVA: 0x0031E494 File Offset: 0x0031C694
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GuildDetailedInformation()
						{
						}

						// Token: 0x06008694 RID: 34452 RVA: 0x0031E4A4 File Offset: 0x0031C6A4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GuildDetailedInformation(GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation other)
						{
						}

						// Token: 0x06008695 RID: 34453 RVA: 0x0031E4B4 File Offset: 0x0031C6B4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation Clone()
						{
							return null;
						}

						// Token: 0x170018C5 RID: 6341
						// (get) Token: 0x06008696 RID: 34454 RVA: 0x0031E4C4 File Offset: 0x0031C6C4
						// (set) Token: 0x06008697 RID: 34455 RVA: 0x0031E4D4 File Offset: 0x0031C6D4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public long LeaderId
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

						// Token: 0x170018C6 RID: 6342
						// (get) Token: 0x06008698 RID: 34456 RVA: 0x0031E4E4 File Offset: 0x0031C6E4
						// (set) Token: 0x06008699 RID: 34457 RVA: 0x0031E4F4 File Offset: 0x0031C6F4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int MembersCount
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

						// Token: 0x170018C7 RID: 6343
						// (get) Token: 0x0600869A RID: 34458 RVA: 0x0031E504 File Offset: 0x0031C704
						// (set) Token: 0x0600869B RID: 34459 RVA: 0x0031E514 File Offset: 0x0031C714
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int LastActivityDay
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

						// Token: 0x170018C8 RID: 6344
						// (get) Token: 0x0600869C RID: 34460 RVA: 0x0031E524 File Offset: 0x0031C724
						// (set) Token: 0x0600869D RID: 34461 RVA: 0x0031E534 File Offset: 0x0031C734
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public GuildRecruitmentInformation Recruitment
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

						// Token: 0x170018C9 RID: 6345
						// (get) Token: 0x0600869E RID: 34462 RVA: 0x0031E544 File Offset: 0x0031C744
						// (set) Token: 0x0600869F RID: 34463 RVA: 0x0031E554 File Offset: 0x0031C754
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int PendingApplicationsCount
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

						// Token: 0x170018CA RID: 6346
						// (get) Token: 0x060086A0 RID: 34464 RVA: 0x0031E564 File Offset: 0x0031C764
						// (set) Token: 0x060086A1 RID: 34465 RVA: 0x0031E574 File Offset: 0x0031C774
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public string LeaderName
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

						// Token: 0x170018CB RID: 6347
						// (get) Token: 0x060086A2 RID: 34466 RVA: 0x0031E584 File Offset: 0x0031C784
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool HasLeaderName
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
						}

						// Token: 0x060086A3 RID: 34467 RVA: 0x0031E594 File Offset: 0x0031C794
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearLeaderName()
						{
						}

						// Token: 0x060086A4 RID: 34468 RVA: 0x0031E5A4 File Offset: 0x0031C7A4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060086A5 RID: 34469 RVA: 0x0031E5B4 File Offset: 0x0031C7B4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation other)
						{
							return true;
						}

						// Token: 0x060086A6 RID: 34470 RVA: 0x0031E5C4 File Offset: 0x0031C7C4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060086A7 RID: 34471 RVA: 0x0031E5D4 File Offset: 0x0031C7D4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060086A8 RID: 34472 RVA: 0x0031E5E4 File Offset: 0x0031C7E4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060086A9 RID: 34473 RVA: 0x0031E5F4 File Offset: 0x0031C7F4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060086AA RID: 34474 RVA: 0x0031E604 File Offset: 0x0031C804
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060086AB RID: 34475 RVA: 0x0031E614 File Offset: 0x0031C814
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation other)
						{
						}

						// Token: 0x060086AC RID: 34476 RVA: 0x0031E624 File Offset: 0x0031C824
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060086AD RID: 34477 RVA: 0x0031E634 File Offset: 0x0031C834
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060086AE RID: 34478 RVA: 0x0031E644 File Offset: 0x0031C844
						[MethodImpl(MethodImplOptions.NoInlining)]
						static GuildDetailedInformation()
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
										GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation.LeaderNameDefaultValue = "";
										num2 = 2;
										continue;
									case 2:
										return;
									case 3:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 4:
										goto IL_72;
									case 5:
										GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation._parser = new MessageParser<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation>(() => null);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
										{
											num2 = 1;
											continue;
										}
										continue;
									}
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 5;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
									{
										num2 = 0;
									}
								}
								IL_72:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num = 3;
							}
						}

						// Token: 0x060086AF RID: 34479 RVA: 0x0031E744 File Offset: 0x0031C944
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool YgMVfpgJM5ADnw2qfBRf()
						{
							return true;
						}

						// Token: 0x060086B0 RID: 34480 RVA: 0x0031E74C File Offset: 0x0031C94C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation BEE3V6gJuQJPP730BO60()
						{
							return null;
						}

						// Token: 0x0400314B RID: 12619
						private static readonly MessageParser<GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation> _parser;

						// Token: 0x0400314C RID: 12620
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400314D RID: 12621
						public const int LeaderIdFieldNumber = 1;

						// Token: 0x0400314E RID: 12622
						private long leaderId_;

						// Token: 0x0400314F RID: 12623
						public const int MembersCountFieldNumber = 2;

						// Token: 0x04003150 RID: 12624
						private int membersCount_;

						// Token: 0x04003151 RID: 12625
						public const int LastActivityDayFieldNumber = 3;

						// Token: 0x04003152 RID: 12626
						private int lastActivityDay_;

						// Token: 0x04003153 RID: 12627
						public const int RecruitmentFieldNumber = 4;

						// Token: 0x04003154 RID: 12628
						private GuildRecruitmentInformation recruitment_;

						// Token: 0x04003155 RID: 12629
						public const int PendingApplicationsCountFieldNumber = 5;

						// Token: 0x04003156 RID: 12630
						private int pendingApplicationsCount_;

						// Token: 0x04003157 RID: 12631
						public const int LeaderNameFieldNumber = 6;

						// Token: 0x04003158 RID: 12632
						private static readonly string LeaderNameDefaultValue;

						// Token: 0x04003159 RID: 12633
						private string leaderName_;

						// Token: 0x0400315A RID: 12634
						internal static GuildInformation.Types.GuildSocialInformation.Types.GuildDetailedInformation WWtQcagJSiEbfskMQH0L;
					}
				}
			}
		}
	}
}
