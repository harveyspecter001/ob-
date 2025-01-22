using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000880 RID: 2176
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendListEvent : IMessage<FriendListEvent>, IMessage, IEquatable<FriendListEvent>, IDeepCloneable<FriendListEvent>, IBufferMessage
	{
		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x0022EA9C File Offset: 0x0022CC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x0022EAAC File Offset: 0x0022CCAC
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

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x0022EABC File Offset: 0x0022CCBC
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

		// Token: 0x06006992 RID: 27026 RVA: 0x0022EACC File Offset: 0x0022CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListEvent()
		{
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x0022EADC File Offset: 0x0022CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListEvent(FriendListEvent other)
		{
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x0022EAEC File Offset: 0x0022CCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListEvent Clone()
		{
			return null;
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06006995 RID: 27029 RVA: 0x0022EAFC File Offset: 0x0022CCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FriendInformation> Friend
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x0022EB0C File Offset: 0x0022CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x0022EB1C File Offset: 0x0022CD1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendListEvent other)
		{
			return true;
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x0022EB2C File Offset: 0x0022CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x0022EB3C File Offset: 0x0022CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x0022EB4C File Offset: 0x0022CD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x0022EB5C File Offset: 0x0022CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x0022EB6C File Offset: 0x0022CD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x0022EB7C File Offset: 0x0022CD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendListEvent other)
		{
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x0022EB8C File Offset: 0x0022CD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x0022EB9C File Offset: 0x0022CD9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x0022EBAC File Offset: 0x0022CDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					FriendListEvent._repeated_friend_codec = FieldCodec.ForMessage<FriendInformation>(10U, cMT6UaAT7JRne3Vb4hsw.XVInXhlssT(cMT6UaAT7JRne3Vb4hsw.h8aATTZBmvd));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				FriendListEvent._parser = new MessageParser<FriendListEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x0022ECB4 File Offset: 0x0022CEB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool il8ol6JnH2Y2uZ4xK7LV()
		{
			return true;
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x0022ECBC File Offset: 0x0022CEBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendListEvent IqFhAgJnYFHmfdLly9m2()
		{
			return null;
		}

		// Token: 0x040024E0 RID: 9440
		private static readonly MessageParser<FriendListEvent> _parser;

		// Token: 0x040024E1 RID: 9441
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024E2 RID: 9442
		public const int FriendFieldNumber = 1;

		// Token: 0x040024E3 RID: 9443
		private static readonly FieldCodec<FriendInformation> _repeated_friend_codec;

		// Token: 0x040024E4 RID: 9444
		private readonly RepeatedField<FriendInformation> friend_;

		// Token: 0x040024E5 RID: 9445
		internal static FriendListEvent D87fCuJnpiauGB0Cjnex;
	}
}
