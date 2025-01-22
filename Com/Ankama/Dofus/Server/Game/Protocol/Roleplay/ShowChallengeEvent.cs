using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200018E RID: 398
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShowChallengeEvent : IMessage<ShowChallengeEvent>, IMessage, IEquatable<ShowChallengeEvent>, IDeepCloneable<ShowChallengeEvent>, IBufferMessage
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x001A20E4 File Offset: 0x001A02E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ShowChallengeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x001A20F4 File Offset: 0x001A02F4
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x001A2104 File Offset: 0x001A0304
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

		// Token: 0x06001261 RID: 4705 RVA: 0x001A2114 File Offset: 0x001A0314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowChallengeEvent()
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x001A2124 File Offset: 0x001A0324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowChallengeEvent(ShowChallengeEvent other)
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x001A2134 File Offset: 0x001A0334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowChallengeEvent Clone()
		{
			return null;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x001A2144 File Offset: 0x001A0344
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x001A2154 File Offset: 0x001A0354
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightCommonInformation FightInformation
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

		// Token: 0x06001266 RID: 4710 RVA: 0x001A2164 File Offset: 0x001A0364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x001A2174 File Offset: 0x001A0374
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShowChallengeEvent other)
		{
			return true;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x001A2184 File Offset: 0x001A0384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x001A2194 File Offset: 0x001A0394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x001A21A4 File Offset: 0x001A03A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x001A21B4 File Offset: 0x001A03B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x001A21C4 File Offset: 0x001A03C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x001A21D4 File Offset: 0x001A03D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShowChallengeEvent other)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x001A21E4 File Offset: 0x001A03E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x001A21F4 File Offset: 0x001A03F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x001A2204 File Offset: 0x001A0404
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShowChallengeEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					ShowChallengeEvent._parser = new MessageParser<ShowChallengeEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
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
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x001A22E8 File Offset: 0x001A04E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X9pI6cOvuivU4eQLU7so()
		{
			return true;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x001A22F0 File Offset: 0x001A04F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShowChallengeEvent Q0PuP0Ov8e45OlxvQXFT()
		{
			return null;
		}

		// Token: 0x040006A3 RID: 1699
		private static readonly MessageParser<ShowChallengeEvent> _parser;

		// Token: 0x040006A4 RID: 1700
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006A5 RID: 1701
		public const int FightInformationFieldNumber = 1;

		// Token: 0x040006A6 RID: 1702
		private FightCommonInformation fightInformation_;

		// Token: 0x040006A7 RID: 1703
		internal static ShowChallengeEvent KcQZIaOvMtbvwUagwOtN;
	}
}
