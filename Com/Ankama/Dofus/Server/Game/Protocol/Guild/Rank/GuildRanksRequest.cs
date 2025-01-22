using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004BE RID: 1214
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRanksRequest : IMessage<GuildRanksRequest>, IMessage, IEquatable<GuildRanksRequest>, IDeepCloneable<GuildRanksRequest>, IBufferMessage
	{
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x001E31BC File Offset: 0x001E13BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRanksRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x001E31CC File Offset: 0x001E13CC
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

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x001E31DC File Offset: 0x001E13DC
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

		// Token: 0x060039FE RID: 14846 RVA: 0x001E31EC File Offset: 0x001E13EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksRequest()
		{
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x001E31FC File Offset: 0x001E13FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksRequest(GuildRanksRequest other)
		{
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x001E320C File Offset: 0x001E140C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksRequest Clone()
		{
			return null;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x001E321C File Offset: 0x001E141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x001E322C File Offset: 0x001E142C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRanksRequest other)
		{
			return true;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x001E323C File Offset: 0x001E143C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x001E324C File Offset: 0x001E144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x001E325C File Offset: 0x001E145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x001E326C File Offset: 0x001E146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x001E327C File Offset: 0x001E147C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x001E328C File Offset: 0x001E148C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRanksRequest other)
		{
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x001E329C File Offset: 0x001E149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x001E32AC File Offset: 0x001E14AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x001E32BC File Offset: 0x001E14BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRanksRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					GuildRanksRequest._parser = new MessageParser<GuildRanksRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001E33B4 File Offset: 0x001E15B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hmcajPOQaHGGSce8gjqU()
		{
			return true;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x001E33BC File Offset: 0x001E15BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRanksRequest TpnpsZOQ5YYRjW2BgydR()
		{
			return null;
		}

		// Token: 0x04001428 RID: 5160
		private static readonly MessageParser<GuildRanksRequest> _parser;

		// Token: 0x04001429 RID: 5161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400142A RID: 5162
		private static GuildRanksRequest X8OlhqOQ10wt3ifDs5W1;
	}
}
