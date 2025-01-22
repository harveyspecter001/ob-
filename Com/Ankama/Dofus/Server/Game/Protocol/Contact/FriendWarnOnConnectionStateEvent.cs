using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000854 RID: 2132
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendWarnOnConnectionStateEvent : IMessage<FriendWarnOnConnectionStateEvent>, IMessage, IEquatable<FriendWarnOnConnectionStateEvent>, IDeepCloneable<FriendWarnOnConnectionStateEvent>, IBufferMessage
	{
		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x0022D4A0 File Offset: 0x0022B6A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendWarnOnConnectionStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060067AD RID: 26541 RVA: 0x0022D4B0 File Offset: 0x0022B6B0
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

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x0022D4C0 File Offset: 0x0022B6C0
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

		// Token: 0x060067AF RID: 26543 RVA: 0x0022D4D0 File Offset: 0x0022B6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnConnectionStateEvent()
		{
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x0022D4E0 File Offset: 0x0022B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnConnectionStateEvent(FriendWarnOnConnectionStateEvent other)
		{
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x0022D4F0 File Offset: 0x0022B6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendWarnOnConnectionStateEvent Clone()
		{
			return null;
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x0022D500 File Offset: 0x0022B700
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x0022D510 File Offset: 0x0022B710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
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

		// Token: 0x060067B4 RID: 26548 RVA: 0x0022D520 File Offset: 0x0022B720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x0022D530 File Offset: 0x0022B730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendWarnOnConnectionStateEvent other)
		{
			return true;
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x0022D540 File Offset: 0x0022B740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x0022D550 File Offset: 0x0022B750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x0022D560 File Offset: 0x0022B760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x0022D570 File Offset: 0x0022B770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x0022D580 File Offset: 0x0022B780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x0022D590 File Offset: 0x0022B790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendWarnOnConnectionStateEvent other)
		{
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x0022D5A0 File Offset: 0x0022B7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x0022D5B0 File Offset: 0x0022B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x0022D5C0 File Offset: 0x0022B7C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendWarnOnConnectionStateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				FriendWarnOnConnectionStateEvent._parser = new MessageParser<FriendWarnOnConnectionStateEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x0022D6A4 File Offset: 0x0022B8A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E8uFy4Jnxr48Ky9I8O50()
		{
			return true;
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x0022D6AC File Offset: 0x0022B8AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendWarnOnConnectionStateEvent EVL786Jn43o4qpBhkapn()
		{
			return null;
		}

		// Token: 0x0400244D RID: 9293
		private static readonly MessageParser<FriendWarnOnConnectionStateEvent> _parser;

		// Token: 0x0400244E RID: 9294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400244F RID: 9295
		public const int EnableFieldNumber = 1;

		// Token: 0x04002450 RID: 9296
		private bool enable_;

		// Token: 0x04002451 RID: 9297
		private static FriendWarnOnConnectionStateEvent QGiSvYJnNNxGEEMHgEXF;
	}
}
