using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DD3 RID: 3539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsPioneerRanksResponse : IMessage<AchievementsPioneerRanksResponse>, IMessage, IEquatable<AchievementsPioneerRanksResponse>, IDeepCloneable<AchievementsPioneerRanksResponse>, IBufferMessage
	{
		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x002990B0 File Offset: 0x002972B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsPioneerRanksResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x002990C0 File Offset: 0x002972C0
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

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x002990D0 File Offset: 0x002972D0
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

		// Token: 0x0600AA8B RID: 43659 RVA: 0x002990E0 File Offset: 0x002972E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksResponse()
		{
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x002990F0 File Offset: 0x002972F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksResponse(AchievementsPioneerRanksResponse other)
		{
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x00299100 File Offset: 0x00297300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksResponse Clone()
		{
			return null;
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x00299110 File Offset: 0x00297310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank> AchievementsPioneerRanks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x00299120 File Offset: 0x00297320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x00299130 File Offset: 0x00297330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsPioneerRanksResponse other)
		{
			return true;
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x00299140 File Offset: 0x00297340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x00299150 File Offset: 0x00297350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x00299160 File Offset: 0x00297360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x00299170 File Offset: 0x00297370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x00299180 File Offset: 0x00297380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x00299190 File Offset: 0x00297390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsPioneerRanksResponse other)
		{
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x002991A0 File Offset: 0x002973A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x002991B0 File Offset: 0x002973B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x002991C0 File Offset: 0x002973C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsPioneerRanksResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AchievementsPioneerRanksResponse._parser = new MessageParser<AchievementsPioneerRanksResponse>(() => null);
					num2 = 5;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					AchievementsPioneerRanksResponse._repeated_achievementsPioneerRanks_codec = FieldCodec.ForMessage<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank>(10U, rE31cR3sSY34L9WNx5kS.XVInXhlssT(rE31cR3sSY34L9WNx5kS.tMe3sMaMjSk));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x002992DC File Offset: 0x002974DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AqsLXxJcwZRNb2bNekhG()
		{
			return true;
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x002992E4 File Offset: 0x002974E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsPioneerRanksResponse CIUJQwJcQu9GJSuNSQ9v()
		{
			return null;
		}

		// Token: 0x04003E98 RID: 16024
		private static readonly MessageParser<AchievementsPioneerRanksResponse> _parser;

		// Token: 0x04003E99 RID: 16025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E9A RID: 16026
		public const int AchievementsPioneerRanksFieldNumber = 1;

		// Token: 0x04003E9B RID: 16027
		private static readonly FieldCodec<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank> _repeated_achievementsPioneerRanks_codec;

		// Token: 0x04003E9C RID: 16028
		private readonly RepeatedField<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank> achievementsPioneerRanks_;

		// Token: 0x04003E9D RID: 16029
		private static AchievementsPioneerRanksResponse VKM67WJctDeKZkEZjJIv;

		// Token: 0x02000DD4 RID: 3540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600AA9C RID: 43676 RVA: 0x002F28A0 File Offset: 0x002F0AA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000DD5 RID: 3541
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AchievementPioneerRank : IMessage<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank>, IMessage, IEquatable<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank>, IDeepCloneable<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank>, IBufferMessage
			{
				// Token: 0x17001F9A RID: 8090
				// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x0030EFDC File Offset: 0x0030D1DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001F9B RID: 8091
				// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x0030EFEC File Offset: 0x0030D1EC
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

				// Token: 0x17001F9C RID: 8092
				// (get) Token: 0x0600AA9F RID: 43679 RVA: 0x0030EFFC File Offset: 0x0030D1FC
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

				// Token: 0x0600AAA0 RID: 43680 RVA: 0x0030F00C File Offset: 0x0030D20C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AchievementPioneerRank()
				{
				}

				// Token: 0x0600AAA1 RID: 43681 RVA: 0x0030F01C File Offset: 0x0030D21C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AchievementPioneerRank(AchievementsPioneerRanksResponse.Types.AchievementPioneerRank other)
				{
				}

				// Token: 0x0600AAA2 RID: 43682 RVA: 0x0030F02C File Offset: 0x0030D22C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AchievementsPioneerRanksResponse.Types.AchievementPioneerRank Clone()
				{
					return null;
				}

				// Token: 0x17001F9D RID: 8093
				// (get) Token: 0x0600AAA3 RID: 43683 RVA: 0x0030F03C File Offset: 0x0030D23C
				// (set) Token: 0x0600AAA4 RID: 43684 RVA: 0x0030F04C File Offset: 0x0030D24C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int AchievementId
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

				// Token: 0x17001F9E RID: 8094
				// (get) Token: 0x0600AAA5 RID: 43685 RVA: 0x0030F05C File Offset: 0x0030D25C
				// (set) Token: 0x0600AAA6 RID: 43686 RVA: 0x0030F06C File Offset: 0x0030D26C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int PioneerRank
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

				// Token: 0x0600AAA7 RID: 43687 RVA: 0x0030F07C File Offset: 0x0030D27C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AAA8 RID: 43688 RVA: 0x0030F08C File Offset: 0x0030D28C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AchievementsPioneerRanksResponse.Types.AchievementPioneerRank other)
				{
					return true;
				}

				// Token: 0x0600AAA9 RID: 43689 RVA: 0x0030F09C File Offset: 0x0030D29C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AAAA RID: 43690 RVA: 0x0030F0AC File Offset: 0x0030D2AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AAAB RID: 43691 RVA: 0x0030F0BC File Offset: 0x0030D2BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AAAC RID: 43692 RVA: 0x0030F0CC File Offset: 0x0030D2CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AAAD RID: 43693 RVA: 0x0030F0DC File Offset: 0x0030D2DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AAAE RID: 43694 RVA: 0x0030F0EC File Offset: 0x0030D2EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AchievementsPioneerRanksResponse.Types.AchievementPioneerRank other)
				{
				}

				// Token: 0x0600AAAF RID: 43695 RVA: 0x0030F0FC File Offset: 0x0030D2FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AAB0 RID: 43696 RVA: 0x0030F10C File Offset: 0x0030D30C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AAB1 RID: 43697 RVA: 0x0030F11C File Offset: 0x0030D31C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AchievementPioneerRank()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							AchievementsPioneerRanksResponse.Types.AchievementPioneerRank._parser = new MessageParser<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
					}
				}

				// Token: 0x0600AAB2 RID: 43698 RVA: 0x0030F1E8 File Offset: 0x0030D3E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool HopgXWGqKA0dr8S9MtZ8()
				{
					return true;
				}

				// Token: 0x0600AAB3 RID: 43699 RVA: 0x0030F1F0 File Offset: 0x0030D3F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AchievementsPioneerRanksResponse.Types.AchievementPioneerRank YEmIaLGqI2r1xEvhDjkM()
				{
					return null;
				}

				// Token: 0x04003E9E RID: 16030
				private static readonly MessageParser<AchievementsPioneerRanksResponse.Types.AchievementPioneerRank> _parser;

				// Token: 0x04003E9F RID: 16031
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003EA0 RID: 16032
				public const int AchievementIdFieldNumber = 1;

				// Token: 0x04003EA1 RID: 16033
				private int achievementId_;

				// Token: 0x04003EA2 RID: 16034
				public const int PioneerRankFieldNumber = 2;

				// Token: 0x04003EA3 RID: 16035
				private int pioneerRank_;

				// Token: 0x04003EA4 RID: 16036
				private static AchievementsPioneerRanksResponse.Types.AchievementPioneerRank wIfwi9GqjlSuOEoJXXLd;
			}
		}
	}
}
