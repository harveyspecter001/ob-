using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000864 RID: 2148
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnIgnoreEvent : IMessage<UnIgnoreEvent>, IMessage, IEquatable<UnIgnoreEvent>, IDeepCloneable<UnIgnoreEvent>, IBufferMessage
	{
		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x0022DF4C File Offset: 0x0022C14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnIgnoreEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x0022DF5C File Offset: 0x0022C15C
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

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x0022DF6C File Offset: 0x0022C16C
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

		// Token: 0x0600686A RID: 26730 RVA: 0x0022DF7C File Offset: 0x0022C17C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreEvent()
		{
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x0022DF8C File Offset: 0x0022C18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreEvent(UnIgnoreEvent other)
		{
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x0022DF9C File Offset: 0x0022C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnIgnoreEvent Clone()
		{
			return null;
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x0022DFAC File Offset: 0x0022C1AC
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x0022DFBC File Offset: 0x0022C1BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UnIgnoreEvent.Types.Error Error
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

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x0022DFCC File Offset: 0x0022C1CC
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x0022DFDC File Offset: 0x0022C1DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UnIgnoreEvent.Types.Success Success
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

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x0022DFEC File Offset: 0x0022C1EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UnIgnoreEvent.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (UnIgnoreEvent.ResultOneofCase)null;
			}
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x0022E000 File Offset: 0x0022C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x0022E010 File Offset: 0x0022C210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x0022E020 File Offset: 0x0022C220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UnIgnoreEvent other)
		{
			return true;
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x0022E030 File Offset: 0x0022C230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x0022E040 File Offset: 0x0022C240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x0022E050 File Offset: 0x0022C250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x0022E060 File Offset: 0x0022C260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x0022E070 File Offset: 0x0022C270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x0022E080 File Offset: 0x0022C280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UnIgnoreEvent other)
		{
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x0022E090 File Offset: 0x0022C290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x0022E0A0 File Offset: 0x0022C2A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x0022E0B0 File Offset: 0x0022C2B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnIgnoreEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UnIgnoreEvent._parser = new MessageParser<UnIgnoreEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x0022E194 File Offset: 0x0022C394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HFQyt7Jn6bAn0TKo4dc7()
		{
			return true;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x0022E19C File Offset: 0x0022C39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UnIgnoreEvent gP5QmqJnLvdCwWtaU02b()
		{
			return null;
		}

		// Token: 0x04002484 RID: 9348
		private static readonly MessageParser<UnIgnoreEvent> _parser;

		// Token: 0x04002485 RID: 9349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002486 RID: 9350
		public const int ErrorFieldNumber = 1;

		// Token: 0x04002487 RID: 9351
		public const int SuccessFieldNumber = 2;

		// Token: 0x04002488 RID: 9352
		private object result_;

		// Token: 0x04002489 RID: 9353
		private UnIgnoreEvent.ResultOneofCase resultCase_;

		// Token: 0x0400248A RID: 9354
		internal static UnIgnoreEvent Wvaon5Jny4WV6D6RZXpy;

		// Token: 0x02000865 RID: 2149
		public enum ResultOneofCase
		{
			// Token: 0x0400248C RID: 9356
			None,
			// Token: 0x0400248D RID: 9357
			Error,
			// Token: 0x0400248E RID: 9358
			Success
		}

		// Token: 0x02000866 RID: 2150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06006880 RID: 26752 RVA: 0x002D6F2C File Offset: 0x002D512C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000867 RID: 2151
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<UnIgnoreEvent.Types.Error>, IMessage, IEquatable<UnIgnoreEvent.Types.Error>, IDeepCloneable<UnIgnoreEvent.Types.Error>, IBufferMessage
			{
				// Token: 0x170012D7 RID: 4823
				// (get) Token: 0x06006881 RID: 26753 RVA: 0x00305888 File Offset: 0x00303A88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<UnIgnoreEvent.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012D8 RID: 4824
				// (get) Token: 0x06006882 RID: 26754 RVA: 0x00305898 File Offset: 0x00303A98
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

				// Token: 0x170012D9 RID: 4825
				// (get) Token: 0x06006883 RID: 26755 RVA: 0x003058A8 File Offset: 0x00303AA8
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

				// Token: 0x06006884 RID: 26756 RVA: 0x003058B8 File Offset: 0x00303AB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x06006885 RID: 26757 RVA: 0x003058C8 File Offset: 0x00303AC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(UnIgnoreEvent.Types.Error other)
				{
				}

				// Token: 0x06006886 RID: 26758 RVA: 0x003058D8 File Offset: 0x00303AD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnIgnoreEvent.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x06006887 RID: 26759 RVA: 0x003058E8 File Offset: 0x00303AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006888 RID: 26760 RVA: 0x003058F8 File Offset: 0x00303AF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(UnIgnoreEvent.Types.Error other)
				{
					return true;
				}

				// Token: 0x06006889 RID: 26761 RVA: 0x00305908 File Offset: 0x00303B08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600688A RID: 26762 RVA: 0x00305918 File Offset: 0x00303B18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600688B RID: 26763 RVA: 0x00305928 File Offset: 0x00303B28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600688C RID: 26764 RVA: 0x00305938 File Offset: 0x00303B38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600688D RID: 26765 RVA: 0x00305948 File Offset: 0x00303B48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600688E RID: 26766 RVA: 0x00305958 File Offset: 0x00303B58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(UnIgnoreEvent.Types.Error other)
				{
				}

				// Token: 0x0600688F RID: 26767 RVA: 0x00305968 File Offset: 0x00303B68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006890 RID: 26768 RVA: 0x00305978 File Offset: 0x00303B78
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006891 RID: 26769 RVA: 0x00305988 File Offset: 0x00303B88
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								return;
							case 4:
								goto IL_87;
							}
							goto Block_1;
						}
						IL_87:
						UnIgnoreEvent.Types.Error._parser = new MessageParser<UnIgnoreEvent.Types.Error>(() => null);
						num = 3;
						continue;
						IL_B0:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 4;
						continue;
						Block_1:
						goto IL_B0;
					}
				}

				// Token: 0x06006892 RID: 26770 RVA: 0x00305A5C File Offset: 0x00303C5C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool VmJo2MGSP1quQ9SRbm7G()
				{
					return true;
				}

				// Token: 0x06006893 RID: 26771 RVA: 0x00305A64 File Offset: 0x00303C64
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static UnIgnoreEvent.Types.Error vcyPp0GSSrDl59qPHupR()
				{
					return null;
				}

				// Token: 0x0400248F RID: 9359
				private static readonly MessageParser<UnIgnoreEvent.Types.Error> _parser;

				// Token: 0x04002490 RID: 9360
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002491 RID: 9361
				private static UnIgnoreEvent.Types.Error vhN4uFGSi5BvSTgjEJyU;
			}

			// Token: 0x02000869 RID: 2153
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<UnIgnoreEvent.Types.Success>, IMessage, IEquatable<UnIgnoreEvent.Types.Success>, IDeepCloneable<UnIgnoreEvent.Types.Success>, IBufferMessage
			{
				// Token: 0x170012DA RID: 4826
				// (get) Token: 0x06006899 RID: 26777 RVA: 0x00305A6C File Offset: 0x00303C6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<UnIgnoreEvent.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012DB RID: 4827
				// (get) Token: 0x0600689A RID: 26778 RVA: 0x00305A7C File Offset: 0x00303C7C
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

				// Token: 0x170012DC RID: 4828
				// (get) Token: 0x0600689B RID: 26779 RVA: 0x00305A8C File Offset: 0x00303C8C
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

				// Token: 0x0600689C RID: 26780 RVA: 0x00305A9C File Offset: 0x00303C9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600689D RID: 26781 RVA: 0x00305AAC File Offset: 0x00303CAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(UnIgnoreEvent.Types.Success other)
				{
				}

				// Token: 0x0600689E RID: 26782 RVA: 0x00305ABC File Offset: 0x00303CBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnIgnoreEvent.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x170012DD RID: 4829
				// (get) Token: 0x0600689F RID: 26783 RVA: 0x00305ACC File Offset: 0x00303CCC
				// (set) Token: 0x060068A0 RID: 26784 RVA: 0x00305ADC File Offset: 0x00303CDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public AccountTag IgnoredTag
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

				// Token: 0x060068A1 RID: 26785 RVA: 0x00305AEC File Offset: 0x00303CEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060068A2 RID: 26786 RVA: 0x00305AFC File Offset: 0x00303CFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(UnIgnoreEvent.Types.Success other)
				{
					return true;
				}

				// Token: 0x060068A3 RID: 26787 RVA: 0x00305B0C File Offset: 0x00303D0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060068A4 RID: 26788 RVA: 0x00305B1C File Offset: 0x00303D1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060068A5 RID: 26789 RVA: 0x00305B2C File Offset: 0x00303D2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060068A6 RID: 26790 RVA: 0x00305B3C File Offset: 0x00303D3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060068A7 RID: 26791 RVA: 0x00305B4C File Offset: 0x00303D4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060068A8 RID: 26792 RVA: 0x00305B5C File Offset: 0x00303D5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(UnIgnoreEvent.Types.Success other)
				{
				}

				// Token: 0x060068A9 RID: 26793 RVA: 0x00305B6C File Offset: 0x00303D6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060068AA RID: 26794 RVA: 0x00305B7C File Offset: 0x00303D7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060068AB RID: 26795 RVA: 0x00305B8C File Offset: 0x00303D8C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							return;
						}
						UnIgnoreEvent.Types.Success._parser = new MessageParser<UnIgnoreEvent.Types.Success>(() => null);
						num2 = 4;
					}
				}

				// Token: 0x060068AC RID: 26796 RVA: 0x00305C58 File Offset: 0x00303E58
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool kRVQ3jGSuOXEsxqsnt4n()
				{
					return true;
				}

				// Token: 0x060068AD RID: 26797 RVA: 0x00305C60 File Offset: 0x00303E60
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static UnIgnoreEvent.Types.Success W2hBkyGS8gWS68OAjJkI()
				{
					return null;
				}

				// Token: 0x04002494 RID: 9364
				private static readonly MessageParser<UnIgnoreEvent.Types.Success> _parser;

				// Token: 0x04002495 RID: 9365
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002496 RID: 9366
				public const int IgnoredTagFieldNumber = 1;

				// Token: 0x04002497 RID: 9367
				private AccountTag ignoredTag_;

				// Token: 0x04002498 RID: 9368
				private static UnIgnoreEvent.Types.Success sBtfYtGSMhiH3INVHl9y;
			}
		}
	}
}
