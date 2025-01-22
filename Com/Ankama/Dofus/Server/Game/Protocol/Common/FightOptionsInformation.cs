using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A91 RID: 2705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightOptionsInformation : IMessage<FightOptionsInformation>, IMessage, IEquatable<FightOptionsInformation>, IDeepCloneable<FightOptionsInformation>, IBufferMessage
	{
		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06008115 RID: 33045 RVA: 0x00260BC4 File Offset: 0x0025EDC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightOptionsInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x00260BD4 File Offset: 0x0025EDD4
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

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x00260BE4 File Offset: 0x0025EDE4
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

		// Token: 0x06008118 RID: 33048 RVA: 0x00260BF4 File Offset: 0x0025EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionsInformation()
		{
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x00260C04 File Offset: 0x0025EE04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionsInformation(FightOptionsInformation other)
		{
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x00260C14 File Offset: 0x0025EE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionsInformation Clone()
		{
			return null;
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600811B RID: 33051 RVA: 0x00260C24 File Offset: 0x0025EE24
		// (set) Token: 0x0600811C RID: 33052 RVA: 0x00260C34 File Offset: 0x0025EE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSecret
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

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600811D RID: 33053 RVA: 0x00260C44 File Offset: 0x0025EE44
		// (set) Token: 0x0600811E RID: 33054 RVA: 0x00260C54 File Offset: 0x0025EE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRestrictedToParty
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

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600811F RID: 33055 RVA: 0x00260C64 File Offset: 0x0025EE64
		// (set) Token: 0x06008120 RID: 33056 RVA: 0x00260C74 File Offset: 0x0025EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsClosed
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

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06008121 RID: 33057 RVA: 0x00260C84 File Offset: 0x0025EE84
		// (set) Token: 0x06008122 RID: 33058 RVA: 0x00260C94 File Offset: 0x0025EE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsAskingForHelp
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

		// Token: 0x06008123 RID: 33059 RVA: 0x00260CA4 File Offset: 0x0025EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00260CB4 File Offset: 0x0025EEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightOptionsInformation other)
		{
			return true;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00260CC4 File Offset: 0x0025EEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00260CD4 File Offset: 0x0025EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00260CE4 File Offset: 0x0025EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00260CF4 File Offset: 0x0025EEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00260D04 File Offset: 0x0025EF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00260D14 File Offset: 0x0025EF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightOptionsInformation other)
		{
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00260D24 File Offset: 0x0025EF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00260D34 File Offset: 0x0025EF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00260D44 File Offset: 0x0025EF44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightOptionsInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightOptionsInformation._parser = new MessageParser<FightOptionsInformation>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00260E3C File Offset: 0x0025F03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gATN6IJg5scVtMpLGwMU()
		{
			return true;
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00260E44 File Offset: 0x0025F044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightOptionsInformation konJdxJgypAEMGpP0Re8()
		{
			return null;
		}

		// Token: 0x04002EEC RID: 12012
		private static readonly MessageParser<FightOptionsInformation> _parser;

		// Token: 0x04002EED RID: 12013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EEE RID: 12014
		public const int IsSecretFieldNumber = 1;

		// Token: 0x04002EEF RID: 12015
		private bool isSecret_;

		// Token: 0x04002EF0 RID: 12016
		public const int IsRestrictedToPartyFieldNumber = 2;

		// Token: 0x04002EF1 RID: 12017
		private bool isRestrictedToParty_;

		// Token: 0x04002EF2 RID: 12018
		public const int IsClosedFieldNumber = 3;

		// Token: 0x04002EF3 RID: 12019
		private bool isClosed_;

		// Token: 0x04002EF4 RID: 12020
		public const int IsAskingForHelpFieldNumber = 4;

		// Token: 0x04002EF5 RID: 12021
		private bool isAskingForHelp_;

		// Token: 0x04002EF6 RID: 12022
		private static FightOptionsInformation fOA9caJgaIjoFM1jGkr5;
	}
}
