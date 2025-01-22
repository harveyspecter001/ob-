using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AAC RID: 2732
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMemberInformation : IMessage<FightTeamMemberInformation>, IMessage, IEquatable<FightTeamMemberInformation>, IDeepCloneable<FightTeamMemberInformation>, IBufferMessage
	{
		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06008297 RID: 33431 RVA: 0x002627A8 File Offset: 0x002609A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamMemberInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x002627B8 File Offset: 0x002609B8
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06008299 RID: 33433 RVA: 0x002627C8 File Offset: 0x002609C8
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

		// Token: 0x0600829A RID: 33434 RVA: 0x002627D8 File Offset: 0x002609D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberInformation()
		{
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x002627E8 File Offset: 0x002609E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberInformation(FightTeamMemberInformation other)
		{
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x002627F8 File Offset: 0x002609F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberInformation Clone()
		{
			return null;
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x00262808 File Offset: 0x00260A08
		// (set) Token: 0x0600829E RID: 33438 RVA: 0x00262818 File Offset: 0x00260A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MemberId
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

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x0600829F RID: 33439 RVA: 0x00262828 File Offset: 0x00260A28
		// (set) Token: 0x060082A0 RID: 33440 RVA: 0x00262838 File Offset: 0x00260A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTeamMemberCharacter CharacterMember
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

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x060082A1 RID: 33441 RVA: 0x00262848 File Offset: 0x00260A48
		// (set) Token: 0x060082A2 RID: 33442 RVA: 0x00262858 File Offset: 0x00260A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamMemberEntity EntityMember
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

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060082A3 RID: 33443 RVA: 0x00262868 File Offset: 0x00260A68
		// (set) Token: 0x060082A4 RID: 33444 RVA: 0x00262878 File Offset: 0x00260A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTeamMemberMonster MonsterMember
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060082A5 RID: 33445 RVA: 0x00262888 File Offset: 0x00260A88
		// (set) Token: 0x060082A6 RID: 33446 RVA: 0x00262898 File Offset: 0x00260A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTeamMemberTaxCollector TaxCollectorMember
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

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x060082A7 RID: 33447 RVA: 0x002628A8 File Offset: 0x00260AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamMemberInformation.InformationOneofCase InformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightTeamMemberInformation.InformationOneofCase)null;
			}
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x002628BC File Offset: 0x00260ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearInformation()
		{
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x002628CC File Offset: 0x00260ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x002628DC File Offset: 0x00260ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMemberInformation other)
		{
			return true;
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x002628EC File Offset: 0x00260AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x002628FC File Offset: 0x00260AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0026290C File Offset: 0x00260B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0026291C File Offset: 0x00260B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0026292C File Offset: 0x00260B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0026293C File Offset: 0x00260B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMemberInformation other)
		{
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0026294C File Offset: 0x00260B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0026295C File Offset: 0x00260B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x0026296C File Offset: 0x00260B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMemberInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					FightTeamMemberInformation._parser = new MessageParser<FightTeamMemberInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x00262A64 File Offset: 0x00260C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B0UsQkJsAYKHRqmJvwiL()
		{
			return true;
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x00262A6C File Offset: 0x00260C6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMemberInformation woUFD7JsBj4yZsN7Ll9p()
		{
			return null;
		}

		// Token: 0x04002F97 RID: 12183
		private static readonly MessageParser<FightTeamMemberInformation> _parser;

		// Token: 0x04002F98 RID: 12184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F99 RID: 12185
		public const int MemberIdFieldNumber = 1;

		// Token: 0x04002F9A RID: 12186
		private long memberId_;

		// Token: 0x04002F9B RID: 12187
		public const int CharacterMemberFieldNumber = 2;

		// Token: 0x04002F9C RID: 12188
		public const int EntityMemberFieldNumber = 3;

		// Token: 0x04002F9D RID: 12189
		public const int MonsterMemberFieldNumber = 4;

		// Token: 0x04002F9E RID: 12190
		public const int TaxCollectorMemberFieldNumber = 5;

		// Token: 0x04002F9F RID: 12191
		private object information_;

		// Token: 0x04002FA0 RID: 12192
		private FightTeamMemberInformation.InformationOneofCase informationCase_;

		// Token: 0x04002FA1 RID: 12193
		private static FightTeamMemberInformation adYyraJsmS4qsaoa4wB3;

		// Token: 0x02000AAD RID: 2733
		public enum InformationOneofCase
		{
			// Token: 0x04002FA3 RID: 12195
			None,
			// Token: 0x04002FA4 RID: 12196
			CharacterMember = 2,
			// Token: 0x04002FA5 RID: 12197
			EntityMember,
			// Token: 0x04002FA6 RID: 12198
			MonsterMember,
			// Token: 0x04002FA7 RID: 12199
			TaxCollectorMember
		}
	}
}
