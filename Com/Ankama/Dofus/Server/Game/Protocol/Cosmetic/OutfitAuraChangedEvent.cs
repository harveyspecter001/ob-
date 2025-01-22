using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CA7 RID: 3239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitAuraChangedEvent : IMessage<OutfitAuraChangedEvent>, IMessage, IEquatable<OutfitAuraChangedEvent>, IDeepCloneable<OutfitAuraChangedEvent>, IBufferMessage
	{
		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06009B8A RID: 39818 RVA: 0x002804EC File Offset: 0x0027E6EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitAuraChangedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x002804FC File Offset: 0x0027E6FC
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

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x0028050C File Offset: 0x0027E70C
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

		// Token: 0x06009B8D RID: 39821 RVA: 0x0028051C File Offset: 0x0027E71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitAuraChangedEvent()
		{
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0028052C File Offset: 0x0027E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitAuraChangedEvent(OutfitAuraChangedEvent other)
		{
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x0028053C File Offset: 0x0027E73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitAuraChangedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0028054C File Offset: 0x0027E74C
		// (set) Token: 0x06009B91 RID: 39825 RVA: 0x0028055C File Offset: 0x0027E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x0028056C File Offset: 0x0027E76C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasEmoteId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x0028057C File Offset: 0x0027E77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEmoteId()
		{
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x0028058C File Offset: 0x0027E78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x0028059C File Offset: 0x0027E79C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitAuraChangedEvent other)
		{
			return true;
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x002805AC File Offset: 0x0027E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x002805BC File Offset: 0x0027E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x002805CC File Offset: 0x0027E7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x002805DC File Offset: 0x0027E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x002805EC File Offset: 0x0027E7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009B9B RID: 39835 RVA: 0x002805FC File Offset: 0x0027E7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitAuraChangedEvent other)
		{
		}

		// Token: 0x06009B9C RID: 39836 RVA: 0x0028060C File Offset: 0x0027E80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009B9D RID: 39837 RVA: 0x0028061C File Offset: 0x0027E81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009B9E RID: 39838 RVA: 0x0028062C File Offset: 0x0027E82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitAuraChangedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OutfitAuraChangedEvent._parser = new MessageParser<OutfitAuraChangedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					OutfitAuraChangedEvent.EmoteIdDefaultValue = 0;
					num2 = 4;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x00280724 File Offset: 0x0027E924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s0od7WJxiL3AE82hCOMA()
		{
			return true;
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x0028072C File Offset: 0x0027E92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitAuraChangedEvent a4w8QFJxP2cbgwFE06p3()
		{
			return null;
		}

		// Token: 0x040039BA RID: 14778
		private static readonly MessageParser<OutfitAuraChangedEvent> _parser;

		// Token: 0x040039BB RID: 14779
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039BC RID: 14780
		private int _hasBits0;

		// Token: 0x040039BD RID: 14781
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x040039BE RID: 14782
		private static readonly int EmoteIdDefaultValue;

		// Token: 0x040039BF RID: 14783
		private int emoteId_;

		// Token: 0x040039C0 RID: 14784
		internal static OutfitAuraChangedEvent fJyEsFJxbrxAaTimaKJc;
	}
}
