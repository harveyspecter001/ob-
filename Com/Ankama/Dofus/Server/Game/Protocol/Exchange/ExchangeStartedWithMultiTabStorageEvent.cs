using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000733 RID: 1843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStartedWithMultiTabStorageEvent : IMessage<ExchangeStartedWithMultiTabStorageEvent>, IMessage, IEquatable<ExchangeStartedWithMultiTabStorageEvent>, IDeepCloneable<ExchangeStartedWithMultiTabStorageEvent>, IBufferMessage
	{
		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x00218944 File Offset: 0x00216B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeStartedWithMultiTabStorageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x00218954 File Offset: 0x00216B54
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

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x00218964 File Offset: 0x00216B64
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

		// Token: 0x06005A63 RID: 23139 RVA: 0x00218974 File Offset: 0x00216B74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithMultiTabStorageEvent()
		{
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00218984 File Offset: 0x00216B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithMultiTabStorageEvent(ExchangeStartedWithMultiTabStorageEvent other)
		{
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00218994 File Offset: 0x00216B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithMultiTabStorageEvent Clone()
		{
			return null;
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x002189A4 File Offset: 0x00216BA4
		// (set) Token: 0x06005A67 RID: 23143 RVA: 0x002189B8 File Offset: 0x00216BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeType ExchangeType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06005A68 RID: 23144 RVA: 0x002189C8 File Offset: 0x00216BC8
		// (set) Token: 0x06005A69 RID: 23145 RVA: 0x002189D8 File Offset: 0x00216BD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int StorageMaxSlot
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06005A6A RID: 23146 RVA: 0x002189E8 File Offset: 0x00216BE8
		// (set) Token: 0x06005A6B RID: 23147 RVA: 0x002189F8 File Offset: 0x00216BF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TabNumber
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

		// Token: 0x06005A6C RID: 23148 RVA: 0x00218A08 File Offset: 0x00216C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00218A18 File Offset: 0x00216C18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeStartedWithMultiTabStorageEvent other)
		{
			return true;
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00218A28 File Offset: 0x00216C28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00218A38 File Offset: 0x00216C38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00218A48 File Offset: 0x00216C48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00218A58 File Offset: 0x00216C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00218A68 File Offset: 0x00216C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00218A78 File Offset: 0x00216C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeStartedWithMultiTabStorageEvent other)
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00218A88 File Offset: 0x00216C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00218A98 File Offset: 0x00216C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00218AA8 File Offset: 0x00216CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeStartedWithMultiTabStorageEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					ExchangeStartedWithMultiTabStorageEvent._parser = new MessageParser<ExchangeStartedWithMultiTabStorageEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00218B74 File Offset: 0x00216D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q2yBalO8xGpyjlVN1l6Q()
		{
			return true;
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00218B7C File Offset: 0x00216D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeStartedWithMultiTabStorageEvent tuVjA5O84jWEK4KJO29Q()
		{
			return null;
		}

		// Token: 0x04001FA7 RID: 8103
		private static readonly MessageParser<ExchangeStartedWithMultiTabStorageEvent> _parser;

		// Token: 0x04001FA8 RID: 8104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA9 RID: 8105
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001FAA RID: 8106
		private ExchangeType exchangeType_;

		// Token: 0x04001FAB RID: 8107
		public const int StorageMaxSlotFieldNumber = 2;

		// Token: 0x04001FAC RID: 8108
		private int storageMaxSlot_;

		// Token: 0x04001FAD RID: 8109
		public const int TabNumberFieldNumber = 3;

		// Token: 0x04001FAE RID: 8110
		private int tabNumber_;

		// Token: 0x04001FAF RID: 8111
		internal static ExchangeStartedWithMultiTabStorageEvent kSoF97O8Nni6rVvY5KDy;
	}
}
