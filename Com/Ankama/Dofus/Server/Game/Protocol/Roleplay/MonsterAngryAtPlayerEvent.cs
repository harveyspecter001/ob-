using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200018A RID: 394
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterAngryAtPlayerEvent : IMessage<MonsterAngryAtPlayerEvent>, IMessage, IEquatable<MonsterAngryAtPlayerEvent>, IDeepCloneable<MonsterAngryAtPlayerEvent>, IBufferMessage
	{
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x001A1C54 File Offset: 0x0019FE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MonsterAngryAtPlayerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x001A1C64 File Offset: 0x0019FE64
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x001A1C74 File Offset: 0x0019FE74
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

		// Token: 0x06001225 RID: 4645 RVA: 0x001A1C84 File Offset: 0x0019FE84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterAngryAtPlayerEvent()
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x001A1C94 File Offset: 0x0019FE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterAngryAtPlayerEvent(MonsterAngryAtPlayerEvent other)
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x001A1CA4 File Offset: 0x0019FEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterAngryAtPlayerEvent Clone()
		{
			return null;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x001A1CB4 File Offset: 0x0019FEB4
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x001A1CC4 File Offset: 0x0019FEC4
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x001A1CD4 File Offset: 0x0019FED4
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x001A1CE4 File Offset: 0x0019FEE4
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x001A1CF4 File Offset: 0x0019FEF4
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x001A1D04 File Offset: 0x0019FF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AngryStartTime
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x001A1D14 File Offset: 0x0019FF14
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x001A1D24 File Offset: 0x0019FF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AttackTime
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

		// Token: 0x06001230 RID: 4656 RVA: 0x001A1D34 File Offset: 0x0019FF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x001A1D44 File Offset: 0x0019FF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonsterAngryAtPlayerEvent other)
		{
			return true;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x001A1D54 File Offset: 0x0019FF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x001A1D64 File Offset: 0x0019FF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x001A1D74 File Offset: 0x0019FF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x001A1D84 File Offset: 0x0019FF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x001A1D94 File Offset: 0x0019FF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x001A1DA4 File Offset: 0x0019FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonsterAngryAtPlayerEvent other)
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x001A1DB4 File Offset: 0x0019FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x001A1DC4 File Offset: 0x0019FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x001A1DD4 File Offset: 0x0019FFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonsterAngryAtPlayerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					MonsterAngryAtPlayerEvent._parser = new MessageParser<MonsterAngryAtPlayerEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x001A1EA0 File Offset: 0x001A00A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rr7PTDOvYYrspClD3jMD()
		{
			return true;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x001A1EA8 File Offset: 0x001A00A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonsterAngryAtPlayerEvent YJEwI0Ovbk2ohPPmBaow()
		{
			return null;
		}

		// Token: 0x0400068D RID: 1677
		private static readonly MessageParser<MonsterAngryAtPlayerEvent> _parser;

		// Token: 0x0400068E RID: 1678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400068F RID: 1679
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04000690 RID: 1680
		private long characterId_;

		// Token: 0x04000691 RID: 1681
		public const int MonsterGroupIdFieldNumber = 2;

		// Token: 0x04000692 RID: 1682
		private long monsterGroupId_;

		// Token: 0x04000693 RID: 1683
		public const int AngryStartTimeFieldNumber = 3;

		// Token: 0x04000694 RID: 1684
		private long angryStartTime_;

		// Token: 0x04000695 RID: 1685
		public const int AttackTimeFieldNumber = 4;

		// Token: 0x04000696 RID: 1686
		private long attackTime_;

		// Token: 0x04000697 RID: 1687
		internal static MonsterAngryAtPlayerEvent sYuVqPOvHECcdWyV60sr;
	}
}
