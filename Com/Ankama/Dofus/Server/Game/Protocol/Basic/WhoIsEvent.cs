using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BD0 RID: 3024
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoIsEvent : IMessage<WhoIsEvent>, IMessage, IEquatable<WhoIsEvent>, IDeepCloneable<WhoIsEvent>, IBufferMessage
	{
		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x0600917D RID: 37245 RVA: 0x0026FC34 File Offset: 0x0026DE34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WhoIsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x0026FC44 File Offset: 0x0026DE44
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

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x0026FC54 File Offset: 0x0026DE54
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

		// Token: 0x06009180 RID: 37248 RVA: 0x0026FC64 File Offset: 0x0026DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsEvent()
		{
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x0026FC74 File Offset: 0x0026DE74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsEvent(WhoIsEvent other)
		{
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x0026FC84 File Offset: 0x0026DE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06009183 RID: 37251 RVA: 0x0026FC94 File Offset: 0x0026DE94
		// (set) Token: 0x06009184 RID: 37252 RVA: 0x0026FCA4 File Offset: 0x0026DEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Self
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06009185 RID: 37253 RVA: 0x0026FCB4 File Offset: 0x0026DEB4
		// (set) Token: 0x06009186 RID: 37254 RVA: 0x0026FCC8 File Offset: 0x0026DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Hierarchy Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Hierarchy)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06009187 RID: 37255 RVA: 0x0026FCD8 File Offset: 0x0026DED8
		// (set) Token: 0x06009188 RID: 37256 RVA: 0x0026FCE8 File Offset: 0x0026DEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AccountName
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

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x0026FCF8 File Offset: 0x0026DEF8
		// (set) Token: 0x0600918A RID: 37258 RVA: 0x0026FD08 File Offset: 0x0026DF08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AccountTag
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x0026FD18 File Offset: 0x0026DF18
		// (set) Token: 0x0600918C RID: 37260 RVA: 0x0026FD28 File Offset: 0x0026DF28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
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

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x0026FD38 File Offset: 0x0026DF38
		// (set) Token: 0x0600918E RID: 37262 RVA: 0x0026FD48 File Offset: 0x0026DF48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string CharacterName
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x0026FD58 File Offset: 0x0026DF58
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x0026FD68 File Offset: 0x0026DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x0026FD78 File Offset: 0x0026DF78
		// (set) Token: 0x06009192 RID: 37266 RVA: 0x0026FD88 File Offset: 0x0026DF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x0026FD98 File Offset: 0x0026DF98
		// (set) Token: 0x06009194 RID: 37268 RVA: 0x0026FDA8 File Offset: 0x0026DFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ServerId
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06009195 RID: 37269 RVA: 0x0026FDB8 File Offset: 0x0026DFB8
		// (set) Token: 0x06009196 RID: 37270 RVA: 0x0026FDC8 File Offset: 0x0026DFC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int OriginServerId
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06009197 RID: 37271 RVA: 0x0026FDD8 File Offset: 0x0026DFD8
		// (set) Token: 0x06009198 RID: 37272 RVA: 0x0026FDE8 File Offset: 0x0026DFE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Verbose
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06009199 RID: 37273 RVA: 0x0026FDF8 File Offset: 0x0026DFF8
		// (set) Token: 0x0600919A RID: 37274 RVA: 0x0026FE0C File Offset: 0x0026E00C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600919B RID: 37275 RVA: 0x0026FE1C File Offset: 0x0026E01C
		// (set) Token: 0x0600919C RID: 37276 RVA: 0x0026FE2C File Offset: 0x0026E02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation GuildInformation
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600919D RID: 37277 RVA: 0x0026FE3C File Offset: 0x0026E03C
		// (set) Token: 0x0600919E RID: 37278 RVA: 0x0026FE4C File Offset: 0x0026E04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation AllianceInformation
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

		// Token: 0x0600919F RID: 37279 RVA: 0x0026FE5C File Offset: 0x0026E05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x0026FE6C File Offset: 0x0026E06C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoIsEvent other)
		{
			return true;
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x0026FE7C File Offset: 0x0026E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x0026FE8C File Offset: 0x0026E08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x0026FE9C File Offset: 0x0026E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x0026FEAC File Offset: 0x0026E0AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x0026FEBC File Offset: 0x0026E0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x0026FECC File Offset: 0x0026E0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoIsEvent other)
		{
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x0026FEDC File Offset: 0x0026E0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060091A8 RID: 37288 RVA: 0x0026FEEC File Offset: 0x0026E0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x0026FEFC File Offset: 0x0026E0FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoIsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						WhoIsEvent._parser = new MessageParser<WhoIsEvent>(() => null);
						num2 = 2;
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_59;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
					}
				}
				IL_59:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x0026FFCC File Offset: 0x0026E1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RWXCfcJ2bYsLSd0WcrdZ()
		{
			return true;
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x0026FFD4 File Offset: 0x0026E1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoIsEvent N6oP6cJ2irKbXqHUTp01()
		{
			return null;
		}

		// Token: 0x04003628 RID: 13864
		private static readonly MessageParser<WhoIsEvent> _parser;

		// Token: 0x04003629 RID: 13865
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400362A RID: 13866
		public const int SelfFieldNumber = 1;

		// Token: 0x0400362B RID: 13867
		private bool self_;

		// Token: 0x0400362C RID: 13868
		public const int PositionFieldNumber = 2;

		// Token: 0x0400362D RID: 13869
		private Hierarchy position_;

		// Token: 0x0400362E RID: 13870
		public const int AccountNameFieldNumber = 3;

		// Token: 0x0400362F RID: 13871
		private string accountName_;

		// Token: 0x04003630 RID: 13872
		public const int AccountTagFieldNumber = 4;

		// Token: 0x04003631 RID: 13873
		private string accountTag_;

		// Token: 0x04003632 RID: 13874
		public const int AccountIdFieldNumber = 5;

		// Token: 0x04003633 RID: 13875
		private long accountId_;

		// Token: 0x04003634 RID: 13876
		public const int CharacterNameFieldNumber = 6;

		// Token: 0x04003635 RID: 13877
		private string characterName_;

		// Token: 0x04003636 RID: 13878
		public const int CharacterIdFieldNumber = 7;

		// Token: 0x04003637 RID: 13879
		private long characterId_;

		// Token: 0x04003638 RID: 13880
		public const int AreaIdFieldNumber = 8;

		// Token: 0x04003639 RID: 13881
		private int areaId_;

		// Token: 0x0400363A RID: 13882
		public const int ServerIdFieldNumber = 9;

		// Token: 0x0400363B RID: 13883
		private int serverId_;

		// Token: 0x0400363C RID: 13884
		public const int OriginServerIdFieldNumber = 10;

		// Token: 0x0400363D RID: 13885
		private int originServerId_;

		// Token: 0x0400363E RID: 13886
		public const int VerboseFieldNumber = 13;

		// Token: 0x0400363F RID: 13887
		private bool verbose_;

		// Token: 0x04003640 RID: 13888
		public const int StateFieldNumber = 14;

		// Token: 0x04003641 RID: 13889
		private CharacterState state_;

		// Token: 0x04003642 RID: 13890
		public const int GuildInformationFieldNumber = 11;

		// Token: 0x04003643 RID: 13891
		private GuildInformation guildInformation_;

		// Token: 0x04003644 RID: 13892
		public const int AllianceInformationFieldNumber = 12;

		// Token: 0x04003645 RID: 13893
		private AllianceInformation allianceInformation_;

		// Token: 0x04003646 RID: 13894
		internal static WhoIsEvent kv3MDpJ2YK1iyqv7No5p;
	}
}
