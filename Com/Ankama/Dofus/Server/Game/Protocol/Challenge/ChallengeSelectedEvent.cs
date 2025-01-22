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
	// Token: 0x02000960 RID: 2400
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeSelectedEvent : IMessage<ChallengeSelectedEvent>, IMessage, IEquatable<ChallengeSelectedEvent>, IDeepCloneable<ChallengeSelectedEvent>, IBufferMessage
	{
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x0024075C File Offset: 0x0023E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06007434 RID: 29748 RVA: 0x0024076C File Offset: 0x0023E96C
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

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06007435 RID: 29749 RVA: 0x0024077C File Offset: 0x0023E97C
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

		// Token: 0x06007436 RID: 29750 RVA: 0x0024078C File Offset: 0x0023E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectedEvent()
		{
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x0024079C File Offset: 0x0023E99C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectedEvent(ChallengeSelectedEvent other)
		{
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x002407AC File Offset: 0x0023E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x002407BC File Offset: 0x0023E9BC
		// (set) Token: 0x0600743A RID: 29754 RVA: 0x002407CC File Offset: 0x0023E9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge Challenge
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

		// Token: 0x0600743B RID: 29755 RVA: 0x002407DC File Offset: 0x0023E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x002407EC File Offset: 0x0023E9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeSelectedEvent other)
		{
			return true;
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x002407FC File Offset: 0x0023E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0024080C File Offset: 0x0023EA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x0024081C File Offset: 0x0023EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x0024082C File Offset: 0x0023EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x0024083C File Offset: 0x0023EA3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x0024084C File Offset: 0x0023EA4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeSelectedEvent other)
		{
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x0024085C File Offset: 0x0023EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0024086C File Offset: 0x0023EA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x0024087C File Offset: 0x0023EA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeSelectedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					ChallengeSelectedEvent._parser = new MessageParser<ChallengeSelectedEvent>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x00240960 File Offset: 0x0023EB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sevnDOJ3p5lpRNX7TdbJ()
		{
			return true;
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00240968 File Offset: 0x0023EB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeSelectedEvent Y2BMF7J3Hsl7TdjMkCYp()
		{
			return null;
		}

		// Token: 0x04002891 RID: 10385
		private static readonly MessageParser<ChallengeSelectedEvent> _parser;

		// Token: 0x04002892 RID: 10386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002893 RID: 10387
		public const int ChallengeFieldNumber = 1;

		// Token: 0x04002894 RID: 10388
		private Challenge challenge_;

		// Token: 0x04002895 RID: 10389
		private static ChallengeSelectedEvent KDEHquJ3TsTij4MhiffV;
	}
}
