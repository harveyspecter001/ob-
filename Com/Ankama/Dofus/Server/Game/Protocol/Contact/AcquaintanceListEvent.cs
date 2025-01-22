using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000882 RID: 2178
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceListEvent : IMessage<AcquaintanceListEvent>, IMessage, IEquatable<AcquaintanceListEvent>, IDeepCloneable<AcquaintanceListEvent>, IBufferMessage
	{
		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060069A8 RID: 27048 RVA: 0x0022ECC4 File Offset: 0x0022CEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcquaintanceListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x0022ECD4 File Offset: 0x0022CED4
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

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060069AA RID: 27050 RVA: 0x0022ECE4 File Offset: 0x0022CEE4
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

		// Token: 0x060069AB RID: 27051 RVA: 0x0022ECF4 File Offset: 0x0022CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListEvent()
		{
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x0022ED04 File Offset: 0x0022CF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListEvent(AcquaintanceListEvent other)
		{
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x0022ED14 File Offset: 0x0022CF14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListEvent Clone()
		{
			return null;
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060069AE RID: 27054 RVA: 0x0022ED24 File Offset: 0x0022CF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AcquaintanceInformation> Acquaintance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x0022ED34 File Offset: 0x0022CF34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x0022ED44 File Offset: 0x0022CF44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceListEvent other)
		{
			return true;
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x0022ED54 File Offset: 0x0022CF54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x0022ED64 File Offset: 0x0022CF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x0022ED74 File Offset: 0x0022CF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x0022ED84 File Offset: 0x0022CF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x0022ED94 File Offset: 0x0022CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x0022EDA4 File Offset: 0x0022CFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceListEvent other)
		{
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x0022EDB4 File Offset: 0x0022CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x0022EDC4 File Offset: 0x0022CFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x0022EDD4 File Offset: 0x0022CFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceListEvent()
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
						AcquaintanceListEvent._parser = new MessageParser<AcquaintanceListEvent>(() => null);
						num2 = 2;
						continue;
					case 2:
						AcquaintanceListEvent._repeated_acquaintance_codec = FieldCodec.ForMessage<AcquaintanceInformation>(10U, zl7vcYATYA5J8uG37rq9.XVInXhlssT(zl7vcYATYA5J8uG37rq9.LeXATbxGECJ));
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						goto IL_BC;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 1;
					}
				}
				IL_BC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 4;
			}
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x0022EEE0 File Offset: 0x0022D0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fywB46JniZm5Ia5QfpuN()
		{
			return true;
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x0022EEE8 File Offset: 0x0022D0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceListEvent iTFwdrJnPJWdIlNE9h6T()
		{
			return null;
		}

		// Token: 0x040024E8 RID: 9448
		private static readonly MessageParser<AcquaintanceListEvent> _parser;

		// Token: 0x040024E9 RID: 9449
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024EA RID: 9450
		public const int AcquaintanceFieldNumber = 1;

		// Token: 0x040024EB RID: 9451
		private static readonly FieldCodec<AcquaintanceInformation> _repeated_acquaintance_codec;

		// Token: 0x040024EC RID: 9452
		private readonly RepeatedField<AcquaintanceInformation> acquaintance_;

		// Token: 0x040024ED RID: 9453
		internal static AcquaintanceListEvent q552bwJnbAdqR2UAoonW;
	}
}
