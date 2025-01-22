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
	// Token: 0x02000789 RID: 1929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountWithoutPaddockStartedEvent : IMessage<ExchangeMountWithoutPaddockStartedEvent>, IMessage, IEquatable<ExchangeMountWithoutPaddockStartedEvent>, IDeepCloneable<ExchangeMountWithoutPaddockStartedEvent>, IBufferMessage
	{
		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x0021D660 File Offset: 0x0021B860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeMountWithoutPaddockStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06005E9A RID: 24218 RVA: 0x0021D670 File Offset: 0x0021B870
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

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x0021D680 File Offset: 0x0021B880
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

		// Token: 0x06005E9C RID: 24220 RVA: 0x0021D690 File Offset: 0x0021B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountWithoutPaddockStartedEvent()
		{
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0021D6A0 File Offset: 0x0021B8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountWithoutPaddockStartedEvent(ExchangeMountWithoutPaddockStartedEvent other)
		{
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x0021D6B0 File Offset: 0x0021B8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountWithoutPaddockStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x0021D6C0 File Offset: 0x0021B8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MountData> StabledMounts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x0021D6D0 File Offset: 0x0021B8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MountData> PaddockedMounts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0021D6E0 File Offset: 0x0021B8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x0021D6F0 File Offset: 0x0021B8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountWithoutPaddockStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x0021D700 File Offset: 0x0021B900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x0021D710 File Offset: 0x0021B910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x0021D720 File Offset: 0x0021B920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0021D730 File Offset: 0x0021B930
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0021D740 File Offset: 0x0021B940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0021D750 File Offset: 0x0021B950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountWithoutPaddockStartedEvent other)
		{
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x0021D760 File Offset: 0x0021B960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x0021D770 File Offset: 0x0021B970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0021D780 File Offset: 0x0021B980
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountWithoutPaddockStartedEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeMountWithoutPaddockStartedEvent._repeated_paddockedMounts_codec = FieldCodec.ForMessage<MountData>(18U, uZWv2vA6viUJSmHpxF4k.XVInXhlssT(uZWv2vA6viUJSmHpxF4k.zN6A6oXMqvt));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					ExchangeMountWithoutPaddockStartedEvent._parser = new MessageParser<ExchangeMountWithoutPaddockStartedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 6:
					ExchangeMountWithoutPaddockStartedEvent._repeated_stabledMounts_codec = FieldCodec.ForMessage<MountData>(10U, uZWv2vA6viUJSmHpxF4k.XVInXhlssT(uZWv2vA6viUJSmHpxF4k.zN6A6oXMqvt));
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0021D8AC File Offset: 0x0021BAAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bN60AkOZqQI4iv2S67BD()
		{
			return true;
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x0021D8B4 File Offset: 0x0021BAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountWithoutPaddockStartedEvent myde1QOZFMR3dxrL5Hgs()
		{
			return null;
		}

		// Token: 0x04002144 RID: 8516
		private static readonly MessageParser<ExchangeMountWithoutPaddockStartedEvent> _parser;

		// Token: 0x04002145 RID: 8517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002146 RID: 8518
		public const int StabledMountsFieldNumber = 1;

		// Token: 0x04002147 RID: 8519
		private static readonly FieldCodec<MountData> _repeated_stabledMounts_codec;

		// Token: 0x04002148 RID: 8520
		private readonly RepeatedField<MountData> stabledMounts_;

		// Token: 0x04002149 RID: 8521
		public const int PaddockedMountsFieldNumber = 2;

		// Token: 0x0400214A RID: 8522
		private static readonly FieldCodec<MountData> _repeated_paddockedMounts_codec;

		// Token: 0x0400214B RID: 8523
		private readonly RepeatedField<MountData> paddockedMounts_;

		// Token: 0x0400214C RID: 8524
		private static ExchangeMountWithoutPaddockStartedEvent fFhamSOZZwh3R0y2btrj;
	}
}
