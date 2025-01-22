using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi
{
	// Token: 0x020004B4 RID: 1204
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HaapiSessionEvent : IMessage<HaapiSessionEvent>, IMessage, IEquatable<HaapiSessionEvent>, IDeepCloneable<HaapiSessionEvent>, IBufferMessage
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x001E1FF0 File Offset: 0x001E01F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HaapiSessionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x001E2000 File Offset: 0x001E0200
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

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x001E2010 File Offset: 0x001E0210
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

		// Token: 0x06003990 RID: 14736 RVA: 0x001E2020 File Offset: 0x001E0220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiSessionEvent()
		{
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x001E2030 File Offset: 0x001E0230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiSessionEvent(HaapiSessionEvent other)
		{
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x001E2040 File Offset: 0x001E0240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiSessionEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x001E2050 File Offset: 0x001E0250
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x001E2060 File Offset: 0x001E0260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string SessionUid
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

		// Token: 0x06003995 RID: 14741 RVA: 0x001E2070 File Offset: 0x001E0270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x001E2080 File Offset: 0x001E0280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HaapiSessionEvent other)
		{
			return true;
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x001E2090 File Offset: 0x001E0290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x001E20A0 File Offset: 0x001E02A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x001E20B0 File Offset: 0x001E02B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x001E20C0 File Offset: 0x001E02C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x001E20D0 File Offset: 0x001E02D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x001E20E0 File Offset: 0x001E02E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HaapiSessionEvent other)
		{
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x001E20F0 File Offset: 0x001E02F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x001E2100 File Offset: 0x001E0300
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x001E2110 File Offset: 0x001E0310
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HaapiSessionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 3;
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
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				HaapiSessionEvent._parser = new MessageParser<HaapiSessionEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x001E2208 File Offset: 0x001E0408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cHxMBoOQdmFcWNNVqwMw()
		{
			return true;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x001E2210 File Offset: 0x001E0410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HaapiSessionEvent Cj6vhwOQ9qBNwK1qZrgq()
		{
			return null;
		}

		// Token: 0x0400140A RID: 5130
		private static readonly MessageParser<HaapiSessionEvent> _parser;

		// Token: 0x0400140B RID: 5131
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400140C RID: 5132
		public const int SessionUidFieldNumber = 1;

		// Token: 0x0400140D RID: 5133
		private string sessionUid_;

		// Token: 0x0400140E RID: 5134
		internal static HaapiSessionEvent JJTADeOQsCRBBALkkpNo;
	}
}
