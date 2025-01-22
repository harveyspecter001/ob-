using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server
{
	// Token: 0x02000163 RID: 355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerSettingsEvent : IMessage<ServerSettingsEvent>, IMessage, IEquatable<ServerSettingsEvent>, IDeepCloneable<ServerSettingsEvent>, IBufferMessage
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0019E3F0 File Offset: 0x0019C5F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ServerSettingsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0019E400 File Offset: 0x0019C600
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0019E410 File Offset: 0x0019C610
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

		// Token: 0x0600103B RID: 4155 RVA: 0x0019E420 File Offset: 0x0019C620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSettingsEvent()
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0019E430 File Offset: 0x0019C630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSettingsEvent(ServerSettingsEvent other)
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0019E440 File Offset: 0x0019C640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSettingsEvent Clone()
		{
			return null;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0019E450 File Offset: 0x0019C650
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x0019E460 File Offset: 0x0019C660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Language
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

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0019E470 File Offset: 0x0019C670
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x0019E480 File Offset: 0x0019C680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Community
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0019E490 File Offset: 0x0019C690
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0019E4A4 File Offset: 0x0019C6A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ServerType GameType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ServerType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0019E4B4 File Offset: 0x0019C6B4
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0019E4C4 File Offset: 0x0019C6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMonoAccount
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0019E4D4 File Offset: 0x0019C6D4
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0019E4E4 File Offset: 0x0019C6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ArenaLeaveBanTime
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0019E4F4 File Offset: 0x0019C6F4
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0019E504 File Offset: 0x0019C704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ItemMaxLevel
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0019E514 File Offset: 0x0019C714
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0019E524 File Offset: 0x0019C724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasFreeAutopilot
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

		// Token: 0x0600104C RID: 4172 RVA: 0x0019E534 File Offset: 0x0019C734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0019E544 File Offset: 0x0019C744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerSettingsEvent other)
		{
			return true;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0019E554 File Offset: 0x0019C754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0019E564 File Offset: 0x0019C764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0019E574 File Offset: 0x0019C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0019E584 File Offset: 0x0019C784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0019E594 File Offset: 0x0019C794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0019E5A4 File Offset: 0x0019C7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerSettingsEvent other)
		{
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0019E5B4 File Offset: 0x0019C7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0019E5C4 File Offset: 0x0019C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0019E5D4 File Offset: 0x0019C7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerSettingsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ServerSettingsEvent._parser = new MessageParser<ServerSettingsEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0019E6B8 File Offset: 0x0019C8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LL75KQOUiph2pSb0uy06()
		{
			return true;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0019E6C0 File Offset: 0x0019C8C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerSettingsEvent fsUcRAOUPWdteXXVZDOP()
		{
			return null;
		}

		// Token: 0x040005E8 RID: 1512
		private static readonly MessageParser<ServerSettingsEvent> _parser;

		// Token: 0x040005E9 RID: 1513
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005EA RID: 1514
		public const int LanguageFieldNumber = 1;

		// Token: 0x040005EB RID: 1515
		private string language_;

		// Token: 0x040005EC RID: 1516
		public const int CommunityFieldNumber = 2;

		// Token: 0x040005ED RID: 1517
		private int community_;

		// Token: 0x040005EE RID: 1518
		public const int GameTypeFieldNumber = 3;

		// Token: 0x040005EF RID: 1519
		private ServerType gameType_;

		// Token: 0x040005F0 RID: 1520
		public const int IsMonoAccountFieldNumber = 4;

		// Token: 0x040005F1 RID: 1521
		private bool isMonoAccount_;

		// Token: 0x040005F2 RID: 1522
		public const int ArenaLeaveBanTimeFieldNumber = 5;

		// Token: 0x040005F3 RID: 1523
		private int arenaLeaveBanTime_;

		// Token: 0x040005F4 RID: 1524
		public const int ItemMaxLevelFieldNumber = 6;

		// Token: 0x040005F5 RID: 1525
		private int itemMaxLevel_;

		// Token: 0x040005F6 RID: 1526
		public const int HasFreeAutopilotFieldNumber = 7;

		// Token: 0x040005F7 RID: 1527
		private bool hasFreeAutopilot_;

		// Token: 0x040005F8 RID: 1528
		private static ServerSettingsEvent ePDhStOUbyYYvv4vVlw1;
	}
}
