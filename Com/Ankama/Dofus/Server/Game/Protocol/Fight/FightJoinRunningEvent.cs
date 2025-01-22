using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000641 RID: 1601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightJoinRunningEvent : IMessage<FightJoinRunningEvent>, IMessage, IEquatable<FightJoinRunningEvent>, IDeepCloneable<FightJoinRunningEvent>, IBufferMessage
	{
		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06004D99 RID: 19865 RVA: 0x002033E0 File Offset: 0x002015E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightJoinRunningEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x002033F0 File Offset: 0x002015F0
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

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x00203400 File Offset: 0x00201600
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

		// Token: 0x06004D9C RID: 19868 RVA: 0x00203410 File Offset: 0x00201610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRunningEvent()
		{
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00203420 File Offset: 0x00201620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRunningEvent(FightJoinRunningEvent other)
		{
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00203430 File Offset: 0x00201630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRunningEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x00203440 File Offset: 0x00201640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRemovableEffectExtendedInformation> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x00203450 File Offset: 0x00201650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightMark> Marks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x00203460 File Offset: 0x00201660
		// (set) Token: 0x06004DA2 RID: 19874 RVA: 0x00203470 File Offset: 0x00201670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GameTurn
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x00203480 File Offset: 0x00201680
		// (set) Token: 0x06004DA4 RID: 19876 RVA: 0x00203490 File Offset: 0x00201690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightStart
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x002034A0 File Offset: 0x002016A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightEffectTriggerCount> FxTriggerCounts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x002034B0 File Offset: 0x002016B0
		// (set) Token: 0x06004DA7 RID: 19879 RVA: 0x002034C0 File Offset: 0x002016C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightResume Resume
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

		// Token: 0x06004DA8 RID: 19880 RVA: 0x002034D0 File Offset: 0x002016D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x002034E0 File Offset: 0x002016E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightJoinRunningEvent other)
		{
			return true;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x002034F0 File Offset: 0x002016F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00203500 File Offset: 0x00201700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00203510 File Offset: 0x00201710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00203520 File Offset: 0x00201720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00203530 File Offset: 0x00201730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00203540 File Offset: 0x00201740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightJoinRunningEvent other)
		{
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00203550 File Offset: 0x00201750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00203560 File Offset: 0x00201760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00203570 File Offset: 0x00201770
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightJoinRunningEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_6A;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						FightJoinRunningEvent._repeated_effects_codec = FieldCodec.ForMessage<FightRemovableEffectExtendedInformation>(10U, URYgQmmZO8kxQLvmqhrb.XVInXhlssT(URYgQmmZO8kxQLvmqhrb.sLemZJPyxfp));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						return;
					case 6:
						FightJoinRunningEvent._repeated_fxTriggerCounts_codec = FieldCodec.ForMessage<FightEffectTriggerCount>(42U, eFvHcEmZscgfEmFlSybU.XVInXhlssT(eFvHcEmZscgfEmFlSybU.n27mZdJrS0E));
						num2 = 5;
						continue;
					case 7:
						FightJoinRunningEvent._parser = new MessageParser<FightJoinRunningEvent>(() => null);
						num2 = 4;
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 7;
				}
				IL_6A:
				FightJoinRunningEvent._repeated_marks_codec = FieldCodec.ForMessage<FightMark>(18U, K7VgvCmZGfJq20FPbBwF.XVInXhlssT(K7VgvCmZGfJq20FPbBwF.pymmZgjhQ2F));
				num = 6;
			}
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x002036AC File Offset: 0x002018AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qs8XW0OiIu7HyXu9Mggs()
		{
			return true;
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x002036B4 File Offset: 0x002018B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightJoinRunningEvent OOUwxYOikSl2MpH79ukd()
		{
			return null;
		}

		// Token: 0x04001B11 RID: 6929
		private static readonly MessageParser<FightJoinRunningEvent> _parser;

		// Token: 0x04001B12 RID: 6930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B13 RID: 6931
		public const int EffectsFieldNumber = 1;

		// Token: 0x04001B14 RID: 6932
		private static readonly FieldCodec<FightRemovableEffectExtendedInformation> _repeated_effects_codec;

		// Token: 0x04001B15 RID: 6933
		private readonly RepeatedField<FightRemovableEffectExtendedInformation> effects_;

		// Token: 0x04001B16 RID: 6934
		public const int MarksFieldNumber = 2;

		// Token: 0x04001B17 RID: 6935
		private static readonly FieldCodec<FightMark> _repeated_marks_codec;

		// Token: 0x04001B18 RID: 6936
		private readonly RepeatedField<FightMark> marks_;

		// Token: 0x04001B19 RID: 6937
		public const int GameTurnFieldNumber = 3;

		// Token: 0x04001B1A RID: 6938
		private int gameTurn_;

		// Token: 0x04001B1B RID: 6939
		public const int FightStartFieldNumber = 4;

		// Token: 0x04001B1C RID: 6940
		private int fightStart_;

		// Token: 0x04001B1D RID: 6941
		public const int FxTriggerCountsFieldNumber = 5;

		// Token: 0x04001B1E RID: 6942
		private static readonly FieldCodec<FightEffectTriggerCount> _repeated_fxTriggerCounts_codec;

		// Token: 0x04001B1F RID: 6943
		private readonly RepeatedField<FightEffectTriggerCount> fxTriggerCounts_;

		// Token: 0x04001B20 RID: 6944
		public const int ResumeFieldNumber = 6;

		// Token: 0x04001B21 RID: 6945
		private FightResume resume_;

		// Token: 0x04001B22 RID: 6946
		internal static FightJoinRunningEvent LAbOGZOiKD2jjK1n80bQ;
	}
}
