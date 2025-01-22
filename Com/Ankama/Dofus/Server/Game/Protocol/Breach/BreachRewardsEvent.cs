using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200098F RID: 2447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRewardsEvent : IMessage<BreachRewardsEvent>, IMessage, IEquatable<BreachRewardsEvent>, IDeepCloneable<BreachRewardsEvent>, IBufferMessage
	{
		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x00244324 File Offset: 0x00242524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachRewardsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06007673 RID: 30323 RVA: 0x00244334 File Offset: 0x00242534
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

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x00244344 File Offset: 0x00242544
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

		// Token: 0x06007675 RID: 30325 RVA: 0x00244354 File Offset: 0x00242554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardsEvent()
		{
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00244364 File Offset: 0x00242564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardsEvent(BreachRewardsEvent other)
		{
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00244374 File Offset: 0x00242574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x00244384 File Offset: 0x00242584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BreachReward> Rewards
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00244394 File Offset: 0x00242594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x002443A4 File Offset: 0x002425A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRewardsEvent other)
		{
			return true;
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x002443B4 File Offset: 0x002425B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x002443C4 File Offset: 0x002425C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x002443D4 File Offset: 0x002425D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x002443E4 File Offset: 0x002425E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x002443F4 File Offset: 0x002425F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00244404 File Offset: 0x00242604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRewardsEvent other)
		{
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00244414 File Offset: 0x00242614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00244424 File Offset: 0x00242624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00244434 File Offset: 0x00242634
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRewardsEvent()
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
						BreachRewardsEvent._repeated_rewards_codec = FieldCodec.ForMessage<BreachReward>(10U, k4yIxYBxvfeIy0gDC3VK.XVInXhlssT(k4yIxYBxvfeIy0gDC3VK.jsQBxomWHLb));
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 2:
						BreachRewardsEvent._parser = new MessageParser<BreachRewardsEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
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
					break;
				}
				IL_AC:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
				continue;
				goto IL_AC;
			}
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00244540 File Offset: 0x00242740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gMou4LJRMgrJfjHMMMSH()
		{
			return true;
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00244548 File Offset: 0x00242748
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRewardsEvent PUr3tHJRuWaHScUOn8y5()
		{
			return null;
		}

		// Token: 0x04002936 RID: 10550
		private static readonly MessageParser<BreachRewardsEvent> _parser;

		// Token: 0x04002937 RID: 10551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002938 RID: 10552
		public const int RewardsFieldNumber = 1;

		// Token: 0x04002939 RID: 10553
		private static readonly FieldCodec<BreachReward> _repeated_rewards_codec;

		// Token: 0x0400293A RID: 10554
		private readonly RepeatedField<BreachReward> rewards_;

		// Token: 0x0400293B RID: 10555
		private static BreachRewardsEvent SKK2TDJRSpoiIZkwuILG;
	}
}
