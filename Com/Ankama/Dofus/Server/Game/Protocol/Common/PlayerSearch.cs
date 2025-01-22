using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A63 RID: 2659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSearch : IMessage<PlayerSearch>, IMessage, IEquatable<PlayerSearch>, IDeepCloneable<PlayerSearch>, IBufferMessage
	{
		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x0025E73C File Offset: 0x0025C93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerSearch> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x0025E74C File Offset: 0x0025C94C
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

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06007EDB RID: 32475 RVA: 0x0025E75C File Offset: 0x0025C95C
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

		// Token: 0x06007EDC RID: 32476 RVA: 0x0025E76C File Offset: 0x0025C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerSearch()
		{
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x0025E77C File Offset: 0x0025C97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerSearch(PlayerSearch other)
		{
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x0025E78C File Offset: 0x0025C98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerSearch Clone()
		{
			return null;
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06007EDF RID: 32479 RVA: 0x0025E79C File Offset: 0x0025C99C
		// (set) Token: 0x06007EE0 RID: 32480 RVA: 0x0025E7AC File Offset: 0x0025C9AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSearch.Types.SearchByCharacterName SearchByCharacterName
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

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06007EE1 RID: 32481 RVA: 0x0025E7BC File Offset: 0x0025C9BC
		// (set) Token: 0x06007EE2 RID: 32482 RVA: 0x0025E7CC File Offset: 0x0025C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSearch.Types.SearchByAccount SearchByAccount
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

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06007EE3 RID: 32483 RVA: 0x0025E7DC File Offset: 0x0025C9DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSearch.PlayerSearchOneofCase PlayerSearchCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PlayerSearch.PlayerSearchOneofCase)null;
			}
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x0025E7F0 File Offset: 0x0025C9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPlayerSearch()
		{
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x0025E800 File Offset: 0x0025CA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x0025E810 File Offset: 0x0025CA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerSearch other)
		{
			return true;
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x0025E820 File Offset: 0x0025CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x0025E830 File Offset: 0x0025CA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x0025E840 File Offset: 0x0025CA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x0025E850 File Offset: 0x0025CA50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x0025E860 File Offset: 0x0025CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x0025E870 File Offset: 0x0025CA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerSearch other)
		{
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x0025E880 File Offset: 0x0025CA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x0025E890 File Offset: 0x0025CA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x0025E8A0 File Offset: 0x0025CAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerSearch()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					PlayerSearch._parser = new MessageParser<PlayerSearch>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x0025E998 File Offset: 0x0025CB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LhH8RfJGihB9ZxnHLe1x()
		{
			return true;
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0025E9A0 File Offset: 0x0025CBA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerSearch SeoOpLJGPdYOoDkBlHbx()
		{
			return null;
		}

		// Token: 0x04002DE9 RID: 11753
		private static readonly MessageParser<PlayerSearch> _parser;

		// Token: 0x04002DEA RID: 11754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DEB RID: 11755
		public const int SearchByCharacterNameFieldNumber = 1;

		// Token: 0x04002DEC RID: 11756
		public const int SearchByAccountFieldNumber = 2;

		// Token: 0x04002DED RID: 11757
		private object playerSearch_;

		// Token: 0x04002DEE RID: 11758
		private PlayerSearch.PlayerSearchOneofCase playerSearchCase_;

		// Token: 0x04002DEF RID: 11759
		internal static PlayerSearch l6F9UHJGbsZfBHodH3i6;

		// Token: 0x02000A64 RID: 2660
		public enum PlayerSearchOneofCase
		{
			// Token: 0x04002DF1 RID: 11761
			None,
			// Token: 0x04002DF2 RID: 11762
			SearchByCharacterName,
			// Token: 0x04002DF3 RID: 11763
			SearchByAccount
		}

		// Token: 0x02000A65 RID: 2661
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007EF2 RID: 32498 RVA: 0x002DFDF0 File Offset: 0x002DDFF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A66 RID: 2662
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SearchByCharacterName : IMessage<PlayerSearch.Types.SearchByCharacterName>, IMessage, IEquatable<PlayerSearch.Types.SearchByCharacterName>, IDeepCloneable<PlayerSearch.Types.SearchByCharacterName>, IBufferMessage
			{
				// Token: 0x17001714 RID: 5908
				// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x00307E08 File Offset: 0x00306008
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PlayerSearch.Types.SearchByCharacterName> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001715 RID: 5909
				// (get) Token: 0x06007EF4 RID: 32500 RVA: 0x00307E18 File Offset: 0x00306018
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

				// Token: 0x17001716 RID: 5910
				// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x00307E28 File Offset: 0x00306028
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

				// Token: 0x06007EF6 RID: 32502 RVA: 0x00307E38 File Offset: 0x00306038
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SearchByCharacterName()
				{
				}

				// Token: 0x06007EF7 RID: 32503 RVA: 0x00307E48 File Offset: 0x00306048
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SearchByCharacterName(PlayerSearch.Types.SearchByCharacterName other)
				{
				}

				// Token: 0x06007EF8 RID: 32504 RVA: 0x00307E58 File Offset: 0x00306058
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerSearch.Types.SearchByCharacterName Clone()
				{
					return null;
				}

				// Token: 0x17001717 RID: 5911
				// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x00307E68 File Offset: 0x00306068
				// (set) Token: 0x06007EFA RID: 32506 RVA: 0x00307E78 File Offset: 0x00306078
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

				// Token: 0x06007EFB RID: 32507 RVA: 0x00307E88 File Offset: 0x00306088
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007EFC RID: 32508 RVA: 0x00307E98 File Offset: 0x00306098
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PlayerSearch.Types.SearchByCharacterName other)
				{
					return true;
				}

				// Token: 0x06007EFD RID: 32509 RVA: 0x00307EA8 File Offset: 0x003060A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007EFE RID: 32510 RVA: 0x00307EB8 File Offset: 0x003060B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007EFF RID: 32511 RVA: 0x00307EC8 File Offset: 0x003060C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007F00 RID: 32512 RVA: 0x00307ED8 File Offset: 0x003060D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007F01 RID: 32513 RVA: 0x00307EE8 File Offset: 0x003060E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007F02 RID: 32514 RVA: 0x00307EF8 File Offset: 0x003060F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PlayerSearch.Types.SearchByCharacterName other)
				{
				}

				// Token: 0x06007F03 RID: 32515 RVA: 0x00307F08 File Offset: 0x00306108
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007F04 RID: 32516 RVA: 0x00307F18 File Offset: 0x00306118
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007F05 RID: 32517 RVA: 0x00307F28 File Offset: 0x00306128
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SearchByCharacterName()
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
							default:
								goto IL_35;
							case 1:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
								{
									num2 = 1;
								}
								break;
							case 3:
								return;
							case 4:
								PlayerSearch.Types.SearchByCharacterName._parser = new MessageParser<PlayerSearch.Types.SearchByCharacterName>(() => null);
								num2 = 3;
								break;
							}
						}
						IL_35:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 4;
					}
				}

				// Token: 0x06007F06 RID: 32518 RVA: 0x00307FF8 File Offset: 0x003061F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool rv9XGZGudIunBlWUgTb8()
				{
					return true;
				}

				// Token: 0x06007F07 RID: 32519 RVA: 0x00308000 File Offset: 0x00306200
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PlayerSearch.Types.SearchByCharacterName RprUy3Gu9ueULoGUVDIj()
				{
					return null;
				}

				// Token: 0x04002DF4 RID: 11764
				private static readonly MessageParser<PlayerSearch.Types.SearchByCharacterName> _parser;

				// Token: 0x04002DF5 RID: 11765
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002DF6 RID: 11766
				public const int NameFieldNumber = 1;

				// Token: 0x04002DF7 RID: 11767
				private string name_;

				// Token: 0x04002DF8 RID: 11768
				private static PlayerSearch.Types.SearchByCharacterName EH9wMEGus0Aq55sc2B5d;
			}

			// Token: 0x02000A68 RID: 2664
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SearchByAccount : IMessage<PlayerSearch.Types.SearchByAccount>, IMessage, IEquatable<PlayerSearch.Types.SearchByAccount>, IDeepCloneable<PlayerSearch.Types.SearchByAccount>, IBufferMessage
			{
				// Token: 0x17001718 RID: 5912
				// (get) Token: 0x06007F0D RID: 32525 RVA: 0x00308008 File Offset: 0x00306208
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PlayerSearch.Types.SearchByAccount> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001719 RID: 5913
				// (get) Token: 0x06007F0E RID: 32526 RVA: 0x00308018 File Offset: 0x00306218
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

				// Token: 0x1700171A RID: 5914
				// (get) Token: 0x06007F0F RID: 32527 RVA: 0x00308028 File Offset: 0x00306228
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

				// Token: 0x06007F10 RID: 32528 RVA: 0x00308038 File Offset: 0x00306238
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SearchByAccount()
				{
				}

				// Token: 0x06007F11 RID: 32529 RVA: 0x00308048 File Offset: 0x00306248
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SearchByAccount(PlayerSearch.Types.SearchByAccount other)
				{
				}

				// Token: 0x06007F12 RID: 32530 RVA: 0x00308058 File Offset: 0x00306258
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerSearch.Types.SearchByAccount Clone()
				{
					return null;
				}

				// Token: 0x1700171B RID: 5915
				// (get) Token: 0x06007F13 RID: 32531 RVA: 0x00308068 File Offset: 0x00306268
				// (set) Token: 0x06007F14 RID: 32532 RVA: 0x00308078 File Offset: 0x00306278
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

				// Token: 0x1700171C RID: 5916
				// (get) Token: 0x06007F15 RID: 32533 RVA: 0x00308088 File Offset: 0x00306288
				// (set) Token: 0x06007F16 RID: 32534 RVA: 0x00308098 File Offset: 0x00306298
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string Tag
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

				// Token: 0x06007F17 RID: 32535 RVA: 0x003080A8 File Offset: 0x003062A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007F18 RID: 32536 RVA: 0x003080B8 File Offset: 0x003062B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PlayerSearch.Types.SearchByAccount other)
				{
					return true;
				}

				// Token: 0x06007F19 RID: 32537 RVA: 0x003080C8 File Offset: 0x003062C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007F1A RID: 32538 RVA: 0x003080D8 File Offset: 0x003062D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007F1B RID: 32539 RVA: 0x003080E8 File Offset: 0x003062E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007F1C RID: 32540 RVA: 0x003080F8 File Offset: 0x003062F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007F1D RID: 32541 RVA: 0x00308108 File Offset: 0x00306308
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007F1E RID: 32542 RVA: 0x00308118 File Offset: 0x00306318
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PlayerSearch.Types.SearchByAccount other)
				{
				}

				// Token: 0x06007F1F RID: 32543 RVA: 0x00308128 File Offset: 0x00306328
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007F20 RID: 32544 RVA: 0x00308138 File Offset: 0x00306338
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007F21 RID: 32545 RVA: 0x00308148 File Offset: 0x00306348
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SearchByAccount()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							PlayerSearch.Types.SearchByAccount._parser = new MessageParser<PlayerSearch.Types.SearchByAccount>(() => null);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 4:
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
					}
				}

				// Token: 0x06007F22 RID: 32546 RVA: 0x0030822C File Offset: 0x0030642C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Tobd0uGuEsxJuKfJn0Wj()
				{
					return true;
				}

				// Token: 0x06007F23 RID: 32547 RVA: 0x00308234 File Offset: 0x00306434
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PlayerSearch.Types.SearchByAccount GDayVYGuXDpy3x86lEWU()
				{
					return null;
				}

				// Token: 0x04002DFB RID: 11771
				private static readonly MessageParser<PlayerSearch.Types.SearchByAccount> _parser;

				// Token: 0x04002DFC RID: 11772
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002DFD RID: 11773
				public const int NameFieldNumber = 1;

				// Token: 0x04002DFE RID: 11774
				private string name_;

				// Token: 0x04002DFF RID: 11775
				public const int TagFieldNumber = 2;

				// Token: 0x04002E00 RID: 11776
				private string tag_;

				// Token: 0x04002E01 RID: 11777
				internal static PlayerSearch.Types.SearchByAccount sOUqRpGu2kOHWn3o5nLf;
			}
		}
	}
}
