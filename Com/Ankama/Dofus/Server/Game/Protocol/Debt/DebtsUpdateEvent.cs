using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debt
{
	// Token: 0x020007F8 RID: 2040
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DebtsUpdateEvent : IMessage<DebtsUpdateEvent>, IMessage, IEquatable<DebtsUpdateEvent>, IDeepCloneable<DebtsUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x00224F54 File Offset: 0x00223154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DebtsUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x00224F64 File Offset: 0x00223164
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x00224F74 File Offset: 0x00223174
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

		// Token: 0x0600637F RID: 25471 RVA: 0x00224F84 File Offset: 0x00223184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsUpdateEvent()
		{
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00224F94 File Offset: 0x00223194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsUpdateEvent(DebtsUpdateEvent other)
		{
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00224FA4 File Offset: 0x002231A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x00224FB4 File Offset: 0x002231B4
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x00224FC8 File Offset: 0x002231C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DebtsUpdateEvent.Types.DebtsAction Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DebtsUpdateEvent.Types.DebtsAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x00224FD8 File Offset: 0x002231D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<DebtsUpdateEvent.Types.DebtInformation> Debts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00224FE8 File Offset: 0x002231E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x00224FF8 File Offset: 0x002231F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DebtsUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00225008 File Offset: 0x00223208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x00225018 File Offset: 0x00223218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00225028 File Offset: 0x00223228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00225038 File Offset: 0x00223238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x00225048 File Offset: 0x00223248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00225058 File Offset: 0x00223258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DebtsUpdateEvent other)
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00225068 File Offset: 0x00223268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00225078 File Offset: 0x00223278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00225088 File Offset: 0x00223288
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DebtsUpdateEvent()
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
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						DebtsUpdateEvent._parser = new MessageParser<DebtsUpdateEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_9C;
					case 5:
						return;
					}
					DebtsUpdateEvent._repeated_debts_codec = FieldCodec.ForMessage<DebtsUpdateEvent.Types.DebtInformation>(18U, ANlUbCAtNjRQTURIbwMp.XVInXhlssT(ANlUbCAtNjRQTURIbwMp.uaFAtxeBXmK));
					num2 = 5;
				}
				IL_9C:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00225194 File Offset: 0x00223394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rMYUeiOzXh6ioHdgb6iy()
		{
			return true;
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0022519C File Offset: 0x0022339C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DebtsUpdateEvent pPc4eGOzNkMfKXYaGDAP()
		{
			return null;
		}

		// Token: 0x040022F8 RID: 8952
		private static readonly MessageParser<DebtsUpdateEvent> _parser;

		// Token: 0x040022F9 RID: 8953
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022FA RID: 8954
		public const int ActionFieldNumber = 1;

		// Token: 0x040022FB RID: 8955
		private DebtsUpdateEvent.Types.DebtsAction action_;

		// Token: 0x040022FC RID: 8956
		public const int DebtsFieldNumber = 2;

		// Token: 0x040022FD RID: 8957
		private static readonly FieldCodec<DebtsUpdateEvent.Types.DebtInformation> _repeated_debts_codec;

		// Token: 0x040022FE RID: 8958
		private readonly RepeatedField<DebtsUpdateEvent.Types.DebtInformation> debts_;

		// Token: 0x040022FF RID: 8959
		private static DebtsUpdateEvent qYTaVwOzErZSQL04bFN1;

		// Token: 0x020007F9 RID: 2041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06006392 RID: 25490 RVA: 0x002D4464 File Offset: 0x002D2664
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007FA RID: 2042
			public enum DebtsAction
			{
				// Token: 0x04002301 RID: 8961
				[OriginalName("DISPATCH")]
				Dispatch,
				// Token: 0x04002302 RID: 8962
				[OriginalName("UPDATE")]
				Update
			}

			// Token: 0x020007FB RID: 2043
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DebtInformation : IMessage<DebtsUpdateEvent.Types.DebtInformation>, IMessage, IEquatable<DebtsUpdateEvent.Types.DebtInformation>, IDeepCloneable<DebtsUpdateEvent.Types.DebtInformation>, IBufferMessage
			{
				// Token: 0x17001209 RID: 4617
				// (get) Token: 0x06006393 RID: 25491 RVA: 0x003051FC File Offset: 0x003033FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DebtsUpdateEvent.Types.DebtInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700120A RID: 4618
				// (get) Token: 0x06006394 RID: 25492 RVA: 0x0030520C File Offset: 0x0030340C
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

				// Token: 0x1700120B RID: 4619
				// (get) Token: 0x06006395 RID: 25493 RVA: 0x0030521C File Offset: 0x0030341C
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

				// Token: 0x06006396 RID: 25494 RVA: 0x0030522C File Offset: 0x0030342C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DebtInformation()
				{
				}

				// Token: 0x06006397 RID: 25495 RVA: 0x0030523C File Offset: 0x0030343C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DebtInformation(DebtsUpdateEvent.Types.DebtInformation other)
				{
				}

				// Token: 0x06006398 RID: 25496 RVA: 0x0030524C File Offset: 0x0030344C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DebtsUpdateEvent.Types.DebtInformation Clone()
				{
					return null;
				}

				// Token: 0x1700120C RID: 4620
				// (get) Token: 0x06006399 RID: 25497 RVA: 0x0030525C File Offset: 0x0030345C
				// (set) Token: 0x0600639A RID: 25498 RVA: 0x0030526C File Offset: 0x0030346C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long DebtId
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

				// Token: 0x1700120D RID: 4621
				// (get) Token: 0x0600639B RID: 25499 RVA: 0x0030527C File Offset: 0x0030347C
				// (set) Token: 0x0600639C RID: 25500 RVA: 0x0030528C File Offset: 0x0030348C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Timestamp
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

				// Token: 0x1700120E RID: 4622
				// (get) Token: 0x0600639D RID: 25501 RVA: 0x0030529C File Offset: 0x0030349C
				// (set) Token: 0x0600639E RID: 25502 RVA: 0x003052AC File Offset: 0x003034AC
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

				// Token: 0x1700120F RID: 4623
				// (get) Token: 0x0600639F RID: 25503 RVA: 0x003052BC File Offset: 0x003034BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasKamas
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x060063A0 RID: 25504 RVA: 0x003052CC File Offset: 0x003034CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearKamas()
				{
				}

				// Token: 0x060063A1 RID: 25505 RVA: 0x003052DC File Offset: 0x003034DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060063A2 RID: 25506 RVA: 0x003052EC File Offset: 0x003034EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DebtsUpdateEvent.Types.DebtInformation other)
				{
					return true;
				}

				// Token: 0x060063A3 RID: 25507 RVA: 0x003052FC File Offset: 0x003034FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060063A4 RID: 25508 RVA: 0x0030530C File Offset: 0x0030350C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060063A5 RID: 25509 RVA: 0x0030531C File Offset: 0x0030351C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060063A6 RID: 25510 RVA: 0x0030532C File Offset: 0x0030352C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060063A7 RID: 25511 RVA: 0x0030533C File Offset: 0x0030353C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060063A8 RID: 25512 RVA: 0x0030534C File Offset: 0x0030354C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DebtsUpdateEvent.Types.DebtInformation other)
				{
				}

				// Token: 0x060063A9 RID: 25513 RVA: 0x0030535C File Offset: 0x0030355C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060063AA RID: 25514 RVA: 0x0030536C File Offset: 0x0030356C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060063AB RID: 25515 RVA: 0x0030537C File Offset: 0x0030357C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DebtInformation()
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
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								goto IL_B0;
							case 4:
								return;
							case 5:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							DebtsUpdateEvent.Types.DebtInformation._parser = new MessageParser<DebtsUpdateEvent.Types.DebtInformation>(() => null);
							num2 = 3;
						}
						IL_B0:
						DebtsUpdateEvent.Types.DebtInformation.KamasDefaultValue = 0L;
						num = 4;
					}
				}

				// Token: 0x060063AC RID: 25516 RVA: 0x00305464 File Offset: 0x00303664
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool O7cuLuGSLvviK0pVjxND()
				{
					return true;
				}

				// Token: 0x060063AD RID: 25517 RVA: 0x0030546C File Offset: 0x0030366C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DebtsUpdateEvent.Types.DebtInformation koMoGjGSWWeTs2kBsN9n()
				{
					return null;
				}

				// Token: 0x04002303 RID: 8963
				private static readonly MessageParser<DebtsUpdateEvent.Types.DebtInformation> _parser;

				// Token: 0x04002304 RID: 8964
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002305 RID: 8965
				private int _hasBits0;

				// Token: 0x04002306 RID: 8966
				public const int DebtIdFieldNumber = 1;

				// Token: 0x04002307 RID: 8967
				private long debtId_;

				// Token: 0x04002308 RID: 8968
				public const int TimestampFieldNumber = 2;

				// Token: 0x04002309 RID: 8969
				private long timestamp_;

				// Token: 0x0400230A RID: 8970
				public const int KamasFieldNumber = 3;

				// Token: 0x0400230B RID: 8971
				private static readonly long KamasDefaultValue;

				// Token: 0x0400230C RID: 8972
				private long kamas_;

				// Token: 0x0400230D RID: 8973
				internal static DebtsUpdateEvent.Types.DebtInformation Tpd4MfGS6Npwss7sU7Vf;
			}
		}
	}
}
