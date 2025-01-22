using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CC3 RID: 3267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitUpdateResponse : IMessage<OutfitUpdateResponse>, IMessage, IEquatable<OutfitUpdateResponse>, IDeepCloneable<OutfitUpdateResponse>, IBufferMessage
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06009D12 RID: 40210 RVA: 0x00282444 File Offset: 0x00280644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06009D13 RID: 40211 RVA: 0x00282454 File Offset: 0x00280654
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

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06009D14 RID: 40212 RVA: 0x00282464 File Offset: 0x00280664
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

		// Token: 0x06009D15 RID: 40213 RVA: 0x00282474 File Offset: 0x00280674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateResponse()
		{
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x00282484 File Offset: 0x00280684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateResponse(OutfitUpdateResponse other)
		{
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x00282494 File Offset: 0x00280694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06009D18 RID: 40216 RVA: 0x002824A4 File Offset: 0x002806A4
		// (set) Token: 0x06009D19 RID: 40217 RVA: 0x002824B4 File Offset: 0x002806B4
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

		// Token: 0x06009D1A RID: 40218 RVA: 0x002824C4 File Offset: 0x002806C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x002824D4 File Offset: 0x002806D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x002824E4 File Offset: 0x002806E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x002824F4 File Offset: 0x002806F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x00282504 File Offset: 0x00280704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x00282514 File Offset: 0x00280714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x00282524 File Offset: 0x00280724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x00282534 File Offset: 0x00280734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitUpdateResponse other)
		{
		}

		// Token: 0x06009D22 RID: 40226 RVA: 0x00282544 File Offset: 0x00280744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x00282554 File Offset: 0x00280754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x00282564 File Offset: 0x00280764
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitUpdateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					OutfitUpdateResponse._parser = new MessageParser<OutfitUpdateResponse>(() => null);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x00282630 File Offset: 0x00280830
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AooHgAJ45msplKBDjYEV()
		{
			return true;
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x00282638 File Offset: 0x00280838
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitUpdateResponse Y2XIK1J4yEua94mD7W19()
		{
			return null;
		}

		// Token: 0x04003A37 RID: 14903
		private static readonly MessageParser<OutfitUpdateResponse> _parser;

		// Token: 0x04003A38 RID: 14904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A39 RID: 14905
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A3A RID: 14906
		private bool success_;

		// Token: 0x04003A3B RID: 14907
		internal static OutfitUpdateResponse hEPbgDJ4aIuHd4S6jI7x;
	}
}
