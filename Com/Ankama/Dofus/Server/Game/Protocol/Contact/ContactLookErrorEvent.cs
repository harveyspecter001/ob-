using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200084A RID: 2122
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactLookErrorEvent : IMessage<ContactLookErrorEvent>, IMessage, IEquatable<ContactLookErrorEvent>, IDeepCloneable<ContactLookErrorEvent>, IBufferMessage
	{
		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x0022CA08 File Offset: 0x0022AC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactLookErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x0022CA18 File Offset: 0x0022AC18
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

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x0022CA28 File Offset: 0x0022AC28
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

		// Token: 0x0600672B RID: 26411 RVA: 0x0022CA38 File Offset: 0x0022AC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookErrorEvent()
		{
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x0022CA48 File Offset: 0x0022AC48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookErrorEvent(ContactLookErrorEvent other)
		{
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x0022CA58 File Offset: 0x0022AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x0022CA68 File Offset: 0x0022AC68
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x0022CA78 File Offset: 0x0022AC78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RequestId
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

		// Token: 0x06006730 RID: 26416 RVA: 0x0022CA88 File Offset: 0x0022AC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x0022CA98 File Offset: 0x0022AC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactLookErrorEvent other)
		{
			return true;
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x0022CAA8 File Offset: 0x0022ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x0022CAB8 File Offset: 0x0022ACB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x0022CAC8 File Offset: 0x0022ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x0022CAD8 File Offset: 0x0022ACD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x0022CAE8 File Offset: 0x0022ACE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x0022CAF8 File Offset: 0x0022ACF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactLookErrorEvent other)
		{
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x0022CB08 File Offset: 0x0022AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x0022CB18 File Offset: 0x0022AD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x0022CB28 File Offset: 0x0022AD28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactLookErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					ContactLookErrorEvent._parser = new MessageParser<ContactLookErrorEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x0022CC0C File Offset: 0x0022AE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EFJlBcJnBJVcEmWNGW8n()
		{
			return true;
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x0022CC14 File Offset: 0x0022AE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactLookErrorEvent NY1FpgJnePKB58se3nnw()
		{
			return null;
		}

		// Token: 0x04002428 RID: 9256
		private static readonly MessageParser<ContactLookErrorEvent> _parser;

		// Token: 0x04002429 RID: 9257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400242A RID: 9258
		public const int RequestIdFieldNumber = 1;

		// Token: 0x0400242B RID: 9259
		private int requestId_;

		// Token: 0x0400242C RID: 9260
		internal static ContactLookErrorEvent xr7J7YJnA0t8nYFEKq9Q;
	}
}
