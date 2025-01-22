using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BEE RID: 3054
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakTransactionValidationEvent : IMessage<BakTransactionValidationEvent>, IMessage, IEquatable<BakTransactionValidationEvent>, IDeepCloneable<BakTransactionValidationEvent>, IBufferMessage
	{
		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x00272654 File Offset: 0x00270854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakTransactionValidationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00272664 File Offset: 0x00270864
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060092F9 RID: 37625 RVA: 0x00272674 File Offset: 0x00270874
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

		// Token: 0x060092FA RID: 37626 RVA: 0x00272684 File Offset: 0x00270884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationEvent()
		{
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x00272694 File Offset: 0x00270894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationEvent(BakTransactionValidationEvent other)
		{
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x002726A4 File Offset: 0x002708A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x002726B4 File Offset: 0x002708B4
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x002726C8 File Offset: 0x002708C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BidAction BidAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BidAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x002726D8 File Offset: 0x002708D8
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x002726EC File Offset: 0x002708EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BakTransactionValidationEvent.Types.BidValidation Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BakTransactionValidationEvent.Types.BidValidation)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x002726FC File Offset: 0x002708FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x0027270C File Offset: 0x0027090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakTransactionValidationEvent other)
		{
			return true;
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x0027271C File Offset: 0x0027091C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x0027272C File Offset: 0x0027092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x0027273C File Offset: 0x0027093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x0027274C File Offset: 0x0027094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x0027275C File Offset: 0x0027095C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x0027276C File Offset: 0x0027096C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakTransactionValidationEvent other)
		{
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x0027277C File Offset: 0x0027097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x0027278C File Offset: 0x0027098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x0027279C File Offset: 0x0027099C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakTransactionValidationEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 3:
						return;
					case 4:
						goto IL_35;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				BakTransactionValidationEvent._parser = new MessageParser<BakTransactionValidationEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x0027286C File Offset: 0x00270A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PMKyJpJE6VDrKxS4h35B()
		{
			return true;
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00272874 File Offset: 0x00270A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakTransactionValidationEvent XYUA3tJELXUe0W6ZO0Rx()
		{
			return null;
		}

		// Token: 0x040036B6 RID: 14006
		private static readonly MessageParser<BakTransactionValidationEvent> _parser;

		// Token: 0x040036B7 RID: 14007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B8 RID: 14008
		public const int BidActionFieldNumber = 1;

		// Token: 0x040036B9 RID: 14009
		private BidAction bidAction_;

		// Token: 0x040036BA RID: 14010
		public const int ResultFieldNumber = 2;

		// Token: 0x040036BB RID: 14011
		private BakTransactionValidationEvent.Types.BidValidation result_;

		// Token: 0x040036BC RID: 14012
		private static BakTransactionValidationEvent NjVY0vJEyfb2qyZCJZlB;

		// Token: 0x02000BEF RID: 3055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600930E RID: 37646 RVA: 0x002E6E38 File Offset: 0x002E5038
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000BF0 RID: 3056
			public enum BidValidation
			{
				// Token: 0x040036BE RID: 14014
				[OriginalName("BID_GENERIC_ERROR")]
				BidGenericError,
				// Token: 0x040036BF RID: 14015
				[OriginalName("BID_BUFFER_OVERLOAD")]
				BidBufferOverload,
				// Token: 0x040036C0 RID: 14016
				[OriginalName("BID_OFFER_DOESNT_EXIST")]
				BidOfferDoesntExist,
				// Token: 0x040036C1 RID: 14017
				[OriginalName("BID_OFFER_ALREADY_EXISTS")]
				BidOfferAlreadyExists,
				// Token: 0x040036C2 RID: 14018
				[OriginalName("BID_NOT_ENOUGH_KAMAS")]
				BidNotEnoughKamas,
				// Token: 0x040036C3 RID: 14019
				[OriginalName("BID_NOT_ENOUGH_OGRINES")]
				BidNotEnoughOgrines,
				// Token: 0x040036C4 RID: 14020
				[OriginalName("BID_SERVER_MAINTENANCE")]
				BidServerMaintenance,
				// Token: 0x040036C5 RID: 14021
				[OriginalName("BID_PLAYER_IN_DEBT")]
				BidPlayerInDebt,
				// Token: 0x040036C6 RID: 14022
				[OriginalName("BID_OFFER_IS_YOURS")]
				BidOfferIsYours,
				// Token: 0x040036C7 RID: 14023
				[OriginalName("BID_VALIDATION_SUCCESS")]
				Success
			}
		}
	}
}
