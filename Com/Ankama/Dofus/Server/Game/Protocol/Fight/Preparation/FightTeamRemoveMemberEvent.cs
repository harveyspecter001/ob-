using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006B7 RID: 1719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamRemoveMemberEvent : IMessage<FightTeamRemoveMemberEvent>, IMessage, IEquatable<FightTeamRemoveMemberEvent>, IDeepCloneable<FightTeamRemoveMemberEvent>, IBufferMessage
	{
		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06005403 RID: 21507 RVA: 0x0020A72C File Offset: 0x0020892C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamRemoveMemberEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x0020A73C File Offset: 0x0020893C
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

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x0020A74C File Offset: 0x0020894C
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

		// Token: 0x06005406 RID: 21510 RVA: 0x0020A75C File Offset: 0x0020895C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamRemoveMemberEvent()
		{
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x0020A76C File Offset: 0x0020896C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamRemoveMemberEvent(FightTeamRemoveMemberEvent other)
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x0020A77C File Offset: 0x0020897C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamRemoveMemberEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06005409 RID: 21513 RVA: 0x0020A78C File Offset: 0x0020898C
		// (set) Token: 0x0600540A RID: 21514 RVA: 0x0020A79C File Offset: 0x0020899C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x0020A7AC File Offset: 0x002089AC
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x0020A7C0 File Offset: 0x002089C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x0020A7D0 File Offset: 0x002089D0
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x0020A7E0 File Offset: 0x002089E0
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

		// Token: 0x0600540F RID: 21519 RVA: 0x0020A7F0 File Offset: 0x002089F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x0020A800 File Offset: 0x00208A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamRemoveMemberEvent other)
		{
			return true;
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x0020A810 File Offset: 0x00208A10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0020A820 File Offset: 0x00208A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x0020A830 File Offset: 0x00208A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x0020A840 File Offset: 0x00208A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x0020A850 File Offset: 0x00208A50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x0020A860 File Offset: 0x00208A60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamRemoveMemberEvent other)
		{
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x0020A870 File Offset: 0x00208A70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x0020A880 File Offset: 0x00208A80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x0020A890 File Offset: 0x00208A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamRemoveMemberEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				FightTeamRemoveMemberEvent._parser = new MessageParser<FightTeamRemoveMemberEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x0020A974 File Offset: 0x00208B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TSChlYOSlejGgjDWcjUm()
		{
			return true;
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0020A97C File Offset: 0x00208B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamRemoveMemberEvent EMva3cOSciYtBa2Wwmf7()
		{
			return null;
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly MessageParser<FightTeamRemoveMemberEvent> _parser;

		// Token: 0x04001D9D RID: 7581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D9E RID: 7582
		public const int FightIdFieldNumber = 1;

		// Token: 0x04001D9F RID: 7583
		private int fightId_;

		// Token: 0x04001DA0 RID: 7584
		public const int TeamFieldNumber = 2;

		// Token: 0x04001DA1 RID: 7585
		private Team team_;

		// Token: 0x04001DA2 RID: 7586
		public const int CharacterIdFieldNumber = 3;

		// Token: 0x04001DA3 RID: 7587
		private long characterId_;

		// Token: 0x04001DA4 RID: 7588
		private static FightTeamRemoveMemberEvent wgbd58OSkmkkAA4EbV5p;
	}
}
