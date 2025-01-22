using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000263 RID: 611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSetFavoriteRequest : IMessage<PresetSetFavoriteRequest>, IMessage, IEquatable<PresetSetFavoriteRequest>, IDeepCloneable<PresetSetFavoriteRequest>, IBufferMessage
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x001B1FB4 File Offset: 0x001B01B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetSetFavoriteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x001B1FC4 File Offset: 0x001B01C4
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x001B1FD4 File Offset: 0x001B01D4
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

		// Token: 0x06001C6C RID: 7276 RVA: 0x001B1FE4 File Offset: 0x001B01E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteRequest()
		{
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x001B1FF4 File Offset: 0x001B01F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteRequest(PresetSetFavoriteRequest other)
		{
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x001B2004 File Offset: 0x001B0204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSetFavoriteRequest Clone()
		{
			return null;
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x001B2014 File Offset: 0x001B0214
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x001B2024 File Offset: 0x001B0224
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PresetUuid
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x001B2034 File Offset: 0x001B0234
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x001B2048 File Offset: 0x001B0248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetType PresetType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x001B2058 File Offset: 0x001B0258
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x001B2068 File Offset: 0x001B0268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsFavorite
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

		// Token: 0x06001C75 RID: 7285 RVA: 0x001B2078 File Offset: 0x001B0278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x001B2088 File Offset: 0x001B0288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSetFavoriteRequest other)
		{
			return true;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x001B2098 File Offset: 0x001B0298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x001B20A8 File Offset: 0x001B02A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x001B20B8 File Offset: 0x001B02B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x001B20C8 File Offset: 0x001B02C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x001B20D8 File Offset: 0x001B02D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x001B20E8 File Offset: 0x001B02E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSetFavoriteRequest other)
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x001B20F8 File Offset: 0x001B02F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x001B2108 File Offset: 0x001B0308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x001B2118 File Offset: 0x001B0318
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSetFavoriteRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					PresetSetFavoriteRequest._parser = new MessageParser<PresetSetFavoriteRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x001B21FC File Offset: 0x001B03FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oXhUp8O51vgSm3DDGrul()
		{
			return true;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x001B2204 File Offset: 0x001B0404
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSetFavoriteRequest QBX6dAO5aVnNERH5UCoH()
		{
			return null;
		}

		// Token: 0x04000A19 RID: 2585
		private static readonly MessageParser<PresetSetFavoriteRequest> _parser;

		// Token: 0x04000A1A RID: 2586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A1B RID: 2587
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000A1C RID: 2588
		private string presetUuid_;

		// Token: 0x04000A1D RID: 2589
		public const int PresetTypeFieldNumber = 2;

		// Token: 0x04000A1E RID: 2590
		private PresetType presetType_;

		// Token: 0x04000A1F RID: 2591
		public const int IsFavoriteFieldNumber = 3;

		// Token: 0x04000A20 RID: 2592
		private bool isFavorite_;

		// Token: 0x04000A21 RID: 2593
		internal static PresetSetFavoriteRequest cBemf1O5oTxlQD4wqH70;
	}
}
