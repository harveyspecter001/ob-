using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006D2 RID: 1746
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferListWithQuantityToInventoryRequest : IMessage<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x002125FC File Offset: 0x002107FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectTransferListWithQuantityToInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x0021260C File Offset: 0x0021080C
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

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x0021261C File Offset: 0x0021081C
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

		// Token: 0x0600556B RID: 21867 RVA: 0x0021262C File Offset: 0x0021082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListWithQuantityToInventoryRequest()
		{
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x0021263C File Offset: 0x0021083C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListWithQuantityToInventoryRequest(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
		{
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x0021264C File Offset: 0x0021084C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListWithQuantityToInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x0021265C File Offset: 0x0021085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectUidWithQuantity> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x0021266C File Offset: 0x0021086C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x0021267C File Offset: 0x0021087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
		{
			return true;
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x0021268C File Offset: 0x0021088C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0021269C File Offset: 0x0021089C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x002126AC File Offset: 0x002108AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x002126BC File Offset: 0x002108BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x002126CC File Offset: 0x002108CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x002126DC File Offset: 0x002108DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
		{
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x002126EC File Offset: 0x002108EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x002126FC File Offset: 0x002108FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0021270C File Offset: 0x0021090C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferListWithQuantityToInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeObjectTransferListWithQuantityToInventoryRequest._parser = new MessageParser<ExchangeObjectTransferListWithQuantityToInventoryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					return;
				}
				ExchangeObjectTransferListWithQuantityToInventoryRequest._repeated_objects_codec = FieldCodec.ForMessage<ObjectUidWithQuantity>(10U, s7w74qnuEYuoJcLSH5jI.XVInXhlssT(s7w74qnuEYuoJcLSH5jI.L5AnuXvQxv7));
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0021283C File Offset: 0x00210A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FPHpQmOMe3Qi335t41u5()
		{
			return true;
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00212844 File Offset: 0x00210A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferListWithQuantityToInventoryRequest aLZCoEOM387GPABWJYhS()
		{
			return null;
		}

		// Token: 0x04001E0A RID: 7690
		private static readonly MessageParser<ExchangeObjectTransferListWithQuantityToInventoryRequest> _parser;

		// Token: 0x04001E0B RID: 7691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E0C RID: 7692
		public const int ObjectsFieldNumber = 1;

		// Token: 0x04001E0D RID: 7693
		private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_objects_codec;

		// Token: 0x04001E0E RID: 7694
		private readonly RepeatedField<ObjectUidWithQuantity> objects_;

		// Token: 0x04001E0F RID: 7695
		internal static ExchangeObjectTransferListWithQuantityToInventoryRequest wSetQfOMB1JmksaSy6Ei;
	}
}
