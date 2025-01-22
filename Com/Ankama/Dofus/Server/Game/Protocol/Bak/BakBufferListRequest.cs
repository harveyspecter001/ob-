using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BDE RID: 3038
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakBufferListRequest : IMessage<BakBufferListRequest>, IMessage, IEquatable<BakBufferListRequest>, IDeepCloneable<BakBufferListRequest>, IBufferMessage
	{
		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x00271728 File Offset: 0x0026F928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BakBufferListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06009236 RID: 37430 RVA: 0x00271738 File Offset: 0x0026F938
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

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06009237 RID: 37431 RVA: 0x00271748 File Offset: 0x0026F948
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

		// Token: 0x06009238 RID: 37432 RVA: 0x00271758 File Offset: 0x0026F958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListRequest()
		{
		}

		// Token: 0x06009239 RID: 37433 RVA: 0x00271768 File Offset: 0x0026F968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListRequest(BakBufferListRequest other)
		{
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00271778 File Offset: 0x0026F978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBufferListRequest Clone()
		{
			return null;
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00271788 File Offset: 0x0026F988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00271798 File Offset: 0x0026F998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakBufferListRequest other)
		{
			return true;
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x002717A8 File Offset: 0x0026F9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x002717B8 File Offset: 0x0026F9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x002717C8 File Offset: 0x0026F9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x002717D8 File Offset: 0x0026F9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x002717E8 File Offset: 0x0026F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x002717F8 File Offset: 0x0026F9F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakBufferListRequest other)
		{
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00271808 File Offset: 0x0026FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00271818 File Offset: 0x0026FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00271828 File Offset: 0x0026FA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakBufferListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BakBufferListRequest._parser = new MessageParser<BakBufferListRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
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
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x002718F4 File Offset: 0x0026FAF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qJAGuCJEdXNdKgSyqGt9()
		{
			return true;
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x002718FC File Offset: 0x0026FAFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakBufferListRequest QNVAKFJE9eIe6cfBCXSa()
		{
			return null;
		}

		// Token: 0x04003674 RID: 13940
		private static readonly MessageParser<BakBufferListRequest> _parser;

		// Token: 0x04003675 RID: 13941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003676 RID: 13942
		private static BakBufferListRequest kWjZo6JEsWsIHbp2CV2I;
	}
}
