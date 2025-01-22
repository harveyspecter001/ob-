using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005C1 RID: 1473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionItemListEvent : IMessage<GameActionItemListEvent>, IMessage, IEquatable<GameActionItemListEvent>, IDeepCloneable<GameActionItemListEvent>, IBufferMessage
	{
		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x001FDE10 File Offset: 0x001FC010
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionItemListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x001FDE20 File Offset: 0x001FC020
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

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600470A RID: 18186 RVA: 0x001FDE30 File Offset: 0x001FC030
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

		// Token: 0x0600470B RID: 18187 RVA: 0x001FDE40 File Offset: 0x001FC040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemListEvent()
		{
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x001FDE50 File Offset: 0x001FC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemListEvent(GameActionItemListEvent other)
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x001FDE60 File Offset: 0x001FC060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemListEvent Clone()
		{
			return null;
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x001FDE70 File Offset: 0x001FC070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameActionItem> Actions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x001FDE80 File Offset: 0x001FC080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x001FDE90 File Offset: 0x001FC090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionItemListEvent other)
		{
			return true;
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x001FDEA0 File Offset: 0x001FC0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x001FDEB0 File Offset: 0x001FC0B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x001FDEC0 File Offset: 0x001FC0C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x001FDED0 File Offset: 0x001FC0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x001FDEE0 File Offset: 0x001FC0E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x001FDEF0 File Offset: 0x001FC0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionItemListEvent other)
		{
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x001FDF00 File Offset: 0x001FC100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001FDF10 File Offset: 0x001FC110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x001FDF20 File Offset: 0x001FC120
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionItemListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GameActionItemListEvent._parser = new MessageParser<GameActionItemListEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					GameActionItemListEvent._repeated_actions_codec = FieldCodec.ForMessage<GameActionItem>(10U, jMIgFempOmLUqOrVdh1e.XVInXhlssT(jMIgFempOmLUqOrVdh1e.A9WmpJCHUqj));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x001FE028 File Offset: 0x001FC228
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x4ZJ2gOb04rUZvJlE1fm()
		{
			return true;
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x001FE030 File Offset: 0x001FC230
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionItemListEvent zTU55AObCLVETVE6YKmB()
		{
			return null;
		}

		// Token: 0x0400189E RID: 6302
		private static readonly MessageParser<GameActionItemListEvent> _parser;

		// Token: 0x0400189F RID: 6303
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018A0 RID: 6304
		public const int ActionsFieldNumber = 1;

		// Token: 0x040018A1 RID: 6305
		private static readonly FieldCodec<GameActionItem> _repeated_actions_codec;

		// Token: 0x040018A2 RID: 6306
		private readonly RepeatedField<GameActionItem> actions_;

		// Token: 0x040018A3 RID: 6307
		private static GameActionItemListEvent WCFMjYObVnpi03NOlFyA;
	}
}
