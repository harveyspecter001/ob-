using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000155 RID: 341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelfAttackableStatusUpdateEvent : IMessage<SelfAttackableStatusUpdateEvent>, IMessage, IEquatable<SelfAttackableStatusUpdateEvent>, IDeepCloneable<SelfAttackableStatusUpdateEvent>, IBufferMessage
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0019CF48 File Offset: 0x0019B148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SelfAttackableStatusUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0019CF58 File Offset: 0x0019B158
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0019CF68 File Offset: 0x0019B168
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

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0019CF78 File Offset: 0x0019B178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfAttackableStatusUpdateEvent()
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0019CF88 File Offset: 0x0019B188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfAttackableStatusUpdateEvent(SelfAttackableStatusUpdateEvent other)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0019CF98 File Offset: 0x0019B198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfAttackableStatusUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0019CFA8 File Offset: 0x0019B1A8
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0019CFBC File Offset: 0x0019B1BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AttackableStatus Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AttackableStatus)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0019CFCC File Offset: 0x0019B1CC
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0019CFDC File Offset: 0x0019B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ProbationTime
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0019CFEC File Offset: 0x0019B1EC
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0019CFFC File Offset: 0x0019B1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KothRole
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0019D00C File Offset: 0x0019B20C
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0019D01C File Offset: 0x0019B21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PictoScore
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

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0019D02C File Offset: 0x0019B22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0019D03C File Offset: 0x0019B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SelfAttackableStatusUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0019D04C File Offset: 0x0019B24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0019D05C File Offset: 0x0019B25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0019D06C File Offset: 0x0019B26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0019D07C File Offset: 0x0019B27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0019D08C File Offset: 0x0019B28C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0019D09C File Offset: 0x0019B29C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SelfAttackableStatusUpdateEvent other)
		{
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0019D0AC File Offset: 0x0019B2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0019D0BC File Offset: 0x0019B2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0019D0CC File Offset: 0x0019B2CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SelfAttackableStatusUpdateEvent()
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
					SelfAttackableStatusUpdateEvent._parser = new MessageParser<SelfAttackableStatusUpdateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0019D1B0 File Offset: 0x0019B3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T5iEYGOUaCAmOs659kGO()
		{
			return true;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0019D1B8 File Offset: 0x0019B3B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SelfAttackableStatusUpdateEvent AmIAiLOU5eaTdjO4wqyy()
		{
			return null;
		}

		// Token: 0x040005B2 RID: 1458
		private static readonly MessageParser<SelfAttackableStatusUpdateEvent> _parser;

		// Token: 0x040005B3 RID: 1459
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005B4 RID: 1460
		public const int StatusFieldNumber = 1;

		// Token: 0x040005B5 RID: 1461
		private AttackableStatus status_;

		// Token: 0x040005B6 RID: 1462
		public const int ProbationTimeFieldNumber = 2;

		// Token: 0x040005B7 RID: 1463
		private long probationTime_;

		// Token: 0x040005B8 RID: 1464
		public const int KothRoleFieldNumber = 3;

		// Token: 0x040005B9 RID: 1465
		private int kothRole_;

		// Token: 0x040005BA RID: 1466
		public const int PictoScoreFieldNumber = 4;

		// Token: 0x040005BB RID: 1467
		private int pictoScore_;

		// Token: 0x040005BC RID: 1468
		internal static SelfAttackableStatusUpdateEvent cSoiQuOU1MI75mYbSmnu;
	}
}
