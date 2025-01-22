using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000228 RID: 552
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetResetResponse : IMessage<CharacterPresetResetResponse>, IMessage, IEquatable<CharacterPresetResetResponse>, IDeepCloneable<CharacterPresetResetResponse>, IBufferMessage
	{
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x001AF98C File Offset: 0x001ADB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetResetResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x001AF99C File Offset: 0x001ADB9C
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x001AF9AC File Offset: 0x001ADBAC
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

		// Token: 0x060019C8 RID: 6600 RVA: 0x001AF9BC File Offset: 0x001ADBBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetResponse()
		{
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x001AF9CC File Offset: 0x001ADBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetResponse(CharacterPresetResetResponse other)
		{
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x001AF9DC File Offset: 0x001ADBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetResetResponse Clone()
		{
			return null;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x001AF9EC File Offset: 0x001ADBEC
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x001AF9FC File Offset: 0x001ADBFC
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x001AFA0C File Offset: 0x001ADC0C
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x001AFA1C File Offset: 0x001ADC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterPresetInfo PresetInfo
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

		// Token: 0x060019CF RID: 6607 RVA: 0x001AFA2C File Offset: 0x001ADC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x001AFA3C File Offset: 0x001ADC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetResetResponse other)
		{
			return true;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x001AFA4C File Offset: 0x001ADC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x001AFA5C File Offset: 0x001ADC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x001AFA6C File Offset: 0x001ADC6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x001AFA7C File Offset: 0x001ADC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x001AFA8C File Offset: 0x001ADC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x001AFA9C File Offset: 0x001ADC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetResetResponse other)
		{
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x001AFAAC File Offset: 0x001ADCAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x001AFABC File Offset: 0x001ADCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x001AFACC File Offset: 0x001ADCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetResetResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CharacterPresetResetResponse._parser = new MessageParser<CharacterPresetResetResponse>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x001AFBC4 File Offset: 0x001ADDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BtR7XHOaCPnhYb2lfpbx()
		{
			return true;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x001AFBCC File Offset: 0x001ADDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetResetResponse dicB5dOaDirUQYJaSGCM()
		{
			return null;
		}

		// Token: 0x0400092B RID: 2347
		private static readonly MessageParser<CharacterPresetResetResponse> _parser;

		// Token: 0x0400092C RID: 2348
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400092D RID: 2349
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x0400092E RID: 2350
		private bool isSuccess_;

		// Token: 0x0400092F RID: 2351
		public const int PresetInfoFieldNumber = 2;

		// Token: 0x04000930 RID: 2352
		private CharacterPresetInfo presetInfo_;

		// Token: 0x04000931 RID: 2353
		private static CharacterPresetResetResponse tc4hX4Oa0SUNBhtFn8ZL;
	}
}
