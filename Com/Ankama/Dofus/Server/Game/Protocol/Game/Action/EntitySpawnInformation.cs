using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x02000627 RID: 1575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntitySpawnInformation : IMessage<EntitySpawnInformation>, IMessage, IEquatable<EntitySpawnInformation>, IDeepCloneable<EntitySpawnInformation>, IBufferMessage
	{
		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x001FF1A0 File Offset: 0x001FD3A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EntitySpawnInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x001FF1B0 File Offset: 0x001FD3B0
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

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x001FF1C0 File Offset: 0x001FD3C0
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

		// Token: 0x06004C75 RID: 19573 RVA: 0x001FF1D0 File Offset: 0x001FD3D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitySpawnInformation()
		{
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x001FF1E0 File Offset: 0x001FD3E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitySpawnInformation(EntitySpawnInformation other)
		{
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x001FF1F0 File Offset: 0x001FD3F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EntitySpawnInformation Clone()
		{
			return null;
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x001FF200 File Offset: 0x001FD400
		// (set) Token: 0x06004C79 RID: 19577 RVA: 0x001FF210 File Offset: 0x001FD410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntitySpawnInformation.Types.Monster Monster
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x001FF220 File Offset: 0x001FD420
		// (set) Token: 0x06004C7B RID: 19579 RVA: 0x001FF230 File Offset: 0x001FD430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySpawnInformation.Types.Character Character
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x001FF240 File Offset: 0x001FD440
		// (set) Token: 0x06004C7D RID: 19581 RVA: 0x001FF250 File Offset: 0x001FD450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySpawnInformation.Types.Companion Companion
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

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x001FF260 File Offset: 0x001FD460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySpawnInformation.SpawnInformationOneofCase SpawnInformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (EntitySpawnInformation.SpawnInformationOneofCase)null;
			}
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x001FF274 File Offset: 0x001FD474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSpawnInformation()
		{
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x001FF284 File Offset: 0x001FD484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x001FF294 File Offset: 0x001FD494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EntitySpawnInformation other)
		{
			return true;
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x001FF2A4 File Offset: 0x001FD4A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x001FF2B4 File Offset: 0x001FD4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x001FF2C4 File Offset: 0x001FD4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x001FF2D4 File Offset: 0x001FD4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x001FF2E4 File Offset: 0x001FD4E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x001FF2F4 File Offset: 0x001FD4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EntitySpawnInformation other)
		{
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x001FF304 File Offset: 0x001FD504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x001FF314 File Offset: 0x001FD514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x001FF324 File Offset: 0x001FD524
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EntitySpawnInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					EntitySpawnInformation._parser = new MessageParser<EntitySpawnInformation>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x001FF408 File Offset: 0x001FD608
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DdMX7yObzZuCqpGdLLxv()
		{
			return true;
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x001FF410 File Offset: 0x001FD610
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EntitySpawnInformation buRpv3Oifjxk26MM9cde()
		{
			return null;
		}

		// Token: 0x04001AAC RID: 6828
		private static readonly MessageParser<EntitySpawnInformation> _parser;

		// Token: 0x04001AAD RID: 6829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AAE RID: 6830
		public const int MonsterFieldNumber = 1;

		// Token: 0x04001AAF RID: 6831
		public const int CharacterFieldNumber = 2;

		// Token: 0x04001AB0 RID: 6832
		public const int CompanionFieldNumber = 3;

		// Token: 0x04001AB1 RID: 6833
		private object spawnInformation_;

		// Token: 0x04001AB2 RID: 6834
		private EntitySpawnInformation.SpawnInformationOneofCase spawnInformationCase_;

		// Token: 0x04001AB3 RID: 6835
		internal static EntitySpawnInformation AAHbdtObFq8Zomv0MVg0;

		// Token: 0x02000628 RID: 1576
		public enum SpawnInformationOneofCase
		{
			// Token: 0x04001AB5 RID: 6837
			None,
			// Token: 0x04001AB6 RID: 6838
			Monster,
			// Token: 0x04001AB7 RID: 6839
			Character,
			// Token: 0x04001AB8 RID: 6840
			Companion
		}

		// Token: 0x02000629 RID: 1577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06004C8D RID: 19597 RVA: 0x002C9288 File Offset: 0x002C7488
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200062A RID: 1578
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Monster : IMessage<EntitySpawnInformation.Types.Monster>, IMessage, IEquatable<EntitySpawnInformation.Types.Monster>, IDeepCloneable<EntitySpawnInformation.Types.Monster>, IBufferMessage
			{
				// Token: 0x17000DCD RID: 3533
				// (get) Token: 0x06004C8E RID: 19598 RVA: 0x00301654 File Offset: 0x002FF854
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<EntitySpawnInformation.Types.Monster> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DCE RID: 3534
				// (get) Token: 0x06004C8F RID: 19599 RVA: 0x00301664 File Offset: 0x002FF864
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

				// Token: 0x17000DCF RID: 3535
				// (get) Token: 0x06004C90 RID: 19600 RVA: 0x00301674 File Offset: 0x002FF874
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

				// Token: 0x06004C91 RID: 19601 RVA: 0x00301684 File Offset: 0x002FF884
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Monster()
				{
				}

				// Token: 0x06004C92 RID: 19602 RVA: 0x00301694 File Offset: 0x002FF894
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Monster(EntitySpawnInformation.Types.Monster other)
				{
				}

				// Token: 0x06004C93 RID: 19603 RVA: 0x003016A4 File Offset: 0x002FF8A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EntitySpawnInformation.Types.Monster Clone()
				{
					return null;
				}

				// Token: 0x17000DD0 RID: 3536
				// (get) Token: 0x06004C94 RID: 19604 RVA: 0x003016B4 File Offset: 0x002FF8B4
				// (set) Token: 0x06004C95 RID: 19605 RVA: 0x003016C4 File Offset: 0x002FF8C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000DD1 RID: 3537
				// (get) Token: 0x06004C96 RID: 19606 RVA: 0x003016D4 File Offset: 0x002FF8D4
				// (set) Token: 0x06004C97 RID: 19607 RVA: 0x003016E4 File Offset: 0x002FF8E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000DD2 RID: 3538
				// (get) Token: 0x06004C98 RID: 19608 RVA: 0x003016F4 File Offset: 0x002FF8F4
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

				// Token: 0x06004C99 RID: 19609 RVA: 0x00301704 File Offset: 0x002FF904
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearGrade()
				{
				}

				// Token: 0x17000DD3 RID: 3539
				// (get) Token: 0x06004C9A RID: 19610 RVA: 0x00301714 File Offset: 0x002FF914
				// (set) Token: 0x06004C9B RID: 19611 RVA: 0x00301724 File Offset: 0x002FF924
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

				// Token: 0x17000DD4 RID: 3540
				// (get) Token: 0x06004C9C RID: 19612 RVA: 0x00301734 File Offset: 0x002FF934
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasLevel
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06004C9D RID: 19613 RVA: 0x00301744 File Offset: 0x002FF944
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearLevel()
				{
				}

				// Token: 0x17000DD5 RID: 3541
				// (get) Token: 0x06004C9E RID: 19614 RVA: 0x00301754 File Offset: 0x002FF954
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EntitySpawnInformation.Types.Monster.InvocationInformationOneofCase InvocationInformationCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (EntitySpawnInformation.Types.Monster.InvocationInformationOneofCase)null;
					}
				}

				// Token: 0x06004C9F RID: 19615 RVA: 0x00301768 File Offset: 0x002FF968
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearInvocationInformation()
				{
				}

				// Token: 0x06004CA0 RID: 19616 RVA: 0x00301778 File Offset: 0x002FF978
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004CA1 RID: 19617 RVA: 0x00301788 File Offset: 0x002FF988
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(EntitySpawnInformation.Types.Monster other)
				{
					return true;
				}

				// Token: 0x06004CA2 RID: 19618 RVA: 0x00301798 File Offset: 0x002FF998
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004CA3 RID: 19619 RVA: 0x003017A8 File Offset: 0x002FF9A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004CA4 RID: 19620 RVA: 0x003017B8 File Offset: 0x002FF9B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004CA5 RID: 19621 RVA: 0x003017C8 File Offset: 0x002FF9C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004CA6 RID: 19622 RVA: 0x003017D8 File Offset: 0x002FF9D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004CA7 RID: 19623 RVA: 0x003017E8 File Offset: 0x002FF9E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(EntitySpawnInformation.Types.Monster other)
				{
				}

				// Token: 0x06004CA8 RID: 19624 RVA: 0x003017F8 File Offset: 0x002FF9F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004CA9 RID: 19625 RVA: 0x00301808 File Offset: 0x002FFA08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004CAA RID: 19626 RVA: 0x00301818 File Offset: 0x002FFA18
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Monster()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							EntitySpawnInformation.Types.Monster._parser = new MessageParser<EntitySpawnInformation.Types.Monster>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004CAB RID: 19627 RVA: 0x00301910 File Offset: 0x002FFB10
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool O13RXBGibjPAoo0YsgS7()
				{
					return true;
				}

				// Token: 0x06004CAC RID: 19628 RVA: 0x00301918 File Offset: 0x002FFB18
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static EntitySpawnInformation.Types.Monster kKnD3uGiiBJ2eJyp7GnV()
				{
					return null;
				}

				// Token: 0x04001AB9 RID: 6841
				private static readonly MessageParser<EntitySpawnInformation.Types.Monster> _parser;

				// Token: 0x04001ABA RID: 6842
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001ABB RID: 6843
				public const int MonsterGidFieldNumber = 1;

				// Token: 0x04001ABC RID: 6844
				private int monsterGid_;

				// Token: 0x04001ABD RID: 6845
				public const int GradeFieldNumber = 2;

				// Token: 0x04001ABE RID: 6846
				public const int LevelFieldNumber = 3;

				// Token: 0x04001ABF RID: 6847
				private object invocationInformation_;

				// Token: 0x04001AC0 RID: 6848
				private EntitySpawnInformation.Types.Monster.InvocationInformationOneofCase invocationInformationCase_;

				// Token: 0x04001AC1 RID: 6849
				internal static EntitySpawnInformation.Types.Monster plUp1QGiYhSRj7k0Z9cH;

				// Token: 0x0200062B RID: 1579
				public enum InvocationInformationOneofCase
				{
					// Token: 0x04001AC3 RID: 6851
					None,
					// Token: 0x04001AC4 RID: 6852
					Grade = 2,
					// Token: 0x04001AC5 RID: 6853
					Level
				}
			}

			// Token: 0x0200062D RID: 1581
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Character : IMessage<EntitySpawnInformation.Types.Character>, IMessage, IEquatable<EntitySpawnInformation.Types.Character>, IDeepCloneable<EntitySpawnInformation.Types.Character>, IBufferMessage
			{
				// Token: 0x17000DD6 RID: 3542
				// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x00301920 File Offset: 0x002FFB20
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<EntitySpawnInformation.Types.Character> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DD7 RID: 3543
				// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x00301930 File Offset: 0x002FFB30
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

				// Token: 0x17000DD8 RID: 3544
				// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00301940 File Offset: 0x002FFB40
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

				// Token: 0x06004CB5 RID: 19637 RVA: 0x00301950 File Offset: 0x002FFB50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Character()
				{
				}

				// Token: 0x06004CB6 RID: 19638 RVA: 0x00301960 File Offset: 0x002FFB60
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Character(EntitySpawnInformation.Types.Character other)
				{
				}

				// Token: 0x06004CB7 RID: 19639 RVA: 0x00301970 File Offset: 0x002FFB70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EntitySpawnInformation.Types.Character Clone()
				{
					return null;
				}

				// Token: 0x17000DD9 RID: 3545
				// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x00301980 File Offset: 0x002FFB80
				// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x00301990 File Offset: 0x002FFB90
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

				// Token: 0x17000DDA RID: 3546
				// (get) Token: 0x06004CBA RID: 19642 RVA: 0x003019A0 File Offset: 0x002FFBA0
				// (set) Token: 0x06004CBB RID: 19643 RVA: 0x003019B0 File Offset: 0x002FFBB0
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

				// Token: 0x06004CBC RID: 19644 RVA: 0x003019C0 File Offset: 0x002FFBC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004CBD RID: 19645 RVA: 0x003019D0 File Offset: 0x002FFBD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(EntitySpawnInformation.Types.Character other)
				{
					return true;
				}

				// Token: 0x06004CBE RID: 19646 RVA: 0x003019E0 File Offset: 0x002FFBE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004CBF RID: 19647 RVA: 0x003019F0 File Offset: 0x002FFBF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004CC0 RID: 19648 RVA: 0x00301A00 File Offset: 0x002FFC00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004CC1 RID: 19649 RVA: 0x00301A10 File Offset: 0x002FFC10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004CC2 RID: 19650 RVA: 0x00301A20 File Offset: 0x002FFC20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004CC3 RID: 19651 RVA: 0x00301A30 File Offset: 0x002FFC30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(EntitySpawnInformation.Types.Character other)
				{
				}

				// Token: 0x06004CC4 RID: 19652 RVA: 0x00301A40 File Offset: 0x002FFC40
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004CC5 RID: 19653 RVA: 0x00301A50 File Offset: 0x002FFC50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004CC6 RID: 19654 RVA: 0x00301A60 File Offset: 0x002FFC60
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Character()
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
								goto IL_B1;
							case 2:
								return;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
							{
								num2 = 0;
							}
						}
						IL_B1:
						EntitySpawnInformation.Types.Character._parser = new MessageParser<EntitySpawnInformation.Types.Character>(() => null);
						num = 2;
					}
				}

				// Token: 0x06004CC7 RID: 19655 RVA: 0x00301B48 File Offset: 0x002FFD48
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool vswxx8GiSltFlGyimZMa()
				{
					return true;
				}

				// Token: 0x06004CC8 RID: 19656 RVA: 0x00301B50 File Offset: 0x002FFD50
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static EntitySpawnInformation.Types.Character MOcm1NGiMTEOxI2rIdne()
				{
					return null;
				}

				// Token: 0x04001AC8 RID: 6856
				private static readonly MessageParser<EntitySpawnInformation.Types.Character> _parser;

				// Token: 0x04001AC9 RID: 6857
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001ACA RID: 6858
				public const int NameFieldNumber = 1;

				// Token: 0x04001ACB RID: 6859
				private string name_;

				// Token: 0x04001ACC RID: 6860
				public const int LevelFieldNumber = 2;

				// Token: 0x04001ACD RID: 6861
				private int level_;

				// Token: 0x04001ACE RID: 6862
				internal static EntitySpawnInformation.Types.Character IFWaqDGiPv0lFthtsIu8;
			}

			// Token: 0x0200062F RID: 1583
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Companion : IMessage<EntitySpawnInformation.Types.Companion>, IMessage, IEquatable<EntitySpawnInformation.Types.Companion>, IDeepCloneable<EntitySpawnInformation.Types.Companion>, IBufferMessage
			{
				// Token: 0x17000DDB RID: 3547
				// (get) Token: 0x06004CCE RID: 19662 RVA: 0x00301B58 File Offset: 0x002FFD58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<EntitySpawnInformation.Types.Companion> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DDC RID: 3548
				// (get) Token: 0x06004CCF RID: 19663 RVA: 0x00301B68 File Offset: 0x002FFD68
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

				// Token: 0x17000DDD RID: 3549
				// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x00301B78 File Offset: 0x002FFD78
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

				// Token: 0x06004CD1 RID: 19665 RVA: 0x00301B88 File Offset: 0x002FFD88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Companion()
				{
				}

				// Token: 0x06004CD2 RID: 19666 RVA: 0x00301B98 File Offset: 0x002FFD98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Companion(EntitySpawnInformation.Types.Companion other)
				{
				}

				// Token: 0x06004CD3 RID: 19667 RVA: 0x00301BA8 File Offset: 0x002FFDA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EntitySpawnInformation.Types.Companion Clone()
				{
					return null;
				}

				// Token: 0x17000DDE RID: 3550
				// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x00301BB8 File Offset: 0x002FFDB8
				// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x00301BC8 File Offset: 0x002FFDC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ModelId
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

				// Token: 0x17000DDF RID: 3551
				// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x00301BD8 File Offset: 0x002FFDD8
				// (set) Token: 0x06004CD7 RID: 19671 RVA: 0x00301BE8 File Offset: 0x002FFDE8
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

				// Token: 0x17000DE0 RID: 3552
				// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x00301BF8 File Offset: 0x002FFDF8
				// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x00301C08 File Offset: 0x002FFE08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long SummonerId
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

				// Token: 0x17000DE1 RID: 3553
				// (get) Token: 0x06004CDA RID: 19674 RVA: 0x00301C18 File Offset: 0x002FFE18
				// (set) Token: 0x06004CDB RID: 19675 RVA: 0x00301C28 File Offset: 0x002FFE28
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long OwnerId
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

				// Token: 0x06004CDC RID: 19676 RVA: 0x00301C38 File Offset: 0x002FFE38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004CDD RID: 19677 RVA: 0x00301C48 File Offset: 0x002FFE48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(EntitySpawnInformation.Types.Companion other)
				{
					return true;
				}

				// Token: 0x06004CDE RID: 19678 RVA: 0x00301C58 File Offset: 0x002FFE58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004CDF RID: 19679 RVA: 0x00301C68 File Offset: 0x002FFE68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004CE0 RID: 19680 RVA: 0x00301C78 File Offset: 0x002FFE78
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004CE1 RID: 19681 RVA: 0x00301C88 File Offset: 0x002FFE88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004CE2 RID: 19682 RVA: 0x00301C98 File Offset: 0x002FFE98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004CE3 RID: 19683 RVA: 0x00301CA8 File Offset: 0x002FFEA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(EntitySpawnInformation.Types.Companion other)
				{
				}

				// Token: 0x06004CE4 RID: 19684 RVA: 0x00301CB8 File Offset: 0x002FFEB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004CE5 RID: 19685 RVA: 0x00301CC8 File Offset: 0x002FFEC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004CE6 RID: 19686 RVA: 0x00301CD8 File Offset: 0x002FFED8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Companion()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								EntitySpawnInformation.Types.Companion._parser = new MessageParser<EntitySpawnInformation.Types.Companion>(() => null);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
								{
									num2 = 1;
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
						IL_AC:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 4;
						continue;
						goto IL_AC;
					}
				}

				// Token: 0x06004CE7 RID: 19687 RVA: 0x00301DA8 File Offset: 0x002FFFA8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool cOKbrQGi80fWkjAWDSeK()
				{
					return true;
				}

				// Token: 0x06004CE8 RID: 19688 RVA: 0x00301DB0 File Offset: 0x002FFFB0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static EntitySpawnInformation.Types.Companion d9GwmNGiZBpQmq6XJQpF()
				{
					return null;
				}

				// Token: 0x04001AD1 RID: 6865
				private static readonly MessageParser<EntitySpawnInformation.Types.Companion> _parser;

				// Token: 0x04001AD2 RID: 6866
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001AD3 RID: 6867
				public const int ModelIdFieldNumber = 1;

				// Token: 0x04001AD4 RID: 6868
				private int modelId_;

				// Token: 0x04001AD5 RID: 6869
				public const int LevelFieldNumber = 2;

				// Token: 0x04001AD6 RID: 6870
				private int level_;

				// Token: 0x04001AD7 RID: 6871
				public const int SummonerIdFieldNumber = 3;

				// Token: 0x04001AD8 RID: 6872
				private long summonerId_;

				// Token: 0x04001AD9 RID: 6873
				public const int OwnerIdFieldNumber = 4;

				// Token: 0x04001ADA RID: 6874
				private long ownerId_;

				// Token: 0x04001ADB RID: 6875
				internal static EntitySpawnInformation.Types.Companion hpPyo6GiuffhOkUWB2S2;
			}
		}
	}
}
