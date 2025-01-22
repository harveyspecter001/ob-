using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006D0 RID: 1744
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferListToInventoryRequest : IMessage<ExchangeObjectTransferListToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListToInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x002123C0 File Offset: 0x002105C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectTransferListToInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x002123D0 File Offset: 0x002105D0
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

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x002123E0 File Offset: 0x002105E0
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

		// Token: 0x06005552 RID: 21842 RVA: 0x002123F0 File Offset: 0x002105F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListToInventoryRequest()
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00212400 File Offset: 0x00210600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListToInventoryRequest(ExchangeObjectTransferListToInventoryRequest other)
		{
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00212410 File Offset: 0x00210610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListToInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06005555 RID: 21845 RVA: 0x00212420 File Offset: 0x00210620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00212430 File Offset: 0x00210630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00212440 File Offset: 0x00210640
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferListToInventoryRequest other)
		{
			return true;
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00212450 File Offset: 0x00210650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00212460 File Offset: 0x00210660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00212470 File Offset: 0x00210670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00212480 File Offset: 0x00210680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00212490 File Offset: 0x00210690
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x002124A0 File Offset: 0x002106A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferListToInventoryRequest other)
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x002124B0 File Offset: 0x002106B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x002124C0 File Offset: 0x002106C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x002124D0 File Offset: 0x002106D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferListToInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_B5;
					case 3:
						ExchangeObjectTransferListToInventoryRequest._repeated_objectsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
					}
				}
				IL_B5:
				ExchangeObjectTransferListToInventoryRequest._parser = new MessageParser<ExchangeObjectTransferListToInventoryRequest>(() => null);
				num = 3;
			}
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x002125EC File Offset: 0x002107EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SwI42UOMmRe1CdAEHOGr()
		{
			return true;
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x002125F4 File Offset: 0x002107F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferListToInventoryRequest cpwLC0OMAepuraWLrDyb()
		{
			return null;
		}

		// Token: 0x04001E02 RID: 7682
		private static readonly MessageParser<ExchangeObjectTransferListToInventoryRequest> _parser;

		// Token: 0x04001E03 RID: 7683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E04 RID: 7684
		public const int ObjectsUidFieldNumber = 1;

		// Token: 0x04001E05 RID: 7685
		private static readonly FieldCodec<int> _repeated_objectsUid_codec;

		// Token: 0x04001E06 RID: 7686
		private readonly RepeatedField<int> objectsUid_;

		// Token: 0x04001E07 RID: 7687
		internal static ExchangeObjectTransferListToInventoryRequest L1N1X4OMntTIgMujxfXq;
	}
}
