using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200041B RID: 1051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectHarvestedWithBonusEvent : IMessage<ObjectHarvestedWithBonusEvent>, IMessage, IEquatable<ObjectHarvestedWithBonusEvent>, IDeepCloneable<ObjectHarvestedWithBonusEvent>, IBufferMessage
	{
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x001D5568 File Offset: 0x001D3768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectHarvestedWithBonusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x001D5578 File Offset: 0x001D3778
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

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x001D5588 File Offset: 0x001D3788
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

		// Token: 0x060031AF RID: 12719 RVA: 0x001D5598 File Offset: 0x001D3798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedWithBonusEvent()
		{
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x001D55A8 File Offset: 0x001D37A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedWithBonusEvent(ObjectHarvestedWithBonusEvent other)
		{
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x001D55B8 File Offset: 0x001D37B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectHarvestedWithBonusEvent Clone()
		{
			return null;
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x001D55C8 File Offset: 0x001D37C8
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x001D55D8 File Offset: 0x001D37D8
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

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x001D55E8 File Offset: 0x001D37E8
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x001D55F8 File Offset: 0x001D37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x001D5608 File Offset: 0x001D3808
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x001D5618 File Offset: 0x001D3818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BonusQuantity
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

		// Token: 0x060031B8 RID: 12728 RVA: 0x001D5628 File Offset: 0x001D3828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x001D5638 File Offset: 0x001D3838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectHarvestedWithBonusEvent other)
		{
			return true;
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x001D5648 File Offset: 0x001D3848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x001D5658 File Offset: 0x001D3858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x001D5668 File Offset: 0x001D3868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x001D5678 File Offset: 0x001D3878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x001D5688 File Offset: 0x001D3888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x001D5698 File Offset: 0x001D3898
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectHarvestedWithBonusEvent other)
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x001D56A8 File Offset: 0x001D38A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x001D56B8 File Offset: 0x001D38B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x001D56C8 File Offset: 0x001D38C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectHarvestedWithBonusEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ObjectHarvestedWithBonusEvent._parser = new MessageParser<ObjectHarvestedWithBonusEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x001D57AC File Offset: 0x001D39AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v3B0kvOCVp6WwrpEUISD()
		{
			return true;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x001D57B4 File Offset: 0x001D39B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectHarvestedWithBonusEvent x4huXMOC0HEPSj48PQ61()
		{
			return null;
		}

		// Token: 0x0400115D RID: 4445
		private static readonly MessageParser<ObjectHarvestedWithBonusEvent> _parser;

		// Token: 0x0400115E RID: 4446
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400115F RID: 4447
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001160 RID: 4448
		private int objectGid_;

		// Token: 0x04001161 RID: 4449
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001162 RID: 4450
		private int quantity_;

		// Token: 0x04001163 RID: 4451
		public const int BonusQuantityFieldNumber = 3;

		// Token: 0x04001164 RID: 4452
		private int bonusQuantity_;

		// Token: 0x04001165 RID: 4453
		internal static ObjectHarvestedWithBonusEvent V9PCSwOCrUrJOJM4Qqew;
	}
}
