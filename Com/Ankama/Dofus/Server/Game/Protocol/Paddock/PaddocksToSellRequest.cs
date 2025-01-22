using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x0200030F RID: 783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddocksToSellRequest : IMessage<PaddocksToSellRequest>, IMessage, IEquatable<PaddocksToSellRequest>, IDeepCloneable<PaddocksToSellRequest>, IBufferMessage
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x001C0318 File Offset: 0x001BE518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddocksToSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x001C0328 File Offset: 0x001BE528
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x001C0338 File Offset: 0x001BE538
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

		// Token: 0x060024C0 RID: 9408 RVA: 0x001C0348 File Offset: 0x001BE548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellRequest()
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x001C0358 File Offset: 0x001BE558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellRequest(PaddocksToSellRequest other)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x001C0368 File Offset: 0x001BE568
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellRequest Clone()
		{
			return null;
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x001C0378 File Offset: 0x001BE578
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x001C0388 File Offset: 0x001BE588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PageIndex
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

		// Token: 0x060024C5 RID: 9413 RVA: 0x001C0398 File Offset: 0x001BE598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x001C03A8 File Offset: 0x001BE5A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddocksToSellRequest other)
		{
			return true;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x001C03B8 File Offset: 0x001BE5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x001C03C8 File Offset: 0x001BE5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x001C03D8 File Offset: 0x001BE5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x001C03E8 File Offset: 0x001BE5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x001C03F8 File Offset: 0x001BE5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x001C0408 File Offset: 0x001BE608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddocksToSellRequest other)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x001C0418 File Offset: 0x001BE618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x001C0428 File Offset: 0x001BE628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x001C0438 File Offset: 0x001BE638
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddocksToSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PaddocksToSellRequest._parser = new MessageParser<PaddocksToSellRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x001C0530 File Offset: 0x001BE730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dMtsoZOWGpvHXaO55nCp()
		{
			return true;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x001C0538 File Offset: 0x001BE738
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddocksToSellRequest ko9CpeOWgQemc3xay2aH()
		{
			return null;
		}

		// Token: 0x04000D0D RID: 3341
		private static readonly MessageParser<PaddocksToSellRequest> _parser;

		// Token: 0x04000D0E RID: 3342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D0F RID: 3343
		public const int PageIndexFieldNumber = 1;

		// Token: 0x04000D10 RID: 3344
		private int pageIndex_;

		// Token: 0x04000D11 RID: 3345
		internal static PaddocksToSellRequest cvmSLmOWJh7NaQ8yTa87;
	}
}
