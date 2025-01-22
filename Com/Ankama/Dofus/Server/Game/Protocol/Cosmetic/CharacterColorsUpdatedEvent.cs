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
	// Token: 0x02000C85 RID: 3205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterColorsUpdatedEvent : IMessage<CharacterColorsUpdatedEvent>, IMessage, IEquatable<CharacterColorsUpdatedEvent>, IDeepCloneable<CharacterColorsUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x0027C478 File Offset: 0x0027A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterColorsUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x0027C488 File Offset: 0x0027A688
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

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x0027C498 File Offset: 0x0027A698
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

		// Token: 0x060099E8 RID: 39400 RVA: 0x0027C4A8 File Offset: 0x0027A6A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColorsUpdatedEvent()
		{
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x0027C4B8 File Offset: 0x0027A6B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColorsUpdatedEvent(CharacterColorsUpdatedEvent other)
		{
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x0027C4C8 File Offset: 0x0027A6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterColorsUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x0027C4D8 File Offset: 0x0027A6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x0027C4E8 File Offset: 0x0027A6E8
		// (set) Token: 0x060099ED RID: 39405 RVA: 0x0027C4F8 File Offset: 0x0027A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
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

		// Token: 0x060099EE RID: 39406 RVA: 0x0027C508 File Offset: 0x0027A708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060099EF RID: 39407 RVA: 0x0027C518 File Offset: 0x0027A718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterColorsUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x0027C528 File Offset: 0x0027A728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060099F1 RID: 39409 RVA: 0x0027C538 File Offset: 0x0027A738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x0027C548 File Offset: 0x0027A748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x0027C558 File Offset: 0x0027A758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x0027C568 File Offset: 0x0027A768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x0027C578 File Offset: 0x0027A778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterColorsUpdatedEvent other)
		{
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x0027C588 File Offset: 0x0027A788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x0027C598 File Offset: 0x0027A798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x0027C5A8 File Offset: 0x0027A7A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterColorsUpdatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						CharacterColorsUpdatedEvent._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_CB;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					CharacterColorsUpdatedEvent._parser = new MessageParser<CharacterColorsUpdatedEvent>(() => null);
					num2 = 2;
				}
				IL_CB:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 5;
			}
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x0027C698 File Offset: 0x0027A898
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r1FytmJxnUQfpEtgQPq8()
		{
			return true;
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x0027C6A0 File Offset: 0x0027A8A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterColorsUpdatedEvent VLRhMtJxmJjcygSfQbS9()
		{
			return null;
		}

		// Token: 0x0400390E RID: 14606
		private static readonly MessageParser<CharacterColorsUpdatedEvent> _parser;

		// Token: 0x0400390F RID: 14607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003910 RID: 14608
		public const int ColorsFieldNumber = 1;

		// Token: 0x04003911 RID: 14609
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x04003912 RID: 14610
		private readonly RepeatedField<int> colors_;

		// Token: 0x04003913 RID: 14611
		public const int SlotFieldNumber = 2;

		// Token: 0x04003914 RID: 14612
		private int slot_;

		// Token: 0x04003915 RID: 14613
		internal static CharacterColorsUpdatedEvent w7uUHaJxfrmtwADuO7Bv;
	}
}
