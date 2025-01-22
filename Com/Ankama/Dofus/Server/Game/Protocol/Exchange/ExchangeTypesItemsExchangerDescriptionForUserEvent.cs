using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200077C RID: 1916
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTypesItemsExchangerDescriptionForUserEvent : IMessage<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IMessage, IEquatable<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IDeepCloneable<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IBufferMessage
	{
		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06005DE8 RID: 24040 RVA: 0x0021CAD8 File Offset: 0x0021ACD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x0021CAE8 File Offset: 0x0021ACE8
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

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06005DEA RID: 24042 RVA: 0x0021CAF8 File Offset: 0x0021ACF8
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

		// Token: 0x06005DEB RID: 24043 RVA: 0x0021CB08 File Offset: 0x0021AD08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesItemsExchangerDescriptionForUserEvent()
		{
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x0021CB18 File Offset: 0x0021AD18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesItemsExchangerDescriptionForUserEvent(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
		{
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x0021CB28 File Offset: 0x0021AD28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesItemsExchangerDescriptionForUserEvent Clone()
		{
			return null;
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06005DEE RID: 24046 RVA: 0x0021CB38 File Offset: 0x0021AD38
		// (set) Token: 0x06005DEF RID: 24047 RVA: 0x0021CB48 File Offset: 0x0021AD48
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

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x0021CB58 File Offset: 0x0021AD58
		// (set) Token: 0x06005DF1 RID: 24049 RVA: 0x0021CB68 File Offset: 0x0021AD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectType
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

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06005DF2 RID: 24050 RVA: 0x0021CB78 File Offset: 0x0021AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject> ItemDescriptions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0021CB88 File Offset: 0x0021AD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x0021CB98 File Offset: 0x0021AD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
		{
			return true;
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x0021CBA8 File Offset: 0x0021ADA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x0021CBB8 File Offset: 0x0021ADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x0021CBC8 File Offset: 0x0021ADC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x0021CBD8 File Offset: 0x0021ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x0021CBE8 File Offset: 0x0021ADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x0021CBF8 File Offset: 0x0021ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
		{
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x0021CC08 File Offset: 0x0021AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x0021CC18 File Offset: 0x0021AE18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x0021CC28 File Offset: 0x0021AE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTypesItemsExchangerDescriptionForUserEvent()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						break;
					case 4:
						ExchangeTypesItemsExchangerDescriptionForUserEvent._repeated_itemDescriptions_codec = FieldCodec.ForMessage<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject>(26U, FEnTslAdF5wuT4Ax8dRi.XVInXhlssT(FEnTslAdF5wuT4Ax8dRi.LRDAdziTDD7));
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						goto IL_D5;
					}
				}
				IL_D5:
				ExchangeTypesItemsExchangerDescriptionForUserEvent._parser = new MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0021CD34 File Offset: 0x0021AF34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wT8U29OZwpYj1Eb0thdx()
		{
			return true;
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x0021CD3C File Offset: 0x0021AF3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTypesItemsExchangerDescriptionForUserEvent wyHTAWOZQgGpjxVq3cY8()
		{
			return null;
		}

		// Token: 0x040020FE RID: 8446
		private static readonly MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent> _parser;

		// Token: 0x040020FF RID: 8447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002100 RID: 8448
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04002101 RID: 8449
		private int objectGid_;

		// Token: 0x04002102 RID: 8450
		public const int ObjectTypeFieldNumber = 2;

		// Token: 0x04002103 RID: 8451
		private int objectType_;

		// Token: 0x04002104 RID: 8452
		public const int ItemDescriptionsFieldNumber = 3;

		// Token: 0x04002105 RID: 8453
		private static readonly FieldCodec<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject> _repeated_itemDescriptions_codec;

		// Token: 0x04002106 RID: 8454
		private readonly RepeatedField<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject> itemDescriptions_;

		// Token: 0x04002107 RID: 8455
		private static ExchangeTypesItemsExchangerDescriptionForUserEvent cV15IWOZt1T0PZ3p7Cxu;

		// Token: 0x0200077D RID: 1917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06005E00 RID: 24064 RVA: 0x002D16DC File Offset: 0x002CF8DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200077E RID: 1918
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class BidExchangerObject : IMessage<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject>, IMessage, IEquatable<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject>, IDeepCloneable<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject>, IBufferMessage
			{
				// Token: 0x1700110C RID: 4364
				// (get) Token: 0x06005E01 RID: 24065 RVA: 0x00304AA0 File Offset: 0x00302CA0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700110D RID: 4365
				// (get) Token: 0x06005E02 RID: 24066 RVA: 0x00304AB0 File Offset: 0x00302CB0
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

				// Token: 0x1700110E RID: 4366
				// (get) Token: 0x06005E03 RID: 24067 RVA: 0x00304AC0 File Offset: 0x00302CC0
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

				// Token: 0x06005E04 RID: 24068 RVA: 0x00304AD0 File Offset: 0x00302CD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BidExchangerObject()
				{
				}

				// Token: 0x06005E05 RID: 24069 RVA: 0x00304AE0 File Offset: 0x00302CE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BidExchangerObject(ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject other)
				{
				}

				// Token: 0x06005E06 RID: 24070 RVA: 0x00304AF0 File Offset: 0x00302CF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject Clone()
				{
					return null;
				}

				// Token: 0x1700110F RID: 4367
				// (get) Token: 0x06005E07 RID: 24071 RVA: 0x00304B00 File Offset: 0x00302D00
				// (set) Token: 0x06005E08 RID: 24072 RVA: 0x00304B10 File Offset: 0x00302D10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Uid
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

				// Token: 0x17001110 RID: 4368
				// (get) Token: 0x06005E09 RID: 24073 RVA: 0x00304B20 File Offset: 0x00302D20
				// (set) Token: 0x06005E0A RID: 24074 RVA: 0x00304B30 File Offset: 0x00302D30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Gid
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

				// Token: 0x17001111 RID: 4369
				// (get) Token: 0x06005E0B RID: 24075 RVA: 0x00304B40 File Offset: 0x00302D40
				// (set) Token: 0x06005E0C RID: 24076 RVA: 0x00304B50 File Offset: 0x00302D50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Type
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

				// Token: 0x17001112 RID: 4370
				// (get) Token: 0x06005E0D RID: 24077 RVA: 0x00304B60 File Offset: 0x00302D60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ObjectEffect> Effects
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001113 RID: 4371
				// (get) Token: 0x06005E0E RID: 24078 RVA: 0x00304B70 File Offset: 0x00302D70
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<long> Prices
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06005E0F RID: 24079 RVA: 0x00304B80 File Offset: 0x00302D80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06005E10 RID: 24080 RVA: 0x00304B90 File Offset: 0x00302D90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject other)
				{
					return true;
				}

				// Token: 0x06005E11 RID: 24081 RVA: 0x00304BA0 File Offset: 0x00302DA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06005E12 RID: 24082 RVA: 0x00304BB0 File Offset: 0x00302DB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06005E13 RID: 24083 RVA: 0x00304BC0 File Offset: 0x00302DC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06005E14 RID: 24084 RVA: 0x00304BD0 File Offset: 0x00302DD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06005E15 RID: 24085 RVA: 0x00304BE0 File Offset: 0x00302DE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06005E16 RID: 24086 RVA: 0x00304BF0 File Offset: 0x00302DF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject other)
				{
				}

				// Token: 0x06005E17 RID: 24087 RVA: 0x00304C00 File Offset: 0x00302E00
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06005E18 RID: 24088 RVA: 0x00304C10 File Offset: 0x00302E10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06005E19 RID: 24089 RVA: 0x00304C20 File Offset: 0x00302E20
				[MethodImpl(MethodImplOptions.NoInlining)]
				static BidExchangerObject()
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
								num2 = 5;
								continue;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								return;
							case 4:
								ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(34U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
								num2 = 6;
								continue;
							case 5:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 6:
								ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject._repeated_prices_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(42U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							break;
						}
						IL_6D:
						ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject._parser = new MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject>(() => null);
						num = 4;
						continue;
						goto IL_6D;
					}
				}

				// Token: 0x06005E1A RID: 24090 RVA: 0x00304D48 File Offset: 0x00302F48
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool p0tt5eGSe1q67BkEFNCq()
				{
					return true;
				}

				// Token: 0x06005E1B RID: 24091 RVA: 0x00304D50 File Offset: 0x00302F50
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject FXFU76GS3glbb97eX8GK()
				{
					return null;
				}

				// Token: 0x04002108 RID: 8456
				private static readonly MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject> _parser;

				// Token: 0x04002109 RID: 8457
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400210A RID: 8458
				public const int UidFieldNumber = 1;

				// Token: 0x0400210B RID: 8459
				private int uid_;

				// Token: 0x0400210C RID: 8460
				public const int GidFieldNumber = 2;

				// Token: 0x0400210D RID: 8461
				private int gid_;

				// Token: 0x0400210E RID: 8462
				public const int TypeFieldNumber = 3;

				// Token: 0x0400210F RID: 8463
				private int type_;

				// Token: 0x04002110 RID: 8464
				public const int EffectsFieldNumber = 4;

				// Token: 0x04002111 RID: 8465
				private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

				// Token: 0x04002112 RID: 8466
				private readonly RepeatedField<ObjectEffect> effects_;

				// Token: 0x04002113 RID: 8467
				public const int PricesFieldNumber = 5;

				// Token: 0x04002114 RID: 8468
				private static readonly FieldCodec<long> _repeated_prices_codec;

				// Token: 0x04002115 RID: 8469
				private readonly RepeatedField<long> prices_;

				// Token: 0x04002116 RID: 8470
				private static ExchangeTypesItemsExchangerDescriptionForUserEvent.Types.BidExchangerObject qsCDlYGSBBH6JE1E0MLV;
			}
		}
	}
}
