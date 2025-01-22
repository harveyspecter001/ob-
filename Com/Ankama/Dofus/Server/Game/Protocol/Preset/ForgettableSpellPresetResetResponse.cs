using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200022C RID: 556
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetResetResponse : IMessage<ForgettableSpellPresetResetResponse>, IMessage, IEquatable<ForgettableSpellPresetResetResponse>, IDeepCloneable<ForgettableSpellPresetResetResponse>, IBufferMessage
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x001AFDD0 File Offset: 0x001ADFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellPresetResetResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x001AFDE0 File Offset: 0x001ADFE0
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

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x001AFDF0 File Offset: 0x001ADFF0
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

		// Token: 0x060019FE RID: 6654 RVA: 0x001AFE00 File Offset: 0x001AE000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetResponse()
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x001AFE10 File Offset: 0x001AE010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetResponse(ForgettableSpellPresetResetResponse other)
		{
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x001AFE20 File Offset: 0x001AE020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetResponse Clone()
		{
			return null;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x001AFE30 File Offset: 0x001AE030
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x001AFE40 File Offset: 0x001AE040
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x001AFE50 File Offset: 0x001AE050
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x001AFE60 File Offset: 0x001AE060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellPresetInfo PresetInfo
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

		// Token: 0x06001A05 RID: 6661 RVA: 0x001AFE70 File Offset: 0x001AE070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x001AFE80 File Offset: 0x001AE080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetResetResponse other)
		{
			return true;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x001AFE90 File Offset: 0x001AE090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x001AFEA0 File Offset: 0x001AE0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x001AFEB0 File Offset: 0x001AE0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x001AFEC0 File Offset: 0x001AE0C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x001AFED0 File Offset: 0x001AE0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x001AFEE0 File Offset: 0x001AE0E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetResetResponse other)
		{
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x001AFEF0 File Offset: 0x001AE0F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x001AFF00 File Offset: 0x001AE100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x001AFF10 File Offset: 0x001AE110
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetResetResponse()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ForgettableSpellPresetResetResponse._parser = new MessageParser<ForgettableSpellPresetResetResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x001AFFF4 File Offset: 0x001AE1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V9o8K8OaTEDfXf3VelDE()
		{
			return true;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x001AFFFC File Offset: 0x001AE1FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetResetResponse dhx3UfOapJN2vrcBtRQ9()
		{
			return null;
		}

		// Token: 0x0400093B RID: 2363
		private static readonly MessageParser<ForgettableSpellPresetResetResponse> _parser;

		// Token: 0x0400093C RID: 2364
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400093D RID: 2365
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x0400093E RID: 2366
		private bool isSuccess_;

		// Token: 0x0400093F RID: 2367
		public const int PresetInfoFieldNumber = 2;

		// Token: 0x04000940 RID: 2368
		private ForgettableSpellPresetInfo presetInfo_;

		// Token: 0x04000941 RID: 2369
		private static ForgettableSpellPresetResetResponse gqcW1HOa78eZNMu8dN18;
	}
}
