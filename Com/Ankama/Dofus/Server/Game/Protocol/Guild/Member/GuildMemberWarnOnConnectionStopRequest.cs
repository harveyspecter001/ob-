using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004D1 RID: 1233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberWarnOnConnectionStopRequest : IMessage<GuildMemberWarnOnConnectionStopRequest>, IMessage, IEquatable<GuildMemberWarnOnConnectionStopRequest>, IDeepCloneable<GuildMemberWarnOnConnectionStopRequest>, IBufferMessage
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x001E4D10 File Offset: 0x001E2F10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildMemberWarnOnConnectionStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x001E4D20 File Offset: 0x001E2F20
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

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x001E4D30 File Offset: 0x001E2F30
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

		// Token: 0x06003AF1 RID: 15089 RVA: 0x001E4D40 File Offset: 0x001E2F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStopRequest()
		{
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x001E4D50 File Offset: 0x001E2F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStopRequest(GuildMemberWarnOnConnectionStopRequest other)
		{
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x001E4D60 File Offset: 0x001E2F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberWarnOnConnectionStopRequest Clone()
		{
			return null;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x001E4D70 File Offset: 0x001E2F70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x001E4D80 File Offset: 0x001E2F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberWarnOnConnectionStopRequest other)
		{
			return true;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x001E4D90 File Offset: 0x001E2F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001E4DA0 File Offset: 0x001E2FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x001E4DB0 File Offset: 0x001E2FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x001E4DC0 File Offset: 0x001E2FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x001E4DD0 File Offset: 0x001E2FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001E4DE0 File Offset: 0x001E2FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberWarnOnConnectionStopRequest other)
		{
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x001E4DF0 File Offset: 0x001E2FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x001E4E00 File Offset: 0x001E3000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001E4E10 File Offset: 0x001E3010
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberWarnOnConnectionStopRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
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
					GuildMemberWarnOnConnectionStopRequest._parser = new MessageParser<GuildMemberWarnOnConnectionStopRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x001E4EF4 File Offset: 0x001E30F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LoX3CFOQzMRnxYO1Kbuy()
		{
			return true;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x001E4EFC File Offset: 0x001E30FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberWarnOnConnectionStopRequest dSsQseO7fpgh3XdH8yLD()
		{
			return null;
		}

		// Token: 0x04001474 RID: 5236
		private static readonly MessageParser<GuildMemberWarnOnConnectionStopRequest> _parser;

		// Token: 0x04001475 RID: 5237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001476 RID: 5238
		private static GuildMemberWarnOnConnectionStopRequest QbF3UxOQFxWSuB1InCjx;
	}
}
