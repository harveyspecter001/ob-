using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C81 RID: 3201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFaceUpdatedEvent : IMessage<CharacterFaceUpdatedEvent>, IMessage, IEquatable<CharacterFaceUpdatedEvent>, IDeepCloneable<CharacterFaceUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x0027C018 File Offset: 0x0027A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterFaceUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x0027C028 File Offset: 0x0027A228
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

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x0027C038 File Offset: 0x0027A238
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

		// Token: 0x060099B1 RID: 39345 RVA: 0x0027C048 File Offset: 0x0027A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaceUpdatedEvent()
		{
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x0027C058 File Offset: 0x0027A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaceUpdatedEvent(CharacterFaceUpdatedEvent other)
		{
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x0027C068 File Offset: 0x0027A268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaceUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x060099B4 RID: 39348 RVA: 0x0027C078 File Offset: 0x0027A278
		// (set) Token: 0x060099B5 RID: 39349 RVA: 0x0027C088 File Offset: 0x0027A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FaceId
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

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x060099B6 RID: 39350 RVA: 0x0027C098 File Offset: 0x0027A298
		// (set) Token: 0x060099B7 RID: 39351 RVA: 0x0027C0A8 File Offset: 0x0027A2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060099B8 RID: 39352 RVA: 0x0027C0B8 File Offset: 0x0027A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x0027C0C8 File Offset: 0x0027A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFaceUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x060099BA RID: 39354 RVA: 0x0027C0D8 File Offset: 0x0027A2D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060099BC RID: 39356 RVA: 0x0027C0F8 File Offset: 0x0027A2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x0027C108 File Offset: 0x0027A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x0027C118 File Offset: 0x0027A318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x0027C128 File Offset: 0x0027A328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFaceUpdatedEvent other)
		{
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x0027C138 File Offset: 0x0027A338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x0027C148 File Offset: 0x0027A348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060099C2 RID: 39362 RVA: 0x0027C158 File Offset: 0x0027A358
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFaceUpdatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					CharacterFaceUpdatedEvent._parser = new MessageParser<CharacterFaceUpdatedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x0027C224 File Offset: 0x0027A424
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l8qqndJN8w9QsX8pBO7r()
		{
			return true;
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x0027C22C File Offset: 0x0027A42C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFaceUpdatedEvent by3qAUJNZtebQL5h1kSb()
		{
			return null;
		}

		// Token: 0x040038FB RID: 14587
		private static readonly MessageParser<CharacterFaceUpdatedEvent> _parser;

		// Token: 0x040038FC RID: 14588
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038FD RID: 14589
		public const int FaceIdFieldNumber = 1;

		// Token: 0x040038FE RID: 14590
		private int faceId_;

		// Token: 0x040038FF RID: 14591
		public const int SlotFieldNumber = 2;

		// Token: 0x04003900 RID: 14592
		private int slot_;

		// Token: 0x04003901 RID: 14593
		internal static CharacterFaceUpdatedEvent BLGwlhJNuFFRfIWxPTJW;
	}
}
