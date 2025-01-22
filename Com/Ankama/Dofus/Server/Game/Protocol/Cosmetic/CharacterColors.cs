using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C67 RID: 3175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterColors : IMessage<CharacterColors>, IMessage, IEquatable<CharacterColors>, IDeepCloneable<CharacterColors>, IBufferMessage
	{
		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x0027B098 File Offset: 0x00279298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterColors> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x0027B0A8 File Offset: 0x002792A8
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

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x0027B0B8 File Offset: 0x002792B8
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

		// Token: 0x06009887 RID: 39047 RVA: 0x0027B0C8 File Offset: 0x002792C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColors()
		{
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x0027B0D8 File Offset: 0x002792D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColors(CharacterColors other)
		{
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x0027B0E8 File Offset: 0x002792E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColors Clone()
		{
			return null;
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x0027B0F8 File Offset: 0x002792F8
		// (set) Token: 0x0600988B RID: 39051 RVA: 0x0027B108 File Offset: 0x00279308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Slots
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

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x0600988C RID: 39052 RVA: 0x0027B118 File Offset: 0x00279318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ColorPalette> ColorPalettes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600988D RID: 39053 RVA: 0x0027B128 File Offset: 0x00279328
		// (set) Token: 0x0600988E RID: 39054 RVA: 0x0027B138 File Offset: 0x00279338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSlots
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

		// Token: 0x0600988F RID: 39055 RVA: 0x0027B148 File Offset: 0x00279348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x0027B158 File Offset: 0x00279358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterColors other)
		{
			return true;
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x0027B168 File Offset: 0x00279368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x0027B178 File Offset: 0x00279378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x0027B188 File Offset: 0x00279388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x0027B198 File Offset: 0x00279398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x0027B1A8 File Offset: 0x002793A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x0027B1B8 File Offset: 0x002793B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterColors other)
		{
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x0027B1C8 File Offset: 0x002793C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x0027B1D8 File Offset: 0x002793D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x0027B1E8 File Offset: 0x002793E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterColors()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_39;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						continue;
					}
					CharacterColors._parser = new MessageParser<CharacterColors>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 1;
					}
				}
				IL_39:
				CharacterColors._repeated_colorPalettes_codec = FieldCodec.ForMessage<ColorPalette>(18U, vQwZtCeWwUbUNdgay795.XVInXhlssT(vQwZtCeWwUbUNdgay795.SfweWQSDryZ));
				num = 2;
			}
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x0027B2F4 File Offset: 0x002794F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wpSkoxJNW0rW7ciOLSSQ()
		{
			return true;
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x0027B2FC File Offset: 0x002794FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterColors TwWlw9JNhWe5gg1MPKFi()
		{
			return null;
		}

		// Token: 0x04003898 RID: 14488
		private static readonly MessageParser<CharacterColors> _parser;

		// Token: 0x04003899 RID: 14489
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400389A RID: 14490
		public const int SlotsFieldNumber = 1;

		// Token: 0x0400389B RID: 14491
		private int slots_;

		// Token: 0x0400389C RID: 14492
		public const int ColorPalettesFieldNumber = 2;

		// Token: 0x0400389D RID: 14493
		private static readonly FieldCodec<ColorPalette> _repeated_colorPalettes_codec;

		// Token: 0x0400389E RID: 14494
		private readonly RepeatedField<ColorPalette> colorPalettes_;

		// Token: 0x0400389F RID: 14495
		public const int MaxSlotsFieldNumber = 3;

		// Token: 0x040038A0 RID: 14496
		private int maxSlots_;

		// Token: 0x040038A1 RID: 14497
		internal static CharacterColors RVgNxlJNLiH6AwdcKgQu;
	}
}
