using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x02000956 RID: 2390
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeListEvent : IMessage<ChallengeListEvent>, IMessage, IEquatable<ChallengeListEvent>, IDeepCloneable<ChallengeListEvent>, IBufferMessage
	{
		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060073AF RID: 29615 RVA: 0x0023FCAC File Offset: 0x0023DEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060073B0 RID: 29616 RVA: 0x0023FCBC File Offset: 0x0023DEBC
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060073B1 RID: 29617 RVA: 0x0023FCCC File Offset: 0x0023DECC
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

		// Token: 0x060073B2 RID: 29618 RVA: 0x0023FCDC File Offset: 0x0023DEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeListEvent()
		{
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x0023FCEC File Offset: 0x0023DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeListEvent(ChallengeListEvent other)
		{
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x0023FCFC File Offset: 0x0023DEFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeListEvent Clone()
		{
			return null;
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060073B5 RID: 29621 RVA: 0x0023FD0C File Offset: 0x0023DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Challenge> Challenges
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x0023FD1C File Offset: 0x0023DF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x0023FD2C File Offset: 0x0023DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeListEvent other)
		{
			return true;
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x0023FD3C File Offset: 0x0023DF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x0023FD4C File Offset: 0x0023DF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x0023FD5C File Offset: 0x0023DF5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x0023FD6C File Offset: 0x0023DF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x0023FD7C File Offset: 0x0023DF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x0023FD8C File Offset: 0x0023DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeListEvent other)
		{
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x0023FD9C File Offset: 0x0023DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x0023FDAC File Offset: 0x0023DFAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x0023FDBC File Offset: 0x0023DFBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ChallengeListEvent._repeated_challenges_codec = FieldCodec.ForMessage<Challenge>(10U, bCS24jB91TBQOe86HREN.XVInXhlssT(bCS24jB91TBQOe86HREN.ItHB9ayeO7V));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ChallengeListEvent._parser = new MessageParser<ChallengeListEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x0023FED8 File Offset: 0x0023E0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kQh4g6J3yNnGPOpE3t6e()
		{
			return true;
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x0023FEE0 File Offset: 0x0023E0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeListEvent zH75n8J36ohkXfy7vZ7E()
		{
			return null;
		}

		// Token: 0x04002868 RID: 10344
		private static readonly MessageParser<ChallengeListEvent> _parser;

		// Token: 0x04002869 RID: 10345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400286A RID: 10346
		public const int ChallengesFieldNumber = 1;

		// Token: 0x0400286B RID: 10347
		private static readonly FieldCodec<Challenge> _repeated_challenges_codec;

		// Token: 0x0400286C RID: 10348
		private readonly RepeatedField<Challenge> challenges_;

		// Token: 0x0400286D RID: 10349
		internal static ChallengeListEvent eKTJr9J35NPQncSHerlN;
	}
}
