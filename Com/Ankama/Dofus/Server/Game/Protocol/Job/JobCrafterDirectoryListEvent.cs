using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003B6 RID: 950
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryListEvent : IMessage<JobCrafterDirectoryListEvent>, IMessage, IEquatable<JobCrafterDirectoryListEvent>, IDeepCloneable<JobCrafterDirectoryListEvent>, IBufferMessage
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x001CD728 File Offset: 0x001CB928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobCrafterDirectoryListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x001CD738 File Offset: 0x001CB938
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

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x001CD748 File Offset: 0x001CB948
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

		// Token: 0x06002C94 RID: 11412 RVA: 0x001CD758 File Offset: 0x001CB958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListEvent()
		{
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x001CD768 File Offset: 0x001CB968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListEvent(JobCrafterDirectoryListEvent other)
		{
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x001CD778 File Offset: 0x001CB978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListEvent Clone()
		{
			return null;
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x001CD788 File Offset: 0x001CB988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<JobCrafterDirectoryEntry> ListEntries
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x001CD798 File Offset: 0x001CB998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x001CD7A8 File Offset: 0x001CB9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryListEvent other)
		{
			return true;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x001CD7B8 File Offset: 0x001CB9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x001CD7C8 File Offset: 0x001CB9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x001CD7D8 File Offset: 0x001CB9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x001CD7E8 File Offset: 0x001CB9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x001CD7F8 File Offset: 0x001CB9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x001CD808 File Offset: 0x001CBA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryListEvent other)
		{
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x001CD818 File Offset: 0x001CBA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x001CD828 File Offset: 0x001CBA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x001CD838 File Offset: 0x001CBA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryListEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					JobCrafterDirectoryListEvent._repeated_listEntries_codec = FieldCodec.ForMessage<JobCrafterDirectoryEntry>(10U, BGY7F6n75rrcbyGa7ROG.XVInXhlssT(BGY7F6n75rrcbyGa7ROG.bSIn7yw7PTB));
					num2 = 5;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				JobCrafterDirectoryListEvent._parser = new MessageParser<JobCrafterDirectoryListEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x001CD928 File Offset: 0x001CBB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bRF1dEOVhEYln5nVcluF()
		{
			return true;
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x001CD930 File Offset: 0x001CBB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryListEvent vAxMn1OVrXXSclmvSOnq()
		{
			return null;
		}

		// Token: 0x04000FAC RID: 4012
		private static readonly MessageParser<JobCrafterDirectoryListEvent> _parser;

		// Token: 0x04000FAD RID: 4013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FAE RID: 4014
		public const int ListEntriesFieldNumber = 1;

		// Token: 0x04000FAF RID: 4015
		private static readonly FieldCodec<JobCrafterDirectoryEntry> _repeated_listEntries_codec;

		// Token: 0x04000FB0 RID: 4016
		private readonly RepeatedField<JobCrafterDirectoryEntry> listEntries_;

		// Token: 0x04000FB1 RID: 4017
		private static JobCrafterDirectoryListEvent gI0jreOVWe0AePQNcJuQ;
	}
}
