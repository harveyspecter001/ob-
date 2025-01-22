using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000680 RID: 1664
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightRefreshCharacterStatsEvent : IMessage<FightRefreshCharacterStatsEvent>, IMessage, IEquatable<FightRefreshCharacterStatsEvent>, IDeepCloneable<FightRefreshCharacterStatsEvent>, IBufferMessage
	{
		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x0020596C File Offset: 0x00203B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightRefreshCharacterStatsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06005125 RID: 20773 RVA: 0x0020597C File Offset: 0x00203B7C
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x0020598C File Offset: 0x00203B8C
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

		// Token: 0x06005127 RID: 20775 RVA: 0x0020599C File Offset: 0x00203B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRefreshCharacterStatsEvent()
		{
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x002059AC File Offset: 0x00203BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRefreshCharacterStatsEvent(FightRefreshCharacterStatsEvent other)
		{
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x002059BC File Offset: 0x00203BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRefreshCharacterStatsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x002059CC File Offset: 0x00203BCC
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x002059DC File Offset: 0x00203BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long FighterId
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x002059EC File Offset: 0x00203BEC
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x002059FC File Offset: 0x00203BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightCharacteristics Stats
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

		// Token: 0x0600512E RID: 20782 RVA: 0x00205A0C File Offset: 0x00203C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00205A1C File Offset: 0x00203C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightRefreshCharacterStatsEvent other)
		{
			return true;
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00205A2C File Offset: 0x00203C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x00205A3C File Offset: 0x00203C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00205A4C File Offset: 0x00203C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00205A5C File Offset: 0x00203C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x00205A6C File Offset: 0x00203C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x00205A7C File Offset: 0x00203C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightRefreshCharacterStatsEvent other)
		{
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x00205A8C File Offset: 0x00203C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00205A9C File Offset: 0x00203C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x00205AAC File Offset: 0x00203CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightRefreshCharacterStatsEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				FightRefreshCharacterStatsEvent._parser = new MessageParser<FightRefreshCharacterStatsEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00205B90 File Offset: 0x00203D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NWbU62OP3VOEarE4DA5H()
		{
			return true;
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00205B98 File Offset: 0x00203D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightRefreshCharacterStatsEvent MEDivbOPReFujrr2oCR2()
		{
			return null;
		}

		// Token: 0x04001C89 RID: 7305
		private static readonly MessageParser<FightRefreshCharacterStatsEvent> _parser;

		// Token: 0x04001C8A RID: 7306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C8B RID: 7307
		public const int FighterIdFieldNumber = 1;

		// Token: 0x04001C8C RID: 7308
		private long fighterId_;

		// Token: 0x04001C8D RID: 7309
		public const int StatsFieldNumber = 2;

		// Token: 0x04001C8E RID: 7310
		private FightCharacteristics stats_;

		// Token: 0x04001C8F RID: 7311
		internal static FightRefreshCharacterStatsEvent l92ZqwOPe6qS9ElM1gwT;
	}
}
