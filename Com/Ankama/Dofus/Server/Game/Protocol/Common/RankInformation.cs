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
	// Token: 0x02000B86 RID: 2950
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RankInformation : IMessage<RankInformation>, IMessage, IEquatable<RankInformation>, IDeepCloneable<RankInformation>, IBufferMessage
	{
		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06008D89 RID: 36233 RVA: 0x0026AD4C File Offset: 0x00268F4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RankInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x0026AD5C File Offset: 0x00268F5C
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

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06008D8B RID: 36235 RVA: 0x0026AD6C File Offset: 0x00268F6C
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

		// Token: 0x06008D8C RID: 36236 RVA: 0x0026AD7C File Offset: 0x00268F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RankInformation()
		{
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x0026AD8C File Offset: 0x00268F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RankInformation(RankInformation other)
		{
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x0026AD9C File Offset: 0x00268F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RankInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06008D8F RID: 36239 RVA: 0x0026ADAC File Offset: 0x00268FAC
		// (set) Token: 0x06008D90 RID: 36240 RVA: 0x0026ADBC File Offset: 0x00268FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06008D91 RID: 36241 RVA: 0x0026ADCC File Offset: 0x00268FCC
		// (set) Token: 0x06008D92 RID: 36242 RVA: 0x0026ADDC File Offset: 0x00268FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06008D93 RID: 36243 RVA: 0x0026ADEC File Offset: 0x00268FEC
		// (set) Token: 0x06008D94 RID: 36244 RVA: 0x0026ADFC File Offset: 0x00268FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RankInformation.Types.OrderAndGfx OrderAndGfx
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

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06008D95 RID: 36245 RVA: 0x0026AE0C File Offset: 0x0026900C
		// (set) Token: 0x06008D96 RID: 36246 RVA: 0x0026AE1C File Offset: 0x0026901C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RankInformation.Types.PrivateInformation PrivateInformation
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

		// Token: 0x06008D97 RID: 36247 RVA: 0x0026AE2C File Offset: 0x0026902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x0026AE3C File Offset: 0x0026903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RankInformation other)
		{
			return true;
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x0026AE4C File Offset: 0x0026904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x0026AE5C File Offset: 0x0026905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x0026AE6C File Offset: 0x0026906C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x0026AE7C File Offset: 0x0026907C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x0026AE8C File Offset: 0x0026908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x0026AE9C File Offset: 0x0026909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RankInformation other)
		{
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x0026AEAC File Offset: 0x002690AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x0026AEBC File Offset: 0x002690BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x0026AECC File Offset: 0x002690CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RankInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					RankInformation._parser = new MessageParser<RankInformation>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x0026AFC4 File Offset: 0x002691C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pTXZreJ9LiAVN9829bur()
		{
			return true;
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x0026AFCC File Offset: 0x002691CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RankInformation tucjHjJ9WiRHOXxBHbi8()
		{
			return null;
		}

		// Token: 0x04003472 RID: 13426
		private static readonly MessageParser<RankInformation> _parser;

		// Token: 0x04003473 RID: 13427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003474 RID: 13428
		public const int IdFieldNumber = 1;

		// Token: 0x04003475 RID: 13429
		private int id_;

		// Token: 0x04003476 RID: 13430
		public const int NameFieldNumber = 2;

		// Token: 0x04003477 RID: 13431
		private string name_;

		// Token: 0x04003478 RID: 13432
		public const int OrderAndGfxFieldNumber = 3;

		// Token: 0x04003479 RID: 13433
		private RankInformation.Types.OrderAndGfx orderAndGfx_;

		// Token: 0x0400347A RID: 13434
		public const int PrivateInformationFieldNumber = 4;

		// Token: 0x0400347B RID: 13435
		private RankInformation.Types.PrivateInformation privateInformation_;

		// Token: 0x0400347C RID: 13436
		private static RankInformation SRoQccJ96nKL3D5AmjrG;

		// Token: 0x02000B87 RID: 2951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06008DA4 RID: 36260 RVA: 0x002E4940 File Offset: 0x002E2B40
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B88 RID: 2952
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class OrderAndGfx : IMessage<RankInformation.Types.OrderAndGfx>, IMessage, IEquatable<RankInformation.Types.OrderAndGfx>, IDeepCloneable<RankInformation.Types.OrderAndGfx>, IBufferMessage
			{
				// Token: 0x17001A5D RID: 6749
				// (get) Token: 0x06008DA5 RID: 36261 RVA: 0x0030C798 File Offset: 0x0030A998
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<RankInformation.Types.OrderAndGfx> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A5E RID: 6750
				// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x0030C7A8 File Offset: 0x0030A9A8
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

				// Token: 0x17001A5F RID: 6751
				// (get) Token: 0x06008DA7 RID: 36263 RVA: 0x0030C7B8 File Offset: 0x0030A9B8
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

				// Token: 0x06008DA8 RID: 36264 RVA: 0x0030C7C8 File Offset: 0x0030A9C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public OrderAndGfx()
				{
				}

				// Token: 0x06008DA9 RID: 36265 RVA: 0x0030C7D8 File Offset: 0x0030A9D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public OrderAndGfx(RankInformation.Types.OrderAndGfx other)
				{
				}

				// Token: 0x06008DAA RID: 36266 RVA: 0x0030C7E8 File Offset: 0x0030A9E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RankInformation.Types.OrderAndGfx Clone()
				{
					return null;
				}

				// Token: 0x17001A60 RID: 6752
				// (get) Token: 0x06008DAB RID: 36267 RVA: 0x0030C7F8 File Offset: 0x0030A9F8
				// (set) Token: 0x06008DAC RID: 36268 RVA: 0x0030C808 File Offset: 0x0030AA08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Order
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

				// Token: 0x17001A61 RID: 6753
				// (get) Token: 0x06008DAD RID: 36269 RVA: 0x0030C818 File Offset: 0x0030AA18
				// (set) Token: 0x06008DAE RID: 36270 RVA: 0x0030C828 File Offset: 0x0030AA28
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int GfxId
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

				// Token: 0x06008DAF RID: 36271 RVA: 0x0030C838 File Offset: 0x0030AA38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008DB0 RID: 36272 RVA: 0x0030C848 File Offset: 0x0030AA48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(RankInformation.Types.OrderAndGfx other)
				{
					return true;
				}

				// Token: 0x06008DB1 RID: 36273 RVA: 0x0030C858 File Offset: 0x0030AA58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008DB2 RID: 36274 RVA: 0x0030C868 File Offset: 0x0030AA68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008DB3 RID: 36275 RVA: 0x0030C878 File Offset: 0x0030AA78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008DB4 RID: 36276 RVA: 0x0030C888 File Offset: 0x0030AA88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008DB5 RID: 36277 RVA: 0x0030C898 File Offset: 0x0030AA98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008DB6 RID: 36278 RVA: 0x0030C8A8 File Offset: 0x0030AAA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(RankInformation.Types.OrderAndGfx other)
				{
				}

				// Token: 0x06008DB7 RID: 36279 RVA: 0x0030C8B8 File Offset: 0x0030AAB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008DB8 RID: 36280 RVA: 0x0030C8C8 File Offset: 0x0030AAC8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008DB9 RID: 36281 RVA: 0x0030C8D8 File Offset: 0x0030AAD8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static OrderAndGfx()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							RankInformation.Types.OrderAndGfx._parser = new MessageParser<RankInformation.Types.OrderAndGfx>(() => null);
							num2 = 4;
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
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
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06008DBA RID: 36282 RVA: 0x0030C9A4 File Offset: 0x0030ABA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ao8qqgGZ3ykg5q6G2YWY()
				{
					return true;
				}

				// Token: 0x06008DBB RID: 36283 RVA: 0x0030C9AC File Offset: 0x0030ABAC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static RankInformation.Types.OrderAndGfx d508PZGZRTOs5kBPxMXg()
				{
					return null;
				}

				// Token: 0x0400347D RID: 13437
				private static readonly MessageParser<RankInformation.Types.OrderAndGfx> _parser;

				// Token: 0x0400347E RID: 13438
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400347F RID: 13439
				public const int OrderFieldNumber = 1;

				// Token: 0x04003480 RID: 13440
				private int order_;

				// Token: 0x04003481 RID: 13441
				public const int GfxIdFieldNumber = 2;

				// Token: 0x04003482 RID: 13442
				private int gfxId_;

				// Token: 0x04003483 RID: 13443
				internal static RankInformation.Types.OrderAndGfx hnUhHPGZebgmjT3R0biW;
			}

			// Token: 0x02000B8A RID: 2954
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PrivateInformation : IMessage<RankInformation.Types.PrivateInformation>, IMessage, IEquatable<RankInformation.Types.PrivateInformation>, IDeepCloneable<RankInformation.Types.PrivateInformation>, IBufferMessage
			{
				// Token: 0x17001A62 RID: 6754
				// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x0030C9B4 File Offset: 0x0030ABB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<RankInformation.Types.PrivateInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A63 RID: 6755
				// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x0030C9C4 File Offset: 0x0030ABC4
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

				// Token: 0x17001A64 RID: 6756
				// (get) Token: 0x06008DC3 RID: 36291 RVA: 0x0030C9D4 File Offset: 0x0030ABD4
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

				// Token: 0x06008DC4 RID: 36292 RVA: 0x0030C9E4 File Offset: 0x0030ABE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PrivateInformation()
				{
				}

				// Token: 0x06008DC5 RID: 36293 RVA: 0x0030C9F4 File Offset: 0x0030ABF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PrivateInformation(RankInformation.Types.PrivateInformation other)
				{
				}

				// Token: 0x06008DC6 RID: 36294 RVA: 0x0030CA04 File Offset: 0x0030AC04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RankInformation.Types.PrivateInformation Clone()
				{
					return null;
				}

				// Token: 0x17001A65 RID: 6757
				// (get) Token: 0x06008DC7 RID: 36295 RVA: 0x0030CA14 File Offset: 0x0030AC14
				// (set) Token: 0x06008DC8 RID: 36296 RVA: 0x0030CA24 File Offset: 0x0030AC24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Modifiable
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

				// Token: 0x17001A66 RID: 6758
				// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x0030CA34 File Offset: 0x0030AC34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Rights
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06008DCA RID: 36298 RVA: 0x0030CA44 File Offset: 0x0030AC44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008DCB RID: 36299 RVA: 0x0030CA54 File Offset: 0x0030AC54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(RankInformation.Types.PrivateInformation other)
				{
					return true;
				}

				// Token: 0x06008DCC RID: 36300 RVA: 0x0030CA64 File Offset: 0x0030AC64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008DCD RID: 36301 RVA: 0x0030CA74 File Offset: 0x0030AC74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008DCE RID: 36302 RVA: 0x0030CA84 File Offset: 0x0030AC84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008DCF RID: 36303 RVA: 0x0030CA94 File Offset: 0x0030AC94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008DD0 RID: 36304 RVA: 0x0030CAA4 File Offset: 0x0030ACA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008DD1 RID: 36305 RVA: 0x0030CAB4 File Offset: 0x0030ACB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(RankInformation.Types.PrivateInformation other)
				{
				}

				// Token: 0x06008DD2 RID: 36306 RVA: 0x0030CAC4 File Offset: 0x0030ACC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008DD3 RID: 36307 RVA: 0x0030CAD4 File Offset: 0x0030ACD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008DD4 RID: 36308 RVA: 0x0030CAE4 File Offset: 0x0030ACE4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PrivateInformation()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							RankInformation.Types.PrivateInformation._parser = new MessageParser<RankInformation.Types.PrivateInformation>(() => null);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						case 5:
							RankInformation.Types.PrivateInformation._repeated_rights_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06008DD5 RID: 36309 RVA: 0x0030CBFC File Offset: 0x0030ADFC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool RfEIWPGZJZGfiUVl8IOe()
				{
					return true;
				}

				// Token: 0x06008DD6 RID: 36310 RVA: 0x0030CC04 File Offset: 0x0030AE04
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static RankInformation.Types.PrivateInformation MBrCRLGZG7pirY9wx3B7()
				{
					return null;
				}

				// Token: 0x04003486 RID: 13446
				private static readonly MessageParser<RankInformation.Types.PrivateInformation> _parser;

				// Token: 0x04003487 RID: 13447
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003488 RID: 13448
				public const int ModifiableFieldNumber = 1;

				// Token: 0x04003489 RID: 13449
				private bool modifiable_;

				// Token: 0x0400348A RID: 13450
				public const int RightsFieldNumber = 2;

				// Token: 0x0400348B RID: 13451
				private static readonly FieldCodec<int> _repeated_rights_codec;

				// Token: 0x0400348C RID: 13452
				private readonly RepeatedField<int> rights_;

				// Token: 0x0400348D RID: 13453
				private static RankInformation.Types.PrivateInformation roRoT5GZOeBYx9T9meX4;
			}
		}
	}
}
