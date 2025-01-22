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
	// Token: 0x0200076A RID: 1898
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTaxCollectorShopStartedEvent : IMessage<ExchangeTaxCollectorShopStartedEvent>, IMessage, IEquatable<ExchangeTaxCollectorShopStartedEvent>, IDeepCloneable<ExchangeTaxCollectorShopStartedEvent>, IBufferMessage
	{
		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x0021BCFC File Offset: 0x00219EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeTaxCollectorShopStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06005D06 RID: 23814 RVA: 0x0021BD0C File Offset: 0x00219F0C
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

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06005D07 RID: 23815 RVA: 0x0021BD1C File Offset: 0x00219F1C
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

		// Token: 0x06005D08 RID: 23816 RVA: 0x0021BD2C File Offset: 0x00219F2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorShopStartedEvent()
		{
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x0021BD3C File Offset: 0x00219F3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorShopStartedEvent(ExchangeTaxCollectorShopStartedEvent other)
		{
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x0021BD4C File Offset: 0x00219F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorShopStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06005D0B RID: 23819 RVA: 0x0021BD5C File Offset: 0x00219F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x0021BD6C File Offset: 0x00219F6C
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x0021BD7C File Offset: 0x00219F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Kamas
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

		// Token: 0x06005D0E RID: 23822 RVA: 0x0021BD8C File Offset: 0x00219F8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x0021BD9C File Offset: 0x00219F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTaxCollectorShopStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x0021BDAC File Offset: 0x00219FAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x0021BDBC File Offset: 0x00219FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x0021BDCC File Offset: 0x00219FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x0021BDDC File Offset: 0x00219FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x0021BDEC File Offset: 0x00219FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x0021BDFC File Offset: 0x00219FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTaxCollectorShopStartedEvent other)
		{
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x0021BE0C File Offset: 0x0021A00C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x0021BE1C File Offset: 0x0021A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x0021BE2C File Offset: 0x0021A02C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTaxCollectorShopStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_AF;
					case 5:
						ExchangeTaxCollectorShopStartedEvent._parser = new MessageParser<ExchangeTaxCollectorShopStartedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					ExchangeTaxCollectorShopStartedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 1;
					}
				}
				IL_AF:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x0021BF38 File Offset: 0x0021A138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b4nKHUOZcukI3g7v4AHh()
		{
			return true;
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x0021BF40 File Offset: 0x0021A140
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTaxCollectorShopStartedEvent Ihwm4YOZUsSyo9HHUXMI()
		{
			return null;
		}

		// Token: 0x040020AB RID: 8363
		private static readonly MessageParser<ExchangeTaxCollectorShopStartedEvent> _parser;

		// Token: 0x040020AC RID: 8364
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020AD RID: 8365
		public const int ObjectsFieldNumber = 1;

		// Token: 0x040020AE RID: 8366
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x040020AF RID: 8367
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x040020B0 RID: 8368
		public const int KamasFieldNumber = 2;

		// Token: 0x040020B1 RID: 8369
		private long kamas_;

		// Token: 0x040020B2 RID: 8370
		private static ExchangeTaxCollectorShopStartedEvent wP0mMaOZlMEjTBnVTRKw;
	}
}
