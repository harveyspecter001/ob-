using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x02000623 RID: 1571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SequenceStartEvent : IMessage<SequenceStartEvent>, IMessage, IEquatable<SequenceStartEvent>, IDeepCloneable<SequenceStartEvent>, IBufferMessage
	{
		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x001FED10 File Offset: 0x001FCF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SequenceStartEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x001FED20 File Offset: 0x001FCF20
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

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x001FED30 File Offset: 0x001FCF30
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

		// Token: 0x06004C3B RID: 19515 RVA: 0x001FED40 File Offset: 0x001FCF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceStartEvent()
		{
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x001FED50 File Offset: 0x001FCF50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceStartEvent(SequenceStartEvent other)
		{
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x001FED60 File Offset: 0x001FCF60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceStartEvent Clone()
		{
			return null;
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x001FED70 File Offset: 0x001FCF70
		// (set) Token: 0x06004C3F RID: 19519 RVA: 0x001FED84 File Offset: 0x001FCF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SequenceType SequenceType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SequenceType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x001FED94 File Offset: 0x001FCF94
		// (set) Token: 0x06004C41 RID: 19521 RVA: 0x001FEDA4 File Offset: 0x001FCFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AuthorId
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

		// Token: 0x06004C42 RID: 19522 RVA: 0x001FEDB4 File Offset: 0x001FCFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x001FEDC4 File Offset: 0x001FCFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SequenceStartEvent other)
		{
			return true;
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x001FEDD4 File Offset: 0x001FCFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x001FEDE4 File Offset: 0x001FCFE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x001FEDF4 File Offset: 0x001FCFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x001FEE04 File Offset: 0x001FD004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x001FEE14 File Offset: 0x001FD014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x001FEE24 File Offset: 0x001FD024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SequenceStartEvent other)
		{
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x001FEE34 File Offset: 0x001FD034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x001FEE44 File Offset: 0x001FD044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x001FEE54 File Offset: 0x001FD054
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SequenceStartEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SequenceStartEvent._parser = new MessageParser<SequenceStartEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x001FEF38 File Offset: 0x001FD138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iyQQy6ObMJZrrThvaTOV()
		{
			return true;
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x001FEF40 File Offset: 0x001FD140
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SequenceStartEvent decSDvObuX9HSaGAtAbh()
		{
			return null;
		}

		// Token: 0x04001A98 RID: 6808
		private static readonly MessageParser<SequenceStartEvent> _parser;

		// Token: 0x04001A99 RID: 6809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A9A RID: 6810
		public const int SequenceTypeFieldNumber = 1;

		// Token: 0x04001A9B RID: 6811
		private SequenceType sequenceType_;

		// Token: 0x04001A9C RID: 6812
		public const int AuthorIdFieldNumber = 2;

		// Token: 0x04001A9D RID: 6813
		private long authorId_;

		// Token: 0x04001A9E RID: 6814
		internal static SequenceStartEvent smWlspObSm1kSGauB3Ph;
	}
}
