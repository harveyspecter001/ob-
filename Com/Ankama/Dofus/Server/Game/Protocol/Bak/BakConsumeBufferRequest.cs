using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BE2 RID: 3042
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakConsumeBufferRequest : IMessage<BakConsumeBufferRequest>, IMessage, IEquatable<BakConsumeBufferRequest>, IDeepCloneable<BakConsumeBufferRequest>, IBufferMessage
	{
		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06009266 RID: 37478 RVA: 0x00271B44 File Offset: 0x0026FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakConsumeBufferRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06009267 RID: 37479 RVA: 0x00271B54 File Offset: 0x0026FD54
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

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06009268 RID: 37480 RVA: 0x00271B64 File Offset: 0x0026FD64
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

		// Token: 0x06009269 RID: 37481 RVA: 0x00271B74 File Offset: 0x0026FD74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakConsumeBufferRequest()
		{
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00271B84 File Offset: 0x0026FD84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakConsumeBufferRequest(BakConsumeBufferRequest other)
		{
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x00271B94 File Offset: 0x0026FD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakConsumeBufferRequest Clone()
		{
			return null;
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x00271BA4 File Offset: 0x0026FDA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x00271BB4 File Offset: 0x0026FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakConsumeBufferRequest other)
		{
			return true;
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x00271BC4 File Offset: 0x0026FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00271BD4 File Offset: 0x0026FDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00271BE4 File Offset: 0x0026FDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x00271BF4 File Offset: 0x0026FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x00271C04 File Offset: 0x0026FE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x00271C14 File Offset: 0x0026FE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakConsumeBufferRequest other)
		{
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x00271C24 File Offset: 0x0026FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x00271C34 File Offset: 0x0026FE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00271C44 File Offset: 0x0026FE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakConsumeBufferRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				BakConsumeBufferRequest._parser = new MessageParser<BakConsumeBufferRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x00271D10 File Offset: 0x0026FF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i95EvPJExjomlaZmt8Jw()
		{
			return true;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00271D18 File Offset: 0x0026FF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakConsumeBufferRequest qOsQ4xJE4CvwmMxYwgkT()
		{
			return null;
		}

		// Token: 0x04003681 RID: 13953
		private static readonly MessageParser<BakConsumeBufferRequest> _parser;

		// Token: 0x04003682 RID: 13954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003683 RID: 13955
		internal static BakConsumeBufferRequest yBjKjTJENMFn5KnGFmmI;
	}
}
