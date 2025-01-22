using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000844 RID: 2116
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactWarnOnPermanentDeathSetRequest : IMessage<ContactWarnOnPermanentDeathSetRequest>, IMessage, IEquatable<ContactWarnOnPermanentDeathSetRequest>, IDeepCloneable<ContactWarnOnPermanentDeathSetRequest>, IBufferMessage
	{
		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060066D4 RID: 26324 RVA: 0x0022C370 File Offset: 0x0022A570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactWarnOnPermanentDeathSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x0022C380 File Offset: 0x0022A580
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

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x0022C390 File Offset: 0x0022A590
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

		// Token: 0x060066D7 RID: 26327 RVA: 0x0022C3A0 File Offset: 0x0022A5A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnPermanentDeathSetRequest()
		{
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x0022C3B0 File Offset: 0x0022A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnPermanentDeathSetRequest(ContactWarnOnPermanentDeathSetRequest other)
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x0022C3C0 File Offset: 0x0022A5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnPermanentDeathSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x0022C3D0 File Offset: 0x0022A5D0
		// (set) Token: 0x060066DB RID: 26331 RVA: 0x0022C3E0 File Offset: 0x0022A5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060066DC RID: 26332 RVA: 0x0022C3F0 File Offset: 0x0022A5F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x0022C400 File Offset: 0x0022A600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactWarnOnPermanentDeathSetRequest other)
		{
			return true;
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x0022C410 File Offset: 0x0022A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x0022C420 File Offset: 0x0022A620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x0022C430 File Offset: 0x0022A630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x0022C440 File Offset: 0x0022A640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x0022C450 File Offset: 0x0022A650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x0022C460 File Offset: 0x0022A660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactWarnOnPermanentDeathSetRequest other)
		{
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x0022C470 File Offset: 0x0022A670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x0022C480 File Offset: 0x0022A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x0022C490 File Offset: 0x0022A690
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactWarnOnPermanentDeathSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					ContactWarnOnPermanentDeathSetRequest._parser = new MessageParser<ContactWarnOnPermanentDeathSetRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x0022C588 File Offset: 0x0022A788
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QxxdteJf8TGOXEeHkLGS()
		{
			return true;
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x0022C590 File Offset: 0x0022A790
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactWarnOnPermanentDeathSetRequest UsVfFUJfZ5e8yOwZwdW4()
		{
			return null;
		}

		// Token: 0x0400240D RID: 9229
		private static readonly MessageParser<ContactWarnOnPermanentDeathSetRequest> _parser;

		// Token: 0x0400240E RID: 9230
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400240F RID: 9231
		public const int EnableFieldNumber = 1;

		// Token: 0x04002410 RID: 9232
		private bool enable_;

		// Token: 0x04002411 RID: 9233
		private static ContactWarnOnPermanentDeathSetRequest mQuMGRJfuSJipkT1hqRm;
	}
}
