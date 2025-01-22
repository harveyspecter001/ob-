using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000469 RID: 1129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseBuyResultEvent : IMessage<HouseBuyResultEvent>, IMessage, IEquatable<HouseBuyResultEvent>, IDeepCloneable<HouseBuyResultEvent>, IBufferMessage
	{
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x001DC88C File Offset: 0x001DAA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseBuyResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x001DC89C File Offset: 0x001DAA9C
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

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x001DC8AC File Offset: 0x001DAAAC
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

		// Token: 0x060035DB RID: 13787 RVA: 0x001DC8BC File Offset: 0x001DAABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyResultEvent()
		{
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x001DC8CC File Offset: 0x001DAACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyResultEvent(HouseBuyResultEvent other)
		{
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x001DC8DC File Offset: 0x001DAADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x001DC8EC File Offset: 0x001DAAEC
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x001DC8FC File Offset: 0x001DAAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HouseId
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

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x001DC90C File Offset: 0x001DAB0C
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x001DC91C File Offset: 0x001DAB1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int InstanceId
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x001DC92C File Offset: 0x001DAB2C
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x001DC93C File Offset: 0x001DAB3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool SecondHand
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x001DC94C File Offset: 0x001DAB4C
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x001DC95C File Offset: 0x001DAB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Bought
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x001DC96C File Offset: 0x001DAB6C
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x001DC97C File Offset: 0x001DAB7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
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

		// Token: 0x060035E8 RID: 13800 RVA: 0x001DC98C File Offset: 0x001DAB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x001DC99C File Offset: 0x001DAB9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseBuyResultEvent other)
		{
			return true;
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x001DC9AC File Offset: 0x001DABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x001DC9BC File Offset: 0x001DABBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x001DC9CC File Offset: 0x001DABCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x001DC9DC File Offset: 0x001DABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x001DC9EC File Offset: 0x001DABEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x001DC9FC File Offset: 0x001DABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseBuyResultEvent other)
		{
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x001DCA0C File Offset: 0x001DAC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x001DCA1C File Offset: 0x001DAC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x001DCA2C File Offset: 0x001DAC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseBuyResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						HouseBuyResultEvent._parser = new MessageParser<HouseBuyResultEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_98;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_98:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x001DCB14 File Offset: 0x001DAD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eIMnXXOtLOOB2G3tjj3Q()
		{
			return true;
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x001DCB1C File Offset: 0x001DAD1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseBuyResultEvent O9Bkh6OtWiuIBBVMXq7m()
		{
			return null;
		}

		// Token: 0x040012CF RID: 4815
		private static readonly MessageParser<HouseBuyResultEvent> _parser;

		// Token: 0x040012D0 RID: 4816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012D1 RID: 4817
		public const int HouseIdFieldNumber = 1;

		// Token: 0x040012D2 RID: 4818
		private int houseId_;

		// Token: 0x040012D3 RID: 4819
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040012D4 RID: 4820
		private int instanceId_;

		// Token: 0x040012D5 RID: 4821
		public const int SecondHandFieldNumber = 3;

		// Token: 0x040012D6 RID: 4822
		private bool secondHand_;

		// Token: 0x040012D7 RID: 4823
		public const int BoughtFieldNumber = 4;

		// Token: 0x040012D8 RID: 4824
		private bool bought_;

		// Token: 0x040012D9 RID: 4825
		public const int PriceFieldNumber = 5;

		// Token: 0x040012DA RID: 4826
		private long price_;

		// Token: 0x040012DB RID: 4827
		private static HouseBuyResultEvent brAT4SOt67DUgkiUEQmO;
	}
}
