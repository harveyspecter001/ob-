using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C99 RID: 3225
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryAddObjectResponse : IMessage<CosmeticInventoryAddObjectResponse>, IMessage, IEquatable<CosmeticInventoryAddObjectResponse>, IDeepCloneable<CosmeticInventoryAddObjectResponse>, IBufferMessage
	{
		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x0027F858 File Offset: 0x0027DA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CosmeticInventoryAddObjectResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06009AEC RID: 39660 RVA: 0x0027F868 File Offset: 0x0027DA68
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

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06009AED RID: 39661 RVA: 0x0027F878 File Offset: 0x0027DA78
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

		// Token: 0x06009AEE RID: 39662 RVA: 0x0027F888 File Offset: 0x0027DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectResponse()
		{
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x0027F898 File Offset: 0x0027DA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectResponse(CosmeticInventoryAddObjectResponse other)
		{
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x0027F8A8 File Offset: 0x0027DAA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryAddObjectResponse Clone()
		{
			return null;
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x0027F8B8 File Offset: 0x0027DAB8
		// (set) Token: 0x06009AF2 RID: 39666 RVA: 0x0027F8CC File Offset: 0x0027DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CosmeticInventoryAddObjectResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CosmeticInventoryAddObjectResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x0027F8DC File Offset: 0x0027DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x0027F8EC File Offset: 0x0027DAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryAddObjectResponse other)
		{
			return true;
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x0027F8FC File Offset: 0x0027DAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x0027F90C File Offset: 0x0027DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x0027F91C File Offset: 0x0027DB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x0027F92C File Offset: 0x0027DB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x0027F93C File Offset: 0x0027DB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x0027F94C File Offset: 0x0027DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryAddObjectResponse other)
		{
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x0027F95C File Offset: 0x0027DB5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x0027F96C File Offset: 0x0027DB6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x0027F97C File Offset: 0x0027DB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryAddObjectResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					CosmeticInventoryAddObjectResponse._parser = new MessageParser<CosmeticInventoryAddObjectResponse>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x0027FA60 File Offset: 0x0027DC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ROTwkaJx6fsOrWvYhuHF()
		{
			return true;
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x0027FA68 File Offset: 0x0027DC68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryAddObjectResponse wYObMuJxLGt2f5Oj0HcQ()
		{
			return null;
		}

		// Token: 0x0400398A RID: 14730
		private static readonly MessageParser<CosmeticInventoryAddObjectResponse> _parser;

		// Token: 0x0400398B RID: 14731
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400398C RID: 14732
		public const int ResultFieldNumber = 1;

		// Token: 0x0400398D RID: 14733
		private CosmeticInventoryAddObjectResponse.Types.Result result_;

		// Token: 0x0400398E RID: 14734
		private static CosmeticInventoryAddObjectResponse uGwfjGJxyYO6IoqAyPx5;

		// Token: 0x02000C9A RID: 3226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06009B00 RID: 39680 RVA: 0x002EA2D4 File Offset: 0x002E84D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C9B RID: 3227
			public enum Result
			{
				// Token: 0x04003990 RID: 14736
				[OriginalName("ERROR")]
				Error,
				// Token: 0x04003991 RID: 14737
				[OriginalName("DUPLICATE")]
				Duplicate,
				// Token: 0x04003992 RID: 14738
				[OriginalName("SUCCESS")]
				Success
			}
		}
	}
}
