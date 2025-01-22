using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000745 RID: 1861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseUnsoldItemsEvent : IMessage<ExchangeBidHouseUnsoldItemsEvent>, IMessage, IEquatable<ExchangeBidHouseUnsoldItemsEvent>, IDeepCloneable<ExchangeBidHouseUnsoldItemsEvent>, IBufferMessage
	{
		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x00219E1C File Offset: 0x0021801C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseUnsoldItemsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00219E2C File Offset: 0x0021802C
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

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x00219E3C File Offset: 0x0021803C
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

		// Token: 0x06005B67 RID: 23399 RVA: 0x00219E4C File Offset: 0x0021804C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseUnsoldItemsEvent()
		{
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00219E5C File Offset: 0x0021805C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseUnsoldItemsEvent(ExchangeBidHouseUnsoldItemsEvent other)
		{
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x00219E6C File Offset: 0x0021806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseUnsoldItemsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06005B6A RID: 23402 RVA: 0x00219E7C File Offset: 0x0021807C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectGidWithQuantity> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00219E8C File Offset: 0x0021808C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00219E9C File Offset: 0x0021809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseUnsoldItemsEvent other)
		{
			return true;
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00219EAC File Offset: 0x002180AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00219EBC File Offset: 0x002180BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00219ECC File Offset: 0x002180CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00219EDC File Offset: 0x002180DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00219EEC File Offset: 0x002180EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00219EFC File Offset: 0x002180FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseUnsoldItemsEvent other)
		{
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x00219F0C File Offset: 0x0021810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x00219F1C File Offset: 0x0021811C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00219F2C File Offset: 0x0021812C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseUnsoldItemsEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeBidHouseUnsoldItemsEvent._parser = new MessageParser<ExchangeBidHouseUnsoldItemsEvent>(() => null);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					ExchangeBidHouseUnsoldItemsEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectGidWithQuantity>(10U, hKDwCgAvDnD1E1yKRZW2.XVInXhlssT(hKDwCgAvDnD1E1yKRZW2.pYwAvtKyGS9));
					num2 = 4;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x0021A01C File Offset: 0x0021821C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mp5qU4O87odRP7MZW0P0()
		{
			return true;
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x0021A024 File Offset: 0x00218224
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseUnsoldItemsEvent YxU16oO8TPJJHreET5HJ()
		{
			return null;
		}

		// Token: 0x04002008 RID: 8200
		private static readonly MessageParser<ExchangeBidHouseUnsoldItemsEvent> _parser;

		// Token: 0x04002009 RID: 8201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400200A RID: 8202
		public const int ObjectsFieldNumber = 1;

		// Token: 0x0400200B RID: 8203
		private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_objects_codec;

		// Token: 0x0400200C RID: 8204
		private readonly RepeatedField<ObjectGidWithQuantity> objects_;

		// Token: 0x0400200D RID: 8205
		internal static ExchangeBidHouseUnsoldItemsEvent LLs0SYO8Q8K5IVhPdeF1;
	}
}
