using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200094E RID: 2382
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeValidateRequest : IMessage<ChallengeValidateRequest>, IMessage, IEquatable<ChallengeValidateRequest>, IDeepCloneable<ChallengeValidateRequest>, IBufferMessage
	{
		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06007347 RID: 29511 RVA: 0x0023F498 File Offset: 0x0023D698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeValidateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x0023F4A8 File Offset: 0x0023D6A8
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

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x0023F4B8 File Offset: 0x0023D6B8
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

		// Token: 0x0600734A RID: 29514 RVA: 0x0023F4C8 File Offset: 0x0023D6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeValidateRequest()
		{
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x0023F4D8 File Offset: 0x0023D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeValidateRequest(ChallengeValidateRequest other)
		{
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x0023F4E8 File Offset: 0x0023D6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeValidateRequest Clone()
		{
			return null;
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x0023F4F8 File Offset: 0x0023D6F8
		// (set) Token: 0x0600734E RID: 29518 RVA: 0x0023F508 File Offset: 0x0023D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600734F RID: 29519 RVA: 0x0023F518 File Offset: 0x0023D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x0023F528 File Offset: 0x0023D728
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeValidateRequest other)
		{
			return true;
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x0023F538 File Offset: 0x0023D738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x0023F548 File Offset: 0x0023D748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x0023F558 File Offset: 0x0023D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x0023F568 File Offset: 0x0023D768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x0023F578 File Offset: 0x0023D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0023F588 File Offset: 0x0023D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeValidateRequest other)
		{
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x0023F598 File Offset: 0x0023D798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0023F5A8 File Offset: 0x0023D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x0023F5B8 File Offset: 0x0023D7B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeValidateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ChallengeValidateRequest._parser = new MessageParser<ChallengeValidateRequest>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x0023F684 File Offset: 0x0023D884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NbUrQOJ3j2nwJOaMEpcv()
		{
			return true;
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x0023F68C File Offset: 0x0023D88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeValidateRequest iXqvmgJ3K6T9HwQIpXo6()
		{
			return null;
		}

		// Token: 0x0400284C RID: 10316
		private static readonly MessageParser<ChallengeValidateRequest> _parser;

		// Token: 0x0400284D RID: 10317
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400284E RID: 10318
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400284F RID: 10319
		private int challengeId_;

		// Token: 0x04002850 RID: 10320
		internal static ChallengeValidateRequest VuLQgfJ34RySeJa77jfR;
	}
}
