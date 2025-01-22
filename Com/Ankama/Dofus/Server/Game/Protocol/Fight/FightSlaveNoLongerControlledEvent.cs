using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200067E RID: 1662
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSlaveNoLongerControlledEvent : IMessage<FightSlaveNoLongerControlledEvent>, IMessage, IEquatable<FightSlaveNoLongerControlledEvent>, IDeepCloneable<FightSlaveNoLongerControlledEvent>, IBufferMessage
	{
		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00205738 File Offset: 0x00203938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightSlaveNoLongerControlledEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x00205748 File Offset: 0x00203948
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00205758 File Offset: 0x00203958
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

		// Token: 0x0600510B RID: 20747 RVA: 0x00205768 File Offset: 0x00203968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveNoLongerControlledEvent()
		{
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00205778 File Offset: 0x00203978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveNoLongerControlledEvent(FightSlaveNoLongerControlledEvent other)
		{
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00205788 File Offset: 0x00203988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveNoLongerControlledEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x00205798 File Offset: 0x00203998
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x002057A8 File Offset: 0x002039A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MasterId
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

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x002057B8 File Offset: 0x002039B8
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x002057C8 File Offset: 0x002039C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SlaveId
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

		// Token: 0x06005112 RID: 20754 RVA: 0x002057D8 File Offset: 0x002039D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x002057E8 File Offset: 0x002039E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSlaveNoLongerControlledEvent other)
		{
			return true;
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x002057F8 File Offset: 0x002039F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00205808 File Offset: 0x00203A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00205818 File Offset: 0x00203A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00205828 File Offset: 0x00203A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00205838 File Offset: 0x00203A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00205848 File Offset: 0x00203A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSlaveNoLongerControlledEvent other)
		{
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00205858 File Offset: 0x00203A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00205868 File Offset: 0x00203A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00205878 File Offset: 0x00203A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSlaveNoLongerControlledEvent()
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
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FightSlaveNoLongerControlledEvent._parser = new MessageParser<FightSlaveNoLongerControlledEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x0020595C File Offset: 0x00203B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uBqh96OPAvGyf0PdSerl()
		{
			return true;
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00205964 File Offset: 0x00203B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSlaveNoLongerControlledEvent eAubIMOPBT4asrC91kUl()
		{
			return null;
		}

		// Token: 0x04001C80 RID: 7296
		private static readonly MessageParser<FightSlaveNoLongerControlledEvent> _parser;

		// Token: 0x04001C81 RID: 7297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C82 RID: 7298
		public const int MasterIdFieldNumber = 1;

		// Token: 0x04001C83 RID: 7299
		private long masterId_;

		// Token: 0x04001C84 RID: 7300
		public const int SlaveIdFieldNumber = 2;

		// Token: 0x04001C85 RID: 7301
		private long slaveId_;

		// Token: 0x04001C86 RID: 7302
		private static FightSlaveNoLongerControlledEvent Min9ArOPm188OMNoIR7g;
	}
}
