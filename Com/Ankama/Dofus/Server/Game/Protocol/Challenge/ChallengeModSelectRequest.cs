using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x02000950 RID: 2384
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeModSelectRequest : IMessage<ChallengeModSelectRequest>, IMessage, IEquatable<ChallengeModSelectRequest>, IDeepCloneable<ChallengeModSelectRequest>, IBufferMessage
	{
		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06007361 RID: 29537 RVA: 0x0023F694 File Offset: 0x0023D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeModSelectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06007362 RID: 29538 RVA: 0x0023F6A4 File Offset: 0x0023D8A4
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

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06007363 RID: 29539 RVA: 0x0023F6B4 File Offset: 0x0023D8B4
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

		// Token: 0x06007364 RID: 29540 RVA: 0x0023F6C4 File Offset: 0x0023D8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectRequest()
		{
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0023F6D4 File Offset: 0x0023D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectRequest(ChallengeModSelectRequest other)
		{
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x0023F6E4 File Offset: 0x0023D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectRequest Clone()
		{
			return null;
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x0023F6F4 File Offset: 0x0023D8F4
		// (set) Token: 0x06007368 RID: 29544 RVA: 0x0023F708 File Offset: 0x0023D908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ChallengeMod ChallengeMod
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChallengeMod)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0023F718 File Offset: 0x0023D918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x0023F728 File Offset: 0x0023D928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeModSelectRequest other)
		{
			return true;
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0023F738 File Offset: 0x0023D938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x0023F748 File Offset: 0x0023D948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x0023F758 File Offset: 0x0023D958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x0023F768 File Offset: 0x0023D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0023F778 File Offset: 0x0023D978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x0023F788 File Offset: 0x0023D988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeModSelectRequest other)
		{
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x0023F798 File Offset: 0x0023D998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0023F7A8 File Offset: 0x0023D9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x0023F7B8 File Offset: 0x0023D9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeModSelectRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ChallengeModSelectRequest._parser = new MessageParser<ChallengeModSelectRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x0023F884 File Offset: 0x0023DA84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UA3Af5J3kRMnXPMqXeQJ()
		{
			return true;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x0023F88C File Offset: 0x0023DA8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeModSelectRequest s3wdORJ3lj19A3o1ZYbQ()
		{
			return null;
		}

		// Token: 0x04002853 RID: 10323
		private static readonly MessageParser<ChallengeModSelectRequest> _parser;

		// Token: 0x04002854 RID: 10324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002855 RID: 10325
		public const int ChallengeModFieldNumber = 1;

		// Token: 0x04002856 RID: 10326
		private ChallengeMod challengeMod_;

		// Token: 0x04002857 RID: 10327
		private static ChallengeModSelectRequest myRMsYJ3IyyN92PmYL6Z;
	}
}
