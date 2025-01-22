using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000421 RID: 1057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InventoryWeightEvent : IMessage<InventoryWeightEvent>, IMessage, IEquatable<InventoryWeightEvent>, IDeepCloneable<InventoryWeightEvent>, IBufferMessage
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x001D5C24 File Offset: 0x001D3E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InventoryWeightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x001D5C34 File Offset: 0x001D3E34
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

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x001D5C44 File Offset: 0x001D3E44
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

		// Token: 0x06003203 RID: 12803 RVA: 0x001D5C54 File Offset: 0x001D3E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryWeightEvent()
		{
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x001D5C64 File Offset: 0x001D3E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryWeightEvent(InventoryWeightEvent other)
		{
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x001D5C74 File Offset: 0x001D3E74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryWeightEvent Clone()
		{
			return null;
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x001D5C84 File Offset: 0x001D3E84
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x001D5C94 File Offset: 0x001D3E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InventoryWeight
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

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x001D5CA4 File Offset: 0x001D3EA4
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x001D5CB4 File Offset: 0x001D3EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeightMax
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

		// Token: 0x0600320A RID: 12810 RVA: 0x001D5CC4 File Offset: 0x001D3EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x001D5CD4 File Offset: 0x001D3ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InventoryWeightEvent other)
		{
			return true;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x001D5CE4 File Offset: 0x001D3EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x001D5CF4 File Offset: 0x001D3EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x001D5D04 File Offset: 0x001D3F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x001D5D14 File Offset: 0x001D3F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x001D5D24 File Offset: 0x001D3F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001D5D34 File Offset: 0x001D3F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InventoryWeightEvent other)
		{
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x001D5D44 File Offset: 0x001D3F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x001D5D54 File Offset: 0x001D3F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x001D5D64 File Offset: 0x001D3F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InventoryWeightEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					InventoryWeightEvent._parser = new MessageParser<InventoryWeightEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x001D5E48 File Offset: 0x001D4048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UECmT6OCp600RGmKC7Hu()
		{
			return true;
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x001D5E50 File Offset: 0x001D4050
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InventoryWeightEvent Udg4wOOCH4QcfEu4O3qQ()
		{
			return null;
		}

		// Token: 0x0400117C RID: 4476
		private static readonly MessageParser<InventoryWeightEvent> _parser;

		// Token: 0x0400117D RID: 4477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400117E RID: 4478
		public const int InventoryWeightFieldNumber = 1;

		// Token: 0x0400117F RID: 4479
		private int inventoryWeight_;

		// Token: 0x04001180 RID: 4480
		public const int WeightMaxFieldNumber = 2;

		// Token: 0x04001181 RID: 4481
		private int weightMax_;

		// Token: 0x04001182 RID: 4482
		private static InventoryWeightEvent kc3ri5OCTofehUnHE2E9;
	}
}
