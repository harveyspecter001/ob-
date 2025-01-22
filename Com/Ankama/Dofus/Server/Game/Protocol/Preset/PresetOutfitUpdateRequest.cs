using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200026F RID: 623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetOutfitUpdateRequest : IMessage<PresetOutfitUpdateRequest>, IMessage, IEquatable<PresetOutfitUpdateRequest>, IDeepCloneable<PresetOutfitUpdateRequest>, IBufferMessage
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x001B2CAC File Offset: 0x001B0EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetOutfitUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x001B2CBC File Offset: 0x001B0EBC
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x001B2CCC File Offset: 0x001B0ECC
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

		// Token: 0x06001D10 RID: 7440 RVA: 0x001B2CDC File Offset: 0x001B0EDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateRequest()
		{
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x001B2CEC File Offset: 0x001B0EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateRequest(PresetOutfitUpdateRequest other)
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x001B2CFC File Offset: 0x001B0EFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOutfitUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x001B2D0C File Offset: 0x001B0F0C
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x001B2D1C File Offset: 0x001B0F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUuid
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x001B2D2C File Offset: 0x001B0F2C
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x001B2D3C File Offset: 0x001B0F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutfitUuid
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x001B2D4C File Offset: 0x001B0F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOutfitUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x001B2D5C File Offset: 0x001B0F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOutfitUuid()
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x001B2D6C File Offset: 0x001B0F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x001B2D7C File Offset: 0x001B0F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetOutfitUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x001B2D8C File Offset: 0x001B0F8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x001B2D9C File Offset: 0x001B0F9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x001B2DAC File Offset: 0x001B0FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x001B2DBC File Offset: 0x001B0FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x001B2DCC File Offset: 0x001B0FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x001B2DDC File Offset: 0x001B0FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetOutfitUpdateRequest other)
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x001B2DEC File Offset: 0x001B0FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x001B2DFC File Offset: 0x001B0FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x001B2E0C File Offset: 0x001B100C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetOutfitUpdateRequest()
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
					default:
						goto IL_39;
					case 1:
						return;
					case 2:
						PresetOutfitUpdateRequest._parser = new MessageParser<PresetOutfitUpdateRequest>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						PresetOutfitUpdateRequest.OutfitUuidDefaultValue = "";
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						break;
					}
				}
				IL_39:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x001B2F0C File Offset: 0x001B110C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CxU9DXO5pdTfZTV5ipic()
		{
			return true;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x001B2F14 File Offset: 0x001B1114
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetOutfitUpdateRequest G3KOhqO5HE926DnR91Rq()
		{
			return null;
		}

		// Token: 0x04000A4B RID: 2635
		private static readonly MessageParser<PresetOutfitUpdateRequest> _parser;

		// Token: 0x04000A4C RID: 2636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A4D RID: 2637
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000A4E RID: 2638
		private string presetUuid_;

		// Token: 0x04000A4F RID: 2639
		public const int OutfitUuidFieldNumber = 2;

		// Token: 0x04000A50 RID: 2640
		private static readonly string OutfitUuidDefaultValue;

		// Token: 0x04000A51 RID: 2641
		private string outfitUuid_;

		// Token: 0x04000A52 RID: 2642
		internal static PresetOutfitUpdateRequest DHAUuuO5T85V5CSvy9qO;
	}
}
