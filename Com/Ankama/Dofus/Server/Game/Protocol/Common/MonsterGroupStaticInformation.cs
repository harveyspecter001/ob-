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
	// Token: 0x02000B41 RID: 2881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterGroupStaticInformation : IMessage<MonsterGroupStaticInformation>, IMessage, IEquatable<MonsterGroupStaticInformation>, IDeepCloneable<MonsterGroupStaticInformation>, IBufferMessage
	{
		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x00267B6C File Offset: 0x00265D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterGroupStaticInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x00267B7C File Offset: 0x00265D7C
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

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060089EA RID: 35306 RVA: 0x00267B8C File Offset: 0x00265D8C
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

		// Token: 0x060089EB RID: 35307 RVA: 0x00267B9C File Offset: 0x00265D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterGroupStaticInformation()
		{
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x00267BAC File Offset: 0x00265DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterGroupStaticInformation(MonsterGroupStaticInformation other)
		{
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x00267BBC File Offset: 0x00265DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterGroupStaticInformation Clone()
		{
			return null;
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060089EE RID: 35310 RVA: 0x00267BCC File Offset: 0x00265DCC
		// (set) Token: 0x060089EF RID: 35311 RVA: 0x00267BDC File Offset: 0x00265DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInGroupInformation MainCreature
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

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060089F0 RID: 35312 RVA: 0x00267BEC File Offset: 0x00265DEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<MonsterInGroupInformation> Underlings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060089F1 RID: 35313 RVA: 0x00267BFC File Offset: 0x00265DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonstersInGroupAlternativeInformation> Alternatives
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00267C0C File Offset: 0x00265E0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x00267C1C File Offset: 0x00265E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonsterGroupStaticInformation other)
		{
			return true;
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00267C2C File Offset: 0x00265E2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00267C3C File Offset: 0x00265E3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x00267C4C File Offset: 0x00265E4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x00267C5C File Offset: 0x00265E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x00267C6C File Offset: 0x00265E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x00267C7C File Offset: 0x00265E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonsterGroupStaticInformation other)
		{
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x00267C8C File Offset: 0x00265E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x00267C9C File Offset: 0x00265E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x00267CAC File Offset: 0x00265EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonsterGroupStaticInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					MonsterGroupStaticInformation._repeated_alternatives_codec = FieldCodec.ForMessage<MonstersInGroupAlternativeInformation>(26U, fRPsXHBlft0Oylecfypp.XVInXhlssT(fRPsXHBlft0Oylecfypp.ET2BlnnRZL6));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					MonsterGroupStaticInformation._repeated_underlings_codec = FieldCodec.ForMessage<MonsterInGroupInformation>(18U, IYZkmgBkFrHCMb0SZnvF.XVInXhlssT(IYZkmgBkFrHCMb0SZnvF.XOCBkzfLnx5));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MonsterGroupStaticInformation._parser = new MessageParser<MonsterGroupStaticInformation>(() => null);
				num2 = 6;
			}
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x00267E00 File Offset: 0x00266000
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QhvDdNJd0tquIpjEdHy9()
		{
			return true;
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x00267E08 File Offset: 0x00266008
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonsterGroupStaticInformation dJ7nXpJdCx2U4vfwvME1()
		{
			return null;
		}

		// Token: 0x040032CA RID: 13002
		private static readonly MessageParser<MonsterGroupStaticInformation> _parser;

		// Token: 0x040032CB RID: 13003
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032CC RID: 13004
		public const int MainCreatureFieldNumber = 1;

		// Token: 0x040032CD RID: 13005
		private MonsterInGroupInformation mainCreature_;

		// Token: 0x040032CE RID: 13006
		public const int UnderlingsFieldNumber = 2;

		// Token: 0x040032CF RID: 13007
		private static readonly FieldCodec<MonsterInGroupInformation> _repeated_underlings_codec;

		// Token: 0x040032D0 RID: 13008
		private readonly RepeatedField<MonsterInGroupInformation> underlings_;

		// Token: 0x040032D1 RID: 13009
		public const int AlternativesFieldNumber = 3;

		// Token: 0x040032D2 RID: 13010
		private static readonly FieldCodec<MonstersInGroupAlternativeInformation> _repeated_alternatives_codec;

		// Token: 0x040032D3 RID: 13011
		private readonly RepeatedField<MonstersInGroupAlternativeInformation> alternatives_;

		// Token: 0x040032D4 RID: 13012
		internal static MonsterGroupStaticInformation CcjZq0JdVPxF5bXwl3MK;
	}
}
