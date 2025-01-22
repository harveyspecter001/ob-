using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000656 RID: 1622
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BaseStatistics : IMessage<BaseStatistics>, IMessage, IEquatable<BaseStatistics>, IDeepCloneable<BaseStatistics>, IBufferMessage
	{
		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004EA7 RID: 20135 RVA: 0x00203EC0 File Offset: 0x002020C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BaseStatistics> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x00203ED0 File Offset: 0x002020D0
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

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x00203EE0 File Offset: 0x002020E0
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

		// Token: 0x06004EAA RID: 20138 RVA: 0x00203EF0 File Offset: 0x002020F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseStatistics()
		{
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00203F00 File Offset: 0x00202100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseStatistics(BaseStatistics other)
		{
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00203F10 File Offset: 0x00202110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseStatistics Clone()
		{
			return null;
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x00203F20 File Offset: 0x00202120
		// (set) Token: 0x06004EAE RID: 20142 RVA: 0x00203F30 File Offset: 0x00202130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DamageDone
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

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x00203F40 File Offset: 0x00202140
		// (set) Token: 0x06004EB0 RID: 20144 RVA: 0x00203F50 File Offset: 0x00202150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DamageTaken
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

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x00203F60 File Offset: 0x00202160
		// (set) Token: 0x06004EB2 RID: 20146 RVA: 0x00203F70 File Offset: 0x00202170
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BlockedDamage
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x00203F80 File Offset: 0x00202180
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x00203F90 File Offset: 0x00202190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AppliedShield
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

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x00203FA0 File Offset: 0x002021A0
		// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x00203FB0 File Offset: 0x002021B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HealDone
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

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x00203FC0 File Offset: 0x002021C0
		// (set) Token: 0x06004EB8 RID: 20152 RVA: 0x00203FD0 File Offset: 0x002021D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HealTaken
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

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x00203FE0 File Offset: 0x002021E0
		// (set) Token: 0x06004EBA RID: 20154 RVA: 0x00203FF0 File Offset: 0x002021F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int KillCount
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

		// Token: 0x06004EBB RID: 20155 RVA: 0x00204000 File Offset: 0x00202200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00204010 File Offset: 0x00202210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BaseStatistics other)
		{
			return true;
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00204020 File Offset: 0x00202220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00204030 File Offset: 0x00202230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00204040 File Offset: 0x00202240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00204050 File Offset: 0x00202250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00204060 File Offset: 0x00202260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00204070 File Offset: 0x00202270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BaseStatistics other)
		{
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x00204080 File Offset: 0x00202280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00204090 File Offset: 0x00202290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x002040A0 File Offset: 0x002022A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BaseStatistics()
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
						BaseStatistics._parser = new MessageParser<BaseStatistics>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 3:
						goto IL_88;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_88:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x00204188 File Offset: 0x00202388
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wTmm4UOiLIsrck1Lbdgk()
		{
			return true;
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00204190 File Offset: 0x00202390
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BaseStatistics onc8k0OiW63sfYVYvZy5()
		{
			return null;
		}

		// Token: 0x04001B80 RID: 7040
		private static readonly MessageParser<BaseStatistics> _parser;

		// Token: 0x04001B81 RID: 7041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B82 RID: 7042
		public const int DamageDoneFieldNumber = 1;

		// Token: 0x04001B83 RID: 7043
		private int damageDone_;

		// Token: 0x04001B84 RID: 7044
		public const int DamageTakenFieldNumber = 2;

		// Token: 0x04001B85 RID: 7045
		private int damageTaken_;

		// Token: 0x04001B86 RID: 7046
		public const int BlockedDamageFieldNumber = 3;

		// Token: 0x04001B87 RID: 7047
		private int blockedDamage_;

		// Token: 0x04001B88 RID: 7048
		public const int AppliedShieldFieldNumber = 4;

		// Token: 0x04001B89 RID: 7049
		private int appliedShield_;

		// Token: 0x04001B8A RID: 7050
		public const int HealDoneFieldNumber = 5;

		// Token: 0x04001B8B RID: 7051
		private int healDone_;

		// Token: 0x04001B8C RID: 7052
		public const int HealTakenFieldNumber = 6;

		// Token: 0x04001B8D RID: 7053
		private int healTaken_;

		// Token: 0x04001B8E RID: 7054
		public const int KillCountFieldNumber = 7;

		// Token: 0x04001B8F RID: 7055
		private int killCount_;

		// Token: 0x04001B90 RID: 7056
		private static BaseStatistics rmxmnfOi6gwdnvrdD15W;
	}
}
