using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000743 RID: 1859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseInListRemovedEvent : IMessage<ExchangeBidHouseInListRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseInListRemovedEvent>, IDeepCloneable<ExchangeBidHouseInListRemovedEvent>, IBufferMessage
	{
		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06005B46 RID: 23366 RVA: 0x00219BC8 File Offset: 0x00217DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseInListRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x00219BD8 File Offset: 0x00217DD8
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06005B48 RID: 23368 RVA: 0x00219BE8 File Offset: 0x00217DE8
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

		// Token: 0x06005B49 RID: 23369 RVA: 0x00219BF8 File Offset: 0x00217DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListRemovedEvent()
		{
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00219C08 File Offset: 0x00217E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListRemovedEvent(ExchangeBidHouseInListRemovedEvent other)
		{
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00219C18 File Offset: 0x00217E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x00219C28 File Offset: 0x00217E28
		// (set) Token: 0x06005B4D RID: 23373 RVA: 0x00219C38 File Offset: 0x00217E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BidItemUid
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

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x00219C48 File Offset: 0x00217E48
		// (set) Token: 0x06005B4F RID: 23375 RVA: 0x00219C58 File Offset: 0x00217E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectGid
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

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x00219C68 File Offset: 0x00217E68
		// (set) Token: 0x06005B51 RID: 23377 RVA: 0x00219C78 File Offset: 0x00217E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectType
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

		// Token: 0x06005B52 RID: 23378 RVA: 0x00219C88 File Offset: 0x00217E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x00219C98 File Offset: 0x00217E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseInListRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00219CA8 File Offset: 0x00217EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x00219CB8 File Offset: 0x00217EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00219CC8 File Offset: 0x00217EC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00219CD8 File Offset: 0x00217ED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00219CE8 File Offset: 0x00217EE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x00219CF8 File Offset: 0x00217EF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseInListRemovedEvent other)
		{
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00219D08 File Offset: 0x00217F08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00219D18 File Offset: 0x00217F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00219D28 File Offset: 0x00217F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseInListRemovedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ExchangeBidHouseInListRemovedEvent._parser = new MessageParser<ExchangeBidHouseInListRemovedEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00219E0C File Offset: 0x0021800C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GwvQtnO8tSa9MCEJK4iX()
		{
			return true;
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00219E14 File Offset: 0x00218014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseInListRemovedEvent DGjCjhO8wfViKIQXFHXr()
		{
			return null;
		}

		// Token: 0x04001FFD RID: 8189
		private static readonly MessageParser<ExchangeBidHouseInListRemovedEvent> _parser;

		// Token: 0x04001FFE RID: 8190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FFF RID: 8191
		public const int BidItemUidFieldNumber = 1;

		// Token: 0x04002000 RID: 8192
		private int bidItemUid_;

		// Token: 0x04002001 RID: 8193
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x04002002 RID: 8194
		private int objectGid_;

		// Token: 0x04002003 RID: 8195
		public const int ObjectTypeFieldNumber = 3;

		// Token: 0x04002004 RID: 8196
		private int objectType_;

		// Token: 0x04002005 RID: 8197
		internal static ExchangeBidHouseInListRemovedEvent BDgleHO8Dm6J8lQCkDen;
	}
}
