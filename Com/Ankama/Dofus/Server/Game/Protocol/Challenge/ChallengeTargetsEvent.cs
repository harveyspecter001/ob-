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
	// Token: 0x02000958 RID: 2392
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeTargetsEvent : IMessage<ChallengeTargetsEvent>, IMessage, IEquatable<ChallengeTargetsEvent>, IDeepCloneable<ChallengeTargetsEvent>, IBufferMessage
	{
		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060073C8 RID: 29640 RVA: 0x0023FEE8 File Offset: 0x0023E0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeTargetsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060073C9 RID: 29641 RVA: 0x0023FEF8 File Offset: 0x0023E0F8
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060073CA RID: 29642 RVA: 0x0023FF08 File Offset: 0x0023E108
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

		// Token: 0x060073CB RID: 29643 RVA: 0x0023FF18 File Offset: 0x0023E118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsEvent()
		{
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x0023FF28 File Offset: 0x0023E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsEvent(ChallengeTargetsEvent other)
		{
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x0023FF38 File Offset: 0x0023E138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsEvent Clone()
		{
			return null;
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x0023FF48 File Offset: 0x0023E148
		// (set) Token: 0x060073CF RID: 29647 RVA: 0x0023FF58 File Offset: 0x0023E158
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

		// Token: 0x060073D0 RID: 29648 RVA: 0x0023FF68 File Offset: 0x0023E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x0023FF78 File Offset: 0x0023E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeTargetsEvent other)
		{
			return true;
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x0023FF88 File Offset: 0x0023E188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x0023FF98 File Offset: 0x0023E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x0023FFA8 File Offset: 0x0023E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x0023FFB8 File Offset: 0x0023E1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x0023FFC8 File Offset: 0x0023E1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x0023FFD8 File Offset: 0x0023E1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeTargetsEvent other)
		{
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x0023FFE8 File Offset: 0x0023E1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x0023FFF8 File Offset: 0x0023E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00240008 File Offset: 0x0023E208
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeTargetsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					ChallengeTargetsEvent._parser = new MessageParser<ChallengeTargetsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x002400D4 File Offset: 0x0023E2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QM8CrEJ3WxsixXLrMuN1()
		{
			return true;
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x002400DC File Offset: 0x0023E2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeTargetsEvent SrTw4nJ3hWvMaUQoW8yf()
		{
			return null;
		}

		// Token: 0x04002870 RID: 10352
		private static readonly MessageParser<ChallengeTargetsEvent> _parser;

		// Token: 0x04002871 RID: 10353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002872 RID: 10354
		public const int ChallengeFieldNumber = 2;

		// Token: 0x04002873 RID: 10355
		private Challenge challenge_;

		// Token: 0x04002874 RID: 10356
		internal static ChallengeTargetsEvent kj0X5pJ3Ldv5IYIdaMNL;
	}
}
