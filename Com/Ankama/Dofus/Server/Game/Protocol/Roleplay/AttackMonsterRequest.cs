using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200017C RID: 380
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AttackMonsterRequest : IMessage<AttackMonsterRequest>, IMessage, IEquatable<AttackMonsterRequest>, IDeepCloneable<AttackMonsterRequest>, IBufferMessage
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x001A0D20 File Offset: 0x0019EF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AttackMonsterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x001A0D30 File Offset: 0x0019EF30
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x001A0D40 File Offset: 0x0019EF40
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

		// Token: 0x06001163 RID: 4451 RVA: 0x001A0D50 File Offset: 0x0019EF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AttackMonsterRequest()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x001A0D60 File Offset: 0x0019EF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AttackMonsterRequest(AttackMonsterRequest other)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x001A0D70 File Offset: 0x0019EF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AttackMonsterRequest Clone()
		{
			return null;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x001A0D80 File Offset: 0x0019EF80
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x001A0D90 File Offset: 0x0019EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MonsterGroupId
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

		// Token: 0x06001168 RID: 4456 RVA: 0x001A0DA0 File Offset: 0x0019EFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x001A0DB0 File Offset: 0x0019EFB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AttackMonsterRequest other)
		{
			return true;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x001A0DC0 File Offset: 0x0019EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x001A0DD0 File Offset: 0x0019EFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x001A0DE0 File Offset: 0x0019EFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x001A0DF0 File Offset: 0x0019EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x001A0E00 File Offset: 0x0019F000
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x001A0E10 File Offset: 0x0019F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AttackMonsterRequest other)
		{
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x001A0E20 File Offset: 0x0019F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x001A0E30 File Offset: 0x0019F030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x001A0E40 File Offset: 0x0019F040
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AttackMonsterRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AttackMonsterRequest._parser = new MessageParser<AttackMonsterRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x001A0F0C File Offset: 0x0019F10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xXYBeaOvoKfyDMjQ8a1k()
		{
			return true;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x001A0F14 File Offset: 0x0019F114
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AttackMonsterRequest b8A7NVOv1NdFoPQCmNmM()
		{
			return null;
		}

		// Token: 0x04000650 RID: 1616
		private static readonly MessageParser<AttackMonsterRequest> _parser;

		// Token: 0x04000651 RID: 1617
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000652 RID: 1618
		public const int MonsterGroupIdFieldNumber = 1;

		// Token: 0x04000653 RID: 1619
		private long monsterGroupId_;

		// Token: 0x04000654 RID: 1620
		internal static AttackMonsterRequest KvJrHSOvvcP2g90Ha9xm;
	}
}
