using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000BB RID: 187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorTopListEvent : IMessage<TaxCollectorTopListEvent>, IMessage, IEquatable<TaxCollectorTopListEvent>, IDeepCloneable<TaxCollectorTopListEvent>, IBufferMessage
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00190AAC File Offset: 0x0018ECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorTopListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00190ABC File Offset: 0x0018ECBC
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00190ACC File Offset: 0x0018ECCC
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

		// Token: 0x06000840 RID: 2112 RVA: 0x00190ADC File Offset: 0x0018ECDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorTopListEvent()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00190AEC File Offset: 0x0018ECEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorTopListEvent(TaxCollectorTopListEvent other)
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00190AFC File Offset: 0x0018ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorTopListEvent Clone()
		{
			return null;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00190B0C File Offset: 0x0018ED0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TaxCollectorInformation> DungeonTaxCollectorsInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00190B1C File Offset: 0x0018ED1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TaxCollectorInformation> WorldTaxCollectorsInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00190B2C File Offset: 0x0018ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00190B3C File Offset: 0x0018ED3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorTopListEvent other)
		{
			return true;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00190B4C File Offset: 0x0018ED4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00190B5C File Offset: 0x0018ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00190B6C File Offset: 0x0018ED6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00190B7C File Offset: 0x0018ED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00190B8C File Offset: 0x0018ED8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00190B9C File Offset: 0x0018ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorTopListEvent other)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00190BAC File Offset: 0x0018EDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00190BBC File Offset: 0x0018EDBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00190BCC File Offset: 0x0018EDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorTopListEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					TaxCollectorTopListEvent._repeated_worldTaxCollectorsInformation_codec = FieldCodec.ForMessage<TaxCollectorInformation>(18U, OjQf6rlEHlpI64eK4V3.XVInXhlssT(OjQf6rlEHlpI64eK4V3.dhhlXuWfjX));
					num2 = 5;
					continue;
				case 4:
					TaxCollectorTopListEvent._repeated_dungeonTaxCollectorsInformation_codec = FieldCodec.ForMessage<TaxCollectorInformation>(10U, OjQf6rlEHlpI64eK4V3.XVInXhlssT(OjQf6rlEHlpI64eK4V3.dhhlXuWfjX));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					return;
				case 6:
					TaxCollectorTopListEvent._parser = new MessageParser<TaxCollectorTopListEvent>(() => null);
					num2 = 4;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 6;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00190D0C File Offset: 0x0018EF0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RBGQ1jOkB3seioMYLEs8()
		{
			return true;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00190D14 File Offset: 0x0018EF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorTopListEvent aNv1yWOkeCFJOruJ0t4c()
		{
			return null;
		}

		// Token: 0x04000305 RID: 773
		private static readonly MessageParser<TaxCollectorTopListEvent> _parser;

		// Token: 0x04000306 RID: 774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000307 RID: 775
		public const int DungeonTaxCollectorsInformationFieldNumber = 1;

		// Token: 0x04000308 RID: 776
		private static readonly FieldCodec<TaxCollectorInformation> _repeated_dungeonTaxCollectorsInformation_codec;

		// Token: 0x04000309 RID: 777
		private readonly RepeatedField<TaxCollectorInformation> dungeonTaxCollectorsInformation_;

		// Token: 0x0400030A RID: 778
		public const int WorldTaxCollectorsInformationFieldNumber = 2;

		// Token: 0x0400030B RID: 779
		private static readonly FieldCodec<TaxCollectorInformation> _repeated_worldTaxCollectorsInformation_codec;

		// Token: 0x0400030C RID: 780
		private readonly RepeatedField<TaxCollectorInformation> worldTaxCollectorsInformation_;

		// Token: 0x0400030D RID: 781
		internal static TaxCollectorTopListEvent SrPBwFOkATW0Bf3uCBdw;
	}
}
