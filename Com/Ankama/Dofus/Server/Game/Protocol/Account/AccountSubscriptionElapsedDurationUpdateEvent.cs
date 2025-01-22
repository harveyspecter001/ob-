using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DE2 RID: 3554
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccountSubscriptionElapsedDurationUpdateEvent : IMessage<AccountSubscriptionElapsedDurationUpdateEvent>, IMessage, IEquatable<AccountSubscriptionElapsedDurationUpdateEvent>, IDeepCloneable<AccountSubscriptionElapsedDurationUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x0029A204 File Offset: 0x00298404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AccountSubscriptionElapsedDurationUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x0029A214 File Offset: 0x00298414
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600AB3C RID: 43836 RVA: 0x0029A224 File Offset: 0x00298424
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

		// Token: 0x0600AB3D RID: 43837 RVA: 0x0029A234 File Offset: 0x00298434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountSubscriptionElapsedDurationUpdateEvent()
		{
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x0029A244 File Offset: 0x00298444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountSubscriptionElapsedDurationUpdateEvent(AccountSubscriptionElapsedDurationUpdateEvent other)
		{
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x0029A254 File Offset: 0x00298454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountSubscriptionElapsedDurationUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x0029A264 File Offset: 0x00298464
		// (set) Token: 0x0600AB41 RID: 43841 RVA: 0x0029A274 File Offset: 0x00298474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SubscriptionElapsedDuration
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

		// Token: 0x0600AB42 RID: 43842 RVA: 0x0029A284 File Offset: 0x00298484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x0029A294 File Offset: 0x00298494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccountSubscriptionElapsedDurationUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x0029A2A4 File Offset: 0x002984A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x0029A2B4 File Offset: 0x002984B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x0029A2C4 File Offset: 0x002984C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x0029A2D4 File Offset: 0x002984D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x0029A2E4 File Offset: 0x002984E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x0029A2F4 File Offset: 0x002984F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccountSubscriptionElapsedDurationUpdateEvent other)
		{
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x0029A304 File Offset: 0x00298504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x0029A314 File Offset: 0x00298514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x0029A324 File Offset: 0x00298524
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountSubscriptionElapsedDurationUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AccountSubscriptionElapsedDurationUpdateEvent._parser = new MessageParser<AccountSubscriptionElapsedDurationUpdateEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x0029A408 File Offset: 0x00298608
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r041RPJcqustPjcXfcc3()
		{
			return true;
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x0029A410 File Offset: 0x00298610
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccountSubscriptionElapsedDurationUpdateEvent SC7pPAJcFSc9bdK7dpZ4()
		{
			return null;
		}

		// Token: 0x04003ED8 RID: 16088
		private static readonly MessageParser<AccountSubscriptionElapsedDurationUpdateEvent> _parser;

		// Token: 0x04003ED9 RID: 16089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EDA RID: 16090
		public const int SubscriptionElapsedDurationFieldNumber = 1;

		// Token: 0x04003EDB RID: 16091
		private long subscriptionElapsedDuration_;

		// Token: 0x04003EDC RID: 16092
		internal static AccountSubscriptionElapsedDurationUpdateEvent oaiwY5JcZGbBnZHV02qN;
	}
}
