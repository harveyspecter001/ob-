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
	// Token: 0x02000232 RID: 562
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetUseRequest : IMessage<PresetUseRequest>, IMessage, IEquatable<PresetUseRequest>, IDeepCloneable<PresetUseRequest>, IBufferMessage
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x001B0450 File Offset: 0x001AE650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetUseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x001B0460 File Offset: 0x001AE660
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x001B0470 File Offset: 0x001AE670
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

		// Token: 0x06001A50 RID: 6736 RVA: 0x001B0480 File Offset: 0x001AE680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseRequest()
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x001B0490 File Offset: 0x001AE690
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseRequest(PresetUseRequest other)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x001B04A0 File Offset: 0x001AE6A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetUseRequest Clone()
		{
			return null;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x001B04B0 File Offset: 0x001AE6B0
		// (set) Token: 0x06001A54 RID: 6740 RVA: 0x001B04C0 File Offset: 0x001AE6C0
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x001B04D0 File Offset: 0x001AE6D0
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x001B04E4 File Offset: 0x001AE6E4
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

		// Token: 0x06001A57 RID: 6743 RVA: 0x001B04F4 File Offset: 0x001AE6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x001B0504 File Offset: 0x001AE704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetUseRequest other)
		{
			return true;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x001B0514 File Offset: 0x001AE714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x001B0524 File Offset: 0x001AE724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x001B0534 File Offset: 0x001AE734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x001B0544 File Offset: 0x001AE744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x001B0554 File Offset: 0x001AE754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x001B0564 File Offset: 0x001AE764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetUseRequest other)
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x001B0574 File Offset: 0x001AE774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x001B0584 File Offset: 0x001AE784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x001B0594 File Offset: 0x001AE794
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetUseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_36;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					PresetUseRequest._parser = new MessageParser<PresetUseRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 1;
					}
				}
				IL_36:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x001B067C File Offset: 0x001AE87C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BNkm29OaucdgPC9i3yKD()
		{
			return true;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x001B0684 File Offset: 0x001AE884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetUseRequest CB5nE7Oa8p0GAFDCas2e()
		{
			return null;
		}

		// Token: 0x04000954 RID: 2388
		private static readonly MessageParser<PresetUseRequest> _parser;

		// Token: 0x04000955 RID: 2389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000956 RID: 2390
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000957 RID: 2391
		private string presetUuid_;

		// Token: 0x04000958 RID: 2392
		public const int PresetTypeFieldNumber = 2;

		// Token: 0x04000959 RID: 2393
		private PresetType presetType_;

		// Token: 0x0400095A RID: 2394
		private static PresetUseRequest CUPi4EOaMAMa0ye777v7;
	}
}
