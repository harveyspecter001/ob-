using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000278 RID: 632
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetListEvent : IMessage<PresetListEvent>, IMessage, IEquatable<PresetListEvent>, IDeepCloneable<PresetListEvent>, IBufferMessage
	{
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x001B33CC File Offset: 0x001B15CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x001B33DC File Offset: 0x001B15DC
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x001B33EC File Offset: 0x001B15EC
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

		// Token: 0x06001D84 RID: 7556 RVA: 0x001B33FC File Offset: 0x001B15FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetListEvent()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x001B340C File Offset: 0x001B160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetListEvent(PresetListEvent other)
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x001B341C File Offset: 0x001B161C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetListEvent Clone()
		{
			return null;
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x001B342C File Offset: 0x001B162C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PresetListEvent.Types.CharacterPresetInfoByIdEntry> CharacterPresetInfoById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x001B343C File Offset: 0x001B163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry> ForgettableSpellPresetInfoById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x001B344C File Offset: 0x001B164C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x001B345C File Offset: 0x001B165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetListEvent other)
		{
			return true;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x001B346C File Offset: 0x001B166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x001B347C File Offset: 0x001B167C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x001B348C File Offset: 0x001B168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x001B349C File Offset: 0x001B169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x001B34AC File Offset: 0x001B16AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x001B34BC File Offset: 0x001B16BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetListEvent other)
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x001B34CC File Offset: 0x001B16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x001B34DC File Offset: 0x001B16DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x001B34EC File Offset: 0x001B16EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetListEvent()
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
					PresetListEvent._parser = new MessageParser<PresetListEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					PresetListEvent._repeated_characterPresetInfoById_codec = FieldCodec.ForMessage<PresetListEvent.Types.CharacterPresetInfoByIdEntry>(10U, hiwnw8q5NJFctS8k1a2.XVInXhlssT(hiwnw8q5NJFctS8k1a2.cE2qyAHCrE));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					PresetListEvent._repeated_forgettableSpellPresetInfoById_codec = FieldCodec.ForMessage<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry>(18U, psC0ABq6jiDadATUX88.XVInXhlssT(psC0ABq6jiDadATUX88.xghqL5sZfw));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x001B362C File Offset: 0x001B182C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uqGuWRO58FVjb1FZOqGn()
		{
			return true;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x001B3634 File Offset: 0x001B1834
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetListEvent LoVM3nO5Zlym3kfrmVEf()
		{
			return null;
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly MessageParser<PresetListEvent> _parser;

		// Token: 0x04000A74 RID: 2676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A75 RID: 2677
		public const int CharacterPresetInfoByIdFieldNumber = 1;

		// Token: 0x04000A76 RID: 2678
		private static readonly FieldCodec<PresetListEvent.Types.CharacterPresetInfoByIdEntry> _repeated_characterPresetInfoById_codec;

		// Token: 0x04000A77 RID: 2679
		private readonly RepeatedField<PresetListEvent.Types.CharacterPresetInfoByIdEntry> characterPresetInfoById_;

		// Token: 0x04000A78 RID: 2680
		public const int ForgettableSpellPresetInfoByIdFieldNumber = 2;

		// Token: 0x04000A79 RID: 2681
		private static readonly FieldCodec<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry> _repeated_forgettableSpellPresetInfoById_codec;

		// Token: 0x04000A7A RID: 2682
		private readonly RepeatedField<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry> forgettableSpellPresetInfoById_;

		// Token: 0x04000A7B RID: 2683
		internal static PresetListEvent K5ONwWO5ugN5syNlutDi;

		// Token: 0x02000279 RID: 633
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001D96 RID: 7574 RVA: 0x002B3078 File Offset: 0x002B1278
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200027A RID: 634
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CharacterPresetInfoByIdEntry : IMessage<PresetListEvent.Types.CharacterPresetInfoByIdEntry>, IMessage, IEquatable<PresetListEvent.Types.CharacterPresetInfoByIdEntry>, IDeepCloneable<PresetListEvent.Types.CharacterPresetInfoByIdEntry>, IBufferMessage
			{
				// Token: 0x17000546 RID: 1350
				// (get) Token: 0x06001D97 RID: 7575 RVA: 0x002FA884 File Offset: 0x002F8A84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetListEvent.Types.CharacterPresetInfoByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000547 RID: 1351
				// (get) Token: 0x06001D98 RID: 7576 RVA: 0x002FA894 File Offset: 0x002F8A94
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

				// Token: 0x17000548 RID: 1352
				// (get) Token: 0x06001D99 RID: 7577 RVA: 0x002FA8A4 File Offset: 0x002F8AA4
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

				// Token: 0x06001D9A RID: 7578 RVA: 0x002FA8B4 File Offset: 0x002F8AB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterPresetInfoByIdEntry()
				{
				}

				// Token: 0x06001D9B RID: 7579 RVA: 0x002FA8C4 File Offset: 0x002F8AC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterPresetInfoByIdEntry(PresetListEvent.Types.CharacterPresetInfoByIdEntry other)
				{
				}

				// Token: 0x06001D9C RID: 7580 RVA: 0x002FA8D4 File Offset: 0x002F8AD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetListEvent.Types.CharacterPresetInfoByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x17000549 RID: 1353
				// (get) Token: 0x06001D9D RID: 7581 RVA: 0x002FA8E4 File Offset: 0x002F8AE4
				// (set) Token: 0x06001D9E RID: 7582 RVA: 0x002FA8F4 File Offset: 0x002F8AF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string Key
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

				// Token: 0x1700054A RID: 1354
				// (get) Token: 0x06001D9F RID: 7583 RVA: 0x002FA904 File Offset: 0x002F8B04
				// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x002FA914 File Offset: 0x002F8B14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public CharacterPresetInfo Value
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

				// Token: 0x06001DA1 RID: 7585 RVA: 0x002FA924 File Offset: 0x002F8B24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001DA2 RID: 7586 RVA: 0x002FA934 File Offset: 0x002F8B34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetListEvent.Types.CharacterPresetInfoByIdEntry other)
				{
					return true;
				}

				// Token: 0x06001DA3 RID: 7587 RVA: 0x002FA944 File Offset: 0x002F8B44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001DA4 RID: 7588 RVA: 0x002FA954 File Offset: 0x002F8B54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001DA5 RID: 7589 RVA: 0x002FA964 File Offset: 0x002F8B64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001DA6 RID: 7590 RVA: 0x002FA974 File Offset: 0x002F8B74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001DA7 RID: 7591 RVA: 0x002FA984 File Offset: 0x002F8B84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001DA8 RID: 7592 RVA: 0x002FA994 File Offset: 0x002F8B94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetListEvent.Types.CharacterPresetInfoByIdEntry other)
				{
				}

				// Token: 0x06001DA9 RID: 7593 RVA: 0x002FA9A4 File Offset: 0x002F8BA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001DAA RID: 7594 RVA: 0x002FA9B4 File Offset: 0x002F8BB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001DAB RID: 7595 RVA: 0x002FA9C4 File Offset: 0x002F8BC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CharacterPresetInfoByIdEntry()
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
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								goto IL_35;
							}
							PresetListEvent.Types.CharacterPresetInfoByIdEntry._parser = new MessageParser<PresetListEvent.Types.CharacterPresetInfoByIdEntry>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
							{
								num2 = 2;
							}
						}
						IL_35:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 3;
					}
				}

				// Token: 0x06001DAC RID: 7596 RVA: 0x002FAAAC File Offset: 0x002F8CAC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool FLQaH6GHVpGroWC0qtvU()
				{
					return true;
				}

				// Token: 0x06001DAD RID: 7597 RVA: 0x002FAAB4 File Offset: 0x002F8CB4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetListEvent.Types.CharacterPresetInfoByIdEntry kjgOs9GH0joTOfO117fl()
				{
					return null;
				}

				// Token: 0x04000A7C RID: 2684
				private static readonly MessageParser<PresetListEvent.Types.CharacterPresetInfoByIdEntry> _parser;

				// Token: 0x04000A7D RID: 2685
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000A7E RID: 2686
				public const int KeyFieldNumber = 1;

				// Token: 0x04000A7F RID: 2687
				private string key_;

				// Token: 0x04000A80 RID: 2688
				public const int ValueFieldNumber = 2;

				// Token: 0x04000A81 RID: 2689
				private CharacterPresetInfo value_;

				// Token: 0x04000A82 RID: 2690
				private static PresetListEvent.Types.CharacterPresetInfoByIdEntry OXLiiaGHrJk8xpn3A0R1;
			}

			// Token: 0x0200027C RID: 636
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ForgettableSpellPresetInfoByIdEntry : IMessage<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry>, IMessage, IEquatable<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry>, IDeepCloneable<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry>, IBufferMessage
			{
				// Token: 0x1700054B RID: 1355
				// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x002FAABC File Offset: 0x002F8CBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700054C RID: 1356
				// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x002FAACC File Offset: 0x002F8CCC
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

				// Token: 0x1700054D RID: 1357
				// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x002FAADC File Offset: 0x002F8CDC
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

				// Token: 0x06001DB6 RID: 7606 RVA: 0x002FAAEC File Offset: 0x002F8CEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellPresetInfoByIdEntry()
				{
				}

				// Token: 0x06001DB7 RID: 7607 RVA: 0x002FAAFC File Offset: 0x002F8CFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellPresetInfoByIdEntry(PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry other)
				{
				}

				// Token: 0x06001DB8 RID: 7608 RVA: 0x002FAB0C File Offset: 0x002F8D0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x1700054E RID: 1358
				// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x002FAB1C File Offset: 0x002F8D1C
				// (set) Token: 0x06001DBA RID: 7610 RVA: 0x002FAB2C File Offset: 0x002F8D2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string Key
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

				// Token: 0x1700054F RID: 1359
				// (get) Token: 0x06001DBB RID: 7611 RVA: 0x002FAB3C File Offset: 0x002F8D3C
				// (set) Token: 0x06001DBC RID: 7612 RVA: 0x002FAB4C File Offset: 0x002F8D4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ForgettableSpellPresetInfo Value
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

				// Token: 0x06001DBD RID: 7613 RVA: 0x002FAB5C File Offset: 0x002F8D5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001DBE RID: 7614 RVA: 0x002FAB6C File Offset: 0x002F8D6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry other)
				{
					return true;
				}

				// Token: 0x06001DBF RID: 7615 RVA: 0x002FAB7C File Offset: 0x002F8D7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001DC0 RID: 7616 RVA: 0x002FAB8C File Offset: 0x002F8D8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001DC1 RID: 7617 RVA: 0x002FAB9C File Offset: 0x002F8D9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001DC2 RID: 7618 RVA: 0x002FABAC File Offset: 0x002F8DAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001DC3 RID: 7619 RVA: 0x002FABBC File Offset: 0x002F8DBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001DC4 RID: 7620 RVA: 0x002FABCC File Offset: 0x002F8DCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry other)
				{
				}

				// Token: 0x06001DC5 RID: 7621 RVA: 0x002FABDC File Offset: 0x002F8DDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001DC6 RID: 7622 RVA: 0x002FABEC File Offset: 0x002F8DEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001DC7 RID: 7623 RVA: 0x002FABFC File Offset: 0x002F8DFC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ForgettableSpellPresetInfoByIdEntry()
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
								goto IL_C1;
							case 2:
								PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry._parser = new MessageParser<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							return;
						}
						IL_C1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 2;
					}
				}

				// Token: 0x06001DC8 RID: 7624 RVA: 0x002FACE4 File Offset: 0x002F8EE4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool B9jgl3GHDONHEif0GGqp()
				{
					return true;
				}

				// Token: 0x06001DC9 RID: 7625 RVA: 0x002FACEC File Offset: 0x002F8EEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry TxLh1vGHtNbFeNkiHwZR()
				{
					return null;
				}

				// Token: 0x04000A85 RID: 2693
				private static readonly MessageParser<PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry> _parser;

				// Token: 0x04000A86 RID: 2694
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000A87 RID: 2695
				public const int KeyFieldNumber = 1;

				// Token: 0x04000A88 RID: 2696
				private string key_;

				// Token: 0x04000A89 RID: 2697
				public const int ValueFieldNumber = 2;

				// Token: 0x04000A8A RID: 2698
				private ForgettableSpellPresetInfo value_;

				// Token: 0x04000A8B RID: 2699
				internal static PresetListEvent.Types.ForgettableSpellPresetInfoByIdEntry blR18vGHCeCjgBmlUTTq;
			}
		}
	}
}
