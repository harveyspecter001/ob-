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
	// Token: 0x02000C69 RID: 3177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ColorPalette : IMessage<ColorPalette>, IMessage, IEquatable<ColorPalette>, IDeepCloneable<ColorPalette>, IBufferMessage
	{
		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x0027B304 File Offset: 0x00279504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ColorPalette> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x060098A2 RID: 39074 RVA: 0x0027B314 File Offset: 0x00279514
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

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x060098A3 RID: 39075 RVA: 0x0027B324 File Offset: 0x00279524
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

		// Token: 0x060098A4 RID: 39076 RVA: 0x0027B334 File Offset: 0x00279534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPalette()
		{
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x0027B344 File Offset: 0x00279544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPalette(ColorPalette other)
		{
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x0027B354 File Offset: 0x00279554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorPalette Clone()
		{
			return null;
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x0027B364 File Offset: 0x00279564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x0027B374 File Offset: 0x00279574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x0027B384 File Offset: 0x00279584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ColorPalette other)
		{
			return true;
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x0027B394 File Offset: 0x00279594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x0027B3A4 File Offset: 0x002795A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x0027B3B4 File Offset: 0x002795B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x0027B3C4 File Offset: 0x002795C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x0027B3D4 File Offset: 0x002795D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x0027B3E4 File Offset: 0x002795E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ColorPalette other)
		{
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x0027B3F4 File Offset: 0x002795F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x0027B404 File Offset: 0x00279604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x0027B414 File Offset: 0x00279614
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ColorPalette()
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
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						return;
					case 5:
						ColorPalette._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 4;
						continue;
					}
					break;
				}
				IL_BB:
				ColorPalette._parser = new MessageParser<ColorPalette>(() => null);
				num = 5;
				continue;
				goto IL_BB;
			}
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x0027B504 File Offset: 0x00279704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FKB0kwJNVsRLMAFU11fB()
		{
			return true;
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x0027B50C File Offset: 0x0027970C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ColorPalette drCSjyJN0xkXo3dVyhna()
		{
			return null;
		}

		// Token: 0x040038A4 RID: 14500
		private static readonly MessageParser<ColorPalette> _parser;

		// Token: 0x040038A5 RID: 14501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038A6 RID: 14502
		public const int ColorsFieldNumber = 1;

		// Token: 0x040038A7 RID: 14503
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x040038A8 RID: 14504
		private readonly RepeatedField<int> colors_;

		// Token: 0x040038A9 RID: 14505
		private static ColorPalette KpoDv0JNrLQSdu4VTAQm;
	}
}
