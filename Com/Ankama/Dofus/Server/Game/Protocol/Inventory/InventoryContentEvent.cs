using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200041D RID: 1053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InventoryContentEvent : IMessage<InventoryContentEvent>, IMessage, IEquatable<InventoryContentEvent>, IDeepCloneable<InventoryContentEvent>, IBufferMessage
	{
		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x001D57BC File Offset: 0x001D39BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InventoryContentEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x001D57CC File Offset: 0x001D39CC
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x001D57DC File Offset: 0x001D39DC
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

		// Token: 0x060031CD RID: 12749 RVA: 0x001D57EC File Offset: 0x001D39EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentEvent()
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x001D57FC File Offset: 0x001D39FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentEvent(InventoryContentEvent other)
		{
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x001D580C File Offset: 0x001D3A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InventoryContentEvent Clone()
		{
			return null;
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x001D581C File Offset: 0x001D3A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x001D582C File Offset: 0x001D3A2C
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x001D583C File Offset: 0x001D3A3C
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

		// Token: 0x060031D3 RID: 12755 RVA: 0x001D584C File Offset: 0x001D3A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x001D585C File Offset: 0x001D3A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InventoryContentEvent other)
		{
			return true;
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x001D586C File Offset: 0x001D3A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x001D587C File Offset: 0x001D3A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x001D588C File Offset: 0x001D3A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x001D589C File Offset: 0x001D3A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x001D58AC File Offset: 0x001D3AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x001D58BC File Offset: 0x001D3ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InventoryContentEvent other)
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x001D58CC File Offset: 0x001D3ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x001D58DC File Offset: 0x001D3ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x001D58EC File Offset: 0x001D3AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InventoryContentEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_B0;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 4:
						return;
					case 5:
						InventoryContentEvent._parser = new MessageParser<InventoryContentEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
				}
				IL_B0:
				InventoryContentEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
				num = 4;
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x001D59E0 File Offset: 0x001D3BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nr08PFOCDhkS2OqJXDEm()
		{
			return true;
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x001D59E8 File Offset: 0x001D3BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InventoryContentEvent xoQOIpOCtlRHSZ83QXHI()
		{
			return null;
		}

		// Token: 0x04001168 RID: 4456
		private static readonly MessageParser<InventoryContentEvent> _parser;

		// Token: 0x04001169 RID: 4457
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400116A RID: 4458
		public const int ObjectsFieldNumber = 1;

		// Token: 0x0400116B RID: 4459
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x0400116C RID: 4460
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x0400116D RID: 4461
		public const int KamasFieldNumber = 2;

		// Token: 0x0400116E RID: 4462
		private long kamas_;

		// Token: 0x0400116F RID: 4463
		private static InventoryContentEvent VCgcDfOCCXvMvR7dnApO;
	}
}
