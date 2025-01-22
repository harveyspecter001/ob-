using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A85 RID: 2693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NamedPartyTeam : IMessage<NamedPartyTeam>, IMessage, IEquatable<NamedPartyTeam>, IDeepCloneable<NamedPartyTeam>, IBufferMessage
	{
		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x0026024C File Offset: 0x0025E44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NamedPartyTeam> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x060080A0 RID: 32928 RVA: 0x0026025C File Offset: 0x0025E45C
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

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x060080A1 RID: 32929 RVA: 0x0026026C File Offset: 0x0025E46C
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

		// Token: 0x060080A2 RID: 32930 RVA: 0x0026027C File Offset: 0x0025E47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeam()
		{
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x0026028C File Offset: 0x0025E48C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeam(NamedPartyTeam other)
		{
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x0026029C File Offset: 0x0025E49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedPartyTeam Clone()
		{
			return null;
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x002602AC File Offset: 0x0025E4AC
		// (set) Token: 0x060080A6 RID: 32934 RVA: 0x002602C0 File Offset: 0x0025E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x060080A7 RID: 32935 RVA: 0x002602D0 File Offset: 0x0025E4D0
		// (set) Token: 0x060080A8 RID: 32936 RVA: 0x002602E0 File Offset: 0x0025E4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PartyName
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

		// Token: 0x060080A9 RID: 32937 RVA: 0x002602F0 File Offset: 0x0025E4F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x00260300 File Offset: 0x0025E500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NamedPartyTeam other)
		{
			return true;
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00260310 File Offset: 0x0025E510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00260320 File Offset: 0x0025E520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00260330 File Offset: 0x0025E530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00260340 File Offset: 0x0025E540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00260350 File Offset: 0x0025E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00260360 File Offset: 0x0025E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NamedPartyTeam other)
		{
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x00260370 File Offset: 0x0025E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00260380 File Offset: 0x0025E580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x00260390 File Offset: 0x0025E590
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NamedPartyTeam()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					NamedPartyTeam._parser = new MessageParser<NamedPartyTeam>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x00260474 File Offset: 0x0025E674
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RHx1efJg47GtimbWm0No()
		{
			return true;
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x0026047C File Offset: 0x0025E67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NamedPartyTeam GBXA4VJgjskC0QLElRCt()
		{
			return null;
		}

		// Token: 0x04002EB9 RID: 11961
		private static readonly MessageParser<NamedPartyTeam> _parser;

		// Token: 0x04002EBA RID: 11962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBB RID: 11963
		public const int TeamFieldNumber = 1;

		// Token: 0x04002EBC RID: 11964
		private Team team_;

		// Token: 0x04002EBD RID: 11965
		public const int PartyNameFieldNumber = 2;

		// Token: 0x04002EBE RID: 11966
		private string partyName_;

		// Token: 0x04002EBF RID: 11967
		internal static NamedPartyTeam LFeKjrJgxCSd4I3M2rq1;
	}
}
