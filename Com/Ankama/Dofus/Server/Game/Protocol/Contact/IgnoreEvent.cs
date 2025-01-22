using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200085C RID: 2140
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IgnoreEvent : IMessage<IgnoreEvent>, IMessage, IEquatable<IgnoreEvent>, IDeepCloneable<IgnoreEvent>, IBufferMessage
	{
		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x0022DCF4 File Offset: 0x0022BEF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IgnoreEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x0022DD04 File Offset: 0x0022BF04
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

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06006816 RID: 26646 RVA: 0x0022DD14 File Offset: 0x0022BF14
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

		// Token: 0x06006817 RID: 26647 RVA: 0x0022DD24 File Offset: 0x0022BF24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreEvent()
		{
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x0022DD34 File Offset: 0x0022BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreEvent(IgnoreEvent other)
		{
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x0022DD44 File Offset: 0x0022BF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreEvent Clone()
		{
			return null;
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x0022DD54 File Offset: 0x0022BF54
		// (set) Token: 0x0600681B RID: 26651 RVA: 0x0022DD64 File Offset: 0x0022BF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IgnoreEvent.Types.Error Error
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

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x0022DD74 File Offset: 0x0022BF74
		// (set) Token: 0x0600681D RID: 26653 RVA: 0x0022DD84 File Offset: 0x0022BF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IgnoreEvent.Types.Success Success
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

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600681E RID: 26654 RVA: 0x0022DD94 File Offset: 0x0022BF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IgnoreEvent.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (IgnoreEvent.ResultOneofCase)null;
			}
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x0022DDA8 File Offset: 0x0022BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x0022DDB8 File Offset: 0x0022BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x0022DDC8 File Offset: 0x0022BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IgnoreEvent other)
		{
			return true;
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x0022DDD8 File Offset: 0x0022BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x0022DDE8 File Offset: 0x0022BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x0022DDF8 File Offset: 0x0022BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x0022DE08 File Offset: 0x0022C008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x0022DE18 File Offset: 0x0022C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x0022DE28 File Offset: 0x0022C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(IgnoreEvent other)
		{
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x0022DE38 File Offset: 0x0022C038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x0022DE48 File Offset: 0x0022C048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x0022DE58 File Offset: 0x0022C058
		[MethodImpl(MethodImplOptions.NoInlining)]
		static IgnoreEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					IgnoreEvent._parser = new MessageParser<IgnoreEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x0022DF3C File Offset: 0x0022C13C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nrUrEWJnaWvl5BOAXEd6()
		{
			return true;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x0022DF44 File Offset: 0x0022C144
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IgnoreEvent j5XxHSJn5lRG0ZQtdHga()
		{
			return null;
		}

		// Token: 0x04002469 RID: 9321
		private static readonly MessageParser<IgnoreEvent> _parser;

		// Token: 0x0400246A RID: 9322
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400246B RID: 9323
		public const int ErrorFieldNumber = 1;

		// Token: 0x0400246C RID: 9324
		public const int SuccessFieldNumber = 2;

		// Token: 0x0400246D RID: 9325
		private object result_;

		// Token: 0x0400246E RID: 9326
		private IgnoreEvent.ResultOneofCase resultCase_;

		// Token: 0x0400246F RID: 9327
		private static IgnoreEvent kJlZkWJn1v75ZUIsJyLD;

		// Token: 0x0200085D RID: 2141
		public enum ResultOneofCase
		{
			// Token: 0x04002471 RID: 9329
			None,
			// Token: 0x04002472 RID: 9330
			Error,
			// Token: 0x04002473 RID: 9331
			Success
		}

		// Token: 0x0200085E RID: 2142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600682D RID: 26669 RVA: 0x002D6E1C File Offset: 0x002D501C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200085F RID: 2143
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<IgnoreEvent.Types.Error>, IMessage, IEquatable<IgnoreEvent.Types.Error>, IDeepCloneable<IgnoreEvent.Types.Error>, IBufferMessage
			{
				// Token: 0x170012C9 RID: 4809
				// (get) Token: 0x0600682E RID: 26670 RVA: 0x00305474 File Offset: 0x00303674
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<IgnoreEvent.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012CA RID: 4810
				// (get) Token: 0x0600682F RID: 26671 RVA: 0x00305484 File Offset: 0x00303684
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

				// Token: 0x170012CB RID: 4811
				// (get) Token: 0x06006830 RID: 26672 RVA: 0x00305494 File Offset: 0x00303694
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

				// Token: 0x06006831 RID: 26673 RVA: 0x003054A4 File Offset: 0x003036A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x06006832 RID: 26674 RVA: 0x003054B4 File Offset: 0x003036B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(IgnoreEvent.Types.Error other)
				{
				}

				// Token: 0x06006833 RID: 26675 RVA: 0x003054C4 File Offset: 0x003036C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public IgnoreEvent.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x170012CC RID: 4812
				// (get) Token: 0x06006834 RID: 26676 RVA: 0x003054D4 File Offset: 0x003036D4
				// (set) Token: 0x06006835 RID: 26677 RVA: 0x003054E8 File Offset: 0x003036E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public AddFailureReason Reason
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (AddFailureReason)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06006836 RID: 26678 RVA: 0x003054F8 File Offset: 0x003036F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006837 RID: 26679 RVA: 0x00305508 File Offset: 0x00303708
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(IgnoreEvent.Types.Error other)
				{
					return true;
				}

				// Token: 0x06006838 RID: 26680 RVA: 0x00305518 File Offset: 0x00303718
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006839 RID: 26681 RVA: 0x00305528 File Offset: 0x00303728
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600683A RID: 26682 RVA: 0x00305538 File Offset: 0x00303738
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600683B RID: 26683 RVA: 0x00305548 File Offset: 0x00303748
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600683C RID: 26684 RVA: 0x00305558 File Offset: 0x00303758
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600683D RID: 26685 RVA: 0x00305568 File Offset: 0x00303768
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(IgnoreEvent.Types.Error other)
				{
				}

				// Token: 0x0600683E RID: 26686 RVA: 0x00305578 File Offset: 0x00303778
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600683F RID: 26687 RVA: 0x00305588 File Offset: 0x00303788
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006840 RID: 26688 RVA: 0x00305598 File Offset: 0x00303798
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							IgnoreEvent.Types.Error._parser = new MessageParser<IgnoreEvent.Types.Error>(() => null);
							num2 = 3;
							continue;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
					}
				}

				// Token: 0x06006841 RID: 26689 RVA: 0x00305664 File Offset: 0x00303864
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool w5khgEGSTQEL5Km1sM6M()
				{
					return true;
				}

				// Token: 0x06006842 RID: 26690 RVA: 0x0030566C File Offset: 0x0030386C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static IgnoreEvent.Types.Error XvIRCOGSpkBmMBi5Bxsu()
				{
					return null;
				}

				// Token: 0x04002474 RID: 9332
				private static readonly MessageParser<IgnoreEvent.Types.Error> _parser;

				// Token: 0x04002475 RID: 9333
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002476 RID: 9334
				public const int ReasonFieldNumber = 1;

				// Token: 0x04002477 RID: 9335
				private AddFailureReason reason_;

				// Token: 0x04002478 RID: 9336
				private static IgnoreEvent.Types.Error Uttc25GS7PbXoN4x6tcH;
			}

			// Token: 0x02000861 RID: 2145
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<IgnoreEvent.Types.Success>, IMessage, IEquatable<IgnoreEvent.Types.Success>, IDeepCloneable<IgnoreEvent.Types.Success>, IBufferMessage
			{
				// Token: 0x170012CD RID: 4813
				// (get) Token: 0x06006848 RID: 26696 RVA: 0x00305674 File Offset: 0x00303874
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<IgnoreEvent.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012CE RID: 4814
				// (get) Token: 0x06006849 RID: 26697 RVA: 0x00305684 File Offset: 0x00303884
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

				// Token: 0x170012CF RID: 4815
				// (get) Token: 0x0600684A RID: 26698 RVA: 0x00305694 File Offset: 0x00303894
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

				// Token: 0x0600684B RID: 26699 RVA: 0x003056A4 File Offset: 0x003038A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600684C RID: 26700 RVA: 0x003056B4 File Offset: 0x003038B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(IgnoreEvent.Types.Success other)
				{
				}

				// Token: 0x0600684D RID: 26701 RVA: 0x003056C4 File Offset: 0x003038C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public IgnoreEvent.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x170012D0 RID: 4816
				// (get) Token: 0x0600684E RID: 26702 RVA: 0x003056D4 File Offset: 0x003038D4
				// (set) Token: 0x0600684F RID: 26703 RVA: 0x003056E4 File Offset: 0x003038E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ContactInformation Ignored
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

				// Token: 0x06006850 RID: 26704 RVA: 0x003056F4 File Offset: 0x003038F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006851 RID: 26705 RVA: 0x00305704 File Offset: 0x00303904
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(IgnoreEvent.Types.Success other)
				{
					return true;
				}

				// Token: 0x06006852 RID: 26706 RVA: 0x00305714 File Offset: 0x00303914
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006853 RID: 26707 RVA: 0x00305724 File Offset: 0x00303924
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006854 RID: 26708 RVA: 0x00305734 File Offset: 0x00303934
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006855 RID: 26709 RVA: 0x00305744 File Offset: 0x00303944
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006856 RID: 26710 RVA: 0x00305754 File Offset: 0x00303954
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006857 RID: 26711 RVA: 0x00305764 File Offset: 0x00303964
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(IgnoreEvent.Types.Success other)
				{
				}

				// Token: 0x06006858 RID: 26712 RVA: 0x00305774 File Offset: 0x00303974
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006859 RID: 26713 RVA: 0x00305784 File Offset: 0x00303984
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600685A RID: 26714 RVA: 0x00305794 File Offset: 0x00303994
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
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
							IgnoreEvent.Types.Success._parser = new MessageParser<IgnoreEvent.Types.Success>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
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
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x0600685B RID: 26715 RVA: 0x00305878 File Offset: 0x00303A78
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool w6N527GSYpRVpDeIMP8F()
				{
					return true;
				}

				// Token: 0x0600685C RID: 26716 RVA: 0x00305880 File Offset: 0x00303A80
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static IgnoreEvent.Types.Success LT2dJXGSb1QIdbFfpjBN()
				{
					return null;
				}

				// Token: 0x0400247B RID: 9339
				private static readonly MessageParser<IgnoreEvent.Types.Success> _parser;

				// Token: 0x0400247C RID: 9340
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400247D RID: 9341
				public const int IgnoredFieldNumber = 1;

				// Token: 0x0400247E RID: 9342
				private ContactInformation ignored_;

				// Token: 0x0400247F RID: 9343
				private static IgnoreEvent.Types.Success VeL7XMGSHS9OuE5bFLgi;
			}
		}
	}
}
