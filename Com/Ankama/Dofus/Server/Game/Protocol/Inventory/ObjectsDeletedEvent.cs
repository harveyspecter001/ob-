using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200040F RID: 1039
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectsDeletedEvent : IMessage<ObjectsDeletedEvent>, IMessage, IEquatable<ObjectsDeletedEvent>, IDeepCloneable<ObjectsDeletedEvent>, IBufferMessage
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x001D48B4 File Offset: 0x001D2AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectsDeletedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x001D48C4 File Offset: 0x001D2AC4
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

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x001D48D4 File Offset: 0x001D2AD4
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

		// Token: 0x06003111 RID: 12561 RVA: 0x001D48E4 File Offset: 0x001D2AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDeletedEvent()
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x001D48F4 File Offset: 0x001D2AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDeletedEvent(ObjectsDeletedEvent other)
		{
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x001D4904 File Offset: 0x001D2B04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsDeletedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x001D4914 File Offset: 0x001D2B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x001D4924 File Offset: 0x001D2B24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x001D4934 File Offset: 0x001D2B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectsDeletedEvent other)
		{
			return true;
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x001D4944 File Offset: 0x001D2B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x001D4954 File Offset: 0x001D2B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x001D4964 File Offset: 0x001D2B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x001D4974 File Offset: 0x001D2B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x001D4984 File Offset: 0x001D2B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x001D4994 File Offset: 0x001D2B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectsDeletedEvent other)
		{
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x001D49A4 File Offset: 0x001D2BA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x001D49B4 File Offset: 0x001D2BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x001D49C4 File Offset: 0x001D2BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectsDeletedEvent()
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
						goto IL_8A;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 5;
						continue;
					case 4:
						goto IL_39;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					ObjectsDeletedEvent._parser = new MessageParser<ObjectsDeletedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 0;
					}
				}
				IL_39:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				IL_8A:
				ObjectsDeletedEvent._repeated_objectsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num = 2;
			}
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x001D4AB8 File Offset: 0x001D2CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S2rNtcOCj5qyOorXdQJP()
		{
			return true;
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x001D4AC0 File Offset: 0x001D2CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectsDeletedEvent xJTv2lOCKk4TZ6KCTpjC()
		{
			return null;
		}

		// Token: 0x0400112D RID: 4397
		private static readonly MessageParser<ObjectsDeletedEvent> _parser;

		// Token: 0x0400112E RID: 4398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400112F RID: 4399
		public const int ObjectsUidFieldNumber = 1;

		// Token: 0x04001130 RID: 4400
		private static readonly FieldCodec<int> _repeated_objectsUid_codec;

		// Token: 0x04001131 RID: 4401
		private readonly RepeatedField<int> objectsUid_;

		// Token: 0x04001132 RID: 4402
		internal static ObjectsDeletedEvent zkgTgFOC45KggXpssUmH;
	}
}
