using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000528 RID: 1320
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCardErrorEvent : IMessage<GuildCardErrorEvent>, IMessage, IEquatable<GuildCardErrorEvent>, IDeepCloneable<GuildCardErrorEvent>, IBufferMessage
	{
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x001EC654 File Offset: 0x001EA854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildCardErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x001EC664 File Offset: 0x001EA864
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

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x001EC674 File Offset: 0x001EA874
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

		// Token: 0x06003F5F RID: 16223 RVA: 0x001EC684 File Offset: 0x001EA884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardErrorEvent()
		{
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x001EC694 File Offset: 0x001EA894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardErrorEvent(GuildCardErrorEvent other)
		{
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x001EC6A4 File Offset: 0x001EA8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x001EC6B4 File Offset: 0x001EA8B4
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x001EC6C4 File Offset: 0x001EA8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GuildId
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

		// Token: 0x06003F64 RID: 16228 RVA: 0x001EC6D4 File Offset: 0x001EA8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x001EC6E4 File Offset: 0x001EA8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCardErrorEvent other)
		{
			return true;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x001EC6F4 File Offset: 0x001EA8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x001EC704 File Offset: 0x001EA904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x001EC714 File Offset: 0x001EA914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x001EC724 File Offset: 0x001EA924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x001EC734 File Offset: 0x001EA934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x001EC744 File Offset: 0x001EA944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCardErrorEvent other)
		{
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x001EC754 File Offset: 0x001EA954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x001EC764 File Offset: 0x001EA964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x001EC774 File Offset: 0x001EA974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCardErrorEvent()
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
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
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
					GuildCardErrorEvent._parser = new MessageParser<GuildCardErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x001EC840 File Offset: 0x001EAA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fFUEAaOpnFTQ0Pc1aaVN()
		{
			return true;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x001EC848 File Offset: 0x001EAA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCardErrorEvent IlbfSeOpmUuK8ShKuAca()
		{
			return null;
		}

		// Token: 0x040015EE RID: 5614
		private static readonly MessageParser<GuildCardErrorEvent> _parser;

		// Token: 0x040015EF RID: 5615
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015F0 RID: 5616
		public const int GuildIdFieldNumber = 1;

		// Token: 0x040015F1 RID: 5617
		private int guildId_;

		// Token: 0x040015F2 RID: 5618
		private static GuildCardErrorEvent MwBvPpOpfLUfk0d7pyHA;
	}
}
