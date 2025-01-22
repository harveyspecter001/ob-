using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000407 RID: 1031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectsAddedEvent : IMessage<ObjectsAddedEvent>, IMessage, IEquatable<ObjectsAddedEvent>, IDeepCloneable<ObjectsAddedEvent>, IBufferMessage
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x001D404C File Offset: 0x001D224C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectsAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x001D405C File Offset: 0x001D225C
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x001D406C File Offset: 0x001D226C
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

		// Token: 0x060030AA RID: 12458 RVA: 0x001D407C File Offset: 0x001D227C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsAddedEvent()
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x001D408C File Offset: 0x001D228C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsAddedEvent(ObjectsAddedEvent other)
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x001D409C File Offset: 0x001D229C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectsAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x001D40AC File Offset: 0x001D22AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x001D40BC File Offset: 0x001D22BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x001D40CC File Offset: 0x001D22CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectsAddedEvent other)
		{
			return true;
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x001D40DC File Offset: 0x001D22DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x001D40EC File Offset: 0x001D22EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x001D40FC File Offset: 0x001D22FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x001D410C File Offset: 0x001D230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x001D411C File Offset: 0x001D231C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x001D412C File Offset: 0x001D232C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectsAddedEvent other)
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x001D413C File Offset: 0x001D233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x001D414C File Offset: 0x001D234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x001D415C File Offset: 0x001D235C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectsAddedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ObjectsAddedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ObjectsAddedEvent._parser = new MessageParser<ObjectsAddedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x001D4278 File Offset: 0x001D2478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UQY2euOCJudgFihBag1L()
		{
			return true;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x001D4280 File Offset: 0x001D2480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectsAddedEvent XB3cAHOCG6C2YlpY7JPx()
		{
			return null;
		}

		// Token: 0x04001110 RID: 4368
		private static readonly MessageParser<ObjectsAddedEvent> _parser;

		// Token: 0x04001111 RID: 4369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001112 RID: 4370
		public const int ObjectsFieldNumber = 1;

		// Token: 0x04001113 RID: 4371
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x04001114 RID: 4372
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x04001115 RID: 4373
		private static ObjectsAddedEvent hrX6QfOCOwx1R3gc3g92;
	}
}
