using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200018C RID: 396
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterNotAngryAtPlayerEvent : IMessage<MonsterNotAngryAtPlayerEvent>, IMessage, IEquatable<MonsterNotAngryAtPlayerEvent>, IDeepCloneable<MonsterNotAngryAtPlayerEvent>, IBufferMessage
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x001A1EB0 File Offset: 0x001A00B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterNotAngryAtPlayerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x001A1EC0 File Offset: 0x001A00C0
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x001A1ED0 File Offset: 0x001A00D0
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

		// Token: 0x06001245 RID: 4677 RVA: 0x001A1EE0 File Offset: 0x001A00E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterNotAngryAtPlayerEvent()
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x001A1EF0 File Offset: 0x001A00F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterNotAngryAtPlayerEvent(MonsterNotAngryAtPlayerEvent other)
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x001A1F00 File Offset: 0x001A0100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterNotAngryAtPlayerEvent Clone()
		{
			return null;
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x001A1F10 File Offset: 0x001A0110
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x001A1F20 File Offset: 0x001A0120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x001A1F30 File Offset: 0x001A0130
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x001A1F40 File Offset: 0x001A0140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MonsterGroupId
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

		// Token: 0x0600124C RID: 4684 RVA: 0x001A1F50 File Offset: 0x001A0150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x001A1F60 File Offset: 0x001A0160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonsterNotAngryAtPlayerEvent other)
		{
			return true;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x001A1F70 File Offset: 0x001A0170
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x001A1F80 File Offset: 0x001A0180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x001A1F90 File Offset: 0x001A0190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x001A1FA0 File Offset: 0x001A01A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x001A1FB0 File Offset: 0x001A01B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x001A1FC0 File Offset: 0x001A01C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonsterNotAngryAtPlayerEvent other)
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x001A1FD0 File Offset: 0x001A01D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x001A1FE0 File Offset: 0x001A01E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x001A1FF0 File Offset: 0x001A01F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonsterNotAngryAtPlayerEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MonsterNotAngryAtPlayerEvent._parser = new MessageParser<MonsterNotAngryAtPlayerEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x001A20D4 File Offset: 0x001A02D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fera8tOvPV5vovwE1Ilk()
		{
			return true;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x001A20DC File Offset: 0x001A02DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonsterNotAngryAtPlayerEvent JENo0jOvSCkXsP4uFghr()
		{
			return null;
		}

		// Token: 0x0400069A RID: 1690
		private static readonly MessageParser<MonsterNotAngryAtPlayerEvent> _parser;

		// Token: 0x0400069B RID: 1691
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400069C RID: 1692
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400069D RID: 1693
		private long characterId_;

		// Token: 0x0400069E RID: 1694
		public const int MonsterGroupIdFieldNumber = 2;

		// Token: 0x0400069F RID: 1695
		private long monsterGroupId_;

		// Token: 0x040006A0 RID: 1696
		internal static MonsterNotAngryAtPlayerEvent q6vUlPOviGVVorQBojk9;
	}
}
