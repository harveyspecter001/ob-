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
	// Token: 0x02000A9E RID: 2718
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightCommonInformation : IMessage<FightCommonInformation>, IMessage, IEquatable<FightCommonInformation>, IDeepCloneable<FightCommonInformation>, IBufferMessage
	{
		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x060081CF RID: 33231 RVA: 0x00261A24 File Offset: 0x0025FC24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightCommonInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x060081D0 RID: 33232 RVA: 0x00261A34 File Offset: 0x0025FC34
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

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x060081D1 RID: 33233 RVA: 0x00261A44 File Offset: 0x0025FC44
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

		// Token: 0x060081D2 RID: 33234 RVA: 0x00261A54 File Offset: 0x0025FC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCommonInformation()
		{
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00261A64 File Offset: 0x0025FC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCommonInformation(FightCommonInformation other)
		{
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00261A74 File Offset: 0x0025FC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCommonInformation Clone()
		{
			return null;
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x00261A84 File Offset: 0x0025FC84
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x00261A94 File Offset: 0x0025FC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightId
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

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x00261AA4 File Offset: 0x0025FCA4
		// (set) Token: 0x060081D8 RID: 33240 RVA: 0x00261AB8 File Offset: 0x0025FCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightType Type
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

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x00261AC8 File Offset: 0x0025FCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightTeamInformation> TeamsInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x060081DA RID: 33242 RVA: 0x00261AD8 File Offset: 0x0025FCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TeamsPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x060081DB RID: 33243 RVA: 0x00261AE8 File Offset: 0x0025FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightOptionsInformation> TeamsOptions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x00261AF8 File Offset: 0x0025FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x00261B08 File Offset: 0x0025FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightCommonInformation other)
		{
			return true;
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x00261B18 File Offset: 0x0025FD18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x00261B28 File Offset: 0x0025FD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x00261B38 File Offset: 0x0025FD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x00261B48 File Offset: 0x0025FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x00261B58 File Offset: 0x0025FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x00261B68 File Offset: 0x0025FD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightCommonInformation other)
		{
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x00261B78 File Offset: 0x0025FD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x00261B88 File Offset: 0x0025FD88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x00261B98 File Offset: 0x0025FD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightCommonInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						FightCommonInformation._repeated_teamsOptions_codec = FieldCodec.ForMessage<FightOptionsInformation>(42U, bn4sYTBIObgh0uUfORc5.XVInXhlssT(bn4sYTBIObgh0uUfORc5.xUlBIJ8Yxvg));
						num2 = 7;
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 6;
						continue;
					case 3:
						FightCommonInformation._repeated_teamsInformation_codec = FieldCodec.ForMessage<FightTeamInformation>(26U, p0ZHFVBINVFhEWZHWjJe.XVInXhlssT(p0ZHFVBINVFhEWZHWjJe.LVGBIxJ3a0e));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						continue;
					case 6:
						goto IL_41;
					case 7:
						return;
					}
					FightCommonInformation._repeated_teamsPosition_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 1;
					}
				}
				IL_41:
				FightCommonInformation._parser = new MessageParser<FightCommonInformation>(() => null);
				num = 3;
			}
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x00261CD0 File Offset: 0x0025FED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ebL5U6JgYnxj0AkmnPfm()
		{
			return true;
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x00261CD8 File Offset: 0x0025FED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightCommonInformation foMlKCJgbbqTVVrgB2EB()
		{
			return null;
		}

		// Token: 0x04002F36 RID: 12086
		private static readonly MessageParser<FightCommonInformation> _parser;

		// Token: 0x04002F37 RID: 12087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F38 RID: 12088
		public const int FightIdFieldNumber = 1;

		// Token: 0x04002F39 RID: 12089
		private int fightId_;

		// Token: 0x04002F3A RID: 12090
		public const int TypeFieldNumber = 2;

		// Token: 0x04002F3B RID: 12091
		private FightType type_;

		// Token: 0x04002F3C RID: 12092
		public const int TeamsInformationFieldNumber = 3;

		// Token: 0x04002F3D RID: 12093
		private static readonly FieldCodec<FightTeamInformation> _repeated_teamsInformation_codec;

		// Token: 0x04002F3E RID: 12094
		private readonly RepeatedField<FightTeamInformation> teamsInformation_;

		// Token: 0x04002F3F RID: 12095
		public const int TeamsPositionFieldNumber = 4;

		// Token: 0x04002F40 RID: 12096
		private static readonly FieldCodec<int> _repeated_teamsPosition_codec;

		// Token: 0x04002F41 RID: 12097
		private readonly RepeatedField<int> teamsPosition_;

		// Token: 0x04002F42 RID: 12098
		public const int TeamsOptionsFieldNumber = 5;

		// Token: 0x04002F43 RID: 12099
		private static readonly FieldCodec<FightOptionsInformation> _repeated_teamsOptions_codec;

		// Token: 0x04002F44 RID: 12100
		private readonly RepeatedField<FightOptionsInformation> teamsOptions_;

		// Token: 0x04002F45 RID: 12101
		private static FightCommonInformation GTkrVRJgHxyPjw4A7c6b;
	}
}
