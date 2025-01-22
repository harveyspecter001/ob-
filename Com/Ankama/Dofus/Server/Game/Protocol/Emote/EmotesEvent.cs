using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007BB RID: 1979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmotesEvent : IMessage<EmotesEvent>, IMessage, IEquatable<EmotesEvent>, IDeepCloneable<EmotesEvent>, IBufferMessage
	{
		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060060F7 RID: 24823 RVA: 0x002205D8 File Offset: 0x0021E7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EmotesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060060F8 RID: 24824 RVA: 0x002205E8 File Offset: 0x0021E7E8
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

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x002205F8 File Offset: 0x0021E7F8
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

		// Token: 0x060060FA RID: 24826 RVA: 0x00220608 File Offset: 0x0021E808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotesEvent()
		{
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00220618 File Offset: 0x0021E818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotesEvent(EmotesEvent other)
		{
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00220628 File Offset: 0x0021E828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x00220638 File Offset: 0x0021E838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EmotesId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00220648 File Offset: 0x0021E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x00220658 File Offset: 0x0021E858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmotesEvent other)
		{
			return true;
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x00220668 File Offset: 0x0021E868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00220678 File Offset: 0x0021E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x00220688 File Offset: 0x0021E888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x00220698 File Offset: 0x0021E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x002206A8 File Offset: 0x0021E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x002206B8 File Offset: 0x0021E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmotesEvent other)
		{
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x002206C8 File Offset: 0x0021E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x002206D8 File Offset: 0x0021E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x002206E8 File Offset: 0x0021E8E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmotesEvent()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					EmotesEvent._repeated_emotesId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					EmotesEvent._parser = new MessageParser<EmotesEvent>(() => null);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x002207E8 File Offset: 0x0021E9E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RX0ELGOq8b7wBvZy1nWs()
		{
			return true;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x002207F0 File Offset: 0x0021E9F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmotesEvent wF4gIkOqZuZ7Vo5l6RwG()
		{
			return null;
		}

		// Token: 0x04002217 RID: 8727
		private static readonly MessageParser<EmotesEvent> _parser;

		// Token: 0x04002218 RID: 8728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002219 RID: 8729
		public const int EmotesIdFieldNumber = 1;

		// Token: 0x0400221A RID: 8730
		private static readonly FieldCodec<int> _repeated_emotesId_codec;

		// Token: 0x0400221B RID: 8731
		private readonly RepeatedField<int> emotesId_;

		// Token: 0x0400221C RID: 8732
		internal static EmotesEvent LKRwB7Oqu2bmAsuC4gO3;
	}
}
