using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000719 RID: 1817
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectRemovedEvent : IMessage<ExchangeObjectRemovedEvent>, IMessage, IEquatable<ExchangeObjectRemovedEvent>, IDeepCloneable<ExchangeObjectRemovedEvent>, IBufferMessage
	{
		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x00216C04 File Offset: 0x00214E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x060058ED RID: 22765 RVA: 0x00216C14 File Offset: 0x00214E14
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

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x00216C24 File Offset: 0x00214E24
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

		// Token: 0x060058EF RID: 22767 RVA: 0x00216C34 File Offset: 0x00214E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedEvent()
		{
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00216C44 File Offset: 0x00214E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedEvent(ExchangeObjectRemovedEvent other)
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00216C54 File Offset: 0x00214E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x00216C64 File Offset: 0x00214E64
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x00216C74 File Offset: 0x00214E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Remote
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x00216C84 File Offset: 0x00214E84
		// (set) Token: 0x060058F5 RID: 22773 RVA: 0x00216C94 File Offset: 0x00214E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BidItemUid
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

		// Token: 0x060058F6 RID: 22774 RVA: 0x00216CA4 File Offset: 0x00214EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00216CB4 File Offset: 0x00214EB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectRemovedEvent other)
		{
			return true;
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00216CC4 File Offset: 0x00214EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00216CD4 File Offset: 0x00214ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00216CE4 File Offset: 0x00214EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00216CF4 File Offset: 0x00214EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00216D04 File Offset: 0x00214F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x00216D14 File Offset: 0x00214F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectRemovedEvent other)
		{
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x00216D24 File Offset: 0x00214F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x00216D34 File Offset: 0x00214F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00216D44 File Offset: 0x00214F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				ExchangeObjectRemovedEvent._parser = new MessageParser<ExchangeObjectRemovedEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00216E28 File Offset: 0x00215028
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QeHwp0OuDp20o9uRbXlb()
		{
			return true;
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00216E30 File Offset: 0x00215030
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectRemovedEvent NBa05lOutYhIQgRpJJmi()
		{
			return null;
		}

		// Token: 0x04001F26 RID: 7974
		private static readonly MessageParser<ExchangeObjectRemovedEvent> _parser;

		// Token: 0x04001F27 RID: 7975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F28 RID: 7976
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F29 RID: 7977
		private bool remote_;

		// Token: 0x04001F2A RID: 7978
		public const int BidItemUidFieldNumber = 2;

		// Token: 0x04001F2B RID: 7979
		private int bidItemUid_;

		// Token: 0x04001F2C RID: 7980
		private static ExchangeObjectRemovedEvent E9SdL1OuCVVuRIZNIxfu;
	}
}
