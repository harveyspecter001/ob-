using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200053E RID: 1342
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestStructureStartListeningRequest : IMessage<GuildChestStructureStartListeningRequest>, IMessage, IEquatable<GuildChestStructureStartListeningRequest>, IDeepCloneable<GuildChestStructureStartListeningRequest>, IBufferMessage
	{
		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x001EE914 File Offset: 0x001ECB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestStructureStartListeningRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x001EE924 File Offset: 0x001ECB24
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

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x001EE934 File Offset: 0x001ECB34
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

		// Token: 0x06004070 RID: 16496 RVA: 0x001EE944 File Offset: 0x001ECB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStartListeningRequest()
		{
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x001EE954 File Offset: 0x001ECB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStartListeningRequest(GuildChestStructureStartListeningRequest other)
		{
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x001EE964 File Offset: 0x001ECB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStartListeningRequest Clone()
		{
			return null;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x001EE974 File Offset: 0x001ECB74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x001EE984 File Offset: 0x001ECB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestStructureStartListeningRequest other)
		{
			return true;
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x001EE994 File Offset: 0x001ECB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x001EE9A4 File Offset: 0x001ECBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x001EE9B4 File Offset: 0x001ECBB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x001EE9C4 File Offset: 0x001ECBC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x001EE9D4 File Offset: 0x001ECBD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x001EE9E4 File Offset: 0x001ECBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestStructureStartListeningRequest other)
		{
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x001EE9F4 File Offset: 0x001ECBF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x001EEA04 File Offset: 0x001ECC04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x001EEA14 File Offset: 0x001ECC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestStructureStartListeningRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						break;
					case 3:
						return;
					case 4:
						goto IL_72;
					}
				}
				IL_72:
				GuildChestStructureStartListeningRequest._parser = new MessageParser<GuildChestStructureStartListeningRequest>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x001EEAE4 File Offset: 0x001ECCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bUP22HOphPQxMa6LM7eR()
		{
			return true;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x001EEAEC File Offset: 0x001ECCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestStructureStartListeningRequest byD4BwOprBixuwN3IPl0()
		{
			return null;
		}

		// Token: 0x04001643 RID: 5699
		private static readonly MessageParser<GuildChestStructureStartListeningRequest> _parser;

		// Token: 0x04001644 RID: 5700
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001645 RID: 5701
		private static GuildChestStructureStartListeningRequest mdGGXDOpWQ0eBNB8VbYq;
	}
}
