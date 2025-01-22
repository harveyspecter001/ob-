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
	// Token: 0x02000B58 RID: 2904
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectEffect : IMessage<ObjectEffect>, IMessage, IEquatable<ObjectEffect>, IDeepCloneable<ObjectEffect>, IBufferMessage
	{
		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06008B15 RID: 35605 RVA: 0x00268F3C File Offset: 0x0026713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectEffect> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06008B16 RID: 35606 RVA: 0x00268F4C File Offset: 0x0026714C
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

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06008B17 RID: 35607 RVA: 0x00268F5C File Offset: 0x0026715C
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

		// Token: 0x06008B18 RID: 35608 RVA: 0x00268F6C File Offset: 0x0026716C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectEffect()
		{
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00268F7C File Offset: 0x0026717C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectEffect(ObjectEffect other)
		{
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x00268F8C File Offset: 0x0026718C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectEffect Clone()
		{
			return null;
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06008B1B RID: 35611 RVA: 0x00268F9C File Offset: 0x0026719C
		// (set) Token: 0x06008B1C RID: 35612 RVA: 0x00268FAC File Offset: 0x002671AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Action
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

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06008B1D RID: 35613 RVA: 0x00268FBC File Offset: 0x002671BC
		// (set) Token: 0x06008B1E RID: 35614 RVA: 0x00268FCC File Offset: 0x002671CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string ValueString
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06008B1F RID: 35615 RVA: 0x00268FDC File Offset: 0x002671DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasValueString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00268FEC File Offset: 0x002671EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearValueString()
		{
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x00268FFC File Offset: 0x002671FC
		// (set) Token: 0x06008B22 RID: 35618 RVA: 0x0026900C File Offset: 0x0026720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ValueInt
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

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06008B23 RID: 35619 RVA: 0x0026901C File Offset: 0x0026721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasValueInt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x0026902C File Offset: 0x0026722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearValueInt()
		{
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x0026903C File Offset: 0x0026723C
		// (set) Token: 0x06008B26 RID: 35622 RVA: 0x0026904C File Offset: 0x0026724C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectEffect.Types.ObjectEffectMinMaxValue MinMax
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

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06008B27 RID: 35623 RVA: 0x0026905C File Offset: 0x0026725C
		// (set) Token: 0x06008B28 RID: 35624 RVA: 0x0026906C File Offset: 0x0026726C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectEffect.Types.ObjectEffectDiceValue Dice
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

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06008B29 RID: 35625 RVA: 0x0026907C File Offset: 0x0026727C
		// (set) Token: 0x06008B2A RID: 35626 RVA: 0x0026908C File Offset: 0x0026728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectEffect.Types.DofusDate Date
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

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06008B2B RID: 35627 RVA: 0x0026909C File Offset: 0x0026729C
		// (set) Token: 0x06008B2C RID: 35628 RVA: 0x002690AC File Offset: 0x002672AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DurationMinute
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

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06008B2D RID: 35629 RVA: 0x002690BC File Offset: 0x002672BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDurationMinute
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x002690CC File Offset: 0x002672CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearDurationMinute()
		{
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x002690DC File Offset: 0x002672DC
		// (set) Token: 0x06008B30 RID: 35632 RVA: 0x002690EC File Offset: 0x002672EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CreatureFamily
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

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x002690FC File Offset: 0x002672FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasCreatureFamily
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x0026910C File Offset: 0x0026730C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCreatureFamily()
		{
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06008B33 RID: 35635 RVA: 0x0026911C File Offset: 0x0026731C
		// (set) Token: 0x06008B34 RID: 35636 RVA: 0x0026912C File Offset: 0x0026732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectEffect.Types.MonsterCount MonsterCount
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

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x0026913C File Offset: 0x0026733C
		// (set) Token: 0x06008B36 RID: 35638 RVA: 0x0026914C File Offset: 0x0026734C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectEffect.Types.ObjectEffectMountValue Mount
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

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06008B37 RID: 35639 RVA: 0x0026915C File Offset: 0x0026735C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectEffect.EffectOneofCase EffectCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectEffect.EffectOneofCase)null;
			}
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x00269170 File Offset: 0x00267370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEffect()
		{
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x00269180 File Offset: 0x00267380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x00269190 File Offset: 0x00267390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectEffect other)
		{
			return true;
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x002691A0 File Offset: 0x002673A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x002691B0 File Offset: 0x002673B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x002691C0 File Offset: 0x002673C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x002691D0 File Offset: 0x002673D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x002691E0 File Offset: 0x002673E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x002691F0 File Offset: 0x002673F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectEffect other)
		{
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x00269200 File Offset: 0x00267400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x00269210 File Offset: 0x00267410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x00269220 File Offset: 0x00267420
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectEffect()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ObjectEffect._parser = new MessageParser<ObjectEffect>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x00269318 File Offset: 0x00267518
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cwEQt8J9mL0JGqKTBV3K()
		{
			return true;
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x00269320 File Offset: 0x00267520
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectEffect DCGNPqJ9ApCh6SCbFYyc()
		{
			return null;
		}

		// Token: 0x04003345 RID: 13125
		private static readonly MessageParser<ObjectEffect> _parser;

		// Token: 0x04003346 RID: 13126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003347 RID: 13127
		public const int ActionFieldNumber = 1;

		// Token: 0x04003348 RID: 13128
		private int action_;

		// Token: 0x04003349 RID: 13129
		public const int ValueStringFieldNumber = 2;

		// Token: 0x0400334A RID: 13130
		public const int ValueIntFieldNumber = 3;

		// Token: 0x0400334B RID: 13131
		public const int MinMaxFieldNumber = 4;

		// Token: 0x0400334C RID: 13132
		public const int DiceFieldNumber = 5;

		// Token: 0x0400334D RID: 13133
		public const int DateFieldNumber = 6;

		// Token: 0x0400334E RID: 13134
		public const int DurationMinuteFieldNumber = 7;

		// Token: 0x0400334F RID: 13135
		public const int CreatureFamilyFieldNumber = 8;

		// Token: 0x04003350 RID: 13136
		public const int MonsterCountFieldNumber = 9;

		// Token: 0x04003351 RID: 13137
		public const int MountFieldNumber = 10;

		// Token: 0x04003352 RID: 13138
		private object effect_;

		// Token: 0x04003353 RID: 13139
		private ObjectEffect.EffectOneofCase effectCase_;

		// Token: 0x04003354 RID: 13140
		private static ObjectEffect u0cByhJ9nDjeFoklupUa;

		// Token: 0x02000B59 RID: 2905
		public enum EffectOneofCase
		{
			// Token: 0x04003356 RID: 13142
			None,
			// Token: 0x04003357 RID: 13143
			ValueString = 2,
			// Token: 0x04003358 RID: 13144
			ValueInt,
			// Token: 0x04003359 RID: 13145
			MinMax,
			// Token: 0x0400335A RID: 13146
			Dice,
			// Token: 0x0400335B RID: 13147
			Date,
			// Token: 0x0400335C RID: 13148
			DurationMinute,
			// Token: 0x0400335D RID: 13149
			CreatureFamily,
			// Token: 0x0400335E RID: 13150
			MonsterCount,
			// Token: 0x0400335F RID: 13151
			Mount
		}

		// Token: 0x02000B5A RID: 2906
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008B46 RID: 35654 RVA: 0x002E3ED4 File Offset: 0x002E20D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B5B RID: 2907
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DofusDate : IMessage<ObjectEffect.Types.DofusDate>, IMessage, IEquatable<ObjectEffect.Types.DofusDate>, IDeepCloneable<ObjectEffect.Types.DofusDate>, IBufferMessage
			{
				// Token: 0x170019D0 RID: 6608
				// (get) Token: 0x06008B47 RID: 35655 RVA: 0x0030B5BC File Offset: 0x003097BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ObjectEffect.Types.DofusDate> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019D1 RID: 6609
				// (get) Token: 0x06008B48 RID: 35656 RVA: 0x0030B5CC File Offset: 0x003097CC
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

				// Token: 0x170019D2 RID: 6610
				// (get) Token: 0x06008B49 RID: 35657 RVA: 0x0030B5DC File Offset: 0x003097DC
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

				// Token: 0x06008B4A RID: 35658 RVA: 0x0030B5EC File Offset: 0x003097EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DofusDate()
				{
				}

				// Token: 0x06008B4B RID: 35659 RVA: 0x0030B5FC File Offset: 0x003097FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DofusDate(ObjectEffect.Types.DofusDate other)
				{
				}

				// Token: 0x06008B4C RID: 35660 RVA: 0x0030B60C File Offset: 0x0030980C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffect.Types.DofusDate Clone()
				{
					return null;
				}

				// Token: 0x170019D3 RID: 6611
				// (get) Token: 0x06008B4D RID: 35661 RVA: 0x0030B61C File Offset: 0x0030981C
				// (set) Token: 0x06008B4E RID: 35662 RVA: 0x0030B62C File Offset: 0x0030982C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Year
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

				// Token: 0x170019D4 RID: 6612
				// (get) Token: 0x06008B4F RID: 35663 RVA: 0x0030B63C File Offset: 0x0030983C
				// (set) Token: 0x06008B50 RID: 35664 RVA: 0x0030B64C File Offset: 0x0030984C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Month
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

				// Token: 0x170019D5 RID: 6613
				// (get) Token: 0x06008B51 RID: 35665 RVA: 0x0030B65C File Offset: 0x0030985C
				// (set) Token: 0x06008B52 RID: 35666 RVA: 0x0030B66C File Offset: 0x0030986C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Day
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

				// Token: 0x170019D6 RID: 6614
				// (get) Token: 0x06008B53 RID: 35667 RVA: 0x0030B67C File Offset: 0x0030987C
				// (set) Token: 0x06008B54 RID: 35668 RVA: 0x0030B68C File Offset: 0x0030988C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Hour
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

				// Token: 0x170019D7 RID: 6615
				// (get) Token: 0x06008B55 RID: 35669 RVA: 0x0030B69C File Offset: 0x0030989C
				// (set) Token: 0x06008B56 RID: 35670 RVA: 0x0030B6AC File Offset: 0x003098AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Minute
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

				// Token: 0x06008B57 RID: 35671 RVA: 0x0030B6BC File Offset: 0x003098BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008B58 RID: 35672 RVA: 0x0030B6CC File Offset: 0x003098CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectEffect.Types.DofusDate other)
				{
					return true;
				}

				// Token: 0x06008B59 RID: 35673 RVA: 0x0030B6DC File Offset: 0x003098DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008B5A RID: 35674 RVA: 0x0030B6EC File Offset: 0x003098EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008B5B RID: 35675 RVA: 0x0030B6FC File Offset: 0x003098FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008B5C RID: 35676 RVA: 0x0030B70C File Offset: 0x0030990C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008B5D RID: 35677 RVA: 0x0030B71C File Offset: 0x0030991C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008B5E RID: 35678 RVA: 0x0030B72C File Offset: 0x0030992C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectEffect.Types.DofusDate other)
				{
				}

				// Token: 0x06008B5F RID: 35679 RVA: 0x0030B73C File Offset: 0x0030993C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008B60 RID: 35680 RVA: 0x0030B74C File Offset: 0x0030994C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008B61 RID: 35681 RVA: 0x0030B75C File Offset: 0x0030995C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DofusDate()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							ObjectEffect.Types.DofusDate._parser = new MessageParser<ObjectEffect.Types.DofusDate>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x06008B62 RID: 35682 RVA: 0x0030B854 File Offset: 0x00309A54
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool mvhE83G8rq2FPpAgeQZF()
				{
					return true;
				}

				// Token: 0x06008B63 RID: 35683 RVA: 0x0030B85C File Offset: 0x00309A5C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectEffect.Types.DofusDate cVWJcWG8VQy9a1DNayKU()
				{
					return null;
				}

				// Token: 0x04003360 RID: 13152
				private static readonly MessageParser<ObjectEffect.Types.DofusDate> _parser;

				// Token: 0x04003361 RID: 13153
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003362 RID: 13154
				public const int YearFieldNumber = 1;

				// Token: 0x04003363 RID: 13155
				private int year_;

				// Token: 0x04003364 RID: 13156
				public const int MonthFieldNumber = 2;

				// Token: 0x04003365 RID: 13157
				private int month_;

				// Token: 0x04003366 RID: 13158
				public const int DayFieldNumber = 3;

				// Token: 0x04003367 RID: 13159
				private int day_;

				// Token: 0x04003368 RID: 13160
				public const int HourFieldNumber = 4;

				// Token: 0x04003369 RID: 13161
				private int hour_;

				// Token: 0x0400336A RID: 13162
				public const int MinuteFieldNumber = 5;

				// Token: 0x0400336B RID: 13163
				private int minute_;

				// Token: 0x0400336C RID: 13164
				internal static ObjectEffect.Types.DofusDate KlGrlcG8haSDp7dLTal7;
			}

			// Token: 0x02000B5D RID: 2909
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectEffectMinMaxValue : IMessage<ObjectEffect.Types.ObjectEffectMinMaxValue>, IMessage, IEquatable<ObjectEffect.Types.ObjectEffectMinMaxValue>, IDeepCloneable<ObjectEffect.Types.ObjectEffectMinMaxValue>, IBufferMessage
			{
				// Token: 0x170019D8 RID: 6616
				// (get) Token: 0x06008B69 RID: 35689 RVA: 0x0030B864 File Offset: 0x00309A64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectEffect.Types.ObjectEffectMinMaxValue> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019D9 RID: 6617
				// (get) Token: 0x06008B6A RID: 35690 RVA: 0x0030B874 File Offset: 0x00309A74
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

				// Token: 0x170019DA RID: 6618
				// (get) Token: 0x06008B6B RID: 35691 RVA: 0x0030B884 File Offset: 0x00309A84
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

				// Token: 0x06008B6C RID: 35692 RVA: 0x0030B894 File Offset: 0x00309A94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectMinMaxValue()
				{
				}

				// Token: 0x06008B6D RID: 35693 RVA: 0x0030B8A4 File Offset: 0x00309AA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectMinMaxValue(ObjectEffect.Types.ObjectEffectMinMaxValue other)
				{
				}

				// Token: 0x06008B6E RID: 35694 RVA: 0x0030B8B4 File Offset: 0x00309AB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffect.Types.ObjectEffectMinMaxValue Clone()
				{
					return null;
				}

				// Token: 0x170019DB RID: 6619
				// (get) Token: 0x06008B6F RID: 35695 RVA: 0x0030B8C4 File Offset: 0x00309AC4
				// (set) Token: 0x06008B70 RID: 35696 RVA: 0x0030B8D4 File Offset: 0x00309AD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Min
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

				// Token: 0x170019DC RID: 6620
				// (get) Token: 0x06008B71 RID: 35697 RVA: 0x0030B8E4 File Offset: 0x00309AE4
				// (set) Token: 0x06008B72 RID: 35698 RVA: 0x0030B8F4 File Offset: 0x00309AF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Max
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

				// Token: 0x06008B73 RID: 35699 RVA: 0x0030B904 File Offset: 0x00309B04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008B74 RID: 35700 RVA: 0x0030B914 File Offset: 0x00309B14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectEffect.Types.ObjectEffectMinMaxValue other)
				{
					return true;
				}

				// Token: 0x06008B75 RID: 35701 RVA: 0x0030B924 File Offset: 0x00309B24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008B76 RID: 35702 RVA: 0x0030B934 File Offset: 0x00309B34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008B77 RID: 35703 RVA: 0x0030B944 File Offset: 0x00309B44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008B78 RID: 35704 RVA: 0x0030B954 File Offset: 0x00309B54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008B79 RID: 35705 RVA: 0x0030B964 File Offset: 0x00309B64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008B7A RID: 35706 RVA: 0x0030B974 File Offset: 0x00309B74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectEffect.Types.ObjectEffectMinMaxValue other)
				{
				}

				// Token: 0x06008B7B RID: 35707 RVA: 0x0030B984 File Offset: 0x00309B84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008B7C RID: 35708 RVA: 0x0030B994 File Offset: 0x00309B94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008B7D RID: 35709 RVA: 0x0030B9A4 File Offset: 0x00309BA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectEffectMinMaxValue()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							ObjectEffect.Types.ObjectEffectMinMaxValue._parser = new MessageParser<ObjectEffect.Types.ObjectEffectMinMaxValue>(() => null);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
					}
				}

				// Token: 0x06008B7E RID: 35710 RVA: 0x0030BA70 File Offset: 0x00309C70
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool MkCPsWG8CGrn8cOKr0oE()
				{
					return true;
				}

				// Token: 0x06008B7F RID: 35711 RVA: 0x0030BA78 File Offset: 0x00309C78
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectEffect.Types.ObjectEffectMinMaxValue HscNTgG8DL3sqvLfEO66()
				{
					return null;
				}

				// Token: 0x0400336F RID: 13167
				private static readonly MessageParser<ObjectEffect.Types.ObjectEffectMinMaxValue> _parser;

				// Token: 0x04003370 RID: 13168
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003371 RID: 13169
				public const int MinFieldNumber = 1;

				// Token: 0x04003372 RID: 13170
				private int min_;

				// Token: 0x04003373 RID: 13171
				public const int MaxFieldNumber = 2;

				// Token: 0x04003374 RID: 13172
				private int max_;

				// Token: 0x04003375 RID: 13173
				private static ObjectEffect.Types.ObjectEffectMinMaxValue B86uNaG80mYxGnnpPgwG;
			}

			// Token: 0x02000B5F RID: 2911
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectEffectDiceValue : IMessage<ObjectEffect.Types.ObjectEffectDiceValue>, IMessage, IEquatable<ObjectEffect.Types.ObjectEffectDiceValue>, IDeepCloneable<ObjectEffect.Types.ObjectEffectDiceValue>, IBufferMessage
			{
				// Token: 0x170019DD RID: 6621
				// (get) Token: 0x06008B85 RID: 35717 RVA: 0x0030BA80 File Offset: 0x00309C80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectEffect.Types.ObjectEffectDiceValue> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019DE RID: 6622
				// (get) Token: 0x06008B86 RID: 35718 RVA: 0x0030BA90 File Offset: 0x00309C90
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

				// Token: 0x170019DF RID: 6623
				// (get) Token: 0x06008B87 RID: 35719 RVA: 0x0030BAA0 File Offset: 0x00309CA0
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

				// Token: 0x06008B88 RID: 35720 RVA: 0x0030BAB0 File Offset: 0x00309CB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectDiceValue()
				{
				}

				// Token: 0x06008B89 RID: 35721 RVA: 0x0030BAC0 File Offset: 0x00309CC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectDiceValue(ObjectEffect.Types.ObjectEffectDiceValue other)
				{
				}

				// Token: 0x06008B8A RID: 35722 RVA: 0x0030BAD0 File Offset: 0x00309CD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffect.Types.ObjectEffectDiceValue Clone()
				{
					return null;
				}

				// Token: 0x170019E0 RID: 6624
				// (get) Token: 0x06008B8B RID: 35723 RVA: 0x0030BAE0 File Offset: 0x00309CE0
				// (set) Token: 0x06008B8C RID: 35724 RVA: 0x0030BAF0 File Offset: 0x00309CF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long Num
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

				// Token: 0x170019E1 RID: 6625
				// (get) Token: 0x06008B8D RID: 35725 RVA: 0x0030BB00 File Offset: 0x00309D00
				// (set) Token: 0x06008B8E RID: 35726 RVA: 0x0030BB10 File Offset: 0x00309D10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Side
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

				// Token: 0x170019E2 RID: 6626
				// (get) Token: 0x06008B8F RID: 35727 RVA: 0x0030BB20 File Offset: 0x00309D20
				// (set) Token: 0x06008B90 RID: 35728 RVA: 0x0030BB30 File Offset: 0x00309D30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Const
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

				// Token: 0x06008B91 RID: 35729 RVA: 0x0030BB40 File Offset: 0x00309D40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008B92 RID: 35730 RVA: 0x0030BB50 File Offset: 0x00309D50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectEffect.Types.ObjectEffectDiceValue other)
				{
					return true;
				}

				// Token: 0x06008B93 RID: 35731 RVA: 0x0030BB60 File Offset: 0x00309D60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008B94 RID: 35732 RVA: 0x0030BB70 File Offset: 0x00309D70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008B95 RID: 35733 RVA: 0x0030BB80 File Offset: 0x00309D80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008B96 RID: 35734 RVA: 0x0030BB90 File Offset: 0x00309D90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008B97 RID: 35735 RVA: 0x0030BBA0 File Offset: 0x00309DA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008B98 RID: 35736 RVA: 0x0030BBB0 File Offset: 0x00309DB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectEffect.Types.ObjectEffectDiceValue other)
				{
				}

				// Token: 0x06008B99 RID: 35737 RVA: 0x0030BBC0 File Offset: 0x00309DC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008B9A RID: 35738 RVA: 0x0030BBD0 File Offset: 0x00309DD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008B9B RID: 35739 RVA: 0x0030BBE0 File Offset: 0x00309DE0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectEffectDiceValue()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							ObjectEffect.Types.ObjectEffectDiceValue._parser = new MessageParser<ObjectEffect.Types.ObjectEffectDiceValue>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							return;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
							{
								num2 = 3;
							}
							break;
						}
					}
				}

				// Token: 0x06008B9C RID: 35740 RVA: 0x0030BCC4 File Offset: 0x00309EC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ODCOl5G8wY7S8IpEQlDt()
				{
					return true;
				}

				// Token: 0x06008B9D RID: 35741 RVA: 0x0030BCCC File Offset: 0x00309ECC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectEffect.Types.ObjectEffectDiceValue Y5SfjYG8QTUWhaqng7lf()
				{
					return null;
				}

				// Token: 0x04003378 RID: 13176
				private static readonly MessageParser<ObjectEffect.Types.ObjectEffectDiceValue> _parser;

				// Token: 0x04003379 RID: 13177
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400337A RID: 13178
				public const int NumFieldNumber = 1;

				// Token: 0x0400337B RID: 13179
				private long num_;

				// Token: 0x0400337C RID: 13180
				public const int SideFieldNumber = 2;

				// Token: 0x0400337D RID: 13181
				private int side_;

				// Token: 0x0400337E RID: 13182
				public const int ConstFieldNumber = 3;

				// Token: 0x0400337F RID: 13183
				private int const_;

				// Token: 0x04003380 RID: 13184
				internal static ObjectEffect.Types.ObjectEffectDiceValue fGCng4G8tfBwPR5hjebR;
			}

			// Token: 0x02000B61 RID: 2913
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MonsterCount : IMessage<ObjectEffect.Types.MonsterCount>, IMessage, IEquatable<ObjectEffect.Types.MonsterCount>, IDeepCloneable<ObjectEffect.Types.MonsterCount>, IBufferMessage
			{
				// Token: 0x170019E3 RID: 6627
				// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x0030BCD4 File Offset: 0x00309ED4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ObjectEffect.Types.MonsterCount> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019E4 RID: 6628
				// (get) Token: 0x06008BA4 RID: 35748 RVA: 0x0030BCE4 File Offset: 0x00309EE4
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

				// Token: 0x170019E5 RID: 6629
				// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x0030BCF4 File Offset: 0x00309EF4
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

				// Token: 0x06008BA6 RID: 35750 RVA: 0x0030BD04 File Offset: 0x00309F04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MonsterCount()
				{
				}

				// Token: 0x06008BA7 RID: 35751 RVA: 0x0030BD14 File Offset: 0x00309F14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MonsterCount(ObjectEffect.Types.MonsterCount other)
				{
				}

				// Token: 0x06008BA8 RID: 35752 RVA: 0x0030BD24 File Offset: 0x00309F24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffect.Types.MonsterCount Clone()
				{
					return null;
				}

				// Token: 0x170019E6 RID: 6630
				// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x0030BD34 File Offset: 0x00309F34
				// (set) Token: 0x06008BAA RID: 35754 RVA: 0x0030BD44 File Offset: 0x00309F44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CreatureFamily
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

				// Token: 0x170019E7 RID: 6631
				// (get) Token: 0x06008BAB RID: 35755 RVA: 0x0030BD54 File Offset: 0x00309F54
				// (set) Token: 0x06008BAC RID: 35756 RVA: 0x0030BD64 File Offset: 0x00309F64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Count
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

				// Token: 0x06008BAD RID: 35757 RVA: 0x0030BD74 File Offset: 0x00309F74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008BAE RID: 35758 RVA: 0x0030BD84 File Offset: 0x00309F84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectEffect.Types.MonsterCount other)
				{
					return true;
				}

				// Token: 0x06008BAF RID: 35759 RVA: 0x0030BD94 File Offset: 0x00309F94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008BB0 RID: 35760 RVA: 0x0030BDA4 File Offset: 0x00309FA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008BB1 RID: 35761 RVA: 0x0030BDB4 File Offset: 0x00309FB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008BB2 RID: 35762 RVA: 0x0030BDC4 File Offset: 0x00309FC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008BB3 RID: 35763 RVA: 0x0030BDD4 File Offset: 0x00309FD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008BB4 RID: 35764 RVA: 0x0030BDE4 File Offset: 0x00309FE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectEffect.Types.MonsterCount other)
				{
				}

				// Token: 0x06008BB5 RID: 35765 RVA: 0x0030BDF4 File Offset: 0x00309FF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008BB6 RID: 35766 RVA: 0x0030BE04 File Offset: 0x0030A004
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008BB7 RID: 35767 RVA: 0x0030BE14 File Offset: 0x0030A014
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MonsterCount()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							ObjectEffect.Types.MonsterCount._parser = new MessageParser<ObjectEffect.Types.MonsterCount>(() => null);
							num2 = 3;
							break;
						case 1:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
							{
								num2 = 3;
							}
							break;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x06008BB8 RID: 35768 RVA: 0x0030BEF8 File Offset: 0x0030A0F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool StRB7CG8TkQdOaUtBFSK()
				{
					return true;
				}

				// Token: 0x06008BB9 RID: 35769 RVA: 0x0030BF00 File Offset: 0x0030A100
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectEffect.Types.MonsterCount LJB2mYG8pahEkO08F2KP()
				{
					return null;
				}

				// Token: 0x04003383 RID: 13187
				private static readonly MessageParser<ObjectEffect.Types.MonsterCount> _parser;

				// Token: 0x04003384 RID: 13188
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003385 RID: 13189
				public const int CreatureFamilyFieldNumber = 1;

				// Token: 0x04003386 RID: 13190
				private int creatureFamily_;

				// Token: 0x04003387 RID: 13191
				public const int CountFieldNumber = 2;

				// Token: 0x04003388 RID: 13192
				private int count_;

				// Token: 0x04003389 RID: 13193
				internal static ObjectEffect.Types.MonsterCount HWOpb4G87w9Gv6qk3JRR;
			}

			// Token: 0x02000B63 RID: 2915
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectEffectMountValue : IMessage<ObjectEffect.Types.ObjectEffectMountValue>, IMessage, IEquatable<ObjectEffect.Types.ObjectEffectMountValue>, IDeepCloneable<ObjectEffect.Types.ObjectEffectMountValue>, IBufferMessage
			{
				// Token: 0x170019E8 RID: 6632
				// (get) Token: 0x06008BBF RID: 35775 RVA: 0x0030BF08 File Offset: 0x0030A108
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectEffect.Types.ObjectEffectMountValue> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019E9 RID: 6633
				// (get) Token: 0x06008BC0 RID: 35776 RVA: 0x0030BF18 File Offset: 0x0030A118
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

				// Token: 0x170019EA RID: 6634
				// (get) Token: 0x06008BC1 RID: 35777 RVA: 0x0030BF28 File Offset: 0x0030A128
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

				// Token: 0x06008BC2 RID: 35778 RVA: 0x0030BF38 File Offset: 0x0030A138
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectMountValue()
				{
				}

				// Token: 0x06008BC3 RID: 35779 RVA: 0x0030BF48 File Offset: 0x0030A148
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffectMountValue(ObjectEffect.Types.ObjectEffectMountValue other)
				{
				}

				// Token: 0x06008BC4 RID: 35780 RVA: 0x0030BF58 File Offset: 0x0030A158
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectEffect.Types.ObjectEffectMountValue Clone()
				{
					return null;
				}

				// Token: 0x170019EB RID: 6635
				// (get) Token: 0x06008BC5 RID: 35781 RVA: 0x0030BF68 File Offset: 0x0030A168
				// (set) Token: 0x06008BC6 RID: 35782 RVA: 0x0030BF78 File Offset: 0x0030A178
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long CertificateId
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

				// Token: 0x170019EC RID: 6636
				// (get) Token: 0x06008BC7 RID: 35783 RVA: 0x0030BF88 File Offset: 0x0030A188
				// (set) Token: 0x06008BC8 RID: 35784 RVA: 0x0030BF98 File Offset: 0x0030A198
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string DateExpiration
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

				// Token: 0x170019ED RID: 6637
				// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x0030BFA8 File Offset: 0x0030A1A8
				// (set) Token: 0x06008BCA RID: 35786 RVA: 0x0030BFB8 File Offset: 0x0030A1B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x170019EE RID: 6638
				// (get) Token: 0x06008BCB RID: 35787 RVA: 0x0030BFC8 File Offset: 0x0030A1C8
				// (set) Token: 0x06008BCC RID: 35788 RVA: 0x0030BFD8 File Offset: 0x0030A1D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string MountName
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

				// Token: 0x170019EF RID: 6639
				// (get) Token: 0x06008BCD RID: 35789 RVA: 0x0030BFE8 File Offset: 0x0030A1E8
				// (set) Token: 0x06008BCE RID: 35790 RVA: 0x0030BFF8 File Offset: 0x0030A1F8
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

				// Token: 0x170019F0 RID: 6640
				// (get) Token: 0x06008BCF RID: 35791 RVA: 0x0030C008 File Offset: 0x0030A208
				// (set) Token: 0x06008BD0 RID: 35792 RVA: 0x0030C018 File Offset: 0x0030A218
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MountLevel
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

				// Token: 0x170019F1 RID: 6641
				// (get) Token: 0x06008BD1 RID: 35793 RVA: 0x0030C028 File Offset: 0x0030A228
				// (set) Token: 0x06008BD2 RID: 35794 RVA: 0x0030C03C File Offset: 0x0030A23C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public Gender MountGender
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (Gender)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170019F2 RID: 6642
				// (get) Token: 0x06008BD3 RID: 35795 RVA: 0x0030C04C File Offset: 0x0030A24C
				// (set) Token: 0x06008BD4 RID: 35796 RVA: 0x0030C05C File Offset: 0x0030A25C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Rideable
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

				// Token: 0x170019F3 RID: 6643
				// (get) Token: 0x06008BD5 RID: 35797 RVA: 0x0030C06C File Offset: 0x0030A26C
				// (set) Token: 0x06008BD6 RID: 35798 RVA: 0x0030C07C File Offset: 0x0030A27C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Impregnated
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

				// Token: 0x170019F4 RID: 6644
				// (get) Token: 0x06008BD7 RID: 35799 RVA: 0x0030C08C File Offset: 0x0030A28C
				// (set) Token: 0x06008BD8 RID: 35800 RVA: 0x0030C09C File Offset: 0x0030A29C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool ImpregnateReady
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

				// Token: 0x170019F5 RID: 6645
				// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x0030C0AC File Offset: 0x0030A2AC
				// (set) Token: 0x06008BDA RID: 35802 RVA: 0x0030C0BC File Offset: 0x0030A2BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ReproductionCount
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

				// Token: 0x170019F6 RID: 6646
				// (get) Token: 0x06008BDB RID: 35803 RVA: 0x0030C0CC File Offset: 0x0030A2CC
				// (set) Token: 0x06008BDC RID: 35804 RVA: 0x0030C0DC File Offset: 0x0030A2DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ReproductionMax
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

				// Token: 0x170019F7 RID: 6647
				// (get) Token: 0x06008BDD RID: 35805 RVA: 0x0030C0EC File Offset: 0x0030A2EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<ObjectEffect> Effect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170019F8 RID: 6648
				// (get) Token: 0x06008BDE RID: 35806 RVA: 0x0030C0FC File Offset: 0x0030A2FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<int> Capacity
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06008BDF RID: 35807 RVA: 0x0030C10C File Offset: 0x0030A30C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008BE0 RID: 35808 RVA: 0x0030C11C File Offset: 0x0030A31C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectEffect.Types.ObjectEffectMountValue other)
				{
					return true;
				}

				// Token: 0x06008BE1 RID: 35809 RVA: 0x0030C12C File Offset: 0x0030A32C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008BE2 RID: 35810 RVA: 0x0030C13C File Offset: 0x0030A33C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008BE3 RID: 35811 RVA: 0x0030C14C File Offset: 0x0030A34C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008BE4 RID: 35812 RVA: 0x0030C15C File Offset: 0x0030A35C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008BE5 RID: 35813 RVA: 0x0030C16C File Offset: 0x0030A36C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008BE6 RID: 35814 RVA: 0x0030C17C File Offset: 0x0030A37C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectEffect.Types.ObjectEffectMountValue other)
				{
				}

				// Token: 0x06008BE7 RID: 35815 RVA: 0x0030C18C File Offset: 0x0030A38C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008BE8 RID: 35816 RVA: 0x0030C19C File Offset: 0x0030A39C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008BE9 RID: 35817 RVA: 0x0030C1AC File Offset: 0x0030A3AC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectEffectMountValue()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							ObjectEffect.Types.ObjectEffectMountValue._parser = new MessageParser<ObjectEffect.Types.ObjectEffectMountValue>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
							{
								num2 = 6;
								continue;
							}
							continue;
						case 5:
							ObjectEffect.Types.ObjectEffectMountValue._repeated_capacity_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(114U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 6:
							ObjectEffect.Types.ObjectEffectMountValue._repeated_effect_codec = FieldCodec.ForMessage<ObjectEffect>(106U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
							num2 = 5;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
					}
				}

				// Token: 0x06008BEA RID: 35818 RVA: 0x0030C2E8 File Offset: 0x0030A4E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ILwJENG8YN2KGvJH7KNW()
				{
					return true;
				}

				// Token: 0x06008BEB RID: 35819 RVA: 0x0030C2F0 File Offset: 0x0030A4F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectEffect.Types.ObjectEffectMountValue jgOE0RG8bynvICK5Fq26()
				{
					return null;
				}

				// Token: 0x0400338C RID: 13196
				private static readonly MessageParser<ObjectEffect.Types.ObjectEffectMountValue> _parser;

				// Token: 0x0400338D RID: 13197
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400338E RID: 13198
				public const int CertificateIdFieldNumber = 1;

				// Token: 0x0400338F RID: 13199
				private long certificateId_;

				// Token: 0x04003390 RID: 13200
				public const int DateExpirationFieldNumber = 2;

				// Token: 0x04003391 RID: 13201
				private string dateExpiration_;

				// Token: 0x04003392 RID: 13202
				public const int ModelIdFieldNumber = 3;

				// Token: 0x04003393 RID: 13203
				private int modelId_;

				// Token: 0x04003394 RID: 13204
				public const int MountNameFieldNumber = 4;

				// Token: 0x04003395 RID: 13205
				private string mountName_;

				// Token: 0x04003396 RID: 13206
				public const int OwnerNameFieldNumber = 5;

				// Token: 0x04003397 RID: 13207
				private string ownerName_;

				// Token: 0x04003398 RID: 13208
				public const int MountLevelFieldNumber = 6;

				// Token: 0x04003399 RID: 13209
				private int mountLevel_;

				// Token: 0x0400339A RID: 13210
				public const int MountGenderFieldNumber = 7;

				// Token: 0x0400339B RID: 13211
				private Gender mountGender_;

				// Token: 0x0400339C RID: 13212
				public const int RideableFieldNumber = 8;

				// Token: 0x0400339D RID: 13213
				private bool rideable_;

				// Token: 0x0400339E RID: 13214
				public const int ImpregnatedFieldNumber = 9;

				// Token: 0x0400339F RID: 13215
				private bool impregnated_;

				// Token: 0x040033A0 RID: 13216
				public const int ImpregnateReadyFieldNumber = 10;

				// Token: 0x040033A1 RID: 13217
				private bool impregnateReady_;

				// Token: 0x040033A2 RID: 13218
				public const int ReproductionCountFieldNumber = 11;

				// Token: 0x040033A3 RID: 13219
				private int reproductionCount_;

				// Token: 0x040033A4 RID: 13220
				public const int ReproductionMaxFieldNumber = 12;

				// Token: 0x040033A5 RID: 13221
				private int reproductionMax_;

				// Token: 0x040033A6 RID: 13222
				public const int EffectFieldNumber = 13;

				// Token: 0x040033A7 RID: 13223
				private static readonly FieldCodec<ObjectEffect> _repeated_effect_codec;

				// Token: 0x040033A8 RID: 13224
				private readonly RepeatedField<ObjectEffect> effect_;

				// Token: 0x040033A9 RID: 13225
				public const int CapacityFieldNumber = 14;

				// Token: 0x040033AA RID: 13226
				private static readonly FieldCodec<int> _repeated_capacity_codec;

				// Token: 0x040033AB RID: 13227
				private readonly RepeatedField<int> capacity_;

				// Token: 0x040033AC RID: 13228
				internal static ObjectEffect.Types.ObjectEffectMountValue hPnc4mG8HqsrxWeORBP3;
			}
		}
	}
}
