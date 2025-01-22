using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008BD RID: 2237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChoiceSelectionEvent : IMessage<ChoiceSelectionEvent>, IMessage, IEquatable<ChoiceSelectionEvent>, IDeepCloneable<ChoiceSelectionEvent>, IBufferMessage
	{
		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x002335D0 File Offset: 0x002317D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChoiceSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06006CAA RID: 27818 RVA: 0x002335E0 File Offset: 0x002317E0
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

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x002335F0 File Offset: 0x002317F0
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

		// Token: 0x06006CAC RID: 27820 RVA: 0x00233600 File Offset: 0x00231800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectionEvent()
		{
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00233610 File Offset: 0x00231810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectionEvent(ChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x00233620 File Offset: 0x00231820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChoiceSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x00233630 File Offset: 0x00231830
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x00233640 File Offset: 0x00231840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
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

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x00233650 File Offset: 0x00231850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Choice> Choices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00233660 File Offset: 0x00231860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00233670 File Offset: 0x00231870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChoiceSelectionEvent other)
		{
			return true;
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00233680 File Offset: 0x00231880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00233690 File Offset: 0x00231890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x002336A0 File Offset: 0x002318A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x002336B0 File Offset: 0x002318B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x002336C0 File Offset: 0x002318C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x002336D0 File Offset: 0x002318D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x002336E0 File Offset: 0x002318E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x002336F0 File Offset: 0x002318F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00233700 File Offset: 0x00231900
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChoiceSelectionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					ChoiceSelectionEvent._parser = new MessageParser<ChoiceSelectionEvent>(() => null);
					num2 = 5;
					continue;
				case 5:
					ChoiceSelectionEvent._repeated_choices_codec = FieldCodec.ForMessage<Choice>(18U, XAvjf4AFsp8kAsD4PKSO.XVInXhlssT(XAvjf4AFsp8kAsD4PKSO.dZLAFd1pAov));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x0023381C File Offset: 0x00231A1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s0bsTkJAstiYQY60pPLi()
		{
			return true;
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x00233824 File Offset: 0x00231A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChoiceSelectionEvent mkVY3hJAdCkGcoJf5B6F()
		{
			return null;
		}

		// Token: 0x040025E5 RID: 9701
		private static readonly MessageParser<ChoiceSelectionEvent> _parser;

		// Token: 0x040025E6 RID: 9702
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025E7 RID: 9703
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x040025E8 RID: 9704
		private int selectionId_;

		// Token: 0x040025E9 RID: 9705
		public const int ChoicesFieldNumber = 2;

		// Token: 0x040025EA RID: 9706
		private static readonly FieldCodec<Choice> _repeated_choices_codec;

		// Token: 0x040025EB RID: 9707
		private readonly RepeatedField<Choice> choices_;

		// Token: 0x040025EC RID: 9708
		internal static ChoiceSelectionEvent RV5kSmJAgQGdj3Ae6MYh;
	}
}
