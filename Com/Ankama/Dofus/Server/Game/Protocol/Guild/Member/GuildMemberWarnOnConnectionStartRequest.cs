using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004CF RID: 1231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberWarnOnConnectionStartRequest : IMessage<GuildMemberWarnOnConnectionStartRequest>, IMessage, IEquatable<GuildMemberWarnOnConnectionStartRequest>, IDeepCloneable<GuildMemberWarnOnConnectionStartRequest>, IBufferMessage
	{
		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x001E4B08 File Offset: 0x001E2D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildMemberWarnOnConnectionStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x001E4B18 File Offset: 0x001E2D18
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

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x001E4B28 File Offset: 0x001E2D28
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

		// Token: 0x06003AD9 RID: 15065 RVA: 0x001E4B38 File Offset: 0x001E2D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStartRequest()
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x001E4B48 File Offset: 0x001E2D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStartRequest(GuildMemberWarnOnConnectionStartRequest other)
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x001E4B58 File Offset: 0x001E2D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStartRequest Clone()
		{
			return null;
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x001E4B68 File Offset: 0x001E2D68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x001E4B78 File Offset: 0x001E2D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberWarnOnConnectionStartRequest other)
		{
			return true;
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x001E4B88 File Offset: 0x001E2D88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x001E4B98 File Offset: 0x001E2D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x001E4BA8 File Offset: 0x001E2DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x001E4BB8 File Offset: 0x001E2DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x001E4BC8 File Offset: 0x001E2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x001E4BD8 File Offset: 0x001E2DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberWarnOnConnectionStartRequest other)
		{
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001E4BE8 File Offset: 0x001E2DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x001E4BF8 File Offset: 0x001E2DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x001E4C08 File Offset: 0x001E2E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberWarnOnConnectionStartRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildMemberWarnOnConnectionStartRequest._parser = new MessageParser<GuildMemberWarnOnConnectionStartRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x001E4D00 File Offset: 0x001E2F00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WCDdK9OQZImiAsapONKg()
		{
			return true;
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x001E4D08 File Offset: 0x001E2F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberWarnOnConnectionStartRequest GIB4iyOQqqo9f1EUmmgo()
		{
			return null;
		}

		// Token: 0x0400146F RID: 5231
		private static readonly MessageParser<GuildMemberWarnOnConnectionStartRequest> _parser;

		// Token: 0x04001470 RID: 5232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001471 RID: 5233
		private static GuildMemberWarnOnConnectionStartRequest Ubp2r9OQ8SV6UnexBxAl;
	}
}
