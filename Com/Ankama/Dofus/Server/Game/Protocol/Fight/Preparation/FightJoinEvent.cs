using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006A5 RID: 1701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightJoinEvent : IMessage<FightJoinEvent>, IMessage, IEquatable<FightJoinEvent>, IDeepCloneable<FightJoinEvent>, IBufferMessage
	{
		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x0020925C File Offset: 0x0020745C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightJoinEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x0020926C File Offset: 0x0020746C
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

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x060052FF RID: 21247 RVA: 0x0020927C File Offset: 0x0020747C
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

		// Token: 0x06005300 RID: 21248 RVA: 0x0020928C File Offset: 0x0020748C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinEvent()
		{
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0020929C File Offset: 0x0020749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinEvent(FightJoinEvent other)
		{
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x002092AC File Offset: 0x002074AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x002092BC File Offset: 0x002074BC
		// (set) Token: 0x06005304 RID: 21252 RVA: 0x002092CC File Offset: 0x002074CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTeamPhase
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

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x002092DC File Offset: 0x002074DC
		// (set) Token: 0x06005306 RID: 21254 RVA: 0x002092EC File Offset: 0x002074EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanBeCancelled
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

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x002092FC File Offset: 0x002074FC
		// (set) Token: 0x06005308 RID: 21256 RVA: 0x0020930C File Offset: 0x0020750C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool CanSayReady
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

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06005309 RID: 21257 RVA: 0x0020931C File Offset: 0x0020751C
		// (set) Token: 0x0600530A RID: 21258 RVA: 0x0020932C File Offset: 0x0020752C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsFightStarted
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

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x0020933C File Offset: 0x0020753C
		// (set) Token: 0x0600530C RID: 21260 RVA: 0x0020934C File Offset: 0x0020754C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TimeMaxBeforeFightStart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x0020935C File Offset: 0x0020755C
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x00209370 File Offset: 0x00207570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightType FightType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00209380 File Offset: 0x00207580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00209390 File Offset: 0x00207590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightJoinEvent other)
		{
			return true;
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x002093A0 File Offset: 0x002075A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x002093B0 File Offset: 0x002075B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x002093C0 File Offset: 0x002075C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x002093D0 File Offset: 0x002075D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x002093E0 File Offset: 0x002075E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x002093F0 File Offset: 0x002075F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightJoinEvent other)
		{
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00209400 File Offset: 0x00207600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00209410 File Offset: 0x00207610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00209420 File Offset: 0x00207620
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightJoinEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					FightJoinEvent._parser = new MessageParser<FightJoinEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00209504 File Offset: 0x00207704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pxRYDhOPFTtBohSYGcFv()
		{
			return true;
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0020950C File Offset: 0x0020770C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightJoinEvent QQTZr3OPzYkrXhwwkpYs()
		{
			return null;
		}

		// Token: 0x04001D3D RID: 7485
		private static readonly MessageParser<FightJoinEvent> _parser;

		// Token: 0x04001D3E RID: 7486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D3F RID: 7487
		public const int IsTeamPhaseFieldNumber = 1;

		// Token: 0x04001D40 RID: 7488
		private bool isTeamPhase_;

		// Token: 0x04001D41 RID: 7489
		public const int CanBeCancelledFieldNumber = 2;

		// Token: 0x04001D42 RID: 7490
		private bool canBeCancelled_;

		// Token: 0x04001D43 RID: 7491
		public const int CanSayReadyFieldNumber = 3;

		// Token: 0x04001D44 RID: 7492
		private bool canSayReady_;

		// Token: 0x04001D45 RID: 7493
		public const int IsFightStartedFieldNumber = 4;

		// Token: 0x04001D46 RID: 7494
		private bool isFightStarted_;

		// Token: 0x04001D47 RID: 7495
		public const int TimeMaxBeforeFightStartFieldNumber = 5;

		// Token: 0x04001D48 RID: 7496
		private long timeMaxBeforeFightStart_;

		// Token: 0x04001D49 RID: 7497
		public const int FightTypeFieldNumber = 6;

		// Token: 0x04001D4A RID: 7498
		private FightType fightType_;

		// Token: 0x04001D4B RID: 7499
		private static FightJoinEvent vL4WFEOPqUamN536uAAG;
	}
}
