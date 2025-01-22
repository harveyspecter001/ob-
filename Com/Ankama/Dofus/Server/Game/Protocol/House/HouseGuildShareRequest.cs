using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000463 RID: 1123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseGuildShareRequest : IMessage<HouseGuildShareRequest>, IMessage, IEquatable<HouseGuildShareRequest>, IDeepCloneable<HouseGuildShareRequest>, IBufferMessage
	{
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x001DC1D0 File Offset: 0x001DA3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseGuildShareRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x001DC1E0 File Offset: 0x001DA3E0
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x001DC1F0 File Offset: 0x001DA3F0
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

		// Token: 0x06003585 RID: 13701 RVA: 0x001DC200 File Offset: 0x001DA400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildShareRequest()
		{
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x001DC210 File Offset: 0x001DA410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildShareRequest(HouseGuildShareRequest other)
		{
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x001DC220 File Offset: 0x001DA420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildShareRequest Clone()
		{
			return null;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x001DC230 File Offset: 0x001DA430
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x001DC240 File Offset: 0x001DA440
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x001DC250 File Offset: 0x001DA450
		// (set) Token: 0x0600358B RID: 13707 RVA: 0x001DC260 File Offset: 0x001DA460
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

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x001DC270 File Offset: 0x001DA470
		// (set) Token: 0x0600358D RID: 13709 RVA: 0x001DC280 File Offset: 0x001DA480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Share
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x001DC290 File Offset: 0x001DA490
		// (set) Token: 0x0600358F RID: 13711 RVA: 0x001DC2A0 File Offset: 0x001DA4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rights
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

		// Token: 0x06003590 RID: 13712 RVA: 0x001DC2B0 File Offset: 0x001DA4B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x001DC2C0 File Offset: 0x001DA4C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseGuildShareRequest other)
		{
			return true;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x001DC2D0 File Offset: 0x001DA4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x001DC2E0 File Offset: 0x001DA4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x001DC2F0 File Offset: 0x001DA4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x001DC300 File Offset: 0x001DA500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x001DC310 File Offset: 0x001DA510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x001DC320 File Offset: 0x001DA520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseGuildShareRequest other)
		{
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x001DC330 File Offset: 0x001DA530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x001DC340 File Offset: 0x001DA540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x001DC350 File Offset: 0x001DA550
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseGuildShareRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					HouseGuildShareRequest._parser = new MessageParser<HouseGuildShareRequest>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x001DC41C File Offset: 0x001DA61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oHDh98OtcY0WYu9d6FBi()
		{
			return true;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x001DC424 File Offset: 0x001DA624
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseGuildShareRequest tJ9bTYOtUADVmtcYNMiS()
		{
			return null;
		}

		// Token: 0x040012AE RID: 4782
		private static readonly MessageParser<HouseGuildShareRequest> _parser;

		// Token: 0x040012AF RID: 4783
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012B0 RID: 4784
		public const int HouseIdFieldNumber = 1;

		// Token: 0x040012B1 RID: 4785
		private int houseId_;

		// Token: 0x040012B2 RID: 4786
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040012B3 RID: 4787
		private int instanceId_;

		// Token: 0x040012B4 RID: 4788
		public const int ShareFieldNumber = 3;

		// Token: 0x040012B5 RID: 4789
		private bool share_;

		// Token: 0x040012B6 RID: 4790
		public const int RightsFieldNumber = 4;

		// Token: 0x040012B7 RID: 4791
		private int rights_;

		// Token: 0x040012B8 RID: 4792
		private static HouseGuildShareRequest aw4MTJOtl0OIvTfSqoru;
	}
}
