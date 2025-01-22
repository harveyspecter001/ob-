using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E3A RID: 3642
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReleaseAccountRequest : IMessage<ReleaseAccountRequest>, IMessage, IEquatable<ReleaseAccountRequest>, IDeepCloneable<ReleaseAccountRequest>, IBufferMessage
	{
		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x002A0C44 File Offset: 0x0029EE44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ReleaseAccountRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x002A0C54 File Offset: 0x0029EE54
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

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x002A0C64 File Offset: 0x0029EE64
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

		// Token: 0x0600AEFC RID: 44796 RVA: 0x002A0C74 File Offset: 0x0029EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReleaseAccountRequest()
		{
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x002A0C84 File Offset: 0x0029EE84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReleaseAccountRequest(ReleaseAccountRequest other)
		{
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x002A0C94 File Offset: 0x0029EE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReleaseAccountRequest Clone()
		{
			return null;
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x002A0CA4 File Offset: 0x0029EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AF00 RID: 44800 RVA: 0x002A0CB4 File Offset: 0x0029EEB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ReleaseAccountRequest other)
		{
			return true;
		}

		// Token: 0x0600AF01 RID: 44801 RVA: 0x002A0CC4 File Offset: 0x0029EEC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x002A0CD4 File Offset: 0x0029EED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x002A0CE4 File Offset: 0x0029EEE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x002A0CF4 File Offset: 0x0029EEF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x002A0D04 File Offset: 0x0029EF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x002A0D14 File Offset: 0x0029EF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ReleaseAccountRequest other)
		{
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x002A0D24 File Offset: 0x0029EF24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x002A0D34 File Offset: 0x0029EF34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x002A0D44 File Offset: 0x0029EF44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReleaseAccountRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
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
					ReleaseAccountRequest._parser = new MessageParser<ReleaseAccountRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x002A0E10 File Offset: 0x0029F010
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vp5AsQJvxKu8RRJOfVpN()
		{
			return true;
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x002A0E18 File Offset: 0x0029F018
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReleaseAccountRequest GvKbiwJv4VuAxcHDBWIR()
		{
			return null;
		}

		// Token: 0x0400406B RID: 16491
		private static readonly MessageParser<ReleaseAccountRequest> _parser;

		// Token: 0x0400406C RID: 16492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400406D RID: 16493
		private static ReleaseAccountRequest ATnbpLJvNglRLiEMutS4;
	}
}
