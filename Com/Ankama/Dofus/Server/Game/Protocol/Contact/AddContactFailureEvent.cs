using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200087E RID: 2174
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddContactFailureEvent : IMessage<AddContactFailureEvent>, IMessage, IEquatable<AddContactFailureEvent>, IDeepCloneable<AddContactFailureEvent>, IBufferMessage
	{
		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x0022E884 File Offset: 0x0022CA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AddContactFailureEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x0022E894 File Offset: 0x0022CA94
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x0022E8A4 File Offset: 0x0022CAA4
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

		// Token: 0x06006978 RID: 27000 RVA: 0x0022E8B4 File Offset: 0x0022CAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddContactFailureEvent()
		{
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x0022E8C4 File Offset: 0x0022CAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddContactFailureEvent(AddContactFailureEvent other)
		{
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x0022E8D4 File Offset: 0x0022CAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddContactFailureEvent Clone()
		{
			return null;
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600697B RID: 27003 RVA: 0x0022E8E4 File Offset: 0x0022CAE4
		// (set) Token: 0x0600697C RID: 27004 RVA: 0x0022E8F8 File Offset: 0x0022CAF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AddFailureReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AddFailureReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x0022E908 File Offset: 0x0022CB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0022E918 File Offset: 0x0022CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AddContactFailureEvent other)
		{
			return true;
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x0022E928 File Offset: 0x0022CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x0022E938 File Offset: 0x0022CB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x0022E948 File Offset: 0x0022CB48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0022E958 File Offset: 0x0022CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x0022E968 File Offset: 0x0022CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0022E978 File Offset: 0x0022CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AddContactFailureEvent other)
		{
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x0022E988 File Offset: 0x0022CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x0022E998 File Offset: 0x0022CB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x0022E9A8 File Offset: 0x0022CBA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddContactFailureEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AddContactFailureEvent._parser = new MessageParser<AddContactFailureEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x0022EA8C File Offset: 0x0022CC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JfkIuFJn7q7r8TJQKK9i()
		{
			return true;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x0022EA94 File Offset: 0x0022CC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AddContactFailureEvent gwcYZZJnT7j3abml2hal()
		{
			return null;
		}

		// Token: 0x040024D9 RID: 9433
		private static readonly MessageParser<AddContactFailureEvent> _parser;

		// Token: 0x040024DA RID: 9434
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024DB RID: 9435
		public const int ReasonFieldNumber = 1;

		// Token: 0x040024DC RID: 9436
		private AddFailureReason reason_;

		// Token: 0x040024DD RID: 9437
		private static AddContactFailureEvent LTi12GJnQgP54CcayLTK;
	}
}
