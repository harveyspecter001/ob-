using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A59 RID: 2649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicDetailed : IMessage<CharacterCharacteristicDetailed>, IMessage, IEquatable<CharacterCharacteristicDetailed>, IDeepCloneable<CharacterCharacteristicDetailed>, IBufferMessage
	{
		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0025DC28 File Offset: 0x0025BE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCharacteristicDetailed> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x0025DC38 File Offset: 0x0025BE38
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

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x0025DC48 File Offset: 0x0025BE48
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

		// Token: 0x06007E49 RID: 32329 RVA: 0x0025DC58 File Offset: 0x0025BE58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailed()
		{
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x0025DC68 File Offset: 0x0025BE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailed(CharacterCharacteristicDetailed other)
		{
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x0025DC78 File Offset: 0x0025BE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicDetailed Clone()
		{
			return null;
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x0025DC88 File Offset: 0x0025BE88
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x0025DC98 File Offset: 0x0025BE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x0025DCA8 File Offset: 0x0025BEA8
		// (set) Token: 0x06007E4F RID: 32335 RVA: 0x0025DCB8 File Offset: 0x0025BEB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x0025DCC8 File Offset: 0x0025BEC8
		// (set) Token: 0x06007E51 RID: 32337 RVA: 0x0025DCD8 File Offset: 0x0025BED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06007E52 RID: 32338 RVA: 0x0025DCE8 File Offset: 0x0025BEE8
		// (set) Token: 0x06007E53 RID: 32339 RVA: 0x0025DCF8 File Offset: 0x0025BEF8
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

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x0025DD08 File Offset: 0x0025BF08
		// (set) Token: 0x06007E55 RID: 32341 RVA: 0x0025DD18 File Offset: 0x0025BF18
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

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06007E56 RID: 32342 RVA: 0x0025DD28 File Offset: 0x0025BF28
		// (set) Token: 0x06007E57 RID: 32343 RVA: 0x0025DD38 File Offset: 0x0025BF38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06007E58 RID: 32344 RVA: 0x0025DD48 File Offset: 0x0025BF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x0025DD58 File Offset: 0x0025BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicDetailed other)
		{
			return true;
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x0025DD68 File Offset: 0x0025BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x0025DD78 File Offset: 0x0025BF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x0025DD88 File Offset: 0x0025BF88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0025DD98 File Offset: 0x0025BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0025DDA8 File Offset: 0x0025BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x0025DDB8 File Offset: 0x0025BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicDetailed other)
		{
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x0025DDC8 File Offset: 0x0025BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x0025DDD8 File Offset: 0x0025BFD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x0025DDE8 File Offset: 0x0025BFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicDetailed()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				CharacterCharacteristicDetailed._parser = new MessageParser<CharacterCharacteristicDetailed>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x0025DECC File Offset: 0x0025C0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TZ49rOJG0VuLhMohKd6F()
		{
			return true;
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x0025DED4 File Offset: 0x0025C0D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicDetailed hCxwISJGClMAB6w7VmhH()
		{
			return null;
		}

		// Token: 0x04002D9C RID: 11676
		private static readonly MessageParser<CharacterCharacteristicDetailed> _parser;

		// Token: 0x04002D9D RID: 11677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D9E RID: 11678
		public const int BaseFieldNumber = 1;

		// Token: 0x04002D9F RID: 11679
		private int base_;

		// Token: 0x04002DA0 RID: 11680
		public const int AdditionalFieldNumber = 2;

		// Token: 0x04002DA1 RID: 11681
		private int additional_;

		// Token: 0x04002DA2 RID: 11682
		public const int ObjectsAndMountBonusFieldNumber = 3;

		// Token: 0x04002DA3 RID: 11683
		private int objectsAndMountBonus_;

		// Token: 0x04002DA4 RID: 11684
		public const int AlignmentGiftBonusFieldNumber = 4;

		// Token: 0x04002DA5 RID: 11685
		private int alignmentGiftBonus_;

		// Token: 0x04002DA6 RID: 11686
		public const int ContextModificationFieldNumber = 5;

		// Token: 0x04002DA7 RID: 11687
		private int contextModification_;

		// Token: 0x04002DA8 RID: 11688
		public const int TemporaryFieldNumber = 6;

		// Token: 0x04002DA9 RID: 11689
		private int temporary_;

		// Token: 0x04002DAA RID: 11690
		internal static CharacterCharacteristicDetailed GcBRUwJGVBQ5nYpH5qok;
	}
}
