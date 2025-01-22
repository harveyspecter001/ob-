using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000261 RID: 609
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSymbolUpdateResponse : IMessage<PresetSymbolUpdateResponse>, IMessage, IEquatable<PresetSymbolUpdateResponse>, IDeepCloneable<PresetSymbolUpdateResponse>, IBufferMessage
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x001B1DA0 File Offset: 0x001AFFA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetSymbolUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x001B1DB0 File Offset: 0x001AFFB0
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x001B1DC0 File Offset: 0x001AFFC0
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

		// Token: 0x06001C52 RID: 7250 RVA: 0x001B1DD0 File Offset: 0x001AFFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateResponse()
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x001B1DE0 File Offset: 0x001AFFE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateResponse(PresetSymbolUpdateResponse other)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x001B1DF0 File Offset: 0x001AFFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSymbolUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x001B1E00 File Offset: 0x001B0000
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x001B1E10 File Offset: 0x001B0010
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

		// Token: 0x06001C57 RID: 7255 RVA: 0x001B1E20 File Offset: 0x001B0020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x001B1E30 File Offset: 0x001B0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSymbolUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x001B1E40 File Offset: 0x001B0040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x001B1E50 File Offset: 0x001B0050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x001B1E60 File Offset: 0x001B0060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x001B1E70 File Offset: 0x001B0070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x001B1E80 File Offset: 0x001B0080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x001B1E90 File Offset: 0x001B0090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSymbolUpdateResponse other)
		{
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x001B1EA0 File Offset: 0x001B00A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x001B1EB0 File Offset: 0x001B00B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x001B1EC0 File Offset: 0x001B00C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSymbolUpdateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PresetSymbolUpdateResponse._parser = new MessageParser<PresetSymbolUpdateResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x001B1FA4 File Offset: 0x001B01A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c6uKabO5U7uqTZmWexYU()
		{
			return true;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x001B1FAC File Offset: 0x001B01AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSymbolUpdateResponse L5Ywd8O5v2SgsiHvuwZf()
		{
			return null;
		}

		// Token: 0x04000A12 RID: 2578
		private static readonly MessageParser<PresetSymbolUpdateResponse> _parser;

		// Token: 0x04000A13 RID: 2579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A14 RID: 2580
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000A15 RID: 2581
		private bool isSuccess_;

		// Token: 0x04000A16 RID: 2582
		private static PresetSymbolUpdateResponse w1Zm1XO5cNYnD80LvMfR;
	}
}
