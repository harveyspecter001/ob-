using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006A3 RID: 1699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightStartingEvent : IMessage<FightStartingEvent>, IMessage, IEquatable<FightStartingEvent>, IDeepCloneable<FightStartingEvent>, IBufferMessage
	{
		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x00208F98 File Offset: 0x00207198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightStartingEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x00208FA8 File Offset: 0x002071A8
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

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x00208FB8 File Offset: 0x002071B8
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

		// Token: 0x060052DD RID: 21213 RVA: 0x00208FC8 File Offset: 0x002071C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingEvent()
		{
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00208FD8 File Offset: 0x002071D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingEvent(FightStartingEvent other)
		{
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00208FE8 File Offset: 0x002071E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartingEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060052E0 RID: 21216 RVA: 0x00208FF8 File Offset: 0x002071F8
		// (set) Token: 0x060052E1 RID: 21217 RVA: 0x0020900C File Offset: 0x0020720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x0020901C File Offset: 0x0020721C
		// (set) Token: 0x060052E3 RID: 21219 RVA: 0x0020902C File Offset: 0x0020722C
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

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x060052E4 RID: 21220 RVA: 0x0020903C File Offset: 0x0020723C
		// (set) Token: 0x060052E5 RID: 21221 RVA: 0x0020904C File Offset: 0x0020724C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AttackerId
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

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x060052E6 RID: 21222 RVA: 0x0020905C File Offset: 0x0020725C
		// (set) Token: 0x060052E7 RID: 21223 RVA: 0x0020906C File Offset: 0x0020726C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long DefenderId
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

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x060052E8 RID: 21224 RVA: 0x0020907C File Offset: 0x0020727C
		// (set) Token: 0x060052E9 RID: 21225 RVA: 0x0020908C File Offset: 0x0020728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContainBoss
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

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x0020909C File Offset: 0x0020729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Monsters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x002090AC File Offset: 0x002072AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x002090BC File Offset: 0x002072BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightStartingEvent other)
		{
			return true;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x002090CC File Offset: 0x002072CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x002090DC File Offset: 0x002072DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x002090EC File Offset: 0x002072EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x002090FC File Offset: 0x002072FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0020910C File Offset: 0x0020730C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0020911C File Offset: 0x0020731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightStartingEvent other)
		{
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0020912C File Offset: 0x0020732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0020913C File Offset: 0x0020733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0020914C File Offset: 0x0020734C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightStartingEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					FightStartingEvent._repeated_monsters_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(50U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					break;
				case 4:
					return;
				case 5:
					FightStartingEvent._parser = new MessageParser<FightStartingEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0020924C File Offset: 0x0020744C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bTK9XvOP8Hyf4BTWgs9A()
		{
			return true;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00209254 File Offset: 0x00207454
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightStartingEvent strL9cOPZgeNEXp1KoxA()
		{
			return null;
		}

		// Token: 0x04001D2B RID: 7467
		private static readonly MessageParser<FightStartingEvent> _parser;

		// Token: 0x04001D2C RID: 7468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D2D RID: 7469
		public const int FightTypeFieldNumber = 1;

		// Token: 0x04001D2E RID: 7470
		private FightType fightType_;

		// Token: 0x04001D2F RID: 7471
		public const int FightIdFieldNumber = 2;

		// Token: 0x04001D30 RID: 7472
		private int fightId_;

		// Token: 0x04001D31 RID: 7473
		public const int AttackerIdFieldNumber = 3;

		// Token: 0x04001D32 RID: 7474
		private long attackerId_;

		// Token: 0x04001D33 RID: 7475
		public const int DefenderIdFieldNumber = 4;

		// Token: 0x04001D34 RID: 7476
		private long defenderId_;

		// Token: 0x04001D35 RID: 7477
		public const int ContainBossFieldNumber = 5;

		// Token: 0x04001D36 RID: 7478
		private bool containBoss_;

		// Token: 0x04001D37 RID: 7479
		public const int MonstersFieldNumber = 6;

		// Token: 0x04001D38 RID: 7480
		private static readonly FieldCodec<int> _repeated_monsters_codec;

		// Token: 0x04001D39 RID: 7481
		private readonly RepeatedField<int> monsters_;

		// Token: 0x04001D3A RID: 7482
		internal static FightStartingEvent K4MDlmOPuKY5lF1AhVUD;
	}
}
