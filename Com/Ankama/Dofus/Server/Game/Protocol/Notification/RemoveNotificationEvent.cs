using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification
{
	// Token: 0x02000358 RID: 856
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveNotificationEvent : IMessage<RemoveNotificationEvent>, IMessage, IEquatable<RemoveNotificationEvent>, IDeepCloneable<RemoveNotificationEvent>, IBufferMessage
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x001C5134 File Offset: 0x001C3334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveNotificationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x001C5144 File Offset: 0x001C3344
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x001C5154 File Offset: 0x001C3354
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

		// Token: 0x06002836 RID: 10294 RVA: 0x001C5164 File Offset: 0x001C3364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveNotificationEvent()
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x001C5174 File Offset: 0x001C3374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveNotificationEvent(RemoveNotificationEvent other)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x001C5184 File Offset: 0x001C3384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveNotificationEvent Clone()
		{
			return null;
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x001C5194 File Offset: 0x001C3394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x001C51A4 File Offset: 0x001C33A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x001C51B4 File Offset: 0x001C33B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveNotificationEvent other)
		{
			return true;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x001C51C4 File Offset: 0x001C33C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x001C51D4 File Offset: 0x001C33D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x001C51E4 File Offset: 0x001C33E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x001C51F4 File Offset: 0x001C33F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x001C5204 File Offset: 0x001C3404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x001C5214 File Offset: 0x001C3414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveNotificationEvent other)
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x001C5224 File Offset: 0x001C3424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x001C5234 File Offset: 0x001C3434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x001C5244 File Offset: 0x001C3444
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveNotificationEvent()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					RemoveNotificationEvent._repeated_id_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				RemoveNotificationEvent._parser = new MessageParser<RemoveNotificationEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x001C535C File Offset: 0x001C355C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lpQQZIOh51nDqRfwdo54()
		{
			return true;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x001C5364 File Offset: 0x001C3564
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveNotificationEvent e2HuB8Ohyh3gvcafJ352()
		{
			return null;
		}

		// Token: 0x04000E4E RID: 3662
		private static readonly MessageParser<RemoveNotificationEvent> _parser;

		// Token: 0x04000E4F RID: 3663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E50 RID: 3664
		public const int IdFieldNumber = 1;

		// Token: 0x04000E51 RID: 3665
		private static readonly FieldCodec<int> _repeated_id_codec;

		// Token: 0x04000E52 RID: 3666
		private readonly RepeatedField<int> id_;

		// Token: 0x04000E53 RID: 3667
		private static RemoveNotificationEvent pj6auIOhaqV4oZxYlRkk;
	}
}
