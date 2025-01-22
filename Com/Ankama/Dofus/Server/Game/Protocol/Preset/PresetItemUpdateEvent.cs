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
	// Token: 0x02000273 RID: 627
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetItemUpdateEvent : IMessage<PresetItemUpdateEvent>, IMessage, IEquatable<PresetItemUpdateEvent>, IDeepCloneable<PresetItemUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x001B3164 File Offset: 0x001B1364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetItemUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x001B3174 File Offset: 0x001B1374
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x001B3184 File Offset: 0x001B1384
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

		// Token: 0x06001D4A RID: 7498 RVA: 0x001B3194 File Offset: 0x001B1394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetItemUpdateEvent()
		{
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x001B31A4 File Offset: 0x001B13A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetItemUpdateEvent(PresetItemUpdateEvent other)
		{
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x001B31B4 File Offset: 0x001B13B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetItemUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x001B31C4 File Offset: 0x001B13C4
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x001B31D4 File Offset: 0x001B13D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLinked
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x001B31E4 File Offset: 0x001B13E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry> ItemPositionByPresetUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x001B31F4 File Offset: 0x001B13F4
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x001B3204 File Offset: 0x001B1404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ItemUid
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

		// Token: 0x06001D52 RID: 7506 RVA: 0x001B3214 File Offset: 0x001B1414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x001B3224 File Offset: 0x001B1424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetItemUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x001B3234 File Offset: 0x001B1434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x001B3244 File Offset: 0x001B1444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x001B3254 File Offset: 0x001B1454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x001B3264 File Offset: 0x001B1464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x001B3274 File Offset: 0x001B1474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x001B3284 File Offset: 0x001B1484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetItemUpdateEvent other)
		{
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x001B3294 File Offset: 0x001B1494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x001B32A4 File Offset: 0x001B14A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x001B32B4 File Offset: 0x001B14B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetItemUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PresetItemUpdateEvent._parser = new MessageParser<PresetItemUpdateEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					PresetItemUpdateEvent._repeated_itemPositionByPresetUuid_codec = FieldCodec.ForMessage<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry>(18U, R8HlfmqvOA1G7db5hAZ.XVInXhlssT(R8HlfmqvOA1G7db5hAZ.SWPqoyUUe0));
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x001B33BC File Offset: 0x001B15BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tav8pcO5S4TJdDq9Z0aX()
		{
			return true;
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x001B33C4 File Offset: 0x001B15C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetItemUpdateEvent rtevLqO5Mpe5pYJFBlO9()
		{
			return null;
		}

		// Token: 0x04000A5E RID: 2654
		private static readonly MessageParser<PresetItemUpdateEvent> _parser;

		// Token: 0x04000A5F RID: 2655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A60 RID: 2656
		public const int IsLinkedFieldNumber = 1;

		// Token: 0x04000A61 RID: 2657
		private bool isLinked_;

		// Token: 0x04000A62 RID: 2658
		public const int ItemPositionByPresetUuidFieldNumber = 2;

		// Token: 0x04000A63 RID: 2659
		private static readonly FieldCodec<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry> _repeated_itemPositionByPresetUuid_codec;

		// Token: 0x04000A64 RID: 2660
		private readonly RepeatedField<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry> itemPositionByPresetUuid_;

		// Token: 0x04000A65 RID: 2661
		public const int ItemUidFieldNumber = 3;

		// Token: 0x04000A66 RID: 2662
		private int itemUid_;

		// Token: 0x04000A67 RID: 2663
		internal static PresetItemUpdateEvent VHw6JmO5PFe9Ljc7EkZV;

		// Token: 0x02000274 RID: 628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001D5F RID: 7519 RVA: 0x002B2F7C File Offset: 0x002B117C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000275 RID: 629
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ItemPositionByPresetUuidEntry : IMessage<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry>, IMessage, IEquatable<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry>, IDeepCloneable<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry>, IBufferMessage
			{
				// Token: 0x1700053C RID: 1340
				// (get) Token: 0x06001D60 RID: 7520 RVA: 0x002FA650 File Offset: 0x002F8850
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700053D RID: 1341
				// (get) Token: 0x06001D61 RID: 7521 RVA: 0x002FA660 File Offset: 0x002F8860
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

				// Token: 0x1700053E RID: 1342
				// (get) Token: 0x06001D62 RID: 7522 RVA: 0x002FA670 File Offset: 0x002F8870
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

				// Token: 0x06001D63 RID: 7523 RVA: 0x002FA680 File Offset: 0x002F8880
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemPositionByPresetUuidEntry()
				{
				}

				// Token: 0x06001D64 RID: 7524 RVA: 0x002FA690 File Offset: 0x002F8890
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemPositionByPresetUuidEntry(PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry other)
				{
				}

				// Token: 0x06001D65 RID: 7525 RVA: 0x002FA6A0 File Offset: 0x002F88A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry Clone()
				{
					return null;
				}

				// Token: 0x1700053F RID: 1343
				// (get) Token: 0x06001D66 RID: 7526 RVA: 0x002FA6B0 File Offset: 0x002F88B0
				// (set) Token: 0x06001D67 RID: 7527 RVA: 0x002FA6C0 File Offset: 0x002F88C0
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

				// Token: 0x17000540 RID: 1344
				// (get) Token: 0x06001D68 RID: 7528 RVA: 0x002FA6D0 File Offset: 0x002F88D0
				// (set) Token: 0x06001D69 RID: 7529 RVA: 0x002FA6E0 File Offset: 0x002F88E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Value
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

				// Token: 0x06001D6A RID: 7530 RVA: 0x002FA6F0 File Offset: 0x002F88F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001D6B RID: 7531 RVA: 0x002FA700 File Offset: 0x002F8900
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry other)
				{
					return true;
				}

				// Token: 0x06001D6C RID: 7532 RVA: 0x002FA710 File Offset: 0x002F8910
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001D6D RID: 7533 RVA: 0x002FA720 File Offset: 0x002F8920
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001D6E RID: 7534 RVA: 0x002FA730 File Offset: 0x002F8930
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001D6F RID: 7535 RVA: 0x002FA740 File Offset: 0x002F8940
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001D70 RID: 7536 RVA: 0x002FA750 File Offset: 0x002F8950
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001D71 RID: 7537 RVA: 0x002FA760 File Offset: 0x002F8960
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry other)
				{
				}

				// Token: 0x06001D72 RID: 7538 RVA: 0x002FA770 File Offset: 0x002F8970
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001D73 RID: 7539 RVA: 0x002FA780 File Offset: 0x002F8980
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001D74 RID: 7540 RVA: 0x002FA790 File Offset: 0x002F8990
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ItemPositionByPresetUuidEntry()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry._parser = new MessageParser<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x06001D75 RID: 7541 RVA: 0x002FA874 File Offset: 0x002F8A74
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool wuN0XCGHWi8XIJvKIpLG()
				{
					return true;
				}

				// Token: 0x06001D76 RID: 7542 RVA: 0x002FA87C File Offset: 0x002F8A7C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry A0muv2GHhoYUD8FHmLRW()
				{
					return null;
				}

				// Token: 0x04000A68 RID: 2664
				private static readonly MessageParser<PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry> _parser;

				// Token: 0x04000A69 RID: 2665
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000A6A RID: 2666
				public const int KeyFieldNumber = 1;

				// Token: 0x04000A6B RID: 2667
				private string key_;

				// Token: 0x04000A6C RID: 2668
				public const int ValueFieldNumber = 2;

				// Token: 0x04000A6D RID: 2669
				private int value_;

				// Token: 0x04000A6E RID: 2670
				private static PresetItemUpdateEvent.Types.ItemPositionByPresetUuidEntry J2vkeJGHLcgxHBAHmSiC;
			}
		}
	}
}
