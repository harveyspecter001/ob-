using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000890 RID: 2192
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactInformation : IMessage<ContactInformation>, IMessage, IEquatable<ContactInformation>, IDeepCloneable<ContactInformation>, IBufferMessage
	{
		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x0022F674 File Offset: 0x0022D874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06006A78 RID: 27256 RVA: 0x0022F684 File Offset: 0x0022D884
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

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x0022F694 File Offset: 0x0022D894
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

		// Token: 0x06006A7A RID: 27258 RVA: 0x0022F6A4 File Offset: 0x0022D8A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactInformation()
		{
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0022F6B4 File Offset: 0x0022D8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactInformation(ContactInformation other)
		{
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x0022F6C4 File Offset: 0x0022D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactInformation Clone()
		{
			return null;
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x0022F6D4 File Offset: 0x0022D8D4
		// (set) Token: 0x06006A7E RID: 27262 RVA: 0x0022F6E4 File Offset: 0x0022D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x0022F6F4 File Offset: 0x0022D8F4
		// (set) Token: 0x06006A80 RID: 27264 RVA: 0x0022F704 File Offset: 0x0022D904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccountTag AccountTag
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

		// Token: 0x06006A81 RID: 27265 RVA: 0x0022F714 File Offset: 0x0022D914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x0022F724 File Offset: 0x0022D924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactInformation other)
		{
			return true;
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x0022F734 File Offset: 0x0022D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x0022F744 File Offset: 0x0022D944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x0022F754 File Offset: 0x0022D954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x0022F764 File Offset: 0x0022D964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x0022F774 File Offset: 0x0022D974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x0022F784 File Offset: 0x0022D984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactInformation other)
		{
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x0022F794 File Offset: 0x0022D994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0022F7A4 File Offset: 0x0022D9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0022F7B4 File Offset: 0x0022D9B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					ContactInformation._parser = new MessageParser<ContactInformation>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x0022F880 File Offset: 0x0022DA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EmrP8iJmmrIVhKhg03fy()
		{
			return true;
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x0022F888 File Offset: 0x0022DA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactInformation lnj0SGJmAQfqTtBUpban()
		{
			return null;
		}

		// Token: 0x04002545 RID: 9541
		private static readonly MessageParser<ContactInformation> _parser;

		// Token: 0x04002546 RID: 9542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002547 RID: 9543
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002548 RID: 9544
		private long accountId_;

		// Token: 0x04002549 RID: 9545
		public const int AccountTagFieldNumber = 2;

		// Token: 0x0400254A RID: 9546
		private AccountTag accountTag_;

		// Token: 0x0400254B RID: 9547
		internal static ContactInformation C55aG7JmnLfgliKQZQwB;
	}
}
