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
	// Token: 0x020008C5 RID: 2245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GlobalChoiceSelectionEvent : IMessage<GlobalChoiceSelectionEvent>, IMessage, IEquatable<GlobalChoiceSelectionEvent>, IDeepCloneable<GlobalChoiceSelectionEvent>, IBufferMessage
	{
		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06006D16 RID: 27926 RVA: 0x00233EF0 File Offset: 0x002320F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GlobalChoiceSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x00233F00 File Offset: 0x00232100
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

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06006D18 RID: 27928 RVA: 0x00233F10 File Offset: 0x00232110
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

		// Token: 0x06006D19 RID: 27929 RVA: 0x00233F20 File Offset: 0x00232120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectionEvent()
		{
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x00233F30 File Offset: 0x00232130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectionEvent(GlobalChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x00233F40 File Offset: 0x00232140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06006D1C RID: 27932 RVA: 0x00233F50 File Offset: 0x00232150
		// (set) Token: 0x06006D1D RID: 27933 RVA: 0x00233F60 File Offset: 0x00232160
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

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06006D1E RID: 27934 RVA: 0x00233F70 File Offset: 0x00232170
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

		// Token: 0x06006D1F RID: 27935 RVA: 0x00233F80 File Offset: 0x00232180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x00233F90 File Offset: 0x00232190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GlobalChoiceSelectionEvent other)
		{
			return true;
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00233FA0 File Offset: 0x002321A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00233FB0 File Offset: 0x002321B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00233FC0 File Offset: 0x002321C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00233FD0 File Offset: 0x002321D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00233FE0 File Offset: 0x002321E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00233FF0 File Offset: 0x002321F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GlobalChoiceSelectionEvent other)
		{
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00234000 File Offset: 0x00232200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x00234010 File Offset: 0x00232210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00234020 File Offset: 0x00232220
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalChoiceSelectionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					GlobalChoiceSelectionEvent._repeated_choices_codec = FieldCodec.ForMessage<Choice>(18U, XAvjf4AFsp8kAsD4PKSO.XVInXhlssT(XAvjf4AFsp8kAsD4PKSO.dZLAFd1pAov));
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					break;
				case 5:
					GlobalChoiceSelectionEvent._parser = new MessageParser<GlobalChoiceSelectionEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00234110 File Offset: 0x00232310
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qPr6ynJAkk4iPNIJBulW()
		{
			return true;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00234118 File Offset: 0x00232318
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GlobalChoiceSelectionEvent qCyBgTJAl5wE6lW72lgG()
		{
			return null;
		}

		// Token: 0x0400260C RID: 9740
		private static readonly MessageParser<GlobalChoiceSelectionEvent> _parser;

		// Token: 0x0400260D RID: 9741
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400260E RID: 9742
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x0400260F RID: 9743
		private int selectionId_;

		// Token: 0x04002610 RID: 9744
		public const int ChoicesFieldNumber = 2;

		// Token: 0x04002611 RID: 9745
		private static readonly FieldCodec<Choice> _repeated_choices_codec;

		// Token: 0x04002612 RID: 9746
		private readonly RepeatedField<Choice> choices_;

		// Token: 0x04002613 RID: 9747
		private static GlobalChoiceSelectionEvent HjWi5aJAIPkZBLb8vWC9;
	}
}
