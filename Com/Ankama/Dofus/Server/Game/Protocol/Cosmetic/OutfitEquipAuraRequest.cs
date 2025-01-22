using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CA3 RID: 3235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipAuraRequest : IMessage<OutfitEquipAuraRequest>, IMessage, IEquatable<OutfitEquipAuraRequest>, IDeepCloneable<OutfitEquipAuraRequest>, IBufferMessage
	{
		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x002800A8 File Offset: 0x0027E2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipAuraRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06009B55 RID: 39765 RVA: 0x002800B8 File Offset: 0x0027E2B8
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

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06009B56 RID: 39766 RVA: 0x002800C8 File Offset: 0x0027E2C8
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

		// Token: 0x06009B57 RID: 39767 RVA: 0x002800D8 File Offset: 0x0027E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraRequest()
		{
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x002800E8 File Offset: 0x0027E2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraRequest(OutfitEquipAuraRequest other)
		{
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x002800F8 File Offset: 0x0027E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipAuraRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06009B5A RID: 39770 RVA: 0x00280108 File Offset: 0x0027E308
		// (set) Token: 0x06009B5B RID: 39771 RVA: 0x00280118 File Offset: 0x0027E318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EmoteId
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

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06009B5C RID: 39772 RVA: 0x00280128 File Offset: 0x0027E328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEmoteId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00280138 File Offset: 0x0027E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEmoteId()
		{
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00280148 File Offset: 0x0027E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00280158 File Offset: 0x0027E358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipAuraRequest other)
		{
			return true;
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x00280168 File Offset: 0x0027E368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x00280178 File Offset: 0x0027E378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B62 RID: 39778 RVA: 0x00280188 File Offset: 0x0027E388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x00280198 File Offset: 0x0027E398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x002801A8 File Offset: 0x0027E3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x002801B8 File Offset: 0x0027E3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipAuraRequest other)
		{
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x002801C8 File Offset: 0x0027E3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x002801D8 File Offset: 0x0027E3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x002801E8 File Offset: 0x0027E3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipAuraRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					OutfitEquipAuraRequest._parser = new MessageParser<OutfitEquipAuraRequest>(() => null);
					num2 = 3;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OutfitEquipAuraRequest.EmoteIdDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x002802C8 File Offset: 0x0027E4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KyKAXSJx7ojQp1fEvTfF()
		{
			return true;
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x002802D0 File Offset: 0x0027E4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipAuraRequest E1gu5cJxT3DkmxN5hO91()
		{
			return null;
		}

		// Token: 0x040039AA RID: 14762
		private static readonly MessageParser<OutfitEquipAuraRequest> _parser;

		// Token: 0x040039AB RID: 14763
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039AC RID: 14764
		private int _hasBits0;

		// Token: 0x040039AD RID: 14765
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x040039AE RID: 14766
		private static readonly int EmoteIdDefaultValue;

		// Token: 0x040039AF RID: 14767
		private int emoteId_;

		// Token: 0x040039B0 RID: 14768
		private static OutfitEquipAuraRequest hpvljqJxQHil5dkw7Tuf;
	}
}
