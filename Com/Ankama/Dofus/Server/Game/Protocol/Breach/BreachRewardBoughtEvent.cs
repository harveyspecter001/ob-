using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000991 RID: 2449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRewardBoughtEvent : IMessage<BreachRewardBoughtEvent>, IMessage, IEquatable<BreachRewardBoughtEvent>, IDeepCloneable<BreachRewardBoughtEvent>, IBufferMessage
	{
		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x00244550 File Offset: 0x00242750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachRewardBoughtEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600768C RID: 30348 RVA: 0x00244560 File Offset: 0x00242760
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

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600768D RID: 30349 RVA: 0x00244570 File Offset: 0x00242770
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

		// Token: 0x0600768E RID: 30350 RVA: 0x00244580 File Offset: 0x00242780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBoughtEvent()
		{
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00244590 File Offset: 0x00242790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBoughtEvent(BreachRewardBoughtEvent other)
		{
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x002445A0 File Offset: 0x002427A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBoughtEvent Clone()
		{
			return null;
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x002445B0 File Offset: 0x002427B0
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x002445C0 File Offset: 0x002427C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
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

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x002445D0 File Offset: 0x002427D0
		// (set) Token: 0x06007694 RID: 30356 RVA: 0x002445E0 File Offset: 0x002427E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Bought
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

		// Token: 0x06007695 RID: 30357 RVA: 0x002445F0 File Offset: 0x002427F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00244600 File Offset: 0x00242800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRewardBoughtEvent other)
		{
			return true;
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00244610 File Offset: 0x00242810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00244620 File Offset: 0x00242820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00244630 File Offset: 0x00242830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00244640 File Offset: 0x00242840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00244650 File Offset: 0x00242850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00244660 File Offset: 0x00242860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRewardBoughtEvent other)
		{
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00244670 File Offset: 0x00242870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00244680 File Offset: 0x00242880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00244690 File Offset: 0x00242890
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRewardBoughtEvent()
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
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						BreachRewardBoughtEvent._parser = new MessageParser<BreachRewardBoughtEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				IL_C1:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				goto IL_C1;
			}
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00244778 File Offset: 0x00242978
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T8UpKwJRZKVwsEfQHoYi()
		{
			return true;
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00244780 File Offset: 0x00242980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRewardBoughtEvent maUhCXJRq2a2hl6Ngt8p()
		{
			return null;
		}

		// Token: 0x0400293E RID: 10558
		private static readonly MessageParser<BreachRewardBoughtEvent> _parser;

		// Token: 0x0400293F RID: 10559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002940 RID: 10560
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04002941 RID: 10561
		private int rewardId_;

		// Token: 0x04002942 RID: 10562
		public const int BoughtFieldNumber = 2;

		// Token: 0x04002943 RID: 10563
		private bool bought_;

		// Token: 0x04002944 RID: 10564
		internal static BreachRewardBoughtEvent A9mrLXJR84oklKJJjDyV;
	}
}
