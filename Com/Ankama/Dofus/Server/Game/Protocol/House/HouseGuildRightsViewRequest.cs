using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000461 RID: 1121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseGuildRightsViewRequest : IMessage<HouseGuildRightsViewRequest>, IMessage, IEquatable<HouseGuildRightsViewRequest>, IDeepCloneable<HouseGuildRightsViewRequest>, IBufferMessage
	{
		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x001DBF88 File Offset: 0x001DA188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseGuildRightsViewRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x001DBF98 File Offset: 0x001DA198
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

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x001DBFA8 File Offset: 0x001DA1A8
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

		// Token: 0x06003569 RID: 13673 RVA: 0x001DBFB8 File Offset: 0x001DA1B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsViewRequest()
		{
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x001DBFC8 File Offset: 0x001DA1C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsViewRequest(HouseGuildRightsViewRequest other)
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x001DBFD8 File Offset: 0x001DA1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsViewRequest Clone()
		{
			return null;
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x001DBFE8 File Offset: 0x001DA1E8
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x001DBFF8 File Offset: 0x001DA1F8
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x001DC008 File Offset: 0x001DA208
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x001DC018 File Offset: 0x001DA218
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

		// Token: 0x06003570 RID: 13680 RVA: 0x001DC028 File Offset: 0x001DA228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x001DC038 File Offset: 0x001DA238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseGuildRightsViewRequest other)
		{
			return true;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x001DC048 File Offset: 0x001DA248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x001DC058 File Offset: 0x001DA258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x001DC068 File Offset: 0x001DA268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x001DC078 File Offset: 0x001DA278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x001DC088 File Offset: 0x001DA288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x001DC098 File Offset: 0x001DA298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseGuildRightsViewRequest other)
		{
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x001DC0A8 File Offset: 0x001DA2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x001DC0B8 File Offset: 0x001DA2B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x001DC0C8 File Offset: 0x001DA2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseGuildRightsViewRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					HouseGuildRightsViewRequest._parser = new MessageParser<HouseGuildRightsViewRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x001DC1C0 File Offset: 0x001DA3C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SJHHqGOtIVewURoItt8n()
		{
			return true;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x001DC1C8 File Offset: 0x001DA3C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseGuildRightsViewRequest gxXg0oOtkttn5qapScYo()
		{
			return null;
		}

		// Token: 0x040012A5 RID: 4773
		private static readonly MessageParser<HouseGuildRightsViewRequest> _parser;

		// Token: 0x040012A6 RID: 4774
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012A7 RID: 4775
		public const int HouseIdFieldNumber = 1;

		// Token: 0x040012A8 RID: 4776
		private int houseId_;

		// Token: 0x040012A9 RID: 4777
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040012AA RID: 4778
		private int instanceId_;

		// Token: 0x040012AB RID: 4779
		private static HouseGuildRightsViewRequest OdTGcfOtKm2ZLgQICl0M;
	}
}
