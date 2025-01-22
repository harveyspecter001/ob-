using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001B0 RID: 432
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStartedEvent : IMessage<QuestStartedEvent>, IMessage, IEquatable<QuestStartedEvent>, IDeepCloneable<QuestStartedEvent>, IBufferMessage
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x001A5310 File Offset: 0x001A3510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x001A5320 File Offset: 0x001A3520
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x001A5330 File Offset: 0x001A3530
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

		// Token: 0x0600141E RID: 5150 RVA: 0x001A5340 File Offset: 0x001A3540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartedEvent()
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x001A5350 File Offset: 0x001A3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartedEvent(QuestStartedEvent other)
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x001A5360 File Offset: 0x001A3560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x001A5370 File Offset: 0x001A3570
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x001A5380 File Offset: 0x001A3580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
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

		// Token: 0x06001423 RID: 5155 RVA: 0x001A5390 File Offset: 0x001A3590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x001A53A0 File Offset: 0x001A35A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStartedEvent other)
		{
			return true;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x001A53B0 File Offset: 0x001A35B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x001A53C0 File Offset: 0x001A35C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x001A53D0 File Offset: 0x001A35D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x001A53E0 File Offset: 0x001A35E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x001A53F0 File Offset: 0x001A35F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x001A5400 File Offset: 0x001A3600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStartedEvent other)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x001A5410 File Offset: 0x001A3610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x001A5420 File Offset: 0x001A3620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x001A5430 File Offset: 0x001A3630
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					QuestStartedEvent._parser = new MessageParser<QuestStartedEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x001A54FC File Offset: 0x001A36FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H41qTsOoD6Zn7TJrrr3t()
		{
			return true;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x001A5504 File Offset: 0x001A3704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStartedEvent HY8bbrOotCPGyi8fnQ8H()
		{
			return null;
		}

		// Token: 0x04000735 RID: 1845
		private static readonly MessageParser<QuestStartedEvent> _parser;

		// Token: 0x04000736 RID: 1846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000737 RID: 1847
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000738 RID: 1848
		private int questId_;

		// Token: 0x04000739 RID: 1849
		internal static QuestStartedEvent DZopr1OoCdBowIydThp0;
	}
}
