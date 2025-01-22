using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DEE RID: 3566
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubscriptionLimitationEvent : IMessage<SubscriptionLimitationEvent>, IMessage, IEquatable<SubscriptionLimitationEvent>, IDeepCloneable<SubscriptionLimitationEvent>, IBufferMessage
	{
		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x0600ABC2 RID: 43970 RVA: 0x0029ACDC File Offset: 0x00298EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubscriptionLimitationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x0029ACEC File Offset: 0x00298EEC
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

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x0029ACFC File Offset: 0x00298EFC
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

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x0029AD0C File Offset: 0x00298F0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionLimitationEvent()
		{
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x0029AD1C File Offset: 0x00298F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionLimitationEvent(SubscriptionLimitationEvent other)
		{
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x0029AD2C File Offset: 0x00298F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionLimitationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x0029AD3C File Offset: 0x00298F3C
		// (set) Token: 0x0600ABC9 RID: 43977 RVA: 0x0029AD50 File Offset: 0x00298F50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SubscriptionLimitationEvent.Types.SubscriptionRequired Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SubscriptionLimitationEvent.Types.SubscriptionRequired)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x0029AD60 File Offset: 0x00298F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x0029AD70 File Offset: 0x00298F70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubscriptionLimitationEvent other)
		{
			return true;
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x0029AD80 File Offset: 0x00298F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x0029AD90 File Offset: 0x00298F90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x0029ADA0 File Offset: 0x00298FA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x0029ADB0 File Offset: 0x00298FB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x0029ADC0 File Offset: 0x00298FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x0029ADD0 File Offset: 0x00298FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubscriptionLimitationEvent other)
		{
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x0029ADE0 File Offset: 0x00298FE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x0029ADF0 File Offset: 0x00298FF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x0029AE00 File Offset: 0x00299000
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubscriptionLimitationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SubscriptionLimitationEvent._parser = new MessageParser<SubscriptionLimitationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x0029AEE4 File Offset: 0x002990E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MNCN5tJUsTHFaqR8KJlv()
		{
			return true;
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x0029AEEC File Offset: 0x002990EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubscriptionLimitationEvent eeWp38JUdif7SeIAN2So()
		{
			return null;
		}

		// Token: 0x04003F0A RID: 16138
		private static readonly MessageParser<SubscriptionLimitationEvent> _parser;

		// Token: 0x04003F0B RID: 16139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F0C RID: 16140
		public const int ReasonFieldNumber = 1;

		// Token: 0x04003F0D RID: 16141
		private SubscriptionLimitationEvent.Types.SubscriptionRequired reason_;

		// Token: 0x04003F0E RID: 16142
		private static SubscriptionLimitationEvent JfE1N8JUg7dIyYjW7tMO;

		// Token: 0x02000DEF RID: 3567
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600ABD7 RID: 43991 RVA: 0x002F3158 File Offset: 0x002F1358
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000DF0 RID: 3568
			public enum SubscriptionRequired
			{
				// Token: 0x04003F10 RID: 16144
				[OriginalName("LIMITED_TO_SUBSCRIBER")]
				LimitedToSubscriber,
				// Token: 0x04003F11 RID: 16145
				[OriginalName("LIMIT_ON_JOB_XP")]
				LimitOnJobXp,
				// Token: 0x04003F12 RID: 16146
				[OriginalName("LIMIT_ON_JOB_USE")]
				LimitOnJobUse,
				// Token: 0x04003F13 RID: 16147
				[OriginalName("LIMIT_ON_MAP")]
				LimitOnMap,
				// Token: 0x04003F14 RID: 16148
				[OriginalName("LIMIT_ON_ITEM")]
				LimitOnItem,
				// Token: 0x04003F15 RID: 16149
				[OriginalName("LIMIT_ON_HAVEN_BAG")]
				LimitOnHavenBag
			}
		}
	}
}
