using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200055C RID: 1372
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationsRequest : IMessage<GuildApplicationsRequest>, IMessage, IEquatable<GuildApplicationsRequest>, IDeepCloneable<GuildApplicationsRequest>, IBufferMessage
	{
		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x001F1594 File Offset: 0x001EF794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x001F15A4 File Offset: 0x001EF7A4
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x001F15B4 File Offset: 0x001EF7B4
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

		// Token: 0x060041FD RID: 16893 RVA: 0x001F15C4 File Offset: 0x001EF7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsRequest()
		{
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x001F15D4 File Offset: 0x001EF7D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsRequest(GuildApplicationsRequest other)
		{
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x001F15E4 File Offset: 0x001EF7E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationsRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x001F15F4 File Offset: 0x001EF7F4
		// (set) Token: 0x06004201 RID: 16897 RVA: 0x001F1604 File Offset: 0x001EF804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Offset
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x001F1614 File Offset: 0x001EF814
		// (set) Token: 0x06004203 RID: 16899 RVA: 0x001F1624 File Offset: 0x001EF824
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Count
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

		// Token: 0x06004204 RID: 16900 RVA: 0x001F1634 File Offset: 0x001EF834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x001F1644 File Offset: 0x001EF844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationsRequest other)
		{
			return true;
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x001F1654 File Offset: 0x001EF854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x001F1664 File Offset: 0x001EF864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x001F1674 File Offset: 0x001EF874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x001F1684 File Offset: 0x001EF884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x001F1694 File Offset: 0x001EF894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x001F16A4 File Offset: 0x001EF8A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationsRequest other)
		{
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x001F16B4 File Offset: 0x001EF8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x001F16C4 File Offset: 0x001EF8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x001F16D4 File Offset: 0x001EF8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GuildApplicationsRequest._parser = new MessageParser<GuildApplicationsRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x001F17A0 File Offset: 0x001EF9A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PbLtfBOHX2YMWgGW5y9k()
		{
			return true;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x001F17A8 File Offset: 0x001EF9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationsRequest W8vKhiOHNwI2h0qqZTd7()
		{
			return null;
		}

		// Token: 0x040016C7 RID: 5831
		private static readonly MessageParser<GuildApplicationsRequest> _parser;

		// Token: 0x040016C8 RID: 5832
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016C9 RID: 5833
		public const int OffsetFieldNumber = 1;

		// Token: 0x040016CA RID: 5834
		private long offset_;

		// Token: 0x040016CB RID: 5835
		public const int CountFieldNumber = 2;

		// Token: 0x040016CC RID: 5836
		private int count_;

		// Token: 0x040016CD RID: 5837
		internal static GuildApplicationsRequest tk1YMSOHEoJx98SPuQXj;
	}
}
