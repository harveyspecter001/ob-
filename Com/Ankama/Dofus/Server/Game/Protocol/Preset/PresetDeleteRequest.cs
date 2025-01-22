using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200022E RID: 558
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetDeleteRequest : IMessage<PresetDeleteRequest>, IMessage, IEquatable<PresetDeleteRequest>, IDeepCloneable<PresetDeleteRequest>, IBufferMessage
	{
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x001B0004 File Offset: 0x001AE204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetDeleteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x001B0014 File Offset: 0x001AE214
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x001B0024 File Offset: 0x001AE224
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

		// Token: 0x06001A1A RID: 6682 RVA: 0x001B0034 File Offset: 0x001AE234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteRequest()
		{
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x001B0044 File Offset: 0x001AE244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteRequest(PresetDeleteRequest other)
		{
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x001B0054 File Offset: 0x001AE254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetDeleteRequest Clone()
		{
			return null;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x001B0064 File Offset: 0x001AE264
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x001B0074 File Offset: 0x001AE274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x001B0084 File Offset: 0x001AE284
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x001B0098 File Offset: 0x001AE298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetType PresetType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x001B00A8 File Offset: 0x001AE2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x001B00B8 File Offset: 0x001AE2B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetDeleteRequest other)
		{
			return true;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x001B00C8 File Offset: 0x001AE2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x001B00D8 File Offset: 0x001AE2D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x001B00E8 File Offset: 0x001AE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x001B00F8 File Offset: 0x001AE2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x001B0108 File Offset: 0x001AE308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x001B0118 File Offset: 0x001AE318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetDeleteRequest other)
		{
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x001B0128 File Offset: 0x001AE328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x001B0138 File Offset: 0x001AE338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x001B0148 File Offset: 0x001AE348
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetDeleteRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					PresetDeleteRequest._parser = new MessageParser<PresetDeleteRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x001B0240 File Offset: 0x001AE440
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rDl0ZXOaYHkUigOT9Yb2()
		{
			return true;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x001B0248 File Offset: 0x001AE448
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetDeleteRequest sU9iyHOabYRMiYNCEgFJ()
		{
			return null;
		}

		// Token: 0x04000944 RID: 2372
		private static readonly MessageParser<PresetDeleteRequest> _parser;

		// Token: 0x04000945 RID: 2373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000946 RID: 2374
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000947 RID: 2375
		private string presetUuid_;

		// Token: 0x04000948 RID: 2376
		public const int PresetTypeFieldNumber = 2;

		// Token: 0x04000949 RID: 2377
		private PresetType presetType_;

		// Token: 0x0400094A RID: 2378
		private static PresetDeleteRequest eTO1JPOaH5Oe7l3uu5dF;
	}
}
