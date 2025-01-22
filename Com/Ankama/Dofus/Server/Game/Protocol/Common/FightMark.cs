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
	// Token: 0x02000ACD RID: 2765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMark : IMessage<FightMark>, IMessage, IEquatable<FightMark>, IDeepCloneable<FightMark>, IBufferMessage
	{
		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600843A RID: 33850 RVA: 0x00264308 File Offset: 0x00262508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMark> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x00264318 File Offset: 0x00262518
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

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600843C RID: 33852 RVA: 0x00264328 File Offset: 0x00262528
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

		// Token: 0x0600843D RID: 33853 RVA: 0x00264338 File Offset: 0x00262538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMark()
		{
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x00264348 File Offset: 0x00262548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMark(FightMark other)
		{
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x00264358 File Offset: 0x00262558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMark Clone()
		{
			return null;
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06008440 RID: 33856 RVA: 0x00264368 File Offset: 0x00262568
		// (set) Token: 0x06008441 RID: 33857 RVA: 0x00264378 File Offset: 0x00262578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AuthorId
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

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06008442 RID: 33858 RVA: 0x00264388 File Offset: 0x00262588
		// (set) Token: 0x06008443 RID: 33859 RVA: 0x0026439C File Offset: 0x0026259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06008444 RID: 33860 RVA: 0x002643AC File Offset: 0x002625AC
		// (set) Token: 0x06008445 RID: 33861 RVA: 0x002643BC File Offset: 0x002625BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellId
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

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06008446 RID: 33862 RVA: 0x002643CC File Offset: 0x002625CC
		// (set) Token: 0x06008447 RID: 33863 RVA: 0x002643DC File Offset: 0x002625DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellLevel
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

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06008448 RID: 33864 RVA: 0x002643EC File Offset: 0x002625EC
		// (set) Token: 0x06008449 RID: 33865 RVA: 0x002643FC File Offset: 0x002625FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
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

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x0600844A RID: 33866 RVA: 0x0026440C File Offset: 0x0026260C
		// (set) Token: 0x0600844B RID: 33867 RVA: 0x00264420 File Offset: 0x00262620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMark.Types.MarkType MarkType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightMark.Types.MarkType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600844C RID: 33868 RVA: 0x00264430 File Offset: 0x00262630
		// (set) Token: 0x0600844D RID: 33869 RVA: 0x00264440 File Offset: 0x00262640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkImpactCell
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

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600844E RID: 33870 RVA: 0x00264450 File Offset: 0x00262650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FightMark.Types.MarkedCell> Cells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600844F RID: 33871 RVA: 0x00264460 File Offset: 0x00262660
		// (set) Token: 0x06008450 RID: 33872 RVA: 0x00264470 File Offset: 0x00262670
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

		// Token: 0x06008451 RID: 33873 RVA: 0x00264480 File Offset: 0x00262680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x00264490 File Offset: 0x00262690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightMark other)
		{
			return true;
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x002644A0 File Offset: 0x002626A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x002644B0 File Offset: 0x002626B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x002644C0 File Offset: 0x002626C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x002644D0 File Offset: 0x002626D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x002644E0 File Offset: 0x002626E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x002644F0 File Offset: 0x002626F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightMark other)
		{
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x00264500 File Offset: 0x00262700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x00264510 File Offset: 0x00262710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x00264520 File Offset: 0x00262720
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightMark()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					FightMark._repeated_cells_codec = FieldCodec.ForMessage<FightMark.Types.MarkedCell>(66U, wVXOJRBIYNLLp9UtPfBU.XVInXhlssT(wVXOJRBIYNLLp9UtPfBU.hO5BIbHOlmi));
					num2 = 4;
					continue;
				}
				FightMark._parser = new MessageParser<FightMark>(() => null);
				num2 = 5;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x0026463C File Offset: 0x0026283C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pM76EcJsWA2QMq1OtIgM()
		{
			return true;
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x00264644 File Offset: 0x00262844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightMark lH6jr2JshX5vWf99ZtTo()
		{
			return null;
		}

		// Token: 0x04003049 RID: 12361
		private static readonly MessageParser<FightMark> _parser;

		// Token: 0x0400304A RID: 12362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400304B RID: 12363
		public const int AuthorIdFieldNumber = 1;

		// Token: 0x0400304C RID: 12364
		private long authorId_;

		// Token: 0x0400304D RID: 12365
		public const int TeamFieldNumber = 2;

		// Token: 0x0400304E RID: 12366
		private Team team_;

		// Token: 0x0400304F RID: 12367
		public const int SpellIdFieldNumber = 3;

		// Token: 0x04003050 RID: 12368
		private int spellId_;

		// Token: 0x04003051 RID: 12369
		public const int SpellLevelFieldNumber = 4;

		// Token: 0x04003052 RID: 12370
		private int spellLevel_;

		// Token: 0x04003053 RID: 12371
		public const int MarkIdFieldNumber = 5;

		// Token: 0x04003054 RID: 12372
		private int markId_;

		// Token: 0x04003055 RID: 12373
		public const int MarkTypeFieldNumber = 6;

		// Token: 0x04003056 RID: 12374
		private FightMark.Types.MarkType markType_;

		// Token: 0x04003057 RID: 12375
		public const int MarkImpactCellFieldNumber = 7;

		// Token: 0x04003058 RID: 12376
		private int markImpactCell_;

		// Token: 0x04003059 RID: 12377
		public const int CellsFieldNumber = 8;

		// Token: 0x0400305A RID: 12378
		private static readonly FieldCodec<FightMark.Types.MarkedCell> _repeated_cells_codec;

		// Token: 0x0400305B RID: 12379
		private readonly RepeatedField<FightMark.Types.MarkedCell> cells_;

		// Token: 0x0400305C RID: 12380
		public const int ActiveFieldNumber = 9;

		// Token: 0x0400305D RID: 12381
		private bool active_;

		// Token: 0x0400305E RID: 12382
		private static FightMark EALT2gJsLgDg6qwFYgcb;

		// Token: 0x02000ACE RID: 2766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600845E RID: 33886 RVA: 0x002E2188 File Offset: 0x002E0388
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000ACF RID: 2767
			public enum MarkType
			{
				// Token: 0x04003060 RID: 12384
				[OriginalName("GLYPH")]
				Glyph,
				// Token: 0x04003061 RID: 12385
				[OriginalName("TRAP")]
				Trap,
				// Token: 0x04003062 RID: 12386
				[OriginalName("WALL")]
				Wall,
				// Token: 0x04003063 RID: 12387
				[OriginalName("PORTAL")]
				Portal,
				// Token: 0x04003064 RID: 12388
				[OriginalName("RUNE")]
				Rune
			}

			// Token: 0x02000AD0 RID: 2768
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MarkedCell : IMessage<FightMark.Types.MarkedCell>, IMessage, IEquatable<FightMark.Types.MarkedCell>, IDeepCloneable<FightMark.Types.MarkedCell>, IBufferMessage
			{
				// Token: 0x1700184B RID: 6219
				// (get) Token: 0x0600845F RID: 33887 RVA: 0x00308DCC File Offset: 0x00306FCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FightMark.Types.MarkedCell> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700184C RID: 6220
				// (get) Token: 0x06008460 RID: 33888 RVA: 0x00308DDC File Offset: 0x00306FDC
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

				// Token: 0x1700184D RID: 6221
				// (get) Token: 0x06008461 RID: 33889 RVA: 0x00308DEC File Offset: 0x00306FEC
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

				// Token: 0x06008462 RID: 33890 RVA: 0x00308DFC File Offset: 0x00306FFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarkedCell()
				{
				}

				// Token: 0x06008463 RID: 33891 RVA: 0x00308E0C File Offset: 0x0030700C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarkedCell(FightMark.Types.MarkedCell other)
				{
				}

				// Token: 0x06008464 RID: 33892 RVA: 0x00308E1C File Offset: 0x0030701C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightMark.Types.MarkedCell Clone()
				{
					return null;
				}

				// Token: 0x1700184E RID: 6222
				// (get) Token: 0x06008465 RID: 33893 RVA: 0x00308E2C File Offset: 0x0030702C
				// (set) Token: 0x06008466 RID: 33894 RVA: 0x00308E3C File Offset: 0x0030703C
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

				// Token: 0x1700184F RID: 6223
				// (get) Token: 0x06008467 RID: 33895 RVA: 0x00308E4C File Offset: 0x0030704C
				// (set) Token: 0x06008468 RID: 33896 RVA: 0x00308E5C File Offset: 0x0030705C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ZoneSize
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

				// Token: 0x17001850 RID: 6224
				// (get) Token: 0x06008469 RID: 33897 RVA: 0x00308E6C File Offset: 0x0030706C
				// (set) Token: 0x0600846A RID: 33898 RVA: 0x00308E7C File Offset: 0x0030707C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Color
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

				// Token: 0x17001851 RID: 6225
				// (get) Token: 0x0600846B RID: 33899 RVA: 0x00308E8C File Offset: 0x0030708C
				// (set) Token: 0x0600846C RID: 33900 RVA: 0x00308EA0 File Offset: 0x003070A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FightMark.Types.MarkedCell.Types.MarkCellsType CellsType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (FightMark.Types.MarkedCell.Types.MarkCellsType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x0600846D RID: 33901 RVA: 0x00308EB0 File Offset: 0x003070B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600846E RID: 33902 RVA: 0x00308EC0 File Offset: 0x003070C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightMark.Types.MarkedCell other)
				{
					return true;
				}

				// Token: 0x0600846F RID: 33903 RVA: 0x00308ED0 File Offset: 0x003070D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008470 RID: 33904 RVA: 0x00308EE0 File Offset: 0x003070E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008471 RID: 33905 RVA: 0x00308EF0 File Offset: 0x003070F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008472 RID: 33906 RVA: 0x00308F00 File Offset: 0x00307100
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008473 RID: 33907 RVA: 0x00308F10 File Offset: 0x00307110
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008474 RID: 33908 RVA: 0x00308F20 File Offset: 0x00307120
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightMark.Types.MarkedCell other)
				{
				}

				// Token: 0x06008475 RID: 33909 RVA: 0x00308F30 File Offset: 0x00307130
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008476 RID: 33910 RVA: 0x00308F40 File Offset: 0x00307140
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008477 RID: 33911 RVA: 0x00308F50 File Offset: 0x00307150
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MarkedCell()
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
							FightMark.Types.MarkedCell._parser = new MessageParser<FightMark.Types.MarkedCell>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
					}
				}

				// Token: 0x06008478 RID: 33912 RVA: 0x0030901C File Offset: 0x0030721C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Au9pK7GuHF2JPwYoeqkA()
				{
					return true;
				}

				// Token: 0x06008479 RID: 33913 RVA: 0x00309024 File Offset: 0x00307224
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightMark.Types.MarkedCell Spxd8nGuYVAnBku6rKvp()
				{
					return null;
				}

				// Token: 0x04003065 RID: 12389
				private static readonly MessageParser<FightMark.Types.MarkedCell> _parser;

				// Token: 0x04003066 RID: 12390
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003067 RID: 12391
				public const int IdFieldNumber = 1;

				// Token: 0x04003068 RID: 12392
				private int id_;

				// Token: 0x04003069 RID: 12393
				public const int ZoneSizeFieldNumber = 2;

				// Token: 0x0400306A RID: 12394
				private int zoneSize_;

				// Token: 0x0400306B RID: 12395
				public const int ColorFieldNumber = 3;

				// Token: 0x0400306C RID: 12396
				private int color_;

				// Token: 0x0400306D RID: 12397
				public const int CellsTypeFieldNumber = 4;

				// Token: 0x0400306E RID: 12398
				private FightMark.Types.MarkedCell.Types.MarkCellsType cellsType_;

				// Token: 0x0400306F RID: 12399
				private static FightMark.Types.MarkedCell JVTQ4RGup9kYPhOgBeqG;

				// Token: 0x02000AD1 RID: 2769
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600847A RID: 33914 RVA: 0x00317F60 File Offset: 0x00316160
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000AD2 RID: 2770
					public enum MarkCellsType
					{
						// Token: 0x04003071 RID: 12401
						[OriginalName("CELLS_CIRCLE")]
						CellsCircle,
						// Token: 0x04003072 RID: 12402
						[OriginalName("CELLS_CROSS")]
						CellsCross,
						// Token: 0x04003073 RID: 12403
						[OriginalName("CELLS_SQUARE")]
						CellsSquare
					}
				}
			}
		}
	}
}
