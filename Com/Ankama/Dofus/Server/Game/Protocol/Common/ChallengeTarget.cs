using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A26 RID: 2598
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeTarget : IMessage<ChallengeTarget>, IMessage, IEquatable<ChallengeTarget>, IDeepCloneable<ChallengeTarget>, IBufferMessage
	{
		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x0025CAF4 File Offset: 0x0025ACF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeTarget> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x0025CB04 File Offset: 0x0025AD04
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x0025CB14 File Offset: 0x0025AD14
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

		// Token: 0x06007BEC RID: 31724 RVA: 0x0025CB24 File Offset: 0x0025AD24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTarget()
		{
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x0025CB34 File Offset: 0x0025AD34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTarget(ChallengeTarget other)
		{
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x0025CB44 File Offset: 0x0025AD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTarget Clone()
		{
			return null;
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x0025CB54 File Offset: 0x0025AD54
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x0025CB64 File Offset: 0x0025AD64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetId
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06007BF1 RID: 31729 RVA: 0x0025CB74 File Offset: 0x0025AD74
		// (set) Token: 0x06007BF2 RID: 31730 RVA: 0x0025CB84 File Offset: 0x0025AD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetCell
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

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x0025CB94 File Offset: 0x0025AD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AttackersId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x0025CBA4 File Offset: 0x0025ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0025CBB4 File Offset: 0x0025ADB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeTarget other)
		{
			return true;
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x0025CBC4 File Offset: 0x0025ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x0025CBD4 File Offset: 0x0025ADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x0025CBE4 File Offset: 0x0025ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x0025CBF4 File Offset: 0x0025ADF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x0025CC04 File Offset: 0x0025AE04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x0025CC14 File Offset: 0x0025AE14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeTarget other)
		{
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x0025CC24 File Offset: 0x0025AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x0025CC34 File Offset: 0x0025AE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x0025CC44 File Offset: 0x0025AE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeTarget()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ChallengeTarget._parser = new MessageParser<ChallengeTarget>(() => null);
						num2 = 5;
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					case 5:
						goto IL_39;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
					}
				}
				IL_39:
				ChallengeTarget._repeated_attackersId_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(26U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num = 4;
			}
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x0025CD48 File Offset: 0x0025AF48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wvcC9XJGxO2NrWRnEcoB()
		{
			return true;
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x0025CD50 File Offset: 0x0025AF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeTarget kI3VSsJG4IOMFW6qB0ex()
		{
			return null;
		}

		// Token: 0x04002C8A RID: 11402
		private static readonly MessageParser<ChallengeTarget> _parser;

		// Token: 0x04002C8B RID: 11403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C8C RID: 11404
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04002C8D RID: 11405
		private long targetId_;

		// Token: 0x04002C8E RID: 11406
		public const int TargetCellFieldNumber = 2;

		// Token: 0x04002C8F RID: 11407
		private int targetCell_;

		// Token: 0x04002C90 RID: 11408
		public const int AttackersIdFieldNumber = 3;

		// Token: 0x04002C91 RID: 11409
		private static readonly FieldCodec<long> _repeated_attackersId_codec;

		// Token: 0x04002C92 RID: 11410
		private readonly RepeatedField<long> attackersId_;

		// Token: 0x04002C93 RID: 11411
		internal static ChallengeTarget SfeAv4JGNnS99yNqVra6;
	}
}
