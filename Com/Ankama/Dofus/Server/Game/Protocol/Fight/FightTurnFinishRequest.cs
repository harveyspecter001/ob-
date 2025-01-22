using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200063F RID: 1599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnFinishRequest : IMessage<FightTurnFinishRequest>, IMessage, IEquatable<FightTurnFinishRequest>, IDeepCloneable<FightTurnFinishRequest>, IBufferMessage
	{
		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x002031CC File Offset: 0x002013CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTurnFinishRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06004D80 RID: 19840 RVA: 0x002031DC File Offset: 0x002013DC
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06004D81 RID: 19841 RVA: 0x002031EC File Offset: 0x002013EC
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

		// Token: 0x06004D82 RID: 19842 RVA: 0x002031FC File Offset: 0x002013FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnFinishRequest()
		{
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x0020320C File Offset: 0x0020140C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnFinishRequest(FightTurnFinishRequest other)
		{
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x0020321C File Offset: 0x0020141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnFinishRequest Clone()
		{
			return null;
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06004D85 RID: 19845 RVA: 0x0020322C File Offset: 0x0020142C
		// (set) Token: 0x06004D86 RID: 19846 RVA: 0x0020323C File Offset: 0x0020143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAfk
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

		// Token: 0x06004D87 RID: 19847 RVA: 0x0020324C File Offset: 0x0020144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x0020325C File Offset: 0x0020145C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnFinishRequest other)
		{
			return true;
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x0020326C File Offset: 0x0020146C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x0020327C File Offset: 0x0020147C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x0020328C File Offset: 0x0020148C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x0020329C File Offset: 0x0020149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x002032AC File Offset: 0x002014AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x002032BC File Offset: 0x002014BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnFinishRequest other)
		{
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x002032CC File Offset: 0x002014CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x002032DC File Offset: 0x002014DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x002032EC File Offset: 0x002014EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnFinishRequest()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FightTurnFinishRequest._parser = new MessageParser<FightTurnFinishRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x002033D0 File Offset: 0x002015D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WNVGRdOi4gvYdEwHQ3KO()
		{
			return true;
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x002033D8 File Offset: 0x002015D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnFinishRequest YZQq7dOijYaEYXwkDEpY()
		{
			return null;
		}

		// Token: 0x04001B0A RID: 6922
		private static readonly MessageParser<FightTurnFinishRequest> _parser;

		// Token: 0x04001B0B RID: 6923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B0C RID: 6924
		public const int IsAfkFieldNumber = 1;

		// Token: 0x04001B0D RID: 6925
		private bool isAfk_;

		// Token: 0x04001B0E RID: 6926
		internal static FightTurnFinishRequest OYYvEHOixi0uFmxRpIIw;
	}
}
