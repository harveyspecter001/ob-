using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C51 RID: 3153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderVoteStartEvent : IMessage<SurrenderVoteStartEvent>, IMessage, IEquatable<SurrenderVoteStartEvent>, IDeepCloneable<SurrenderVoteStartEvent>, IBufferMessage
	{
		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06009772 RID: 38770 RVA: 0x0027836C File Offset: 0x0027656C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SurrenderVoteStartEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06009773 RID: 38771 RVA: 0x0027837C File Offset: 0x0027657C
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

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06009774 RID: 38772 RVA: 0x0027838C File Offset: 0x0027658C
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

		// Token: 0x06009775 RID: 38773 RVA: 0x0027839C File Offset: 0x0027659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteStartEvent()
		{
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x002783AC File Offset: 0x002765AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteStartEvent(SurrenderVoteStartEvent other)
		{
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x002783BC File Offset: 0x002765BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteStartEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06009778 RID: 38776 RVA: 0x002783CC File Offset: 0x002765CC
		// (set) Token: 0x06009779 RID: 38777 RVA: 0x002783DC File Offset: 0x002765DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AlreadyCastedVote
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

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600977A RID: 38778 RVA: 0x002783EC File Offset: 0x002765EC
		// (set) Token: 0x0600977B RID: 38779 RVA: 0x002783FC File Offset: 0x002765FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ParticipantNumber
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

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x0027840C File Offset: 0x0027660C
		// (set) Token: 0x0600977D RID: 38781 RVA: 0x0027841C File Offset: 0x0027661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CastedVoteNumber
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

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600977E RID: 38782 RVA: 0x0027842C File Offset: 0x0027662C
		// (set) Token: 0x0600977F RID: 38783 RVA: 0x0027843C File Offset: 0x0027663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VoteDuration
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

		// Token: 0x06009780 RID: 38784 RVA: 0x0027844C File Offset: 0x0027664C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009781 RID: 38785 RVA: 0x0027845C File Offset: 0x0027665C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderVoteStartEvent other)
		{
			return true;
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x0027846C File Offset: 0x0027666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009783 RID: 38787 RVA: 0x0027847C File Offset: 0x0027667C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0027848C File Offset: 0x0027668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0027849C File Offset: 0x0027669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x002784AC File Offset: 0x002766AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x002784BC File Offset: 0x002766BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderVoteStartEvent other)
		{
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x002784CC File Offset: 0x002766CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x002784DC File Offset: 0x002766DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x002784EC File Offset: 0x002766EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderVoteStartEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SurrenderVoteStartEvent._parser = new MessageParser<SurrenderVoteStartEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x002785D0 File Offset: 0x002767D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q00Gx2JNfd9DRtVhhDI4()
		{
			return true;
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x002785D8 File Offset: 0x002767D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderVoteStartEvent LIAT4vJNnSajkJvLY0b1()
		{
			return null;
		}

		// Token: 0x04003844 RID: 14404
		private static readonly MessageParser<SurrenderVoteStartEvent> _parser;

		// Token: 0x04003845 RID: 14405
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003846 RID: 14406
		public const int AlreadyCastedVoteFieldNumber = 1;

		// Token: 0x04003847 RID: 14407
		private bool alreadyCastedVote_;

		// Token: 0x04003848 RID: 14408
		public const int ParticipantNumberFieldNumber = 2;

		// Token: 0x04003849 RID: 14409
		private int participantNumber_;

		// Token: 0x0400384A RID: 14410
		public const int CastedVoteNumberFieldNumber = 3;

		// Token: 0x0400384B RID: 14411
		private int castedVoteNumber_;

		// Token: 0x0400384C RID: 14412
		public const int VoteDurationFieldNumber = 4;

		// Token: 0x0400384D RID: 14413
		private int voteDuration_;

		// Token: 0x0400384E RID: 14414
		internal static SurrenderVoteStartEvent dvgRiZJXz4mToSFb92mf;
	}
}
