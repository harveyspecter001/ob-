using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000481 RID: 1153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagThemeChangeRequest : IMessage<HavenBagThemeChangeRequest>, IMessage, IEquatable<HavenBagThemeChangeRequest>, IDeepCloneable<HavenBagThemeChangeRequest>, IBufferMessage
	{
		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x001DEF20 File Offset: 0x001DD120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagThemeChangeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x001DEF30 File Offset: 0x001DD130
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

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x001DEF40 File Offset: 0x001DD140
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

		// Token: 0x06003734 RID: 14132 RVA: 0x001DEF50 File Offset: 0x001DD150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagThemeChangeRequest()
		{
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x001DEF60 File Offset: 0x001DD160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagThemeChangeRequest(HavenBagThemeChangeRequest other)
		{
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x001DEF70 File Offset: 0x001DD170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagThemeChangeRequest Clone()
		{
			return null;
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x001DEF80 File Offset: 0x001DD180
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x001DEF90 File Offset: 0x001DD190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Theme
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

		// Token: 0x06003739 RID: 14137 RVA: 0x001DEFA0 File Offset: 0x001DD1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x001DEFB0 File Offset: 0x001DD1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagThemeChangeRequest other)
		{
			return true;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x001DEFD0 File Offset: 0x001DD1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001DEFE0 File Offset: 0x001DD1E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x001DEFF0 File Offset: 0x001DD1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x001DF000 File Offset: 0x001DD200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x001DF010 File Offset: 0x001DD210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagThemeChangeRequest other)
		{
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x001DF020 File Offset: 0x001DD220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x001DF030 File Offset: 0x001DD230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x001DF040 File Offset: 0x001DD240
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagThemeChangeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					HavenBagThemeChangeRequest._parser = new MessageParser<HavenBagThemeChangeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x001DF138 File Offset: 0x001DD338
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RYp0jsOw3NcmJuM1m4Mb()
		{
			return true;
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x001DF140 File Offset: 0x001DD340
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagThemeChangeRequest yUIQVcOwRDiBD5O9LbRK()
		{
			return null;
		}

		// Token: 0x04001358 RID: 4952
		private static readonly MessageParser<HavenBagThemeChangeRequest> _parser;

		// Token: 0x04001359 RID: 4953
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400135A RID: 4954
		public const int ThemeFieldNumber = 1;

		// Token: 0x0400135B RID: 4955
		private int theme_;

		// Token: 0x0400135C RID: 4956
		private static HavenBagThemeChangeRequest KLkFvUOwef5PHnmh7xX6;
	}
}
