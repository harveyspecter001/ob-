using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000474 RID: 1140
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseGuildRightsEvent : IMessage<HouseGuildRightsEvent>, IMessage, IEquatable<HouseGuildRightsEvent>, IDeepCloneable<HouseGuildRightsEvent>, IBufferMessage
	{
		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x001DD27C File Offset: 0x001DB47C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseGuildRightsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x001DD28C File Offset: 0x001DB48C
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x001DD29C File Offset: 0x001DB49C
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

		// Token: 0x06003690 RID: 13968 RVA: 0x001DD2AC File Offset: 0x001DB4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsEvent()
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x001DD2BC File Offset: 0x001DB4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsEvent(HouseGuildRightsEvent other)
		{
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x001DD2CC File Offset: 0x001DB4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseGuildRightsEvent Clone()
		{
			return null;
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x001DD2DC File Offset: 0x001DB4DC
		// (set) Token: 0x06003694 RID: 13972 RVA: 0x001DD2EC File Offset: 0x001DB4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HouseId
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x001DD2FC File Offset: 0x001DB4FC
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x001DD30C File Offset: 0x001DB50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x001DD31C File Offset: 0x001DB51C
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x001DD32C File Offset: 0x001DB52C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool SecondHand
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x001DD33C File Offset: 0x001DB53C
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x001DD34C File Offset: 0x001DB54C
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x001DD35C File Offset: 0x001DB55C
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x001DD36C File Offset: 0x001DB56C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Rights
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x001DD37C File Offset: 0x001DB57C
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x001DD38C File Offset: 0x001DB58C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsLocked
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

		// Token: 0x0600369F RID: 13983 RVA: 0x001DD39C File Offset: 0x001DB59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001DD3AC File Offset: 0x001DB5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseGuildRightsEvent other)
		{
			return true;
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x001DD3BC File Offset: 0x001DB5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x001DD3CC File Offset: 0x001DB5CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x001DD3DC File Offset: 0x001DB5DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x001DD3EC File Offset: 0x001DB5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x001DD3FC File Offset: 0x001DB5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x001DD40C File Offset: 0x001DB60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseGuildRightsEvent other)
		{
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x001DD41C File Offset: 0x001DB61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x001DD42C File Offset: 0x001DB62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x001DD43C File Offset: 0x001DB63C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseGuildRightsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					HouseGuildRightsEvent._parser = new MessageParser<HouseGuildRightsEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x001DD520 File Offset: 0x001DB720
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t7o9KTOtTaEbbDfnMOMs()
		{
			return true;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x001DD528 File Offset: 0x001DB728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseGuildRightsEvent mykWHhOtpLFqInoj65aN()
		{
			return null;
		}

		// Token: 0x04001328 RID: 4904
		private static readonly MessageParser<HouseGuildRightsEvent> _parser;

		// Token: 0x04001329 RID: 4905
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400132A RID: 4906
		public const int HouseIdFieldNumber = 1;

		// Token: 0x0400132B RID: 4907
		private int houseId_;

		// Token: 0x0400132C RID: 4908
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x0400132D RID: 4909
		private int instanceId_;

		// Token: 0x0400132E RID: 4910
		public const int SecondHandFieldNumber = 3;

		// Token: 0x0400132F RID: 4911
		private bool secondHand_;

		// Token: 0x04001330 RID: 4912
		public const int GuildInformationFieldNumber = 4;

		// Token: 0x04001331 RID: 4913
		private GuildInformation guildInformation_;

		// Token: 0x04001332 RID: 4914
		public const int RightsFieldNumber = 5;

		// Token: 0x04001333 RID: 4915
		private int rights_;

		// Token: 0x04001334 RID: 4916
		public const int IsLockedFieldNumber = 6;

		// Token: 0x04001335 RID: 4917
		private bool isLocked_;

		// Token: 0x04001336 RID: 4918
		internal static HouseGuildRightsEvent AAMKbNOt73OduaDElbAM;
	}
}
