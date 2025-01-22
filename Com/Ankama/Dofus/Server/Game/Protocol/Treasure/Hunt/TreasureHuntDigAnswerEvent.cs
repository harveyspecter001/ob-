using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x0200005F RID: 95
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntDigAnswerEvent : IMessage<TreasureHuntDigAnswerEvent>, IMessage, IEquatable<TreasureHuntDigAnswerEvent>, IDeepCloneable<TreasureHuntDigAnswerEvent>, IBufferMessage
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00187FA0 File Offset: 0x001861A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntDigAnswerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00187FB0 File Offset: 0x001861B0
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00187FC0 File Offset: 0x001861C0
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

		// Token: 0x060003C4 RID: 964 RVA: 0x00187FD0 File Offset: 0x001861D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigAnswerEvent()
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00187FE0 File Offset: 0x001861E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigAnswerEvent(TreasureHuntDigAnswerEvent other)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00187FF0 File Offset: 0x001861F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntDigAnswerEvent Clone()
		{
			return null;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00188000 File Offset: 0x00186200
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00188014 File Offset: 0x00186214
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00188024 File Offset: 0x00186224
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00188038 File Offset: 0x00186238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntDigAnswerEvent.Types.DigResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntDigAnswerEvent.Types.DigResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00188048 File Offset: 0x00186248
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00188058 File Offset: 0x00186258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WrongFlagCount
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00188068 File Offset: 0x00186268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWrongFlagCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00188078 File Offset: 0x00186278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearWrongFlagCount()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00188088 File Offset: 0x00186288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00188098 File Offset: 0x00186298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntDigAnswerEvent other)
		{
			return true;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x001880A8 File Offset: 0x001862A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x001880B8 File Offset: 0x001862B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x001880C8 File Offset: 0x001862C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x001880D8 File Offset: 0x001862D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x001880E8 File Offset: 0x001862E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x001880F8 File Offset: 0x001862F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntDigAnswerEvent other)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00188108 File Offset: 0x00186308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00188118 File Offset: 0x00186318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00188128 File Offset: 0x00186328
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntDigAnswerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					TreasureHuntDigAnswerEvent.WrongFlagCountDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					TreasureHuntDigAnswerEvent._parser = new MessageParser<TreasureHuntDigAnswerEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00188234 File Offset: 0x00186434
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sXrHkVOjMLG48VFBbbIx()
		{
			return true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0018823C File Offset: 0x0018643C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntDigAnswerEvent ubR0GVOjuK3RtpNBvIO9()
		{
			return null;
		}

		// Token: 0x04000179 RID: 377
		private static readonly MessageParser<TreasureHuntDigAnswerEvent> _parser;

		// Token: 0x0400017A RID: 378
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400017B RID: 379
		private int _hasBits0;

		// Token: 0x0400017C RID: 380
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x0400017D RID: 381
		private TreasureHuntType questType_;

		// Token: 0x0400017E RID: 382
		public const int ResultFieldNumber = 2;

		// Token: 0x0400017F RID: 383
		private TreasureHuntDigAnswerEvent.Types.DigResult result_;

		// Token: 0x04000180 RID: 384
		public const int WrongFlagCountFieldNumber = 3;

		// Token: 0x04000181 RID: 385
		private static readonly int WrongFlagCountDefaultValue;

		// Token: 0x04000182 RID: 386
		private int wrongFlagCount_;

		// Token: 0x04000183 RID: 387
		internal static TreasureHuntDigAnswerEvent TeTmKXOjSI7P5nVlLGvQ;

		// Token: 0x02000060 RID: 96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060003DC RID: 988 RVA: 0x002A6730 File Offset: 0x002A4930
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000061 RID: 97
			public enum DigResult
			{
				// Token: 0x04000185 RID: 389
				[OriginalName("ERROR_UNDEFINED")]
				ErrorUndefined,
				// Token: 0x04000186 RID: 390
				[OriginalName("NEW_HINT")]
				NewHint,
				// Token: 0x04000187 RID: 391
				[OriginalName("FINISHED")]
				Finished,
				// Token: 0x04000188 RID: 392
				[OriginalName("WRONG")]
				Wrong,
				// Token: 0x04000189 RID: 393
				[OriginalName("LOST")]
				Lost,
				// Token: 0x0400018A RID: 394
				[OriginalName("ERROR_IMPOSSIBLE")]
				ErrorImpossible,
				// Token: 0x0400018B RID: 395
				[OriginalName("WRONG_AND_YOU_KNOW_IT")]
				WrongAndYouKnowIt
			}
		}
	}
}
