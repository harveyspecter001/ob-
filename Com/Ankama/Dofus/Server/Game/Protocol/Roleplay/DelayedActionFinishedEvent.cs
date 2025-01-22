using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000196 RID: 406
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelayedActionFinishedEvent : IMessage<DelayedActionFinishedEvent>, IMessage, IEquatable<DelayedActionFinishedEvent>, IDeepCloneable<DelayedActionFinishedEvent>, IBufferMessage
	{
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x001A2A38 File Offset: 0x001A0C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DelayedActionFinishedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x001A2A48 File Offset: 0x001A0C48
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x001A2A58 File Offset: 0x001A0C58
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

		// Token: 0x060012D9 RID: 4825 RVA: 0x001A2A68 File Offset: 0x001A0C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionFinishedEvent()
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x001A2A78 File Offset: 0x001A0C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionFinishedEvent(DelayedActionFinishedEvent other)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x001A2A88 File Offset: 0x001A0C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionFinishedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x001A2A98 File Offset: 0x001A0C98
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x001A2AA8 File Offset: 0x001A0CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
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

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x001A2AB8 File Offset: 0x001A0CB8
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x001A2ACC File Offset: 0x001A0CCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DelayedActionType DelayedActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DelayedActionType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x001A2ADC File Offset: 0x001A0CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x001A2AEC File Offset: 0x001A0CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DelayedActionFinishedEvent other)
		{
			return true;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x001A2AFC File Offset: 0x001A0CFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x001A2B0C File Offset: 0x001A0D0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x001A2B1C File Offset: 0x001A0D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x001A2B2C File Offset: 0x001A0D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x001A2B3C File Offset: 0x001A0D3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x001A2B4C File Offset: 0x001A0D4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DelayedActionFinishedEvent other)
		{
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x001A2B5C File Offset: 0x001A0D5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x001A2B6C File Offset: 0x001A0D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x001A2B7C File Offset: 0x001A0D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DelayedActionFinishedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					DelayedActionFinishedEvent._parser = new MessageParser<DelayedActionFinishedEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x001A2C48 File Offset: 0x001A0E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t4WvmwOo3hwaY9hUpc1v()
		{
			return true;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x001A2C50 File Offset: 0x001A0E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DelayedActionFinishedEvent xDu8uFOoRH9g8m9g9aot()
		{
			return null;
		}

		// Token: 0x040006CF RID: 1743
		private static readonly MessageParser<DelayedActionFinishedEvent> _parser;

		// Token: 0x040006D0 RID: 1744
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006D1 RID: 1745
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x040006D2 RID: 1746
		private long characterId_;

		// Token: 0x040006D3 RID: 1747
		public const int DelayedActionTypeFieldNumber = 2;

		// Token: 0x040006D4 RID: 1748
		private DelayedActionType delayedActionType_;

		// Token: 0x040006D5 RID: 1749
		internal static DelayedActionFinishedEvent Yr18gUOoerYKtx18p5Tb;
	}
}
