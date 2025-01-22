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
	// Token: 0x02000A1E RID: 2590
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachReward : IMessage<BreachReward>, IMessage, IEquatable<BreachReward>, IDeepCloneable<BreachReward>, IBufferMessage
	{
		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x0025C560 File Offset: 0x0025A760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachReward> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06007BA4 RID: 31652 RVA: 0x0025C570 File Offset: 0x0025A770
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

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x0025C580 File Offset: 0x0025A780
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

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0025C590 File Offset: 0x0025A790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachReward()
		{
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x0025C5A0 File Offset: 0x0025A7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachReward(BreachReward other)
		{
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x0025C5B0 File Offset: 0x0025A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachReward Clone()
		{
			return null;
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x0025C5C0 File Offset: 0x0025A7C0
		// (set) Token: 0x06007BAA RID: 31658 RVA: 0x0025C5D0 File Offset: 0x0025A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x0025C5E0 File Offset: 0x0025A7E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<BreachReward.Types.BreachRewardLock> BuyLocks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0025C5F0 File Offset: 0x0025A7F0
		// (set) Token: 0x06007BAD RID: 31661 RVA: 0x0025C600 File Offset: 0x0025A800
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

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0025C610 File Offset: 0x0025A810
		// (set) Token: 0x06007BAF RID: 31663 RVA: 0x0025C620 File Offset: 0x0025A820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RemainingQuantity
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

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06007BB0 RID: 31664 RVA: 0x0025C630 File Offset: 0x0025A830
		// (set) Token: 0x06007BB1 RID: 31665 RVA: 0x0025C640 File Offset: 0x0025A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Price
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

		// Token: 0x06007BB2 RID: 31666 RVA: 0x0025C650 File Offset: 0x0025A850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x0025C660 File Offset: 0x0025A860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachReward other)
		{
			return true;
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x0025C670 File Offset: 0x0025A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x0025C680 File Offset: 0x0025A880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x0025C690 File Offset: 0x0025A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x0025C6A0 File Offset: 0x0025A8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x0025C6B0 File Offset: 0x0025A8B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x0025C6C0 File Offset: 0x0025A8C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachReward other)
		{
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x0025C6D0 File Offset: 0x0025A8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x0025C6E0 File Offset: 0x0025A8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x0025C6F0 File Offset: 0x0025A8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachReward()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BreachReward._repeated_buyLocks_codec = FieldCodec.ForEnum<BreachReward.Types.BreachRewardLock>(18U, (BreachReward.Types.BreachRewardLock x) => 0, (int x) => (BreachReward.Types.BreachRewardLock)null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
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
				BreachReward._parser = new MessageParser<BreachReward>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x0025C820 File Offset: 0x0025AA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tmWqrtJGdQeJVqkBcsgc()
		{
			return true;
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x0025C828 File Offset: 0x0025AA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachReward LfWvw5JG9KSciJ4SfwIb()
		{
			return null;
		}

		// Token: 0x04002C5F RID: 11359
		private static readonly MessageParser<BreachReward> _parser;

		// Token: 0x04002C60 RID: 11360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C61 RID: 11361
		public const int IdFieldNumber = 1;

		// Token: 0x04002C62 RID: 11362
		private int id_;

		// Token: 0x04002C63 RID: 11363
		public const int BuyLocksFieldNumber = 2;

		// Token: 0x04002C64 RID: 11364
		private static readonly FieldCodec<BreachReward.Types.BreachRewardLock> _repeated_buyLocks_codec;

		// Token: 0x04002C65 RID: 11365
		private readonly RepeatedField<BreachReward.Types.BreachRewardLock> buyLocks_;

		// Token: 0x04002C66 RID: 11366
		public const int BuyCriterionFieldNumber = 3;

		// Token: 0x04002C67 RID: 11367
		private string buyCriterion_;

		// Token: 0x04002C68 RID: 11368
		public const int RemainingQuantityFieldNumber = 4;

		// Token: 0x04002C69 RID: 11369
		private int remainingQuantity_;

		// Token: 0x04002C6A RID: 11370
		public const int PriceFieldNumber = 5;

		// Token: 0x04002C6B RID: 11371
		private int price_;

		// Token: 0x04002C6C RID: 11372
		internal static BreachReward a6NblRJGsD2Agq7WCjvB;

		// Token: 0x02000A1F RID: 2591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007BBF RID: 31679 RVA: 0x002DF0E0 File Offset: 0x002DD2E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A20 RID: 2592
			public enum BreachRewardLock
			{
				// Token: 0x04002C6E RID: 11374
				[OriginalName("BREACH_REWARD_LOCK_OWNER")]
				Owner,
				// Token: 0x04002C6F RID: 11375
				[OriginalName("BREACH_REWARD_LOCK_FIGHTER")]
				Fighter,
				// Token: 0x04002C70 RID: 11376
				[OriginalName("BREACH_REWARD_LOCK_RESOURCES")]
				Resources,
				// Token: 0x04002C71 RID: 11377
				[OriginalName("BREACH_REWARD_LOCK_CRITERION")]
				Criterion,
				// Token: 0x04002C72 RID: 11378
				[OriginalName("BREACH_REWARD_LOCK_USELESS")]
				Useless,
				// Token: 0x04002C73 RID: 11379
				[OriginalName("BREACH_REWARD_MAX_PURCHASE_REACHED")]
				BreachRewardMaxPurchaseReached
			}
		}
	}
}
