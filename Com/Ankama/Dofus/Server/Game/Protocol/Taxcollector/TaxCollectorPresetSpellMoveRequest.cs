using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000B9 RID: 185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetSpellMoveRequest : IMessage<TaxCollectorPresetSpellMoveRequest>, IMessage, IEquatable<TaxCollectorPresetSpellMoveRequest>, IDeepCloneable<TaxCollectorPresetSpellMoveRequest>, IBufferMessage
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00190870 File Offset: 0x0018EA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorPresetSpellMoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00190880 File Offset: 0x0018EA80
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00190890 File Offset: 0x0018EA90
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

		// Token: 0x06000822 RID: 2082 RVA: 0x001908A0 File Offset: 0x0018EAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellMoveRequest()
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x001908B0 File Offset: 0x0018EAB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellMoveRequest(TaxCollectorPresetSpellMoveRequest other)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x001908C0 File Offset: 0x0018EAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellMoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x001908D0 File Offset: 0x0018EAD0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x001908E0 File Offset: 0x0018EAE0
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x001908F0 File Offset: 0x0018EAF0
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00190900 File Offset: 0x0018EB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromSlotId
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00190910 File Offset: 0x0018EB10
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00190920 File Offset: 0x0018EB20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ToSlotId
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

		// Token: 0x0600082B RID: 2091 RVA: 0x00190930 File Offset: 0x0018EB30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00190940 File Offset: 0x0018EB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetSpellMoveRequest other)
		{
			return true;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00190950 File Offset: 0x0018EB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00190960 File Offset: 0x0018EB60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00190970 File Offset: 0x0018EB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00190980 File Offset: 0x0018EB80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00190990 File Offset: 0x0018EB90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x001909A0 File Offset: 0x0018EBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetSpellMoveRequest other)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x001909B0 File Offset: 0x0018EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x001909C0 File Offset: 0x0018EBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x001909D0 File Offset: 0x0018EBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetSpellMoveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TaxCollectorPresetSpellMoveRequest._parser = new MessageParser<TaxCollectorPresetSpellMoveRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00190A9C File Offset: 0x0018EC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool so01olOkngNv7aIEJhpH()
		{
			return true;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00190AA4 File Offset: 0x0018ECA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetSpellMoveRequest e38V7gOkmHLX4falVuWm()
		{
			return null;
		}

		// Token: 0x040002FA RID: 762
		private static readonly MessageParser<TaxCollectorPresetSpellMoveRequest> _parser;

		// Token: 0x040002FB RID: 763
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002FC RID: 764
		public const int PresetUidFieldNumber = 1;

		// Token: 0x040002FD RID: 765
		private string presetUid_;

		// Token: 0x040002FE RID: 766
		public const int FromSlotIdFieldNumber = 2;

		// Token: 0x040002FF RID: 767
		private int fromSlotId_;

		// Token: 0x04000300 RID: 768
		public const int ToSlotIdFieldNumber = 3;

		// Token: 0x04000301 RID: 769
		private int toSlotId_;

		// Token: 0x04000302 RID: 770
		internal static TaxCollectorPresetSpellMoveRequest EjDlYKOkfcMdEWCRktsr;
	}
}
