using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000190 RID: 400
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveChallengeEvent : IMessage<RemoveChallengeEvent>, IMessage, IEquatable<RemoveChallengeEvent>, IDeepCloneable<RemoveChallengeEvent>, IBufferMessage
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x001A22F8 File Offset: 0x001A04F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RemoveChallengeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x001A2308 File Offset: 0x001A0508
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x001A2318 File Offset: 0x001A0518
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

		// Token: 0x0600127B RID: 4731 RVA: 0x001A2328 File Offset: 0x001A0528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveChallengeEvent()
		{
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x001A2338 File Offset: 0x001A0538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveChallengeEvent(RemoveChallengeEvent other)
		{
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x001A2348 File Offset: 0x001A0548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveChallengeEvent Clone()
		{
			return null;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x001A2358 File Offset: 0x001A0558
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x001A2368 File Offset: 0x001A0568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightId
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

		// Token: 0x06001280 RID: 4736 RVA: 0x001A2378 File Offset: 0x001A0578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x001A2388 File Offset: 0x001A0588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveChallengeEvent other)
		{
			return true;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x001A2398 File Offset: 0x001A0598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x001A23A8 File Offset: 0x001A05A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x001A23B8 File Offset: 0x001A05B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x001A23C8 File Offset: 0x001A05C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x001A23D8 File Offset: 0x001A05D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x001A23E8 File Offset: 0x001A05E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveChallengeEvent other)
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x001A23F8 File Offset: 0x001A05F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x001A2408 File Offset: 0x001A0608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x001A2418 File Offset: 0x001A0618
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveChallengeEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
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
						goto IL_9C;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
					}
				}
				IL_9C:
				RemoveChallengeEvent._parser = new MessageParser<RemoveChallengeEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x001A24E8 File Offset: 0x001A06E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fWjCPQOvqkqpsMueOwle()
		{
			return true;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x001A24F0 File Offset: 0x001A06F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveChallengeEvent XMHiPsOvF0Qckq03vnBc()
		{
			return null;
		}

		// Token: 0x040006AA RID: 1706
		private static readonly MessageParser<RemoveChallengeEvent> _parser;

		// Token: 0x040006AB RID: 1707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006AC RID: 1708
		public const int FightIdFieldNumber = 1;

		// Token: 0x040006AD RID: 1709
		private int fightId_;

		// Token: 0x040006AE RID: 1710
		internal static RemoveChallengeEvent QhnYcPOvZQ4ildbqYmdi;
	}
}
