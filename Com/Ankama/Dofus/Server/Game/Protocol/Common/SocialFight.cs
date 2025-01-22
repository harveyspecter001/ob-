using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A8B RID: 2699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialFight : IMessage<SocialFight>, IMessage, IEquatable<SocialFight>, IDeepCloneable<SocialFight>, IBufferMessage
	{
		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x002606DC File Offset: 0x0025E8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialFight> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x060080DB RID: 32987 RVA: 0x002606EC File Offset: 0x0025E8EC
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

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x002606FC File Offset: 0x0025E8FC
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

		// Token: 0x060080DD RID: 32989 RVA: 0x0026070C File Offset: 0x0025E90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFight()
		{
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x0026071C File Offset: 0x0025E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFight(SocialFight other)
		{
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x0026072C File Offset: 0x0025E92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialFight Clone()
		{
			return null;
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x060080E0 RID: 32992 RVA: 0x0026073C File Offset: 0x0025E93C
		// (set) Token: 0x060080E1 RID: 32993 RVA: 0x0026074C File Offset: 0x0025E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialFightInformation SocialFightInfo
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

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x060080E2 RID: 32994 RVA: 0x0026075C File Offset: 0x0025E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Character> Attackers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x0026076C File Offset: 0x0025E96C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Character> Defenders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x060080E4 RID: 32996 RVA: 0x0026077C File Offset: 0x0025E97C
		// (set) Token: 0x060080E5 RID: 32997 RVA: 0x0026078C File Offset: 0x0025E98C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightPhaseInfo Phase
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

		// Token: 0x060080E6 RID: 32998 RVA: 0x0026079C File Offset: 0x0025E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x002607AC File Offset: 0x0025E9AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SocialFight other)
		{
			return true;
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x002607BC File Offset: 0x0025E9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x002607CC File Offset: 0x0025E9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x002607DC File Offset: 0x0025E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x002607EC File Offset: 0x0025E9EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x002607FC File Offset: 0x0025E9FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x0026080C File Offset: 0x0025EA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SocialFight other)
		{
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x0026081C File Offset: 0x0025EA1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x0026082C File Offset: 0x0025EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x0026083C File Offset: 0x0025EA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SocialFight()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					SocialFight._parser = new MessageParser<SocialFight>(() => null);
					num2 = 4;
					break;
				case 2:
					SocialFight._repeated_defenders_codec = FieldCodec.ForMessage<Character>(26U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					SocialFight._repeated_attackers_codec = FieldCodec.ForMessage<Character>(18U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x0026097C File Offset: 0x0025EB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U7hBZSJgcsxe6cI4YKTn()
		{
			return true;
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00260984 File Offset: 0x0025EB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SocialFight LML3R4JgUscr4oeopEY5()
		{
			return null;
		}

		// Token: 0x04002ED0 RID: 11984
		private static readonly MessageParser<SocialFight> _parser;

		// Token: 0x04002ED1 RID: 11985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED2 RID: 11986
		public const int SocialFightInfoFieldNumber = 1;

		// Token: 0x04002ED3 RID: 11987
		private SocialFightInformation socialFightInfo_;

		// Token: 0x04002ED4 RID: 11988
		public const int AttackersFieldNumber = 2;

		// Token: 0x04002ED5 RID: 11989
		private static readonly FieldCodec<Character> _repeated_attackers_codec;

		// Token: 0x04002ED6 RID: 11990
		private readonly RepeatedField<Character> attackers_;

		// Token: 0x04002ED7 RID: 11991
		public const int DefendersFieldNumber = 3;

		// Token: 0x04002ED8 RID: 11992
		private static readonly FieldCodec<Character> _repeated_defenders_codec;

		// Token: 0x04002ED9 RID: 11993
		private readonly RepeatedField<Character> defenders_;

		// Token: 0x04002EDA RID: 11994
		public const int PhaseFieldNumber = 4;

		// Token: 0x04002EDB RID: 11995
		private FightPhaseInfo phase_;

		// Token: 0x04002EDC RID: 11996
		internal static SocialFight RkT08UJglxoI0tIrdItS;
	}
}
