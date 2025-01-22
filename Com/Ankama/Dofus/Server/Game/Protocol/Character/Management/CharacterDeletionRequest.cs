using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200090D RID: 2317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterDeletionRequest : IMessage<CharacterDeletionRequest>, IMessage, IEquatable<CharacterDeletionRequest>, IDeepCloneable<CharacterDeletionRequest>, IBufferMessage
	{
		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06007062 RID: 28770 RVA: 0x0023B34C File Offset: 0x0023954C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterDeletionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x0023B35C File Offset: 0x0023955C
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

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x0023B36C File Offset: 0x0023956C
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

		// Token: 0x06007065 RID: 28773 RVA: 0x0023B37C File Offset: 0x0023957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionRequest()
		{
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x0023B38C File Offset: 0x0023958C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionRequest(CharacterDeletionRequest other)
		{
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x0023B39C File Offset: 0x0023959C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06007068 RID: 28776 RVA: 0x0023B3AC File Offset: 0x002395AC
		// (set) Token: 0x06007069 RID: 28777 RVA: 0x0023B3BC File Offset: 0x002395BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x0023B3CC File Offset: 0x002395CC
		// (set) Token: 0x0600706B RID: 28779 RVA: 0x0023B3DC File Offset: 0x002395DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string SecretAnswerHash
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

		// Token: 0x0600706C RID: 28780 RVA: 0x0023B3EC File Offset: 0x002395EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x0023B3FC File Offset: 0x002395FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterDeletionRequest other)
		{
			return true;
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x0023B40C File Offset: 0x0023960C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x0023B41C File Offset: 0x0023961C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x0023B42C File Offset: 0x0023962C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x0023B43C File Offset: 0x0023963C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x0023B44C File Offset: 0x0023964C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x0023B45C File Offset: 0x0023965C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterDeletionRequest other)
		{
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x0023B46C File Offset: 0x0023966C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x0023B47C File Offset: 0x0023967C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x0023B48C File Offset: 0x0023968C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterDeletionRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					CharacterDeletionRequest._parser = new MessageParser<CharacterDeletionRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x0023B570 File Offset: 0x00239770
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R4DNgxJemMuWhdExuw64()
		{
			return true;
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x0023B578 File Offset: 0x00239778
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterDeletionRequest tDsLLpJeABZQhALsEqQL()
		{
			return null;
		}

		// Token: 0x0400276B RID: 10091
		private static readonly MessageParser<CharacterDeletionRequest> _parser;

		// Token: 0x0400276C RID: 10092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400276D RID: 10093
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400276E RID: 10094
		private long characterId_;

		// Token: 0x0400276F RID: 10095
		public const int SecretAnswerHashFieldNumber = 2;

		// Token: 0x04002770 RID: 10096
		private string secretAnswerHash_;

		// Token: 0x04002771 RID: 10097
		private static CharacterDeletionRequest dq0mqbJenfUeYl0ddyHP;
	}
}
