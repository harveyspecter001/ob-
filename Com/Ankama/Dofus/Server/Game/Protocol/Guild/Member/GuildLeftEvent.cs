using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004DB RID: 1243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildLeftEvent : IMessage<GuildLeftEvent>, IMessage, IEquatable<GuildLeftEvent>, IDeepCloneable<GuildLeftEvent>, IBufferMessage
	{
		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003B71 RID: 15217 RVA: 0x001E577C File Offset: 0x001E397C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildLeftEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x001E578C File Offset: 0x001E398C
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x001E579C File Offset: 0x001E399C
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

		// Token: 0x06003B74 RID: 15220 RVA: 0x001E57AC File Offset: 0x001E39AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLeftEvent()
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x001E57BC File Offset: 0x001E39BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLeftEvent(GuildLeftEvent other)
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x001E57CC File Offset: 0x001E39CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLeftEvent Clone()
		{
			return null;
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x001E57DC File Offset: 0x001E39DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x001E57EC File Offset: 0x001E39EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildLeftEvent other)
		{
			return true;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x001E57FC File Offset: 0x001E39FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x001E580C File Offset: 0x001E3A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x001E581C File Offset: 0x001E3A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x001E582C File Offset: 0x001E3A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x001E583C File Offset: 0x001E3A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x001E584C File Offset: 0x001E3A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildLeftEvent other)
		{
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x001E585C File Offset: 0x001E3A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x001E586C File Offset: 0x001E3A6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x001E587C File Offset: 0x001E3A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildLeftEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					GuildLeftEvent._parser = new MessageParser<GuildLeftEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x001E5960 File Offset: 0x001E3B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H5o9Z6O79QdRTTHw5glA()
		{
			return true;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x001E5968 File Offset: 0x001E3B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildLeftEvent AD9p14O72l3tj2LnpvrY()
		{
			return null;
		}

		// Token: 0x0400149A RID: 5274
		private static readonly MessageParser<GuildLeftEvent> _parser;

		// Token: 0x0400149B RID: 5275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400149C RID: 5276
		private static GuildLeftEvent OVeb41O7dn2NsL46l1ve;
	}
}
