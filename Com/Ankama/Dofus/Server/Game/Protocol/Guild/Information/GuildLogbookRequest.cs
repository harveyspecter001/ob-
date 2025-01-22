using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004E2 RID: 1250
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildLogbookRequest : IMessage<GuildLogbookRequest>, IMessage, IEquatable<GuildLogbookRequest>, IDeepCloneable<GuildLogbookRequest>, IBufferMessage
	{
		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x001E7DA8 File Offset: 0x001E5FA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildLogbookRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x001E7DB8 File Offset: 0x001E5FB8
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x001E7DC8 File Offset: 0x001E5FC8
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

		// Token: 0x06003BC8 RID: 15304 RVA: 0x001E7DD8 File Offset: 0x001E5FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookRequest()
		{
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001E7DE8 File Offset: 0x001E5FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookRequest(GuildLogbookRequest other)
		{
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x001E7DF8 File Offset: 0x001E5FF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookRequest Clone()
		{
			return null;
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x001E7E08 File Offset: 0x001E6008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x001E7E18 File Offset: 0x001E6018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildLogbookRequest other)
		{
			return true;
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x001E7E28 File Offset: 0x001E6028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x001E7E38 File Offset: 0x001E6038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x001E7E48 File Offset: 0x001E6048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001E7E58 File Offset: 0x001E6058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x001E7E68 File Offset: 0x001E6068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x001E7E78 File Offset: 0x001E6078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildLogbookRequest other)
		{
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x001E7E88 File Offset: 0x001E6088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x001E7E98 File Offset: 0x001E6098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x001E7EA8 File Offset: 0x001E60A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildLogbookRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					GuildLogbookRequest._parser = new MessageParser<GuildLogbookRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x001E7F74 File Offset: 0x001E6174
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mJ0J1LO7cu9gx5INll09()
		{
			return true;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x001E7F7C File Offset: 0x001E617C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildLogbookRequest IdODVRO7UpjPLPdlBsSL()
		{
			return null;
		}

		// Token: 0x040014B3 RID: 5299
		private static readonly MessageParser<GuildLogbookRequest> _parser;

		// Token: 0x040014B4 RID: 5300
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014B5 RID: 5301
		private static GuildLogbookRequest E9LKIXO7lA0CQqHXkCGL;
	}
}
