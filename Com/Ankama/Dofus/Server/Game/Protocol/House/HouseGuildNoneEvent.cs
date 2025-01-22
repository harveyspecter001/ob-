using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000472 RID: 1138
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseGuildNoneEvent : IMessage<HouseGuildNoneEvent>, IMessage, IEquatable<HouseGuildNoneEvent>, IDeepCloneable<HouseGuildNoneEvent>, IBufferMessage
	{
		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x001DD040 File Offset: 0x001DB240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseGuildNoneEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x001DD050 File Offset: 0x001DB250
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

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x001DD060 File Offset: 0x001DB260
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

		// Token: 0x06003672 RID: 13938 RVA: 0x001DD070 File Offset: 0x001DB270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildNoneEvent()
		{
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x001DD080 File Offset: 0x001DB280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildNoneEvent(HouseGuildNoneEvent other)
		{
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x001DD090 File Offset: 0x001DB290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildNoneEvent Clone()
		{
			return null;
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x001DD0A0 File Offset: 0x001DB2A0
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x001DD0B0 File Offset: 0x001DB2B0
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

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x001DD0C0 File Offset: 0x001DB2C0
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x001DD0D0 File Offset: 0x001DB2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x001DD0E0 File Offset: 0x001DB2E0
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x001DD0F0 File Offset: 0x001DB2F0
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

		// Token: 0x0600367B RID: 13947 RVA: 0x001DD100 File Offset: 0x001DB300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x001DD110 File Offset: 0x001DB310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseGuildNoneEvent other)
		{
			return true;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x001DD120 File Offset: 0x001DB320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x001DD130 File Offset: 0x001DB330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x001DD140 File Offset: 0x001DB340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x001DD150 File Offset: 0x001DB350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x001DD160 File Offset: 0x001DB360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x001DD170 File Offset: 0x001DB370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseGuildNoneEvent other)
		{
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x001DD180 File Offset: 0x001DB380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x001DD190 File Offset: 0x001DB390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x001DD1A0 File Offset: 0x001DB3A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseGuildNoneEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					HouseGuildNoneEvent._parser = new MessageParser<HouseGuildNoneEvent>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x001DD26C File Offset: 0x001DB46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VEB25sOtwYuPnYEF8iPl()
		{
			return true;
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x001DD274 File Offset: 0x001DB474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseGuildNoneEvent RIeXOrOtQaDrMKdDM4rT()
		{
			return null;
		}

		// Token: 0x0400131D RID: 4893
		private static readonly MessageParser<HouseGuildNoneEvent> _parser;

		// Token: 0x0400131E RID: 4894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400131F RID: 4895
		public const int HouseIdFieldNumber = 1;

		// Token: 0x04001320 RID: 4896
		private int houseId_;

		// Token: 0x04001321 RID: 4897
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x04001322 RID: 4898
		private int instanceId_;

		// Token: 0x04001323 RID: 4899
		public const int SecondHandFieldNumber = 3;

		// Token: 0x04001324 RID: 4900
		private bool secondHand_;

		// Token: 0x04001325 RID: 4901
		private static HouseGuildNoneEvent KPYewPOttZvxYX15xDrA;
	}
}
