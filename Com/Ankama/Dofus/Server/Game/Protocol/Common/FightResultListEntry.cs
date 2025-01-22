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
	// Token: 0x02000ADB RID: 2779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightResultListEntry : IMessage<FightResultListEntry>, IMessage, IEquatable<FightResultListEntry>, IDeepCloneable<FightResultListEntry>, IBufferMessage
	{
		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x00264D60 File Offset: 0x00262F60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightResultListEntry> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x00264D70 File Offset: 0x00262F70
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

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060084E0 RID: 34016 RVA: 0x00264D80 File Offset: 0x00262F80
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

		// Token: 0x060084E1 RID: 34017 RVA: 0x00264D90 File Offset: 0x00262F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResultListEntry()
		{
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x00264DA0 File Offset: 0x00262FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResultListEntry(FightResultListEntry other)
		{
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x00264DB0 File Offset: 0x00262FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightResultListEntry Clone()
		{
			return null;
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x00264DC0 File Offset: 0x00262FC0
		// (set) Token: 0x060084E5 RID: 34021 RVA: 0x00264DD4 File Offset: 0x00262FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightOutcome Outcome
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightOutcome)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060084E6 RID: 34022 RVA: 0x00264DE4 File Offset: 0x00262FE4
		// (set) Token: 0x060084E7 RID: 34023 RVA: 0x00264DF4 File Offset: 0x00262FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060084E8 RID: 34024 RVA: 0x00264E04 File Offset: 0x00263004
		// (set) Token: 0x060084E9 RID: 34025 RVA: 0x00264E14 File Offset: 0x00263014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightResultListEntry.Types.FightLoot Rewards
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060084EA RID: 34026 RVA: 0x00264E24 File Offset: 0x00263024
		// (set) Token: 0x060084EB RID: 34027 RVA: 0x00264E34 File Offset: 0x00263034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightResultListEntry.Types.FighterListEntry FighterListEntry
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

		// Token: 0x060084EC RID: 34028 RVA: 0x00264E44 File Offset: 0x00263044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00264E54 File Offset: 0x00263054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightResultListEntry other)
		{
			return true;
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x00264E64 File Offset: 0x00263064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x00264E74 File Offset: 0x00263074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00264E84 File Offset: 0x00263084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x00264E94 File Offset: 0x00263094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x00264EA4 File Offset: 0x002630A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x00264EB4 File Offset: 0x002630B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightResultListEntry other)
		{
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x00264EC4 File Offset: 0x002630C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x00264ED4 File Offset: 0x002630D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x00264EE4 File Offset: 0x002630E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightResultListEntry()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					FightResultListEntry._parser = new MessageParser<FightResultListEntry>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x00264FC8 File Offset: 0x002631C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bwjSxAJspGHkyuDbGgcU()
		{
			return true;
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00264FD0 File Offset: 0x002631D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightResultListEntry H9EMddJsHN0PTs414Kjq()
		{
			return null;
		}

		// Token: 0x0400309A RID: 12442
		private static readonly MessageParser<FightResultListEntry> _parser;

		// Token: 0x0400309B RID: 12443
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400309C RID: 12444
		public const int OutcomeFieldNumber = 1;

		// Token: 0x0400309D RID: 12445
		private FightOutcome outcome_;

		// Token: 0x0400309E RID: 12446
		public const int WaveFieldNumber = 2;

		// Token: 0x0400309F RID: 12447
		private int wave_;

		// Token: 0x040030A0 RID: 12448
		public const int RewardsFieldNumber = 3;

		// Token: 0x040030A1 RID: 12449
		private FightResultListEntry.Types.FightLoot rewards_;

		// Token: 0x040030A2 RID: 12450
		public const int FighterListEntryFieldNumber = 4;

		// Token: 0x040030A3 RID: 12451
		private FightResultListEntry.Types.FighterListEntry fighterListEntry_;

		// Token: 0x040030A4 RID: 12452
		internal static FightResultListEntry FHTBGmJsTidgYCc40aik;

		// Token: 0x02000ADC RID: 2780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060084F9 RID: 34041 RVA: 0x002E2578 File Offset: 0x002E0778
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000ADD RID: 2781
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FightLoot : IMessage<FightResultListEntry.Types.FightLoot>, IMessage, IEquatable<FightResultListEntry.Types.FightLoot>, IDeepCloneable<FightResultListEntry.Types.FightLoot>, IBufferMessage
			{
				// Token: 0x1700186B RID: 6251
				// (get) Token: 0x060084FA RID: 34042 RVA: 0x0030902C File Offset: 0x0030722C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FightResultListEntry.Types.FightLoot> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700186C RID: 6252
				// (get) Token: 0x060084FB RID: 34043 RVA: 0x0030903C File Offset: 0x0030723C
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

				// Token: 0x1700186D RID: 6253
				// (get) Token: 0x060084FC RID: 34044 RVA: 0x0030904C File Offset: 0x0030724C
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

				// Token: 0x060084FD RID: 34045 RVA: 0x0030905C File Offset: 0x0030725C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightLoot()
				{
				}

				// Token: 0x060084FE RID: 34046 RVA: 0x0030906C File Offset: 0x0030726C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightLoot(FightResultListEntry.Types.FightLoot other)
				{
				}

				// Token: 0x060084FF RID: 34047 RVA: 0x0030907C File Offset: 0x0030727C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightResultListEntry.Types.FightLoot Clone()
				{
					return null;
				}

				// Token: 0x1700186E RID: 6254
				// (get) Token: 0x06008500 RID: 34048 RVA: 0x0030908C File Offset: 0x0030728C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<FightResultListEntry.Types.FightLoot.Types.Object> Objects
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700186F RID: 6255
				// (get) Token: 0x06008501 RID: 34049 RVA: 0x0030909C File Offset: 0x0030729C
				// (set) Token: 0x06008502 RID: 34050 RVA: 0x003090AC File Offset: 0x003072AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Kamas
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

				// Token: 0x06008503 RID: 34051 RVA: 0x003090BC File Offset: 0x003072BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008504 RID: 34052 RVA: 0x003090CC File Offset: 0x003072CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightResultListEntry.Types.FightLoot other)
				{
					return true;
				}

				// Token: 0x06008505 RID: 34053 RVA: 0x003090DC File Offset: 0x003072DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008506 RID: 34054 RVA: 0x003090EC File Offset: 0x003072EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008507 RID: 34055 RVA: 0x003090FC File Offset: 0x003072FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008508 RID: 34056 RVA: 0x0030910C File Offset: 0x0030730C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008509 RID: 34057 RVA: 0x0030911C File Offset: 0x0030731C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600850A RID: 34058 RVA: 0x0030912C File Offset: 0x0030732C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightResultListEntry.Types.FightLoot other)
				{
				}

				// Token: 0x0600850B RID: 34059 RVA: 0x0030913C File Offset: 0x0030733C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600850C RID: 34060 RVA: 0x0030914C File Offset: 0x0030734C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600850D RID: 34061 RVA: 0x0030915C File Offset: 0x0030735C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FightLoot()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							FightResultListEntry.Types.FightLoot._repeated_objects_codec = FieldCodec.ForMessage<FightResultListEntry.Types.FightLoot.Types.Object>(10U, ewRBrdBISlAL9VjQVLH5.XVInXhlssT(ewRBrdBISlAL9VjQVLH5.y9tBIMyuhJT));
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 4:
							FightResultListEntry.Types.FightLoot._parser = new MessageParser<FightResultListEntry.Types.FightLoot>(() => null);
							num2 = 3;
							continue;
						case 5:
							return;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x0600850E RID: 34062 RVA: 0x00309278 File Offset: 0x00307478
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool HrPsNiGui0FFicWYMTZX()
				{
					return true;
				}

				// Token: 0x0600850F RID: 34063 RVA: 0x00309280 File Offset: 0x00307480
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightResultListEntry.Types.FightLoot SjhZAnGuP5pHw5KWJgld()
				{
					return null;
				}

				// Token: 0x040030A5 RID: 12453
				private static readonly MessageParser<FightResultListEntry.Types.FightLoot> _parser;

				// Token: 0x040030A6 RID: 12454
				private UnknownFieldSet _unknownFields;

				// Token: 0x040030A7 RID: 12455
				public const int ObjectsFieldNumber = 1;

				// Token: 0x040030A8 RID: 12456
				private static readonly FieldCodec<FightResultListEntry.Types.FightLoot.Types.Object> _repeated_objects_codec;

				// Token: 0x040030A9 RID: 12457
				private readonly RepeatedField<FightResultListEntry.Types.FightLoot.Types.Object> objects_;

				// Token: 0x040030AA RID: 12458
				public const int KamasFieldNumber = 2;

				// Token: 0x040030AB RID: 12459
				private long kamas_;

				// Token: 0x040030AC RID: 12460
				private static FightResultListEntry.Types.FightLoot ygue7kGube1VdNGfYsBo;

				// Token: 0x02000ADE RID: 2782
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x06008510 RID: 34064 RVA: 0x00318058 File Offset: 0x00316258
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000ADF RID: 2783
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Object : IMessage<FightResultListEntry.Types.FightLoot.Types.Object>, IMessage, IEquatable<FightResultListEntry.Types.FightLoot.Types.Object>, IDeepCloneable<FightResultListEntry.Types.FightLoot.Types.Object>, IBufferMessage
					{
						// Token: 0x17001870 RID: 6256
						// (get) Token: 0x06008511 RID: 34065 RVA: 0x0031DBBC File Offset: 0x0031BDBC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<FightResultListEntry.Types.FightLoot.Types.Object> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001871 RID: 6257
						// (get) Token: 0x06008512 RID: 34066 RVA: 0x0031DBCC File Offset: 0x0031BDCC
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

						// Token: 0x17001872 RID: 6258
						// (get) Token: 0x06008513 RID: 34067 RVA: 0x0031DBDC File Offset: 0x0031BDDC
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

						// Token: 0x06008514 RID: 34068 RVA: 0x0031DBEC File Offset: 0x0031BDEC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Object()
						{
						}

						// Token: 0x06008515 RID: 34069 RVA: 0x0031DBFC File Offset: 0x0031BDFC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Object(FightResultListEntry.Types.FightLoot.Types.Object other)
						{
						}

						// Token: 0x06008516 RID: 34070 RVA: 0x0031DC0C File Offset: 0x0031BE0C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightResultListEntry.Types.FightLoot.Types.Object Clone()
						{
							return null;
						}

						// Token: 0x17001873 RID: 6259
						// (get) Token: 0x06008517 RID: 34071 RVA: 0x0031DC1C File Offset: 0x0031BE1C
						// (set) Token: 0x06008518 RID: 34072 RVA: 0x0031DC2C File Offset: 0x0031BE2C
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

						// Token: 0x17001874 RID: 6260
						// (get) Token: 0x06008519 RID: 34073 RVA: 0x0031DC3C File Offset: 0x0031BE3C
						// (set) Token: 0x0600851A RID: 34074 RVA: 0x0031DC4C File Offset: 0x0031BE4C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int Quantity
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

						// Token: 0x17001875 RID: 6261
						// (get) Token: 0x0600851B RID: 34075 RVA: 0x0031DC5C File Offset: 0x0031BE5C
						// (set) Token: 0x0600851C RID: 34076 RVA: 0x0031DC6C File Offset: 0x0031BE6C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int PriorityHint
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

						// Token: 0x0600851D RID: 34077 RVA: 0x0031DC7C File Offset: 0x0031BE7C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600851E RID: 34078 RVA: 0x0031DC8C File Offset: 0x0031BE8C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(FightResultListEntry.Types.FightLoot.Types.Object other)
						{
							return true;
						}

						// Token: 0x0600851F RID: 34079 RVA: 0x0031DC9C File Offset: 0x0031BE9C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06008520 RID: 34080 RVA: 0x0031DCAC File Offset: 0x0031BEAC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06008521 RID: 34081 RVA: 0x0031DCBC File Offset: 0x0031BEBC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06008522 RID: 34082 RVA: 0x0031DCCC File Offset: 0x0031BECC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06008523 RID: 34083 RVA: 0x0031DCDC File Offset: 0x0031BEDC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06008524 RID: 34084 RVA: 0x0031DCEC File Offset: 0x0031BEEC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(FightResultListEntry.Types.FightLoot.Types.Object other)
						{
						}

						// Token: 0x06008525 RID: 34085 RVA: 0x0031DCFC File Offset: 0x0031BEFC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06008526 RID: 34086 RVA: 0x0031DD0C File Offset: 0x0031BF0C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06008527 RID: 34087 RVA: 0x0031DD1C File Offset: 0x0031BF1C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Object()
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
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
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
									FightResultListEntry.Types.FightLoot.Types.Object._parser = new MessageParser<FightResultListEntry.Types.FightLoot.Types.Object>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								}
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 4;
							}
						}

						// Token: 0x06008528 RID: 34088 RVA: 0x0031DDE8 File Offset: 0x0031BFE8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool gf7rZOgJtMhWukX2euPo()
						{
							return true;
						}

						// Token: 0x06008529 RID: 34089 RVA: 0x0031DDF0 File Offset: 0x0031BFF0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static FightResultListEntry.Types.FightLoot.Types.Object hp7v6YgJwGxXKfgBHlG8()
						{
							return null;
						}

						// Token: 0x040030AD RID: 12461
						private static readonly MessageParser<FightResultListEntry.Types.FightLoot.Types.Object> _parser;

						// Token: 0x040030AE RID: 12462
						private UnknownFieldSet _unknownFields;

						// Token: 0x040030AF RID: 12463
						public const int IdFieldNumber = 1;

						// Token: 0x040030B0 RID: 12464
						private int id_;

						// Token: 0x040030B1 RID: 12465
						public const int QuantityFieldNumber = 2;

						// Token: 0x040030B2 RID: 12466
						private int quantity_;

						// Token: 0x040030B3 RID: 12467
						public const int PriorityHintFieldNumber = 3;

						// Token: 0x040030B4 RID: 12468
						private int priorityHint_;

						// Token: 0x040030B5 RID: 12469
						private static FightResultListEntry.Types.FightLoot.Types.Object WpldqHgJD1n516E4frG1;
					}
				}
			}

			// Token: 0x02000AE2 RID: 2786
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FighterListEntry : IMessage<FightResultListEntry.Types.FighterListEntry>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry>, IBufferMessage
			{
				// Token: 0x17001876 RID: 6262
				// (get) Token: 0x06008534 RID: 34100 RVA: 0x00309288 File Offset: 0x00307488
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FightResultListEntry.Types.FighterListEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001877 RID: 6263
				// (get) Token: 0x06008535 RID: 34101 RVA: 0x00309298 File Offset: 0x00307498
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

				// Token: 0x17001878 RID: 6264
				// (get) Token: 0x06008536 RID: 34102 RVA: 0x003092A8 File Offset: 0x003074A8
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

				// Token: 0x06008537 RID: 34103 RVA: 0x003092B8 File Offset: 0x003074B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterListEntry()
				{
				}

				// Token: 0x06008538 RID: 34104 RVA: 0x003092C8 File Offset: 0x003074C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterListEntry(FightResultListEntry.Types.FighterListEntry other)
				{
				}

				// Token: 0x06008539 RID: 34105 RVA: 0x003092D8 File Offset: 0x003074D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightResultListEntry.Types.FighterListEntry Clone()
				{
					return null;
				}

				// Token: 0x17001879 RID: 6265
				// (get) Token: 0x0600853A RID: 34106 RVA: 0x003092E8 File Offset: 0x003074E8
				// (set) Token: 0x0600853B RID: 34107 RVA: 0x003092F8 File Offset: 0x003074F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long FighterId
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

				// Token: 0x1700187A RID: 6266
				// (get) Token: 0x0600853C RID: 34108 RVA: 0x00309308 File Offset: 0x00307508
				// (set) Token: 0x0600853D RID: 34109 RVA: 0x00309318 File Offset: 0x00307518
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Alive
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

				// Token: 0x1700187B RID: 6267
				// (get) Token: 0x0600853E RID: 34110 RVA: 0x00309328 File Offset: 0x00307528
				// (set) Token: 0x0600853F RID: 34111 RVA: 0x00309338 File Offset: 0x00307538
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry PlayerListEntry
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

				// Token: 0x1700187C RID: 6268
				// (get) Token: 0x06008540 RID: 34112 RVA: 0x00309348 File Offset: 0x00307548
				// (set) Token: 0x06008541 RID: 34113 RVA: 0x00309358 File Offset: 0x00307558
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry MutantListEntry
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

				// Token: 0x1700187D RID: 6269
				// (get) Token: 0x06008542 RID: 34114 RVA: 0x00309368 File Offset: 0x00307568
				// (set) Token: 0x06008543 RID: 34115 RVA: 0x00309378 File Offset: 0x00307578
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry TaxCollectorListEntry
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

				// Token: 0x1700187E RID: 6270
				// (get) Token: 0x06008544 RID: 34116 RVA: 0x00309388 File Offset: 0x00307588
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FightResultListEntry.Types.FighterListEntry.ComplementOneofCase ComplementCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (FightResultListEntry.Types.FighterListEntry.ComplementOneofCase)null;
					}
				}

				// Token: 0x06008545 RID: 34117 RVA: 0x0030939C File Offset: 0x0030759C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearComplement()
				{
				}

				// Token: 0x06008546 RID: 34118 RVA: 0x003093AC File Offset: 0x003075AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008547 RID: 34119 RVA: 0x003093BC File Offset: 0x003075BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightResultListEntry.Types.FighterListEntry other)
				{
					return true;
				}

				// Token: 0x06008548 RID: 34120 RVA: 0x003093CC File Offset: 0x003075CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008549 RID: 34121 RVA: 0x003093DC File Offset: 0x003075DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600854A RID: 34122 RVA: 0x003093EC File Offset: 0x003075EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600854B RID: 34123 RVA: 0x003093FC File Offset: 0x003075FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600854C RID: 34124 RVA: 0x0030940C File Offset: 0x0030760C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600854D RID: 34125 RVA: 0x0030941C File Offset: 0x0030761C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightResultListEntry.Types.FighterListEntry other)
				{
				}

				// Token: 0x0600854E RID: 34126 RVA: 0x0030942C File Offset: 0x0030762C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600854F RID: 34127 RVA: 0x0030943C File Offset: 0x0030763C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008550 RID: 34128 RVA: 0x0030944C File Offset: 0x0030764C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FighterListEntry()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
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
							FightResultListEntry.Types.FighterListEntry._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06008551 RID: 34129 RVA: 0x00309518 File Offset: 0x00307718
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool XjHGaxGuMEDD7medl3au()
				{
					return true;
				}

				// Token: 0x06008552 RID: 34130 RVA: 0x00309520 File Offset: 0x00307720
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightResultListEntry.Types.FighterListEntry lpWsORGuujGm1fBbSZBd()
				{
					return null;
				}

				// Token: 0x040030BA RID: 12474
				private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry> _parser;

				// Token: 0x040030BB RID: 12475
				private UnknownFieldSet _unknownFields;

				// Token: 0x040030BC RID: 12476
				public const int FighterIdFieldNumber = 1;

				// Token: 0x040030BD RID: 12477
				private long fighterId_;

				// Token: 0x040030BE RID: 12478
				public const int AliveFieldNumber = 2;

				// Token: 0x040030BF RID: 12479
				private bool alive_;

				// Token: 0x040030C0 RID: 12480
				public const int PlayerListEntryFieldNumber = 3;

				// Token: 0x040030C1 RID: 12481
				public const int MutantListEntryFieldNumber = 4;

				// Token: 0x040030C2 RID: 12482
				public const int TaxCollectorListEntryFieldNumber = 5;

				// Token: 0x040030C3 RID: 12483
				private object complement_;

				// Token: 0x040030C4 RID: 12484
				private FightResultListEntry.Types.FighterListEntry.ComplementOneofCase complementCase_;

				// Token: 0x040030C5 RID: 12485
				internal static FightResultListEntry.Types.FighterListEntry jcqTrFGuSAwSLmLsCbH3;

				// Token: 0x02000AE3 RID: 2787
				public enum ComplementOneofCase
				{
					// Token: 0x040030C7 RID: 12487
					None,
					// Token: 0x040030C8 RID: 12488
					PlayerListEntry = 3,
					// Token: 0x040030C9 RID: 12489
					MutantListEntry,
					// Token: 0x040030CA RID: 12490
					TaxCollectorListEntry
				}

				// Token: 0x02000AE4 RID: 2788
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x06008553 RID: 34131 RVA: 0x00318150 File Offset: 0x00316350
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000AE5 RID: 2789
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class PlayerListEntry : IMessage<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry>, IBufferMessage
					{
						// Token: 0x1700187F RID: 6271
						// (get) Token: 0x06008554 RID: 34132 RVA: 0x0031DDF8 File Offset: 0x0031BFF8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001880 RID: 6272
						// (get) Token: 0x06008555 RID: 34133 RVA: 0x0031DE08 File Offset: 0x0031C008
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

						// Token: 0x17001881 RID: 6273
						// (get) Token: 0x06008556 RID: 34134 RVA: 0x0031DE18 File Offset: 0x0031C018
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

						// Token: 0x06008557 RID: 34135 RVA: 0x0031DE28 File Offset: 0x0031C028
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PlayerListEntry()
						{
						}

						// Token: 0x06008558 RID: 34136 RVA: 0x0031DE38 File Offset: 0x0031C038
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PlayerListEntry(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry other)
						{
						}

						// Token: 0x06008559 RID: 34137 RVA: 0x0031DE48 File Offset: 0x0031C048
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry Clone()
						{
							return null;
						}

						// Token: 0x17001882 RID: 6274
						// (get) Token: 0x0600855A RID: 34138 RVA: 0x0031DE58 File Offset: 0x0031C058
						// (set) Token: 0x0600855B RID: 34139 RVA: 0x0031DE68 File Offset: 0x0031C068
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

						// Token: 0x17001883 RID: 6275
						// (get) Token: 0x0600855C RID: 34140 RVA: 0x0031DE78 File Offset: 0x0031C078
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public RepeatedField<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData> Additional
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x0600855D RID: 34141 RVA: 0x0031DE88 File Offset: 0x0031C088
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600855E RID: 34142 RVA: 0x0031DE98 File Offset: 0x0031C098
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry other)
						{
							return true;
						}

						// Token: 0x0600855F RID: 34143 RVA: 0x0031DEA8 File Offset: 0x0031C0A8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06008560 RID: 34144 RVA: 0x0031DEB8 File Offset: 0x0031C0B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06008561 RID: 34145 RVA: 0x0031DEC8 File Offset: 0x0031C0C8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06008562 RID: 34146 RVA: 0x0031DED8 File Offset: 0x0031C0D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06008563 RID: 34147 RVA: 0x0031DEE8 File Offset: 0x0031C0E8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06008564 RID: 34148 RVA: 0x0031DEF8 File Offset: 0x0031C0F8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry other)
						{
						}

						// Token: 0x06008565 RID: 34149 RVA: 0x0031DF08 File Offset: 0x0031C108
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06008566 RID: 34150 RVA: 0x0031DF18 File Offset: 0x0031C118
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06008567 RID: 34151 RVA: 0x0031DF28 File Offset: 0x0031C128
						[MethodImpl(MethodImplOptions.NoInlining)]
						static PlayerListEntry()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry._repeated_additional_codec = FieldCodec.ForMessage<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData>(18U, oXBrwsBIFW0Y6SL2hpBj.XVInXhlssT(oXBrwsBIFW0Y6SL2hpBj.PrDBIzBrDWL));
									num2 = 2;
									continue;
								case 2:
									return;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
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
									FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry>(() => null);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 5;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
								{
									num2 = 5;
								}
							}
						}

						// Token: 0x06008568 RID: 34152 RVA: 0x0031E030 File Offset: 0x0031C230
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool J32pAegJ7TqbNTZaCY4e()
						{
							return true;
						}

						// Token: 0x06008569 RID: 34153 RVA: 0x0031E038 File Offset: 0x0031C238
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry M6tKIVgJT7yKIVix5CIE()
						{
							return null;
						}

						// Token: 0x040030CB RID: 12491
						private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry> _parser;

						// Token: 0x040030CC RID: 12492
						private UnknownFieldSet _unknownFields;

						// Token: 0x040030CD RID: 12493
						public const int LevelFieldNumber = 1;

						// Token: 0x040030CE RID: 12494
						private int level_;

						// Token: 0x040030CF RID: 12495
						public const int AdditionalFieldNumber = 2;

						// Token: 0x040030D0 RID: 12496
						private static readonly FieldCodec<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData> _repeated_additional_codec;

						// Token: 0x040030D1 RID: 12497
						private readonly RepeatedField<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData> additional_;

						// Token: 0x040030D2 RID: 12498
						internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry J70PCLgJQfMSNC6UAdl7;

						// Token: 0x02000AE6 RID: 2790
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static class Types
						{
							// Token: 0x0600856A RID: 34154 RVA: 0x00321C38 File Offset: 0x0031FE38
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x02000AE7 RID: 2791
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class FightResultAdditionalData : IMessage<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData>, IBufferMessage
							{
								// Token: 0x17001884 RID: 6276
								// (get) Token: 0x0600856B RID: 34155 RVA: 0x00324B10 File Offset: 0x00322D10
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17001885 RID: 6277
								// (get) Token: 0x0600856C RID: 34156 RVA: 0x00324B20 File Offset: 0x00322D20
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

								// Token: 0x17001886 RID: 6278
								// (get) Token: 0x0600856D RID: 34157 RVA: 0x00324B30 File Offset: 0x00322D30
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

								// Token: 0x0600856E RID: 34158 RVA: 0x00324B40 File Offset: 0x00322D40
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public FightResultAdditionalData()
								{
								}

								// Token: 0x0600856F RID: 34159 RVA: 0x00324B50 File Offset: 0x00322D50
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public FightResultAdditionalData(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData other)
								{
								}

								// Token: 0x06008570 RID: 34160 RVA: 0x00324B60 File Offset: 0x00322D60
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData Clone()
								{
									return null;
								}

								// Token: 0x17001887 RID: 6279
								// (get) Token: 0x06008571 RID: 34161 RVA: 0x00324B70 File Offset: 0x00322D70
								// (set) Token: 0x06008572 RID: 34162 RVA: 0x00324B80 File Offset: 0x00322D80
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData ExperienceData
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

								// Token: 0x17001888 RID: 6280
								// (get) Token: 0x06008573 RID: 34163 RVA: 0x00324B90 File Offset: 0x00322D90
								// (set) Token: 0x06008574 RID: 34164 RVA: 0x00324BA0 File Offset: 0x00322DA0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData PvpData
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

								// Token: 0x17001889 RID: 6281
								// (get) Token: 0x06008575 RID: 34165 RVA: 0x00324BB0 File Offset: 0x00322DB0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.AdditionalDataOneofCase AdditionalDataCase
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return (FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.AdditionalDataOneofCase)null;
									}
								}

								// Token: 0x06008576 RID: 34166 RVA: 0x00324BC4 File Offset: 0x00322DC4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void ClearAdditionalData()
								{
								}

								// Token: 0x06008577 RID: 34167 RVA: 0x00324BD4 File Offset: 0x00322DD4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06008578 RID: 34168 RVA: 0x00324BE4 File Offset: 0x00322DE4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData other)
								{
									return true;
								}

								// Token: 0x06008579 RID: 34169 RVA: 0x00324BF4 File Offset: 0x00322DF4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x0600857A RID: 34170 RVA: 0x00324C04 File Offset: 0x00322E04
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x0600857B RID: 34171 RVA: 0x00324C14 File Offset: 0x00322E14
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x0600857C RID: 34172 RVA: 0x00324C24 File Offset: 0x00322E24
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x0600857D RID: 34173 RVA: 0x00324C34 File Offset: 0x00322E34
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x0600857E RID: 34174 RVA: 0x00324C44 File Offset: 0x00322E44
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData other)
								{
								}

								// Token: 0x0600857F RID: 34175 RVA: 0x00324C54 File Offset: 0x00322E54
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06008580 RID: 34176 RVA: 0x00324C64 File Offset: 0x00322E64
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06008581 RID: 34177 RVA: 0x00324C74 File Offset: 0x00322E74
								[MethodImpl(MethodImplOptions.NoInlining)]
								static FightResultAdditionalData()
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
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 3:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 2;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 4:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 3;
											continue;
										}
										FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData>(() => null);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
										{
											num2 = 1;
										}
									}
								}

								// Token: 0x06008582 RID: 34178 RVA: 0x00324D58 File Offset: 0x00322F58
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool OyBjVLg9fCekc2empwHE()
								{
									return true;
								}

								// Token: 0x06008583 RID: 34179 RVA: 0x00324D60 File Offset: 0x00322F60
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData RFafhPg9nPoBKcsX49IY()
								{
									return null;
								}

								// Token: 0x040030D3 RID: 12499
								private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData> _parser;

								// Token: 0x040030D4 RID: 12500
								private UnknownFieldSet _unknownFields;

								// Token: 0x040030D5 RID: 12501
								public const int ExperienceDataFieldNumber = 1;

								// Token: 0x040030D6 RID: 12502
								public const int PvpDataFieldNumber = 2;

								// Token: 0x040030D7 RID: 12503
								private object additionalData_;

								// Token: 0x040030D8 RID: 12504
								private FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.AdditionalDataOneofCase additionalDataCase_;

								// Token: 0x040030D9 RID: 12505
								private static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData WLx6bigdzHEOG24JMPrV;

								// Token: 0x02000AE8 RID: 2792
								public enum AdditionalDataOneofCase
								{
									// Token: 0x040030DB RID: 12507
									None,
									// Token: 0x040030DC RID: 12508
									ExperienceData,
									// Token: 0x040030DD RID: 12509
									PvpData
								}

								// Token: 0x02000AE9 RID: 2793
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static class Types
								{
									// Token: 0x06008584 RID: 34180 RVA: 0x00325AD0 File Offset: 0x00323CD0
									[MethodImpl(MethodImplOptions.NoInlining)]
									static Types()
									{
										uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									}

									// Token: 0x02000AEA RID: 2794
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class ExperienceData : IMessage<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData>, IBufferMessage
									{
										// Token: 0x1700188A RID: 6282
										// (get) Token: 0x06008585 RID: 34181 RVA: 0x00327960 File Offset: 0x00325B60
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700188B RID: 6283
										// (get) Token: 0x06008586 RID: 34182 RVA: 0x00327970 File Offset: 0x00325B70
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

										// Token: 0x1700188C RID: 6284
										// (get) Token: 0x06008587 RID: 34183 RVA: 0x00327980 File Offset: 0x00325B80
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

										// Token: 0x06008588 RID: 34184 RVA: 0x00327990 File Offset: 0x00325B90
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ExperienceData()
										{
										}

										// Token: 0x06008589 RID: 34185 RVA: 0x003279A0 File Offset: 0x00325BA0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public ExperienceData(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData other)
										{
										}

										// Token: 0x0600858A RID: 34186 RVA: 0x003279B0 File Offset: 0x00325BB0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData Clone()
										{
											return null;
										}

										// Token: 0x1700188D RID: 6285
										// (get) Token: 0x0600858B RID: 34187 RVA: 0x003279C0 File Offset: 0x00325BC0
										// (set) Token: 0x0600858C RID: 34188 RVA: 0x003279D0 File Offset: 0x00325BD0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public long Experience
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

										// Token: 0x1700188E RID: 6286
										// (get) Token: 0x0600858D RID: 34189 RVA: 0x003279E0 File Offset: 0x00325BE0
										// (set) Token: 0x0600858E RID: 34190 RVA: 0x003279F0 File Offset: 0x00325BF0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public bool ShowExperience
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

										// Token: 0x1700188F RID: 6287
										// (get) Token: 0x0600858F RID: 34191 RVA: 0x00327A00 File Offset: 0x00325C00
										// (set) Token: 0x06008590 RID: 34192 RVA: 0x00327A10 File Offset: 0x00325C10
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public long ExperienceLevelFloor
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

										// Token: 0x17001890 RID: 6288
										// (get) Token: 0x06008591 RID: 34193 RVA: 0x00327A20 File Offset: 0x00325C20
										// (set) Token: 0x06008592 RID: 34194 RVA: 0x00327A30 File Offset: 0x00325C30
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public bool ShowExperienceLevelFloor
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

										// Token: 0x17001891 RID: 6289
										// (get) Token: 0x06008593 RID: 34195 RVA: 0x00327A40 File Offset: 0x00325C40
										// (set) Token: 0x06008594 RID: 34196 RVA: 0x00327A50 File Offset: 0x00325C50
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public long ExperienceNextLevelFloor
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

										// Token: 0x17001892 RID: 6290
										// (get) Token: 0x06008595 RID: 34197 RVA: 0x00327A60 File Offset: 0x00325C60
										// (set) Token: 0x06008596 RID: 34198 RVA: 0x00327A70 File Offset: 0x00325C70
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public bool ShowExperienceNextLevelFloor
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

										// Token: 0x17001893 RID: 6291
										// (get) Token: 0x06008597 RID: 34199 RVA: 0x00327A80 File Offset: 0x00325C80
										// (set) Token: 0x06008598 RID: 34200 RVA: 0x00327A90 File Offset: 0x00325C90
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public long ExperienceFightDelta
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

										// Token: 0x17001894 RID: 6292
										// (get) Token: 0x06008599 RID: 34201 RVA: 0x00327AA0 File Offset: 0x00325CA0
										// (set) Token: 0x0600859A RID: 34202 RVA: 0x00327AB0 File Offset: 0x00325CB0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public bool ShowExperienceFightDelta
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

										// Token: 0x17001895 RID: 6293
										// (get) Token: 0x0600859B RID: 34203 RVA: 0x00327AC0 File Offset: 0x00325CC0
										// (set) Token: 0x0600859C RID: 34204 RVA: 0x00327AD0 File Offset: 0x00325CD0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public long ExperienceForGuild
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

										// Token: 0x17001896 RID: 6294
										// (get) Token: 0x0600859D RID: 34205 RVA: 0x00327AE0 File Offset: 0x00325CE0
										// (set) Token: 0x0600859E RID: 34206 RVA: 0x00327AF0 File Offset: 0x00325CF0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public bool ShowExperienceForGuild
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

										// Token: 0x17001897 RID: 6295
										// (get) Token: 0x0600859F RID: 34207 RVA: 0x00327B00 File Offset: 0x00325D00
										// (set) Token: 0x060085A0 RID: 34208 RVA: 0x00327B10 File Offset: 0x00325D10
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public long ExperienceForMount
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

										// Token: 0x17001898 RID: 6296
										// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00327B20 File Offset: 0x00325D20
										// (set) Token: 0x060085A2 RID: 34210 RVA: 0x00327B30 File Offset: 0x00325D30
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public bool ShowExperienceForMount
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

										// Token: 0x17001899 RID: 6297
										// (get) Token: 0x060085A3 RID: 34211 RVA: 0x00327B40 File Offset: 0x00325D40
										// (set) Token: 0x060085A4 RID: 34212 RVA: 0x00327B50 File Offset: 0x00325D50
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int ReRollExperienceMultiplier
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

										// Token: 0x060085A5 RID: 34213 RVA: 0x00327B60 File Offset: 0x00325D60
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x060085A6 RID: 34214 RVA: 0x00327B70 File Offset: 0x00325D70
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData other)
										{
											return true;
										}

										// Token: 0x060085A7 RID: 34215 RVA: 0x00327B80 File Offset: 0x00325D80
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x060085A8 RID: 34216 RVA: 0x00327B90 File Offset: 0x00325D90
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x060085A9 RID: 34217 RVA: 0x00327BA0 File Offset: 0x00325DA0
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x060085AA RID: 34218 RVA: 0x00327BB0 File Offset: 0x00325DB0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x060085AB RID: 34219 RVA: 0x00327BC0 File Offset: 0x00325DC0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x060085AC RID: 34220 RVA: 0x00327BD0 File Offset: 0x00325DD0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData other)
										{
										}

										// Token: 0x060085AD RID: 34221 RVA: 0x00327BE0 File Offset: 0x00325DE0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x060085AE RID: 34222 RVA: 0x00327BF0 File Offset: 0x00325DF0
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x060085AF RID: 34223 RVA: 0x00327C00 File Offset: 0x00325E00
										[MethodImpl(MethodImplOptions.NoInlining)]
										static ExperienceData()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
													{
														num2 = 3;
														continue;
													}
													continue;
												case 2:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 3:
													FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData>(() => null);
													num2 = 0;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
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
												break;
											}
										}

										// Token: 0x060085B0 RID: 34224 RVA: 0x00327CE4 File Offset: 0x00325EE4
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool LqkJNYg2zjxR1wRIm2eE()
										{
											return true;
										}

										// Token: 0x060085B1 RID: 34225 RVA: 0x00327CEC File Offset: 0x00325EEC
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData R6Qcr6gEfEmsPKlu4pNA()
										{
											return null;
										}

										// Token: 0x040030DE RID: 12510
										private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData> _parser;

										// Token: 0x040030DF RID: 12511
										private UnknownFieldSet _unknownFields;

										// Token: 0x040030E0 RID: 12512
										public const int ExperienceFieldNumber = 1;

										// Token: 0x040030E1 RID: 12513
										private long experience_;

										// Token: 0x040030E2 RID: 12514
										public const int ShowExperienceFieldNumber = 2;

										// Token: 0x040030E3 RID: 12515
										private bool showExperience_;

										// Token: 0x040030E4 RID: 12516
										public const int ExperienceLevelFloorFieldNumber = 3;

										// Token: 0x040030E5 RID: 12517
										private long experienceLevelFloor_;

										// Token: 0x040030E6 RID: 12518
										public const int ShowExperienceLevelFloorFieldNumber = 4;

										// Token: 0x040030E7 RID: 12519
										private bool showExperienceLevelFloor_;

										// Token: 0x040030E8 RID: 12520
										public const int ExperienceNextLevelFloorFieldNumber = 5;

										// Token: 0x040030E9 RID: 12521
										private long experienceNextLevelFloor_;

										// Token: 0x040030EA RID: 12522
										public const int ShowExperienceNextLevelFloorFieldNumber = 6;

										// Token: 0x040030EB RID: 12523
										private bool showExperienceNextLevelFloor_;

										// Token: 0x040030EC RID: 12524
										public const int ExperienceFightDeltaFieldNumber = 7;

										// Token: 0x040030ED RID: 12525
										private long experienceFightDelta_;

										// Token: 0x040030EE RID: 12526
										public const int ShowExperienceFightDeltaFieldNumber = 8;

										// Token: 0x040030EF RID: 12527
										private bool showExperienceFightDelta_;

										// Token: 0x040030F0 RID: 12528
										public const int ExperienceForGuildFieldNumber = 9;

										// Token: 0x040030F1 RID: 12529
										private long experienceForGuild_;

										// Token: 0x040030F2 RID: 12530
										public const int ShowExperienceForGuildFieldNumber = 10;

										// Token: 0x040030F3 RID: 12531
										private bool showExperienceForGuild_;

										// Token: 0x040030F4 RID: 12532
										public const int ExperienceForMountFieldNumber = 11;

										// Token: 0x040030F5 RID: 12533
										private long experienceForMount_;

										// Token: 0x040030F6 RID: 12534
										public const int ShowExperienceForMountFieldNumber = 12;

										// Token: 0x040030F7 RID: 12535
										private bool showExperienceForMount_;

										// Token: 0x040030F8 RID: 12536
										public const int ReRollExperienceMultiplierFieldNumber = 13;

										// Token: 0x040030F9 RID: 12537
										private int reRollExperienceMultiplier_;

										// Token: 0x040030FA RID: 12538
										internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.ExperienceData LAusSkg2FTPsWfL5rl0a;
									}

									// Token: 0x02000AEC RID: 2796
									[DebuggerDisplay("{ToString(),nq}")]
									public sealed class PvpData : IMessage<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData>, IBufferMessage
									{
										// Token: 0x1700189A RID: 6298
										// (get) Token: 0x060085B7 RID: 34231 RVA: 0x00327CF4 File Offset: 0x00325EF4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData> Parser
										{
											[MethodImpl(MethodImplOptions.NoInlining)]
											get
											{
												return null;
											}
										}

										// Token: 0x1700189B RID: 6299
										// (get) Token: 0x060085B8 RID: 34232 RVA: 0x00327D04 File Offset: 0x00325F04
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

										// Token: 0x1700189C RID: 6300
										// (get) Token: 0x060085B9 RID: 34233 RVA: 0x00327D14 File Offset: 0x00325F14
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

										// Token: 0x060085BA RID: 34234 RVA: 0x00327D24 File Offset: 0x00325F24
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PvpData()
										{
										}

										// Token: 0x060085BB RID: 34235 RVA: 0x00327D34 File Offset: 0x00325F34
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public PvpData(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData other)
										{
										}

										// Token: 0x060085BC RID: 34236 RVA: 0x00327D44 File Offset: 0x00325F44
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData Clone()
										{
											return null;
										}

										// Token: 0x1700189D RID: 6301
										// (get) Token: 0x060085BD RID: 34237 RVA: 0x00327D54 File Offset: 0x00325F54
										// (set) Token: 0x060085BE RID: 34238 RVA: 0x00327D64 File Offset: 0x00325F64
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

										// Token: 0x1700189E RID: 6302
										// (get) Token: 0x060085BF RID: 34239 RVA: 0x00327D74 File Offset: 0x00325F74
										// (set) Token: 0x060085C0 RID: 34240 RVA: 0x00327D84 File Offset: 0x00325F84
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int MinHonorForGrade
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

										// Token: 0x1700189F RID: 6303
										// (get) Token: 0x060085C1 RID: 34241 RVA: 0x00327D94 File Offset: 0x00325F94
										// (set) Token: 0x060085C2 RID: 34242 RVA: 0x00327DA4 File Offset: 0x00325FA4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										public int MaxHonorForGrade
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

										// Token: 0x170018A0 RID: 6304
										// (get) Token: 0x060085C3 RID: 34243 RVA: 0x00327DB4 File Offset: 0x00325FB4
										// (set) Token: 0x060085C4 RID: 34244 RVA: 0x00327DC4 File Offset: 0x00325FC4
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
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

										// Token: 0x170018A1 RID: 6305
										// (get) Token: 0x060085C5 RID: 34245 RVA: 0x00327DD4 File Offset: 0x00325FD4
										// (set) Token: 0x060085C6 RID: 34246 RVA: 0x00327DE4 File Offset: 0x00325FE4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										public int HonorDelta
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

										// Token: 0x060085C7 RID: 34247 RVA: 0x00327DF4 File Offset: 0x00325FF4
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override bool Equals(object other)
										{
											return true;
										}

										// Token: 0x060085C8 RID: 34248 RVA: 0x00327E04 File Offset: 0x00326004
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData other)
										{
											return true;
										}

										// Token: 0x060085C9 RID: 34249 RVA: 0x00327E14 File Offset: 0x00326014
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override int GetHashCode()
										{
											return 0;
										}

										// Token: 0x060085CA RID: 34250 RVA: 0x00327E24 File Offset: 0x00326024
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public override string ToString()
										{
											return null;
										}

										// Token: 0x060085CB RID: 34251 RVA: 0x00327E34 File Offset: 0x00326034
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void WriteTo(CodedOutputStream output)
										{
										}

										// Token: 0x060085CC RID: 34252 RVA: 0x00327E44 File Offset: 0x00326044
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalWriteTo(ref WriteContext output)
										{
										}

										// Token: 0x060085CD RID: 34253 RVA: 0x00327E54 File Offset: 0x00326054
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public int CalculateSize()
										{
											return 0;
										}

										// Token: 0x060085CE RID: 34254 RVA: 0x00327E64 File Offset: 0x00326064
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData other)
										{
										}

										// Token: 0x060085CF RID: 34255 RVA: 0x00327E74 File Offset: 0x00326074
										[GeneratedCode("protoc", null)]
										[DebuggerNonUserCode]
										[MethodImpl(MethodImplOptions.NoInlining)]
										public void MergeFrom(CodedInputStream input)
										{
										}

										// Token: 0x060085D0 RID: 34256 RVA: 0x00327E84 File Offset: 0x00326084
										[DebuggerNonUserCode]
										[GeneratedCode("protoc", null)]
										[MethodImpl(MethodImplOptions.NoInlining)]
										void IBufferMessage.InternalMergeFrom(ref ParseContext input)
										{
										}

										// Token: 0x060085D1 RID: 34257 RVA: 0x00327E94 File Offset: 0x00326094
										[MethodImpl(MethodImplOptions.NoInlining)]
										static PvpData()
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
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 2:
													xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
													num2 = 1;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
													{
														num2 = 0;
														continue;
													}
													continue;
												case 3:
													return;
												case 4:
													FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData>(() => null);
													num2 = 2;
													if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
													{
														num2 = 3;
														continue;
													}
													continue;
												}
												UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
												num2 = 4;
												if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
												{
													num2 = 4;
												}
											}
										}

										// Token: 0x060085D2 RID: 34258 RVA: 0x00327F8C File Offset: 0x0032618C
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static bool PSXLs2gEmo5wryM0Onkj()
										{
											return true;
										}

										// Token: 0x060085D3 RID: 34259 RVA: 0x00327F94 File Offset: 0x00326194
										[MethodImpl(MethodImplOptions.NoInlining)]
										internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData wFtbYkgEASSq8BDdkxvs()
										{
											return null;
										}

										// Token: 0x040030FD RID: 12541
										private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData> _parser;

										// Token: 0x040030FE RID: 12542
										private UnknownFieldSet _unknownFields;

										// Token: 0x040030FF RID: 12543
										public const int GradeFieldNumber = 1;

										// Token: 0x04003100 RID: 12544
										private int grade_;

										// Token: 0x04003101 RID: 12545
										public const int MinHonorForGradeFieldNumber = 2;

										// Token: 0x04003102 RID: 12546
										private int minHonorForGrade_;

										// Token: 0x04003103 RID: 12547
										public const int MaxHonorForGradeFieldNumber = 3;

										// Token: 0x04003104 RID: 12548
										private int maxHonorForGrade_;

										// Token: 0x04003105 RID: 12549
										public const int HonorFieldNumber = 4;

										// Token: 0x04003106 RID: 12550
										private int honor_;

										// Token: 0x04003107 RID: 12551
										public const int HonorDeltaFieldNumber = 5;

										// Token: 0x04003108 RID: 12552
										private int honorDelta_;

										// Token: 0x04003109 RID: 12553
										internal static FightResultListEntry.Types.FighterListEntry.Types.PlayerListEntry.Types.FightResultAdditionalData.Types.PvpData M1nFELgEnGPFfji5fVot;
									}
								}
							}
						}
					}

					// Token: 0x02000AF0 RID: 2800
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class MutantListEntry : IMessage<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry>, IBufferMessage
					{
						// Token: 0x170018A2 RID: 6306
						// (get) Token: 0x060085E3 RID: 34275 RVA: 0x0031E040 File Offset: 0x0031C240
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170018A3 RID: 6307
						// (get) Token: 0x060085E4 RID: 34276 RVA: 0x0031E050 File Offset: 0x0031C250
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

						// Token: 0x170018A4 RID: 6308
						// (get) Token: 0x060085E5 RID: 34277 RVA: 0x0031E060 File Offset: 0x0031C260
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

						// Token: 0x060085E6 RID: 34278 RVA: 0x0031E070 File Offset: 0x0031C270
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public MutantListEntry()
						{
						}

						// Token: 0x060085E7 RID: 34279 RVA: 0x0031E080 File Offset: 0x0031C280
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public MutantListEntry(FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry other)
						{
						}

						// Token: 0x060085E8 RID: 34280 RVA: 0x0031E090 File Offset: 0x0031C290
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry Clone()
						{
							return null;
						}

						// Token: 0x170018A5 RID: 6309
						// (get) Token: 0x060085E9 RID: 34281 RVA: 0x0031E0A0 File Offset: 0x0031C2A0
						// (set) Token: 0x060085EA RID: 34282 RVA: 0x0031E0B0 File Offset: 0x0031C2B0
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

						// Token: 0x060085EB RID: 34283 RVA: 0x0031E0C0 File Offset: 0x0031C2C0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060085EC RID: 34284 RVA: 0x0031E0D0 File Offset: 0x0031C2D0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry other)
						{
							return true;
						}

						// Token: 0x060085ED RID: 34285 RVA: 0x0031E0E0 File Offset: 0x0031C2E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060085EE RID: 34286 RVA: 0x0031E0F0 File Offset: 0x0031C2F0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060085EF RID: 34287 RVA: 0x0031E100 File Offset: 0x0031C300
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060085F0 RID: 34288 RVA: 0x0031E110 File Offset: 0x0031C310
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060085F1 RID: 34289 RVA: 0x0031E120 File Offset: 0x0031C320
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060085F2 RID: 34290 RVA: 0x0031E130 File Offset: 0x0031C330
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry other)
						{
						}

						// Token: 0x060085F3 RID: 34291 RVA: 0x0031E140 File Offset: 0x0031C340
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060085F4 RID: 34292 RVA: 0x0031E150 File Offset: 0x0031C350
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060085F5 RID: 34293 RVA: 0x0031E160 File Offset: 0x0031C360
						[MethodImpl(MethodImplOptions.NoInlining)]
						static MutantListEntry()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									return;
								case 3:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 4;
									continue;
								case 4:
									FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								}
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 3;
							}
						}

						// Token: 0x060085F6 RID: 34294 RVA: 0x0031E22C File Offset: 0x0031C42C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool LyFAnegJHox4rgUDCJlu()
						{
							return true;
						}

						// Token: 0x060085F7 RID: 34295 RVA: 0x0031E234 File Offset: 0x0031C434
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry z4042dgJYVsYagQaktJL()
						{
							return null;
						}

						// Token: 0x04003110 RID: 12560
						private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry> _parser;

						// Token: 0x04003111 RID: 12561
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003112 RID: 12562
						public const int LevelFieldNumber = 1;

						// Token: 0x04003113 RID: 12563
						private int level_;

						// Token: 0x04003114 RID: 12564
						internal static FightResultListEntry.Types.FighterListEntry.Types.MutantListEntry GrApEFgJp4TZbtgPS077;
					}

					// Token: 0x02000AF2 RID: 2802
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class TaxCollectorListEntry : IMessage<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry>, IMessage, IEquatable<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry>, IDeepCloneable<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry>, IBufferMessage
					{
						// Token: 0x170018A6 RID: 6310
						// (get) Token: 0x060085FD RID: 34301 RVA: 0x0031E23C File Offset: 0x0031C43C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170018A7 RID: 6311
						// (get) Token: 0x060085FE RID: 34302 RVA: 0x0031E24C File Offset: 0x0031C44C
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

						// Token: 0x170018A8 RID: 6312
						// (get) Token: 0x060085FF RID: 34303 RVA: 0x0031E25C File Offset: 0x0031C45C
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

						// Token: 0x06008600 RID: 34304 RVA: 0x0031E26C File Offset: 0x0031C46C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TaxCollectorListEntry()
						{
						}

						// Token: 0x06008601 RID: 34305 RVA: 0x0031E27C File Offset: 0x0031C47C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TaxCollectorListEntry(FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry other)
						{
						}

						// Token: 0x06008602 RID: 34306 RVA: 0x0031E28C File Offset: 0x0031C48C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry Clone()
						{
							return null;
						}

						// Token: 0x170018A9 RID: 6313
						// (get) Token: 0x06008603 RID: 34307 RVA: 0x0031E29C File Offset: 0x0031C49C
						// (set) Token: 0x06008604 RID: 34308 RVA: 0x0031E2AC File Offset: 0x0031C4AC
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

						// Token: 0x06008605 RID: 34309 RVA: 0x0031E2BC File Offset: 0x0031C4BC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06008606 RID: 34310 RVA: 0x0031E2CC File Offset: 0x0031C4CC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry other)
						{
							return true;
						}

						// Token: 0x06008607 RID: 34311 RVA: 0x0031E2DC File Offset: 0x0031C4DC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06008608 RID: 34312 RVA: 0x0031E2EC File Offset: 0x0031C4EC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06008609 RID: 34313 RVA: 0x0031E2FC File Offset: 0x0031C4FC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600860A RID: 34314 RVA: 0x0031E30C File Offset: 0x0031C50C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600860B RID: 34315 RVA: 0x0031E31C File Offset: 0x0031C51C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600860C RID: 34316 RVA: 0x0031E32C File Offset: 0x0031C52C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry other)
						{
						}

						// Token: 0x0600860D RID: 34317 RVA: 0x0031E33C File Offset: 0x0031C53C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600860E RID: 34318 RVA: 0x0031E34C File Offset: 0x0031C54C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600860F RID: 34319 RVA: 0x0031E35C File Offset: 0x0031C55C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static TaxCollectorListEntry()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
									{
										num2 = 4;
										continue;
									}
									continue;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry._parser = new MessageParser<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry>(() => null);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
								{
									num2 = 3;
								}
							}
						}

						// Token: 0x06008610 RID: 34320 RVA: 0x0031E454 File Offset: 0x0031C654
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool H5fGDDgJiLRaNkkDIJfy()
						{
							return true;
						}

						// Token: 0x06008611 RID: 34321 RVA: 0x0031E45C File Offset: 0x0031C65C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry YaPGDsgJPeNlXgZqcHZK()
						{
							return null;
						}

						// Token: 0x04003117 RID: 12567
						private static readonly MessageParser<FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry> _parser;

						// Token: 0x04003118 RID: 12568
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003119 RID: 12569
						public const int AllianceInformationFieldNumber = 1;

						// Token: 0x0400311A RID: 12570
						private AllianceInformation allianceInformation_;

						// Token: 0x0400311B RID: 12571
						private static FightResultListEntry.Types.FighterListEntry.Types.TaxCollectorListEntry W3BH59gJboDeult8UEZw;
					}
				}
			}
		}
	}
}
