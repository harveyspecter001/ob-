using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000DFB RID: 3579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IBufferMessage
	{
		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x0029E398 File Offset: 0x0029C598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Response> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x0029E3A8 File Offset: 0x0029C5A8
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

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x0600AC47 RID: 44103 RVA: 0x0029E3B8 File Offset: 0x0029C5B8
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

		// Token: 0x0600AC48 RID: 44104 RVA: 0x0029E3C8 File Offset: 0x0029C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response()
		{
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x0029E3D8 File Offset: 0x0029C5D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response(Response other)
		{
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x0029E3E8 File Offset: 0x0029C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response Clone()
		{
			return null;
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600AC4B RID: 44107 RVA: 0x0029E3F8 File Offset: 0x0029C5F8
		// (set) Token: 0x0600AC4C RID: 44108 RVA: 0x0029E408 File Offset: 0x0029C608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uuid
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

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600AC4D RID: 44109 RVA: 0x0029E418 File Offset: 0x0029C618
		// (set) Token: 0x0600AC4E RID: 44110 RVA: 0x0029E428 File Offset: 0x0029C628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Pong Pong
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

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600AC4F RID: 44111 RVA: 0x0029E438 File Offset: 0x0029C638
		// (set) Token: 0x0600AC50 RID: 44112 RVA: 0x0029E448 File Offset: 0x0029C648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdentificationResponse Identification
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

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x0600AC51 RID: 44113 RVA: 0x0029E458 File Offset: 0x0029C658
		// (set) Token: 0x0600AC52 RID: 44114 RVA: 0x0029E468 File Offset: 0x0029C668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectServerResponse SelectServer
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

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x0029E478 File Offset: 0x0029C678
		// (set) Token: 0x0600AC54 RID: 44116 RVA: 0x0029E488 File Offset: 0x0029C688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ForceAccountResponse ForceAccount
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

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x0029E498 File Offset: 0x0029C698
		// (set) Token: 0x0600AC56 RID: 44118 RVA: 0x0029E4A8 File Offset: 0x0029C6A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendListResponse FriendList
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

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x0029E4B8 File Offset: 0x0029C6B8
		// (set) Token: 0x0600AC58 RID: 44120 RVA: 0x0029E4C8 File Offset: 0x0029C6C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AcquaintanceServersResponse AcquaintanceServersResponse
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

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x0029E4D8 File Offset: 0x0029C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Response.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Response.ContentOneofCase)null;
			}
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x0029E4EC File Offset: 0x0029C6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x0029E4FC File Offset: 0x0029C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x0029E50C File Offset: 0x0029C70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Response other)
		{
			return true;
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x0029E51C File Offset: 0x0029C71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x0029E52C File Offset: 0x0029C72C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x0029E53C File Offset: 0x0029C73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AC60 RID: 44128 RVA: 0x0029E54C File Offset: 0x0029C74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x0029E55C File Offset: 0x0029C75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x0029E56C File Offset: 0x0029C76C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Response other)
		{
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x0029E57C File Offset: 0x0029C77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x0029E58C File Offset: 0x0029C78C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x0029E59C File Offset: 0x0029C79C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Response()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Response._parser = new MessageParser<Response>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 0;
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
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x0029E668 File Offset: 0x0029C868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tLbwKEJUU0gaksN0OQuE()
		{
			return true;
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x0029E670 File Offset: 0x0029C870
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Response gdU5q4JUv0gyNlSX4vqf()
		{
			return null;
		}

		// Token: 0x04003F49 RID: 16201
		private static readonly MessageParser<Response> _parser;

		// Token: 0x04003F4A RID: 16202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F4B RID: 16203
		public const int UuidFieldNumber = 1;

		// Token: 0x04003F4C RID: 16204
		private string uuid_;

		// Token: 0x04003F4D RID: 16205
		public const int PongFieldNumber = 2;

		// Token: 0x04003F4E RID: 16206
		public const int IdentificationFieldNumber = 3;

		// Token: 0x04003F4F RID: 16207
		public const int SelectServerFieldNumber = 4;

		// Token: 0x04003F50 RID: 16208
		public const int ForceAccountFieldNumber = 5;

		// Token: 0x04003F51 RID: 16209
		public const int FriendListFieldNumber = 6;

		// Token: 0x04003F52 RID: 16210
		public const int AcquaintanceServersResponseFieldNumber = 7;

		// Token: 0x04003F53 RID: 16211
		private object content_;

		// Token: 0x04003F54 RID: 16212
		private Response.ContentOneofCase contentCase_;

		// Token: 0x04003F55 RID: 16213
		internal static Response CPqJleJUckXc9ygpvapF;

		// Token: 0x02000DFC RID: 3580
		public enum ContentOneofCase
		{
			// Token: 0x04003F57 RID: 16215
			None,
			// Token: 0x04003F58 RID: 16216
			Pong = 2,
			// Token: 0x04003F59 RID: 16217
			Identification,
			// Token: 0x04003F5A RID: 16218
			SelectServer,
			// Token: 0x04003F5B RID: 16219
			ForceAccount,
			// Token: 0x04003F5C RID: 16220
			FriendList,
			// Token: 0x04003F5D RID: 16221
			AcquaintanceServersResponse
		}
	}
}
