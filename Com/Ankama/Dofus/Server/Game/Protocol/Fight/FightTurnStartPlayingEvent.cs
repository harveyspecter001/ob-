using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000673 RID: 1651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnStartPlayingEvent : IMessage<FightTurnStartPlayingEvent>, IMessage, IEquatable<FightTurnStartPlayingEvent>, IDeepCloneable<FightTurnStartPlayingEvent>, IBufferMessage
	{
		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x00204E48 File Offset: 0x00203048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTurnStartPlayingEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x00204E58 File Offset: 0x00203058
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x00204E68 File Offset: 0x00203068
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

		// Token: 0x06005081 RID: 20609 RVA: 0x00204E78 File Offset: 0x00203078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnStartPlayingEvent()
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00204E88 File Offset: 0x00203088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnStartPlayingEvent(FightTurnStartPlayingEvent other)
		{
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00204E98 File Offset: 0x00203098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnStartPlayingEvent Clone()
		{
			return null;
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00204EA8 File Offset: 0x002030A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00204EB8 File Offset: 0x002030B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnStartPlayingEvent other)
		{
			return true;
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00204EC8 File Offset: 0x002030C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00204ED8 File Offset: 0x002030D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00204EE8 File Offset: 0x002030E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00204EF8 File Offset: 0x002030F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00204F08 File Offset: 0x00203108
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00204F18 File Offset: 0x00203118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnStartPlayingEvent other)
		{
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00204F28 File Offset: 0x00203128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00204F38 File Offset: 0x00203138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00204F48 File Offset: 0x00203148
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnStartPlayingEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					FightTurnStartPlayingEvent._parser = new MessageParser<FightTurnStartPlayingEvent>(() => null);
					num2 = 2;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00205014 File Offset: 0x00203214
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YtyrdBOiPH3uP250maIE()
		{
			return true;
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x0020501C File Offset: 0x0020321C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnStartPlayingEvent TC0WyCOiSi38B6gH5Fkk()
		{
			return null;
		}

		// Token: 0x04001C50 RID: 7248
		private static readonly MessageParser<FightTurnStartPlayingEvent> _parser;

		// Token: 0x04001C51 RID: 7249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C52 RID: 7250
		internal static FightTurnStartPlayingEvent RE6QpcOiiR4cApmshJwT;
	}
}
