using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200086E RID: 2158
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BlockEvent : IMessage<BlockEvent>, IMessage, IEquatable<BlockEvent>, IDeepCloneable<BlockEvent>, IBufferMessage
	{
		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x0022E3D0 File Offset: 0x0022C5D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BlockEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x0022E3E0 File Offset: 0x0022C5E0
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

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x0022E3F0 File Offset: 0x0022C5F0
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

		// Token: 0x060068D4 RID: 26836 RVA: 0x0022E400 File Offset: 0x0022C600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockEvent()
		{
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x0022E410 File Offset: 0x0022C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockEvent(BlockEvent other)
		{
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x0022E420 File Offset: 0x0022C620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockEvent Clone()
		{
			return null;
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060068D7 RID: 26839 RVA: 0x0022E430 File Offset: 0x0022C630
		// (set) Token: 0x060068D8 RID: 26840 RVA: 0x0022E440 File Offset: 0x0022C640
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BlockEvent.Types.Error Error
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

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060068D9 RID: 26841 RVA: 0x0022E450 File Offset: 0x0022C650
		// (set) Token: 0x060068DA RID: 26842 RVA: 0x0022E460 File Offset: 0x0022C660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BlockEvent.Types.Success Success
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060068DB RID: 26843 RVA: 0x0022E470 File Offset: 0x0022C670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlockEvent.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BlockEvent.ResultOneofCase)null;
			}
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x0022E484 File Offset: 0x0022C684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x0022E494 File Offset: 0x0022C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x0022E4A4 File Offset: 0x0022C6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BlockEvent other)
		{
			return true;
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x0022E4B4 File Offset: 0x0022C6B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x0022E4C4 File Offset: 0x0022C6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x0022E4D4 File Offset: 0x0022C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x0022E4E4 File Offset: 0x0022C6E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x0022E4F4 File Offset: 0x0022C6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x0022E504 File Offset: 0x0022C704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BlockEvent other)
		{
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x0022E514 File Offset: 0x0022C714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x0022E524 File Offset: 0x0022C724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x0022E534 File Offset: 0x0022C734
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockEvent()
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
					default:
						goto IL_35;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						BlockEvent._parser = new MessageParser<BlockEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x0022E61C File Offset: 0x0022C81C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mXnZZ8Jn0onUWvtJar37()
		{
			return true;
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x0022E624 File Offset: 0x0022C824
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BlockEvent b4gIW0JnCH0SFDuOT4oM()
		{
			return null;
		}

		// Token: 0x040024A5 RID: 9381
		private static readonly MessageParser<BlockEvent> _parser;

		// Token: 0x040024A6 RID: 9382
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024A7 RID: 9383
		public const int ErrorFieldNumber = 1;

		// Token: 0x040024A8 RID: 9384
		public const int SuccessFieldNumber = 2;

		// Token: 0x040024A9 RID: 9385
		private object result_;

		// Token: 0x040024AA RID: 9386
		private BlockEvent.ResultOneofCase resultCase_;

		// Token: 0x040024AB RID: 9387
		private static BlockEvent MDy8H3JnVECnPnrLvJcj;

		// Token: 0x0200086F RID: 2159
		public enum ResultOneofCase
		{
			// Token: 0x040024AD RID: 9389
			None,
			// Token: 0x040024AE RID: 9390
			Error,
			// Token: 0x040024AF RID: 9391
			Success
		}

		// Token: 0x02000870 RID: 2160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060068EA RID: 26858 RVA: 0x002D7150 File Offset: 0x002D5350
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000871 RID: 2161
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<BlockEvent.Types.Error>, IMessage, IEquatable<BlockEvent.Types.Error>, IDeepCloneable<BlockEvent.Types.Error>, IBufferMessage
			{
				// Token: 0x170012E8 RID: 4840
				// (get) Token: 0x060068EB RID: 26859 RVA: 0x00305C68 File Offset: 0x00303E68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<BlockEvent.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012E9 RID: 4841
				// (get) Token: 0x060068EC RID: 26860 RVA: 0x00305C78 File Offset: 0x00303E78
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

				// Token: 0x170012EA RID: 4842
				// (get) Token: 0x060068ED RID: 26861 RVA: 0x00305C88 File Offset: 0x00303E88
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

				// Token: 0x060068EE RID: 26862 RVA: 0x00305C98 File Offset: 0x00303E98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x060068EF RID: 26863 RVA: 0x00305CA8 File Offset: 0x00303EA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(BlockEvent.Types.Error other)
				{
				}

				// Token: 0x060068F0 RID: 26864 RVA: 0x00305CB8 File Offset: 0x00303EB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BlockEvent.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x170012EB RID: 4843
				// (get) Token: 0x060068F1 RID: 26865 RVA: 0x00305CC8 File Offset: 0x00303EC8
				// (set) Token: 0x060068F2 RID: 26866 RVA: 0x00305CDC File Offset: 0x00303EDC
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

				// Token: 0x060068F3 RID: 26867 RVA: 0x00305CEC File Offset: 0x00303EEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060068F4 RID: 26868 RVA: 0x00305CFC File Offset: 0x00303EFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(BlockEvent.Types.Error other)
				{
					return true;
				}

				// Token: 0x060068F5 RID: 26869 RVA: 0x00305D0C File Offset: 0x00303F0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060068F6 RID: 26870 RVA: 0x00305D1C File Offset: 0x00303F1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060068F7 RID: 26871 RVA: 0x00305D2C File Offset: 0x00303F2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060068F8 RID: 26872 RVA: 0x00305D3C File Offset: 0x00303F3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060068F9 RID: 26873 RVA: 0x00305D4C File Offset: 0x00303F4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060068FA RID: 26874 RVA: 0x00305D5C File Offset: 0x00303F5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(BlockEvent.Types.Error other)
				{
				}

				// Token: 0x060068FB RID: 26875 RVA: 0x00305D6C File Offset: 0x00303F6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060068FC RID: 26876 RVA: 0x00305D7C File Offset: 0x00303F7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060068FD RID: 26877 RVA: 0x00305D8C File Offset: 0x00303F8C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							BlockEvent.Types.Error._parser = new MessageParser<BlockEvent.Types.Error>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x060068FE RID: 26878 RVA: 0x00305E70 File Offset: 0x00304070
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool W8kDyuGSqRyqTtZYB5Oh()
				{
					return true;
				}

				// Token: 0x060068FF RID: 26879 RVA: 0x00305E78 File Offset: 0x00304078
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static BlockEvent.Types.Error TeA7vSGSFh1B1kl9ahkL()
				{
					return null;
				}

				// Token: 0x040024B0 RID: 9392
				private static readonly MessageParser<BlockEvent.Types.Error> _parser;

				// Token: 0x040024B1 RID: 9393
				private UnknownFieldSet _unknownFields;

				// Token: 0x040024B2 RID: 9394
				public const int ReasonFieldNumber = 1;

				// Token: 0x040024B3 RID: 9395
				private AddFailureReason reason_;

				// Token: 0x040024B4 RID: 9396
				internal static BlockEvent.Types.Error W8c62UGSZj52QIJ4fVTC;
			}

			// Token: 0x02000873 RID: 2163
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<BlockEvent.Types.Success>, IMessage, IEquatable<BlockEvent.Types.Success>, IDeepCloneable<BlockEvent.Types.Success>, IBufferMessage
			{
				// Token: 0x170012EC RID: 4844
				// (get) Token: 0x06006905 RID: 26885 RVA: 0x00305E80 File Offset: 0x00304080
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<BlockEvent.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012ED RID: 4845
				// (get) Token: 0x06006906 RID: 26886 RVA: 0x00305E90 File Offset: 0x00304090
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

				// Token: 0x170012EE RID: 4846
				// (get) Token: 0x06006907 RID: 26887 RVA: 0x00305EA0 File Offset: 0x003040A0
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

				// Token: 0x06006908 RID: 26888 RVA: 0x00305EB0 File Offset: 0x003040B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x06006909 RID: 26889 RVA: 0x00305EC0 File Offset: 0x003040C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(BlockEvent.Types.Success other)
				{
				}

				// Token: 0x0600690A RID: 26890 RVA: 0x00305ED0 File Offset: 0x003040D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BlockEvent.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x170012EF RID: 4847
				// (get) Token: 0x0600690B RID: 26891 RVA: 0x00305EE0 File Offset: 0x003040E0
				// (set) Token: 0x0600690C RID: 26892 RVA: 0x00305EF0 File Offset: 0x003040F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ContactInformation Blocked
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

				// Token: 0x0600690D RID: 26893 RVA: 0x00305F00 File Offset: 0x00304100
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600690E RID: 26894 RVA: 0x00305F10 File Offset: 0x00304110
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(BlockEvent.Types.Success other)
				{
					return true;
				}

				// Token: 0x0600690F RID: 26895 RVA: 0x00305F20 File Offset: 0x00304120
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006910 RID: 26896 RVA: 0x00305F30 File Offset: 0x00304130
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006911 RID: 26897 RVA: 0x00305F40 File Offset: 0x00304140
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006912 RID: 26898 RVA: 0x00305F50 File Offset: 0x00304150
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006913 RID: 26899 RVA: 0x00305F60 File Offset: 0x00304160
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006914 RID: 26900 RVA: 0x00305F70 File Offset: 0x00304170
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(BlockEvent.Types.Success other)
				{
				}

				// Token: 0x06006915 RID: 26901 RVA: 0x00305F80 File Offset: 0x00304180
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006916 RID: 26902 RVA: 0x00305F90 File Offset: 0x00304190
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006917 RID: 26903 RVA: 0x00305FA0 File Offset: 0x003041A0
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
							BlockEvent.Types.Success._parser = new MessageParser<BlockEvent.Types.Success>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
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
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06006918 RID: 26904 RVA: 0x00306084 File Offset: 0x00304284
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool bJeUyEGMfPuPPU5oWVxH()
				{
					return true;
				}

				// Token: 0x06006919 RID: 26905 RVA: 0x0030608C File Offset: 0x0030428C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static BlockEvent.Types.Success iwNfsiGMnlUxHvX4dYm8()
				{
					return null;
				}

				// Token: 0x040024B7 RID: 9399
				private static readonly MessageParser<BlockEvent.Types.Success> _parser;

				// Token: 0x040024B8 RID: 9400
				private UnknownFieldSet _unknownFields;

				// Token: 0x040024B9 RID: 9401
				public const int BlockedFieldNumber = 1;

				// Token: 0x040024BA RID: 9402
				private ContactInformation blocked_;

				// Token: 0x040024BB RID: 9403
				private static BlockEvent.Types.Success H31906GSzm3OhFWpiStx;
			}
		}
	}
}
