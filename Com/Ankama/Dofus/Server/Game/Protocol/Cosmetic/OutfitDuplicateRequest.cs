using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CC7 RID: 3271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitDuplicateRequest : IMessage<OutfitDuplicateRequest>, IMessage, IEquatable<OutfitDuplicateRequest>, IDeepCloneable<OutfitDuplicateRequest>, IBufferMessage
	{
		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06009D4C RID: 40268 RVA: 0x002828B4 File Offset: 0x00280AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitDuplicateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x002828C4 File Offset: 0x00280AC4
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

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06009D4E RID: 40270 RVA: 0x002828D4 File Offset: 0x00280AD4
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

		// Token: 0x06009D4F RID: 40271 RVA: 0x002828E4 File Offset: 0x00280AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitDuplicateRequest()
		{
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x002828F4 File Offset: 0x00280AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitDuplicateRequest(OutfitDuplicateRequest other)
		{
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x00282904 File Offset: 0x00280B04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitDuplicateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x00282914 File Offset: 0x00280B14
		// (set) Token: 0x06009D53 RID: 40275 RVA: 0x00282924 File Offset: 0x00280B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutfitUuid
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

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x00282934 File Offset: 0x00280B34
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x00282944 File Offset: 0x00280B44
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

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x00282954 File Offset: 0x00280B54
		// (set) Token: 0x06009D57 RID: 40279 RVA: 0x00282964 File Offset: 0x00280B64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PictogramId
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

		// Token: 0x06009D58 RID: 40280 RVA: 0x00282974 File Offset: 0x00280B74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x00282984 File Offset: 0x00280B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitDuplicateRequest other)
		{
			return true;
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x00282994 File Offset: 0x00280B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x002829A4 File Offset: 0x00280BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x002829B4 File Offset: 0x00280BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x002829C4 File Offset: 0x00280BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x002829D4 File Offset: 0x00280BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x002829E4 File Offset: 0x00280BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitDuplicateRequest other)
		{
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x002829F4 File Offset: 0x00280BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x00282A04 File Offset: 0x00280C04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x00282A14 File Offset: 0x00280C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitDuplicateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OutfitDuplicateRequest._parser = new MessageParser<OutfitDuplicateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x00282B0C File Offset: 0x00280D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R8pJnsJ4rqLNxdJxFlPr()
		{
			return true;
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x00282B14 File Offset: 0x00280D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitDuplicateRequest Yx0OIpJ4VYboCUNlBJsr()
		{
			return null;
		}

		// Token: 0x04003A4B RID: 14923
		private static readonly MessageParser<OutfitDuplicateRequest> _parser;

		// Token: 0x04003A4C RID: 14924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A4D RID: 14925
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x04003A4E RID: 14926
		private string outfitUuid_;

		// Token: 0x04003A4F RID: 14927
		public const int NameFieldNumber = 2;

		// Token: 0x04003A50 RID: 14928
		private string name_;

		// Token: 0x04003A51 RID: 14929
		public const int PictogramIdFieldNumber = 3;

		// Token: 0x04003A52 RID: 14930
		private int pictogramId_;

		// Token: 0x04003A53 RID: 14931
		private static OutfitDuplicateRequest JaITpGJ4hMJku3sITYgG;
	}
}
