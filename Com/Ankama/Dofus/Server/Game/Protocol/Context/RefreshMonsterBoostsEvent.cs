using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x0200081F RID: 2079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RefreshMonsterBoostsEvent : IMessage<RefreshMonsterBoostsEvent>, IMessage, IEquatable<RefreshMonsterBoostsEvent>, IDeepCloneable<RefreshMonsterBoostsEvent>, IBufferMessage
	{
		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x002278B8 File Offset: 0x00225AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RefreshMonsterBoostsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06006528 RID: 25896 RVA: 0x002278C8 File Offset: 0x00225AC8
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

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06006529 RID: 25897 RVA: 0x002278D8 File Offset: 0x00225AD8
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

		// Token: 0x0600652A RID: 25898 RVA: 0x002278E8 File Offset: 0x00225AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefreshMonsterBoostsEvent()
		{
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x002278F8 File Offset: 0x00225AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefreshMonsterBoostsEvent(RefreshMonsterBoostsEvent other)
		{
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x00227908 File Offset: 0x00225B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefreshMonsterBoostsEvent Clone()
		{
			return null;
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x00227918 File Offset: 0x00225B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterBoosts> MonsterBoosts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x00227928 File Offset: 0x00225B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<MonsterBoosts> FamilyBoosts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00227938 File Offset: 0x00225B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00227948 File Offset: 0x00225B48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RefreshMonsterBoostsEvent other)
		{
			return true;
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00227958 File Offset: 0x00225B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00227968 File Offset: 0x00225B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x00227978 File Offset: 0x00225B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00227988 File Offset: 0x00225B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00227998 File Offset: 0x00225B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x002279A8 File Offset: 0x00225BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RefreshMonsterBoostsEvent other)
		{
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x002279B8 File Offset: 0x00225BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x002279C8 File Offset: 0x00225BC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x002279D8 File Offset: 0x00225BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RefreshMonsterBoostsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					RefreshMonsterBoostsEvent._repeated_familyBoosts_codec = FieldCodec.ForMessage<MonsterBoosts>(18U, sxLGHMAw3sqedi7yfm9R.XVInXhlssT(sxLGHMAw3sqedi7yfm9R.FrEAwRXfJMI));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					RefreshMonsterBoostsEvent._parser = new MessageParser<RefreshMonsterBoostsEvent>(() => null);
					num2 = 6;
					continue;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 6:
					RefreshMonsterBoostsEvent._repeated_monsterBoosts_codec = FieldCodec.ForMessage<MonsterBoosts>(10U, sxLGHMAw3sqedi7yfm9R.XVInXhlssT(sxLGHMAw3sqedi7yfm9R.FrEAwRXfJMI));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00227B04 File Offset: 0x00225D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wNiiKmJfAxRCZW9EBsMX()
		{
			return true;
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x00227B0C File Offset: 0x00225D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RefreshMonsterBoostsEvent EijW9hJfBcvLiU8TNLsg()
		{
			return null;
		}

		// Token: 0x04002381 RID: 9089
		private static readonly MessageParser<RefreshMonsterBoostsEvent> _parser;

		// Token: 0x04002382 RID: 9090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002383 RID: 9091
		public const int MonsterBoostsFieldNumber = 1;

		// Token: 0x04002384 RID: 9092
		private static readonly FieldCodec<MonsterBoosts> _repeated_monsterBoosts_codec;

		// Token: 0x04002385 RID: 9093
		private readonly RepeatedField<MonsterBoosts> monsterBoosts_;

		// Token: 0x04002386 RID: 9094
		public const int FamilyBoostsFieldNumber = 2;

		// Token: 0x04002387 RID: 9095
		private static readonly FieldCodec<MonsterBoosts> _repeated_familyBoosts_codec;

		// Token: 0x04002388 RID: 9096
		private readonly RepeatedField<MonsterBoosts> familyBoosts_;

		// Token: 0x04002389 RID: 9097
		private static RefreshMonsterBoostsEvent DPkT4aJfmmDYBFu6IjMh;
	}
}
