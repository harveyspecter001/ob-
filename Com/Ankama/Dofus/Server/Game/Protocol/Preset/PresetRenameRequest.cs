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
	// Token: 0x02000259 RID: 601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetRenameRequest : IMessage<PresetRenameRequest>, IMessage, IEquatable<PresetRenameRequest>, IDeepCloneable<PresetRenameRequest>, IBufferMessage
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x001B16C4 File Offset: 0x001AF8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetRenameRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x001B16D4 File Offset: 0x001AF8D4
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x001B16E4 File Offset: 0x001AF8E4
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

		// Token: 0x06001BFB RID: 7163 RVA: 0x001B16F4 File Offset: 0x001AF8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameRequest()
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x001B1704 File Offset: 0x001AF904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameRequest(PresetRenameRequest other)
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x001B1714 File Offset: 0x001AF914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameRequest Clone()
		{
			return null;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x001B1724 File Offset: 0x001AF924
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x001B1734 File Offset: 0x001AF934
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x001B1744 File Offset: 0x001AF944
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x001B1758 File Offset: 0x001AF958
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x001B1768 File Offset: 0x001AF968
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x001B1778 File Offset: 0x001AF978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x06001C04 RID: 7172 RVA: 0x001B1788 File Offset: 0x001AF988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x001B1798 File Offset: 0x001AF998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetRenameRequest other)
		{
			return true;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x001B17A8 File Offset: 0x001AF9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x001B17B8 File Offset: 0x001AF9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x001B17C8 File Offset: 0x001AF9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x001B17D8 File Offset: 0x001AF9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x001B17E8 File Offset: 0x001AF9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x001B17F8 File Offset: 0x001AF9F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetRenameRequest other)
		{
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x001B1808 File Offset: 0x001AFA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x001B1818 File Offset: 0x001AFA18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x001B1828 File Offset: 0x001AFA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetRenameRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					PresetRenameRequest._parser = new MessageParser<PresetRenameRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x001B190C File Offset: 0x001AFB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lCY8yoO5NDNCC4btKfJA()
		{
			return true;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x001B1914 File Offset: 0x001AFB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetRenameRequest rwlH4UO5xEM3OiUZqkEe()
		{
			return null;
		}

		// Token: 0x040009EF RID: 2543
		private static readonly MessageParser<PresetRenameRequest> _parser;

		// Token: 0x040009F0 RID: 2544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009F1 RID: 2545
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x040009F2 RID: 2546
		private string presetUuid_;

		// Token: 0x040009F3 RID: 2547
		public const int PresetTypeFieldNumber = 2;

		// Token: 0x040009F4 RID: 2548
		private PresetType presetType_;

		// Token: 0x040009F5 RID: 2549
		public const int NameFieldNumber = 3;

		// Token: 0x040009F6 RID: 2550
		private string name_;

		// Token: 0x040009F7 RID: 2551
		private static PresetRenameRequest kV4TInO5XsmlpCLtb2ZR;
	}
}
