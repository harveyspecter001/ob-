using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A71 RID: 2673
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlignmentInformation : IMessage<AlignmentInformation>, IMessage, IEquatable<AlignmentInformation>, IDeepCloneable<AlignmentInformation>, IBufferMessage
	{
		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06007F92 RID: 32658 RVA: 0x0025F1A0 File Offset: 0x0025D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlignmentInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06007F93 RID: 32659 RVA: 0x0025F1B0 File Offset: 0x0025D3B0
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

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x0025F1C0 File Offset: 0x0025D3C0
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

		// Token: 0x06007F95 RID: 32661 RVA: 0x0025F1D0 File Offset: 0x0025D3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentInformation()
		{
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x0025F1E0 File Offset: 0x0025D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentInformation(AlignmentInformation other)
		{
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x0025F1F0 File Offset: 0x0025D3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlignmentInformation Clone()
		{
			return null;
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x0025F200 File Offset: 0x0025D400
		// (set) Token: 0x06007F99 RID: 32665 RVA: 0x0025F214 File Offset: 0x0025D414
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

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06007F9A RID: 32666 RVA: 0x0025F224 File Offset: 0x0025D424
		// (set) Token: 0x06007F9B RID: 32667 RVA: 0x0025F234 File Offset: 0x0025D434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AlignmentQuestNumber
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

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06007F9C RID: 32668 RVA: 0x0025F244 File Offset: 0x0025D444
		// (set) Token: 0x06007F9D RID: 32669 RVA: 0x0025F254 File Offset: 0x0025D454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AlignmentGrade
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

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x0025F264 File Offset: 0x0025D464
		// (set) Token: 0x06007F9F RID: 32671 RVA: 0x0025F274 File Offset: 0x0025D474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x0025F284 File Offset: 0x0025D484
		// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x0025F294 File Offset: 0x0025D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterLevel
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

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x0025F2A4 File Offset: 0x0025D4A4
		// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x0025F2B4 File Offset: 0x0025D4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AlignmentInformation.Types.AlignmentExtendedInformation ExtendedInformation
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

		// Token: 0x06007FA4 RID: 32676 RVA: 0x0025F2C4 File Offset: 0x0025D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x0025F2D4 File Offset: 0x0025D4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlignmentInformation other)
		{
			return true;
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x0025F2E4 File Offset: 0x0025D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x0025F2F4 File Offset: 0x0025D4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x0025F304 File Offset: 0x0025D504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x0025F314 File Offset: 0x0025D514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x0025F324 File Offset: 0x0025D524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x0025F334 File Offset: 0x0025D534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlignmentInformation other)
		{
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x0025F344 File Offset: 0x0025D544
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x0025F354 File Offset: 0x0025D554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x0025F364 File Offset: 0x0025D564
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlignmentInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AlignmentInformation._parser = new MessageParser<AlignmentInformation>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x0025F430 File Offset: 0x0025D630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hhAdiCJgmcBH5wskVZHu()
		{
			return true;
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x0025F438 File Offset: 0x0025D638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlignmentInformation N7jbg5JgAMwk3tdBfBW6()
		{
			return null;
		}

		// Token: 0x04002E35 RID: 11829
		private static readonly MessageParser<AlignmentInformation> _parser;

		// Token: 0x04002E36 RID: 11830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E37 RID: 11831
		public const int AlignmentFieldNumber = 1;

		// Token: 0x04002E38 RID: 11832
		private Alignment alignment_;

		// Token: 0x04002E39 RID: 11833
		public const int AlignmentQuestNumberFieldNumber = 2;

		// Token: 0x04002E3A RID: 11834
		private int alignmentQuestNumber_;

		// Token: 0x04002E3B RID: 11835
		public const int AlignmentGradeFieldNumber = 3;

		// Token: 0x04002E3C RID: 11836
		private int alignmentGrade_;

		// Token: 0x04002E3D RID: 11837
		public const int CharacterIdFieldNumber = 4;

		// Token: 0x04002E3E RID: 11838
		private long characterId_;

		// Token: 0x04002E3F RID: 11839
		public const int CharacterLevelFieldNumber = 5;

		// Token: 0x04002E40 RID: 11840
		private long characterLevel_;

		// Token: 0x04002E41 RID: 11841
		public const int ExtendedInformationFieldNumber = 6;

		// Token: 0x04002E42 RID: 11842
		private AlignmentInformation.Types.AlignmentExtendedInformation extendedInformation_;

		// Token: 0x04002E43 RID: 11843
		private static AlignmentInformation F8uBJeJgnXwhW3kw27vb;

		// Token: 0x02000A72 RID: 2674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007FB1 RID: 32689 RVA: 0x002E01E4 File Offset: 0x002DE3E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A73 RID: 2675
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AlignmentExtendedInformation : IMessage<AlignmentInformation.Types.AlignmentExtendedInformation>, IMessage, IEquatable<AlignmentInformation.Types.AlignmentExtendedInformation>, IDeepCloneable<AlignmentInformation.Types.AlignmentExtendedInformation>, IBufferMessage
			{
				// Token: 0x1700173E RID: 5950
				// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x0030823C File Offset: 0x0030643C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<AlignmentInformation.Types.AlignmentExtendedInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700173F RID: 5951
				// (get) Token: 0x06007FB3 RID: 32691 RVA: 0x0030824C File Offset: 0x0030644C
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

				// Token: 0x17001740 RID: 5952
				// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x0030825C File Offset: 0x0030645C
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

				// Token: 0x06007FB5 RID: 32693 RVA: 0x0030826C File Offset: 0x0030646C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AlignmentExtendedInformation()
				{
				}

				// Token: 0x06007FB6 RID: 32694 RVA: 0x0030827C File Offset: 0x0030647C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AlignmentExtendedInformation(AlignmentInformation.Types.AlignmentExtendedInformation other)
				{
				}

				// Token: 0x06007FB7 RID: 32695 RVA: 0x0030828C File Offset: 0x0030648C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AlignmentInformation.Types.AlignmentExtendedInformation Clone()
				{
					return null;
				}

				// Token: 0x17001741 RID: 5953
				// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x0030829C File Offset: 0x0030649C
				// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x003082AC File Offset: 0x003064AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Honor
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

				// Token: 0x17001742 RID: 5954
				// (get) Token: 0x06007FBA RID: 32698 RVA: 0x003082BC File Offset: 0x003064BC
				// (set) Token: 0x06007FBB RID: 32699 RVA: 0x003082CC File Offset: 0x003064CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int HonorGradeFloor
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

				// Token: 0x17001743 RID: 5955
				// (get) Token: 0x06007FBC RID: 32700 RVA: 0x003082DC File Offset: 0x003064DC
				// (set) Token: 0x06007FBD RID: 32701 RVA: 0x003082EC File Offset: 0x003064EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int HonorNextGradeFloor
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

				// Token: 0x17001744 RID: 5956
				// (get) Token: 0x06007FBE RID: 32702 RVA: 0x003082FC File Offset: 0x003064FC
				// (set) Token: 0x06007FBF RID: 32703 RVA: 0x00308310 File Offset: 0x00306510
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public AttackableStatus Attackable
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

				// Token: 0x06007FC0 RID: 32704 RVA: 0x00308320 File Offset: 0x00306520
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007FC1 RID: 32705 RVA: 0x00308330 File Offset: 0x00306530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AlignmentInformation.Types.AlignmentExtendedInformation other)
				{
					return true;
				}

				// Token: 0x06007FC2 RID: 32706 RVA: 0x00308340 File Offset: 0x00306540
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007FC3 RID: 32707 RVA: 0x00308350 File Offset: 0x00306550
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007FC4 RID: 32708 RVA: 0x00308360 File Offset: 0x00306560
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007FC5 RID: 32709 RVA: 0x00308370 File Offset: 0x00306570
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007FC6 RID: 32710 RVA: 0x00308380 File Offset: 0x00306580
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007FC7 RID: 32711 RVA: 0x00308390 File Offset: 0x00306590
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AlignmentInformation.Types.AlignmentExtendedInformation other)
				{
				}

				// Token: 0x06007FC8 RID: 32712 RVA: 0x003083A0 File Offset: 0x003065A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007FC9 RID: 32713 RVA: 0x003083B0 File Offset: 0x003065B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007FCA RID: 32714 RVA: 0x003083C0 File Offset: 0x003065C0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AlignmentExtendedInformation()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AlignmentInformation.Types.AlignmentExtendedInformation._parser = new MessageParser<AlignmentInformation.Types.AlignmentExtendedInformation>(() => null);
							num2 = 4;
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
					}
				}

				// Token: 0x06007FCB RID: 32715 RVA: 0x0030848C File Offset: 0x0030668C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool kaxrIaGuxoM4QkLMqQ6w()
				{
					return true;
				}

				// Token: 0x06007FCC RID: 32716 RVA: 0x00308494 File Offset: 0x00306694
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AlignmentInformation.Types.AlignmentExtendedInformation WyxM2rGu4JhObZXKs3hT()
				{
					return null;
				}

				// Token: 0x04002E44 RID: 11844
				private static readonly MessageParser<AlignmentInformation.Types.AlignmentExtendedInformation> _parser;

				// Token: 0x04002E45 RID: 11845
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002E46 RID: 11846
				public const int HonorFieldNumber = 1;

				// Token: 0x04002E47 RID: 11847
				private int honor_;

				// Token: 0x04002E48 RID: 11848
				public const int HonorGradeFloorFieldNumber = 2;

				// Token: 0x04002E49 RID: 11849
				private int honorGradeFloor_;

				// Token: 0x04002E4A RID: 11850
				public const int HonorNextGradeFloorFieldNumber = 3;

				// Token: 0x04002E4B RID: 11851
				private int honorNextGradeFloor_;

				// Token: 0x04002E4C RID: 11852
				public const int AttackableFieldNumber = 4;

				// Token: 0x04002E4D RID: 11853
				private AttackableStatus attackable_;

				// Token: 0x04002E4E RID: 11854
				private static AlignmentInformation.Types.AlignmentExtendedInformation jspUXAGuNP4W9h0DAIJg;
			}
		}
	}
}
