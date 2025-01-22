using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000838 RID: 2104
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnIgnoreRequest : IMessage<UnIgnoreRequest>, IMessage, IEquatable<UnIgnoreRequest>, IDeepCloneable<UnIgnoreRequest>, IBufferMessage
	{
		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x0022B778 File Offset: 0x00229978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnIgnoreRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x0022B788 File Offset: 0x00229988
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

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x0022B798 File Offset: 0x00229998
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

		// Token: 0x06006641 RID: 26177 RVA: 0x0022B7A8 File Offset: 0x002299A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreRequest()
		{
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x0022B7B8 File Offset: 0x002299B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreRequest(UnIgnoreRequest other)
		{
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x0022B7C8 File Offset: 0x002299C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreRequest Clone()
		{
			return null;
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x0022B7D8 File Offset: 0x002299D8
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x0022B7E8 File Offset: 0x002299E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
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

		// Token: 0x06006646 RID: 26182 RVA: 0x0022B7F8 File Offset: 0x002299F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x0022B808 File Offset: 0x00229A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UnIgnoreRequest other)
		{
			return true;
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0022B818 File Offset: 0x00229A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x0022B828 File Offset: 0x00229A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x0022B838 File Offset: 0x00229A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x0022B848 File Offset: 0x00229A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x0022B858 File Offset: 0x00229A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x0022B868 File Offset: 0x00229A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UnIgnoreRequest other)
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x0022B878 File Offset: 0x00229A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x0022B888 File Offset: 0x00229A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x0022B898 File Offset: 0x00229A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnIgnoreRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UnIgnoreRequest._parser = new MessageParser<UnIgnoreRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x0022B990 File Offset: 0x00229B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BfGw91JfVihUhywGp1oa()
		{
			return true;
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0022B998 File Offset: 0x00229B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UnIgnoreRequest ASSxuTJf04IxXFJXpvpd()
		{
			return null;
		}

		// Token: 0x040023E9 RID: 9193
		private static readonly MessageParser<UnIgnoreRequest> _parser;

		// Token: 0x040023EA RID: 9194
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023EB RID: 9195
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040023EC RID: 9196
		private long accountId_;

		// Token: 0x040023ED RID: 9197
		private static UnIgnoreRequest bkNGmOJfrdU2qjaAj83r;
	}
}
