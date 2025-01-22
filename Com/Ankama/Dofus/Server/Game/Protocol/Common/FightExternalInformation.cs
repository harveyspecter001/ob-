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
	// Token: 0x02000AA3 RID: 2723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightExternalInformation : IMessage<FightExternalInformation>, IMessage, IEquatable<FightExternalInformation>, IDeepCloneable<FightExternalInformation>, IBufferMessage
	{
		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x00261FCC File Offset: 0x002601CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightExternalInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06008217 RID: 33303 RVA: 0x00261FDC File Offset: 0x002601DC
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

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06008218 RID: 33304 RVA: 0x00261FEC File Offset: 0x002601EC
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

		// Token: 0x06008219 RID: 33305 RVA: 0x00261FFC File Offset: 0x002601FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightExternalInformation()
		{
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0026200C File Offset: 0x0026020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightExternalInformation(FightExternalInformation other)
		{
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x0026201C File Offset: 0x0026021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightExternalInformation Clone()
		{
			return null;
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x0600821C RID: 33308 RVA: 0x0026202C File Offset: 0x0026022C
		// (set) Token: 0x0600821D RID: 33309 RVA: 0x0026203C File Offset: 0x0026023C
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

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x0600821E RID: 33310 RVA: 0x0026204C File Offset: 0x0026024C
		// (set) Token: 0x0600821F RID: 33311 RVA: 0x00262060 File Offset: 0x00260260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x00262070 File Offset: 0x00260270
		// (set) Token: 0x06008221 RID: 33313 RVA: 0x00262080 File Offset: 0x00260280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FightStart
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06008222 RID: 33314 RVA: 0x00262090 File Offset: 0x00260290
		// (set) Token: 0x06008223 RID: 33315 RVA: 0x002620A0 File Offset: 0x002602A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool FightSpectatorLocked
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

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x002620B0 File Offset: 0x002602B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightExternalInformation.Types.FightTeamsWithOptions> FightTeamsWithOptions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x002620C0 File Offset: 0x002602C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x002620D0 File Offset: 0x002602D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightExternalInformation other)
		{
			return true;
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x002620E0 File Offset: 0x002602E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x002620F0 File Offset: 0x002602F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x00262100 File Offset: 0x00260300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x00262110 File Offset: 0x00260310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x00262120 File Offset: 0x00260320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x00262130 File Offset: 0x00260330
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightExternalInformation other)
		{
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x00262140 File Offset: 0x00260340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x00262150 File Offset: 0x00260350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x00262160 File Offset: 0x00260360
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightExternalInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					FightExternalInformation._repeated_fightTeamsWithOptions_codec = FieldCodec.ForMessage<FightExternalInformation.Types.FightTeamsWithOptions>(42U, OdswtXBI4Aq5dRCZPmEE.XVInXhlssT(OdswtXBI4Aq5dRCZPmEE.mwkBIjTU5VG));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					FightExternalInformation._parser = new MessageParser<FightExternalInformation>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x00262250 File Offset: 0x00260450
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fr1kOnJguMbupYNRT2Te()
		{
			return true;
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x00262258 File Offset: 0x00260458
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightExternalInformation FSQkdVJg8EawN9u4G0GG()
		{
			return null;
		}

		// Token: 0x04002F5F RID: 12127
		private static readonly MessageParser<FightExternalInformation> _parser;

		// Token: 0x04002F60 RID: 12128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F61 RID: 12129
		public const int FightIdFieldNumber = 1;

		// Token: 0x04002F62 RID: 12130
		private int fightId_;

		// Token: 0x04002F63 RID: 12131
		public const int FightTypeFieldNumber = 2;

		// Token: 0x04002F64 RID: 12132
		private FightType fightType_;

		// Token: 0x04002F65 RID: 12133
		public const int FightStartFieldNumber = 3;

		// Token: 0x04002F66 RID: 12134
		private long fightStart_;

		// Token: 0x04002F67 RID: 12135
		public const int FightSpectatorLockedFieldNumber = 4;

		// Token: 0x04002F68 RID: 12136
		private bool fightSpectatorLocked_;

		// Token: 0x04002F69 RID: 12137
		public const int FightTeamsWithOptionsFieldNumber = 5;

		// Token: 0x04002F6A RID: 12138
		private static readonly FieldCodec<FightExternalInformation.Types.FightTeamsWithOptions> _repeated_fightTeamsWithOptions_codec;

		// Token: 0x04002F6B RID: 12139
		private readonly RepeatedField<FightExternalInformation.Types.FightTeamsWithOptions> fightTeamsWithOptions_;

		// Token: 0x04002F6C RID: 12140
		internal static FightExternalInformation NAoKehJgMjWqqLYFRGaD;

		// Token: 0x02000AA4 RID: 2724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008232 RID: 33330 RVA: 0x002E13A8 File Offset: 0x002DF5A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000AA5 RID: 2725
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FightTeamsWithOptions : IMessage<FightExternalInformation.Types.FightTeamsWithOptions>, IMessage, IEquatable<FightExternalInformation.Types.FightTeamsWithOptions>, IDeepCloneable<FightExternalInformation.Types.FightTeamsWithOptions>, IBufferMessage
			{
				// Token: 0x170017CE RID: 6094
				// (get) Token: 0x06008233 RID: 33331 RVA: 0x00308728 File Offset: 0x00306928
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FightExternalInformation.Types.FightTeamsWithOptions> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170017CF RID: 6095
				// (get) Token: 0x06008234 RID: 33332 RVA: 0x00308738 File Offset: 0x00306938
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

				// Token: 0x170017D0 RID: 6096
				// (get) Token: 0x06008235 RID: 33333 RVA: 0x00308748 File Offset: 0x00306948
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

				// Token: 0x06008236 RID: 33334 RVA: 0x00308758 File Offset: 0x00306958
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightTeamsWithOptions()
				{
				}

				// Token: 0x06008237 RID: 33335 RVA: 0x00308768 File Offset: 0x00306968
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightTeamsWithOptions(FightExternalInformation.Types.FightTeamsWithOptions other)
				{
				}

				// Token: 0x06008238 RID: 33336 RVA: 0x00308778 File Offset: 0x00306978
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightExternalInformation.Types.FightTeamsWithOptions Clone()
				{
					return null;
				}

				// Token: 0x170017D1 RID: 6097
				// (get) Token: 0x06008239 RID: 33337 RVA: 0x00308788 File Offset: 0x00306988
				// (set) Token: 0x0600823A RID: 33338 RVA: 0x00308798 File Offset: 0x00306998
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightTeamInformation FightTeam
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

				// Token: 0x170017D2 RID: 6098
				// (get) Token: 0x0600823B RID: 33339 RVA: 0x003087A8 File Offset: 0x003069A8
				// (set) Token: 0x0600823C RID: 33340 RVA: 0x003087B8 File Offset: 0x003069B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightOptionsInformation FightTeamOptions
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

				// Token: 0x0600823D RID: 33341 RVA: 0x003087C8 File Offset: 0x003069C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600823E RID: 33342 RVA: 0x003087D8 File Offset: 0x003069D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightExternalInformation.Types.FightTeamsWithOptions other)
				{
					return true;
				}

				// Token: 0x0600823F RID: 33343 RVA: 0x003087E8 File Offset: 0x003069E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008240 RID: 33344 RVA: 0x003087F8 File Offset: 0x003069F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008241 RID: 33345 RVA: 0x00308808 File Offset: 0x00306A08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008242 RID: 33346 RVA: 0x00308818 File Offset: 0x00306A18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008243 RID: 33347 RVA: 0x00308828 File Offset: 0x00306A28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008244 RID: 33348 RVA: 0x00308838 File Offset: 0x00306A38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightExternalInformation.Types.FightTeamsWithOptions other)
				{
				}

				// Token: 0x06008245 RID: 33349 RVA: 0x00308848 File Offset: 0x00306A48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008246 RID: 33350 RVA: 0x00308858 File Offset: 0x00306A58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008247 RID: 33351 RVA: 0x00308868 File Offset: 0x00306A68
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FightTeamsWithOptions()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							FightExternalInformation.Types.FightTeamsWithOptions._parser = new MessageParser<FightExternalInformation.Types.FightTeamsWithOptions>(() => null);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x06008248 RID: 33352 RVA: 0x0030894C File Offset: 0x00306B4C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool vLvIbAGu6IBJTw04MdKh()
				{
					return true;
				}

				// Token: 0x06008249 RID: 33353 RVA: 0x00308954 File Offset: 0x00306B54
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightExternalInformation.Types.FightTeamsWithOptions oMgWcIGuLjK6wIEsmBDr()
				{
					return null;
				}

				// Token: 0x04002F6D RID: 12141
				private static readonly MessageParser<FightExternalInformation.Types.FightTeamsWithOptions> _parser;

				// Token: 0x04002F6E RID: 12142
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002F6F RID: 12143
				public const int FightTeamFieldNumber = 1;

				// Token: 0x04002F70 RID: 12144
				private FightTeamInformation fightTeam_;

				// Token: 0x04002F71 RID: 12145
				public const int FightTeamOptionsFieldNumber = 2;

				// Token: 0x04002F72 RID: 12146
				private FightOptionsInformation fightTeamOptions_;

				// Token: 0x04002F73 RID: 12147
				internal static FightExternalInformation.Types.FightTeamsWithOptions tiAdVfGuybOhDkrOJ7yJ;
			}
		}
	}
}
