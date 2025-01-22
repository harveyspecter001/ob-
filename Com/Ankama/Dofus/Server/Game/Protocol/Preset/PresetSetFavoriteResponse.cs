using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000265 RID: 613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSetFavoriteResponse : IMessage<PresetSetFavoriteResponse>, IMessage, IEquatable<PresetSetFavoriteResponse>, IDeepCloneable<PresetSetFavoriteResponse>, IBufferMessage
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x001B220C File Offset: 0x001B040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetSetFavoriteResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x001B221C File Offset: 0x001B041C
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x001B222C File Offset: 0x001B042C
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

		// Token: 0x06001C8A RID: 7306 RVA: 0x001B223C File Offset: 0x001B043C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteResponse()
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x001B224C File Offset: 0x001B044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteResponse(PresetSetFavoriteResponse other)
		{
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x001B225C File Offset: 0x001B045C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteResponse Clone()
		{
			return null;
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x001B226C File Offset: 0x001B046C
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x001B227C File Offset: 0x001B047C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x001B228C File Offset: 0x001B048C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x001B229C File Offset: 0x001B049C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSetFavoriteResponse other)
		{
			return true;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x001B22AC File Offset: 0x001B04AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x001B22BC File Offset: 0x001B04BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x001B22CC File Offset: 0x001B04CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x001B22DC File Offset: 0x001B04DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x001B22EC File Offset: 0x001B04EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x001B22FC File Offset: 0x001B04FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSetFavoriteResponse other)
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x001B230C File Offset: 0x001B050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x001B231C File Offset: 0x001B051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x001B232C File Offset: 0x001B052C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSetFavoriteResponse()
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
					PresetSetFavoriteResponse._parser = new MessageParser<PresetSetFavoriteResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x001B2410 File Offset: 0x001B0610
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DgyVgnO5yuZM4ggyKpgJ()
		{
			return true;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x001B2418 File Offset: 0x001B0618
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSetFavoriteResponse WdNYiKO56vND5QKph5Bw()
		{
			return null;
		}

		// Token: 0x04000A24 RID: 2596
		private static readonly MessageParser<PresetSetFavoriteResponse> _parser;

		// Token: 0x04000A25 RID: 2597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A26 RID: 2598
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000A27 RID: 2599
		private bool isSuccess_;

		// Token: 0x04000A28 RID: 2600
		internal static PresetSetFavoriteResponse l4MLBQO557Xq2Voq285O;
	}
}
