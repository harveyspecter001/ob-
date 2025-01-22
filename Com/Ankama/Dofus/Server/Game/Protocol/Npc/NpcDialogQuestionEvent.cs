using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x0200033B RID: 827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcDialogQuestionEvent : IMessage<NpcDialogQuestionEvent>, IMessage, IEquatable<NpcDialogQuestionEvent>, IDeepCloneable<NpcDialogQuestionEvent>, IBufferMessage
	{
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x001C3438 File Offset: 0x001C1638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcDialogQuestionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x001C3448 File Offset: 0x001C1648
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

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x001C3458 File Offset: 0x001C1658
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

		// Token: 0x060026C2 RID: 9922 RVA: 0x001C3468 File Offset: 0x001C1668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogQuestionEvent()
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x001C3478 File Offset: 0x001C1678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogQuestionEvent(NpcDialogQuestionEvent other)
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x001C3488 File Offset: 0x001C1688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogQuestionEvent Clone()
		{
			return null;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x001C3498 File Offset: 0x001C1698
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x001C34A8 File Offset: 0x001C16A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MessageId
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

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x001C34B8 File Offset: 0x001C16B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> DialogParams
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x001C34C8 File Offset: 0x001C16C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcDialogQuestionEvent.Types.VisibleReply> VisibleReplies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x001C34D8 File Offset: 0x001C16D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x001C34E8 File Offset: 0x001C16E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcDialogQuestionEvent other)
		{
			return true;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x001C34F8 File Offset: 0x001C16F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x001C3508 File Offset: 0x001C1708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x001C3518 File Offset: 0x001C1718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x001C3528 File Offset: 0x001C1728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x001C3538 File Offset: 0x001C1738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x001C3548 File Offset: 0x001C1748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcDialogQuestionEvent other)
		{
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x001C3558 File Offset: 0x001C1758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x001C3568 File Offset: 0x001C1768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x001C3578 File Offset: 0x001C1778
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcDialogQuestionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					NpcDialogQuestionEvent._repeated_visibleReplies_codec = FieldCodec.ForMessage<NpcDialogQuestionEvent.Types.VisibleReply>(26U, EKRo8Cn6KFhCPVMBm97u.XVInXhlssT(EKRo8Cn6KFhCPVMBm97u.dcBn6I4bOKA));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					NpcDialogQuestionEvent._parser = new MessageParser<NpcDialogQuestionEvent>(() => null);
					num2 = 6;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 6:
					NpcDialogQuestionEvent._repeated_dialogParams_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(18U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x001C36C8 File Offset: 0x001C18C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SHqcn7OWZAYd3y4DId0H()
		{
			return true;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x001C36D0 File Offset: 0x001C18D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcDialogQuestionEvent Qlhui4OWqLlZyIVj3yY6()
		{
			return null;
		}

		// Token: 0x04000DC9 RID: 3529
		private static readonly MessageParser<NpcDialogQuestionEvent> _parser;

		// Token: 0x04000DCA RID: 3530
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DCB RID: 3531
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04000DCC RID: 3532
		private int messageId_;

		// Token: 0x04000DCD RID: 3533
		public const int DialogParamsFieldNumber = 2;

		// Token: 0x04000DCE RID: 3534
		private static readonly FieldCodec<string> _repeated_dialogParams_codec;

		// Token: 0x04000DCF RID: 3535
		private readonly RepeatedField<string> dialogParams_;

		// Token: 0x04000DD0 RID: 3536
		public const int VisibleRepliesFieldNumber = 3;

		// Token: 0x04000DD1 RID: 3537
		private static readonly FieldCodec<NpcDialogQuestionEvent.Types.VisibleReply> _repeated_visibleReplies_codec;

		// Token: 0x04000DD2 RID: 3538
		private readonly RepeatedField<NpcDialogQuestionEvent.Types.VisibleReply> visibleReplies_;

		// Token: 0x04000DD3 RID: 3539
		internal static NpcDialogQuestionEvent RmrSHCOW8vwhdaAH6nh0;

		// Token: 0x0200033C RID: 828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060026D6 RID: 9942 RVA: 0x002B7BEC File Offset: 0x002B5DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200033D RID: 829
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class VisibleReply : IMessage<NpcDialogQuestionEvent.Types.VisibleReply>, IMessage, IEquatable<NpcDialogQuestionEvent.Types.VisibleReply>, IDeepCloneable<NpcDialogQuestionEvent.Types.VisibleReply>, IBufferMessage
			{
				// Token: 0x170006F8 RID: 1784
				// (get) Token: 0x060026D7 RID: 9943 RVA: 0x002FB1D8 File Offset: 0x002F93D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<NpcDialogQuestionEvent.Types.VisibleReply> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170006F9 RID: 1785
				// (get) Token: 0x060026D8 RID: 9944 RVA: 0x002FB1E8 File Offset: 0x002F93E8
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

				// Token: 0x170006FA RID: 1786
				// (get) Token: 0x060026D9 RID: 9945 RVA: 0x002FB1F8 File Offset: 0x002F93F8
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

				// Token: 0x060026DA RID: 9946 RVA: 0x002FB208 File Offset: 0x002F9408
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public VisibleReply()
				{
				}

				// Token: 0x060026DB RID: 9947 RVA: 0x002FB218 File Offset: 0x002F9418
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public VisibleReply(NpcDialogQuestionEvent.Types.VisibleReply other)
				{
				}

				// Token: 0x060026DC RID: 9948 RVA: 0x002FB228 File Offset: 0x002F9428
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public NpcDialogQuestionEvent.Types.VisibleReply Clone()
				{
					return null;
				}

				// Token: 0x170006FB RID: 1787
				// (get) Token: 0x060026DD RID: 9949 RVA: 0x002FB238 File Offset: 0x002F9438
				// (set) Token: 0x060026DE RID: 9950 RVA: 0x002FB248 File Offset: 0x002F9448
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ReplyId
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

				// Token: 0x170006FC RID: 1788
				// (get) Token: 0x060026DF RID: 9951 RVA: 0x002FB258 File Offset: 0x002F9458
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation> Actions
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x060026E0 RID: 9952 RVA: 0x002FB268 File Offset: 0x002F9468
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060026E1 RID: 9953 RVA: 0x002FB278 File Offset: 0x002F9478
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(NpcDialogQuestionEvent.Types.VisibleReply other)
				{
					return true;
				}

				// Token: 0x060026E2 RID: 9954 RVA: 0x002FB288 File Offset: 0x002F9488
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060026E3 RID: 9955 RVA: 0x002FB298 File Offset: 0x002F9498
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060026E4 RID: 9956 RVA: 0x002FB2A8 File Offset: 0x002F94A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060026E5 RID: 9957 RVA: 0x002FB2B8 File Offset: 0x002F94B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060026E6 RID: 9958 RVA: 0x002FB2C8 File Offset: 0x002F94C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060026E7 RID: 9959 RVA: 0x002FB2D8 File Offset: 0x002F94D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(NpcDialogQuestionEvent.Types.VisibleReply other)
				{
				}

				// Token: 0x060026E8 RID: 9960 RVA: 0x002FB2E8 File Offset: 0x002F94E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060026E9 RID: 9961 RVA: 0x002FB2F8 File Offset: 0x002F94F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060026EA RID: 9962 RVA: 0x002FB308 File Offset: 0x002F9508
				[MethodImpl(MethodImplOptions.NoInlining)]
				static VisibleReply()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NpcDialogQuestionEvent.Types.VisibleReply._parser = new MessageParser<NpcDialogQuestionEvent.Types.VisibleReply>(() => null);
							num2 = 2;
							continue;
						case 2:
							NpcDialogQuestionEvent.Types.VisibleReply._repeated_actions_codec = FieldCodec.ForMessage<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation>(18U, rFJy0on6kDJg8rm4VeDP.XVInXhlssT(rFJy0on6kDJg8rm4VeDP.Kvkn6l4bX4b));
							num2 = 3;
							continue;
						case 3:
							return;
						case 4:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 4;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x060026EB RID: 9963 RVA: 0x002FB3F8 File Offset: 0x002F95F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool SG6vC6GYxN0NAwik7oOx()
				{
					return true;
				}

				// Token: 0x060026EC RID: 9964 RVA: 0x002FB400 File Offset: 0x002F9600
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static NpcDialogQuestionEvent.Types.VisibleReply CgTxXDGY4vA2dkB8bh7A()
				{
					return null;
				}

				// Token: 0x04000DD4 RID: 3540
				private static readonly MessageParser<NpcDialogQuestionEvent.Types.VisibleReply> _parser;

				// Token: 0x04000DD5 RID: 3541
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000DD6 RID: 3542
				public const int ReplyIdFieldNumber = 1;

				// Token: 0x04000DD7 RID: 3543
				private int replyId_;

				// Token: 0x04000DD8 RID: 3544
				public const int ActionsFieldNumber = 2;

				// Token: 0x04000DD9 RID: 3545
				private static readonly FieldCodec<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation> _repeated_actions_codec;

				// Token: 0x04000DDA RID: 3546
				private readonly RepeatedField<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation> actions_;

				// Token: 0x04000DDB RID: 3547
				internal static NpcDialogQuestionEvent.Types.VisibleReply k9us0ZGYN2MBqrEKDb8l;

				// Token: 0x0200033E RID: 830
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x060026ED RID: 9965 RVA: 0x0031242C File Offset: 0x0031062C
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x0200033F RID: 831
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class ActionInformation : IMessage<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation>, IMessage, IEquatable<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation>, IDeepCloneable<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation>, IBufferMessage
					{
						// Token: 0x170006FD RID: 1789
						// (get) Token: 0x060026EE RID: 9966 RVA: 0x0031BDC8 File Offset: 0x00319FC8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x170006FE RID: 1790
						// (get) Token: 0x060026EF RID: 9967 RVA: 0x0031BDD8 File Offset: 0x00319FD8
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

						// Token: 0x170006FF RID: 1791
						// (get) Token: 0x060026F0 RID: 9968 RVA: 0x0031BDE8 File Offset: 0x00319FE8
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

						// Token: 0x060026F1 RID: 9969 RVA: 0x0031BDF8 File Offset: 0x00319FF8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public ActionInformation()
						{
						}

						// Token: 0x060026F2 RID: 9970 RVA: 0x0031BE08 File Offset: 0x0031A008
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public ActionInformation(NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation other)
						{
						}

						// Token: 0x060026F3 RID: 9971 RVA: 0x0031BE18 File Offset: 0x0031A018
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation Clone()
						{
							return null;
						}

						// Token: 0x17000700 RID: 1792
						// (get) Token: 0x060026F4 RID: 9972 RVA: 0x0031BE28 File Offset: 0x0031A028
						// (set) Token: 0x060026F5 RID: 9973 RVA: 0x0031BE38 File Offset: 0x0031A038
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
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

						// Token: 0x17000701 RID: 1793
						// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0031BE48 File Offset: 0x0031A048
						// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0031BE58 File Offset: 0x0031A058
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool IsRepeatable
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

						// Token: 0x17000702 RID: 1794
						// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0031BE68 File Offset: 0x0031A068
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool HasIsRepeatable
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
						}

						// Token: 0x060026F9 RID: 9977 RVA: 0x0031BE78 File Offset: 0x0031A078
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void ClearIsRepeatable()
						{
						}

						// Token: 0x060026FA RID: 9978 RVA: 0x0031BE88 File Offset: 0x0031A088
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060026FB RID: 9979 RVA: 0x0031BE98 File Offset: 0x0031A098
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation other)
						{
							return true;
						}

						// Token: 0x060026FC RID: 9980 RVA: 0x0031BEA8 File Offset: 0x0031A0A8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060026FD RID: 9981 RVA: 0x0031BEB8 File Offset: 0x0031A0B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060026FE RID: 9982 RVA: 0x0031BEC8 File Offset: 0x0031A0C8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060026FF RID: 9983 RVA: 0x0031BED8 File Offset: 0x0031A0D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06002700 RID: 9984 RVA: 0x0031BEE8 File Offset: 0x0031A0E8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06002701 RID: 9985 RVA: 0x0031BEF8 File Offset: 0x0031A0F8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation other)
						{
						}

						// Token: 0x06002702 RID: 9986 RVA: 0x0031BF08 File Offset: 0x0031A108
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06002703 RID: 9987 RVA: 0x0031BF18 File Offset: 0x0031A118
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06002704 RID: 9988 RVA: 0x0031BF28 File Offset: 0x0031A128
						[MethodImpl(MethodImplOptions.NoInlining)]
						static ActionInformation()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 5;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									continue;
								case 2:
									NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation._parser = new MessageParser<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									return;
								case 4:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 5:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 4;
									continue;
								}
								NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation.IsRepeatableDefaultValue = false;
								num2 = 3;
							}
						}

						// Token: 0x06002705 RID: 9989 RVA: 0x0031C008 File Offset: 0x0031A208
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool WbAFMdgJnv3eR2Z87Oga()
						{
							return true;
						}

						// Token: 0x06002706 RID: 9990 RVA: 0x0031C010 File Offset: 0x0031A210
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation g0WVhRgJmUWOhBnQy1W0()
						{
							return null;
						}

						// Token: 0x04000DDC RID: 3548
						private static readonly MessageParser<NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation> _parser;

						// Token: 0x04000DDD RID: 3549
						private UnknownFieldSet _unknownFields;

						// Token: 0x04000DDE RID: 3550
						private int _hasBits0;

						// Token: 0x04000DDF RID: 3551
						public const int IdFieldNumber = 1;

						// Token: 0x04000DE0 RID: 3552
						private int id_;

						// Token: 0x04000DE1 RID: 3553
						public const int IsRepeatableFieldNumber = 2;

						// Token: 0x04000DE2 RID: 3554
						private static readonly bool IsRepeatableDefaultValue;

						// Token: 0x04000DE3 RID: 3555
						private bool isRepeatable_;

						// Token: 0x04000DE4 RID: 3556
						internal static NpcDialogQuestionEvent.Types.VisibleReply.Types.ActionInformation XaFroVgJfb20RxNMyNct;
					}
				}
			}
		}
	}
}
