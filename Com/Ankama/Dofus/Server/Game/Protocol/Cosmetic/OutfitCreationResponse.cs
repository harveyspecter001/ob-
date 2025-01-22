using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CC9 RID: 3273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitCreationResponse : IMessage<OutfitCreationResponse>, IMessage, IEquatable<OutfitCreationResponse>, IDeepCloneable<OutfitCreationResponse>, IBufferMessage
	{
		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x00282B1C File Offset: 0x00280D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitCreationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06009D6B RID: 40299 RVA: 0x00282B2C File Offset: 0x00280D2C
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

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x00282B3C File Offset: 0x00280D3C
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

		// Token: 0x06009D6D RID: 40301 RVA: 0x00282B4C File Offset: 0x00280D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreationResponse()
		{
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x00282B5C File Offset: 0x00280D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreationResponse(OutfitCreationResponse other)
		{
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x00282B6C File Offset: 0x00280D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreationResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x00282B7C File Offset: 0x00280D7C
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x00282B8C File Offset: 0x00280D8C
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

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x00282B9C File Offset: 0x00280D9C
		// (set) Token: 0x06009D73 RID: 40307 RVA: 0x00282BAC File Offset: 0x00280DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Outfit OutfitCreated
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

		// Token: 0x06009D74 RID: 40308 RVA: 0x00282BBC File Offset: 0x00280DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x00282BCC File Offset: 0x00280DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitCreationResponse other)
		{
			return true;
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x00282BDC File Offset: 0x00280DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x00282BEC File Offset: 0x00280DEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x00282BFC File Offset: 0x00280DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x00282C0C File Offset: 0x00280E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x00282C1C File Offset: 0x00280E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x00282C2C File Offset: 0x00280E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitCreationResponse other)
		{
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x00282C3C File Offset: 0x00280E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x00282C4C File Offset: 0x00280E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x00282C5C File Offset: 0x00280E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitCreationResponse()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					OutfitCreationResponse._parser = new MessageParser<OutfitCreationResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x00282D54 File Offset: 0x00280F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Toht2oJ4CrBS6DRQsaLy()
		{
			return true;
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x00282D5C File Offset: 0x00280F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitCreationResponse jhIw7CJ4DanpJLyQslWg()
		{
			return null;
		}

		// Token: 0x04003A56 RID: 14934
		private static readonly MessageParser<OutfitCreationResponse> _parser;

		// Token: 0x04003A57 RID: 14935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A58 RID: 14936
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A59 RID: 14937
		private bool success_;

		// Token: 0x04003A5A RID: 14938
		public const int OutfitCreatedFieldNumber = 2;

		// Token: 0x04003A5B RID: 14939
		private Outfit outfitCreated_;

		// Token: 0x04003A5C RID: 14940
		internal static OutfitCreationResponse XpWe4EJ40Cc3O6haU6vn;
	}
}
