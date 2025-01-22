using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move
{
	// Token: 0x02000637 RID: 1591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishMovesEvent : IMessage<FinishMovesEvent>, IMessage, IEquatable<FinishMovesEvent>, IDeepCloneable<FinishMovesEvent>, IBufferMessage
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x001FFC24 File Offset: 0x001FDE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishMovesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x001FFC34 File Offset: 0x001FDE34
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004D2D RID: 19757 RVA: 0x001FFC44 File Offset: 0x001FDE44
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

		// Token: 0x06004D2E RID: 19758 RVA: 0x001FFC54 File Offset: 0x001FDE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesEvent()
		{
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001FFC64 File Offset: 0x001FDE64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesEvent(FinishMovesEvent other)
		{
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x001FFC74 File Offset: 0x001FDE74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesEvent Clone()
		{
			return null;
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x001FFC84 File Offset: 0x001FDE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FinishMovesEvent.Types.FinishMove> FinishMoves
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x001FFC94 File Offset: 0x001FDE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x001FFCA4 File Offset: 0x001FDEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FinishMovesEvent other)
		{
			return true;
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x001FFCB4 File Offset: 0x001FDEB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001FFCC4 File Offset: 0x001FDEC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x001FFCD4 File Offset: 0x001FDED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x001FFCE4 File Offset: 0x001FDEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x001FFCF4 File Offset: 0x001FDEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x001FFD04 File Offset: 0x001FDF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FinishMovesEvent other)
		{
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x001FFD14 File Offset: 0x001FDF14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x001FFD24 File Offset: 0x001FDF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001FFD34 File Offset: 0x001FDF34
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FinishMovesEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
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
						FinishMovesEvent._repeated_finishMoves_codec = FieldCodec.ForMessage<FinishMovesEvent.Types.FinishMove>(10U, BSgJMBmMrBAaMA12ELK0.XVInXhlssT(BSgJMBmMrBAaMA12ELK0.qfmmMVP93s9));
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 4:
						return;
					case 5:
						goto IL_98;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 2;
					}
				}
				IL_98:
				FinishMovesEvent._parser = new MessageParser<FinishMovesEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x001FFE40 File Offset: 0x001FE040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool agiQGWOigcoQbwyBTL2x()
		{
			return true;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x001FFE48 File Offset: 0x001FE048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FinishMovesEvent ULXuoIOisywOSePX8vnF()
		{
			return null;
		}

		// Token: 0x04001AF0 RID: 6896
		private static readonly MessageParser<FinishMovesEvent> _parser;

		// Token: 0x04001AF1 RID: 6897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AF2 RID: 6898
		public const int FinishMovesFieldNumber = 1;

		// Token: 0x04001AF3 RID: 6899
		private static readonly FieldCodec<FinishMovesEvent.Types.FinishMove> _repeated_finishMoves_codec;

		// Token: 0x04001AF4 RID: 6900
		private readonly RepeatedField<FinishMovesEvent.Types.FinishMove> finishMoves_;

		// Token: 0x04001AF5 RID: 6901
		private static FinishMovesEvent SGCDYLOiGyADdnxK4Zs6;

		// Token: 0x02000638 RID: 1592
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06004D3F RID: 19775 RVA: 0x002C957C File Offset: 0x002C777C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000639 RID: 1593
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FinishMove : IMessage<FinishMovesEvent.Types.FinishMove>, IMessage, IEquatable<FinishMovesEvent.Types.FinishMove>, IDeepCloneable<FinishMovesEvent.Types.FinishMove>, IBufferMessage
			{
				// Token: 0x17000DEF RID: 3567
				// (get) Token: 0x06004D40 RID: 19776 RVA: 0x00301DB8 File Offset: 0x002FFFB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FinishMovesEvent.Types.FinishMove> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DF0 RID: 3568
				// (get) Token: 0x06004D41 RID: 19777 RVA: 0x00301DC8 File Offset: 0x002FFFC8
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

				// Token: 0x17000DF1 RID: 3569
				// (get) Token: 0x06004D42 RID: 19778 RVA: 0x00301DD8 File Offset: 0x002FFFD8
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

				// Token: 0x06004D43 RID: 19779 RVA: 0x00301DE8 File Offset: 0x002FFFE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FinishMove()
				{
				}

				// Token: 0x06004D44 RID: 19780 RVA: 0x00301DF8 File Offset: 0x002FFFF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FinishMove(FinishMovesEvent.Types.FinishMove other)
				{
				}

				// Token: 0x06004D45 RID: 19781 RVA: 0x00301E08 File Offset: 0x00300008
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FinishMovesEvent.Types.FinishMove Clone()
				{
					return null;
				}

				// Token: 0x17000DF2 RID: 3570
				// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00301E18 File Offset: 0x00300018
				// (set) Token: 0x06004D47 RID: 19783 RVA: 0x00301E28 File Offset: 0x00300028
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FinishMoveId
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

				// Token: 0x17000DF3 RID: 3571
				// (get) Token: 0x06004D48 RID: 19784 RVA: 0x00301E38 File Offset: 0x00300038
				// (set) Token: 0x06004D49 RID: 19785 RVA: 0x00301E48 File Offset: 0x00300048
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Effective
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

				// Token: 0x06004D4A RID: 19786 RVA: 0x00301E58 File Offset: 0x00300058
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004D4B RID: 19787 RVA: 0x00301E68 File Offset: 0x00300068
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FinishMovesEvent.Types.FinishMove other)
				{
					return true;
				}

				// Token: 0x06004D4C RID: 19788 RVA: 0x00301E78 File Offset: 0x00300078
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004D4D RID: 19789 RVA: 0x00301E88 File Offset: 0x00300088
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004D4E RID: 19790 RVA: 0x00301E98 File Offset: 0x00300098
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004D4F RID: 19791 RVA: 0x00301EA8 File Offset: 0x003000A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004D50 RID: 19792 RVA: 0x00301EB8 File Offset: 0x003000B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004D51 RID: 19793 RVA: 0x00301EC8 File Offset: 0x003000C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FinishMovesEvent.Types.FinishMove other)
				{
				}

				// Token: 0x06004D52 RID: 19794 RVA: 0x00301ED8 File Offset: 0x003000D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004D53 RID: 19795 RVA: 0x00301EE8 File Offset: 0x003000E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004D54 RID: 19796 RVA: 0x00301EF8 File Offset: 0x003000F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FinishMove()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 3;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
								{
									num2 = 2;
									continue;
								}
								continue;
							}
							break;
						}
						IL_5F:
						FinishMovesEvent.Types.FinishMove._parser = new MessageParser<FinishMovesEvent.Types.FinishMove>(() => null);
						num = 2;
						continue;
						goto IL_5F;
					}
				}

				// Token: 0x06004D55 RID: 19797 RVA: 0x00301FE0 File Offset: 0x003001E0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool GWV4DCGiFWWDJr5SGmJa()
				{
					return true;
				}

				// Token: 0x06004D56 RID: 19798 RVA: 0x00301FE8 File Offset: 0x003001E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FinishMovesEvent.Types.FinishMove g2BmOyGizp1aVLrMsfWg()
				{
					return null;
				}

				// Token: 0x04001AF6 RID: 6902
				private static readonly MessageParser<FinishMovesEvent.Types.FinishMove> _parser;

				// Token: 0x04001AF7 RID: 6903
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001AF8 RID: 6904
				public const int FinishMoveIdFieldNumber = 1;

				// Token: 0x04001AF9 RID: 6905
				private int finishMoveId_;

				// Token: 0x04001AFA RID: 6906
				public const int EffectiveFieldNumber = 2;

				// Token: 0x04001AFB RID: 6907
				private bool effective_;

				// Token: 0x04001AFC RID: 6908
				internal static FinishMovesEvent.Types.FinishMove LJSYXoGiqJ3Zti8OrRBR;
			}
		}
	}
}
