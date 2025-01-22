using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006B3 RID: 1715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightOptionUpdateEvent : IMessage<FightOptionUpdateEvent>, IMessage, IEquatable<FightOptionUpdateEvent>, IDeepCloneable<FightOptionUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x0020A27C File Offset: 0x0020847C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightOptionUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060053C8 RID: 21448 RVA: 0x0020A28C File Offset: 0x0020848C
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

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x0020A29C File Offset: 0x0020849C
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

		// Token: 0x060053CA RID: 21450 RVA: 0x0020A2AC File Offset: 0x002084AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionUpdateEvent()
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0020A2BC File Offset: 0x002084BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionUpdateEvent(FightOptionUpdateEvent other)
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0020A2CC File Offset: 0x002084CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x0020A2DC File Offset: 0x002084DC
		// (set) Token: 0x060053CE RID: 21454 RVA: 0x0020A2EC File Offset: 0x002084EC
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

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x0020A2FC File Offset: 0x002084FC
		// (set) Token: 0x060053D0 RID: 21456 RVA: 0x0020A310 File Offset: 0x00208510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x0020A320 File Offset: 0x00208520
		// (set) Token: 0x060053D2 RID: 21458 RVA: 0x0020A334 File Offset: 0x00208534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightOption Option
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightOption)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x0020A344 File Offset: 0x00208544
		// (set) Token: 0x060053D4 RID: 21460 RVA: 0x0020A354 File Offset: 0x00208554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State
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

		// Token: 0x060053D5 RID: 21461 RVA: 0x0020A364 File Offset: 0x00208564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0020A374 File Offset: 0x00208574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightOptionUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x0020A384 File Offset: 0x00208584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x0020A394 File Offset: 0x00208594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0020A3A4 File Offset: 0x002085A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0020A3B4 File Offset: 0x002085B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0020A3C4 File Offset: 0x002085C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0020A3D4 File Offset: 0x002085D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightOptionUpdateEvent other)
		{
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x0020A3E4 File Offset: 0x002085E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x0020A3F4 File Offset: 0x002085F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0020A404 File Offset: 0x00208604
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightOptionUpdateEvent()
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
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						goto IL_5E;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						break;
					}
				}
				IL_5E:
				FightOptionUpdateEvent._parser = new MessageParser<FightOptionUpdateEvent>(() => null);
				num = 2;
			}
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x0020A4D4 File Offset: 0x002086D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VEERrKOSxXWW6G6XL4e4()
		{
			return true;
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x0020A4DC File Offset: 0x002086DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightOptionUpdateEvent CYQXHKOS4m8ouielk2Dv()
		{
			return null;
		}

		// Token: 0x04001D86 RID: 7558
		private static readonly MessageParser<FightOptionUpdateEvent> _parser;

		// Token: 0x04001D87 RID: 7559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D88 RID: 7560
		public const int FightIdFieldNumber = 1;

		// Token: 0x04001D89 RID: 7561
		private int fightId_;

		// Token: 0x04001D8A RID: 7562
		public const int TeamFieldNumber = 2;

		// Token: 0x04001D8B RID: 7563
		private Team team_;

		// Token: 0x04001D8C RID: 7564
		public const int OptionFieldNumber = 3;

		// Token: 0x04001D8D RID: 7565
		private FightOption option_;

		// Token: 0x04001D8E RID: 7566
		public const int StateFieldNumber = 4;

		// Token: 0x04001D8F RID: 7567
		private bool state_;

		// Token: 0x04001D90 RID: 7568
		private static FightOptionUpdateEvent iaJ4JqOSNE43agEAw6oh;
	}
}
