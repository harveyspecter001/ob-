using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001D7 RID: 471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismAttackedEvent : IMessage<PrismAttackedEvent>, IMessage, IEquatable<PrismAttackedEvent>, IDeepCloneable<PrismAttackedEvent>, IBufferMessage
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x001A7B88 File Offset: 0x001A5D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismAttackedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x001A7B98 File Offset: 0x001A5D98
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x001A7BA8 File Offset: 0x001A5DA8
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

		// Token: 0x06001602 RID: 5634 RVA: 0x001A7BB8 File Offset: 0x001A5DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackedEvent()
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x001A7BC8 File Offset: 0x001A5DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackedEvent(PrismAttackedEvent other)
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x001A7BD8 File Offset: 0x001A5DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackedEvent Clone()
		{
			return null;
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x001A7BE8 File Offset: 0x001A5DE8
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x001A7BF8 File Offset: 0x001A5DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrismLocalizedInformation PrismLocalizedInformation
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

		// Token: 0x06001607 RID: 5639 RVA: 0x001A7C08 File Offset: 0x001A5E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x001A7C18 File Offset: 0x001A5E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismAttackedEvent other)
		{
			return true;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x001A7C28 File Offset: 0x001A5E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x001A7C38 File Offset: 0x001A5E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x001A7C48 File Offset: 0x001A5E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x001A7C58 File Offset: 0x001A5E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x001A7C68 File Offset: 0x001A5E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x001A7C78 File Offset: 0x001A5E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismAttackedEvent other)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x001A7C88 File Offset: 0x001A5E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x001A7C98 File Offset: 0x001A5E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x001A7CA8 File Offset: 0x001A5EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismAttackedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				PrismAttackedEvent._parser = new MessageParser<PrismAttackedEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x001A7D8C File Offset: 0x001A5F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hnlBaAO1aZfftQGFOgoP()
		{
			return true;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x001A7D94 File Offset: 0x001A5F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismAttackedEvent NxLiJNO15FRK7YDrRb6f()
		{
			return null;
		}

		// Token: 0x040007C7 RID: 1991
		private static readonly MessageParser<PrismAttackedEvent> _parser;

		// Token: 0x040007C8 RID: 1992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007C9 RID: 1993
		public const int PrismLocalizedInformationFieldNumber = 1;

		// Token: 0x040007CA RID: 1994
		private PrismLocalizedInformation prismLocalizedInformation_;

		// Token: 0x040007CB RID: 1995
		private static PrismAttackedEvent H37HHNO11C06G41YbeS9;
	}
}
