using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server
{
	// Token: 0x02000165 RID: 357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerSessionConstantsEvent : IMessage<ServerSessionConstantsEvent>, IMessage, IEquatable<ServerSessionConstantsEvent>, IDeepCloneable<ServerSessionConstantsEvent>, IBufferMessage
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0019E6C8 File Offset: 0x0019C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerSessionConstantsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0019E6D8 File Offset: 0x0019C8D8
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0019E6E8 File Offset: 0x0019C8E8
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

		// Token: 0x06001061 RID: 4193 RVA: 0x0019E6F8 File Offset: 0x0019C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionConstantsEvent()
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0019E708 File Offset: 0x0019C908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionConstantsEvent(ServerSessionConstantsEvent other)
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0019E718 File Offset: 0x0019C918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionConstantsEvent Clone()
		{
			return null;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0019E728 File Offset: 0x0019C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ServerSessionConstantsEvent.Types.ServerSessionConstant> Variables
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0019E738 File Offset: 0x0019C938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0019E748 File Offset: 0x0019C948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerSessionConstantsEvent other)
		{
			return true;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0019E758 File Offset: 0x0019C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0019E768 File Offset: 0x0019C968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0019E778 File Offset: 0x0019C978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0019E788 File Offset: 0x0019C988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0019E798 File Offset: 0x0019C998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0019E7A8 File Offset: 0x0019C9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerSessionConstantsEvent other)
		{
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0019E7B8 File Offset: 0x0019C9B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0019E7C8 File Offset: 0x0019C9C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0019E7D8 File Offset: 0x0019C9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerSessionConstantsEvent()
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
						num2 = 5;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						ServerSessionConstantsEvent._repeated_variables_codec = FieldCodec.ForMessage<ServerSessionConstantsEvent.Types.ServerSessionConstant>(10U, AqWxOftS4FfYfS2f3KE.XVInXhlssT(AqWxOftS4FfYfS2f3KE.mYCtMf6IuG));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_C1;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					return;
				}
				IL_C1:
				ServerSessionConstantsEvent._parser = new MessageParser<ServerSessionConstantsEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0019E8E4 File Offset: 0x0019CAE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OH8P8cOUMvNeU6UAlBV6()
		{
			return true;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0019E8EC File Offset: 0x0019CAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerSessionConstantsEvent AVXpmaOUu9GtbgmPZcnW()
		{
			return null;
		}

		// Token: 0x040005FB RID: 1531
		private static readonly MessageParser<ServerSessionConstantsEvent> _parser;

		// Token: 0x040005FC RID: 1532
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005FD RID: 1533
		public const int VariablesFieldNumber = 1;

		// Token: 0x040005FE RID: 1534
		private static readonly FieldCodec<ServerSessionConstantsEvent.Types.ServerSessionConstant> _repeated_variables_codec;

		// Token: 0x040005FF RID: 1535
		private readonly RepeatedField<ServerSessionConstantsEvent.Types.ServerSessionConstant> variables_;

		// Token: 0x04000600 RID: 1536
		private static ServerSessionConstantsEvent meYkJNOUSjoPWGeGE3LD;

		// Token: 0x02000166 RID: 358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001072 RID: 4210 RVA: 0x002AD2A0 File Offset: 0x002AB4A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000167 RID: 359
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ServerSessionConstant : IMessage<ServerSessionConstantsEvent.Types.ServerSessionConstant>, IMessage, IEquatable<ServerSessionConstantsEvent.Types.ServerSessionConstant>, IDeepCloneable<ServerSessionConstantsEvent.Types.ServerSessionConstant>, IBufferMessage
			{
				// Token: 0x170002E9 RID: 745
				// (get) Token: 0x06001073 RID: 4211 RVA: 0x002F78E0 File Offset: 0x002F5AE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ServerSessionConstantsEvent.Types.ServerSessionConstant> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170002EA RID: 746
				// (get) Token: 0x06001074 RID: 4212 RVA: 0x002F78F0 File Offset: 0x002F5AF0
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

				// Token: 0x170002EB RID: 747
				// (get) Token: 0x06001075 RID: 4213 RVA: 0x002F7900 File Offset: 0x002F5B00
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

				// Token: 0x06001076 RID: 4214 RVA: 0x002F7910 File Offset: 0x002F5B10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ServerSessionConstant()
				{
				}

				// Token: 0x06001077 RID: 4215 RVA: 0x002F7920 File Offset: 0x002F5B20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ServerSessionConstant(ServerSessionConstantsEvent.Types.ServerSessionConstant other)
				{
				}

				// Token: 0x06001078 RID: 4216 RVA: 0x002F7930 File Offset: 0x002F5B30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ServerSessionConstantsEvent.Types.ServerSessionConstant Clone()
				{
					return null;
				}

				// Token: 0x170002EC RID: 748
				// (get) Token: 0x06001079 RID: 4217 RVA: 0x002F7940 File Offset: 0x002F5B40
				// (set) Token: 0x0600107A RID: 4218 RVA: 0x002F7950 File Offset: 0x002F5B50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Id
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

				// Token: 0x170002ED RID: 749
				// (get) Token: 0x0600107B RID: 4219 RVA: 0x002F7960 File Offset: 0x002F5B60
				// (set) Token: 0x0600107C RID: 4220 RVA: 0x002F7970 File Offset: 0x002F5B70
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long Value
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

				// Token: 0x0600107D RID: 4221 RVA: 0x002F7980 File Offset: 0x002F5B80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600107E RID: 4222 RVA: 0x002F7990 File Offset: 0x002F5B90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ServerSessionConstantsEvent.Types.ServerSessionConstant other)
				{
					return true;
				}

				// Token: 0x0600107F RID: 4223 RVA: 0x002F79A0 File Offset: 0x002F5BA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001080 RID: 4224 RVA: 0x002F79B0 File Offset: 0x002F5BB0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001081 RID: 4225 RVA: 0x002F79C0 File Offset: 0x002F5BC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001082 RID: 4226 RVA: 0x002F79D0 File Offset: 0x002F5BD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001083 RID: 4227 RVA: 0x002F79E0 File Offset: 0x002F5BE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001084 RID: 4228 RVA: 0x002F79F0 File Offset: 0x002F5BF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ServerSessionConstantsEvent.Types.ServerSessionConstant other)
				{
				}

				// Token: 0x06001085 RID: 4229 RVA: 0x002F7A00 File Offset: 0x002F5C00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001086 RID: 4230 RVA: 0x002F7A10 File Offset: 0x002F5C10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001087 RID: 4231 RVA: 0x002F7A20 File Offset: 0x002F5C20
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ServerSessionConstant()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
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
						ServerSessionConstantsEvent.Types.ServerSessionConstant._parser = new MessageParser<ServerSessionConstantsEvent.Types.ServerSessionConstant>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06001088 RID: 4232 RVA: 0x002F7B04 File Offset: 0x002F5D04
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool e627QUGpXqLrxrO3QNX3()
				{
					return true;
				}

				// Token: 0x06001089 RID: 4233 RVA: 0x002F7B0C File Offset: 0x002F5D0C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ServerSessionConstantsEvent.Types.ServerSessionConstant MkfMqeGpN489l2DqWYMj()
				{
					return null;
				}

				// Token: 0x04000601 RID: 1537
				private static readonly MessageParser<ServerSessionConstantsEvent.Types.ServerSessionConstant> _parser;

				// Token: 0x04000602 RID: 1538
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000603 RID: 1539
				public const int IdFieldNumber = 1;

				// Token: 0x04000604 RID: 1540
				private int id_;

				// Token: 0x04000605 RID: 1541
				public const int ValueFieldNumber = 2;

				// Token: 0x04000606 RID: 1542
				private long value_;

				// Token: 0x04000607 RID: 1543
				private static ServerSessionConstantsEvent.Types.ServerSessionConstant eiNfGRGpEIc8qvg36iJw;
			}
		}
	}
}
