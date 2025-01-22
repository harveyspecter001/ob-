using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000686 RID: 1670
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnEndEvent : IMessage<FightTurnEndEvent>, IMessage, IEquatable<FightTurnEndEvent>, IDeepCloneable<FightTurnEndEvent>, IBufferMessage
	{
		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x00205FF0 File Offset: 0x002041F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTurnEndEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x00206000 File Offset: 0x00204200
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x00206010 File Offset: 0x00204210
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

		// Token: 0x06005176 RID: 20854 RVA: 0x00206020 File Offset: 0x00204220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEndEvent()
		{
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00206030 File Offset: 0x00204230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEndEvent(FightTurnEndEvent other)
		{
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00206040 File Offset: 0x00204240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEndEvent Clone()
		{
			return null;
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06005179 RID: 20857 RVA: 0x00206050 File Offset: 0x00204250
		// (set) Token: 0x0600517A RID: 20858 RVA: 0x00206060 File Offset: 0x00204260
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

		// Token: 0x0600517B RID: 20859 RVA: 0x00206070 File Offset: 0x00204270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00206080 File Offset: 0x00204280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnEndEvent other)
		{
			return true;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00206090 File Offset: 0x00204290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x002060A0 File Offset: 0x002042A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x002060B0 File Offset: 0x002042B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x002060C0 File Offset: 0x002042C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x002060D0 File Offset: 0x002042D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x002060E0 File Offset: 0x002042E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnEndEvent other)
		{
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x002060F0 File Offset: 0x002042F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00206100 File Offset: 0x00204300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00206110 File Offset: 0x00204310
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnEndEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					FightTurnEndEvent._parser = new MessageParser<FightTurnEndEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x002061DC File Offset: 0x002043DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool njWKD3OP2wINxrwiudd6()
		{
			return true;
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x002061E4 File Offset: 0x002043E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnEndEvent qXukWsOPETUemuugMHDY()
		{
			return null;
		}

		// Token: 0x04001CA1 RID: 7329
		private static readonly MessageParser<FightTurnEndEvent> _parser;

		// Token: 0x04001CA2 RID: 7330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CA3 RID: 7331
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04001CA4 RID: 7332
		private long characterId_;

		// Token: 0x04001CA5 RID: 7333
		private static FightTurnEndEvent Qkt4wjOP9cwh39ROO1ch;
	}
}
