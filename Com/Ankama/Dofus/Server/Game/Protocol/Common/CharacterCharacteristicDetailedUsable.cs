using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A5B RID: 2651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicDetailedUsable : IMessage<CharacterCharacteristicDetailedUsable>, IMessage, IEquatable<CharacterCharacteristicDetailedUsable>, IDeepCloneable<CharacterCharacteristicDetailedUsable>, IBufferMessage
	{
		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x0025DEDC File Offset: 0x0025C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCharacteristicDetailedUsable> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0025DEEC File Offset: 0x0025C0EC
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

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x0025DEFC File Offset: 0x0025C0FC
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

		// Token: 0x06007E6D RID: 32365 RVA: 0x0025DF0C File Offset: 0x0025C10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailedUsable()
		{
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x0025DF1C File Offset: 0x0025C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailedUsable(CharacterCharacteristicDetailedUsable other)
		{
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x0025DF2C File Offset: 0x0025C12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailedUsable Clone()
		{
			return null;
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0025DF3C File Offset: 0x0025C13C
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x0025DF4C File Offset: 0x0025C14C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Base
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0025DF5C File Offset: 0x0025C15C
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x0025DF6C File Offset: 0x0025C16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Additional
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

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0025DF7C File Offset: 0x0025C17C
		// (set) Token: 0x06007E75 RID: 32373 RVA: 0x0025DF8C File Offset: 0x0025C18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectsAndMountBonus
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

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x0025DF9C File Offset: 0x0025C19C
		// (set) Token: 0x06007E77 RID: 32375 RVA: 0x0025DFAC File Offset: 0x0025C1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AlignmentGiftBonus
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

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007E78 RID: 32376 RVA: 0x0025DFBC File Offset: 0x0025C1BC
		// (set) Token: 0x06007E79 RID: 32377 RVA: 0x0025DFCC File Offset: 0x0025C1CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ContextModification
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

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x0025DFDC File Offset: 0x0025C1DC
		// (set) Token: 0x06007E7B RID: 32379 RVA: 0x0025DFEC File Offset: 0x0025C1EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Used
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

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06007E7C RID: 32380 RVA: 0x0025DFFC File Offset: 0x0025C1FC
		// (set) Token: 0x06007E7D RID: 32381 RVA: 0x0025E00C File Offset: 0x0025C20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Temporary
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

		// Token: 0x06007E7E RID: 32382 RVA: 0x0025E01C File Offset: 0x0025C21C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0025E02C File Offset: 0x0025C22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicDetailedUsable other)
		{
			return true;
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0025E03C File Offset: 0x0025C23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x0025E04C File Offset: 0x0025C24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0025E05C File Offset: 0x0025C25C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0025E06C File Offset: 0x0025C26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0025E07C File Offset: 0x0025C27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x0025E08C File Offset: 0x0025C28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicDetailedUsable other)
		{
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0025E09C File Offset: 0x0025C29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x0025E0AC File Offset: 0x0025C2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0025E0BC File Offset: 0x0025C2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicDetailedUsable()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterCharacteristicDetailedUsable._parser = new MessageParser<CharacterCharacteristicDetailedUsable>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
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
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0025E1A0 File Offset: 0x0025C3A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dZBZHLJGtsh5lLagbxch()
		{
			return true;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0025E1A8 File Offset: 0x0025C3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicDetailedUsable T7ltC9JGwhJKrJeOoHny()
		{
			return null;
		}

		// Token: 0x04002DAD RID: 11693
		private static readonly MessageParser<CharacterCharacteristicDetailedUsable> _parser;

		// Token: 0x04002DAE RID: 11694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DAF RID: 11695
		public const int BaseFieldNumber = 1;

		// Token: 0x04002DB0 RID: 11696
		private int base_;

		// Token: 0x04002DB1 RID: 11697
		public const int AdditionalFieldNumber = 2;

		// Token: 0x04002DB2 RID: 11698
		private int additional_;

		// Token: 0x04002DB3 RID: 11699
		public const int ObjectsAndMountBonusFieldNumber = 3;

		// Token: 0x04002DB4 RID: 11700
		private int objectsAndMountBonus_;

		// Token: 0x04002DB5 RID: 11701
		public const int AlignmentGiftBonusFieldNumber = 4;

		// Token: 0x04002DB6 RID: 11702
		private int alignmentGiftBonus_;

		// Token: 0x04002DB7 RID: 11703
		public const int ContextModificationFieldNumber = 5;

		// Token: 0x04002DB8 RID: 11704
		private int contextModification_;

		// Token: 0x04002DB9 RID: 11705
		public const int UsedFieldNumber = 6;

		// Token: 0x04002DBA RID: 11706
		private int used_;

		// Token: 0x04002DBB RID: 11707
		public const int TemporaryFieldNumber = 7;

		// Token: 0x04002DBC RID: 11708
		private int temporary_;

		// Token: 0x04002DBD RID: 11709
		private static CharacterCharacteristicDetailedUsable EFpFE6JGDcxRhLnfdsRc;
	}
}
