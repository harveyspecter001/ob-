using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000540 RID: 1344
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestStructureStopListeningRequest : IMessage<GuildChestStructureStopListeningRequest>, IMessage, IEquatable<GuildChestStructureStopListeningRequest>, IDeepCloneable<GuildChestStructureStopListeningRequest>, IBufferMessage
	{
		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06004085 RID: 16517 RVA: 0x001EEAF4 File Offset: 0x001ECCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestStructureStopListeningRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x001EEB04 File Offset: 0x001ECD04
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

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x001EEB14 File Offset: 0x001ECD14
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

		// Token: 0x06004088 RID: 16520 RVA: 0x001EEB24 File Offset: 0x001ECD24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStopListeningRequest()
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x001EEB34 File Offset: 0x001ECD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStopListeningRequest(GuildChestStructureStopListeningRequest other)
		{
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x001EEB44 File Offset: 0x001ECD44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestStructureStopListeningRequest Clone()
		{
			return null;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x001EEB54 File Offset: 0x001ECD54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x001EEB64 File Offset: 0x001ECD64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestStructureStopListeningRequest other)
		{
			return true;
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x001EEB74 File Offset: 0x001ECD74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x001EEB84 File Offset: 0x001ECD84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x001EEB94 File Offset: 0x001ECD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x001EEBA4 File Offset: 0x001ECDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x001EEBB4 File Offset: 0x001ECDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x001EEBC4 File Offset: 0x001ECDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestStructureStopListeningRequest other)
		{
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x001EEBD4 File Offset: 0x001ECDD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x001EEBE4 File Offset: 0x001ECDE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x001EEBF4 File Offset: 0x001ECDF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestStructureStopListeningRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					GuildChestStructureStopListeningRequest._parser = new MessageParser<GuildChestStructureStopListeningRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x001EECD8 File Offset: 0x001ECED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m2j6OEOp0gp2GJstPksW()
		{
			return true;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x001EECE0 File Offset: 0x001ECEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestStructureStopListeningRequest QJtSxWOpCQi7kfnMQG6l()
		{
			return null;
		}

		// Token: 0x04001648 RID: 5704
		private static readonly MessageParser<GuildChestStructureStopListeningRequest> _parser;

		// Token: 0x04001649 RID: 5705
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400164A RID: 5706
		private static GuildChestStructureStopListeningRequest LlG6hVOpVATaT6fQINtn;
	}
}
