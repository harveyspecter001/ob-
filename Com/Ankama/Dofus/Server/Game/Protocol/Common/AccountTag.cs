using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009C3 RID: 2499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccountTag : IMessage<AccountTag>, IMessage, IEquatable<AccountTag>, IDeepCloneable<AccountTag>, IBufferMessage
	{
		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x0025B8AC File Offset: 0x00259AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccountTag> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x0025B8BC File Offset: 0x00259ABC
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

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x0600773B RID: 30523 RVA: 0x0025B8CC File Offset: 0x00259ACC
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

		// Token: 0x0600773C RID: 30524 RVA: 0x0025B8DC File Offset: 0x00259ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountTag()
		{
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x0025B8EC File Offset: 0x00259AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountTag(AccountTag other)
		{
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x0025B8FC File Offset: 0x00259AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountTag Clone()
		{
			return null;
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x0600773F RID: 30527 RVA: 0x0025B90C File Offset: 0x00259B0C
		// (set) Token: 0x06007740 RID: 30528 RVA: 0x0025B91C File Offset: 0x00259B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Nickname
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

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x0025B92C File Offset: 0x00259B2C
		// (set) Token: 0x06007742 RID: 30530 RVA: 0x0025B93C File Offset: 0x00259B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Tag
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

		// Token: 0x06007743 RID: 30531 RVA: 0x0025B94C File Offset: 0x00259B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x0025B95C File Offset: 0x00259B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccountTag other)
		{
			return true;
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x0025B96C File Offset: 0x00259B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x0025B97C File Offset: 0x00259B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x0025B98C File Offset: 0x00259B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x0025B99C File Offset: 0x00259B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x0025B9AC File Offset: 0x00259BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x0025B9BC File Offset: 0x00259BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccountTag other)
		{
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0025B9CC File Offset: 0x00259BCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x0025B9DC File Offset: 0x00259BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x0025B9EC File Offset: 0x00259BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountTag()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
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
					AccountTag._parser = new MessageParser<AccountTag>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x0025BAD0 File Offset: 0x00259CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xhUTRoJJFaDNin1QvjOO()
		{
			return true;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x0025BAD8 File Offset: 0x00259CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccountTag pHYLTsJJzHejJBZXC5Ge()
		{
			return null;
		}

		// Token: 0x04002A84 RID: 10884
		private static readonly MessageParser<AccountTag> _parser;

		// Token: 0x04002A85 RID: 10885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A86 RID: 10886
		public const int NicknameFieldNumber = 1;

		// Token: 0x04002A87 RID: 10887
		private string nickname_;

		// Token: 0x04002A88 RID: 10888
		public const int TagFieldNumber = 2;

		// Token: 0x04002A89 RID: 10889
		private string tag_;

		// Token: 0x04002A8A RID: 10890
		internal static AccountTag XZdB6UJJqcCNcfUx1geo;
	}
}
