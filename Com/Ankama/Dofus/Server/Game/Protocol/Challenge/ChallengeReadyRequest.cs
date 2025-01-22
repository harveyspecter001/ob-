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
	// Token: 0x02000952 RID: 2386
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeReadyRequest : IMessage<ChallengeReadyRequest>, IMessage, IEquatable<ChallengeReadyRequest>, IDeepCloneable<ChallengeReadyRequest>, IBufferMessage
	{
		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600737B RID: 29563 RVA: 0x0023F894 File Offset: 0x0023DA94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x0023F8A4 File Offset: 0x0023DAA4
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600737D RID: 29565 RVA: 0x0023F8B4 File Offset: 0x0023DAB4
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

		// Token: 0x0600737E RID: 29566 RVA: 0x0023F8C4 File Offset: 0x0023DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeReadyRequest()
		{
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x0023F8D4 File Offset: 0x0023DAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeReadyRequest(ChallengeReadyRequest other)
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0023F8E4 File Offset: 0x0023DAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x0023F8F4 File Offset: 0x0023DAF4
		// (set) Token: 0x06007382 RID: 29570 RVA: 0x0023F908 File Offset: 0x0023DB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06007383 RID: 29571 RVA: 0x0023F918 File Offset: 0x0023DB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0023F928 File Offset: 0x0023DB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeReadyRequest other)
		{
			return true;
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0023F938 File Offset: 0x0023DB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x0023F948 File Offset: 0x0023DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x0023F958 File Offset: 0x0023DB58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x0023F968 File Offset: 0x0023DB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x0023F978 File Offset: 0x0023DB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x0023F988 File Offset: 0x0023DB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeReadyRequest other)
		{
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0023F998 File Offset: 0x0023DB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x0023F9A8 File Offset: 0x0023DBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeReadyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ChallengeReadyRequest._parser = new MessageParser<ChallengeReadyRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x0023FA9C File Offset: 0x0023DC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tTGRAkJ3UipvmaeiqIdM()
		{
			return true;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x0023FAA4 File Offset: 0x0023DCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeReadyRequest mnvk5yJ3vgYVHHYAnvF6()
		{
			return null;
		}

		// Token: 0x0400285A RID: 10330
		private static readonly MessageParser<ChallengeReadyRequest> _parser;

		// Token: 0x0400285B RID: 10331
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400285C RID: 10332
		public const int ChallengeModFieldNumber = 1;

		// Token: 0x0400285D RID: 10333
		private ChallengeMod challengeMod_;

		// Token: 0x0400285E RID: 10334
		private static ChallengeReadyRequest jQdVFNJ3c86ai2giZdrq;
	}
}
