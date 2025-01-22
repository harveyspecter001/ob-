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
	// Token: 0x02000B4D RID: 2893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectGidWithQuantity : IMessage<ObjectGidWithQuantity>, IMessage, IEquatable<ObjectGidWithQuantity>, IDeepCloneable<ObjectGidWithQuantity>, IBufferMessage
	{
		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x002685AC File Offset: 0x002667AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectGidWithQuantity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06008A80 RID: 35456 RVA: 0x002685BC File Offset: 0x002667BC
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

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x002685CC File Offset: 0x002667CC
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

		// Token: 0x06008A82 RID: 35458 RVA: 0x002685DC File Offset: 0x002667DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectGidWithQuantity()
		{
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x002685EC File Offset: 0x002667EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectGidWithQuantity(ObjectGidWithQuantity other)
		{
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x002685FC File Offset: 0x002667FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectGidWithQuantity Clone()
		{
			return null;
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06008A85 RID: 35461 RVA: 0x0026860C File Offset: 0x0026680C
		// (set) Token: 0x06008A86 RID: 35462 RVA: 0x0026861C File Offset: 0x0026681C
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

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x0026862C File Offset: 0x0026682C
		// (set) Token: 0x06008A88 RID: 35464 RVA: 0x0026863C File Offset: 0x0026683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x0026864C File Offset: 0x0026684C
		// (set) Token: 0x06008A8A RID: 35466 RVA: 0x0026865C File Offset: 0x0026685C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectGidWithQuantity.Types.ObjectPriceDateEffect PriceDateEffect
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

		// Token: 0x06008A8B RID: 35467 RVA: 0x0026866C File Offset: 0x0026686C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0026867C File Offset: 0x0026687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectGidWithQuantity other)
		{
			return true;
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0026868C File Offset: 0x0026688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0026869C File Offset: 0x0026689C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x002686AC File Offset: 0x002668AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x002686BC File Offset: 0x002668BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x002686CC File Offset: 0x002668CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x002686DC File Offset: 0x002668DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectGidWithQuantity other)
		{
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x002686EC File Offset: 0x002668EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x002686FC File Offset: 0x002668FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0026870C File Offset: 0x0026690C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectGidWithQuantity()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ObjectGidWithQuantity._parser = new MessageParser<ObjectGidWithQuantity>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x00268804 File Offset: 0x00266A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ohsOy2JdiZFG3ohEcriA()
		{
			return true;
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x0026880C File Offset: 0x00266A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectGidWithQuantity y3YcfpJdPZqr9IvErdrB()
		{
			return null;
		}

		// Token: 0x04003309 RID: 13065
		private static readonly MessageParser<ObjectGidWithQuantity> _parser;

		// Token: 0x0400330A RID: 13066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400330B RID: 13067
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x0400330C RID: 13068
		private int objectGid_;

		// Token: 0x0400330D RID: 13069
		public const int QuantityFieldNumber = 2;

		// Token: 0x0400330E RID: 13070
		private int quantity_;

		// Token: 0x0400330F RID: 13071
		public const int PriceDateEffectFieldNumber = 3;

		// Token: 0x04003310 RID: 13072
		private ObjectGidWithQuantity.Types.ObjectPriceDateEffect priceDateEffect_;

		// Token: 0x04003311 RID: 13073
		internal static ObjectGidWithQuantity ckItVJJdbfZd28dCWnsG;

		// Token: 0x02000B4E RID: 2894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06008A98 RID: 35480 RVA: 0x002E3AE4 File Offset: 0x002E1CE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B4F RID: 2895
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectPriceDateEffect : IMessage<ObjectGidWithQuantity.Types.ObjectPriceDateEffect>, IMessage, IEquatable<ObjectGidWithQuantity.Types.ObjectPriceDateEffect>, IDeepCloneable<ObjectGidWithQuantity.Types.ObjectPriceDateEffect>, IBufferMessage
			{
				// Token: 0x170019A5 RID: 6565
				// (get) Token: 0x06008A99 RID: 35481 RVA: 0x0030B36C File Offset: 0x0030956C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectGidWithQuantity.Types.ObjectPriceDateEffect> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019A6 RID: 6566
				// (get) Token: 0x06008A9A RID: 35482 RVA: 0x0030B37C File Offset: 0x0030957C
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

				// Token: 0x170019A7 RID: 6567
				// (get) Token: 0x06008A9B RID: 35483 RVA: 0x0030B38C File Offset: 0x0030958C
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

				// Token: 0x06008A9C RID: 35484 RVA: 0x0030B39C File Offset: 0x0030959C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectPriceDateEffect()
				{
				}

				// Token: 0x06008A9D RID: 35485 RVA: 0x0030B3AC File Offset: 0x003095AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectPriceDateEffect(ObjectGidWithQuantity.Types.ObjectPriceDateEffect other)
				{
				}

				// Token: 0x06008A9E RID: 35486 RVA: 0x0030B3BC File Offset: 0x003095BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectGidWithQuantity.Types.ObjectPriceDateEffect Clone()
				{
					return null;
				}

				// Token: 0x170019A8 RID: 6568
				// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0030B3CC File Offset: 0x003095CC
				// (set) Token: 0x06008AA0 RID: 35488 RVA: 0x0030B3DC File Offset: 0x003095DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Price
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

				// Token: 0x170019A9 RID: 6569
				// (get) Token: 0x06008AA1 RID: 35489 RVA: 0x0030B3EC File Offset: 0x003095EC
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

				// Token: 0x170019AA RID: 6570
				// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x0030B3FC File Offset: 0x003095FC
				// (set) Token: 0x06008AA3 RID: 35491 RVA: 0x0030B40C File Offset: 0x0030960C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Date
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

				// Token: 0x06008AA4 RID: 35492 RVA: 0x0030B41C File Offset: 0x0030961C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008AA5 RID: 35493 RVA: 0x0030B42C File Offset: 0x0030962C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectGidWithQuantity.Types.ObjectPriceDateEffect other)
				{
					return true;
				}

				// Token: 0x06008AA6 RID: 35494 RVA: 0x0030B43C File Offset: 0x0030963C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008AA7 RID: 35495 RVA: 0x0030B44C File Offset: 0x0030964C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008AA8 RID: 35496 RVA: 0x0030B45C File Offset: 0x0030965C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008AA9 RID: 35497 RVA: 0x0030B46C File Offset: 0x0030966C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008AAA RID: 35498 RVA: 0x0030B47C File Offset: 0x0030967C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008AAB RID: 35499 RVA: 0x0030B48C File Offset: 0x0030968C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectGidWithQuantity.Types.ObjectPriceDateEffect other)
				{
				}

				// Token: 0x06008AAC RID: 35500 RVA: 0x0030B49C File Offset: 0x0030969C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008AAD RID: 35501 RVA: 0x0030B4AC File Offset: 0x003096AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008AAE RID: 35502 RVA: 0x0030B4BC File Offset: 0x003096BC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectPriceDateEffect()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							ObjectGidWithQuantity.Types.ObjectPriceDateEffect._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(18U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 5;
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						case 5:
							ObjectGidWithQuantity.Types.ObjectPriceDateEffect._parser = new MessageParser<ObjectGidWithQuantity.Types.ObjectPriceDateEffect>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06008AAF RID: 35503 RVA: 0x0030B5AC File Offset: 0x003097AC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool xb91SsG8LHdIreQqbTaP()
				{
					return true;
				}

				// Token: 0x06008AB0 RID: 35504 RVA: 0x0030B5B4 File Offset: 0x003097B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectGidWithQuantity.Types.ObjectPriceDateEffect HuRNOMG8W3h5I8oD8f6W()
				{
					return null;
				}

				// Token: 0x04003312 RID: 13074
				private static readonly MessageParser<ObjectGidWithQuantity.Types.ObjectPriceDateEffect> _parser;

				// Token: 0x04003313 RID: 13075
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003314 RID: 13076
				public const int PriceFieldNumber = 1;

				// Token: 0x04003315 RID: 13077
				private long price_;

				// Token: 0x04003316 RID: 13078
				public const int EffectsFieldNumber = 2;

				// Token: 0x04003317 RID: 13079
				private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

				// Token: 0x04003318 RID: 13080
				private readonly RepeatedField<ObjectEffect> effects_;

				// Token: 0x04003319 RID: 13081
				public const int DateFieldNumber = 3;

				// Token: 0x0400331A RID: 13082
				private long date_;

				// Token: 0x0400331B RID: 13083
				internal static ObjectGidWithQuantity.Types.ObjectPriceDateEffect itbQY0G86JDVbne5fCD2;
			}
		}
	}
}
