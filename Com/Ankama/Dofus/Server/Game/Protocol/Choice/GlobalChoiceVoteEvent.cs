using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008C9 RID: 2249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GlobalChoiceVoteEvent : IMessage<GlobalChoiceVoteEvent>, IMessage, IEquatable<GlobalChoiceVoteEvent>, IDeepCloneable<GlobalChoiceVoteEvent>, IBufferMessage
	{
		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x00234334 File Offset: 0x00232534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GlobalChoiceVoteEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x00234344 File Offset: 0x00232544
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

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x00234354 File Offset: 0x00232554
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

		// Token: 0x06006D4E RID: 27982 RVA: 0x00234364 File Offset: 0x00232564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceVoteEvent()
		{
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x00234374 File Offset: 0x00232574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceVoteEvent(GlobalChoiceVoteEvent other)
		{
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x00234384 File Offset: 0x00232584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceVoteEvent Clone()
		{
			return null;
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06006D51 RID: 27985 RVA: 0x00234394 File Offset: 0x00232594
		// (set) Token: 0x06006D52 RID: 27986 RVA: 0x002343A4 File Offset: 0x002325A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06006D53 RID: 27987 RVA: 0x002343B4 File Offset: 0x002325B4
		// (set) Token: 0x06006D54 RID: 27988 RVA: 0x002343C4 File Offset: 0x002325C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ChoicePosition
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

		// Token: 0x06006D55 RID: 27989 RVA: 0x002343D4 File Offset: 0x002325D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x002343E4 File Offset: 0x002325E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GlobalChoiceVoteEvent other)
		{
			return true;
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x002343F4 File Offset: 0x002325F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x00234404 File Offset: 0x00232604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x00234414 File Offset: 0x00232614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x00234424 File Offset: 0x00232624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x00234434 File Offset: 0x00232634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x00234444 File Offset: 0x00232644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GlobalChoiceVoteEvent other)
		{
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x00234454 File Offset: 0x00232654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x00234464 File Offset: 0x00232664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x00234474 File Offset: 0x00232674
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalChoiceVoteEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GlobalChoiceVoteEvent._parser = new MessageParser<GlobalChoiceVoteEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x00234540 File Offset: 0x00232740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fNxOGhJA1fvg1RvfC9Y5()
		{
			return true;
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x00234548 File Offset: 0x00232748
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GlobalChoiceVoteEvent cl6t24JAaIoF73HUsSMF()
		{
			return null;
		}

		// Token: 0x0400261D RID: 9757
		private static readonly MessageParser<GlobalChoiceVoteEvent> _parser;

		// Token: 0x0400261E RID: 9758
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400261F RID: 9759
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002620 RID: 9760
		private long playerId_;

		// Token: 0x04002621 RID: 9761
		public const int ChoicePositionFieldNumber = 2;

		// Token: 0x04002622 RID: 9762
		private int choicePosition_;

		// Token: 0x04002623 RID: 9763
		internal static GlobalChoiceVoteEvent qVuq6vJAoTLDquxRe6aU;
	}
}
