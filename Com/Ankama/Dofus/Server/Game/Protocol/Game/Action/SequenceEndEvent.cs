using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x02000625 RID: 1573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SequenceEndEvent : IMessage<SequenceEndEvent>, IMessage, IEquatable<SequenceEndEvent>, IDeepCloneable<SequenceEndEvent>, IBufferMessage
	{
		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x001FEF48 File Offset: 0x001FD148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SequenceEndEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x001FEF58 File Offset: 0x001FD158
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

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x001FEF68 File Offset: 0x001FD168
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

		// Token: 0x06004C57 RID: 19543 RVA: 0x001FEF78 File Offset: 0x001FD178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceEndEvent()
		{
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001FEF88 File Offset: 0x001FD188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceEndEvent(SequenceEndEvent other)
		{
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x001FEF98 File Offset: 0x001FD198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceEndEvent Clone()
		{
			return null;
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x001FEFA8 File Offset: 0x001FD1A8
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x001FEFB8 File Offset: 0x001FD1B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ActionId
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

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x001FEFC8 File Offset: 0x001FD1C8
		// (set) Token: 0x06004C5D RID: 19549 RVA: 0x001FEFD8 File Offset: 0x001FD1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x001FEFE8 File Offset: 0x001FD1E8
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x001FEFFC File Offset: 0x001FD1FC
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

		// Token: 0x06004C60 RID: 19552 RVA: 0x001FF00C File Offset: 0x001FD20C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x001FF01C File Offset: 0x001FD21C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SequenceEndEvent other)
		{
			return true;
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x001FF02C File Offset: 0x001FD22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x001FF03C File Offset: 0x001FD23C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x001FF04C File Offset: 0x001FD24C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x001FF05C File Offset: 0x001FD25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x001FF06C File Offset: 0x001FD26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x001FF07C File Offset: 0x001FD27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SequenceEndEvent other)
		{
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x001FF08C File Offset: 0x001FD28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001FF09C File Offset: 0x001FD29C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x001FF0AC File Offset: 0x001FD2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SequenceEndEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SequenceEndEvent._parser = new MessageParser<SequenceEndEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x001FF190 File Offset: 0x001FD390
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WBpTgvObZ0A4n4g9Aw33()
		{
			return true;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x001FF198 File Offset: 0x001FD398
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SequenceEndEvent HILKIvObqvyuwtCEUPCX()
		{
			return null;
		}

		// Token: 0x04001AA1 RID: 6817
		private static readonly MessageParser<SequenceEndEvent> _parser;

		// Token: 0x04001AA2 RID: 6818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AA3 RID: 6819
		public const int ActionIdFieldNumber = 1;

		// Token: 0x04001AA4 RID: 6820
		private int actionId_;

		// Token: 0x04001AA5 RID: 6821
		public const int AuthorIdFieldNumber = 2;

		// Token: 0x04001AA6 RID: 6822
		private long authorId_;

		// Token: 0x04001AA7 RID: 6823
		public const int SequenceTypeFieldNumber = 3;

		// Token: 0x04001AA8 RID: 6824
		private SequenceType sequenceType_;

		// Token: 0x04001AA9 RID: 6825
		internal static SequenceEndEvent CKLp2WOb8hewDTyAaiu8;
	}
}
