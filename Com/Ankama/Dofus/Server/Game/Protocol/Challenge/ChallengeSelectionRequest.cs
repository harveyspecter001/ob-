using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200094C RID: 2380
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeSelectionRequest : IMessage<ChallengeSelectionRequest>, IMessage, IEquatable<ChallengeSelectionRequest>, IDeepCloneable<ChallengeSelectionRequest>, IBufferMessage
	{
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x0023F284 File Offset: 0x0023D484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeSelectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600732E RID: 29486 RVA: 0x0023F294 File Offset: 0x0023D494
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

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600732F RID: 29487 RVA: 0x0023F2A4 File Offset: 0x0023D4A4
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

		// Token: 0x06007330 RID: 29488 RVA: 0x0023F2B4 File Offset: 0x0023D4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectionRequest()
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x0023F2C4 File Offset: 0x0023D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectionRequest(ChallengeSelectionRequest other)
		{
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x0023F2D4 File Offset: 0x0023D4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeSelectionRequest Clone()
		{
			return null;
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x0023F2E4 File Offset: 0x0023D4E4
		// (set) Token: 0x06007334 RID: 29492 RVA: 0x0023F2F4 File Offset: 0x0023D4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ChallengeId
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

		// Token: 0x06007335 RID: 29493 RVA: 0x0023F304 File Offset: 0x0023D504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x0023F314 File Offset: 0x0023D514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeSelectionRequest other)
		{
			return true;
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x0023F324 File Offset: 0x0023D524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x0023F334 File Offset: 0x0023D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x0023F344 File Offset: 0x0023D544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x0023F354 File Offset: 0x0023D554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x0023F364 File Offset: 0x0023D564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0023F374 File Offset: 0x0023D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeSelectionRequest other)
		{
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0023F384 File Offset: 0x0023D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x0023F394 File Offset: 0x0023D594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0023F3A4 File Offset: 0x0023D5A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeSelectionRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					ChallengeSelectionRequest._parser = new MessageParser<ChallengeSelectionRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x0023F488 File Offset: 0x0023D688
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ebdOJZJ3NgJ1UEXgn23A()
		{
			return true;
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x0023F490 File Offset: 0x0023D690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeSelectionRequest DjtMEOJ3x5WiVevRMgwR()
		{
			return null;
		}

		// Token: 0x04002845 RID: 10309
		private static readonly MessageParser<ChallengeSelectionRequest> _parser;

		// Token: 0x04002846 RID: 10310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002847 RID: 10311
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04002848 RID: 10312
		private int challengeId_;

		// Token: 0x04002849 RID: 10313
		private static ChallengeSelectionRequest AYX0dXJ3XiCxaoyTPTiW;
	}
}
