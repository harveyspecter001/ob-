using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000827 RID: 2087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactLookRequest : IMessage<ContactLookRequest>, IMessage, IEquatable<ContactLookRequest>, IDeepCloneable<ContactLookRequest>, IBufferMessage
	{
		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x0022A880 File Offset: 0x00228A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactLookRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600657C RID: 25980 RVA: 0x0022A890 File Offset: 0x00228A90
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

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x0022A8A0 File Offset: 0x00228AA0
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

		// Token: 0x0600657E RID: 25982 RVA: 0x0022A8B0 File Offset: 0x00228AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookRequest()
		{
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x0022A8C0 File Offset: 0x00228AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookRequest(ContactLookRequest other)
		{
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x0022A8D0 File Offset: 0x00228AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookRequest Clone()
		{
			return null;
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x0022A8E0 File Offset: 0x00228AE0
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x0022A8F0 File Offset: 0x00228AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06006583 RID: 25987 RVA: 0x0022A900 File Offset: 0x00228B00
		// (set) Token: 0x06006584 RID: 25988 RVA: 0x0022A914 File Offset: 0x00228B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContactLookRequest.Types.SocialContactCategory ContactType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ContactLookRequest.Types.SocialContactCategory)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x0022A924 File Offset: 0x00228B24
		// (set) Token: 0x06006586 RID: 25990 RVA: 0x0022A934 File Offset: 0x00228B34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x0022A944 File Offset: 0x00228B44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0022A954 File Offset: 0x00228B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearName()
		{
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x0022A964 File Offset: 0x00228B64
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x0022A974 File Offset: 0x00228B74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Id
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

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x0022A984 File Offset: 0x00228B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x0022A994 File Offset: 0x00228B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearId()
		{
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600658D RID: 25997 RVA: 0x0022A9A4 File Offset: 0x00228BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContactLookRequest.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ContactLookRequest.ComplementOneofCase)null;
			}
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0022A9B8 File Offset: 0x00228BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x0022A9C8 File Offset: 0x00228BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x0022A9D8 File Offset: 0x00228BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactLookRequest other)
		{
			return true;
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x0022A9E8 File Offset: 0x00228BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x0022A9F8 File Offset: 0x00228BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x0022AA08 File Offset: 0x00228C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x0022AA18 File Offset: 0x00228C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x0022AA28 File Offset: 0x00228C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0022AA38 File Offset: 0x00228C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactLookRequest other)
		{
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x0022AA48 File Offset: 0x00228C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x0022AA58 File Offset: 0x00228C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x0022AA68 File Offset: 0x00228C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactLookRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
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
					ContactLookRequest._parser = new MessageParser<ContactLookRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
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

		// Token: 0x0600659A RID: 26010 RVA: 0x0022AB34 File Offset: 0x00228D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kbTrQQJfNbccjwqiIxvm()
		{
			return true;
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x0022AB3C File Offset: 0x00228D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactLookRequest h297twJfxESqXujgI3jL()
		{
			return null;
		}

		// Token: 0x040023A5 RID: 9125
		private static readonly MessageParser<ContactLookRequest> _parser;

		// Token: 0x040023A6 RID: 9126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A7 RID: 9127
		public const int RequestIdFieldNumber = 1;

		// Token: 0x040023A8 RID: 9128
		private int requestId_;

		// Token: 0x040023A9 RID: 9129
		public const int ContactTypeFieldNumber = 2;

		// Token: 0x040023AA RID: 9130
		private ContactLookRequest.Types.SocialContactCategory contactType_;

		// Token: 0x040023AB RID: 9131
		public const int NameFieldNumber = 3;

		// Token: 0x040023AC RID: 9132
		public const int IdFieldNumber = 4;

		// Token: 0x040023AD RID: 9133
		private object complement_;

		// Token: 0x040023AE RID: 9134
		private ContactLookRequest.ComplementOneofCase complementCase_;

		// Token: 0x040023AF RID: 9135
		private static ContactLookRequest TmGZ14JfX3NuJTKWNU1E;

		// Token: 0x02000828 RID: 2088
		public enum ComplementOneofCase
		{
			// Token: 0x040023B1 RID: 9137
			None,
			// Token: 0x040023B2 RID: 9138
			Name = 3,
			// Token: 0x040023B3 RID: 9139
			Id
		}

		// Token: 0x02000829 RID: 2089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600659C RID: 26012 RVA: 0x002D55E0 File Offset: 0x002D37E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200082A RID: 2090
			public enum SocialContactCategory
			{
				// Token: 0x040023B5 RID: 9141
				[OriginalName("FRIEND")]
				Friend,
				// Token: 0x040023B6 RID: 9142
				[OriginalName("SPOUSE")]
				Spouse,
				// Token: 0x040023B7 RID: 9143
				[OriginalName("PARTY")]
				Party,
				// Token: 0x040023B8 RID: 9144
				[OriginalName("GUILD")]
				Guild,
				// Token: 0x040023B9 RID: 9145
				[OriginalName("ALLIANCE")]
				Alliance,
				// Token: 0x040023BA RID: 9146
				[OriginalName("CRAFTER")]
				Crafter,
				// Token: 0x040023BB RID: 9147
				[OriginalName("INTERLOCUTOR")]
				Interlocutor,
				// Token: 0x040023BC RID: 9148
				[OriginalName("FIGHT")]
				Fight
			}
		}
	}
}
