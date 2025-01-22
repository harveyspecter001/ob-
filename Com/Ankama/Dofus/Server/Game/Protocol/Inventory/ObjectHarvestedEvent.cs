using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000419 RID: 1049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectHarvestedEvent : IMessage<ObjectHarvestedEvent>, IMessage, IEquatable<ObjectHarvestedEvent>, IDeepCloneable<ObjectHarvestedEvent>, IBufferMessage
	{
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x001D5320 File Offset: 0x001D3520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectHarvestedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x001D5330 File Offset: 0x001D3530
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

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x001D5340 File Offset: 0x001D3540
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

		// Token: 0x06003193 RID: 12691 RVA: 0x001D5350 File Offset: 0x001D3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedEvent()
		{
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x001D5360 File Offset: 0x001D3560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedEvent(ObjectHarvestedEvent other)
		{
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x001D5370 File Offset: 0x001D3570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x001D5380 File Offset: 0x001D3580
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x001D5390 File Offset: 0x001D3590
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

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x001D53A0 File Offset: 0x001D35A0
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x001D53B0 File Offset: 0x001D35B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
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

		// Token: 0x0600319A RID: 12698 RVA: 0x001D53C0 File Offset: 0x001D35C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x001D53D0 File Offset: 0x001D35D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectHarvestedEvent other)
		{
			return true;
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x001D53E0 File Offset: 0x001D35E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x001D53F0 File Offset: 0x001D35F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x001D5400 File Offset: 0x001D3600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x001D5410 File Offset: 0x001D3610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x001D5420 File Offset: 0x001D3620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x001D5430 File Offset: 0x001D3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectHarvestedEvent other)
		{
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x001D5440 File Offset: 0x001D3640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x001D5450 File Offset: 0x001D3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x001D5460 File Offset: 0x001D3660
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectHarvestedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					ObjectHarvestedEvent._parser = new MessageParser<ObjectHarvestedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x001D5558 File Offset: 0x001D3758
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gcEsxIOCWKDCOWG8U99U()
		{
			return true;
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x001D5560 File Offset: 0x001D3760
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectHarvestedEvent yQ9acAOChAxbDf1aF9Lp()
		{
			return null;
		}

		// Token: 0x04001154 RID: 4436
		private static readonly MessageParser<ObjectHarvestedEvent> _parser;

		// Token: 0x04001155 RID: 4437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001156 RID: 4438
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001157 RID: 4439
		private int objectGid_;

		// Token: 0x04001158 RID: 4440
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001159 RID: 4441
		private int quantity_;

		// Token: 0x0400115A RID: 4442
		internal static ObjectHarvestedEvent iqOpfTOCLh66fNP3KssB;
	}
}
