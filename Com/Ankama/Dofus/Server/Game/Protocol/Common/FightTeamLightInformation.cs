using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AA8 RID: 2728
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamLightInformation : IMessage<FightTeamLightInformation>, IMessage, IEquatable<FightTeamLightInformation>, IDeepCloneable<FightTeamLightInformation>, IBufferMessage
	{
		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x00262260 File Offset: 0x00260460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06008255 RID: 33365 RVA: 0x00262270 File Offset: 0x00260470
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

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06008256 RID: 33366 RVA: 0x00262280 File Offset: 0x00260480
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

		// Token: 0x06008257 RID: 33367 RVA: 0x00262290 File Offset: 0x00260490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamLightInformation()
		{
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x002622A0 File Offset: 0x002604A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamLightInformation(FightTeamLightInformation other)
		{
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x002622B0 File Offset: 0x002604B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamLightInformation Clone()
		{
			return null;
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x002622C0 File Offset: 0x002604C0
		// (set) Token: 0x0600825B RID: 33371 RVA: 0x002622D0 File Offset: 0x002604D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamMembersCount
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

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x002622E0 File Offset: 0x002604E0
		// (set) Token: 0x0600825D RID: 33373 RVA: 0x002622F0 File Offset: 0x002604F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AverageLevel
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

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x00262300 File Offset: 0x00260500
		// (set) Token: 0x0600825F RID: 33375 RVA: 0x00262310 File Offset: 0x00260510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFriend
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

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x00262320 File Offset: 0x00260520
		// (set) Token: 0x06008261 RID: 33377 RVA: 0x00262330 File Offset: 0x00260530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasGuildMember
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06008262 RID: 33378 RVA: 0x00262340 File Offset: 0x00260540
		// (set) Token: 0x06008263 RID: 33379 RVA: 0x00262350 File Offset: 0x00260550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAllianceMember
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06008264 RID: 33380 RVA: 0x00262360 File Offset: 0x00260560
		// (set) Token: 0x06008265 RID: 33381 RVA: 0x00262370 File Offset: 0x00260570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasGroupMember
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

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06008266 RID: 33382 RVA: 0x00262380 File Offset: 0x00260580
		// (set) Token: 0x06008267 RID: 33383 RVA: 0x00262390 File Offset: 0x00260590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMyTaxCollector
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

		// Token: 0x06008268 RID: 33384 RVA: 0x002623A0 File Offset: 0x002605A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x002623B0 File Offset: 0x002605B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamLightInformation other)
		{
			return true;
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x002623C0 File Offset: 0x002605C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x002623D0 File Offset: 0x002605D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x002623E0 File Offset: 0x002605E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x002623F0 File Offset: 0x002605F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x00262400 File Offset: 0x00260600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x00262410 File Offset: 0x00260610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamLightInformation other)
		{
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x00262420 File Offset: 0x00260620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x00262430 File Offset: 0x00260630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x00262440 File Offset: 0x00260640
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamLightInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						goto IL_5F;
					case 4:
						FightTeamLightInformation._parser = new MessageParser<FightTeamLightInformation>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 2;
						}
						break;
					}
				}
				IL_5F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x00262528 File Offset: 0x00260728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EM84pbJgqpnMV1HePIki()
		{
			return true;
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x00262530 File Offset: 0x00260730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamLightInformation vY3TGuJgFWZODsBWgvJB()
		{
			return null;
		}

		// Token: 0x04002F78 RID: 12152
		private static readonly MessageParser<FightTeamLightInformation> _parser;

		// Token: 0x04002F79 RID: 12153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F7A RID: 12154
		public const int TeamMembersCountFieldNumber = 1;

		// Token: 0x04002F7B RID: 12155
		private int teamMembersCount_;

		// Token: 0x04002F7C RID: 12156
		public const int AverageLevelFieldNumber = 2;

		// Token: 0x04002F7D RID: 12157
		private int averageLevel_;

		// Token: 0x04002F7E RID: 12158
		public const int HasFriendFieldNumber = 3;

		// Token: 0x04002F7F RID: 12159
		private bool hasFriend_;

		// Token: 0x04002F80 RID: 12160
		public const int HasGuildMemberFieldNumber = 4;

		// Token: 0x04002F81 RID: 12161
		private bool hasGuildMember_;

		// Token: 0x04002F82 RID: 12162
		public const int HasAllianceMemberFieldNumber = 5;

		// Token: 0x04002F83 RID: 12163
		private bool hasAllianceMember_;

		// Token: 0x04002F84 RID: 12164
		public const int HasGroupMemberFieldNumber = 6;

		// Token: 0x04002F85 RID: 12165
		private bool hasGroupMember_;

		// Token: 0x04002F86 RID: 12166
		public const int HasMyTaxCollectorFieldNumber = 7;

		// Token: 0x04002F87 RID: 12167
		private bool hasMyTaxCollector_;

		// Token: 0x04002F88 RID: 12168
		internal static FightTeamLightInformation vAoOfaJgZ7cQpRsfJS4C;
	}
}
