using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000B5 RID: 181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetSpellAddRequest : IMessage<TaxCollectorPresetSpellAddRequest>, IMessage, IEquatable<TaxCollectorPresetSpellAddRequest>, IDeepCloneable<TaxCollectorPresetSpellAddRequest>, IBufferMessage
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x001903F4 File Offset: 0x0018E5F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorPresetSpellAddRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00190404 File Offset: 0x0018E604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00190414 File Offset: 0x0018E614
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

		// Token: 0x060007EA RID: 2026 RVA: 0x00190424 File Offset: 0x0018E624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellAddRequest()
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00190434 File Offset: 0x0018E634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellAddRequest(TaxCollectorPresetSpellAddRequest other)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00190444 File Offset: 0x0018E644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellAddRequest Clone()
		{
			return null;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00190454 File Offset: 0x0018E654
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00190464 File Offset: 0x0018E664
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00190474 File Offset: 0x0018E674
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00190484 File Offset: 0x0018E684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorOrderedSpell Spell
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

		// Token: 0x060007F1 RID: 2033 RVA: 0x00190494 File Offset: 0x0018E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x001904A4 File Offset: 0x0018E6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetSpellAddRequest other)
		{
			return true;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x001904B4 File Offset: 0x0018E6B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x001904C4 File Offset: 0x0018E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x001904D4 File Offset: 0x0018E6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x001904E4 File Offset: 0x0018E6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x001904F4 File Offset: 0x0018E6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00190504 File Offset: 0x0018E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetSpellAddRequest other)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00190514 File Offset: 0x0018E714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00190524 File Offset: 0x0018E724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00190534 File Offset: 0x0018E734
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetSpellAddRequest()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TaxCollectorPresetSpellAddRequest._parser = new MessageParser<TaxCollectorPresetSpellAddRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00190618 File Offset: 0x0018E818
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cxEQGnOI86M2CSpWxMjn()
		{
			return true;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00190620 File Offset: 0x0018E820
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetSpellAddRequest dX0hdIOIZvhJp2BdWoRB()
		{
			return null;
		}

		// Token: 0x040002E8 RID: 744
		private static readonly MessageParser<TaxCollectorPresetSpellAddRequest> _parser;

		// Token: 0x040002E9 RID: 745
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002EA RID: 746
		public const int PresetUidFieldNumber = 1;

		// Token: 0x040002EB RID: 747
		private string presetUid_;

		// Token: 0x040002EC RID: 748
		public const int SpellFieldNumber = 2;

		// Token: 0x040002ED RID: 749
		private TaxCollectorOrderedSpell spell_;

		// Token: 0x040002EE RID: 750
		private static TaxCollectorPresetSpellAddRequest aS6xpgOIuoHZWlV58umR;
	}
}
