using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000BAF RID: 2991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellItem : IMessage<SpellItem>, IMessage, IEquatable<SpellItem>, IDeepCloneable<SpellItem>, IBufferMessage
	{
		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x0026CBA0 File Offset: 0x0026ADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06008FD9 RID: 36825 RVA: 0x0026CBB0 File Offset: 0x0026ADB0
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

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06008FDA RID: 36826 RVA: 0x0026CBC0 File Offset: 0x0026ADC0
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

		// Token: 0x06008FDB RID: 36827 RVA: 0x0026CBD0 File Offset: 0x0026ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem()
		{
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x0026CBE0 File Offset: 0x0026ADE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem(SpellItem other)
		{
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0026CBF0 File Offset: 0x0026ADF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellItem Clone()
		{
			return null;
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x0026CC00 File Offset: 0x0026AE00
		// (set) Token: 0x06008FDF RID: 36831 RVA: 0x0026CC10 File Offset: 0x0026AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellId
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

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x0026CC20 File Offset: 0x0026AE20
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x0026CC30 File Offset: 0x0026AE30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellLevel
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

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06008FE2 RID: 36834 RVA: 0x0026CC40 File Offset: 0x0026AE40
		// (set) Token: 0x06008FE3 RID: 36835 RVA: 0x0026CC50 File Offset: 0x0026AE50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Available
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06008FE4 RID: 36836 RVA: 0x0026CC60 File Offset: 0x0026AE60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0026CC70 File Offset: 0x0026AE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAvailable()
		{
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0026CC80 File Offset: 0x0026AE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0026CC90 File Offset: 0x0026AE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellItem other)
		{
			return true;
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0026CCA0 File Offset: 0x0026AEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0026CCB0 File Offset: 0x0026AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0026CCC0 File Offset: 0x0026AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0026CCD0 File Offset: 0x0026AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x0026CCE0 File Offset: 0x0026AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0026CCF0 File Offset: 0x0026AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellItem other)
		{
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0026CD00 File Offset: 0x0026AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0026CD10 File Offset: 0x0026AF10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0026CD20 File Offset: 0x0026AF20
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellItem()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					SpellItem.AvailableDefaultValue = false;
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					SpellItem._parser = new MessageParser<SpellItem>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0026CE2C File Offset: 0x0026B02C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kDdfUwJ2A4h3HnsjP02e()
		{
			return true;
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0026CE34 File Offset: 0x0026B034
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellItem z6jeCWJ2B7g2pU4BPaNE()
		{
			return null;
		}

		// Token: 0x04003595 RID: 13717
		private static readonly MessageParser<SpellItem> _parser;

		// Token: 0x04003596 RID: 13718
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003597 RID: 13719
		private int _hasBits0;

		// Token: 0x04003598 RID: 13720
		public const int SpellIdFieldNumber = 1;

		// Token: 0x04003599 RID: 13721
		private int spellId_;

		// Token: 0x0400359A RID: 13722
		public const int SpellLevelFieldNumber = 2;

		// Token: 0x0400359B RID: 13723
		private int spellLevel_;

		// Token: 0x0400359C RID: 13724
		public const int AvailableFieldNumber = 3;

		// Token: 0x0400359D RID: 13725
		private static readonly bool AvailableDefaultValue;

		// Token: 0x0400359E RID: 13726
		private bool available_;

		// Token: 0x0400359F RID: 13727
		private static SpellItem kaAeB7J2mewl94n3mHbO;
	}
}
