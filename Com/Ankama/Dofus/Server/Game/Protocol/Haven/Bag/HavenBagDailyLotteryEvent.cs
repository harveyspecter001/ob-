using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200049D RID: 1181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagDailyLotteryEvent : IMessage<HavenBagDailyLotteryEvent>, IMessage, IEquatable<HavenBagDailyLotteryEvent>, IDeepCloneable<HavenBagDailyLotteryEvent>, IBufferMessage
	{
		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x001E07A8 File Offset: 0x001DE9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagDailyLotteryEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x001E07B8 File Offset: 0x001DE9B8
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x001E07C8 File Offset: 0x001DE9C8
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

		// Token: 0x06003880 RID: 14464 RVA: 0x001E07D8 File Offset: 0x001DE9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagDailyLotteryEvent()
		{
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x001E07E8 File Offset: 0x001DE9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagDailyLotteryEvent(HavenBagDailyLotteryEvent other)
		{
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x001E07F8 File Offset: 0x001DE9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagDailyLotteryEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x001E0808 File Offset: 0x001DEA08
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x001E081C File Offset: 0x001DEA1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public HavenBagDailyLotteryEvent.Types.DailyLotteryResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HavenBagDailyLotteryEvent.Types.DailyLotteryResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x001E082C File Offset: 0x001DEA2C
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x001E083C File Offset: 0x001DEA3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long GameActionId
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

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x001E084C File Offset: 0x001DEA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasGameActionId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x001E085C File Offset: 0x001DEA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearGameActionId()
		{
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x001E086C File Offset: 0x001DEA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x001E087C File Offset: 0x001DEA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagDailyLotteryEvent other)
		{
			return true;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x001E088C File Offset: 0x001DEA8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x001E089C File Offset: 0x001DEA9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x001E08AC File Offset: 0x001DEAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x001E08BC File Offset: 0x001DEABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x001E08CC File Offset: 0x001DEACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x001E08DC File Offset: 0x001DEADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagDailyLotteryEvent other)
		{
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x001E08EC File Offset: 0x001DEAEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x001E08FC File Offset: 0x001DEAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x001E090C File Offset: 0x001DEB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagDailyLotteryEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					HavenBagDailyLotteryEvent.GameActionIdDefaultValue = 0L;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 5;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					HavenBagDailyLotteryEvent._parser = new MessageParser<HavenBagDailyLotteryEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x001E0A04 File Offset: 0x001DEC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ImVRhXOwDAe7R8LwRnqC()
		{
			return true;
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x001E0A0C File Offset: 0x001DEC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagDailyLotteryEvent lYfWpoOwtEcGa89utnX4()
		{
			return null;
		}

		// Token: 0x040013B5 RID: 5045
		private static readonly MessageParser<HavenBagDailyLotteryEvent> _parser;

		// Token: 0x040013B6 RID: 5046
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013B7 RID: 5047
		private int _hasBits0;

		// Token: 0x040013B8 RID: 5048
		public const int ResultFieldNumber = 1;

		// Token: 0x040013B9 RID: 5049
		private HavenBagDailyLotteryEvent.Types.DailyLotteryResult result_;

		// Token: 0x040013BA RID: 5050
		public const int GameActionIdFieldNumber = 2;

		// Token: 0x040013BB RID: 5051
		private static readonly long GameActionIdDefaultValue;

		// Token: 0x040013BC RID: 5052
		private long gameActionId_;

		// Token: 0x040013BD RID: 5053
		internal static HavenBagDailyLotteryEvent SrIH8ZOwCR4buShA3U8h;

		// Token: 0x0200049E RID: 1182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06003896 RID: 14486 RVA: 0x002C0D20 File Offset: 0x002BEF20
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200049F RID: 1183
			public enum DailyLotteryResult
			{
				// Token: 0x040013BF RID: 5055
				[OriginalName("HAVEN_BAG_DAILY_LOTTERY_OK")]
				HavenBagDailyLotteryOk,
				// Token: 0x040013C0 RID: 5056
				[OriginalName("HAVEN_BAG_DAILY_LOTTERY_ALREADY_USED")]
				HavenBagDailyLotteryAlreadyUsed,
				// Token: 0x040013C1 RID: 5057
				[OriginalName("HAVEN_BAG_DAILY_LOTTERY_ERROR")]
				HavenBagDailyLotteryError
			}
		}
	}
}
