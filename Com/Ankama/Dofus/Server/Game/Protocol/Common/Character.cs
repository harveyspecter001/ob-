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
	// Token: 0x02000A28 RID: 2600
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Character : IMessage<Character>, IMessage, IEquatable<Character>, IDeepCloneable<Character>, IBufferMessage
	{
		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06007C06 RID: 31750 RVA: 0x0025CD58 File Offset: 0x0025AF58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Character> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x0025CD68 File Offset: 0x0025AF68
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

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06007C08 RID: 31752 RVA: 0x0025CD78 File Offset: 0x0025AF78
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

		// Token: 0x06007C09 RID: 31753 RVA: 0x0025CD88 File Offset: 0x0025AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character()
		{
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x0025CD98 File Offset: 0x0025AF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character(Character other)
		{
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x0025CDA8 File Offset: 0x0025AFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character Clone()
		{
			return null;
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06007C0C RID: 31756 RVA: 0x0025CDB8 File Offset: 0x0025AFB8
		// (set) Token: 0x06007C0D RID: 31757 RVA: 0x0025CDC8 File Offset: 0x0025AFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06007C0E RID: 31758 RVA: 0x0025CDD8 File Offset: 0x0025AFD8
		// (set) Token: 0x06007C0F RID: 31759 RVA: 0x0025CDE8 File Offset: 0x0025AFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character.Types.CharacterBasicInformation CharacterBasicInformation
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

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06007C10 RID: 31760 RVA: 0x0025CDF8 File Offset: 0x0025AFF8
		// (set) Token: 0x06007C11 RID: 31761 RVA: 0x0025CE08 File Offset: 0x0025B008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterRemodelingInformation CharacterRemodelingInformation
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06007C12 RID: 31762 RVA: 0x0025CE18 File Offset: 0x0025B018
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Character.ComplementOneofCase)null;
			}
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x0025CE2C File Offset: 0x0025B02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x0025CE3C File Offset: 0x0025B03C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x0025CE4C File Offset: 0x0025B04C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Character other)
		{
			return true;
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x0025CE5C File Offset: 0x0025B05C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x0025CE6C File Offset: 0x0025B06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x0025CE7C File Offset: 0x0025B07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x0025CE8C File Offset: 0x0025B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x0025CE9C File Offset: 0x0025B09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x0025CEAC File Offset: 0x0025B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Character other)
		{
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x0025CEBC File Offset: 0x0025B0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0025CECC File Offset: 0x0025B0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x0025CEDC File Offset: 0x0025B0DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Character()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						Character._parser = new MessageParser<Character>(() => null);
						num2 = 3;
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				IL_AC:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
				continue;
				goto IL_AC;
			}
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x0025CFAC File Offset: 0x0025B1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rXX4x4JGKyaj19nMegKt()
		{
			return true;
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x0025CFB4 File Offset: 0x0025B1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Character Rq6KmZJGIYMZAnrT3eGa()
		{
			return null;
		}

		// Token: 0x04002C96 RID: 11414
		private static readonly MessageParser<Character> _parser;

		// Token: 0x04002C97 RID: 11415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C98 RID: 11416
		public const int IdFieldNumber = 1;

		// Token: 0x04002C99 RID: 11417
		private long id_;

		// Token: 0x04002C9A RID: 11418
		public const int CharacterBasicInformationFieldNumber = 2;

		// Token: 0x04002C9B RID: 11419
		public const int CharacterRemodelingInformationFieldNumber = 3;

		// Token: 0x04002C9C RID: 11420
		private object complement_;

		// Token: 0x04002C9D RID: 11421
		private Character.ComplementOneofCase complementCase_;

		// Token: 0x04002C9E RID: 11422
		internal static Character Ey8aZxJGjXCGrAXB43xL;

		// Token: 0x02000A29 RID: 2601
		public enum ComplementOneofCase
		{
			// Token: 0x04002CA0 RID: 11424
			None,
			// Token: 0x04002CA1 RID: 11425
			CharacterBasicInformation = 2,
			// Token: 0x04002CA2 RID: 11426
			CharacterRemodelingInformation
		}

		// Token: 0x02000A2A RID: 2602
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007C21 RID: 31777 RVA: 0x002DF3E0 File Offset: 0x002DD5E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A2B RID: 2603
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CharacterBasicInformation : IMessage<Character.Types.CharacterBasicInformation>, IMessage, IEquatable<Character.Types.CharacterBasicInformation>, IDeepCloneable<Character.Types.CharacterBasicInformation>, IBufferMessage
			{
				// Token: 0x1700166C RID: 5740
				// (get) Token: 0x06007C22 RID: 31778 RVA: 0x003076A0 File Offset: 0x003058A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Character.Types.CharacterBasicInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700166D RID: 5741
				// (get) Token: 0x06007C23 RID: 31779 RVA: 0x003076B0 File Offset: 0x003058B0
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

				// Token: 0x1700166E RID: 5742
				// (get) Token: 0x06007C24 RID: 31780 RVA: 0x003076C0 File Offset: 0x003058C0
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

				// Token: 0x06007C25 RID: 31781 RVA: 0x003076D0 File Offset: 0x003058D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterBasicInformation()
				{
				}

				// Token: 0x06007C26 RID: 31782 RVA: 0x003076E0 File Offset: 0x003058E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterBasicInformation(Character.Types.CharacterBasicInformation other)
				{
				}

				// Token: 0x06007C27 RID: 31783 RVA: 0x003076F0 File Offset: 0x003058F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Character.Types.CharacterBasicInformation Clone()
				{
					return null;
				}

				// Token: 0x1700166F RID: 5743
				// (get) Token: 0x06007C28 RID: 31784 RVA: 0x00307700 File Offset: 0x00305900
				// (set) Token: 0x06007C29 RID: 31785 RVA: 0x00307710 File Offset: 0x00305910
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

				// Token: 0x17001670 RID: 5744
				// (get) Token: 0x06007C2A RID: 31786 RVA: 0x00307720 File Offset: 0x00305920
				// (set) Token: 0x06007C2B RID: 31787 RVA: 0x00307730 File Offset: 0x00305930
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

				// Token: 0x17001671 RID: 5745
				// (get) Token: 0x06007C2C RID: 31788 RVA: 0x00307740 File Offset: 0x00305940
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasLevel
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06007C2D RID: 31789 RVA: 0x00307750 File Offset: 0x00305950
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearLevel()
				{
				}

				// Token: 0x17001672 RID: 5746
				// (get) Token: 0x06007C2E RID: 31790 RVA: 0x00307760 File Offset: 0x00305960
				// (set) Token: 0x06007C2F RID: 31791 RVA: 0x00307770 File Offset: 0x00305970
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public Character.Types.CharacterBasicInformation.Types.CharacterLook CharacterLook
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

				// Token: 0x17001673 RID: 5747
				// (get) Token: 0x06007C30 RID: 31792 RVA: 0x00307780 File Offset: 0x00305980
				// (set) Token: 0x06007C31 RID: 31793 RVA: 0x00307790 File Offset: 0x00305990
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RankInformation Rank
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

				// Token: 0x17001674 RID: 5748
				// (get) Token: 0x06007C32 RID: 31794 RVA: 0x003077A0 File Offset: 0x003059A0
				// (set) Token: 0x06007C33 RID: 31795 RVA: 0x003077B0 File Offset: 0x003059B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Character.Types.CharacterBasicInformation.Types.SocialMember SocialMember
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

				// Token: 0x17001675 RID: 5749
				// (get) Token: 0x06007C34 RID: 31796 RVA: 0x003077C0 File Offset: 0x003059C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public Character.Types.CharacterBasicInformation.ComplementOneofCase ComplementCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (Character.Types.CharacterBasicInformation.ComplementOneofCase)null;
					}
				}

				// Token: 0x06007C35 RID: 31797 RVA: 0x003077D4 File Offset: 0x003059D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearComplement()
				{
				}

				// Token: 0x06007C36 RID: 31798 RVA: 0x003077E4 File Offset: 0x003059E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007C37 RID: 31799 RVA: 0x003077F4 File Offset: 0x003059F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(Character.Types.CharacterBasicInformation other)
				{
					return true;
				}

				// Token: 0x06007C38 RID: 31800 RVA: 0x00307804 File Offset: 0x00305A04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007C39 RID: 31801 RVA: 0x00307814 File Offset: 0x00305A14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007C3A RID: 31802 RVA: 0x00307824 File Offset: 0x00305A24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007C3B RID: 31803 RVA: 0x00307834 File Offset: 0x00305A34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007C3C RID: 31804 RVA: 0x00307844 File Offset: 0x00305A44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007C3D RID: 31805 RVA: 0x00307854 File Offset: 0x00305A54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(Character.Types.CharacterBasicInformation other)
				{
				}

				// Token: 0x06007C3E RID: 31806 RVA: 0x00307864 File Offset: 0x00305A64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007C3F RID: 31807 RVA: 0x00307874 File Offset: 0x00305A74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007C40 RID: 31808 RVA: 0x00307884 File Offset: 0x00305A84
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CharacterBasicInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							Character.Types.CharacterBasicInformation.LevelDefaultValue = 0;
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 3:
							Character.Types.CharacterBasicInformation._parser = new MessageParser<Character.Types.CharacterBasicInformation>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
							{
								num2 = 2;
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

				// Token: 0x06007C41 RID: 31809 RVA: 0x00307990 File Offset: 0x00305B90
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool zmabubGuntBs3eP0y2eo()
				{
					return true;
				}

				// Token: 0x06007C42 RID: 31810 RVA: 0x00307998 File Offset: 0x00305B98
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static Character.Types.CharacterBasicInformation CYvq7rGumx2w2RVMZEb1()
				{
					return null;
				}

				// Token: 0x04002CA3 RID: 11427
				private static readonly MessageParser<Character.Types.CharacterBasicInformation> _parser;

				// Token: 0x04002CA4 RID: 11428
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002CA5 RID: 11429
				private int _hasBits0;

				// Token: 0x04002CA6 RID: 11430
				public const int NameFieldNumber = 1;

				// Token: 0x04002CA7 RID: 11431
				private string name_;

				// Token: 0x04002CA8 RID: 11432
				public const int LevelFieldNumber = 2;

				// Token: 0x04002CA9 RID: 11433
				private static readonly int LevelDefaultValue;

				// Token: 0x04002CAA RID: 11434
				private int level_;

				// Token: 0x04002CAB RID: 11435
				public const int CharacterLookFieldNumber = 4;

				// Token: 0x04002CAC RID: 11436
				public const int RankFieldNumber = 5;

				// Token: 0x04002CAD RID: 11437
				public const int SocialMemberFieldNumber = 6;

				// Token: 0x04002CAE RID: 11438
				private object complement_;

				// Token: 0x04002CAF RID: 11439
				private Character.Types.CharacterBasicInformation.ComplementOneofCase complementCase_;

				// Token: 0x04002CB0 RID: 11440
				private static Character.Types.CharacterBasicInformation qGxbgEGuf9f2F0wDCfos;

				// Token: 0x02000A2C RID: 2604
				public enum ComplementOneofCase
				{
					// Token: 0x04002CB2 RID: 11442
					None,
					// Token: 0x04002CB3 RID: 11443
					CharacterLook = 4,
					// Token: 0x04002CB4 RID: 11444
					Rank,
					// Token: 0x04002CB5 RID: 11445
					SocialMember
				}

				// Token: 0x02000A2D RID: 2605
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x06007C43 RID: 31811 RVA: 0x003175BC File Offset: 0x003157BC
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000A2E RID: 2606
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SocialMember : IMessage<Character.Types.CharacterBasicInformation.Types.SocialMember>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.SocialMember>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.SocialMember>, IBufferMessage
					{
						// Token: 0x17001676 RID: 5750
						// (get) Token: 0x06007C44 RID: 31812 RVA: 0x0031D568 File Offset: 0x0031B768
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001677 RID: 5751
						// (get) Token: 0x06007C45 RID: 31813 RVA: 0x0031D578 File Offset: 0x0031B778
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

						// Token: 0x17001678 RID: 5752
						// (get) Token: 0x06007C46 RID: 31814 RVA: 0x0031D588 File Offset: 0x0031B788
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

						// Token: 0x06007C47 RID: 31815 RVA: 0x0031D598 File Offset: 0x0031B798
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SocialMember()
						{
						}

						// Token: 0x06007C48 RID: 31816 RVA: 0x0031D5A8 File Offset: 0x0031B7A8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SocialMember(Character.Types.CharacterBasicInformation.Types.SocialMember other)
						{
						}

						// Token: 0x06007C49 RID: 31817 RVA: 0x0031D5B8 File Offset: 0x0031B7B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Character.Types.CharacterBasicInformation.Types.SocialMember Clone()
						{
							return null;
						}

						// Token: 0x17001679 RID: 5753
						// (get) Token: 0x06007C4A RID: 31818 RVA: 0x0031D5C8 File Offset: 0x0031B7C8
						// (set) Token: 0x06007C4B RID: 31819 RVA: 0x0031D5D8 File Offset: 0x0031B7D8
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

						// Token: 0x1700167A RID: 5754
						// (get) Token: 0x06007C4C RID: 31820 RVA: 0x0031D5E8 File Offset: 0x0031B7E8
						// (set) Token: 0x06007C4D RID: 31821 RVA: 0x0031D5FC File Offset: 0x0031B7FC
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

						// Token: 0x1700167B RID: 5755
						// (get) Token: 0x06007C4E RID: 31822 RVA: 0x0031D60C File Offset: 0x0031B80C
						// (set) Token: 0x06007C4F RID: 31823 RVA: 0x0031D620 File Offset: 0x0031B820
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public CharacterState State
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (CharacterState)null;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x1700167C RID: 5756
						// (get) Token: 0x06007C50 RID: 31824 RVA: 0x0031D630 File Offset: 0x0031B830
						// (set) Token: 0x06007C51 RID: 31825 RVA: 0x0031D640 File Offset: 0x0031B840
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public long HoursSinceLastConnection
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

						// Token: 0x1700167D RID: 5757
						// (get) Token: 0x06007C52 RID: 31826 RVA: 0x0031D650 File Offset: 0x0031B850
						// (set) Token: 0x06007C53 RID: 31827 RVA: 0x0031D660 File Offset: 0x0031B860
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

						// Token: 0x1700167E RID: 5758
						// (get) Token: 0x06007C54 RID: 31828 RVA: 0x0031D670 File Offset: 0x0031B870
						// (set) Token: 0x06007C55 RID: 31829 RVA: 0x0031D680 File Offset: 0x0031B880
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
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

						// Token: 0x1700167F RID: 5759
						// (get) Token: 0x06007C56 RID: 31830 RVA: 0x0031D690 File Offset: 0x0031B890
						// (set) Token: 0x06007C57 RID: 31831 RVA: 0x0031D6A0 File Offset: 0x0031B8A0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int RankId
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

						// Token: 0x17001680 RID: 5760
						// (get) Token: 0x06007C58 RID: 31832 RVA: 0x0031D6B0 File Offset: 0x0031B8B0
						// (set) Token: 0x06007C59 RID: 31833 RVA: 0x0031D6C0 File Offset: 0x0031B8C0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public long EnrollmentDate
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

						// Token: 0x17001681 RID: 5761
						// (get) Token: 0x06007C5A RID: 31834 RVA: 0x0031D6D0 File Offset: 0x0031B8D0
						// (set) Token: 0x06007C5B RID: 31835 RVA: 0x0031D6E0 File Offset: 0x0031B8E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int AvaRoleId
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

						// Token: 0x17001682 RID: 5762
						// (get) Token: 0x06007C5C RID: 31836 RVA: 0x0031D6F0 File Offset: 0x0031B8F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public bool HasAvaRoleId
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
						}

						// Token: 0x06007C5D RID: 31837 RVA: 0x0031D700 File Offset: 0x0031B900
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearAvaRoleId()
						{
						}

						// Token: 0x17001683 RID: 5763
						// (get) Token: 0x06007C5E RID: 31838 RVA: 0x0031D710 File Offset: 0x0031B910
						// (set) Token: 0x06007C5F RID: 31839 RVA: 0x0031D720 File Offset: 0x0031B920
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember GuildMember
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

						// Token: 0x06007C60 RID: 31840 RVA: 0x0031D730 File Offset: 0x0031B930
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06007C61 RID: 31841 RVA: 0x0031D740 File Offset: 0x0031B940
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(Character.Types.CharacterBasicInformation.Types.SocialMember other)
						{
							return true;
						}

						// Token: 0x06007C62 RID: 31842 RVA: 0x0031D750 File Offset: 0x0031B950
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06007C63 RID: 31843 RVA: 0x0031D760 File Offset: 0x0031B960
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06007C64 RID: 31844 RVA: 0x0031D770 File Offset: 0x0031B970
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06007C65 RID: 31845 RVA: 0x0031D780 File Offset: 0x0031B980
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06007C66 RID: 31846 RVA: 0x0031D790 File Offset: 0x0031B990
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06007C67 RID: 31847 RVA: 0x0031D7A0 File Offset: 0x0031B9A0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(Character.Types.CharacterBasicInformation.Types.SocialMember other)
						{
						}

						// Token: 0x06007C68 RID: 31848 RVA: 0x0031D7B0 File Offset: 0x0031B9B0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06007C69 RID: 31849 RVA: 0x0031D7C0 File Offset: 0x0031B9C0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06007C6A RID: 31850 RVA: 0x0031D7D0 File Offset: 0x0031B9D0
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SocialMember()
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
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 2:
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 3:
										goto IL_62;
									case 4:
										return;
									case 5:
										Character.Types.CharacterBasicInformation.Types.SocialMember._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember>(() => null);
										num2 = 3;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
										{
											num2 = 3;
											continue;
										}
										continue;
									}
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 5;
								}
								IL_62:
								Character.Types.CharacterBasicInformation.Types.SocialMember.AvaRoleIdDefaultValue = 0;
								num = 4;
							}
						}

						// Token: 0x06007C6B RID: 31851 RVA: 0x0031D8CC File Offset: 0x0031BACC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool t7Z01NgJ6BgJcSQIlgkU()
						{
							return true;
						}

						// Token: 0x06007C6C RID: 31852 RVA: 0x0031D8D4 File Offset: 0x0031BAD4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static Character.Types.CharacterBasicInformation.Types.SocialMember TFb7ocgJLbB16WpbQnlK()
						{
							return null;
						}

						// Token: 0x04002CB6 RID: 11446
						private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember> _parser;

						// Token: 0x04002CB7 RID: 11447
						private UnknownFieldSet _unknownFields;

						// Token: 0x04002CB8 RID: 11448
						private int _hasBits0;

						// Token: 0x04002CB9 RID: 11449
						public const int BreedIdFieldNumber = 1;

						// Token: 0x04002CBA RID: 11450
						private int breedId_;

						// Token: 0x04002CBB RID: 11451
						public const int GenderFieldNumber = 2;

						// Token: 0x04002CBC RID: 11452
						private Gender gender_;

						// Token: 0x04002CBD RID: 11453
						public const int StateFieldNumber = 3;

						// Token: 0x04002CBE RID: 11454
						private CharacterState state_;

						// Token: 0x04002CBF RID: 11455
						public const int HoursSinceLastConnectionFieldNumber = 4;

						// Token: 0x04002CC0 RID: 11456
						private long hoursSinceLastConnection_;

						// Token: 0x04002CC1 RID: 11457
						public const int AccountIdFieldNumber = 5;

						// Token: 0x04002CC2 RID: 11458
						private long accountId_;

						// Token: 0x04002CC3 RID: 11459
						public const int StatusFieldNumber = 6;

						// Token: 0x04002CC4 RID: 11460
						private CharacterStatus status_;

						// Token: 0x04002CC5 RID: 11461
						public const int RankIdFieldNumber = 7;

						// Token: 0x04002CC6 RID: 11462
						private int rankId_;

						// Token: 0x04002CC7 RID: 11463
						public const int EnrollmentDateFieldNumber = 8;

						// Token: 0x04002CC8 RID: 11464
						private long enrollmentDate_;

						// Token: 0x04002CC9 RID: 11465
						public const int AvaRoleIdFieldNumber = 9;

						// Token: 0x04002CCA RID: 11466
						private static readonly int AvaRoleIdDefaultValue;

						// Token: 0x04002CCB RID: 11467
						private int avaRoleId_;

						// Token: 0x04002CCC RID: 11468
						public const int GuildMemberFieldNumber = 10;

						// Token: 0x04002CCD RID: 11469
						private Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember guildMember_;

						// Token: 0x04002CCE RID: 11470
						internal static Character.Types.CharacterBasicInformation.Types.SocialMember Nb277WgJy8IfXIQv6vVy;

						// Token: 0x02000A2F RID: 2607
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x06007C6D RID: 31853 RVA: 0x00321938 File Offset: 0x0031FB38
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x02000A30 RID: 2608
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class GuildMember : IMessage<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember>, IBufferMessage
							{
								// Token: 0x17001684 RID: 5764
								// (get) Token: 0x06007C6E RID: 31854 RVA: 0x003245A0 File Offset: 0x003227A0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17001685 RID: 5765
								// (get) Token: 0x06007C6F RID: 31855 RVA: 0x003245B0 File Offset: 0x003227B0
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

								// Token: 0x17001686 RID: 5766
								// (get) Token: 0x06007C70 RID: 31856 RVA: 0x003245C0 File Offset: 0x003227C0
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

								// Token: 0x06007C71 RID: 31857 RVA: 0x003245D0 File Offset: 0x003227D0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public GuildMember()
								{
								}

								// Token: 0x06007C72 RID: 31858 RVA: 0x003245E0 File Offset: 0x003227E0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public GuildMember(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember other)
								{
								}

								// Token: 0x06007C73 RID: 31859 RVA: 0x003245F0 File Offset: 0x003227F0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember Clone()
								{
									return null;
								}

								// Token: 0x17001687 RID: 5767
								// (get) Token: 0x06007C74 RID: 31860 RVA: 0x00324600 File Offset: 0x00322800
								// (set) Token: 0x06007C75 RID: 31861 RVA: 0x00324610 File Offset: 0x00322810
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public long GivenExperience
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

								// Token: 0x17001688 RID: 5768
								// (get) Token: 0x06007C76 RID: 31862 RVA: 0x00324620 File Offset: 0x00322820
								// (set) Token: 0x06007C77 RID: 31863 RVA: 0x00324630 File Offset: 0x00322830
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int ExperienceGivenPercent
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

								// Token: 0x17001689 RID: 5769
								// (get) Token: 0x06007C78 RID: 31864 RVA: 0x00324640 File Offset: 0x00322840
								// (set) Token: 0x06007C79 RID: 31865 RVA: 0x00324654 File Offset: 0x00322854
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

								// Token: 0x1700168A RID: 5770
								// (get) Token: 0x06007C7A RID: 31866 RVA: 0x00324664 File Offset: 0x00322864
								// (set) Token: 0x06007C7B RID: 31867 RVA: 0x00324674 File Offset: 0x00322874
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int MoodSmileyId
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

								// Token: 0x1700168B RID: 5771
								// (get) Token: 0x06007C7C RID: 31868 RVA: 0x00324684 File Offset: 0x00322884
								// (set) Token: 0x06007C7D RID: 31869 RVA: 0x00324694 File Offset: 0x00322894
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int AchievementPoints
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

								// Token: 0x1700168C RID: 5772
								// (get) Token: 0x06007C7E RID: 31870 RVA: 0x003246A4 File Offset: 0x003228A4
								// (set) Token: 0x06007C7F RID: 31871 RVA: 0x003246B4 File Offset: 0x003228B4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public bool HavenBagShared
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

								// Token: 0x1700168D RID: 5773
								// (get) Token: 0x06007C80 RID: 31872 RVA: 0x003246C4 File Offset: 0x003228C4
								// (set) Token: 0x06007C81 RID: 31873 RVA: 0x003246D4 File Offset: 0x003228D4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote Note
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

								// Token: 0x06007C82 RID: 31874 RVA: 0x003246E4 File Offset: 0x003228E4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007C83 RID: 31875 RVA: 0x003246F4 File Offset: 0x003228F4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember other)
								{
									return true;
								}

								// Token: 0x06007C84 RID: 31876 RVA: 0x00324704 File Offset: 0x00322904
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06007C85 RID: 31877 RVA: 0x00324714 File Offset: 0x00322914
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06007C86 RID: 31878 RVA: 0x00324724 File Offset: 0x00322924
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06007C87 RID: 31879 RVA: 0x00324734 File Offset: 0x00322934
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06007C88 RID: 31880 RVA: 0x00324744 File Offset: 0x00322944
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06007C89 RID: 31881 RVA: 0x00324754 File Offset: 0x00322954
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember other)
								{
								}

								// Token: 0x06007C8A RID: 31882 RVA: 0x00324764 File Offset: 0x00322964
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007C8B RID: 31883 RVA: 0x00324774 File Offset: 0x00322974
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007C8C RID: 31884 RVA: 0x00324784 File Offset: 0x00322984
								[MethodImpl(MethodImplOptions.NoInlining)]
								static GuildMember()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											return;
										case 3:
											Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember>(() => null);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 4:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
											{
												num2 = 3;
												continue;
											}
											continue;
										}
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 4;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
										{
											num2 = 2;
										}
									}
								}

								// Token: 0x06007C8D RID: 31885 RVA: 0x0032487C File Offset: 0x00322A7C
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool YMGQFtgduAAhh6YSdDLy()
								{
									return true;
								}

								// Token: 0x06007C8E RID: 31886 RVA: 0x00324884 File Offset: 0x00322A84
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember qTMak9gd8ntOtuqBnuGO()
								{
									return null;
								}

								// Token: 0x04002CCF RID: 11471
								private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember> _parser;

								// Token: 0x04002CD0 RID: 11472
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002CD1 RID: 11473
								public const int GivenExperienceFieldNumber = 1;

								// Token: 0x04002CD2 RID: 11474
								private long givenExperience_;

								// Token: 0x04002CD3 RID: 11475
								public const int ExperienceGivenPercentFieldNumber = 2;

								// Token: 0x04002CD4 RID: 11476
								private int experienceGivenPercent_;

								// Token: 0x04002CD5 RID: 11477
								public const int AlignmentFieldNumber = 3;

								// Token: 0x04002CD6 RID: 11478
								private Alignment alignment_;

								// Token: 0x04002CD7 RID: 11479
								public const int MoodSmileyIdFieldNumber = 4;

								// Token: 0x04002CD8 RID: 11480
								private int moodSmileyId_;

								// Token: 0x04002CD9 RID: 11481
								public const int AchievementPointsFieldNumber = 5;

								// Token: 0x04002CDA RID: 11482
								private int achievementPoints_;

								// Token: 0x04002CDB RID: 11483
								public const int HavenBagSharedFieldNumber = 6;

								// Token: 0x04002CDC RID: 11484
								private bool havenBagShared_;

								// Token: 0x04002CDD RID: 11485
								public const int NoteFieldNumber = 7;

								// Token: 0x04002CDE RID: 11486
								private Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote note_;

								// Token: 0x04002CDF RID: 11487
								private static Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember cOH8GHgdMVxIWYYsrh4v;

								// Token: 0x02000A31 RID: 2609
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public static class Types
								{
									// Token: 0x06007C8F RID: 31887 RVA: 0x003258B0 File Offset: 0x00323AB0
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x02000A32 RID: 2610
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class PlayerNote : IMessage<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote>, IBufferMessage
									{
										// Token: 0x1700168E RID: 5774
										// (get) Token: 0x06007C90 RID: 31888 RVA: 0x00326F6C File Offset: 0x0032516C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700168F RID: 5775
										// (get) Token: 0x06007C91 RID: 31889 RVA: 0x00326F7C File Offset: 0x0032517C
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

										// Token: 0x17001690 RID: 5776
										// (get) Token: 0x06007C92 RID: 31890 RVA: 0x00326F8C File Offset: 0x0032518C
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

										// Token: 0x06007C93 RID: 31891 RVA: 0x00326F9C File Offset: 0x0032519C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PlayerNote()
										{
										}

										// Token: 0x06007C94 RID: 31892 RVA: 0x00326FAC File Offset: 0x003251AC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PlayerNote(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote other)
										{
										}

										// Token: 0x06007C95 RID: 31893 RVA: 0x00326FBC File Offset: 0x003251BC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote Clone()
										{
											return null;
										}

										// Token: 0x17001691 RID: 5777
										// (get) Token: 0x06007C96 RID: 31894 RVA: 0x00326FCC File Offset: 0x003251CC
										// (set) Token: 0x06007C97 RID: 31895 RVA: 0x00326FDC File Offset: 0x003251DC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public string Content
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

										// Token: 0x17001692 RID: 5778
										// (get) Token: 0x06007C98 RID: 31896 RVA: 0x00326FEC File Offset: 0x003251EC
										// (set) Token: 0x06007C99 RID: 31897 RVA: 0x00326FFC File Offset: 0x003251FC
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public long LastEditDate
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

										// Token: 0x06007C9A RID: 31898 RVA: 0x0032700C File Offset: 0x0032520C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007C9B RID: 31899 RVA: 0x0032701C File Offset: 0x0032521C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote other)
										{
											return true;
										}

										// Token: 0x06007C9C RID: 31900 RVA: 0x0032702C File Offset: 0x0032522C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007C9D RID: 31901 RVA: 0x0032703C File Offset: 0x0032523C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007C9E RID: 31902 RVA: 0x0032704C File Offset: 0x0032524C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007C9F RID: 31903 RVA: 0x0032705C File Offset: 0x0032525C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007CA0 RID: 31904 RVA: 0x0032706C File Offset: 0x0032526C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007CA1 RID: 31905 RVA: 0x0032707C File Offset: 0x0032527C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote other)
										{
										}

										// Token: 0x06007CA2 RID: 31906 RVA: 0x0032708C File Offset: 0x0032528C
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007CA3 RID: 31907 RVA: 0x0032709C File Offset: 0x0032529C
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007CA4 RID: 31908 RVA: 0x003270AC File Offset: 0x003252AC
										[MethodImpl(MethodImplOptions.NoInlining)]
										static PlayerNote()
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
													num2 = 2;
													continue;
												case 2:
													Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote>(() => null);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 3:
													AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
													{
														num2 = 1;
														continue;
													}
													continue;
												case 4:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 2;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
													{
														num2 = 3;
														continue;
													}
													continue;
												}
												break;
											}
										}

										// Token: 0x06007CA5 RID: 31909 RVA: 0x00327190 File Offset: 0x00325390
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool POjgy5g2HS2iJyXREJQa()
										{
											return true;
										}

										// Token: 0x06007CA6 RID: 31910 RVA: 0x00327198 File Offset: 0x00325398
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote uC3WG0g2YNvTmkqoIT2o()
										{
											return null;
										}

										// Token: 0x04002CE0 RID: 11488
										private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote> _parser;

										// Token: 0x04002CE1 RID: 11489
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002CE2 RID: 11490
										public const int ContentFieldNumber = 1;

										// Token: 0x04002CE3 RID: 11491
										private string content_;

										// Token: 0x04002CE4 RID: 11492
										public const int LastEditDateFieldNumber = 2;

										// Token: 0x04002CE5 RID: 11493
										private long lastEditDate_;

										// Token: 0x04002CE6 RID: 11494
										internal static Character.Types.CharacterBasicInformation.Types.SocialMember.Types.GuildMember.Types.PlayerNote f1LtVUg2prHRMWvQABPo;
									}
								}
							}
						}
					}

					// Token: 0x02000A36 RID: 2614
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class CharacterLook : IMessage<Character.Types.CharacterBasicInformation.Types.CharacterLook>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.CharacterLook>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.CharacterLook>, IBufferMessage
					{
						// Token: 0x17001693 RID: 5779
						// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x0031D8DC File Offset: 0x0031BADC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001694 RID: 5780
						// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x0031D8EC File Offset: 0x0031BAEC
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

						// Token: 0x17001695 RID: 5781
						// (get) Token: 0x06007CB8 RID: 31928 RVA: 0x0031D8FC File Offset: 0x0031BAFC
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

						// Token: 0x06007CB9 RID: 31929 RVA: 0x0031D90C File Offset: 0x0031BB0C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public CharacterLook()
						{
						}

						// Token: 0x06007CBA RID: 31930 RVA: 0x0031D91C File Offset: 0x0031BB1C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public CharacterLook(Character.Types.CharacterBasicInformation.Types.CharacterLook other)
						{
						}

						// Token: 0x06007CBB RID: 31931 RVA: 0x0031D92C File Offset: 0x0031BB2C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Character.Types.CharacterBasicInformation.Types.CharacterLook Clone()
						{
							return null;
						}

						// Token: 0x17001696 RID: 5782
						// (get) Token: 0x06007CBC RID: 31932 RVA: 0x0031D93C File Offset: 0x0031BB3C
						// (set) Token: 0x06007CBD RID: 31933 RVA: 0x0031D94C File Offset: 0x0031BB4C
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

						// Token: 0x17001697 RID: 5783
						// (get) Token: 0x06007CBE RID: 31934 RVA: 0x0031D95C File Offset: 0x0031BB5C
						// (set) Token: 0x06007CBF RID: 31935 RVA: 0x0031D96C File Offset: 0x0031BB6C
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

						// Token: 0x17001698 RID: 5784
						// (get) Token: 0x06007CC0 RID: 31936 RVA: 0x0031D97C File Offset: 0x0031BB7C
						// (set) Token: 0x06007CC1 RID: 31937 RVA: 0x0031D98C File Offset: 0x0031BB8C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
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

						// Token: 0x17001699 RID: 5785
						// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x0031D99C File Offset: 0x0031BB9C
						// (set) Token: 0x06007CC3 RID: 31939 RVA: 0x0031D9AC File Offset: 0x0031BBAC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
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

						// Token: 0x1700169A RID: 5786
						// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x0031D9BC File Offset: 0x0031BBBC
						// (set) Token: 0x06007CC5 RID: 31941 RVA: 0x0031D9CC File Offset: 0x0031BBCC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int Grade
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

						// Token: 0x1700169B RID: 5787
						// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x0031D9DC File Offset: 0x0031BBDC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool HasGrade
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
						}

						// Token: 0x06007CC7 RID: 31943 RVA: 0x0031D9EC File Offset: 0x0031BBEC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearGrade()
						{
						}

						// Token: 0x1700169C RID: 5788
						// (get) Token: 0x06007CC8 RID: 31944 RVA: 0x0031D9FC File Offset: 0x0031BBFC
						// (set) Token: 0x06007CC9 RID: 31945 RVA: 0x0031DA0C File Offset: 0x0031BC0C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation BaseInformation
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

						// Token: 0x1700169D RID: 5789
						// (get) Token: 0x06007CCA RID: 31946 RVA: 0x0031DA1C File Offset: 0x0031BC1C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public Character.Types.CharacterBasicInformation.Types.CharacterLook.ComplementOneofCase ComplementCase
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (Character.Types.CharacterBasicInformation.Types.CharacterLook.ComplementOneofCase)null;
							}
						}

						// Token: 0x06007CCB RID: 31947 RVA: 0x0031DA30 File Offset: 0x0031BC30
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearComplement()
						{
						}

						// Token: 0x06007CCC RID: 31948 RVA: 0x0031DA40 File Offset: 0x0031BC40
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06007CCD RID: 31949 RVA: 0x0031DA50 File Offset: 0x0031BC50
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(Character.Types.CharacterBasicInformation.Types.CharacterLook other)
						{
							return true;
						}

						// Token: 0x06007CCE RID: 31950 RVA: 0x0031DA60 File Offset: 0x0031BC60
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06007CCF RID: 31951 RVA: 0x0031DA70 File Offset: 0x0031BC70
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06007CD0 RID: 31952 RVA: 0x0031DA80 File Offset: 0x0031BC80
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06007CD1 RID: 31953 RVA: 0x0031DA90 File Offset: 0x0031BC90
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06007CD2 RID: 31954 RVA: 0x0031DAA0 File Offset: 0x0031BCA0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06007CD3 RID: 31955 RVA: 0x0031DAB0 File Offset: 0x0031BCB0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(Character.Types.CharacterBasicInformation.Types.CharacterLook other)
						{
						}

						// Token: 0x06007CD4 RID: 31956 RVA: 0x0031DAC0 File Offset: 0x0031BCC0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06007CD5 RID: 31957 RVA: 0x0031DAD0 File Offset: 0x0031BCD0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06007CD6 RID: 31958 RVA: 0x0031DAE0 File Offset: 0x0031BCE0
						[MethodImpl(MethodImplOptions.NoInlining)]
						static CharacterLook()
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
									continue;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								Character.Types.CharacterBasicInformation.Types.CharacterLook._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook>(() => null);
								num2 = 3;
							}
						}

						// Token: 0x06007CD7 RID: 31959 RVA: 0x0031DBAC File Offset: 0x0031BDAC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool mTwHlwgJh0nu6Xeahij9()
						{
							return true;
						}

						// Token: 0x06007CD8 RID: 31960 RVA: 0x0031DBB4 File Offset: 0x0031BDB4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static Character.Types.CharacterBasicInformation.Types.CharacterLook AAYLyngJraoO3S0NvNn3()
						{
							return null;
						}

						// Token: 0x04002CED RID: 11501
						private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook> _parser;

						// Token: 0x04002CEE RID: 11502
						private UnknownFieldSet _unknownFields;

						// Token: 0x04002CEF RID: 11503
						public const int LookFieldNumber = 1;

						// Token: 0x04002CF0 RID: 11504
						private EntityLook look_;

						// Token: 0x04002CF1 RID: 11505
						public const int BreedIdFieldNumber = 2;

						// Token: 0x04002CF2 RID: 11506
						private int breedId_;

						// Token: 0x04002CF3 RID: 11507
						public const int GuildInformationFieldNumber = 3;

						// Token: 0x04002CF4 RID: 11508
						public const int AllianceInformationFieldNumber = 4;

						// Token: 0x04002CF5 RID: 11509
						public const int GradeFieldNumber = 5;

						// Token: 0x04002CF6 RID: 11510
						public const int BaseInformationFieldNumber = 6;

						// Token: 0x04002CF7 RID: 11511
						private object complement_;

						// Token: 0x04002CF8 RID: 11512
						private Character.Types.CharacterBasicInformation.Types.CharacterLook.ComplementOneofCase complementCase_;

						// Token: 0x04002CF9 RID: 11513
						private static Character.Types.CharacterBasicInformation.Types.CharacterLook ePuKWBgJWDCYSGuZi0hD;

						// Token: 0x02000A37 RID: 2615
						public enum ComplementOneofCase
						{
							// Token: 0x04002CFB RID: 11515
							None,
							// Token: 0x04002CFC RID: 11516
							GuildInformation = 3,
							// Token: 0x04002CFD RID: 11517
							AllianceInformation,
							// Token: 0x04002CFE RID: 11518
							Grade,
							// Token: 0x04002CFF RID: 11519
							BaseInformation
						}

						// Token: 0x02000A38 RID: 2616
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x06007CD9 RID: 31961 RVA: 0x00321A5C File Offset: 0x0031FC5C
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x02000A39 RID: 2617
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class CharacterBaseInformation : IMessage<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation>, IBufferMessage
							{
								// Token: 0x1700169E RID: 5790
								// (get) Token: 0x06007CDA RID: 31962 RVA: 0x0032488C File Offset: 0x00322A8C
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x1700169F RID: 5791
								// (get) Token: 0x06007CDB RID: 31963 RVA: 0x0032489C File Offset: 0x00322A9C
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

								// Token: 0x170016A0 RID: 5792
								// (get) Token: 0x06007CDC RID: 31964 RVA: 0x003248AC File Offset: 0x00322AAC
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

								// Token: 0x06007CDD RID: 31965 RVA: 0x003248BC File Offset: 0x00322ABC
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public CharacterBaseInformation()
								{
								}

								// Token: 0x06007CDE RID: 31966 RVA: 0x003248CC File Offset: 0x00322ACC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public CharacterBaseInformation(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation other)
								{
								}

								// Token: 0x06007CDF RID: 31967 RVA: 0x003248DC File Offset: 0x00322ADC
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation Clone()
								{
									return null;
								}

								// Token: 0x170016A1 RID: 5793
								// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x003248EC File Offset: 0x00322AEC
								// (set) Token: 0x06007CE1 RID: 31969 RVA: 0x00324900 File Offset: 0x00322B00
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

								// Token: 0x170016A2 RID: 5794
								// (get) Token: 0x06007CE2 RID: 31970 RVA: 0x00324910 File Offset: 0x00322B10
								// (set) Token: 0x06007CE3 RID: 31971 RVA: 0x00324920 File Offset: 0x00322B20
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation EpicInformation
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

								// Token: 0x170016A3 RID: 5795
								// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x00324930 File Offset: 0x00322B30
								// (set) Token: 0x06007CE5 RID: 31973 RVA: 0x00324940 File Offset: 0x00322B40
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation PartyMemberInformation
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

								// Token: 0x170016A4 RID: 5796
								// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x00324950 File Offset: 0x00322B50
								// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x00324960 File Offset: 0x00322B60
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation PartyInvitationMemberInformation
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

								// Token: 0x170016A5 RID: 5797
								// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x00324970 File Offset: 0x00322B70
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.ComplementOneofCase ComplementCase
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.ComplementOneofCase)null;
									}
								}

								// Token: 0x06007CE9 RID: 31977 RVA: 0x00324984 File Offset: 0x00322B84
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void ClearComplement()
								{
								}

								// Token: 0x06007CEA RID: 31978 RVA: 0x00324994 File Offset: 0x00322B94
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06007CEB RID: 31979 RVA: 0x003249A4 File Offset: 0x00322BA4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation other)
								{
									return true;
								}

								// Token: 0x06007CEC RID: 31980 RVA: 0x003249B4 File Offset: 0x00322BB4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06007CED RID: 31981 RVA: 0x003249C4 File Offset: 0x00322BC4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06007CEE RID: 31982 RVA: 0x003249D4 File Offset: 0x00322BD4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06007CEF RID: 31983 RVA: 0x003249E4 File Offset: 0x00322BE4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06007CF0 RID: 31984 RVA: 0x003249F4 File Offset: 0x00322BF4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06007CF1 RID: 31985 RVA: 0x00324A04 File Offset: 0x00322C04
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation other)
								{
								}

								// Token: 0x06007CF2 RID: 31986 RVA: 0x00324A14 File Offset: 0x00322C14
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06007CF3 RID: 31987 RVA: 0x00324A24 File Offset: 0x00322C24
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06007CF4 RID: 31988 RVA: 0x00324A34 File Offset: 0x00322C34
								[MethodImpl(MethodImplOptions.NoInlining)]
								static CharacterBaseInformation()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											return;
										case 3:
											Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation>(() => null);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
											{
												num2 = 0;
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

								// Token: 0x06007CF5 RID: 31989 RVA: 0x00324B00 File Offset: 0x00322D00
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool I4mMO2gdqRYiFfL7nSlO()
								{
									return true;
								}

								// Token: 0x06007CF6 RID: 31990 RVA: 0x00324B08 File Offset: 0x00322D08
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation WasCvdgdFHvkmC1UP65d()
								{
									return null;
								}

								// Token: 0x04002D00 RID: 11520
								private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation> _parser;

								// Token: 0x04002D01 RID: 11521
								private UnknownFieldSet _unknownFields;

								// Token: 0x04002D02 RID: 11522
								public const int GenderFieldNumber = 1;

								// Token: 0x04002D03 RID: 11523
								private Gender gender_;

								// Token: 0x04002D04 RID: 11524
								public const int EpicInformationFieldNumber = 2;

								// Token: 0x04002D05 RID: 11525
								public const int PartyMemberInformationFieldNumber = 3;

								// Token: 0x04002D06 RID: 11526
								public const int PartyInvitationMemberInformationFieldNumber = 4;

								// Token: 0x04002D07 RID: 11527
								private object complement_;

								// Token: 0x04002D08 RID: 11528
								private Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.ComplementOneofCase complementCase_;

								// Token: 0x04002D09 RID: 11529
								internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation HQ0WpwgdZeQnLxQTnWO8;

								// Token: 0x02000A3A RID: 2618
								public enum ComplementOneofCase
								{
									// Token: 0x04002D0B RID: 11531
									None,
									// Token: 0x04002D0C RID: 11532
									EpicInformation = 2,
									// Token: 0x04002D0D RID: 11533
									PartyMemberInformation,
									// Token: 0x04002D0E RID: 11534
									PartyInvitationMemberInformation
								}

								// Token: 0x02000A3B RID: 2619
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static class Types
								{
									// Token: 0x06007CF7 RID: 31991 RVA: 0x003259C0 File Offset: 0x00323BC0
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x02000A3C RID: 2620
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class CharacterEpicInformation : IMessage<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation>, IBufferMessage
									{
										// Token: 0x170016A6 RID: 5798
										// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x003271A0 File Offset: 0x003253A0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170016A7 RID: 5799
										// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x003271B0 File Offset: 0x003253B0
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

										// Token: 0x170016A8 RID: 5800
										// (get) Token: 0x06007CFA RID: 31994 RVA: 0x003271C0 File Offset: 0x003253C0
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

										// Token: 0x06007CFB RID: 31995 RVA: 0x003271D0 File Offset: 0x003253D0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public CharacterEpicInformation()
										{
										}

										// Token: 0x06007CFC RID: 31996 RVA: 0x003271E0 File Offset: 0x003253E0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public CharacterEpicInformation(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation other)
										{
										}

										// Token: 0x06007CFD RID: 31997 RVA: 0x003271F0 File Offset: 0x003253F0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation Clone()
										{
											return null;
										}

										// Token: 0x170016A9 RID: 5801
										// (get) Token: 0x06007CFE RID: 31998 RVA: 0x00327200 File Offset: 0x00325400
										// (set) Token: 0x06007CFF RID: 31999 RVA: 0x00327214 File Offset: 0x00325414
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation.Types.EpicDeathState DeathState
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return (Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation.Types.EpicDeathState)null;
											}
											[MethodImpl(MethodImplOptions.NoInlining)]
											set
											{
											}
										}

										// Token: 0x170016AA RID: 5802
										// (get) Token: 0x06007D00 RID: 32000 RVA: 0x00327224 File Offset: 0x00325424
										// (set) Token: 0x06007D01 RID: 32001 RVA: 0x00327234 File Offset: 0x00325434
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int DeathCount
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

										// Token: 0x170016AB RID: 5803
										// (get) Token: 0x06007D02 RID: 32002 RVA: 0x00327244 File Offset: 0x00325444
										// (set) Token: 0x06007D03 RID: 32003 RVA: 0x00327254 File Offset: 0x00325454
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int DeathMaxLevel
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

										// Token: 0x06007D04 RID: 32004 RVA: 0x00327264 File Offset: 0x00325464
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007D05 RID: 32005 RVA: 0x00327274 File Offset: 0x00325474
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation other)
										{
											return true;
										}

										// Token: 0x06007D06 RID: 32006 RVA: 0x00327284 File Offset: 0x00325484
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007D07 RID: 32007 RVA: 0x00327294 File Offset: 0x00325494
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007D08 RID: 32008 RVA: 0x003272A4 File Offset: 0x003254A4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007D09 RID: 32009 RVA: 0x003272B4 File Offset: 0x003254B4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007D0A RID: 32010 RVA: 0x003272C4 File Offset: 0x003254C4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007D0B RID: 32011 RVA: 0x003272D4 File Offset: 0x003254D4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation other)
										{
										}

										// Token: 0x06007D0C RID: 32012 RVA: 0x003272E4 File Offset: 0x003254E4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007D0D RID: 32013 RVA: 0x003272F4 File Offset: 0x003254F4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007D0E RID: 32014 RVA: 0x00327304 File Offset: 0x00325504
										[MethodImpl(MethodImplOptions.NoInlining)]
										static CharacterEpicInformation()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation>(() => null);
													num2 = 3;
													continue;
												case 3:
													return;
												case 4:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
													{
														num2 = 2;
														continue;
													}
													continue;
												}
												AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
												num2 = 4;
											}
										}

										// Token: 0x06007D0F RID: 32015 RVA: 0x003273D0 File Offset: 0x003255D0
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool diInwsg2inXIJGGiqjCE()
										{
											return true;
										}

										// Token: 0x06007D10 RID: 32016 RVA: 0x003273D8 File Offset: 0x003255D8
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation eO5XO2g2PKcuix73lOe7()
										{
											return null;
										}

										// Token: 0x04002D0F RID: 11535
										private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation> _parser;

										// Token: 0x04002D10 RID: 11536
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002D11 RID: 11537
										public const int DeathStateFieldNumber = 1;

										// Token: 0x04002D12 RID: 11538
										private Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation.Types.EpicDeathState deathState_;

										// Token: 0x04002D13 RID: 11539
										public const int DeathCountFieldNumber = 2;

										// Token: 0x04002D14 RID: 11540
										private int deathCount_;

										// Token: 0x04002D15 RID: 11541
										public const int DeathMaxLevelFieldNumber = 3;

										// Token: 0x04002D16 RID: 11542
										private int deathMaxLevel_;

										// Token: 0x04002D17 RID: 11543
										internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.CharacterEpicInformation b9YaRQg2bLOh5g1glWOD;

										// Token: 0x02000A3D RID: 2621
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static class Types
										{
											// Token: 0x06007D11 RID: 32017 RVA: 0x00328858 File Offset: 0x00326A58
											[MethodImpl(MethodImplOptions.NoInlining)]
											static Types()
											{
												uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
												xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											}

											// Token: 0x02000A3E RID: 2622
											public enum EpicDeathState
											{
												// Token: 0x04002D19 RID: 11545
												[OriginalName("DEATH_STATE_ALIVE")]
												DeathStateAlive,
												// Token: 0x04002D1A RID: 11546
												[OriginalName("DEATH_STATE_DEAD")]
												DeathStateDead,
												// Token: 0x04002D1B RID: 11547
												[OriginalName("DEATH_STATE_WAITING_CONFIRMATION")]
												DeathStateWaitingConfirmation
											}
										}
									}

									// Token: 0x02000A40 RID: 2624
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class PartyMemberInformation : IMessage<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation>, IBufferMessage
									{
										// Token: 0x170016AC RID: 5804
										// (get) Token: 0x06007D17 RID: 32023 RVA: 0x003273E0 File Offset: 0x003255E0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170016AD RID: 5805
										// (get) Token: 0x06007D18 RID: 32024 RVA: 0x003273F0 File Offset: 0x003255F0
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

										// Token: 0x170016AE RID: 5806
										// (get) Token: 0x06007D19 RID: 32025 RVA: 0x00327400 File Offset: 0x00325600
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

										// Token: 0x06007D1A RID: 32026 RVA: 0x00327410 File Offset: 0x00325610
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PartyMemberInformation()
										{
										}

										// Token: 0x06007D1B RID: 32027 RVA: 0x00327420 File Offset: 0x00325620
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PartyMemberInformation(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation other)
										{
										}

										// Token: 0x06007D1C RID: 32028 RVA: 0x00327430 File Offset: 0x00325630
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation Clone()
										{
											return null;
										}

										// Token: 0x170016AF RID: 5807
										// (get) Token: 0x06007D1D RID: 32029 RVA: 0x00327440 File Offset: 0x00325640
										// (set) Token: 0x06007D1E RID: 32030 RVA: 0x00327450 File Offset: 0x00325650
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public PartyUpdateCommonsInformation CommonsInformation
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

										// Token: 0x170016B0 RID: 5808
										// (get) Token: 0x06007D1F RID: 32031 RVA: 0x00327460 File Offset: 0x00325660
										// (set) Token: 0x06007D20 RID: 32032 RVA: 0x00327470 File Offset: 0x00325670
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int Initiative
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

										// Token: 0x170016B1 RID: 5809
										// (get) Token: 0x06007D21 RID: 32033 RVA: 0x00327480 File Offset: 0x00325680
										// (set) Token: 0x06007D22 RID: 32034 RVA: 0x00327494 File Offset: 0x00325694
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
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

										// Token: 0x170016B2 RID: 5810
										// (get) Token: 0x06007D23 RID: 32035 RVA: 0x003274A4 File Offset: 0x003256A4
										// (set) Token: 0x06007D24 RID: 32036 RVA: 0x003274B4 File Offset: 0x003256B4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public MapExtendedCoordinates Coordinates
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

										// Token: 0x170016B3 RID: 5811
										// (get) Token: 0x06007D25 RID: 32037 RVA: 0x003274C4 File Offset: 0x003256C4
										// (set) Token: 0x06007D26 RID: 32038 RVA: 0x003274D4 File Offset: 0x003256D4
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

										// Token: 0x170016B4 RID: 5812
										// (get) Token: 0x06007D27 RID: 32039 RVA: 0x003274E4 File Offset: 0x003256E4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public RepeatedField<PartyEntity> Entities
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170016B5 RID: 5813
										// (get) Token: 0x06007D28 RID: 32040 RVA: 0x003274F4 File Offset: 0x003256F4
										// (set) Token: 0x06007D29 RID: 32041 RVA: 0x00327504 File Offset: 0x00325704
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int Rank
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

										// Token: 0x170016B6 RID: 5814
										// (get) Token: 0x06007D2A RID: 32042 RVA: 0x00327514 File Offset: 0x00325714
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public bool HasRank
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return true;
											}
										}

										// Token: 0x06007D2B RID: 32043 RVA: 0x00327524 File Offset: 0x00325724
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void ClearRank()
										{
										}

										// Token: 0x06007D2C RID: 32044 RVA: 0x00327534 File Offset: 0x00325734
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007D2D RID: 32045 RVA: 0x00327544 File Offset: 0x00325744
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation other)
										{
											return true;
										}

										// Token: 0x06007D2E RID: 32046 RVA: 0x00327554 File Offset: 0x00325754
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007D2F RID: 32047 RVA: 0x00327564 File Offset: 0x00325764
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007D30 RID: 32048 RVA: 0x00327574 File Offset: 0x00325774
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007D31 RID: 32049 RVA: 0x00327584 File Offset: 0x00325784
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007D32 RID: 32050 RVA: 0x00327594 File Offset: 0x00325794
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007D33 RID: 32051 RVA: 0x003275A4 File Offset: 0x003257A4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation other)
										{
										}

										// Token: 0x06007D34 RID: 32052 RVA: 0x003275B4 File Offset: 0x003257B4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007D35 RID: 32053 RVA: 0x003275C4 File Offset: 0x003257C4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007D36 RID: 32054 RVA: 0x003275D4 File Offset: 0x003257D4
										[MethodImpl(MethodImplOptions.NoInlining)]
										static PartyMemberInformation()
										{
											uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
											int num = 3;
											for (;;)
											{
												int num2 = num;
												for (;;)
												{
													switch (num2)
													{
													case 1:
														goto IL_3E;
													case 2:
														AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
														num2 = 0;
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
														{
															num2 = 0;
															continue;
														}
														continue;
													case 3:
														xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
														num2 = 2;
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
														{
															num2 = 2;
															continue;
														}
														continue;
													case 4:
														return;
													case 5:
														Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation._repeated_entities_codec = FieldCodec.ForMessage<PartyEntity>(50U, cYYvTcn1ExwQJEKZCPPn.XVInXhlssT(cYYvTcn1ExwQJEKZCPPn.zJSn1Xk8R1C));
														num2 = 1;
														if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
														{
															num2 = 1;
															continue;
														}
														continue;
													case 6:
														Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation>(() => null);
														num2 = 5;
														continue;
													}
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 6;
												}
												IL_3E:
												Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation.RankDefaultValue = 0;
												num = 4;
											}
										}

										// Token: 0x06007D37 RID: 32055 RVA: 0x003276F4 File Offset: 0x003258F4
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool K3tK2hg2Mfl6w7mN6KJk()
										{
											return true;
										}

										// Token: 0x06007D38 RID: 32056 RVA: 0x003276FC File Offset: 0x003258FC
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation cqg5Phg2u05nxPuxd4Si()
										{
											return null;
										}

										// Token: 0x04002D1E RID: 11550
										private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation> _parser;

										// Token: 0x04002D1F RID: 11551
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002D20 RID: 11552
										private int _hasBits0;

										// Token: 0x04002D21 RID: 11553
										public const int CommonsInformationFieldNumber = 1;

										// Token: 0x04002D22 RID: 11554
										private PartyUpdateCommonsInformation commonsInformation_;

										// Token: 0x04002D23 RID: 11555
										public const int InitiativeFieldNumber = 2;

										// Token: 0x04002D24 RID: 11556
										private int initiative_;

										// Token: 0x04002D25 RID: 11557
										public const int AlignmentFieldNumber = 3;

										// Token: 0x04002D26 RID: 11558
										private Alignment alignment_;

										// Token: 0x04002D27 RID: 11559
										public const int CoordinatesFieldNumber = 4;

										// Token: 0x04002D28 RID: 11560
										private MapExtendedCoordinates coordinates_;

										// Token: 0x04002D29 RID: 11561
										public const int StatusFieldNumber = 5;

										// Token: 0x04002D2A RID: 11562
										private CharacterStatus status_;

										// Token: 0x04002D2B RID: 11563
										public const int EntitiesFieldNumber = 6;

										// Token: 0x04002D2C RID: 11564
										private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

										// Token: 0x04002D2D RID: 11565
										private readonly RepeatedField<PartyEntity> entities_;

										// Token: 0x04002D2E RID: 11566
										public const int RankFieldNumber = 7;

										// Token: 0x04002D2F RID: 11567
										private static readonly int RankDefaultValue;

										// Token: 0x04002D30 RID: 11568
										private int rank_;

										// Token: 0x04002D31 RID: 11569
										private static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyMemberInformation OAc44Mg2SbAhsx7TNnkv;
									}

									// Token: 0x02000A42 RID: 2626
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class PartyInvitationMemberInformation : IMessage<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation>, IMessage, IEquatable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation>, IDeepCloneable<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation>, IBufferMessage
									{
										// Token: 0x170016B7 RID: 5815
										// (get) Token: 0x06007D3E RID: 32062 RVA: 0x00327704 File Offset: 0x00325904
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x170016B8 RID: 5816
										// (get) Token: 0x06007D3F RID: 32063 RVA: 0x00327714 File Offset: 0x00325914
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

										// Token: 0x170016B9 RID: 5817
										// (get) Token: 0x06007D40 RID: 32064 RVA: 0x00327724 File Offset: 0x00325924
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

										// Token: 0x06007D41 RID: 32065 RVA: 0x00327734 File Offset: 0x00325934
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PartyInvitationMemberInformation()
										{
										}

										// Token: 0x06007D42 RID: 32066 RVA: 0x00327744 File Offset: 0x00325944
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PartyInvitationMemberInformation(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation other)
										{
										}

										// Token: 0x06007D43 RID: 32067 RVA: 0x00327754 File Offset: 0x00325954
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation Clone()
										{
											return null;
										}

										// Token: 0x170016BA RID: 5818
										// (get) Token: 0x06007D44 RID: 32068 RVA: 0x00327764 File Offset: 0x00325964
										// (set) Token: 0x06007D45 RID: 32069 RVA: 0x00327774 File Offset: 0x00325974
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public MapExtendedCoordinates Coordinates
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

										// Token: 0x170016BB RID: 5819
										// (get) Token: 0x06007D46 RID: 32070 RVA: 0x00327784 File Offset: 0x00325984
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public RepeatedField<PartyEntity> Entities
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x06007D47 RID: 32071 RVA: 0x00327794 File Offset: 0x00325994
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x06007D48 RID: 32072 RVA: 0x003277A4 File Offset: 0x003259A4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation other)
										{
											return true;
										}

										// Token: 0x06007D49 RID: 32073 RVA: 0x003277B4 File Offset: 0x003259B4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x06007D4A RID: 32074 RVA: 0x003277C4 File Offset: 0x003259C4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x06007D4B RID: 32075 RVA: 0x003277D4 File Offset: 0x003259D4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x06007D4C RID: 32076 RVA: 0x003277E4 File Offset: 0x003259E4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x06007D4D RID: 32077 RVA: 0x003277F4 File Offset: 0x003259F4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x06007D4E RID: 32078 RVA: 0x00327804 File Offset: 0x00325A04
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation other)
										{
										}

										// Token: 0x06007D4F RID: 32079 RVA: 0x00327814 File Offset: 0x00325A14
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x06007D50 RID: 32080 RVA: 0x00327824 File Offset: 0x00325A24
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x06007D51 RID: 32081 RVA: 0x00327834 File Offset: 0x00325A34
										[MethodImpl(MethodImplOptions.NoInlining)]
										static PartyInvitationMemberInformation()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation._parser = new MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation>(() => null);
													num2 = 3;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 3:
													Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation._repeated_entities_codec = FieldCodec.ForMessage<PartyEntity>(18U, cYYvTcn1ExwQJEKZCPPn.XVInXhlssT(cYYvTcn1ExwQJEKZCPPn.zJSn1Xk8R1C));
													num2 = 4;
													continue;
												case 4:
													return;
												case 5:
													UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
													num2 = 2;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												}
												AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
												num2 = 3;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
												{
													num2 = 5;
												}
											}
										}

										// Token: 0x06007D52 RID: 32082 RVA: 0x00327950 File Offset: 0x00325B50
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool EDUmQng2ZBPXfHifcBRX()
										{
											return true;
										}

										// Token: 0x06007D53 RID: 32083 RVA: 0x00327958 File Offset: 0x00325B58
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation E86imHg2qG7Z4gKM8nU1()
										{
											return null;
										}

										// Token: 0x04002D34 RID: 11572
										private static readonly MessageParser<Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation> _parser;

										// Token: 0x04002D35 RID: 11573
										private UnknownFieldSet _unknownFields;

										// Token: 0x04002D36 RID: 11574
										public const int CoordinatesFieldNumber = 1;

										// Token: 0x04002D37 RID: 11575
										private MapExtendedCoordinates coordinates_;

										// Token: 0x04002D38 RID: 11576
										public const int EntitiesFieldNumber = 2;

										// Token: 0x04002D39 RID: 11577
										private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

										// Token: 0x04002D3A RID: 11578
										private readonly RepeatedField<PartyEntity> entities_;

										// Token: 0x04002D3B RID: 11579
										private static Character.Types.CharacterBasicInformation.Types.CharacterLook.Types.CharacterBaseInformation.Types.PartyInvitationMemberInformation ohisCLg28XWxqoEYny0I;
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
