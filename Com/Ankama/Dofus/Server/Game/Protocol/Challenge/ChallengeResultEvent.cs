using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200095A RID: 2394
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeResultEvent : IMessage<ChallengeResultEvent>, IMessage, IEquatable<ChallengeResultEvent>, IDeepCloneable<ChallengeResultEvent>, IBufferMessage
	{
		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x002400E4 File Offset: 0x0023E2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x002400F4 File Offset: 0x0023E2F4
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x00240104 File Offset: 0x0023E304
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

		// Token: 0x060073E5 RID: 29669 RVA: 0x00240114 File Offset: 0x0023E314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeResultEvent()
		{
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00240124 File Offset: 0x0023E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeResultEvent(ChallengeResultEvent other)
		{
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00240134 File Offset: 0x0023E334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x00240144 File Offset: 0x0023E344
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x00240154 File Offset: 0x0023E354
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x00240164 File Offset: 0x0023E364
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x00240174 File Offset: 0x0023E374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x00240184 File Offset: 0x0023E384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x00240194 File Offset: 0x0023E394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeResultEvent other)
		{
			return true;
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x002401A4 File Offset: 0x0023E3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x002401B4 File Offset: 0x0023E3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x002401C4 File Offset: 0x0023E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x002401D4 File Offset: 0x0023E3D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x002401E4 File Offset: 0x0023E3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x002401F4 File Offset: 0x0023E3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeResultEvent other)
		{
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00240204 File Offset: 0x0023E404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x00240214 File Offset: 0x0023E414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x00240224 File Offset: 0x0023E424
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					ChallengeResultEvent._parser = new MessageParser<ChallengeResultEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x002402F0 File Offset: 0x0023E4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReGpqUJ3VbZS4D4H6awN()
		{
			return true;
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x002402F8 File Offset: 0x0023E4F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeResultEvent lSAQOGJ30YeDXOylZc0y()
		{
			return null;
		}

		// Token: 0x04002877 RID: 10359
		private static readonly MessageParser<ChallengeResultEvent> _parser;

		// Token: 0x04002878 RID: 10360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002879 RID: 10361
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400287A RID: 10362
		private int challengeId_;

		// Token: 0x0400287B RID: 10363
		public const int SuccessFieldNumber = 2;

		// Token: 0x0400287C RID: 10364
		private bool success_;

		// Token: 0x0400287D RID: 10365
		internal static ChallengeResultEvent y6i8mYJ3r6wnruQoCdjt;
	}
}
