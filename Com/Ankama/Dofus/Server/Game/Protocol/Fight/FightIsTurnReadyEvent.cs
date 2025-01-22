using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000682 RID: 1666
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightIsTurnReadyEvent : IMessage<FightIsTurnReadyEvent>, IMessage, IEquatable<FightIsTurnReadyEvent>, IDeepCloneable<FightIsTurnReadyEvent>, IBufferMessage
	{
		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00205BA0 File Offset: 0x00203DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightIsTurnReadyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x00205BB0 File Offset: 0x00203DB0
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x00205BC0 File Offset: 0x00203DC0
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

		// Token: 0x06005143 RID: 20803 RVA: 0x00205BD0 File Offset: 0x00203DD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightIsTurnReadyEvent()
		{
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00205BE0 File Offset: 0x00203DE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightIsTurnReadyEvent(FightIsTurnReadyEvent other)
		{
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00205BF0 File Offset: 0x00203DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightIsTurnReadyEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x00205C00 File Offset: 0x00203E00
		// (set) Token: 0x06005147 RID: 20807 RVA: 0x00205C10 File Offset: 0x00203E10
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

		// Token: 0x06005148 RID: 20808 RVA: 0x00205C20 File Offset: 0x00203E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00205C30 File Offset: 0x00203E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightIsTurnReadyEvent other)
		{
			return true;
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00205C40 File Offset: 0x00203E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00205C50 File Offset: 0x00203E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00205C60 File Offset: 0x00203E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00205C70 File Offset: 0x00203E70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00205C80 File Offset: 0x00203E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00205C90 File Offset: 0x00203E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightIsTurnReadyEvent other)
		{
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00205CA0 File Offset: 0x00203EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00205CB0 File Offset: 0x00203EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x00205CC0 File Offset: 0x00203EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightIsTurnReadyEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					FightIsTurnReadyEvent._parser = new MessageParser<FightIsTurnReadyEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00205DA4 File Offset: 0x00203FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LieO5uOPJWr7JZ3S6tg9()
		{
			return true;
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x00205DAC File Offset: 0x00203FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightIsTurnReadyEvent OlSg9hOPGc410eH7kRBL()
		{
			return null;
		}

		// Token: 0x04001C92 RID: 7314
		private static readonly MessageParser<FightIsTurnReadyEvent> _parser;

		// Token: 0x04001C93 RID: 7315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C94 RID: 7316
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04001C95 RID: 7317
		private long characterId_;

		// Token: 0x04001C96 RID: 7318
		private static FightIsTurnReadyEvent QujJRIOPO089ISrYHigP;
	}
}
