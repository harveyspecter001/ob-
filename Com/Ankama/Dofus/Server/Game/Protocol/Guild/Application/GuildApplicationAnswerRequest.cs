using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200055E RID: 1374
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationAnswerRequest : IMessage<GuildApplicationAnswerRequest>, IMessage, IEquatable<GuildApplicationAnswerRequest>, IDeepCloneable<GuildApplicationAnswerRequest>, IBufferMessage
	{
		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x001F17B0 File Offset: 0x001EF9B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x001F17C0 File Offset: 0x001EF9C0
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x001F17D0 File Offset: 0x001EF9D0
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

		// Token: 0x06004219 RID: 16921 RVA: 0x001F17E0 File Offset: 0x001EF9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerRequest()
		{
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x001F17F0 File Offset: 0x001EF9F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerRequest(GuildApplicationAnswerRequest other)
		{
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x001F1800 File Offset: 0x001EFA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x001F1810 File Offset: 0x001EFA10
		// (set) Token: 0x0600421D RID: 16925 RVA: 0x001F1820 File Offset: 0x001EFA20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accepted
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

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x001F1830 File Offset: 0x001EFA30
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x001F1840 File Offset: 0x001EFA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06004220 RID: 16928 RVA: 0x001F1850 File Offset: 0x001EFA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x001F1860 File Offset: 0x001EFA60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x001F1870 File Offset: 0x001EFA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x001F1880 File Offset: 0x001EFA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x001F1890 File Offset: 0x001EFA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x001F18A0 File Offset: 0x001EFAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x001F18B0 File Offset: 0x001EFAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x001F18C0 File Offset: 0x001EFAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationAnswerRequest other)
		{
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x001F18D0 File Offset: 0x001EFAD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x001F18E0 File Offset: 0x001EFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x001F18F0 File Offset: 0x001EFAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationAnswerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					GuildApplicationAnswerRequest._parser = new MessageParser<GuildApplicationAnswerRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x001F19D4 File Offset: 0x001EFBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ybgHDHOH4o9JBoMNnvE1()
		{
			return true;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x001F19DC File Offset: 0x001EFBDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationAnswerRequest MJ5rAOOHjsr6Cc20IiAt()
		{
			return null;
		}

		// Token: 0x040016D0 RID: 5840
		private static readonly MessageParser<GuildApplicationAnswerRequest> _parser;

		// Token: 0x040016D1 RID: 5841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016D2 RID: 5842
		public const int AcceptedFieldNumber = 1;

		// Token: 0x040016D3 RID: 5843
		private bool accepted_;

		// Token: 0x040016D4 RID: 5844
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040016D5 RID: 5845
		private long playerId_;

		// Token: 0x040016D6 RID: 5846
		internal static GuildApplicationAnswerRequest XCfYjkOHx6KCumttoXxy;
	}
}
