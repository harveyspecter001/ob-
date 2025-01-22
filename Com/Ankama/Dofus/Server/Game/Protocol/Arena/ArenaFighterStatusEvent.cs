using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C18 RID: 3096
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaFighterStatusEvent : IMessage<ArenaFighterStatusEvent>, IMessage, IEquatable<ArenaFighterStatusEvent>, IDeepCloneable<ArenaFighterStatusEvent>, IBufferMessage
	{
		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060094B5 RID: 38069 RVA: 0x00276874 File Offset: 0x00274A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaFighterStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060094B6 RID: 38070 RVA: 0x00276884 File Offset: 0x00274A84
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060094B7 RID: 38071 RVA: 0x00276894 File Offset: 0x00274A94
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

		// Token: 0x060094B8 RID: 38072 RVA: 0x002768A4 File Offset: 0x00274AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterStatusEvent()
		{
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x002768B4 File Offset: 0x00274AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterStatusEvent(ArenaFighterStatusEvent other)
		{
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x002768C4 File Offset: 0x00274AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaFighterStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060094BB RID: 38075 RVA: 0x002768D4 File Offset: 0x00274AD4
		// (set) Token: 0x060094BC RID: 38076 RVA: 0x002768E4 File Offset: 0x00274AE4
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060094BD RID: 38077 RVA: 0x002768F4 File Offset: 0x00274AF4
		// (set) Token: 0x060094BE RID: 38078 RVA: 0x00276904 File Offset: 0x00274B04
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060094BF RID: 38079 RVA: 0x00276914 File Offset: 0x00274B14
		// (set) Token: 0x060094C0 RID: 38080 RVA: 0x00276924 File Offset: 0x00274B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accepted
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

		// Token: 0x060094C1 RID: 38081 RVA: 0x00276934 File Offset: 0x00274B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00276944 File Offset: 0x00274B44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaFighterStatusEvent other)
		{
			return true;
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x00276954 File Offset: 0x00274B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x00276964 File Offset: 0x00274B64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00276974 File Offset: 0x00274B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x00276984 File Offset: 0x00274B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x00276994 File Offset: 0x00274B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x002769A4 File Offset: 0x00274BA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaFighterStatusEvent other)
		{
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x002769B4 File Offset: 0x00274BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x002769C4 File Offset: 0x00274BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x002769D4 File Offset: 0x00274BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaFighterStatusEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ArenaFighterStatusEvent._parser = new MessageParser<ArenaFighterStatusEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00276AB8 File Offset: 0x00274CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XmbRugJXcrHGMH4DEBjc()
		{
			return true;
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x00276AC0 File Offset: 0x00274CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaFighterStatusEvent uJUWVwJXU94b2xJgn6Va()
		{
			return null;
		}

		// Token: 0x0400375B RID: 14171
		private static readonly MessageParser<ArenaFighterStatusEvent> _parser;

		// Token: 0x0400375C RID: 14172
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400375D RID: 14173
		public const int FightIdFieldNumber = 1;

		// Token: 0x0400375E RID: 14174
		private int fightId_;

		// Token: 0x0400375F RID: 14175
		public const int CharacterIdFieldNumber = 2;

		// Token: 0x04003760 RID: 14176
		private long characterId_;

		// Token: 0x04003761 RID: 14177
		public const int AcceptedFieldNumber = 3;

		// Token: 0x04003762 RID: 14178
		private bool accepted_;

		// Token: 0x04003763 RID: 14179
		private static ArenaFighterStatusEvent GKOg2IJXl87Uoig4uhak;
	}
}
