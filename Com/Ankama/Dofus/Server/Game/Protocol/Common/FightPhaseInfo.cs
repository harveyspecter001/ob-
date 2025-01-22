using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A8D RID: 2701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPhaseInfo : IMessage<FightPhaseInfo>, IMessage, IEquatable<FightPhaseInfo>, IDeepCloneable<FightPhaseInfo>, IBufferMessage
	{
		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x0026098C File Offset: 0x0025EB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightPhaseInfo> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x060080F9 RID: 33017 RVA: 0x0026099C File Offset: 0x0025EB9C
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

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x060080FA RID: 33018 RVA: 0x002609AC File Offset: 0x0025EBAC
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

		// Token: 0x060080FB RID: 33019 RVA: 0x002609BC File Offset: 0x0025EBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPhaseInfo()
		{
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x002609CC File Offset: 0x0025EBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPhaseInfo(FightPhaseInfo other)
		{
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x002609DC File Offset: 0x0025EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPhaseInfo Clone()
		{
			return null;
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x002609EC File Offset: 0x0025EBEC
		// (set) Token: 0x060080FF RID: 33023 RVA: 0x00260A00 File Offset: 0x0025EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightPhaseInfo.Types.FightPhase Phase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightPhaseInfo.Types.FightPhase)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x00260A10 File Offset: 0x0025EC10
		// (set) Token: 0x06008101 RID: 33025 RVA: 0x00260A20 File Offset: 0x0025EC20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PhaseEndTimestamp
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

		// Token: 0x06008102 RID: 33026 RVA: 0x00260A30 File Offset: 0x0025EC30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x00260A40 File Offset: 0x0025EC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPhaseInfo other)
		{
			return true;
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00260A50 File Offset: 0x0025EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00260A60 File Offset: 0x0025EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00260A70 File Offset: 0x0025EC70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00260A80 File Offset: 0x0025EC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x00260A90 File Offset: 0x0025EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x00260AA0 File Offset: 0x0025ECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPhaseInfo other)
		{
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00260AB0 File Offset: 0x0025ECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00260AC0 File Offset: 0x0025ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00260AD0 File Offset: 0x0025ECD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPhaseInfo()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					FightPhaseInfo._parser = new MessageParser<FightPhaseInfo>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00260BB4 File Offset: 0x0025EDB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HdgeJsJgo2PwCWO3RHuM()
		{
			return true;
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00260BBC File Offset: 0x0025EDBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPhaseInfo NnWiyKJg1jqKBUfCnVdb()
		{
			return null;
		}

		// Token: 0x04002EDF RID: 11999
		private static readonly MessageParser<FightPhaseInfo> _parser;

		// Token: 0x04002EE0 RID: 12000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EE1 RID: 12001
		public const int PhaseFieldNumber = 1;

		// Token: 0x04002EE2 RID: 12002
		private FightPhaseInfo.Types.FightPhase phase_;

		// Token: 0x04002EE3 RID: 12003
		public const int PhaseEndTimestampFieldNumber = 2;

		// Token: 0x04002EE4 RID: 12004
		private long phaseEndTimestamp_;

		// Token: 0x04002EE5 RID: 12005
		private static FightPhaseInfo JcOit5JgvqbpxCu9odjP;

		// Token: 0x02000A8E RID: 2702
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600810F RID: 33039 RVA: 0x002E0AC8 File Offset: 0x002DECC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A8F RID: 2703
			public enum FightPhase
			{
				// Token: 0x04002EE7 RID: 12007
				[OriginalName("STARTED")]
				Started,
				// Token: 0x04002EE8 RID: 12008
				[OriginalName("JOINING_PHASE")]
				JoiningPhase,
				// Token: 0x04002EE9 RID: 12009
				[OriginalName("POSITIONING_PHASE")]
				PositioningPhase
			}
		}
	}
}
