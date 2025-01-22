using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000491 RID: 1169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagRoomUpdateEvent : IMessage<HavenBagRoomUpdateEvent>, IMessage, IEquatable<HavenBagRoomUpdateEvent>, IDeepCloneable<HavenBagRoomUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x001DFF68 File Offset: 0x001DE168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagRoomUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x001DFF78 File Offset: 0x001DE178
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

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x001DFF88 File Offset: 0x001DE188
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

		// Token: 0x060037FF RID: 14335 RVA: 0x001DFF98 File Offset: 0x001DE198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagRoomUpdateEvent()
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x001DFFA8 File Offset: 0x001DE1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagRoomUpdateEvent(HavenBagRoomUpdateEvent other)
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x001DFFB8 File Offset: 0x001DE1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagRoomUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x001DFFC8 File Offset: 0x001DE1C8
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x001DFFDC File Offset: 0x001DE1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HavenBagRoomUpdateEvent.Types.HavenBagRoomAction Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HavenBagRoomUpdateEvent.Types.HavenBagRoomAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x001DFFEC File Offset: 0x001DE1EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview> Preview
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x001DFFFC File Offset: 0x001DE1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x001E000C File Offset: 0x001DE20C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagRoomUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x001E001C File Offset: 0x001DE21C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x001E002C File Offset: 0x001DE22C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001E003C File Offset: 0x001DE23C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x001E004C File Offset: 0x001DE24C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x001E005C File Offset: 0x001DE25C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x001E006C File Offset: 0x001DE26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagRoomUpdateEvent other)
		{
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x001E007C File Offset: 0x001DE27C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x001E008C File Offset: 0x001DE28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x001E009C File Offset: 0x001DE29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagRoomUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagRoomUpdateEvent._parser = new MessageParser<HavenBagRoomUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 2;
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
				HavenBagRoomUpdateEvent._repeated_preview_codec = FieldCodec.ForMessage<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview>(18U, D04JFRmGs0VsSgnbj0Vx.XVInXhlssT(D04JFRmGs0VsSgnbj0Vx.AeemGd52Ayx));
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x001E01B8 File Offset: 0x001DE3B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nYbxu7Ow1r8BSInoJTjP()
		{
			return true;
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x001E01C0 File Offset: 0x001DE3C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagRoomUpdateEvent ChMAfhOwaZq931MvXjeB()
		{
			return null;
		}

		// Token: 0x0400138D RID: 5005
		private static readonly MessageParser<HavenBagRoomUpdateEvent> _parser;

		// Token: 0x0400138E RID: 5006
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400138F RID: 5007
		public const int ActionFieldNumber = 1;

		// Token: 0x04001390 RID: 5008
		private HavenBagRoomUpdateEvent.Types.HavenBagRoomAction action_;

		// Token: 0x04001391 RID: 5009
		public const int PreviewFieldNumber = 2;

		// Token: 0x04001392 RID: 5010
		private static readonly FieldCodec<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview> _repeated_preview_codec;

		// Token: 0x04001393 RID: 5011
		private readonly RepeatedField<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview> preview_;

		// Token: 0x04001394 RID: 5012
		internal static HavenBagRoomUpdateEvent CkEVo5OwolX2qywc6p8i;

		// Token: 0x02000492 RID: 1170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06003812 RID: 14354 RVA: 0x002C091C File Offset: 0x002BEB1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000493 RID: 1171
			public enum HavenBagRoomAction
			{
				// Token: 0x04001396 RID: 5014
				[OriginalName("HAVEN_BAG_ROOM_DISPATCH")]
				HavenBagRoomDispatch,
				// Token: 0x04001397 RID: 5015
				[OriginalName("HAVEN_BAG_ROOM_UPDATE")]
				HavenBagRoomUpdate
			}

			// Token: 0x02000494 RID: 1172
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HavenBagRoomPreview : IMessage<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview>, IMessage, IEquatable<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview>, IDeepCloneable<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview>, IBufferMessage
			{
				// Token: 0x17000A0C RID: 2572
				// (get) Token: 0x06003813 RID: 14355 RVA: 0x002FC354 File Offset: 0x002FA554
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000A0D RID: 2573
				// (get) Token: 0x06003814 RID: 14356 RVA: 0x002FC364 File Offset: 0x002FA564
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

				// Token: 0x17000A0E RID: 2574
				// (get) Token: 0x06003815 RID: 14357 RVA: 0x002FC374 File Offset: 0x002FA574
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

				// Token: 0x06003816 RID: 14358 RVA: 0x002FC384 File Offset: 0x002FA584
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HavenBagRoomPreview()
				{
				}

				// Token: 0x06003817 RID: 14359 RVA: 0x002FC394 File Offset: 0x002FA594
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HavenBagRoomPreview(HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview other)
				{
				}

				// Token: 0x06003818 RID: 14360 RVA: 0x002FC3A4 File Offset: 0x002FA5A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview Clone()
				{
					return null;
				}

				// Token: 0x17000A0F RID: 2575
				// (get) Token: 0x06003819 RID: 14361 RVA: 0x002FC3B4 File Offset: 0x002FA5B4
				// (set) Token: 0x0600381A RID: 14362 RVA: 0x002FC3C4 File Offset: 0x002FA5C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int RoomId
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

				// Token: 0x17000A10 RID: 2576
				// (get) Token: 0x0600381B RID: 14363 RVA: 0x002FC3D4 File Offset: 0x002FA5D4
				// (set) Token: 0x0600381C RID: 14364 RVA: 0x002FC3E4 File Offset: 0x002FA5E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ThemeId
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

				// Token: 0x0600381D RID: 14365 RVA: 0x002FC3F4 File Offset: 0x002FA5F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600381E RID: 14366 RVA: 0x002FC404 File Offset: 0x002FA604
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview other)
				{
					return true;
				}

				// Token: 0x0600381F RID: 14367 RVA: 0x002FC414 File Offset: 0x002FA614
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06003820 RID: 14368 RVA: 0x002FC424 File Offset: 0x002FA624
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06003821 RID: 14369 RVA: 0x002FC434 File Offset: 0x002FA634
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06003822 RID: 14370 RVA: 0x002FC444 File Offset: 0x002FA644
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06003823 RID: 14371 RVA: 0x002FC454 File Offset: 0x002FA654
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06003824 RID: 14372 RVA: 0x002FC464 File Offset: 0x002FA664
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview other)
				{
				}

				// Token: 0x06003825 RID: 14373 RVA: 0x002FC474 File Offset: 0x002FA674
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06003826 RID: 14374 RVA: 0x002FC484 File Offset: 0x002FA684
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06003827 RID: 14375 RVA: 0x002FC494 File Offset: 0x002FA694
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HavenBagRoomPreview()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview._parser = new MessageParser<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06003828 RID: 14376 RVA: 0x002FC58C File Offset: 0x002FA78C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool CMbEIYGYiUeIt79urhtm()
				{
					return true;
				}

				// Token: 0x06003829 RID: 14377 RVA: 0x002FC594 File Offset: 0x002FA794
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview I7UKDXGYPiDTsLJQpVv9()
				{
					return null;
				}

				// Token: 0x04001398 RID: 5016
				private static readonly MessageParser<HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview> _parser;

				// Token: 0x04001399 RID: 5017
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400139A RID: 5018
				public const int RoomIdFieldNumber = 1;

				// Token: 0x0400139B RID: 5019
				private int roomId_;

				// Token: 0x0400139C RID: 5020
				public const int ThemeIdFieldNumber = 2;

				// Token: 0x0400139D RID: 5021
				private int themeId_;

				// Token: 0x0400139E RID: 5022
				private static HavenBagRoomUpdateEvent.Types.HavenBagRoomPreview kV8vcBGYbMUex9dYZMk8;
			}
		}
	}
}
