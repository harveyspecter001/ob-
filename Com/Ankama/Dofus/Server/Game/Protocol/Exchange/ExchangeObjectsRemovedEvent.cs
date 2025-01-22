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
	// Token: 0x0200071B RID: 1819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectsRemovedEvent : IMessage<ExchangeObjectsRemovedEvent>, IMessage, IEquatable<ExchangeObjectsRemovedEvent>, IDeepCloneable<ExchangeObjectsRemovedEvent>, IBufferMessage
	{
		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06005908 RID: 22792 RVA: 0x00216E38 File Offset: 0x00215038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectsRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06005909 RID: 22793 RVA: 0x00216E48 File Offset: 0x00215048
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x00216E58 File Offset: 0x00215058
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

		// Token: 0x0600590B RID: 22795 RVA: 0x00216E68 File Offset: 0x00215068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsRemovedEvent()
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00216E78 File Offset: 0x00215078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsRemovedEvent(ExchangeObjectsRemovedEvent other)
		{
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00216E88 File Offset: 0x00215088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x00216E98 File Offset: 0x00215098
		// (set) Token: 0x0600590F RID: 22799 RVA: 0x00216EA8 File Offset: 0x002150A8
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06005910 RID: 22800 RVA: 0x00216EB8 File Offset: 0x002150B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BidItemsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00216EC8 File Offset: 0x002150C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00216ED8 File Offset: 0x002150D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectsRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x00216EE8 File Offset: 0x002150E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00216EF8 File Offset: 0x002150F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00216F08 File Offset: 0x00215108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00216F18 File Offset: 0x00215118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00216F28 File Offset: 0x00215128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00216F38 File Offset: 0x00215138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectsRemovedEvent other)
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00216F48 File Offset: 0x00215148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00216F58 File Offset: 0x00215158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00216F68 File Offset: 0x00215168
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectsRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					ExchangeObjectsRemovedEvent._parser = new MessageParser<ExchangeObjectsRemovedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ExchangeObjectsRemovedEvent._repeated_bidItemsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00217068 File Offset: 0x00215268
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AOONU0OuQfHhUM6bs71I()
		{
			return true;
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00217070 File Offset: 0x00215270
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectsRemovedEvent U2skoZOu7heVZ7XLgSII()
		{
			return null;
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly MessageParser<ExchangeObjectsRemovedEvent> _parser;

		// Token: 0x04001F30 RID: 7984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F31 RID: 7985
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F32 RID: 7986
		private bool remote_;

		// Token: 0x04001F33 RID: 7987
		public const int BidItemsUidFieldNumber = 2;

		// Token: 0x04001F34 RID: 7988
		private static readonly FieldCodec<int> _repeated_bidItemsUid_codec;

		// Token: 0x04001F35 RID: 7989
		private readonly RepeatedField<int> bidItemsUid_;

		// Token: 0x04001F36 RID: 7990
		internal static ExchangeObjectsRemovedEvent hnXGMHOuw7yjdALRcOvU;
	}
}
