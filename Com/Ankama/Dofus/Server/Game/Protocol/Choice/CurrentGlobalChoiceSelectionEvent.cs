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
	// Token: 0x020008C3 RID: 2243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CurrentGlobalChoiceSelectionEvent : IMessage<CurrentGlobalChoiceSelectionEvent>, IMessage, IEquatable<CurrentGlobalChoiceSelectionEvent>, IDeepCloneable<CurrentGlobalChoiceSelectionEvent>, IBufferMessage
	{
		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x00233CB8 File Offset: 0x00231EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CurrentGlobalChoiceSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x00233CC8 File Offset: 0x00231EC8
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

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x00233CD8 File Offset: 0x00231ED8
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

		// Token: 0x06006CFE RID: 27902 RVA: 0x00233CE8 File Offset: 0x00231EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurrentGlobalChoiceSelectionEvent()
		{
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x00233CF8 File Offset: 0x00231EF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurrentGlobalChoiceSelectionEvent(CurrentGlobalChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x00233D08 File Offset: 0x00231F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurrentGlobalChoiceSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x00233D18 File Offset: 0x00231F18
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x00233D28 File Offset: 0x00231F28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x00233D38 File Offset: 0x00231F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VotedChoice> Choices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00233D48 File Offset: 0x00231F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x00233D58 File Offset: 0x00231F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CurrentGlobalChoiceSelectionEvent other)
		{
			return true;
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x00233D68 File Offset: 0x00231F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x00233D78 File Offset: 0x00231F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x00233D88 File Offset: 0x00231F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x00233D98 File Offset: 0x00231F98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00233DA8 File Offset: 0x00231FA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x00233DB8 File Offset: 0x00231FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CurrentGlobalChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00233DC8 File Offset: 0x00231FC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00233DD8 File Offset: 0x00231FD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00233DE8 File Offset: 0x00231FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CurrentGlobalChoiceSelectionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
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
						goto IL_D4;
					case 3:
						goto IL_5E;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						CurrentGlobalChoiceSelectionEvent._repeated_choices_codec = FieldCodec.ForMessage<VotedChoice>(18U, KAbPvYAF9mdldjg04jP8.XVInXhlssT(KAbPvYAF9mdldjg04jP8.PT6AF2mRR6Q));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					CurrentGlobalChoiceSelectionEvent._parser = new MessageParser<CurrentGlobalChoiceSelectionEvent>(() => null);
					num2 = 5;
				}
				IL_5E:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
				continue;
				IL_D4:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00233EE0 File Offset: 0x002320E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool omN8yiJAj2QwVejsvHBs()
		{
			return true;
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00233EE8 File Offset: 0x002320E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CurrentGlobalChoiceSelectionEvent oYYqQgJAKDoPlfNZnoTv()
		{
			return null;
		}

		// Token: 0x04002602 RID: 9730
		private static readonly MessageParser<CurrentGlobalChoiceSelectionEvent> _parser;

		// Token: 0x04002603 RID: 9731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002604 RID: 9732
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x04002605 RID: 9733
		private int selectionId_;

		// Token: 0x04002606 RID: 9734
		public const int ChoicesFieldNumber = 2;

		// Token: 0x04002607 RID: 9735
		private static readonly FieldCodec<VotedChoice> _repeated_choices_codec;

		// Token: 0x04002608 RID: 9736
		private readonly RepeatedField<VotedChoice> choices_;

		// Token: 0x04002609 RID: 9737
		private static CurrentGlobalChoiceSelectionEvent UOADwQJA4bneDkpRtYn0;
	}
}
