using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000188 RID: 392
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerFightFriendlyAnsweredEvent : IMessage<PlayerFightFriendlyAnsweredEvent>, IMessage, IEquatable<PlayerFightFriendlyAnsweredEvent>, IDeepCloneable<PlayerFightFriendlyAnsweredEvent>, IBufferMessage
	{
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x001A19E0 File Offset: 0x0019FBE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerFightFriendlyAnsweredEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x001A19F0 File Offset: 0x0019FBF0
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x001A1A00 File Offset: 0x0019FC00
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

		// Token: 0x06001205 RID: 4613 RVA: 0x001A1A10 File Offset: 0x0019FC10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnsweredEvent()
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x001A1A20 File Offset: 0x0019FC20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnsweredEvent(PlayerFightFriendlyAnsweredEvent other)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x001A1A30 File Offset: 0x0019FC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyAnsweredEvent Clone()
		{
			return null;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x001A1A40 File Offset: 0x0019FC40
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x001A1A50 File Offset: 0x0019FC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x001A1A60 File Offset: 0x0019FC60
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x001A1A70 File Offset: 0x0019FC70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SourceId
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x001A1A80 File Offset: 0x0019FC80
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x001A1A90 File Offset: 0x0019FC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x001A1AA0 File Offset: 0x0019FCA0
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x001A1AB0 File Offset: 0x0019FCB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accept
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

		// Token: 0x06001210 RID: 4624 RVA: 0x001A1AC0 File Offset: 0x0019FCC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x001A1AD0 File Offset: 0x0019FCD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerFightFriendlyAnsweredEvent other)
		{
			return true;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x001A1AE0 File Offset: 0x0019FCE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x001A1AF0 File Offset: 0x0019FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x001A1B00 File Offset: 0x0019FD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x001A1B10 File Offset: 0x0019FD10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x001A1B20 File Offset: 0x0019FD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x001A1B30 File Offset: 0x0019FD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerFightFriendlyAnsweredEvent other)
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x001A1B40 File Offset: 0x0019FD40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x001A1B50 File Offset: 0x0019FD50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x001A1B60 File Offset: 0x0019FD60
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerFightFriendlyAnsweredEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PlayerFightFriendlyAnsweredEvent._parser = new MessageParser<PlayerFightFriendlyAnsweredEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x001A1C44 File Offset: 0x0019FE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Na4d4kOvTAdVQjUye7SH()
		{
			return true;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x001A1C4C File Offset: 0x0019FE4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerFightFriendlyAnsweredEvent NdoZ68OvpBJuXerbwQWS()
		{
			return null;
		}

		// Token: 0x04000680 RID: 1664
		private static readonly MessageParser<PlayerFightFriendlyAnsweredEvent> _parser;

		// Token: 0x04000681 RID: 1665
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000682 RID: 1666
		public const int FightIdFieldNumber = 1;

		// Token: 0x04000683 RID: 1667
		private int fightId_;

		// Token: 0x04000684 RID: 1668
		public const int SourceIdFieldNumber = 2;

		// Token: 0x04000685 RID: 1669
		private long sourceId_;

		// Token: 0x04000686 RID: 1670
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04000687 RID: 1671
		private long targetId_;

		// Token: 0x04000688 RID: 1672
		public const int AcceptFieldNumber = 4;

		// Token: 0x04000689 RID: 1673
		private bool accept_;

		// Token: 0x0400068A RID: 1674
		internal static PlayerFightFriendlyAnsweredEvent rlSRxrOv7LFJdpx5XZeF;
	}
}
