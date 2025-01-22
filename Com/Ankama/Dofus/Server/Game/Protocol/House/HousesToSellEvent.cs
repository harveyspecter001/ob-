using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x0200046D RID: 1133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HousesToSellEvent : IMessage<HousesToSellEvent>, IMessage, IEquatable<HousesToSellEvent>, IDeepCloneable<HousesToSellEvent>, IBufferMessage
	{
		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x001DCDEC File Offset: 0x001DAFEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HousesToSellEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x001DCDFC File Offset: 0x001DAFFC
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

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x001DCE0C File Offset: 0x001DB00C
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

		// Token: 0x06003621 RID: 13857 RVA: 0x001DCE1C File Offset: 0x001DB01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellEvent()
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x001DCE2C File Offset: 0x001DB02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellEvent(HousesToSellEvent other)
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x001DCE3C File Offset: 0x001DB03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellEvent Clone()
		{
			return null;
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x001DCE4C File Offset: 0x001DB04C
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x001DCE5C File Offset: 0x001DB05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PageIndex
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x001DCE6C File Offset: 0x001DB06C
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x001DCE7C File Offset: 0x001DB07C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TotalPage
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x001DCE8C File Offset: 0x001DB08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HousesToSellEvent.Types.HouseToSell> Houses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x001DCE9C File Offset: 0x001DB09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x001DCEAC File Offset: 0x001DB0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HousesToSellEvent other)
		{
			return true;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x001DCEBC File Offset: 0x001DB0BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x001DCECC File Offset: 0x001DB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x001DCEDC File Offset: 0x001DB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x001DCEEC File Offset: 0x001DB0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x001DCEFC File Offset: 0x001DB0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x001DCF0C File Offset: 0x001DB10C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HousesToSellEvent other)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x001DCF1C File Offset: 0x001DB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x001DCF2C File Offset: 0x001DB12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x001DCF3C File Offset: 0x001DB13C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HousesToSellEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						HousesToSellEvent._repeated_houses_codec = FieldCodec.ForMessage<HousesToSellEvent.Types.HouseToSell>(26U, Fgora4mArWxDsOI2dW6o.XVInXhlssT(Fgora4mArWxDsOI2dW6o.j0BmAV5coHh));
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 5:
						goto IL_3A;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
				}
				IL_3A:
				HousesToSellEvent._parser = new MessageParser<HousesToSellEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x001DD030 File Offset: 0x001DB230
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dfiRv1OtCkdZ15Edbyyo()
		{
			return true;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x001DD038 File Offset: 0x001DB238
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HousesToSellEvent CjSVImOtDoJLLDiXSKER()
		{
			return null;
		}

		// Token: 0x040012EF RID: 4847
		private static readonly MessageParser<HousesToSellEvent> _parser;

		// Token: 0x040012F0 RID: 4848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012F1 RID: 4849
		public const int PageIndexFieldNumber = 1;

		// Token: 0x040012F2 RID: 4850
		private int pageIndex_;

		// Token: 0x040012F3 RID: 4851
		public const int TotalPageFieldNumber = 2;

		// Token: 0x040012F4 RID: 4852
		private int totalPage_;

		// Token: 0x040012F5 RID: 4853
		public const int HousesFieldNumber = 3;

		// Token: 0x040012F6 RID: 4854
		private static readonly FieldCodec<HousesToSellEvent.Types.HouseToSell> _repeated_houses_codec;

		// Token: 0x040012F7 RID: 4855
		private readonly RepeatedField<HousesToSellEvent.Types.HouseToSell> houses_;

		// Token: 0x040012F8 RID: 4856
		internal static HousesToSellEvent xDw2hCOt0whXNAnxMkZu;

		// Token: 0x0200046E RID: 1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06003636 RID: 13878 RVA: 0x002BF990 File Offset: 0x002BDB90
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200046F RID: 1135
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HouseToSell : IMessage<HousesToSellEvent.Types.HouseToSell>, IMessage, IEquatable<HousesToSellEvent.Types.HouseToSell>, IDeepCloneable<HousesToSellEvent.Types.HouseToSell>, IBufferMessage
			{
				// Token: 0x170009B7 RID: 2487
				// (get) Token: 0x06003637 RID: 13879 RVA: 0x002FBF94 File Offset: 0x002FA194
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<HousesToSellEvent.Types.HouseToSell> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170009B8 RID: 2488
				// (get) Token: 0x06003638 RID: 13880 RVA: 0x002FBFA4 File Offset: 0x002FA1A4
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

				// Token: 0x170009B9 RID: 2489
				// (get) Token: 0x06003639 RID: 13881 RVA: 0x002FBFB4 File Offset: 0x002FA1B4
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

				// Token: 0x0600363A RID: 13882 RVA: 0x002FBFC4 File Offset: 0x002FA1C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseToSell()
				{
				}

				// Token: 0x0600363B RID: 13883 RVA: 0x002FBFD4 File Offset: 0x002FA1D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HouseToSell(HousesToSellEvent.Types.HouseToSell other)
				{
				}

				// Token: 0x0600363C RID: 13884 RVA: 0x002FBFE4 File Offset: 0x002FA1E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HousesToSellEvent.Types.HouseToSell Clone()
				{
					return null;
				}

				// Token: 0x170009BA RID: 2490
				// (get) Token: 0x0600363D RID: 13885 RVA: 0x002FBFF4 File Offset: 0x002FA1F4
				// (set) Token: 0x0600363E RID: 13886 RVA: 0x002FC004 File Offset: 0x002FA204
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int InstanceId
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

				// Token: 0x170009BB RID: 2491
				// (get) Token: 0x0600363F RID: 13887 RVA: 0x002FC014 File Offset: 0x002FA214
				// (set) Token: 0x06003640 RID: 13888 RVA: 0x002FC024 File Offset: 0x002FA224
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool SecondHand
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

				// Token: 0x170009BC RID: 2492
				// (get) Token: 0x06003641 RID: 13889 RVA: 0x002FC034 File Offset: 0x002FA234
				// (set) Token: 0x06003642 RID: 13890 RVA: 0x002FC044 File Offset: 0x002FA244
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

				// Token: 0x170009BD RID: 2493
				// (get) Token: 0x06003643 RID: 13891 RVA: 0x002FC054 File Offset: 0x002FA254
				// (set) Token: 0x06003644 RID: 13892 RVA: 0x002FC064 File Offset: 0x002FA264
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string OwnerAccountNickname
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

				// Token: 0x170009BE RID: 2494
				// (get) Token: 0x06003645 RID: 13893 RVA: 0x002FC074 File Offset: 0x002FA274
				// (set) Token: 0x06003646 RID: 13894 RVA: 0x002FC084 File Offset: 0x002FA284
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string OwnerAccountTag
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

				// Token: 0x170009BF RID: 2495
				// (get) Token: 0x06003647 RID: 13895 RVA: 0x002FC094 File Offset: 0x002FA294
				// (set) Token: 0x06003648 RID: 13896 RVA: 0x002FC0A4 File Offset: 0x002FA2A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasOwner
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

				// Token: 0x170009C0 RID: 2496
				// (get) Token: 0x06003649 RID: 13897 RVA: 0x002FC0B4 File Offset: 0x002FA2B4
				// (set) Token: 0x0600364A RID: 13898 RVA: 0x002FC0C4 File Offset: 0x002FA2C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string OwnerName
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

				// Token: 0x170009C1 RID: 2497
				// (get) Token: 0x0600364B RID: 13899 RVA: 0x002FC0D4 File Offset: 0x002FA2D4
				// (set) Token: 0x0600364C RID: 13900 RVA: 0x002FC0E4 File Offset: 0x002FA2E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public MapCoordinates Coordinates
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

				// Token: 0x170009C2 RID: 2498
				// (get) Token: 0x0600364D RID: 13901 RVA: 0x002FC0F4 File Offset: 0x002FA2F4
				// (set) Token: 0x0600364E RID: 13902 RVA: 0x002FC104 File Offset: 0x002FA304
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SubAreaId
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

				// Token: 0x170009C3 RID: 2499
				// (get) Token: 0x0600364F RID: 13903 RVA: 0x002FC114 File Offset: 0x002FA314
				// (set) Token: 0x06003650 RID: 13904 RVA: 0x002FC124 File Offset: 0x002FA324
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int RoomNumber
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

				// Token: 0x170009C4 RID: 2500
				// (get) Token: 0x06003651 RID: 13905 RVA: 0x002FC134 File Offset: 0x002FA334
				// (set) Token: 0x06003652 RID: 13906 RVA: 0x002FC144 File Offset: 0x002FA344
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ChestNumber
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

				// Token: 0x170009C5 RID: 2501
				// (get) Token: 0x06003653 RID: 13907 RVA: 0x002FC154 File Offset: 0x002FA354
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> SkillsId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170009C6 RID: 2502
				// (get) Token: 0x06003654 RID: 13908 RVA: 0x002FC164 File Offset: 0x002FA364
				// (set) Token: 0x06003655 RID: 13909 RVA: 0x002FC174 File Offset: 0x002FA374
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool IsLocked
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

				// Token: 0x170009C7 RID: 2503
				// (get) Token: 0x06003656 RID: 13910 RVA: 0x002FC184 File Offset: 0x002FA384
				// (set) Token: 0x06003657 RID: 13911 RVA: 0x002FC194 File Offset: 0x002FA394
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

				// Token: 0x06003658 RID: 13912 RVA: 0x002FC1A4 File Offset: 0x002FA3A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06003659 RID: 13913 RVA: 0x002FC1B4 File Offset: 0x002FA3B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(HousesToSellEvent.Types.HouseToSell other)
				{
					return true;
				}

				// Token: 0x0600365A RID: 13914 RVA: 0x002FC1C4 File Offset: 0x002FA3C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600365B RID: 13915 RVA: 0x002FC1D4 File Offset: 0x002FA3D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600365C RID: 13916 RVA: 0x002FC1E4 File Offset: 0x002FA3E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600365D RID: 13917 RVA: 0x002FC1F4 File Offset: 0x002FA3F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600365E RID: 13918 RVA: 0x002FC204 File Offset: 0x002FA404
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600365F RID: 13919 RVA: 0x002FC214 File Offset: 0x002FA414
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(HousesToSellEvent.Types.HouseToSell other)
				{
				}

				// Token: 0x06003660 RID: 13920 RVA: 0x002FC224 File Offset: 0x002FA424
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06003661 RID: 13921 RVA: 0x002FC234 File Offset: 0x002FA434
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06003662 RID: 13922 RVA: 0x002FC244 File Offset: 0x002FA444
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HouseToSell()
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
							HousesToSellEvent.Types.HouseToSell._parser = new MessageParser<HousesToSellEvent.Types.HouseToSell>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
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
							return;
						}
						HousesToSellEvent.Types.HouseToSell._repeated_skillsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(98U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 5;
						}
					}
				}

				// Token: 0x06003663 RID: 13923 RVA: 0x002FC344 File Offset: 0x002FA544
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool LovpmdGY7TDSDFOC0tci()
				{
					return true;
				}

				// Token: 0x06003664 RID: 13924 RVA: 0x002FC34C File Offset: 0x002FA54C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static HousesToSellEvent.Types.HouseToSell Ok20TAGYTjlfheqi2FcF()
				{
					return null;
				}

				// Token: 0x040012F9 RID: 4857
				private static readonly MessageParser<HousesToSellEvent.Types.HouseToSell> _parser;

				// Token: 0x040012FA RID: 4858
				private UnknownFieldSet _unknownFields;

				// Token: 0x040012FB RID: 4859
				public const int InstanceIdFieldNumber = 1;

				// Token: 0x040012FC RID: 4860
				private int instanceId_;

				// Token: 0x040012FD RID: 4861
				public const int SecondHandFieldNumber = 2;

				// Token: 0x040012FE RID: 4862
				private bool secondHand_;

				// Token: 0x040012FF RID: 4863
				public const int ModelIdFieldNumber = 3;

				// Token: 0x04001300 RID: 4864
				private int modelId_;

				// Token: 0x04001301 RID: 4865
				public const int OwnerAccountNicknameFieldNumber = 4;

				// Token: 0x04001302 RID: 4866
				private string ownerAccountNickname_;

				// Token: 0x04001303 RID: 4867
				public const int OwnerAccountTagFieldNumber = 5;

				// Token: 0x04001304 RID: 4868
				private string ownerAccountTag_;

				// Token: 0x04001305 RID: 4869
				public const int HasOwnerFieldNumber = 6;

				// Token: 0x04001306 RID: 4870
				private bool hasOwner_;

				// Token: 0x04001307 RID: 4871
				public const int OwnerNameFieldNumber = 7;

				// Token: 0x04001308 RID: 4872
				private string ownerName_;

				// Token: 0x04001309 RID: 4873
				public const int CoordinatesFieldNumber = 8;

				// Token: 0x0400130A RID: 4874
				private MapCoordinates coordinates_;

				// Token: 0x0400130B RID: 4875
				public const int SubAreaIdFieldNumber = 9;

				// Token: 0x0400130C RID: 4876
				private int subAreaId_;

				// Token: 0x0400130D RID: 4877
				public const int RoomNumberFieldNumber = 10;

				// Token: 0x0400130E RID: 4878
				private int roomNumber_;

				// Token: 0x0400130F RID: 4879
				public const int ChestNumberFieldNumber = 11;

				// Token: 0x04001310 RID: 4880
				private int chestNumber_;

				// Token: 0x04001311 RID: 4881
				public const int SkillsIdFieldNumber = 12;

				// Token: 0x04001312 RID: 4882
				private static readonly FieldCodec<int> _repeated_skillsId_codec;

				// Token: 0x04001313 RID: 4883
				private readonly RepeatedField<int> skillsId_;

				// Token: 0x04001314 RID: 4884
				public const int IsLockedFieldNumber = 13;

				// Token: 0x04001315 RID: 4885
				private bool isLocked_;

				// Token: 0x04001316 RID: 4886
				public const int PriceFieldNumber = 14;

				// Token: 0x04001317 RID: 4887
				private long price_;

				// Token: 0x04001318 RID: 4888
				private static HousesToSellEvent.Types.HouseToSell hRxb5rGYQBoUCJKNlaZm;
			}
		}
	}
}
