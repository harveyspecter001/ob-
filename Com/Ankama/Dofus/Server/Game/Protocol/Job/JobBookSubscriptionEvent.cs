using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003BA RID: 954
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobBookSubscriptionEvent : IMessage<JobBookSubscriptionEvent>, IMessage, IEquatable<JobBookSubscriptionEvent>, IDeepCloneable<JobBookSubscriptionEvent>, IBufferMessage
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x001CDB60 File Offset: 0x001CBD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobBookSubscriptionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x001CDB70 File Offset: 0x001CBD70
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x001CDB80 File Offset: 0x001CBD80
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

		// Token: 0x06002CC6 RID: 11462 RVA: 0x001CDB90 File Offset: 0x001CBD90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscriptionEvent()
		{
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x001CDBA0 File Offset: 0x001CBDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscriptionEvent(JobBookSubscriptionEvent other)
		{
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x001CDBB0 File Offset: 0x001CBDB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscriptionEvent Clone()
		{
			return null;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x001CDBC0 File Offset: 0x001CBDC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<JobBookSubscriptionEvent.Types.Subscription> Subscriptions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x001CDBD0 File Offset: 0x001CBDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x001CDBE0 File Offset: 0x001CBDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobBookSubscriptionEvent other)
		{
			return true;
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x001CDBF0 File Offset: 0x001CBDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x001CDC00 File Offset: 0x001CBE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x001CDC10 File Offset: 0x001CBE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x001CDC20 File Offset: 0x001CBE20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x001CDC30 File Offset: 0x001CBE30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x001CDC40 File Offset: 0x001CBE40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobBookSubscriptionEvent other)
		{
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x001CDC50 File Offset: 0x001CBE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x001CDC60 File Offset: 0x001CBE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x001CDC70 File Offset: 0x001CBE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobBookSubscriptionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					JobBookSubscriptionEvent._parser = new MessageParser<JobBookSubscriptionEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					JobBookSubscriptionEvent._repeated_subscriptions_codec = FieldCodec.ForMessage<JobBookSubscriptionEvent.Types.Subscription>(10U, H3CoYIn7sK8tNnkdSHIe.XVInXhlssT(H3CoYIn7sK8tNnkdSHIe.fWnn7dJWmY8));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x001CDD60 File Offset: 0x001CBF60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F2m2IqOVttZr5XQv34tG()
		{
			return true;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x001CDD68 File Offset: 0x001CBF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobBookSubscriptionEvent qxoqQZOVw5tW6LvWMkge()
		{
			return null;
		}

		// Token: 0x04000FBC RID: 4028
		private static readonly MessageParser<JobBookSubscriptionEvent> _parser;

		// Token: 0x04000FBD RID: 4029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FBE RID: 4030
		public const int SubscriptionsFieldNumber = 1;

		// Token: 0x04000FBF RID: 4031
		private static readonly FieldCodec<JobBookSubscriptionEvent.Types.Subscription> _repeated_subscriptions_codec;

		// Token: 0x04000FC0 RID: 4032
		private readonly RepeatedField<JobBookSubscriptionEvent.Types.Subscription> subscriptions_;

		// Token: 0x04000FC1 RID: 4033
		internal static JobBookSubscriptionEvent kcYXmvOVDjtgHyJOSKs5;

		// Token: 0x020003BB RID: 955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002CD7 RID: 11479 RVA: 0x002BADE0 File Offset: 0x002B8FE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020003BC RID: 956
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Subscription : IMessage<JobBookSubscriptionEvent.Types.Subscription>, IMessage, IEquatable<JobBookSubscriptionEvent.Types.Subscription>, IDeepCloneable<JobBookSubscriptionEvent.Types.Subscription>, IBufferMessage
			{
				// Token: 0x170007FE RID: 2046
				// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x002FB8B8 File Offset: 0x002F9AB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<JobBookSubscriptionEvent.Types.Subscription> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170007FF RID: 2047
				// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x002FB8C8 File Offset: 0x002F9AC8
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

				// Token: 0x17000800 RID: 2048
				// (get) Token: 0x06002CDA RID: 11482 RVA: 0x002FB8D8 File Offset: 0x002F9AD8
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

				// Token: 0x06002CDB RID: 11483 RVA: 0x002FB8E8 File Offset: 0x002F9AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Subscription()
				{
				}

				// Token: 0x06002CDC RID: 11484 RVA: 0x002FB8F8 File Offset: 0x002F9AF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Subscription(JobBookSubscriptionEvent.Types.Subscription other)
				{
				}

				// Token: 0x06002CDD RID: 11485 RVA: 0x002FB908 File Offset: 0x002F9B08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public JobBookSubscriptionEvent.Types.Subscription Clone()
				{
					return null;
				}

				// Token: 0x17000801 RID: 2049
				// (get) Token: 0x06002CDE RID: 11486 RVA: 0x002FB918 File Offset: 0x002F9B18
				// (set) Token: 0x06002CDF RID: 11487 RVA: 0x002FB928 File Offset: 0x002F9B28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int JobId
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

				// Token: 0x17000802 RID: 2050
				// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x002FB938 File Offset: 0x002F9B38
				// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x002FB948 File Offset: 0x002F9B48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Subscribed
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

				// Token: 0x06002CE2 RID: 11490 RVA: 0x002FB958 File Offset: 0x002F9B58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002CE3 RID: 11491 RVA: 0x002FB968 File Offset: 0x002F9B68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(JobBookSubscriptionEvent.Types.Subscription other)
				{
					return true;
				}

				// Token: 0x06002CE4 RID: 11492 RVA: 0x002FB978 File Offset: 0x002F9B78
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002CE5 RID: 11493 RVA: 0x002FB988 File Offset: 0x002F9B88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002CE6 RID: 11494 RVA: 0x002FB998 File Offset: 0x002F9B98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002CE7 RID: 11495 RVA: 0x002FB9A8 File Offset: 0x002F9BA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002CE8 RID: 11496 RVA: 0x002FB9B8 File Offset: 0x002F9BB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002CE9 RID: 11497 RVA: 0x002FB9C8 File Offset: 0x002F9BC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(JobBookSubscriptionEvent.Types.Subscription other)
				{
				}

				// Token: 0x06002CEA RID: 11498 RVA: 0x002FB9D8 File Offset: 0x002F9BD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06002CEB RID: 11499 RVA: 0x002FB9E8 File Offset: 0x002F9BE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06002CEC RID: 11500 RVA: 0x002FB9F8 File Offset: 0x002F9BF8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Subscription()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							JobBookSubscriptionEvent.Types.Subscription._parser = new MessageParser<JobBookSubscriptionEvent.Types.Subscription>(() => null);
							num2 = 2;
							break;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
							{
								num2 = 1;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x06002CED RID: 11501 RVA: 0x002FBAC4 File Offset: 0x002F9CC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool KnkxDAGYhtoHmu3fGTWw()
				{
					return true;
				}

				// Token: 0x06002CEE RID: 11502 RVA: 0x002FBACC File Offset: 0x002F9CCC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static JobBookSubscriptionEvent.Types.Subscription wudys8GYr2pghQI4EUoF()
				{
					return null;
				}

				// Token: 0x04000FC2 RID: 4034
				private static readonly MessageParser<JobBookSubscriptionEvent.Types.Subscription> _parser;

				// Token: 0x04000FC3 RID: 4035
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000FC4 RID: 4036
				public const int JobIdFieldNumber = 1;

				// Token: 0x04000FC5 RID: 4037
				private int jobId_;

				// Token: 0x04000FC6 RID: 4038
				public const int SubscribedFieldNumber = 2;

				// Token: 0x04000FC7 RID: 4039
				private bool subscribed_;

				// Token: 0x04000FC8 RID: 4040
				internal static JobBookSubscriptionEvent.Types.Subscription S8uCWZGYWnXyGQMkPGuO;
			}
		}
	}
}
