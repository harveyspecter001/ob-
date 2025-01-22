using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x0200006B RID: 107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitlesAndOrnamentsEvent : IMessage<TitlesAndOrnamentsEvent>, IMessage, IEquatable<TitlesAndOrnamentsEvent>, IDeepCloneable<TitlesAndOrnamentsEvent>, IBufferMessage
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00188D4C File Offset: 0x00186F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TitlesAndOrnamentsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00188D5C File Offset: 0x00186F5C
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00188D6C File Offset: 0x00186F6C
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

		// Token: 0x06000420 RID: 1056 RVA: 0x00188D7C File Offset: 0x00186F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsEvent()
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00188D8C File Offset: 0x00186F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsEvent(TitlesAndOrnamentsEvent other)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00188D9C File Offset: 0x00186F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsEvent Clone()
		{
			return null;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00188DAC File Offset: 0x00186FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Titles
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00188DBC File Offset: 0x00186FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ornaments
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00188DCC File Offset: 0x00186FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00188DDC File Offset: 0x00186FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitlesAndOrnamentsEvent other)
		{
			return true;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00188DEC File Offset: 0x00186FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00188DFC File Offset: 0x00186FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00188E0C File Offset: 0x0018700C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00188E1C File Offset: 0x0018701C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00188E2C File Offset: 0x0018702C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00188E3C File Offset: 0x0018703C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitlesAndOrnamentsEvent other)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00188E4C File Offset: 0x0018704C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00188E5C File Offset: 0x0018705C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00188E6C File Offset: 0x0018706C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitlesAndOrnamentsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TitlesAndOrnamentsEvent._repeated_ornaments_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					TitlesAndOrnamentsEvent._repeated_titles_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 6;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TitlesAndOrnamentsEvent._parser = new MessageParser<TitlesAndOrnamentsEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00188FA0 File Offset: 0x001871A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ShntdMOKOt6GUNyqyqHN()
		{
			return true;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00188FA8 File Offset: 0x001871A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitlesAndOrnamentsEvent IERTZdOKJ3hapTa7Wm0U()
		{
			return null;
		}

		// Token: 0x040001AC RID: 428
		private static readonly MessageParser<TitlesAndOrnamentsEvent> _parser;

		// Token: 0x040001AD RID: 429
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001AE RID: 430
		public const int TitlesFieldNumber = 1;

		// Token: 0x040001AF RID: 431
		private static readonly FieldCodec<int> _repeated_titles_codec;

		// Token: 0x040001B0 RID: 432
		private readonly RepeatedField<int> titles_;

		// Token: 0x040001B1 RID: 433
		public const int OrnamentsFieldNumber = 2;

		// Token: 0x040001B2 RID: 434
		private static readonly FieldCodec<int> _repeated_ornaments_codec;

		// Token: 0x040001B3 RID: 435
		private readonly RepeatedField<int> ornaments_;

		// Token: 0x040001B4 RID: 436
		internal static TitlesAndOrnamentsEvent DKHsrpOKRZJ9PDt3gCIs;
	}
}
