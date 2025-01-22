using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004EE RID: 1262
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildModificationEmblemValidRequest : IMessage<GuildModificationEmblemValidRequest>, IMessage, IEquatable<GuildModificationEmblemValidRequest>, IDeepCloneable<GuildModificationEmblemValidRequest>, IBufferMessage
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x001E87DC File Offset: 0x001E69DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildModificationEmblemValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x001E87EC File Offset: 0x001E69EC
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

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x001E87FC File Offset: 0x001E69FC
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

		// Token: 0x06003C4D RID: 15437 RVA: 0x001E880C File Offset: 0x001E6A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationEmblemValidRequest()
		{
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x001E881C File Offset: 0x001E6A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationEmblemValidRequest(GuildModificationEmblemValidRequest other)
		{
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x001E882C File Offset: 0x001E6A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationEmblemValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x001E883C File Offset: 0x001E6A3C
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x001E884C File Offset: 0x001E6A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialEmblem Emblem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x001E885C File Offset: 0x001E6A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001E886C File Offset: 0x001E6A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildModificationEmblemValidRequest other)
		{
			return true;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x001E887C File Offset: 0x001E6A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x001E888C File Offset: 0x001E6A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x001E889C File Offset: 0x001E6A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x001E88AC File Offset: 0x001E6AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x001E88BC File Offset: 0x001E6ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x001E88CC File Offset: 0x001E6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildModificationEmblemValidRequest other)
		{
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x001E88DC File Offset: 0x001E6ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x001E88EC File Offset: 0x001E6AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x001E88FC File Offset: 0x001E6AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildModificationEmblemValidRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						GuildModificationEmblemValidRequest._parser = new MessageParser<GuildModificationEmblemValidRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5E;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_5E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x001E89E4 File Offset: 0x001E6BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AQ23MdO7rxgNB8Oa5sXG()
		{
			return true;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x001E89EC File Offset: 0x001E6BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildModificationEmblemValidRequest KHxPBRO7V23PgG2JERUH()
		{
			return null;
		}

		// Token: 0x040014FB RID: 5371
		private static readonly MessageParser<GuildModificationEmblemValidRequest> _parser;

		// Token: 0x040014FC RID: 5372
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014FD RID: 5373
		public const int EmblemFieldNumber = 1;

		// Token: 0x040014FE RID: 5374
		private SocialEmblem emblem_;

		// Token: 0x040014FF RID: 5375
		internal static GuildModificationEmblemValidRequest mYucp5O7hI9omlycesNN;
	}
}
