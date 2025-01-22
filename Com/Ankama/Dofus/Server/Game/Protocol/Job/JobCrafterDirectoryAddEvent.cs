using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003C1 RID: 961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryAddEvent : IMessage<JobCrafterDirectoryAddEvent>, IMessage, IEquatable<JobCrafterDirectoryAddEvent>, IDeepCloneable<JobCrafterDirectoryAddEvent>, IBufferMessage
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x001CDFA4 File Offset: 0x001CC1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobCrafterDirectoryAddEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x001CDFB4 File Offset: 0x001CC1B4
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x001CDFC4 File Offset: 0x001CC1C4
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

		// Token: 0x06002D18 RID: 11544 RVA: 0x001CDFD4 File Offset: 0x001CC1D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryAddEvent()
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x001CDFE4 File Offset: 0x001CC1E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryAddEvent(JobCrafterDirectoryAddEvent other)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x001CDFF4 File Offset: 0x001CC1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryAddEvent Clone()
		{
			return null;
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x001CE004 File Offset: 0x001CC204
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x001CE014 File Offset: 0x001CC214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JobCrafterDirectoryEntry Entry
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x001CE024 File Offset: 0x001CC224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x001CE034 File Offset: 0x001CC234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryAddEvent other)
		{
			return true;
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x001CE044 File Offset: 0x001CC244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x001CE054 File Offset: 0x001CC254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x001CE064 File Offset: 0x001CC264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x001CE074 File Offset: 0x001CC274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x001CE084 File Offset: 0x001CC284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x001CE094 File Offset: 0x001CC294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryAddEvent other)
		{
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x001CE0A4 File Offset: 0x001CC2A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x001CE0B4 File Offset: 0x001CC2B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x001CE0C4 File Offset: 0x001CC2C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryAddEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					JobCrafterDirectoryAddEvent._parser = new MessageParser<JobCrafterDirectoryAddEvent>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x001CE1A8 File Offset: 0x001CC3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UNPcfpOVHApaPK8t4rHO()
		{
			return true;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x001CE1B0 File Offset: 0x001CC3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryAddEvent b6YmAQOVYvCe1XCmpQbg()
		{
			return null;
		}

		// Token: 0x04000FD6 RID: 4054
		private static readonly MessageParser<JobCrafterDirectoryAddEvent> _parser;

		// Token: 0x04000FD7 RID: 4055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FD8 RID: 4056
		public const int EntryFieldNumber = 1;

		// Token: 0x04000FD9 RID: 4057
		private JobCrafterDirectoryEntry entry_;

		// Token: 0x04000FDA RID: 4058
		private static JobCrafterDirectoryAddEvent GgB4uDOVpniMBHYurI9v;
	}
}
