using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000B7 RID: 183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetSpellRemoveRequest : IMessage<TaxCollectorPresetSpellRemoveRequest>, IMessage, IEquatable<TaxCollectorPresetSpellRemoveRequest>, IDeepCloneable<TaxCollectorPresetSpellRemoveRequest>, IBufferMessage
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00190628 File Offset: 0x0018E828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorPresetSpellRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00190638 File Offset: 0x0018E838
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00190648 File Offset: 0x0018E848
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

		// Token: 0x06000806 RID: 2054 RVA: 0x00190658 File Offset: 0x0018E858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellRemoveRequest()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00190668 File Offset: 0x0018E868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellRemoveRequest(TaxCollectorPresetSpellRemoveRequest other)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00190678 File Offset: 0x0018E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00190688 File Offset: 0x0018E888
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00190698 File Offset: 0x0018E898
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PresetUid
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x001906A8 File Offset: 0x0018E8A8
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x001906B8 File Offset: 0x0018E8B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SlotId
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

		// Token: 0x0600080D RID: 2061 RVA: 0x001906C8 File Offset: 0x0018E8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x001906D8 File Offset: 0x0018E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetSpellRemoveRequest other)
		{
			return true;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x001906E8 File Offset: 0x0018E8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x001906F8 File Offset: 0x0018E8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00190708 File Offset: 0x0018E908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00190718 File Offset: 0x0018E918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00190728 File Offset: 0x0018E928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00190738 File Offset: 0x0018E938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetSpellRemoveRequest other)
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00190748 File Offset: 0x0018E948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00190758 File Offset: 0x0018E958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00190768 File Offset: 0x0018E968
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetSpellRemoveRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					TaxCollectorPresetSpellRemoveRequest._parser = new MessageParser<TaxCollectorPresetSpellRemoveRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00190860 File Offset: 0x0018EA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yrFukUOIFWO2fGZFqU55()
		{
			return true;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00190868 File Offset: 0x0018EA68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetSpellRemoveRequest LqpvIYOIzlHS509iimgQ()
		{
			return null;
		}

		// Token: 0x040002F1 RID: 753
		private static readonly MessageParser<TaxCollectorPresetSpellRemoveRequest> _parser;

		// Token: 0x040002F2 RID: 754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002F3 RID: 755
		public const int PresetUidFieldNumber = 1;

		// Token: 0x040002F4 RID: 756
		private string presetUid_;

		// Token: 0x040002F5 RID: 757
		public const int SlotIdFieldNumber = 2;

		// Token: 0x040002F6 RID: 758
		private int slotId_;

		// Token: 0x040002F7 RID: 759
		internal static TaxCollectorPresetSpellRemoveRequest eEBgHwOIq4h8vimNCU7u;
	}
}
