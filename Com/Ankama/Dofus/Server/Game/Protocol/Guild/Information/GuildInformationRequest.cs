using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004E8 RID: 1256
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInformationRequest : IMessage<GuildInformationRequest>, IMessage, IEquatable<GuildInformationRequest>, IDeepCloneable<GuildInformationRequest>, IBufferMessage
	{
		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x001E83DC File Offset: 0x001E65DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x001E83EC File Offset: 0x001E65EC
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

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x001E83FC File Offset: 0x001E65FC
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

		// Token: 0x06003C18 RID: 15384 RVA: 0x001E840C File Offset: 0x001E660C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformationRequest()
		{
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x001E841C File Offset: 0x001E661C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformationRequest(GuildInformationRequest other)
		{
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x001E842C File Offset: 0x001E662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x001E843C File Offset: 0x001E663C
		// (set) Token: 0x06003C1C RID: 15388 RVA: 0x001E8450 File Offset: 0x001E6650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildInformationRequest.Types.InformationType InformationType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GuildInformationRequest.Types.InformationType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x001E8460 File Offset: 0x001E6660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x001E8470 File Offset: 0x001E6670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInformationRequest other)
		{
			return true;
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x001E8480 File Offset: 0x001E6680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x001E8490 File Offset: 0x001E6690
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x001E84A0 File Offset: 0x001E66A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x001E84B0 File Offset: 0x001E66B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x001E84C0 File Offset: 0x001E66C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x001E84D0 File Offset: 0x001E66D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInformationRequest other)
		{
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x001E84E0 File Offset: 0x001E66E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x001E84F0 File Offset: 0x001E66F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x001E8500 File Offset: 0x001E6700
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_36;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 1;
					}
				}
				IL_36:
				GuildInformationRequest._parser = new MessageParser<GuildInformationRequest>(() => null);
				num = 2;
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x001E85D0 File Offset: 0x001E67D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RtZaUsO755uX7c0EGSVG()
		{
			return true;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x001E85D8 File Offset: 0x001E67D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInformationRequest bCC7yeO7youvAnd3NkvM()
		{
			return null;
		}

		// Token: 0x040014E5 RID: 5349
		private static readonly MessageParser<GuildInformationRequest> _parser;

		// Token: 0x040014E6 RID: 5350
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014E7 RID: 5351
		public const int InformationTypeFieldNumber = 1;

		// Token: 0x040014E8 RID: 5352
		private GuildInformationRequest.Types.InformationType informationType_;

		// Token: 0x040014E9 RID: 5353
		internal static GuildInformationRequest fW4i1JO7agHWYyjJaAt0;

		// Token: 0x020004E9 RID: 1257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06003C2A RID: 15402 RVA: 0x002C2C6C File Offset: 0x002C0E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020004EA RID: 1258
			public enum InformationType
			{
				// Token: 0x040014EB RID: 5355
				[OriginalName("INFO_GENERAL")]
				InfoGeneral,
				// Token: 0x040014EC RID: 5356
				[OriginalName("INFO_MEMBERS")]
				InfoMembers,
				// Token: 0x040014ED RID: 5357
				[OriginalName("INFO_BOOSTS")]
				InfoBoosts,
				// Token: 0x040014EE RID: 5358
				[OriginalName("INFO_PADDOCKS")]
				InfoPaddocks,
				// Token: 0x040014EF RID: 5359
				[OriginalName("INFO_HOUSES")]
				InfoHouses,
				// Token: 0x040014F0 RID: 5360
				[OriginalName("INFO_RECRUITMENT")]
				InfoRecruitment,
				// Token: 0x040014F1 RID: 5361
				[OriginalName("INFO_LOGBOOK")]
				InfoLogbook
			}
		}
	}
}
