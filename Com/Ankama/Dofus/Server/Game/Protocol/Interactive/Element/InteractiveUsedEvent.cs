using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x02000442 RID: 1090
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveUsedEvent : IMessage<InteractiveUsedEvent>, IMessage, IEquatable<InteractiveUsedEvent>, IDeepCloneable<InteractiveUsedEvent>, IBufferMessage
	{
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x001D8878 File Offset: 0x001D6A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<InteractiveUsedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x001D8888 File Offset: 0x001D6A88
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x001D8898 File Offset: 0x001D6A98
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

		// Token: 0x060033C3 RID: 13251 RVA: 0x001D88A8 File Offset: 0x001D6AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUsedEvent()
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x001D88B8 File Offset: 0x001D6AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUsedEvent(InteractiveUsedEvent other)
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x001D88C8 File Offset: 0x001D6AC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUsedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x001D88D8 File Offset: 0x001D6AD8
		// (set) Token: 0x060033C7 RID: 13255 RVA: 0x001D88E8 File Offset: 0x001D6AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x001D88F8 File Offset: 0x001D6AF8
		// (set) Token: 0x060033C9 RID: 13257 RVA: 0x001D8908 File Offset: 0x001D6B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ElementId
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

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x001D8918 File Offset: 0x001D6B18
		// (set) Token: 0x060033CB RID: 13259 RVA: 0x001D8928 File Offset: 0x001D6B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x001D8938 File Offset: 0x001D6B38
		// (set) Token: 0x060033CD RID: 13261 RVA: 0x001D8948 File Offset: 0x001D6B48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Duration
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

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x001D8958 File Offset: 0x001D6B58
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x001D8968 File Offset: 0x001D6B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool CanMove
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

		// Token: 0x060033D0 RID: 13264 RVA: 0x001D8978 File Offset: 0x001D6B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x001D8988 File Offset: 0x001D6B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveUsedEvent other)
		{
			return true;
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x001D8998 File Offset: 0x001D6B98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x001D89A8 File Offset: 0x001D6BA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x001D89B8 File Offset: 0x001D6BB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x001D89C8 File Offset: 0x001D6BC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x001D89D8 File Offset: 0x001D6BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x001D89E8 File Offset: 0x001D6BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveUsedEvent other)
		{
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x001D89F8 File Offset: 0x001D6BF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x001D8A08 File Offset: 0x001D6C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x001D8A18 File Offset: 0x001D6C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveUsedEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				InteractiveUsedEvent._parser = new MessageParser<InteractiveUsedEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x001D8B10 File Offset: 0x001D6D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool buRpTJODhyIvoQ0X2GxH()
		{
			return true;
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x001D8B18 File Offset: 0x001D6D18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveUsedEvent BNt105ODrJMU6kZ1KmLi()
		{
			return null;
		}

		// Token: 0x0400121A RID: 4634
		private static readonly MessageParser<InteractiveUsedEvent> _parser;

		// Token: 0x0400121B RID: 4635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400121C RID: 4636
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400121D RID: 4637
		private long entityId_;

		// Token: 0x0400121E RID: 4638
		public const int ElementIdFieldNumber = 2;

		// Token: 0x0400121F RID: 4639
		private int elementId_;

		// Token: 0x04001220 RID: 4640
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04001221 RID: 4641
		private int skillId_;

		// Token: 0x04001222 RID: 4642
		public const int DurationFieldNumber = 4;

		// Token: 0x04001223 RID: 4643
		private int duration_;

		// Token: 0x04001224 RID: 4644
		public const int CanMoveFieldNumber = 5;

		// Token: 0x04001225 RID: 4645
		private bool canMove_;

		// Token: 0x04001226 RID: 4646
		internal static InteractiveUsedEvent XhVfkvODWKc0S2SekfgR;
	}
}
