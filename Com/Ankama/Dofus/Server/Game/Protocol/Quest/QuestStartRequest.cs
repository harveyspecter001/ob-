using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x0200019B RID: 411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStartRequest : IMessage<QuestStartRequest>, IMessage, IEquatable<QuestStartRequest>, IDeepCloneable<QuestStartRequest>, IBufferMessage
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x001A3F64 File Offset: 0x001A2164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x001A3F74 File Offset: 0x001A2174
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x001A3F84 File Offset: 0x001A2184
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

		// Token: 0x06001311 RID: 4881 RVA: 0x001A3F94 File Offset: 0x001A2194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartRequest()
		{
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x001A3FA4 File Offset: 0x001A21A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartRequest(QuestStartRequest other)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x001A3FB4 File Offset: 0x001A21B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartRequest Clone()
		{
			return null;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x001A3FC4 File Offset: 0x001A21C4
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x001A3FD4 File Offset: 0x001A21D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int QuestId
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

		// Token: 0x06001316 RID: 4886 RVA: 0x001A3FE4 File Offset: 0x001A21E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x001A3FF4 File Offset: 0x001A21F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStartRequest other)
		{
			return true;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x001A4004 File Offset: 0x001A2204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x001A4014 File Offset: 0x001A2214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x001A4024 File Offset: 0x001A2224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x001A4034 File Offset: 0x001A2234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x001A4044 File Offset: 0x001A2244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x001A4054 File Offset: 0x001A2254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStartRequest other)
		{
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x001A4064 File Offset: 0x001A2264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x001A4074 File Offset: 0x001A2274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x001A4084 File Offset: 0x001A2284
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStartRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					QuestStartRequest._parser = new MessageParser<QuestStartRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x001A417C File Offset: 0x001A237C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HeXBOQOo24ikY0ClRe7g()
		{
			return true;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x001A4184 File Offset: 0x001A2384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStartRequest vw2xCKOoEt1cw4iqqaju()
		{
			return null;
		}

		// Token: 0x040006DF RID: 1759
		private static readonly MessageParser<QuestStartRequest> _parser;

		// Token: 0x040006E0 RID: 1760
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006E1 RID: 1761
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040006E2 RID: 1762
		private int questId_;

		// Token: 0x040006E3 RID: 1763
		internal static QuestStartRequest FaIdB8Oo94EjEftGZG7M;
	}
}
