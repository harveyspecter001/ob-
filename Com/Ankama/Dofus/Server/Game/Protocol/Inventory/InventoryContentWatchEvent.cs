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
	// Token: 0x0200041F RID: 1055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InventoryContentWatchEvent : IMessage<InventoryContentWatchEvent>, IMessage, IEquatable<InventoryContentWatchEvent>, IDeepCloneable<InventoryContentWatchEvent>, IBufferMessage
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x001D59F0 File Offset: 0x001D3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InventoryContentWatchEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x001D5A00 File Offset: 0x001D3C00
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x001D5A10 File Offset: 0x001D3C10
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

		// Token: 0x060031E8 RID: 12776 RVA: 0x001D5A20 File Offset: 0x001D3C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentWatchEvent()
		{
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x001D5A30 File Offset: 0x001D3C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentWatchEvent(InventoryContentWatchEvent other)
		{
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x001D5A40 File Offset: 0x001D3C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentWatchEvent Clone()
		{
			return null;
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x001D5A50 File Offset: 0x001D3C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x001D5A60 File Offset: 0x001D3C60
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x001D5A70 File Offset: 0x001D3C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Kamas
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x001D5A80 File Offset: 0x001D3C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x001D5A90 File Offset: 0x001D3C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InventoryContentWatchEvent other)
		{
			return true;
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x001D5AA0 File Offset: 0x001D3CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x001D5AB0 File Offset: 0x001D3CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x001D5AC0 File Offset: 0x001D3CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x001D5AD0 File Offset: 0x001D3CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x001D5AE0 File Offset: 0x001D3CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x001D5AF0 File Offset: 0x001D3CF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InventoryContentWatchEvent other)
		{
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x001D5B00 File Offset: 0x001D3D00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x001D5B10 File Offset: 0x001D3D10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x001D5B20 File Offset: 0x001D3D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InventoryContentWatchEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						InventoryContentWatchEvent._parser = new MessageParser<InventoryContentWatchEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					break;
				}
				IL_8B:
				InventoryContentWatchEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
				num = 5;
				continue;
				goto IL_8B;
			}
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x001D5C14 File Offset: 0x001D3E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aE0UqFOCQckTbvtGKGIr()
		{
			return true;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x001D5C1C File Offset: 0x001D3E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InventoryContentWatchEvent x18lcgOC7OtZ2Pb7dCqd()
		{
			return null;
		}

		// Token: 0x04001172 RID: 4466
		private static readonly MessageParser<InventoryContentWatchEvent> _parser;

		// Token: 0x04001173 RID: 4467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001174 RID: 4468
		public const int ObjectsFieldNumber = 1;

		// Token: 0x04001175 RID: 4469
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x04001176 RID: 4470
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x04001177 RID: 4471
		public const int KamasFieldNumber = 2;

		// Token: 0x04001178 RID: 4472
		private long kamas_;

		// Token: 0x04001179 RID: 4473
		internal static InventoryContentWatchEvent Wmrc4kOCwoo2YjjaeLFg;
	}
}
