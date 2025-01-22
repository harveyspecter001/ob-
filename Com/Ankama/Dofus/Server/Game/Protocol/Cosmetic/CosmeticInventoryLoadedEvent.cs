using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C95 RID: 3221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CosmeticInventoryLoadedEvent : IMessage<CosmeticInventoryLoadedEvent>, IMessage, IEquatable<CosmeticInventoryLoadedEvent>, IDeepCloneable<CosmeticInventoryLoadedEvent>, IBufferMessage
	{
		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06009AB8 RID: 39608 RVA: 0x0027F434 File Offset: 0x0027D634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CosmeticInventoryLoadedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x0027F444 File Offset: 0x0027D644
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

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x0027F454 File Offset: 0x0027D654
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

		// Token: 0x06009ABB RID: 39611 RVA: 0x0027F464 File Offset: 0x0027D664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryLoadedEvent()
		{
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x0027F474 File Offset: 0x0027D674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryLoadedEvent(CosmeticInventoryLoadedEvent other)
		{
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x0027F484 File Offset: 0x0027D684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CosmeticInventoryLoadedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06009ABE RID: 39614 RVA: 0x0027F494 File Offset: 0x0027D694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItem> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x0027F4A4 File Offset: 0x0027D6A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x0027F4B4 File Offset: 0x0027D6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CosmeticInventoryLoadedEvent other)
		{
			return true;
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x0027F4C4 File Offset: 0x0027D6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x0027F4D4 File Offset: 0x0027D6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x0027F4E4 File Offset: 0x0027D6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x0027F4F4 File Offset: 0x0027D6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x0027F504 File Offset: 0x0027D704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x0027F514 File Offset: 0x0027D714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CosmeticInventoryLoadedEvent other)
		{
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x0027F524 File Offset: 0x0027D724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x0027F534 File Offset: 0x0027D734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x0027F544 File Offset: 0x0027D744
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CosmeticInventoryLoadedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CosmeticInventoryLoadedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItem>(10U, nltnaGBl3L2ejkRk2AUZ.XVInXhlssT(nltnaGBl3L2ejkRk2AUZ.YplBlRflj3N));
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
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
					return;
				case 5:
					CosmeticInventoryLoadedEvent._parser = new MessageParser<CosmeticInventoryLoadedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x0027F634 File Offset: 0x0027D834
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jLBLNuJxvh5tVSNJAWnl()
		{
			return true;
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x0027F63C File Offset: 0x0027D83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CosmeticInventoryLoadedEvent hIfklMJxoq7bS8eLL6YO()
		{
			return null;
		}

		// Token: 0x0400397B RID: 14715
		private static readonly MessageParser<CosmeticInventoryLoadedEvent> _parser;

		// Token: 0x0400397C RID: 14716
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400397D RID: 14717
		public const int ObjectsFieldNumber = 1;

		// Token: 0x0400397E RID: 14718
		private static readonly FieldCodec<ObjectItem> _repeated_objects_codec;

		// Token: 0x0400397F RID: 14719
		private readonly RepeatedField<ObjectItem> objects_;

		// Token: 0x04003980 RID: 14720
		internal static CosmeticInventoryLoadedEvent nPKciHJxU1ncoYQvXu4X;
	}
}
