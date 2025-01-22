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
	// Token: 0x020006B5 RID: 1717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamUpdateEvent : IMessage<FightTeamUpdateEvent>, IMessage, IEquatable<FightTeamUpdateEvent>, IDeepCloneable<FightTeamUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x0020A4E4 File Offset: 0x002086E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0020A4F4 File Offset: 0x002086F4
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

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x0020A504 File Offset: 0x00208704
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

		// Token: 0x060053EA RID: 21482 RVA: 0x0020A514 File Offset: 0x00208714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamUpdateEvent()
		{
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x0020A524 File Offset: 0x00208724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamUpdateEvent(FightTeamUpdateEvent other)
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x0020A534 File Offset: 0x00208734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x0020A544 File Offset: 0x00208744
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x0020A554 File Offset: 0x00208754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x0020A564 File Offset: 0x00208764
		// (set) Token: 0x060053F0 RID: 21488 RVA: 0x0020A574 File Offset: 0x00208774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTeamInformation Team
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

		// Token: 0x060053F1 RID: 21489 RVA: 0x0020A584 File Offset: 0x00208784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0020A594 File Offset: 0x00208794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x0020A5A4 File Offset: 0x002087A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0020A5B4 File Offset: 0x002087B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0020A5C4 File Offset: 0x002087C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0020A5D4 File Offset: 0x002087D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x0020A5E4 File Offset: 0x002087E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x0020A5F4 File Offset: 0x002087F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamUpdateEvent other)
		{
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x0020A604 File Offset: 0x00208804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x0020A614 File Offset: 0x00208814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x0020A624 File Offset: 0x00208824
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					FightTeamUpdateEvent._parser = new MessageParser<FightTeamUpdateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x0020A71C File Offset: 0x0020891C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TKebpSOSKxXesUG1hNco()
		{
			return true;
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x0020A724 File Offset: 0x00208924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamUpdateEvent QcTFGmOSIMdvPW8M2gRo()
		{
			return null;
		}

		// Token: 0x04001D93 RID: 7571
		private static readonly MessageParser<FightTeamUpdateEvent> _parser;

		// Token: 0x04001D94 RID: 7572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D95 RID: 7573
		public const int FightIdFieldNumber = 1;

		// Token: 0x04001D96 RID: 7574
		private int fightId_;

		// Token: 0x04001D97 RID: 7575
		public const int TeamFieldNumber = 2;

		// Token: 0x04001D98 RID: 7576
		private FightTeamInformation team_;

		// Token: 0x04001D99 RID: 7577
		internal static FightTeamUpdateEvent AGZXTFOSj0YsbIsjmgeH;
	}
}
