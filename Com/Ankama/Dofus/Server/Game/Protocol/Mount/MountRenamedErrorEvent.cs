using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000377 RID: 887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountRenamedErrorEvent : IMessage<MountRenamedErrorEvent>, IMessage, IEquatable<MountRenamedErrorEvent>, IDeepCloneable<MountRenamedErrorEvent>, IBufferMessage
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x001C8014 File Offset: 0x001C6214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountRenamedErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x001C8024 File Offset: 0x001C6224
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

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x001C8034 File Offset: 0x001C6234
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

		// Token: 0x060029AA RID: 10666 RVA: 0x001C8044 File Offset: 0x001C6244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedErrorEvent()
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x001C8054 File Offset: 0x001C6254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedErrorEvent(MountRenamedErrorEvent other)
		{
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x001C8064 File Offset: 0x001C6264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenamedErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x001C8074 File Offset: 0x001C6274
		// (set) Token: 0x060029AE RID: 10670 RVA: 0x001C8084 File Offset: 0x001C6284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MountId
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

		// Token: 0x060029AF RID: 10671 RVA: 0x001C8094 File Offset: 0x001C6294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x001C80A4 File Offset: 0x001C62A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountRenamedErrorEvent other)
		{
			return true;
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x001C80B4 File Offset: 0x001C62B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x001C80C4 File Offset: 0x001C62C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x001C80D4 File Offset: 0x001C62D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x001C80E4 File Offset: 0x001C62E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x001C80F4 File Offset: 0x001C62F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x001C8104 File Offset: 0x001C6304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountRenamedErrorEvent other)
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x001C8114 File Offset: 0x001C6314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x001C8124 File Offset: 0x001C6324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x001C8134 File Offset: 0x001C6334
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountRenamedErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					MountRenamedErrorEvent._parser = new MessageParser<MountRenamedErrorEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x001C8218 File Offset: 0x001C6418
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wqPF4HOr2oqfflSjtIeF()
		{
			return true;
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x001C8220 File Offset: 0x001C6420
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountRenamedErrorEvent Ai9h3AOrEJCT8L6rHfkR()
		{
			return null;
		}

		// Token: 0x04000EBC RID: 3772
		private static readonly MessageParser<MountRenamedErrorEvent> _parser;

		// Token: 0x04000EBD RID: 3773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EBE RID: 3774
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000EBF RID: 3775
		private int mountId_;

		// Token: 0x04000EC0 RID: 3776
		private static MountRenamedErrorEvent iSEgMkOr9pg2FuyJhPdj;
	}
}
