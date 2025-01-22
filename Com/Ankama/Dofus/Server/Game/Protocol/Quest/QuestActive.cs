using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001BE RID: 446
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestActive : IMessage<QuestActive>, IMessage, IEquatable<QuestActive>, IDeepCloneable<QuestActive>, IBufferMessage
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x001A6204 File Offset: 0x001A4404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QuestActive> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x001A6214 File Offset: 0x001A4414
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x001A6224 File Offset: 0x001A4424
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

		// Token: 0x060014DD RID: 5341 RVA: 0x001A6234 File Offset: 0x001A4434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestActive()
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x001A6244 File Offset: 0x001A4444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestActive(QuestActive other)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x001A6254 File Offset: 0x001A4454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestActive Clone()
		{
			return null;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x001A6264 File Offset: 0x001A4464
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x001A6274 File Offset: 0x001A4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x001A6284 File Offset: 0x001A4484
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x001A6294 File Offset: 0x001A4494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public QuestActive.Types.Details Details
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

		// Token: 0x060014E4 RID: 5348 RVA: 0x001A62A4 File Offset: 0x001A44A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x001A62B4 File Offset: 0x001A44B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestActive other)
		{
			return true;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x001A62C4 File Offset: 0x001A44C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x001A62D4 File Offset: 0x001A44D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x001A62E4 File Offset: 0x001A44E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x001A62F4 File Offset: 0x001A44F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x001A6304 File Offset: 0x001A4504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x001A6314 File Offset: 0x001A4514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestActive other)
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x001A6324 File Offset: 0x001A4524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x001A6334 File Offset: 0x001A4534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x001A6344 File Offset: 0x001A4544
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestActive()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				case 4:
					QuestActive._parser = new MessageParser<QuestActive>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x001A6428 File Offset: 0x001A4628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool baJx3NO1n1qAPKlHkmpg()
		{
			return true;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x001A6430 File Offset: 0x001A4630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestActive eIH7yjO1mck78M5nf1af()
		{
			return null;
		}

		// Token: 0x04000771 RID: 1905
		private static readonly MessageParser<QuestActive> _parser;

		// Token: 0x04000772 RID: 1906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000773 RID: 1907
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000774 RID: 1908
		private int questId_;

		// Token: 0x04000775 RID: 1909
		public const int DetailsFieldNumber = 2;

		// Token: 0x04000776 RID: 1910
		private QuestActive.Types.Details details_;

		// Token: 0x04000777 RID: 1911
		private static QuestActive rgoHvoO1fB4ijyiNFlMP;

		// Token: 0x020001BF RID: 447
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060014F1 RID: 5361 RVA: 0x002AF7E4 File Offset: 0x002AD9E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001C0 RID: 448
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Details : IMessage<QuestActive.Types.Details>, IMessage, IEquatable<QuestActive.Types.Details>, IDeepCloneable<QuestActive.Types.Details>, IBufferMessage
			{
				// Token: 0x170003B5 RID: 949
				// (get) Token: 0x060014F2 RID: 5362 RVA: 0x002F7D48 File Offset: 0x002F5F48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<QuestActive.Types.Details> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170003B6 RID: 950
				// (get) Token: 0x060014F3 RID: 5363 RVA: 0x002F7D58 File Offset: 0x002F5F58
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

				// Token: 0x170003B7 RID: 951
				// (get) Token: 0x060014F4 RID: 5364 RVA: 0x002F7D68 File Offset: 0x002F5F68
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

				// Token: 0x060014F5 RID: 5365 RVA: 0x002F7D78 File Offset: 0x002F5F78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Details()
				{
				}

				// Token: 0x060014F6 RID: 5366 RVA: 0x002F7D88 File Offset: 0x002F5F88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Details(QuestActive.Types.Details other)
				{
				}

				// Token: 0x060014F7 RID: 5367 RVA: 0x002F7D98 File Offset: 0x002F5F98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public QuestActive.Types.Details Clone()
				{
					return null;
				}

				// Token: 0x170003B8 RID: 952
				// (get) Token: 0x060014F8 RID: 5368 RVA: 0x002F7DA8 File Offset: 0x002F5FA8
				// (set) Token: 0x060014F9 RID: 5369 RVA: 0x002F7DB8 File Offset: 0x002F5FB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int StepId
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

				// Token: 0x170003B9 RID: 953
				// (get) Token: 0x060014FA RID: 5370 RVA: 0x002F7DC8 File Offset: 0x002F5FC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<QuestObjective> Objectives
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x060014FB RID: 5371 RVA: 0x002F7DD8 File Offset: 0x002F5FD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060014FC RID: 5372 RVA: 0x002F7DE8 File Offset: 0x002F5FE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(QuestActive.Types.Details other)
				{
					return true;
				}

				// Token: 0x060014FD RID: 5373 RVA: 0x002F7DF8 File Offset: 0x002F5FF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060014FE RID: 5374 RVA: 0x002F7E08 File Offset: 0x002F6008
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060014FF RID: 5375 RVA: 0x002F7E18 File Offset: 0x002F6018
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001500 RID: 5376 RVA: 0x002F7E28 File Offset: 0x002F6028
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001501 RID: 5377 RVA: 0x002F7E38 File Offset: 0x002F6038
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001502 RID: 5378 RVA: 0x002F7E48 File Offset: 0x002F6048
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(QuestActive.Types.Details other)
				{
				}

				// Token: 0x06001503 RID: 5379 RVA: 0x002F7E58 File Offset: 0x002F6058
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001504 RID: 5380 RVA: 0x002F7E68 File Offset: 0x002F6068
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001505 RID: 5381 RVA: 0x002F7E78 File Offset: 0x002F6078
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Details()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								return;
							case 2:
								QuestActive.Types.Details._repeated_objectives_codec = FieldCodec.ForMessage<QuestObjective>(18U, lGkOo9buV1lbJvnZUQR.XVInXhlssT(lGkOo9buV1lbJvnZUQR.S2Wb8SU46X));
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 3;
								continue;
							case 5:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 4;
								continue;
							}
							break;
						}
						IL_C0:
						QuestActive.Types.Details._parser = new MessageParser<QuestActive.Types.Details>(() => null);
						num = 2;
						continue;
						goto IL_C0;
					}
				}

				// Token: 0x06001506 RID: 5382 RVA: 0x002F7F6C File Offset: 0x002F616C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool rWvrBXGpIL7NYDS5kWkD()
				{
					return true;
				}

				// Token: 0x06001507 RID: 5383 RVA: 0x002F7F74 File Offset: 0x002F6174
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static QuestActive.Types.Details He3Op0Gpknv4ApkPPdpm()
				{
					return null;
				}

				// Token: 0x04000778 RID: 1912
				private static readonly MessageParser<QuestActive.Types.Details> _parser;

				// Token: 0x04000779 RID: 1913
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400077A RID: 1914
				public const int StepIdFieldNumber = 1;

				// Token: 0x0400077B RID: 1915
				private int stepId_;

				// Token: 0x0400077C RID: 1916
				public const int ObjectivesFieldNumber = 2;

				// Token: 0x0400077D RID: 1917
				private static readonly FieldCodec<QuestObjective> _repeated_objectives_codec;

				// Token: 0x0400077E RID: 1918
				private readonly RepeatedField<QuestObjective> objectives_;

				// Token: 0x0400077F RID: 1919
				private static QuestActive.Types.Details jvkKTOGpKHI946rGtWDI;
			}
		}
	}
}
