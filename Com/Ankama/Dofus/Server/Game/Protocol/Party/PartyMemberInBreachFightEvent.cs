using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002FC RID: 764
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyMemberInBreachFightEvent : IMessage<PartyMemberInBreachFightEvent>, IMessage, IEquatable<PartyMemberInBreachFightEvent>, IDeepCloneable<PartyMemberInBreachFightEvent>, IBufferMessage
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x001BE208 File Offset: 0x001BC408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyMemberInBreachFightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x001BE218 File Offset: 0x001BC418
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x001BE228 File Offset: 0x001BC428
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

		// Token: 0x060023C6 RID: 9158 RVA: 0x001BE238 File Offset: 0x001BC438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInBreachFightEvent()
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x001BE248 File Offset: 0x001BC448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInBreachFightEvent(PartyMemberInBreachFightEvent other)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x001BE258 File Offset: 0x001BC458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInBreachFightEvent Clone()
		{
			return null;
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x001BE268 File Offset: 0x001BC468
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x001BE278 File Offset: 0x001BC478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x001BE288 File Offset: 0x001BC488
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x001BE29C File Offset: 0x001BC49C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PartyMemberInFightCause Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PartyMemberInFightCause)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x001BE2AC File Offset: 0x001BC4AC
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x001BE2BC File Offset: 0x001BC4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MemberId
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x001BE2CC File Offset: 0x001BC4CC
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x001BE2DC File Offset: 0x001BC4DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MemberAccountId
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x001BE2EC File Offset: 0x001BC4EC
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x001BE2FC File Offset: 0x001BC4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MemberName
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x001BE30C File Offset: 0x001BC50C
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x001BE31C File Offset: 0x001BC51C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x001BE32C File Offset: 0x001BC52C
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x001BE33C File Offset: 0x001BC53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeBeforeFightStart
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x001BE34C File Offset: 0x001BC54C
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x001BE35C File Offset: 0x001BC55C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Floor
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

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x001BE36C File Offset: 0x001BC56C
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x001BE37C File Offset: 0x001BC57C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Room
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

		// Token: 0x060023DB RID: 9179 RVA: 0x001BE38C File Offset: 0x001BC58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x001BE39C File Offset: 0x001BC59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyMemberInBreachFightEvent other)
		{
			return true;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x001BE3AC File Offset: 0x001BC5AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x001BE3BC File Offset: 0x001BC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x001BE3CC File Offset: 0x001BC5CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x001BE3DC File Offset: 0x001BC5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x001BE3EC File Offset: 0x001BC5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x001BE3FC File Offset: 0x001BC5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyMemberInBreachFightEvent other)
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x001BE40C File Offset: 0x001BC60C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x001BE41C File Offset: 0x001BC61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x001BE42C File Offset: 0x001BC62C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyMemberInBreachFightEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					PartyMemberInBreachFightEvent._parser = new MessageParser<PartyMemberInBreachFightEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x001BE510 File Offset: 0x001BC710
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NAX9o1OLQjg2b7L9gAOs()
		{
			return true;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x001BE518 File Offset: 0x001BC718
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyMemberInBreachFightEvent XQfLKQOL7hG6fqPqrj6E()
		{
			return null;
		}

		// Token: 0x04000CA6 RID: 3238
		private static readonly MessageParser<PartyMemberInBreachFightEvent> _parser;

		// Token: 0x04000CA7 RID: 3239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CA8 RID: 3240
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000CA9 RID: 3241
		private int partyId_;

		// Token: 0x04000CAA RID: 3242
		public const int ReasonFieldNumber = 2;

		// Token: 0x04000CAB RID: 3243
		private PartyMemberInFightCause reason_;

		// Token: 0x04000CAC RID: 3244
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04000CAD RID: 3245
		private long memberId_;

		// Token: 0x04000CAE RID: 3246
		public const int MemberAccountIdFieldNumber = 4;

		// Token: 0x04000CAF RID: 3247
		private long memberAccountId_;

		// Token: 0x04000CB0 RID: 3248
		public const int MemberNameFieldNumber = 5;

		// Token: 0x04000CB1 RID: 3249
		private string memberName_;

		// Token: 0x04000CB2 RID: 3250
		public const int FightIdFieldNumber = 6;

		// Token: 0x04000CB3 RID: 3251
		private int fightId_;

		// Token: 0x04000CB4 RID: 3252
		public const int TimeBeforeFightStartFieldNumber = 7;

		// Token: 0x04000CB5 RID: 3253
		private int timeBeforeFightStart_;

		// Token: 0x04000CB6 RID: 3254
		public const int FloorFieldNumber = 8;

		// Token: 0x04000CB7 RID: 3255
		private int floor_;

		// Token: 0x04000CB8 RID: 3256
		public const int RoomFieldNumber = 9;

		// Token: 0x04000CB9 RID: 3257
		private int room_;

		// Token: 0x04000CBA RID: 3258
		internal static PartyMemberInBreachFightEvent oZx3TCOLwjw8uUw5WCdt;
	}
}
