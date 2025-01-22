using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005C5 RID: 1477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionSpamEvent : IMessage<GameActionSpamEvent>, IMessage, IEquatable<GameActionSpamEvent>, IDeepCloneable<GameActionSpamEvent>, IBufferMessage
	{
		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x001FE274 File Offset: 0x001FC474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameActionSpamEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x001FE284 File Offset: 0x001FC484
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x001FE294 File Offset: 0x001FC494
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

		// Token: 0x06004742 RID: 18242 RVA: 0x001FE2A4 File Offset: 0x001FC4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionSpamEvent()
		{
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x001FE2B4 File Offset: 0x001FC4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionSpamEvent(GameActionSpamEvent other)
		{
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x001FE2C4 File Offset: 0x001FC4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionSpamEvent Clone()
		{
			return null;
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x001FE2D4 File Offset: 0x001FC4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Cells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x001FE2E4 File Offset: 0x001FC4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x001FE2F4 File Offset: 0x001FC4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionSpamEvent other)
		{
			return true;
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x001FE304 File Offset: 0x001FC504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x001FE314 File Offset: 0x001FC514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x001FE324 File Offset: 0x001FC524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x001FE334 File Offset: 0x001FC534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x001FE344 File Offset: 0x001FC544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x001FE354 File Offset: 0x001FC554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionSpamEvent other)
		{
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x001FE364 File Offset: 0x001FC564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x001FE374 File Offset: 0x001FC574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x001FE384 File Offset: 0x001FC584
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionSpamEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					GameActionSpamEvent._repeated_cells_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				GameActionSpamEvent._parser = new MessageParser<GameActionSpamEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x001FE470 File Offset: 0x001FC670
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YRhxcxOb7WwFN6tuO28P()
		{
			return true;
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x001FE478 File Offset: 0x001FC678
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionSpamEvent TRxos1ObT9Say4tUGuLG()
		{
			return null;
		}

		// Token: 0x040018B1 RID: 6321
		private static readonly MessageParser<GameActionSpamEvent> _parser;

		// Token: 0x040018B2 RID: 6322
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018B3 RID: 6323
		public const int CellsFieldNumber = 1;

		// Token: 0x040018B4 RID: 6324
		private static readonly FieldCodec<int> _repeated_cells_codec;

		// Token: 0x040018B5 RID: 6325
		private readonly RepeatedField<int> cells_;

		// Token: 0x040018B6 RID: 6326
		private static GameActionSpamEvent MMbx7xObQuoIPPCZMflj;
	}
}
