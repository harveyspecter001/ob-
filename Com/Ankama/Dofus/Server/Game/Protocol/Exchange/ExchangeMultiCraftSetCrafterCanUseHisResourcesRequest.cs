using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006E4 RID: 1764
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest : IMessage<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IMessage, IEquatable<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IDeepCloneable<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IBufferMessage
	{
		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06005648 RID: 22088 RVA: 0x00213874 File Offset: 0x00211A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06005649 RID: 22089 RVA: 0x00213884 File Offset: 0x00211A84
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x00213894 File Offset: 0x00211A94
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

		// Token: 0x0600564B RID: 22091 RVA: 0x002138A4 File Offset: 0x00211AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest()
		{
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x002138B4 File Offset: 0x00211AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
		{
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x002138C4 File Offset: 0x00211AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x002138D4 File Offset: 0x00211AD4
		// (set) Token: 0x0600564F RID: 22095 RVA: 0x002138E4 File Offset: 0x00211AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Allow
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

		// Token: 0x06005650 RID: 22096 RVA: 0x002138F4 File Offset: 0x00211AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00213904 File Offset: 0x00211B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
		{
			return true;
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00213914 File Offset: 0x00211B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00213924 File Offset: 0x00211B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00213934 File Offset: 0x00211B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00213944 File Offset: 0x00211B44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00213954 File Offset: 0x00211B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00213964 File Offset: 0x00211B64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00213974 File Offset: 0x00211B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00213984 File Offset: 0x00211B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00213994 File Offset: 0x00211B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest._parser = new MessageParser<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00213A8C File Offset: 0x00211C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p70komOM5f9pgRijNSq1()
		{
			return true;
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00213A94 File Offset: 0x00211C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest AWI6HOOMysLqCRvP3XfQ()
		{
			return null;
		}

		// Token: 0x04001E43 RID: 7747
		private static readonly MessageParser<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest> _parser;

		// Token: 0x04001E44 RID: 7748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E45 RID: 7749
		public const int AllowFieldNumber = 1;

		// Token: 0x04001E46 RID: 7750
		private bool allow_;

		// Token: 0x04001E47 RID: 7751
		internal static ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest O4xi7AOMaSIT9oG8kqPb;
	}
}
