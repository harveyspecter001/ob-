using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006C4 RID: 1732
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeSetCraftRecipeRequest : IMessage<ExchangeSetCraftRecipeRequest>, IMessage, IEquatable<ExchangeSetCraftRecipeRequest>, IDeepCloneable<ExchangeSetCraftRecipeRequest>, IBufferMessage
	{
		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x00211690 File Offset: 0x0020F890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeSetCraftRecipeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x002116A0 File Offset: 0x0020F8A0
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

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x002116B0 File Offset: 0x0020F8B0
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

		// Token: 0x060054AA RID: 21674 RVA: 0x002116C0 File Offset: 0x0020F8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSetCraftRecipeRequest()
		{
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x002116D0 File Offset: 0x0020F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSetCraftRecipeRequest(ExchangeSetCraftRecipeRequest other)
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x002116E0 File Offset: 0x0020F8E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSetCraftRecipeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060054AD RID: 21677 RVA: 0x002116F0 File Offset: 0x0020F8F0
		// (set) Token: 0x060054AE RID: 21678 RVA: 0x00211700 File Offset: 0x0020F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x060054AF RID: 21679 RVA: 0x00211710 File Offset: 0x0020F910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00211720 File Offset: 0x0020F920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeSetCraftRecipeRequest other)
		{
			return true;
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00211730 File Offset: 0x0020F930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00211740 File Offset: 0x0020F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00211750 File Offset: 0x0020F950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00211760 File Offset: 0x0020F960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00211770 File Offset: 0x0020F970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00211780 File Offset: 0x0020F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeSetCraftRecipeRequest other)
		{
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00211790 File Offset: 0x0020F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x002117A0 File Offset: 0x0020F9A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x002117B0 File Offset: 0x0020F9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeSetCraftRecipeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						ExchangeSetCraftRecipeRequest._parser = new MessageParser<ExchangeSetCraftRecipeRequest>(() => null);
						num2 = 4;
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_59:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				goto IL_59;
			}
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00211880 File Offset: 0x0020FA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wpaPTFOS7qCwOHIASvru()
		{
			return true;
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00211888 File Offset: 0x0020FA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeSetCraftRecipeRequest hMCDApOSTM14gXXpJerm()
		{
			return null;
		}

		// Token: 0x04001DCC RID: 7628
		private static readonly MessageParser<ExchangeSetCraftRecipeRequest> _parser;

		// Token: 0x04001DCD RID: 7629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DCE RID: 7630
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DCF RID: 7631
		private int objectUid_;

		// Token: 0x04001DD0 RID: 7632
		internal static ExchangeSetCraftRecipeRequest xqA3VUOSQaHbiavNJvai;
	}
}
