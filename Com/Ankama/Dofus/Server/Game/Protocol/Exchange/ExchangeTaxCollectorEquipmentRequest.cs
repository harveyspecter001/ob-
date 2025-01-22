using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200070F RID: 1807
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTaxCollectorEquipmentRequest : IMessage<ExchangeTaxCollectorEquipmentRequest>, IMessage, IEquatable<ExchangeTaxCollectorEquipmentRequest>, IDeepCloneable<ExchangeTaxCollectorEquipmentRequest>, IBufferMessage
	{
		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0021611C File Offset: 0x0021431C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeTaxCollectorEquipmentRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0021612C File Offset: 0x0021432C
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

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06005869 RID: 22633 RVA: 0x0021613C File Offset: 0x0021433C
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

		// Token: 0x0600586A RID: 22634 RVA: 0x0021614C File Offset: 0x0021434C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentRequest()
		{
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0021615C File Offset: 0x0021435C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentRequest(ExchangeTaxCollectorEquipmentRequest other)
		{
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0021616C File Offset: 0x0021436C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorEquipmentRequest Clone()
		{
			return null;
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600586D RID: 22637 RVA: 0x0021617C File Offset: 0x0021437C
		// (set) Token: 0x0600586E RID: 22638 RVA: 0x0021618C File Offset: 0x0021438C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string TaxCollectorUid
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

		// Token: 0x0600586F RID: 22639 RVA: 0x0021619C File Offset: 0x0021439C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x002161AC File Offset: 0x002143AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTaxCollectorEquipmentRequest other)
		{
			return true;
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x002161BC File Offset: 0x002143BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x002161CC File Offset: 0x002143CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x002161DC File Offset: 0x002143DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x002161EC File Offset: 0x002143EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x002161FC File Offset: 0x002143FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0021620C File Offset: 0x0021440C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTaxCollectorEquipmentRequest other)
		{
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0021621C File Offset: 0x0021441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0021622C File Offset: 0x0021442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0021623C File Offset: 0x0021443C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTaxCollectorEquipmentRequest()
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
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_C1;
					}
					ExchangeTaxCollectorEquipmentRequest._parser = new MessageParser<ExchangeTaxCollectorEquipmentRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
					}
				}
				IL_C1:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x00216324 File Offset: 0x00214524
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PvSf6eOuUAjpR4DosPmp()
		{
			return true;
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0021632C File Offset: 0x0021452C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTaxCollectorEquipmentRequest y0wFVNOuvlpJBpEedOn9()
		{
			return null;
		}

		// Token: 0x04001EFE RID: 7934
		private static readonly MessageParser<ExchangeTaxCollectorEquipmentRequest> _parser;

		// Token: 0x04001EFF RID: 7935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F00 RID: 7936
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x04001F01 RID: 7937
		private string taxCollectorUid_;

		// Token: 0x04001F02 RID: 7938
		internal static ExchangeTaxCollectorEquipmentRequest JFR2J7OucSQy5lHv7S0L;
	}
}
