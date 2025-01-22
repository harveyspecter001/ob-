using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x0200032B RID: 811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcDialogReplyRequest : IMessage<NpcDialogReplyRequest>, IMessage, IEquatable<NpcDialogReplyRequest>, IDeepCloneable<NpcDialogReplyRequest>, IBufferMessage
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x001C2B98 File Offset: 0x001C0D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcDialogReplyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x001C2BA8 File Offset: 0x001C0DA8
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x001C2BB8 File Offset: 0x001C0DB8
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

		// Token: 0x0600261D RID: 9757 RVA: 0x001C2BC8 File Offset: 0x001C0DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogReplyRequest()
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x001C2BD8 File Offset: 0x001C0DD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogReplyRequest(NpcDialogReplyRequest other)
		{
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x001C2BE8 File Offset: 0x001C0DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogReplyRequest Clone()
		{
			return null;
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x001C2BF8 File Offset: 0x001C0DF8
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x001C2C08 File Offset: 0x001C0E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ReplyId
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

		// Token: 0x06002622 RID: 9762 RVA: 0x001C2C18 File Offset: 0x001C0E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x001C2C28 File Offset: 0x001C0E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcDialogReplyRequest other)
		{
			return true;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x001C2C38 File Offset: 0x001C0E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x001C2C48 File Offset: 0x001C0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x001C2C58 File Offset: 0x001C0E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x001C2C68 File Offset: 0x001C0E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x001C2C78 File Offset: 0x001C0E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x001C2C88 File Offset: 0x001C0E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcDialogReplyRequest other)
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x001C2C98 File Offset: 0x001C0E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x001C2CA8 File Offset: 0x001C0EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x001C2CB8 File Offset: 0x001C0EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcDialogReplyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				NpcDialogReplyRequest._parser = new MessageParser<NpcDialogReplyRequest>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x001C2D84 File Offset: 0x001C0F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rVg57qOW7HGisE60Z2Ni()
		{
			return true;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x001C2D8C File Offset: 0x001C0F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcDialogReplyRequest qbonB9OWTLwlYTRD24Dj()
		{
			return null;
		}

		// Token: 0x04000D8B RID: 3467
		private static readonly MessageParser<NpcDialogReplyRequest> _parser;

		// Token: 0x04000D8C RID: 3468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D8D RID: 3469
		public const int ReplyIdFieldNumber = 1;

		// Token: 0x04000D8E RID: 3470
		private int replyId_;

		// Token: 0x04000D8F RID: 3471
		internal static NpcDialogReplyRequest ML9qyQOWQoWPnoRbeHqh;
	}
}
