using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B72 RID: 2930
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismInformation : IMessage<PrismInformation>, IMessage, IEquatable<PrismInformation>, IDeepCloneable<PrismInformation>, IBufferMessage
	{
		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06008C92 RID: 35986 RVA: 0x00269A94 File Offset: 0x00267C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06008C93 RID: 35987 RVA: 0x00269AA4 File Offset: 0x00267CA4
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

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06008C94 RID: 35988 RVA: 0x00269AB4 File Offset: 0x00267CB4
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

		// Token: 0x06008C95 RID: 35989 RVA: 0x00269AC4 File Offset: 0x00267CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismInformation()
		{
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00269AD4 File Offset: 0x00267CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismInformation(PrismInformation other)
		{
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00269AE4 File Offset: 0x00267CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06008C98 RID: 35992 RVA: 0x00269AF4 File Offset: 0x00267CF4
		// (set) Token: 0x06008C99 RID: 35993 RVA: 0x00269B08 File Offset: 0x00267D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrismInformation.Types.PrismState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PrismInformation.Types.PrismState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x00269B18 File Offset: 0x00267D18
		// (set) Token: 0x06008C9B RID: 35995 RVA: 0x00269B28 File Offset: 0x00267D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlacementDate
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

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00269B38 File Offset: 0x00267D38
		// (set) Token: 0x06008C9D RID: 35997 RVA: 0x00269B48 File Offset: 0x00267D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NuggetsCount
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

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06008C9E RID: 35998 RVA: 0x00269B58 File Offset: 0x00267D58
		// (set) Token: 0x06008C9F RID: 35999 RVA: 0x00269B68 File Offset: 0x00267D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Durability
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

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x00269B78 File Offset: 0x00267D78
		// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x00269B88 File Offset: 0x00267D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextEvolutionDate
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

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x00269B98 File Offset: 0x00267D98
		// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x00269BA8 File Offset: 0x00267DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation AllianceInformation
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

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x00269BB8 File Offset: 0x00267DB8
		// (set) Token: 0x06008CA5 RID: 36005 RVA: 0x00269BC8 File Offset: 0x00267DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismModule Module
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

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x00269BD8 File Offset: 0x00267DD8
		// (set) Token: 0x06008CA7 RID: 36007 RVA: 0x00269BE8 File Offset: 0x00267DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismCristal Cristal
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

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x00269BF8 File Offset: 0x00267DF8
		// (set) Token: 0x06008CA9 RID: 36009 RVA: 0x00269C08 File Offset: 0x00267E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CristalNumberLeft
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

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x00269C18 File Offset: 0x00267E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasCristalNumberLeft
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00269C28 File Offset: 0x00267E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCristalNumberLeft()
		{
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00269C38 File Offset: 0x00267E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x00269C48 File Offset: 0x00267E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismInformation other)
		{
			return true;
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x00269C58 File Offset: 0x00267E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00269C68 File Offset: 0x00267E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x00269C78 File Offset: 0x00267E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x00269C88 File Offset: 0x00267E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00269C98 File Offset: 0x00267E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00269CA8 File Offset: 0x00267EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismInformation other)
		{
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x00269CB8 File Offset: 0x00267EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00269CC8 File Offset: 0x00267EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00269CD8 File Offset: 0x00267ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismInformation()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 4:
						PrismInformation.CristalNumberLeftDefaultValue = 0;
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						goto IL_3A;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 3;
					}
				}
				IL_3A:
				PrismInformation._parser = new MessageParser<PrismInformation>(() => null);
				num = 4;
			}
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00269DD4 File Offset: 0x00267FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xrcYYjJ99tbwqVCBFyTd()
		{
			return true;
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x00269DDC File Offset: 0x00267FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismInformation Cyp6HAJ929hn4BlQWTA7()
		{
			return null;
		}

		// Token: 0x040033F1 RID: 13297
		private static readonly MessageParser<PrismInformation> _parser;

		// Token: 0x040033F2 RID: 13298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F3 RID: 13299
		private int _hasBits0;

		// Token: 0x040033F4 RID: 13300
		public const int StateFieldNumber = 1;

		// Token: 0x040033F5 RID: 13301
		private PrismInformation.Types.PrismState state_;

		// Token: 0x040033F6 RID: 13302
		public const int PlacementDateFieldNumber = 2;

		// Token: 0x040033F7 RID: 13303
		private long placementDate_;

		// Token: 0x040033F8 RID: 13304
		public const int NuggetsCountFieldNumber = 3;

		// Token: 0x040033F9 RID: 13305
		private long nuggetsCount_;

		// Token: 0x040033FA RID: 13306
		public const int DurabilityFieldNumber = 4;

		// Token: 0x040033FB RID: 13307
		private int durability_;

		// Token: 0x040033FC RID: 13308
		public const int NextEvolutionDateFieldNumber = 5;

		// Token: 0x040033FD RID: 13309
		private long nextEvolutionDate_;

		// Token: 0x040033FE RID: 13310
		public const int AllianceInformationFieldNumber = 6;

		// Token: 0x040033FF RID: 13311
		private AllianceInformation allianceInformation_;

		// Token: 0x04003400 RID: 13312
		public const int ModuleFieldNumber = 7;

		// Token: 0x04003401 RID: 13313
		private PrismModule module_;

		// Token: 0x04003402 RID: 13314
		public const int CristalFieldNumber = 8;

		// Token: 0x04003403 RID: 13315
		private PrismCristal cristal_;

		// Token: 0x04003404 RID: 13316
		public const int CristalNumberLeftFieldNumber = 9;

		// Token: 0x04003405 RID: 13317
		private static readonly int CristalNumberLeftDefaultValue;

		// Token: 0x04003406 RID: 13318
		private int cristalNumberLeft_;

		// Token: 0x04003407 RID: 13319
		private static PrismInformation CsVv6UJ9daR7CZTGCE3r;

		// Token: 0x02000B73 RID: 2931
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008CB9 RID: 36025 RVA: 0x002E42A8 File Offset: 0x002E24A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B74 RID: 2932
			public enum PrismState
			{
				// Token: 0x04003409 RID: 13321
				[OriginalName("NORMAL")]
				Normal,
				// Token: 0x0400340A RID: 13322
				[OriginalName("WEAKENED")]
				Weakened,
				// Token: 0x0400340B RID: 13323
				[OriginalName("VULNERABLE")]
				Vulnerable,
				// Token: 0x0400340C RID: 13324
				[OriginalName("PROTECTED")]
				Protected,
				// Token: 0x0400340D RID: 13325
				[OriginalName("INHIBITED")]
				Inhibited
			}
		}
	}
}
