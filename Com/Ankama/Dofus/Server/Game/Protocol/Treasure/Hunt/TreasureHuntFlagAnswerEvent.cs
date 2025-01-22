using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000063 RID: 99
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntFlagAnswerEvent : IMessage<TreasureHuntFlagAnswerEvent>, IMessage, IEquatable<TreasureHuntFlagAnswerEvent>, IDeepCloneable<TreasureHuntFlagAnswerEvent>, IBufferMessage
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00188244 File Offset: 0x00186444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureHuntFlagAnswerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00188254 File Offset: 0x00186454
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00188264 File Offset: 0x00186464
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

		// Token: 0x060003E5 RID: 997 RVA: 0x00188274 File Offset: 0x00186474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagAnswerEvent()
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00188284 File Offset: 0x00186484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagAnswerEvent(TreasureHuntFlagAnswerEvent other)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00188294 File Offset: 0x00186494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagAnswerEvent Clone()
		{
			return null;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x001882A4 File Offset: 0x001864A4
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x001882B8 File Offset: 0x001864B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntType QuestType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x001882C8 File Offset: 0x001864C8
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x001882DC File Offset: 0x001864DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntFlagAnswerEvent.Types.FlagResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntFlagAnswerEvent.Types.FlagResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x001882EC File Offset: 0x001864EC
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x001882FC File Offset: 0x001864FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
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

		// Token: 0x060003EE RID: 1006 RVA: 0x0018830C File Offset: 0x0018650C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0018831C File Offset: 0x0018651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntFlagAnswerEvent other)
		{
			return true;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0018832C File Offset: 0x0018652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0018833C File Offset: 0x0018653C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0018834C File Offset: 0x0018654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0018835C File Offset: 0x0018655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0018836C File Offset: 0x0018656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0018837C File Offset: 0x0018657C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntFlagAnswerEvent other)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0018838C File Offset: 0x0018658C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0018839C File Offset: 0x0018659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x001883AC File Offset: 0x001865AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntFlagAnswerEvent()
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
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					break;
				}
				IL_88:
				TreasureHuntFlagAnswerEvent._parser = new MessageParser<TreasureHuntFlagAnswerEvent>(() => null);
				num = 2;
				continue;
				goto IL_88;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00188494 File Offset: 0x00186694
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eXqWRNOjZelwXmY5vYEa()
		{
			return true;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0018849C File Offset: 0x0018669C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntFlagAnswerEvent weVAr7OjqF35WtTLOCb4()
		{
			return null;
		}

		// Token: 0x0400018E RID: 398
		private static readonly MessageParser<TreasureHuntFlagAnswerEvent> _parser;

		// Token: 0x0400018F RID: 399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000190 RID: 400
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x04000191 RID: 401
		private TreasureHuntType questType_;

		// Token: 0x04000192 RID: 402
		public const int ResultFieldNumber = 2;

		// Token: 0x04000193 RID: 403
		private TreasureHuntFlagAnswerEvent.Types.FlagResult result_;

		// Token: 0x04000194 RID: 404
		public const int IndexFieldNumber = 3;

		// Token: 0x04000195 RID: 405
		private int index_;

		// Token: 0x04000196 RID: 406
		internal static TreasureHuntFlagAnswerEvent WE1TA6Oj8Yi1CfMbeqrK;

		// Token: 0x02000064 RID: 100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060003FB RID: 1019 RVA: 0x002A6854 File Offset: 0x002A4A54
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000065 RID: 101
			public enum FlagResult
			{
				// Token: 0x04000198 RID: 408
				[OriginalName("ERROR_UNDEFINED")]
				ErrorUndefined,
				// Token: 0x04000199 RID: 409
				[OriginalName("OK")]
				Ok,
				// Token: 0x0400019A RID: 410
				[OriginalName("WRONG")]
				Wrong,
				// Token: 0x0400019B RID: 411
				[OriginalName("TOO_MANY")]
				TooMany,
				// Token: 0x0400019C RID: 412
				[OriginalName("ERROR_IMPOSSIBLE")]
				ErrorImpossible,
				// Token: 0x0400019D RID: 413
				[OriginalName("WRONG_INDEX")]
				WrongIndex,
				// Token: 0x0400019E RID: 414
				[OriginalName("SAME_MAP")]
				SameMap
			}
		}
	}
}
