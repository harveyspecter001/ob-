using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C9F RID: 3231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryPopObjectResponse : IMessage<CosmeticInventoryPopObjectResponse>, IMessage, IEquatable<CosmeticInventoryPopObjectResponse>, IDeepCloneable<CosmeticInventoryPopObjectResponse>, IBufferMessage
	{
		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x0027FC98 File Offset: 0x0027DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CosmeticInventoryPopObjectResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x0027FCA8 File Offset: 0x0027DEA8
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

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06009B22 RID: 39714 RVA: 0x0027FCB8 File Offset: 0x0027DEB8
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

		// Token: 0x06009B23 RID: 39715 RVA: 0x0027FCC8 File Offset: 0x0027DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectResponse()
		{
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x0027FCD8 File Offset: 0x0027DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectResponse(CosmeticInventoryPopObjectResponse other)
		{
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x0027FCE8 File Offset: 0x0027DEE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryPopObjectResponse Clone()
		{
			return null;
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x0027FCF8 File Offset: 0x0027DEF8
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x0027FD08 File Offset: 0x0027DF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
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

		// Token: 0x06009B28 RID: 39720 RVA: 0x0027FD18 File Offset: 0x0027DF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0027FD28 File Offset: 0x0027DF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryPopObjectResponse other)
		{
			return true;
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x0027FD38 File Offset: 0x0027DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x0027FD48 File Offset: 0x0027DF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x0027FD58 File Offset: 0x0027DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x0027FD68 File Offset: 0x0027DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x0027FD78 File Offset: 0x0027DF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x0027FD88 File Offset: 0x0027DF88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryPopObjectResponse other)
		{
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x0027FD98 File Offset: 0x0027DF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x0027FDA8 File Offset: 0x0027DFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x0027FDB8 File Offset: 0x0027DFB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryPopObjectResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					CosmeticInventoryPopObjectResponse._parser = new MessageParser<CosmeticInventoryPopObjectResponse>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x0027FE84 File Offset: 0x0027E084
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CVjwRdJx0sbnI6L4ARWP()
		{
			return true;
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x0027FE8C File Offset: 0x0027E08C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryPopObjectResponse KEpYsWJxCvFlEkMqS8Ke()
		{
			return null;
		}

		// Token: 0x0400399C RID: 14748
		private static readonly MessageParser<CosmeticInventoryPopObjectResponse> _parser;

		// Token: 0x0400399D RID: 14749
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400399E RID: 14750
		public const int SuccessFieldNumber = 1;

		// Token: 0x0400399F RID: 14751
		private bool success_;

		// Token: 0x040039A0 RID: 14752
		internal static CosmeticInventoryPopObjectResponse FcvW0aJxV4rxa36MnmNe;
	}
}
