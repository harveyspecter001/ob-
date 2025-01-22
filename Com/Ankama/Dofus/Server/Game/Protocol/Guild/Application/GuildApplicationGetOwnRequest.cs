using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200055A RID: 1370
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationGetOwnRequest : IMessage<GuildApplicationGetOwnRequest>, IMessage, IEquatable<GuildApplicationGetOwnRequest>, IDeepCloneable<GuildApplicationGetOwnRequest>, IBufferMessage
	{
		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x001F13B8 File Offset: 0x001EF5B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationGetOwnRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x001F13C8 File Offset: 0x001EF5C8
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x001F13D8 File Offset: 0x001EF5D8
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

		// Token: 0x060041E5 RID: 16869 RVA: 0x001F13E8 File Offset: 0x001EF5E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationGetOwnRequest()
		{
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x001F13F8 File Offset: 0x001EF5F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationGetOwnRequest(GuildApplicationGetOwnRequest other)
		{
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001F1408 File Offset: 0x001EF608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationGetOwnRequest Clone()
		{
			return null;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x001F1418 File Offset: 0x001EF618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x001F1428 File Offset: 0x001EF628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationGetOwnRequest other)
		{
			return true;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x001F1438 File Offset: 0x001EF638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001F1448 File Offset: 0x001EF648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x001F1458 File Offset: 0x001EF658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x001F1468 File Offset: 0x001EF668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001F1478 File Offset: 0x001EF678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x001F1488 File Offset: 0x001EF688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationGetOwnRequest other)
		{
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x001F1498 File Offset: 0x001EF698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x001F14A8 File Offset: 0x001EF6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x001F14B8 File Offset: 0x001EF6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationGetOwnRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					GuildApplicationGetOwnRequest._parser = new MessageParser<GuildApplicationGetOwnRequest>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x001F1584 File Offset: 0x001EF784
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool seIttDOH9F4YMY2ciihA()
		{
			return true;
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x001F158C File Offset: 0x001EF78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationGetOwnRequest biBCpxOH2Xi8mGfk9ZVb()
		{
			return null;
		}

		// Token: 0x040016C2 RID: 5826
		private static readonly MessageParser<GuildApplicationGetOwnRequest> _parser;

		// Token: 0x040016C3 RID: 5827
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016C4 RID: 5828
		internal static GuildApplicationGetOwnRequest krMlcbOHdUUskVn4R6Yj;
	}
}
