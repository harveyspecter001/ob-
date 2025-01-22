using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000858 RID: 2136
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendWarnOnLevelGainStateEvent : IMessage<FriendWarnOnLevelGainStateEvent>, IMessage, IEquatable<FriendWarnOnLevelGainStateEvent>, IDeepCloneable<FriendWarnOnLevelGainStateEvent>, IBufferMessage
	{
		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0022D8C8 File Offset: 0x0022BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendWarnOnLevelGainStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x0022D8D8 File Offset: 0x0022BAD8
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

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x0022D8E8 File Offset: 0x0022BAE8
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

		// Token: 0x060067E3 RID: 26595 RVA: 0x0022D8F8 File Offset: 0x0022BAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnLevelGainStateEvent()
		{
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x0022D908 File Offset: 0x0022BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnLevelGainStateEvent(FriendWarnOnLevelGainStateEvent other)
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x0022D918 File Offset: 0x0022BB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnLevelGainStateEvent Clone()
		{
			return null;
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x0022D928 File Offset: 0x0022BB28
		// (set) Token: 0x060067E7 RID: 26599 RVA: 0x0022D938 File Offset: 0x0022BB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
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

		// Token: 0x060067E8 RID: 26600 RVA: 0x0022D948 File Offset: 0x0022BB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x0022D958 File Offset: 0x0022BB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendWarnOnLevelGainStateEvent other)
		{
			return true;
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x0022D968 File Offset: 0x0022BB68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x0022D978 File Offset: 0x0022BB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x0022D988 File Offset: 0x0022BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x0022D998 File Offset: 0x0022BB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x0022D9A8 File Offset: 0x0022BBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x0022D9B8 File Offset: 0x0022BBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendWarnOnLevelGainStateEvent other)
		{
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x0022D9C8 File Offset: 0x0022BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x0022D9D8 File Offset: 0x0022BBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x0022D9E8 File Offset: 0x0022BBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendWarnOnLevelGainStateEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5F;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 4;
					}
				}
				IL_5F:
				FriendWarnOnLevelGainStateEvent._parser = new MessageParser<FriendWarnOnLevelGainStateEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x0022DAD0 File Offset: 0x0022BCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CeyptWJnlj24PqXY1qiN()
		{
			return true;
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x0022DAD8 File Offset: 0x0022BCD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendWarnOnLevelGainStateEvent LGhcfuJncPP1ad81sQvg()
		{
			return null;
		}

		// Token: 0x0400245B RID: 9307
		private static readonly MessageParser<FriendWarnOnLevelGainStateEvent> _parser;

		// Token: 0x0400245C RID: 9308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400245D RID: 9309
		public const int EnableFieldNumber = 1;

		// Token: 0x0400245E RID: 9310
		private bool enable_;

		// Token: 0x0400245F RID: 9311
		private static FriendWarnOnLevelGainStateEvent XcqhWXJnkbKerCRrslck;
	}
}
