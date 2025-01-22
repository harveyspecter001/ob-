using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000721 RID: 1825
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectRemovedFromBagEvent : IMessage<ExchangeObjectRemovedFromBagEvent>, IMessage, IEquatable<ExchangeObjectRemovedFromBagEvent>, IDeepCloneable<ExchangeObjectRemovedFromBagEvent>, IBufferMessage
	{
		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x002174F4 File Offset: 0x002156F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectRemovedFromBagEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x00217504 File Offset: 0x00215704
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

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x00217514 File Offset: 0x00215714
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

		// Token: 0x0600595D RID: 22877 RVA: 0x00217524 File Offset: 0x00215724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedFromBagEvent()
		{
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00217534 File Offset: 0x00215734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedFromBagEvent(ExchangeObjectRemovedFromBagEvent other)
		{
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00217544 File Offset: 0x00215744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedFromBagEvent Clone()
		{
			return null;
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x00217554 File Offset: 0x00215754
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x00217564 File Offset: 0x00215764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Remote
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

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x00217574 File Offset: 0x00215774
		// (set) Token: 0x06005963 RID: 22883 RVA: 0x00217584 File Offset: 0x00215784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x06005964 RID: 22884 RVA: 0x00217594 File Offset: 0x00215794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x002175A4 File Offset: 0x002157A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectRemovedFromBagEvent other)
		{
			return true;
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x002175B4 File Offset: 0x002157B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x002175C4 File Offset: 0x002157C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x002175D4 File Offset: 0x002157D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x002175E4 File Offset: 0x002157E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x002175F4 File Offset: 0x002157F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00217604 File Offset: 0x00215804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectRemovedFromBagEvent other)
		{
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00217614 File Offset: 0x00215814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00217624 File Offset: 0x00215824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00217634 File Offset: 0x00215834
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectRemovedFromBagEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					ExchangeObjectRemovedFromBagEvent._parser = new MessageParser<ExchangeObjectRemovedFromBagEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00217718 File Offset: 0x00215918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yKhZjdOuSGiD5v7Ncn0P()
		{
			return true;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00217720 File Offset: 0x00215920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectRemovedFromBagEvent DukUcOOuM477GRKHFvdU()
		{
			return null;
		}

		// Token: 0x04001F4C RID: 8012
		private static readonly MessageParser<ExchangeObjectRemovedFromBagEvent> _parser;

		// Token: 0x04001F4D RID: 8013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F4E RID: 8014
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F4F RID: 8015
		private bool remote_;

		// Token: 0x04001F50 RID: 8016
		public const int ObjectUidFieldNumber = 2;

		// Token: 0x04001F51 RID: 8017
		private int objectUid_;

		// Token: 0x04001F52 RID: 8018
		private static ExchangeObjectRemovedFromBagEvent GTJhcjOuPdAHKWx5arXU;
	}
}
