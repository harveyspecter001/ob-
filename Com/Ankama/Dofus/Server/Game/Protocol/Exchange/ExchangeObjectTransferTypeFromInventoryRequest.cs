using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006DA RID: 1754
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferTypeFromInventoryRequest : IMessage<ExchangeObjectTransferTypeFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferTypeFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferTypeFromInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x00212E68 File Offset: 0x00211068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectTransferTypeFromInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060055CB RID: 21963 RVA: 0x00212E78 File Offset: 0x00211078
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

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x00212E88 File Offset: 0x00211088
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

		// Token: 0x060055CD RID: 21965 RVA: 0x00212E98 File Offset: 0x00211098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferTypeFromInventoryRequest()
		{
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00212EA8 File Offset: 0x002110A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferTypeFromInventoryRequest(ExchangeObjectTransferTypeFromInventoryRequest other)
		{
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00212EB8 File Offset: 0x002110B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferTypeFromInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x00212EC8 File Offset: 0x002110C8
		// (set) Token: 0x060055D1 RID: 21969 RVA: 0x00212ED8 File Offset: 0x002110D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060055D2 RID: 21970 RVA: 0x00212EE8 File Offset: 0x002110E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00212EF8 File Offset: 0x002110F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferTypeFromInventoryRequest other)
		{
			return true;
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00212F08 File Offset: 0x00211108
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00212F18 File Offset: 0x00211118
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00212F28 File Offset: 0x00211128
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00212F38 File Offset: 0x00211138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00212F48 File Offset: 0x00211148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00212F58 File Offset: 0x00211158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferTypeFromInventoryRequest other)
		{
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00212F68 File Offset: 0x00211168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00212F78 File Offset: 0x00211178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00212F88 File Offset: 0x00211188
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferTypeFromInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeObjectTransferTypeFromInventoryRequest._parser = new MessageParser<ExchangeObjectTransferTypeFromInventoryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x0021306C File Offset: 0x0021126C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LKOt7vOMXGbSUjM7cG2v()
		{
			return true;
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00213074 File Offset: 0x00211274
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferTypeFromInventoryRequest hfqq6HOMNCbSISInBNjS()
		{
			return null;
		}

		// Token: 0x04001E24 RID: 7716
		private static readonly MessageParser<ExchangeObjectTransferTypeFromInventoryRequest> _parser;

		// Token: 0x04001E25 RID: 7717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E26 RID: 7718
		public const int ObjectTypeFieldNumber = 1;

		// Token: 0x04001E27 RID: 7719
		private int objectType_;

		// Token: 0x04001E28 RID: 7720
		internal static ExchangeObjectTransferTypeFromInventoryRequest s7GOMnOME634xUST8fCg;
	}
}
