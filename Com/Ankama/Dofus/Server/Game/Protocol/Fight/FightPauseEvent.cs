using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000675 RID: 1653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPauseEvent : IMessage<FightPauseEvent>, IMessage, IEquatable<FightPauseEvent>, IDeepCloneable<FightPauseEvent>, IBufferMessage
	{
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06005096 RID: 20630 RVA: 0x00205024 File Offset: 0x00203224
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightPauseEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x00205034 File Offset: 0x00203234
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

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x00205044 File Offset: 0x00203244
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

		// Token: 0x06005099 RID: 20633 RVA: 0x00205054 File Offset: 0x00203254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPauseEvent()
		{
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x00205064 File Offset: 0x00203264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPauseEvent(FightPauseEvent other)
		{
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x00205074 File Offset: 0x00203274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPauseEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x00205084 File Offset: 0x00203284
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x00205094 File Offset: 0x00203294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsPaused
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

		// Token: 0x0600509E RID: 20638 RVA: 0x002050A4 File Offset: 0x002032A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x002050B4 File Offset: 0x002032B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPauseEvent other)
		{
			return true;
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x002050C4 File Offset: 0x002032C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x002050D4 File Offset: 0x002032D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x002050E4 File Offset: 0x002032E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x002050F4 File Offset: 0x002032F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00205104 File Offset: 0x00203304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x00205114 File Offset: 0x00203314
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPauseEvent other)
		{
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x00205124 File Offset: 0x00203324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00205134 File Offset: 0x00203334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x00205144 File Offset: 0x00203344
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPauseEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
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
					FightPauseEvent._parser = new MessageParser<FightPauseEvent>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00205210 File Offset: 0x00203410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ov3S1JOiu08HtuDdN21P()
		{
			return true;
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00205218 File Offset: 0x00203418
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPauseEvent FrGfcqOi8L5pAkkhCOeU()
		{
			return null;
		}

		// Token: 0x04001C55 RID: 7253
		private static readonly MessageParser<FightPauseEvent> _parser;

		// Token: 0x04001C56 RID: 7254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C57 RID: 7255
		public const int IsPausedFieldNumber = 1;

		// Token: 0x04001C58 RID: 7256
		private bool isPaused_;

		// Token: 0x04001C59 RID: 7257
		private static FightPauseEvent i7ps60OiMHlwypeyU77r;
	}
}
