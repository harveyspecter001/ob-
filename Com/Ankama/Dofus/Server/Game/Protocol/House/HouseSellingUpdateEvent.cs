using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x0200046B RID: 1131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseSellingUpdateEvent : IMessage<HouseSellingUpdateEvent>, IMessage, IEquatable<HouseSellingUpdateEvent>, IDeepCloneable<HouseSellingUpdateEvent>, IBufferMessage
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x001DCB24 File Offset: 0x001DAD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseSellingUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x001DCB34 File Offset: 0x001DAD34
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x001DCB44 File Offset: 0x001DAD44
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

		// Token: 0x060035FD RID: 13821 RVA: 0x001DCB54 File Offset: 0x001DAD54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellingUpdateEvent()
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x001DCB64 File Offset: 0x001DAD64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellingUpdateEvent(HouseSellingUpdateEvent other)
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x001DCB74 File Offset: 0x001DAD74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellingUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x001DCB84 File Offset: 0x001DAD84
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x001DCB94 File Offset: 0x001DAD94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x001DCBA4 File Offset: 0x001DADA4
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x001DCBB4 File Offset: 0x001DADB4
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x001DCBC4 File Offset: 0x001DADC4
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x001DCBD4 File Offset: 0x001DADD4
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x001DCBE4 File Offset: 0x001DADE4
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x001DCBF4 File Offset: 0x001DADF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x001DCC04 File Offset: 0x001DAE04
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x001DCC14 File Offset: 0x001DAE14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string BuyerAccountNickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x001DCC24 File Offset: 0x001DAE24
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x001DCC34 File Offset: 0x001DAE34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string BuyerAccountTag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x001DCC44 File Offset: 0x001DAE44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x001DCC54 File Offset: 0x001DAE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseSellingUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x001DCC64 File Offset: 0x001DAE64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x001DCC74 File Offset: 0x001DAE74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x001DCC84 File Offset: 0x001DAE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x001DCC94 File Offset: 0x001DAE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x001DCCA4 File Offset: 0x001DAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x001DCCB4 File Offset: 0x001DAEB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseSellingUpdateEvent other)
		{
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x001DCCC4 File Offset: 0x001DAEC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x001DCCD4 File Offset: 0x001DAED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x001DCCE4 File Offset: 0x001DAEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseSellingUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					HouseSellingUpdateEvent._parser = new MessageParser<HouseSellingUpdateEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x001DCDDC File Offset: 0x001DAFDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JH8DI5OtrUfxa24FocTh()
		{
			return true;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x001DCDE4 File Offset: 0x001DAFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseSellingUpdateEvent nJgi8nOtVtamVkfxBypq()
		{
			return null;
		}

		// Token: 0x040012DE RID: 4830
		private static readonly MessageParser<HouseSellingUpdateEvent> _parser;

		// Token: 0x040012DF RID: 4831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012E0 RID: 4832
		public const int HouseIdFieldNumber = 1;

		// Token: 0x040012E1 RID: 4833
		private int houseId_;

		// Token: 0x040012E2 RID: 4834
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040012E3 RID: 4835
		private int instanceId_;

		// Token: 0x040012E4 RID: 4836
		public const int SecondHandFieldNumber = 3;

		// Token: 0x040012E5 RID: 4837
		private bool secondHand_;

		// Token: 0x040012E6 RID: 4838
		public const int PriceFieldNumber = 4;

		// Token: 0x040012E7 RID: 4839
		private long price_;

		// Token: 0x040012E8 RID: 4840
		public const int BuyerAccountNicknameFieldNumber = 5;

		// Token: 0x040012E9 RID: 4841
		private string buyerAccountNickname_;

		// Token: 0x040012EA RID: 4842
		public const int BuyerAccountTagFieldNumber = 6;

		// Token: 0x040012EB RID: 4843
		private string buyerAccountTag_;

		// Token: 0x040012EC RID: 4844
		private static HouseSellingUpdateEvent ww3gR8Othr1tuwfF9C3A;
	}
}
