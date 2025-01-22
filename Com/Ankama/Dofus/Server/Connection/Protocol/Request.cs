using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000DF8 RID: 3576
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IBufferMessage
	{
		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x0600AC1B RID: 44059 RVA: 0x0029E080 File Offset: 0x0029C280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Request> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x0029E090 File Offset: 0x0029C290
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

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x0029E0A0 File Offset: 0x0029C2A0
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

		// Token: 0x0600AC1E RID: 44062 RVA: 0x0029E0B0 File Offset: 0x0029C2B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request()
		{
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x0029E0C0 File Offset: 0x0029C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request(Request other)
		{
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x0029E0D0 File Offset: 0x0029C2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request Clone()
		{
			return null;
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x0600AC21 RID: 44065 RVA: 0x0029E0E0 File Offset: 0x0029C2E0
		// (set) Token: 0x0600AC22 RID: 44066 RVA: 0x0029E0F0 File Offset: 0x0029C2F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600AC23 RID: 44067 RVA: 0x0029E100 File Offset: 0x0029C300
		// (set) Token: 0x0600AC24 RID: 44068 RVA: 0x0029E110 File Offset: 0x0029C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Ping Ping
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

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x0600AC25 RID: 44069 RVA: 0x0029E120 File Offset: 0x0029C320
		// (set) Token: 0x0600AC26 RID: 44070 RVA: 0x0029E130 File Offset: 0x0029C330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdentificationRequest Identification
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

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600AC27 RID: 44071 RVA: 0x0029E140 File Offset: 0x0029C340
		// (set) Token: 0x0600AC28 RID: 44072 RVA: 0x0029E150 File Offset: 0x0029C350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectServerRequest SelectServer
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

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x0600AC29 RID: 44073 RVA: 0x0029E160 File Offset: 0x0029C360
		// (set) Token: 0x0600AC2A RID: 44074 RVA: 0x0029E170 File Offset: 0x0029C370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceAccountRequest ForceAccount
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

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x0600AC2B RID: 44075 RVA: 0x0029E180 File Offset: 0x0029C380
		// (set) Token: 0x0600AC2C RID: 44076 RVA: 0x0029E190 File Offset: 0x0029C390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ReleaseAccountRequest ReleaseAccount
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

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x0029E1A0 File Offset: 0x0029C3A0
		// (set) Token: 0x0600AC2E RID: 44078 RVA: 0x0029E1B0 File Offset: 0x0029C3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendListRequest FriendListRequest
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

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x0600AC2F RID: 44079 RVA: 0x0029E1C0 File Offset: 0x0029C3C0
		// (set) Token: 0x0600AC30 RID: 44080 RVA: 0x0029E1D0 File Offset: 0x0029C3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcquaintanceServersRequest AcquaintanceServersRequest
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

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600AC31 RID: 44081 RVA: 0x0029E1E0 File Offset: 0x0029C3E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Request.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Request.ContentOneofCase)null;
			}
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x0029E1F4 File Offset: 0x0029C3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x0029E204 File Offset: 0x0029C404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0029E214 File Offset: 0x0029C414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Request other)
		{
			return true;
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x0029E224 File Offset: 0x0029C424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x0029E234 File Offset: 0x0029C434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x0029E244 File Offset: 0x0029C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x0029E254 File Offset: 0x0029C454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x0029E264 File Offset: 0x0029C464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x0029E274 File Offset: 0x0029C474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Request other)
		{
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x0029E284 File Offset: 0x0029C484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x0029E294 File Offset: 0x0029C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x0029E2A4 File Offset: 0x0029C4A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Request()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					Request._parser = new MessageParser<Request>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x0029E388 File Offset: 0x0029C588
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AcpVuPJUkXj2tMZeBeZA()
		{
			return true;
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x0029E390 File Offset: 0x0029C590
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Request vZto9OJUlVVxBD5k689S()
		{
			return null;
		}

		// Token: 0x04003F30 RID: 16176
		private static readonly MessageParser<Request> _parser;

		// Token: 0x04003F31 RID: 16177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F32 RID: 16178
		public const int UuidFieldNumber = 1;

		// Token: 0x04003F33 RID: 16179
		private string uuid_;

		// Token: 0x04003F34 RID: 16180
		public const int PingFieldNumber = 2;

		// Token: 0x04003F35 RID: 16181
		public const int IdentificationFieldNumber = 3;

		// Token: 0x04003F36 RID: 16182
		public const int SelectServerFieldNumber = 4;

		// Token: 0x04003F37 RID: 16183
		public const int ForceAccountFieldNumber = 5;

		// Token: 0x04003F38 RID: 16184
		public const int ReleaseAccountFieldNumber = 6;

		// Token: 0x04003F39 RID: 16185
		public const int FriendListRequestFieldNumber = 7;

		// Token: 0x04003F3A RID: 16186
		public const int AcquaintanceServersRequestFieldNumber = 8;

		// Token: 0x04003F3B RID: 16187
		private object content_;

		// Token: 0x04003F3C RID: 16188
		private Request.ContentOneofCase contentCase_;

		// Token: 0x04003F3D RID: 16189
		private static Request rOnaagJUIXWTlDjk9yXy;

		// Token: 0x02000DF9 RID: 3577
		public enum ContentOneofCase
		{
			// Token: 0x04003F3F RID: 16191
			None,
			// Token: 0x04003F40 RID: 16192
			Ping = 2,
			// Token: 0x04003F41 RID: 16193
			Identification,
			// Token: 0x04003F42 RID: 16194
			SelectServer,
			// Token: 0x04003F43 RID: 16195
			ForceAccount,
			// Token: 0x04003F44 RID: 16196
			ReleaseAccount,
			// Token: 0x04003F45 RID: 16197
			FriendListRequest,
			// Token: 0x04003F46 RID: 16198
			AcquaintanceServersRequest
		}
	}
}
