using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002E8 RID: 744
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyMemberUpdateLightEvent : IMessage<PartyMemberUpdateLightEvent>, IMessage, IEquatable<PartyMemberUpdateLightEvent>, IDeepCloneable<PartyMemberUpdateLightEvent>, IBufferMessage
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x001BCAD0 File Offset: 0x001BACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyMemberUpdateLightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x001BCAE0 File Offset: 0x001BACE0
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x001BCAF0 File Offset: 0x001BACF0
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

		// Token: 0x06002298 RID: 8856 RVA: 0x001BCB00 File Offset: 0x001BAD00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateLightEvent()
		{
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x001BCB10 File Offset: 0x001BAD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateLightEvent(PartyMemberUpdateLightEvent other)
		{
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x001BCB20 File Offset: 0x001BAD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateLightEvent Clone()
		{
			return null;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x001BCB30 File Offset: 0x001BAD30
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x001BCB40 File Offset: 0x001BAD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartyId
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

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x001BCB50 File Offset: 0x001BAD50
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x001BCB60 File Offset: 0x001BAD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x001BCB70 File Offset: 0x001BAD70
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x001BCB80 File Offset: 0x001BAD80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PartyUpdateCommonsInformation CommonsInformation
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

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x001BCB90 File Offset: 0x001BAD90
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x001BCBA0 File Offset: 0x001BADA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Index
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

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x001BCBB0 File Offset: 0x001BADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x001BCBC0 File Offset: 0x001BADC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearIndex()
		{
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x001BCBD0 File Offset: 0x001BADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x001BCBE0 File Offset: 0x001BADE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyMemberUpdateLightEvent other)
		{
			return true;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x001BCBF0 File Offset: 0x001BADF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x001BCC00 File Offset: 0x001BAE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x001BCC10 File Offset: 0x001BAE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x001BCC20 File Offset: 0x001BAE20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x001BCC30 File Offset: 0x001BAE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x001BCC40 File Offset: 0x001BAE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyMemberUpdateLightEvent other)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x001BCC50 File Offset: 0x001BAE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x001BCC60 File Offset: 0x001BAE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x001BCC70 File Offset: 0x001BAE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyMemberUpdateLightEvent()
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
					num2 = 2;
					continue;
				case 2:
					PartyMemberUpdateLightEvent._parser = new MessageParser<PartyMemberUpdateLightEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				PartyMemberUpdateLightEvent.IndexDefaultValue = 0;
				num2 = 3;
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x001BCD50 File Offset: 0x001BAF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u7VKdJOL2iorjVKQ3efB()
		{
			return true;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x001BCD58 File Offset: 0x001BAF58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyMemberUpdateLightEvent tdVJFJOLEn8guPUXhZIk()
		{
			return null;
		}

		// Token: 0x04000C36 RID: 3126
		private static readonly MessageParser<PartyMemberUpdateLightEvent> _parser;

		// Token: 0x04000C37 RID: 3127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C38 RID: 3128
		private int _hasBits0;

		// Token: 0x04000C39 RID: 3129
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C3A RID: 3130
		private int partyId_;

		// Token: 0x04000C3B RID: 3131
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000C3C RID: 3132
		private long playerId_;

		// Token: 0x04000C3D RID: 3133
		public const int CommonsInformationFieldNumber = 3;

		// Token: 0x04000C3E RID: 3134
		private PartyUpdateCommonsInformation commonsInformation_;

		// Token: 0x04000C3F RID: 3135
		public const int IndexFieldNumber = 4;

		// Token: 0x04000C40 RID: 3136
		private static readonly int IndexDefaultValue;

		// Token: 0x04000C41 RID: 3137
		private int index_;

		// Token: 0x04000C42 RID: 3138
		internal static PartyMemberUpdateLightEvent OIsTaHOL9UsC6IO9vN94;
	}
}
