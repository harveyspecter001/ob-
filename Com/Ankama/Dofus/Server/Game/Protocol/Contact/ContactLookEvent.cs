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
	// Token: 0x02000848 RID: 2120
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactLookEvent : IMessage<ContactLookEvent>, IMessage, IEquatable<ContactLookEvent>, IDeepCloneable<ContactLookEvent>, IBufferMessage
	{
		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x0022C794 File Offset: 0x0022A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactLookEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06006709 RID: 26377 RVA: 0x0022C7A4 File Offset: 0x0022A9A4
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

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600670A RID: 26378 RVA: 0x0022C7B4 File Offset: 0x0022A9B4
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

		// Token: 0x0600670B RID: 26379 RVA: 0x0022C7C4 File Offset: 0x0022A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookEvent()
		{
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x0022C7D4 File Offset: 0x0022A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookEvent(ContactLookEvent other)
		{
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x0022C7E4 File Offset: 0x0022A9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLookEvent Clone()
		{
			return null;
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x0022C7F4 File Offset: 0x0022A9F4
		// (set) Token: 0x0600670F RID: 26383 RVA: 0x0022C804 File Offset: 0x0022AA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RequestId
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

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x0022C814 File Offset: 0x0022AA14
		// (set) Token: 0x06006711 RID: 26385 RVA: 0x0022C824 File Offset: 0x0022AA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06006712 RID: 26386 RVA: 0x0022C834 File Offset: 0x0022AA34
		// (set) Token: 0x06006713 RID: 26387 RVA: 0x0022C844 File Offset: 0x0022AA44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x0022C854 File Offset: 0x0022AA54
		// (set) Token: 0x06006715 RID: 26389 RVA: 0x0022C864 File Offset: 0x0022AA64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook Look
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

		// Token: 0x06006716 RID: 26390 RVA: 0x0022C874 File Offset: 0x0022AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x0022C884 File Offset: 0x0022AA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactLookEvent other)
		{
			return true;
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x0022C894 File Offset: 0x0022AA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x0022C8A4 File Offset: 0x0022AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x0022C8B4 File Offset: 0x0022AAB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x0022C8C4 File Offset: 0x0022AAC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x0022C8D4 File Offset: 0x0022AAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x0022C8E4 File Offset: 0x0022AAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactLookEvent other)
		{
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x0022C8F4 File Offset: 0x0022AAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x0022C904 File Offset: 0x0022AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x0022C914 File Offset: 0x0022AB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactLookEvent()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ContactLookEvent._parser = new MessageParser<ContactLookEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x0022C9F8 File Offset: 0x0022ABF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HEArprJnnTEUad7s3qbg()
		{
			return true;
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x0022CA00 File Offset: 0x0022AC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactLookEvent AFvhW8JnmBFqM8kp3vgs()
		{
			return null;
		}

		// Token: 0x0400241B RID: 9243
		private static readonly MessageParser<ContactLookEvent> _parser;

		// Token: 0x0400241C RID: 9244
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400241D RID: 9245
		public const int RequestIdFieldNumber = 1;

		// Token: 0x0400241E RID: 9246
		private int requestId_;

		// Token: 0x0400241F RID: 9247
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x04002420 RID: 9248
		private string playerName_;

		// Token: 0x04002421 RID: 9249
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04002422 RID: 9250
		private long playerId_;

		// Token: 0x04002423 RID: 9251
		public const int LookFieldNumber = 4;

		// Token: 0x04002424 RID: 9252
		private EntityLook look_;

		// Token: 0x04002425 RID: 9253
		internal static ContactLookEvent nMNabiJnfl7bIFe54GG2;
	}
}
