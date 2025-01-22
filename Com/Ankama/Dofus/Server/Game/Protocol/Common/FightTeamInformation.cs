using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AA0 RID: 2720
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamInformation : IMessage<FightTeamInformation>, IMessage, IEquatable<FightTeamInformation>, IDeepCloneable<FightTeamInformation>, IBufferMessage
	{
		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x060081EE RID: 33262 RVA: 0x00261CE0 File Offset: 0x0025FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTeamInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x00261CF0 File Offset: 0x0025FEF0
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

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x00261D00 File Offset: 0x0025FF00
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

		// Token: 0x060081F1 RID: 33265 RVA: 0x00261D10 File Offset: 0x0025FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamInformation()
		{
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x00261D20 File Offset: 0x0025FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamInformation(FightTeamInformation other)
		{
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x00261D30 File Offset: 0x0025FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamInformation Clone()
		{
			return null;
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x060081F4 RID: 33268 RVA: 0x00261D40 File Offset: 0x0025FF40
		// (set) Token: 0x060081F5 RID: 33269 RVA: 0x00261D54 File Offset: 0x0025FF54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x060081F6 RID: 33270 RVA: 0x00261D64 File Offset: 0x0025FF64
		// (set) Token: 0x060081F7 RID: 33271 RVA: 0x00261D74 File Offset: 0x0025FF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long LeaderId
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

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x00261D84 File Offset: 0x0025FF84
		// (set) Token: 0x060081F9 RID: 33273 RVA: 0x00261D98 File Offset: 0x0025FF98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Alignment Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Alignment)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x060081FA RID: 33274 RVA: 0x00261DA8 File Offset: 0x0025FFA8
		// (set) Token: 0x060081FB RID: 33275 RVA: 0x00261DBC File Offset: 0x0025FFBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TeamType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TeamType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x060081FC RID: 33276 RVA: 0x00261DCC File Offset: 0x0025FFCC
		// (set) Token: 0x060081FD RID: 33277 RVA: 0x00261DDC File Offset: 0x0025FFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Waves
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

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x00261DEC File Offset: 0x0025FFEC
		// (set) Token: 0x060081FF RID: 33279 RVA: 0x00261DFC File Offset: 0x0025FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamMembersInformation TeamMembers
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

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06008200 RID: 33280 RVA: 0x00261E0C File Offset: 0x0026000C
		// (set) Token: 0x06008201 RID: 33281 RVA: 0x00261E1C File Offset: 0x0026001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamLightInformation LightInformation
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06008202 RID: 33282 RVA: 0x00261E2C File Offset: 0x0026002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamInformation.TeamInformationOneofCase TeamInformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightTeamInformation.TeamInformationOneofCase)null;
			}
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00261E40 File Offset: 0x00260040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearTeamInformation()
		{
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00261E50 File Offset: 0x00260050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00261E60 File Offset: 0x00260060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamInformation other)
		{
			return true;
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00261E70 File Offset: 0x00260070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00261E80 File Offset: 0x00260080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00261E90 File Offset: 0x00260090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00261EA0 File Offset: 0x002600A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x00261EB0 File Offset: 0x002600B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00261EC0 File Offset: 0x002600C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamInformation other)
		{
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x00261ED0 File Offset: 0x002600D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00261EE0 File Offset: 0x002600E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x00261EF0 File Offset: 0x002600F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					FightTeamInformation._parser = new MessageParser<FightTeamInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x00261FBC File Offset: 0x002601BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kWniyxJgPdL9r3qr31y2()
		{
			return true;
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x00261FC4 File Offset: 0x002601C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamInformation t4NmsMJgS1FGXRPfaOss()
		{
			return null;
		}

		// Token: 0x04002F48 RID: 12104
		private static readonly MessageParser<FightTeamInformation> _parser;

		// Token: 0x04002F49 RID: 12105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F4A RID: 12106
		public const int TeamFieldNumber = 1;

		// Token: 0x04002F4B RID: 12107
		private Team team_;

		// Token: 0x04002F4C RID: 12108
		public const int LeaderIdFieldNumber = 2;

		// Token: 0x04002F4D RID: 12109
		private long leaderId_;

		// Token: 0x04002F4E RID: 12110
		public const int SideFieldNumber = 3;

		// Token: 0x04002F4F RID: 12111
		private Alignment side_;

		// Token: 0x04002F50 RID: 12112
		public const int TypeFieldNumber = 4;

		// Token: 0x04002F51 RID: 12113
		private TeamType type_;

		// Token: 0x04002F52 RID: 12114
		public const int WavesFieldNumber = 5;

		// Token: 0x04002F53 RID: 12115
		private int waves_;

		// Token: 0x04002F54 RID: 12116
		public const int TeamMembersFieldNumber = 6;

		// Token: 0x04002F55 RID: 12117
		public const int LightInformationFieldNumber = 7;

		// Token: 0x04002F56 RID: 12118
		private object teamInformation_;

		// Token: 0x04002F57 RID: 12119
		private FightTeamInformation.TeamInformationOneofCase teamInformationCase_;

		// Token: 0x04002F58 RID: 12120
		private static FightTeamInformation h6iPPTJgiuAEBMKkE1Ms;

		// Token: 0x02000AA1 RID: 2721
		public enum TeamInformationOneofCase
		{
			// Token: 0x04002F5A RID: 12122
			None,
			// Token: 0x04002F5B RID: 12123
			TeamMembers = 6,
			// Token: 0x04002F5C RID: 12124
			LightInformation
		}
	}
}
