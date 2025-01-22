using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200095C RID: 2396
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeNumberEvent : IMessage<ChallengeNumberEvent>, IMessage, IEquatable<ChallengeNumberEvent>, IDeepCloneable<ChallengeNumberEvent>, IBufferMessage
	{
		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x00240300 File Offset: 0x0023E500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeNumberEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x00240310 File Offset: 0x0023E510
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

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x00240320 File Offset: 0x0023E520
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

		// Token: 0x06007401 RID: 29697 RVA: 0x00240330 File Offset: 0x0023E530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeNumberEvent()
		{
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x00240340 File Offset: 0x0023E540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeNumberEvent(ChallengeNumberEvent other)
		{
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x00240350 File Offset: 0x0023E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeNumberEvent Clone()
		{
			return null;
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x00240360 File Offset: 0x0023E560
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x00240370 File Offset: 0x0023E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeNumber
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

		// Token: 0x06007406 RID: 29702 RVA: 0x00240380 File Offset: 0x0023E580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x00240390 File Offset: 0x0023E590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeNumberEvent other)
		{
			return true;
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x002403A0 File Offset: 0x0023E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x002403B0 File Offset: 0x0023E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x002403C0 File Offset: 0x0023E5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x002403D0 File Offset: 0x0023E5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x002403E0 File Offset: 0x0023E5E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x002403F0 File Offset: 0x0023E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeNumberEvent other)
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00240400 File Offset: 0x0023E600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00240410 File Offset: 0x0023E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00240420 File Offset: 0x0023E620
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeNumberEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ChallengeNumberEvent._parser = new MessageParser<ChallengeNumberEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x00240504 File Offset: 0x0023E704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wujfgYJ3DtuVHNlmlbrG()
		{
			return true;
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x0024050C File Offset: 0x0023E70C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeNumberEvent bsHfieJ3t9qBrrHNliRc()
		{
			return null;
		}

		// Token: 0x04002880 RID: 10368
		private static readonly MessageParser<ChallengeNumberEvent> _parser;

		// Token: 0x04002881 RID: 10369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002882 RID: 10370
		public const int ChallengeNumberFieldNumber = 1;

		// Token: 0x04002883 RID: 10371
		private int challengeNumber_;

		// Token: 0x04002884 RID: 10372
		internal static ChallengeNumberEvent b69S7BJ3CvfsO8yD6NZn;
	}
}
