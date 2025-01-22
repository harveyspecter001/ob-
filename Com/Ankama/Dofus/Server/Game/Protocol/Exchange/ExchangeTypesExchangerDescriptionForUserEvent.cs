using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200077A RID: 1914
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTypesExchangerDescriptionForUserEvent : IMessage<ExchangeTypesExchangerDescriptionForUserEvent>, IMessage, IEquatable<ExchangeTypesExchangerDescriptionForUserEvent>, IDeepCloneable<ExchangeTypesExchangerDescriptionForUserEvent>, IBufferMessage
	{
		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x0021C8A8 File Offset: 0x0021AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeTypesExchangerDescriptionForUserEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x0021C8B8 File Offset: 0x0021AAB8
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

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x0021C8C8 File Offset: 0x0021AAC8
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

		// Token: 0x06005DD0 RID: 24016 RVA: 0x0021C8D8 File Offset: 0x0021AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesExchangerDescriptionForUserEvent()
		{
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0021C8E8 File Offset: 0x0021AAE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesExchangerDescriptionForUserEvent(ExchangeTypesExchangerDescriptionForUserEvent other)
		{
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x0021C8F8 File Offset: 0x0021AAF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTypesExchangerDescriptionForUserEvent Clone()
		{
			return null;
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06005DD3 RID: 24019 RVA: 0x0021C908 File Offset: 0x0021AB08
		// (set) Token: 0x06005DD4 RID: 24020 RVA: 0x0021C918 File Offset: 0x0021AB18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectType
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

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x0021C928 File Offset: 0x0021AB28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> TypeDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x0021C938 File Offset: 0x0021AB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x0021C948 File Offset: 0x0021AB48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTypesExchangerDescriptionForUserEvent other)
		{
			return true;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x0021C958 File Offset: 0x0021AB58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0021C968 File Offset: 0x0021AB68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x0021C978 File Offset: 0x0021AB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x0021C988 File Offset: 0x0021AB88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x0021C998 File Offset: 0x0021AB98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x0021C9A8 File Offset: 0x0021ABA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTypesExchangerDescriptionForUserEvent other)
		{
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x0021C9B8 File Offset: 0x0021ABB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x0021C9C8 File Offset: 0x0021ABC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x0021C9D8 File Offset: 0x0021ABD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTypesExchangerDescriptionForUserEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						return;
					case 5:
						ExchangeTypesExchangerDescriptionForUserEvent._repeated_typeDescription_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 4;
						continue;
					}
					break;
				}
				IL_BB:
				ExchangeTypesExchangerDescriptionForUserEvent._parser = new MessageParser<ExchangeTypesExchangerDescriptionForUserEvent>(() => null);
				num = 5;
				continue;
				goto IL_BB;
			}
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x0021CAC8 File Offset: 0x0021ACC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J4IpMsOZCVII7eAOWHP3()
		{
			return true;
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x0021CAD0 File Offset: 0x0021ACD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTypesExchangerDescriptionForUserEvent tUcjrfOZDUmK7ITp8vZY()
		{
			return null;
		}

		// Token: 0x040020F4 RID: 8436
		private static readonly MessageParser<ExchangeTypesExchangerDescriptionForUserEvent> _parser;

		// Token: 0x040020F5 RID: 8437
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F6 RID: 8438
		public const int ObjectTypeFieldNumber = 1;

		// Token: 0x040020F7 RID: 8439
		private int objectType_;

		// Token: 0x040020F8 RID: 8440
		public const int TypeDescriptionFieldNumber = 2;

		// Token: 0x040020F9 RID: 8441
		private static readonly FieldCodec<int> _repeated_typeDescription_codec;

		// Token: 0x040020FA RID: 8442
		private readonly RepeatedField<int> typeDescription_;

		// Token: 0x040020FB RID: 8443
		internal static ExchangeTypesExchangerDescriptionForUserEvent OcVHlCOZ0EMsBp7y5Rat;
	}
}
