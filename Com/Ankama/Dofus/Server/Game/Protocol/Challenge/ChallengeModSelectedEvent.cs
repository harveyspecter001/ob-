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
	// Token: 0x02000964 RID: 2404
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeModSelectedEvent : IMessage<ChallengeModSelectedEvent>, IMessage, IEquatable<ChallengeModSelectedEvent>, IDeepCloneable<ChallengeModSelectedEvent>, IBufferMessage
	{
		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06007467 RID: 29799 RVA: 0x00240B84 File Offset: 0x0023ED84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeModSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x00240B94 File Offset: 0x0023ED94
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

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06007469 RID: 29801 RVA: 0x00240BA4 File Offset: 0x0023EDA4
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

		// Token: 0x0600746A RID: 29802 RVA: 0x00240BB4 File Offset: 0x0023EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectedEvent()
		{
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00240BC4 File Offset: 0x0023EDC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectedEvent(ChallengeModSelectedEvent other)
		{
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00240BD4 File Offset: 0x0023EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeModSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x00240BE4 File Offset: 0x0023EDE4
		// (set) Token: 0x0600746E RID: 29806 RVA: 0x00240BF8 File Offset: 0x0023EDF8
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

		// Token: 0x0600746F RID: 29807 RVA: 0x00240C08 File Offset: 0x0023EE08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00240C18 File Offset: 0x0023EE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeModSelectedEvent other)
		{
			return true;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x00240C28 File Offset: 0x0023EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x00240C38 File Offset: 0x0023EE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x00240C48 File Offset: 0x0023EE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x00240C58 File Offset: 0x0023EE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x00240C68 File Offset: 0x0023EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x00240C78 File Offset: 0x0023EE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeModSelectedEvent other)
		{
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x00240C88 File Offset: 0x0023EE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00240C98 File Offset: 0x0023EE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x00240CA8 File Offset: 0x0023EEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeModSelectedEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					ChallengeModSelectedEvent._parser = new MessageParser<ChallengeModSelectedEvent>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00240D8C File Offset: 0x0023EF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YOrVRkJ3STc519q8bERU()
		{
			return true;
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00240D94 File Offset: 0x0023EF94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeModSelectedEvent kZvYpyJ3M2PoKIcxuXfs()
		{
			return null;
		}

		// Token: 0x0400289F RID: 10399
		private static readonly MessageParser<ChallengeModSelectedEvent> _parser;

		// Token: 0x040028A0 RID: 10400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A1 RID: 10401
		public const int ChallengeModFieldNumber = 1;

		// Token: 0x040028A2 RID: 10402
		private ChallengeMod challengeMod_;

		// Token: 0x040028A3 RID: 10403
		internal static ChallengeModSelectedEvent Wre0YSJ3PiU7nVNPT8Nh;
	}
}
