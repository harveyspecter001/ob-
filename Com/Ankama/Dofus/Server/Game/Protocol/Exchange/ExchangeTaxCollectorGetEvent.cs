using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000783 RID: 1923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTaxCollectorGetEvent : IMessage<ExchangeTaxCollectorGetEvent>, IMessage, IEquatable<ExchangeTaxCollectorGetEvent>, IDeepCloneable<ExchangeTaxCollectorGetEvent>, IBufferMessage
	{
		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0021CF60 File Offset: 0x0021B160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeTaxCollectorGetEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x0021CF70 File Offset: 0x0021B170
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

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0021CF80 File Offset: 0x0021B180
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

		// Token: 0x06005E45 RID: 24133 RVA: 0x0021CF90 File Offset: 0x0021B190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorGetEvent()
		{
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x0021CFA0 File Offset: 0x0021B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorGetEvent(ExchangeTaxCollectorGetEvent other)
		{
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x0021CFB0 File Offset: 0x0021B1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorGetEvent Clone()
		{
			return null;
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0021CFC0 File Offset: 0x0021B1C0
		// (set) Token: 0x06005E49 RID: 24137 RVA: 0x0021CFD0 File Offset: 0x0021B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CollectorName
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

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005E4A RID: 24138 RVA: 0x0021CFE0 File Offset: 0x0021B1E0
		// (set) Token: 0x06005E4B RID: 24139 RVA: 0x0021CFF0 File Offset: 0x0021B1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapExtendedCoordinates Coordinates
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

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06005E4C RID: 24140 RVA: 0x0021D000 File Offset: 0x0021B200
		// (set) Token: 0x06005E4D RID: 24141 RVA: 0x0021D010 File Offset: 0x0021B210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string UserName
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

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06005E4E RID: 24142 RVA: 0x0021D020 File Offset: 0x0021B220
		// (set) Token: 0x06005E4F RID: 24143 RVA: 0x0021D030 File Offset: 0x0021B230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CallerId
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x0021D040 File Offset: 0x0021B240
		// (set) Token: 0x06005E51 RID: 24145 RVA: 0x0021D050 File Offset: 0x0021B250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CallerName
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

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x0021D060 File Offset: 0x0021B260
		// (set) Token: 0x06005E53 RID: 24147 RVA: 0x0021D070 File Offset: 0x0021B270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Pods
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

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06005E54 RID: 24148 RVA: 0x0021D080 File Offset: 0x0021B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectGidWithQuantity> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x0021D090 File Offset: 0x0021B290
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x0021D0A0 File Offset: 0x0021B2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLook Look
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

		// Token: 0x06005E57 RID: 24151 RVA: 0x0021D0B0 File Offset: 0x0021B2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x0021D0C0 File Offset: 0x0021B2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTaxCollectorGetEvent other)
		{
			return true;
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x0021D0D0 File Offset: 0x0021B2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x0021D0E0 File Offset: 0x0021B2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x0021D0F0 File Offset: 0x0021B2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x0021D100 File Offset: 0x0021B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0021D110 File Offset: 0x0021B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x0021D120 File Offset: 0x0021B320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTaxCollectorGetEvent other)
		{
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x0021D130 File Offset: 0x0021B330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x0021D140 File Offset: 0x0021B340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0021D150 File Offset: 0x0021B350
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTaxCollectorGetEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 5:
					ExchangeTaxCollectorGetEvent._parser = new MessageParser<ExchangeTaxCollectorGetEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ExchangeTaxCollectorGetEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectGidWithQuantity>(58U, hKDwCgAvDnD1E1yKRZW2.XVInXhlssT(hKDwCgAvDnD1E1yKRZW2.pYwAvtKyGS9));
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x0021D26C File Offset: 0x0021B46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TssRgIOZYGBsL6bqD6sV()
		{
			return true;
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x0021D274 File Offset: 0x0021B474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTaxCollectorGetEvent LQQP16OZbokna6facxKV()
		{
			return null;
		}

		// Token: 0x04002124 RID: 8484
		private static readonly MessageParser<ExchangeTaxCollectorGetEvent> _parser;

		// Token: 0x04002125 RID: 8485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002126 RID: 8486
		public const int CollectorNameFieldNumber = 1;

		// Token: 0x04002127 RID: 8487
		private string collectorName_;

		// Token: 0x04002128 RID: 8488
		public const int CoordinatesFieldNumber = 2;

		// Token: 0x04002129 RID: 8489
		private MapExtendedCoordinates coordinates_;

		// Token: 0x0400212A RID: 8490
		public const int UserNameFieldNumber = 3;

		// Token: 0x0400212B RID: 8491
		private string userName_;

		// Token: 0x0400212C RID: 8492
		public const int CallerIdFieldNumber = 4;

		// Token: 0x0400212D RID: 8493
		private long callerId_;

		// Token: 0x0400212E RID: 8494
		public const int CallerNameFieldNumber = 5;

		// Token: 0x0400212F RID: 8495
		private string callerName_;

		// Token: 0x04002130 RID: 8496
		public const int PodsFieldNumber = 6;

		// Token: 0x04002131 RID: 8497
		private int pods_;

		// Token: 0x04002132 RID: 8498
		public const int ObjectsFieldNumber = 7;

		// Token: 0x04002133 RID: 8499
		private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_objects_codec;

		// Token: 0x04002134 RID: 8500
		private readonly RepeatedField<ObjectGidWithQuantity> objects_;

		// Token: 0x04002135 RID: 8501
		public const int LookFieldNumber = 8;

		// Token: 0x04002136 RID: 8502
		private EntityLook look_;

		// Token: 0x04002137 RID: 8503
		private static ExchangeTaxCollectorGetEvent ulwcHBOZH63IfNK09JFc;
	}
}
