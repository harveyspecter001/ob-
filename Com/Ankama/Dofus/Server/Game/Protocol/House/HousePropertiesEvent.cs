using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000467 RID: 1127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HousePropertiesEvent : IMessage<HousePropertiesEvent>, IMessage, IEquatable<HousePropertiesEvent>, IDeepCloneable<HousePropertiesEvent>, IBufferMessage
	{
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x001DC640 File Offset: 0x001DA840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HousePropertiesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x001DC650 File Offset: 0x001DA850
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x001DC660 File Offset: 0x001DA860
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

		// Token: 0x060035BE RID: 13758 RVA: 0x001DC670 File Offset: 0x001DA870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousePropertiesEvent()
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x001DC680 File Offset: 0x001DA880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousePropertiesEvent(HousePropertiesEvent other)
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x001DC690 File Offset: 0x001DA890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousePropertiesEvent Clone()
		{
			return null;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x001DC6A0 File Offset: 0x001DA8A0
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x001DC6B0 File Offset: 0x001DA8B0
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x001DC6C0 File Offset: 0x001DA8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DoorsOnMap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x001DC6D0 File Offset: 0x001DA8D0
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x001DC6E0 File Offset: 0x001DA8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HouseInstance Properties
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

		// Token: 0x060035C6 RID: 13766 RVA: 0x001DC6F0 File Offset: 0x001DA8F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x001DC700 File Offset: 0x001DA900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HousePropertiesEvent other)
		{
			return true;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x001DC710 File Offset: 0x001DA910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x001DC720 File Offset: 0x001DA920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x001DC730 File Offset: 0x001DA930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x001DC740 File Offset: 0x001DA940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x001DC750 File Offset: 0x001DA950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x001DC760 File Offset: 0x001DA960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HousePropertiesEvent other)
		{
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x001DC770 File Offset: 0x001DA970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x001DC780 File Offset: 0x001DA980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x001DC790 File Offset: 0x001DA990
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HousePropertiesEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					HousePropertiesEvent._repeated_doorsOnMap_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					continue;
				case 5:
					return;
				}
				HousePropertiesEvent._parser = new MessageParser<HousePropertiesEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x001DC87C File Offset: 0x001DAA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VQuAn0Ot5HPs4bG4WyPw()
		{
			return true;
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x001DC884 File Offset: 0x001DAA84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HousePropertiesEvent LLfiQbOtyyPfnQP3IgkH()
		{
			return null;
		}

		// Token: 0x040012C3 RID: 4803
		private static readonly MessageParser<HousePropertiesEvent> _parser;

		// Token: 0x040012C4 RID: 4804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012C5 RID: 4805
		public const int HouseIdFieldNumber = 1;

		// Token: 0x040012C6 RID: 4806
		private int houseId_;

		// Token: 0x040012C7 RID: 4807
		public const int DoorsOnMapFieldNumber = 2;

		// Token: 0x040012C8 RID: 4808
		private static readonly FieldCodec<int> _repeated_doorsOnMap_codec;

		// Token: 0x040012C9 RID: 4809
		private readonly RepeatedField<int> doorsOnMap_;

		// Token: 0x040012CA RID: 4810
		public const int PropertiesFieldNumber = 3;

		// Token: 0x040012CB RID: 4811
		private HouseInstance properties_;

		// Token: 0x040012CC RID: 4812
		internal static HousePropertiesEvent OMm7JbOtamFw33qrvyMG;
	}
}
