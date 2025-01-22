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
	// Token: 0x02000B47 RID: 2887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ItemMinimalInformation : IMessage<ItemMinimalInformation>, IMessage, IEquatable<ItemMinimalInformation>, IDeepCloneable<ItemMinimalInformation>, IBufferMessage
	{
		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06008A3F RID: 35391 RVA: 0x002682E0 File Offset: 0x002664E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ItemMinimalInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x002682F0 File Offset: 0x002664F0
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

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06008A41 RID: 35393 RVA: 0x00268300 File Offset: 0x00266500
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

		// Token: 0x06008A42 RID: 35394 RVA: 0x00268310 File Offset: 0x00266510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemMinimalInformation()
		{
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x00268320 File Offset: 0x00266520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemMinimalInformation(ItemMinimalInformation other)
		{
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x00268330 File Offset: 0x00266530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemMinimalInformation Clone()
		{
			return null;
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x00268340 File Offset: 0x00266540
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x00268350 File Offset: 0x00266550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06008A47 RID: 35399 RVA: 0x00268360 File Offset: 0x00266560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06008A48 RID: 35400 RVA: 0x00268370 File Offset: 0x00266570
		// (set) Token: 0x06008A49 RID: 35401 RVA: 0x00268380 File Offset: 0x00266580
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

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06008A4A RID: 35402 RVA: 0x00268390 File Offset: 0x00266590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasQuantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x002683A0 File Offset: 0x002665A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearQuantity()
		{
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06008A4C RID: 35404 RVA: 0x002683B0 File Offset: 0x002665B0
		// (set) Token: 0x06008A4D RID: 35405 RVA: 0x002683C0 File Offset: 0x002665C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemMinimalInformation.Types.ItemToSellInNpcShop ItemToSellInNpcShop
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

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06008A4E RID: 35406 RVA: 0x002683D0 File Offset: 0x002665D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemMinimalInformation.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ItemMinimalInformation.ComplementOneofCase)null;
			}
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x002683E4 File Offset: 0x002665E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x002683F4 File Offset: 0x002665F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x00268404 File Offset: 0x00266604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ItemMinimalInformation other)
		{
			return true;
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x00268414 File Offset: 0x00266614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x00268424 File Offset: 0x00266624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x00268434 File Offset: 0x00266634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x00268444 File Offset: 0x00266644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00268454 File Offset: 0x00266654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x00268464 File Offset: 0x00266664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ItemMinimalInformation other)
		{
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x00268474 File Offset: 0x00266674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x00268484 File Offset: 0x00266684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x00268494 File Offset: 0x00266694
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ItemMinimalInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ItemMinimalInformation._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(18U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ItemMinimalInformation._parser = new MessageParser<ItemMinimalInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x0026859C File Offset: 0x0026679C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f74r4ZJdHDJQOtCFcxFI()
		{
			return true;
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x002685A4 File Offset: 0x002667A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ItemMinimalInformation lR3paFJdYTJITEcHu02F()
		{
			return null;
		}

		// Token: 0x040032EE RID: 13038
		private static readonly MessageParser<ItemMinimalInformation> _parser;

		// Token: 0x040032EF RID: 13039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032F0 RID: 13040
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x040032F1 RID: 13041
		private int objectGid_;

		// Token: 0x040032F2 RID: 13042
		public const int EffectsFieldNumber = 2;

		// Token: 0x040032F3 RID: 13043
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x040032F4 RID: 13044
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x040032F5 RID: 13045
		public const int QuantityFieldNumber = 3;

		// Token: 0x040032F6 RID: 13046
		public const int ItemToSellInNpcShopFieldNumber = 4;

		// Token: 0x040032F7 RID: 13047
		private object complement_;

		// Token: 0x040032F8 RID: 13048
		private ItemMinimalInformation.ComplementOneofCase complementCase_;

		// Token: 0x040032F9 RID: 13049
		internal static ItemMinimalInformation pNwrKKJdpXKNabUPsJou;

		// Token: 0x02000B48 RID: 2888
		public enum ComplementOneofCase
		{
			// Token: 0x040032FB RID: 13051
			None,
			// Token: 0x040032FC RID: 13052
			Quantity = 3,
			// Token: 0x040032FD RID: 13053
			ItemToSellInNpcShop
		}

		// Token: 0x02000B49 RID: 2889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06008A5D RID: 35421 RVA: 0x002E39D4 File Offset: 0x002E1BD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B4A RID: 2890
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ItemToSellInNpcShop : IMessage<ItemMinimalInformation.Types.ItemToSellInNpcShop>, IMessage, IEquatable<ItemMinimalInformation.Types.ItemToSellInNpcShop>, IDeepCloneable<ItemMinimalInformation.Types.ItemToSellInNpcShop>, IBufferMessage
			{
				// Token: 0x1700199A RID: 6554
				// (get) Token: 0x06008A5E RID: 35422 RVA: 0x0030B14C File Offset: 0x0030934C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ItemMinimalInformation.Types.ItemToSellInNpcShop> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700199B RID: 6555
				// (get) Token: 0x06008A5F RID: 35423 RVA: 0x0030B15C File Offset: 0x0030935C
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

				// Token: 0x1700199C RID: 6556
				// (get) Token: 0x06008A60 RID: 35424 RVA: 0x0030B16C File Offset: 0x0030936C
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

				// Token: 0x06008A61 RID: 35425 RVA: 0x0030B17C File Offset: 0x0030937C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemToSellInNpcShop()
				{
				}

				// Token: 0x06008A62 RID: 35426 RVA: 0x0030B18C File Offset: 0x0030938C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemToSellInNpcShop(ItemMinimalInformation.Types.ItemToSellInNpcShop other)
				{
				}

				// Token: 0x06008A63 RID: 35427 RVA: 0x0030B19C File Offset: 0x0030939C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemMinimalInformation.Types.ItemToSellInNpcShop Clone()
				{
					return null;
				}

				// Token: 0x1700199D RID: 6557
				// (get) Token: 0x06008A64 RID: 35428 RVA: 0x0030B1AC File Offset: 0x003093AC
				// (set) Token: 0x06008A65 RID: 35429 RVA: 0x0030B1BC File Offset: 0x003093BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x1700199E RID: 6558
				// (get) Token: 0x06008A66 RID: 35430 RVA: 0x0030B1CC File Offset: 0x003093CC
				// (set) Token: 0x06008A67 RID: 35431 RVA: 0x0030B1DC File Offset: 0x003093DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string BuyCriterion
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

				// Token: 0x06008A68 RID: 35432 RVA: 0x0030B1EC File Offset: 0x003093EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008A69 RID: 35433 RVA: 0x0030B1FC File Offset: 0x003093FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ItemMinimalInformation.Types.ItemToSellInNpcShop other)
				{
					return true;
				}

				// Token: 0x06008A6A RID: 35434 RVA: 0x0030B20C File Offset: 0x0030940C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008A6B RID: 35435 RVA: 0x0030B21C File Offset: 0x0030941C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008A6C RID: 35436 RVA: 0x0030B22C File Offset: 0x0030942C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008A6D RID: 35437 RVA: 0x0030B23C File Offset: 0x0030943C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008A6E RID: 35438 RVA: 0x0030B24C File Offset: 0x0030944C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008A6F RID: 35439 RVA: 0x0030B25C File Offset: 0x0030945C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ItemMinimalInformation.Types.ItemToSellInNpcShop other)
				{
				}

				// Token: 0x06008A70 RID: 35440 RVA: 0x0030B26C File Offset: 0x0030946C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008A71 RID: 35441 RVA: 0x0030B27C File Offset: 0x0030947C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008A72 RID: 35442 RVA: 0x0030B28C File Offset: 0x0030948C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ItemToSellInNpcShop()
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
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 4;
								continue;
							case 2:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								goto IL_73;
							case 4:
								ItemMinimalInformation.Types.ItemToSellInNpcShop._parser = new MessageParser<ItemMinimalInformation.Types.ItemToSellInNpcShop>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							return;
						}
						IL_73:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 2;
					}
				}

				// Token: 0x06008A73 RID: 35443 RVA: 0x0030B35C File Offset: 0x0030955C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool vKUwAlG85JCLAW64ZscM()
				{
					return true;
				}

				// Token: 0x06008A74 RID: 35444 RVA: 0x0030B364 File Offset: 0x00309564
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ItemMinimalInformation.Types.ItemToSellInNpcShop mbK2bgG8y8ZTHTO3rXcc()
				{
					return null;
				}

				// Token: 0x040032FE RID: 13054
				private static readonly MessageParser<ItemMinimalInformation.Types.ItemToSellInNpcShop> _parser;

				// Token: 0x040032FF RID: 13055
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003300 RID: 13056
				public const int PriceFieldNumber = 1;

				// Token: 0x04003301 RID: 13057
				private long price_;

				// Token: 0x04003302 RID: 13058
				public const int BuyCriterionFieldNumber = 2;

				// Token: 0x04003303 RID: 13059
				private string buyCriterion_;

				// Token: 0x04003304 RID: 13060
				private static ItemMinimalInformation.Types.ItemToSellInNpcShop IIw3bWG8afJISs7ckXVH;
			}
		}
	}
}
