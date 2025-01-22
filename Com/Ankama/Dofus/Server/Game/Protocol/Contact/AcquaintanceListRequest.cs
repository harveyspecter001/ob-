using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000842 RID: 2114
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceListRequest : IMessage<AcquaintanceListRequest>, IMessage, IEquatable<AcquaintanceListRequest>, IDeepCloneable<AcquaintanceListRequest>, IBufferMessage
	{
		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x0022C194 File Offset: 0x0022A394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AcquaintanceListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060066BD RID: 26301 RVA: 0x0022C1A4 File Offset: 0x0022A3A4
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x0022C1B4 File Offset: 0x0022A3B4
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

		// Token: 0x060066BF RID: 26303 RVA: 0x0022C1C4 File Offset: 0x0022A3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListRequest()
		{
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x0022C1D4 File Offset: 0x0022A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListRequest(AcquaintanceListRequest other)
		{
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x0022C1E4 File Offset: 0x0022A3E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceListRequest Clone()
		{
			return null;
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0022C1F4 File Offset: 0x0022A3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x0022C204 File Offset: 0x0022A404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceListRequest other)
		{
			return true;
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x0022C214 File Offset: 0x0022A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x0022C224 File Offset: 0x0022A424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x0022C234 File Offset: 0x0022A434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x0022C244 File Offset: 0x0022A444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x0022C254 File Offset: 0x0022A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x0022C264 File Offset: 0x0022A464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceListRequest other)
		{
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x0022C274 File Offset: 0x0022A474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x0022C284 File Offset: 0x0022A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x0022C294 File Offset: 0x0022A494
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AcquaintanceListRequest._parser = new MessageParser<AcquaintanceListRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x0022C360 File Offset: 0x0022A560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hMhfS6JfSLu8lQMrV2pE()
		{
			return true;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x0022C368 File Offset: 0x0022A568
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceListRequest GetIACJfMN7Jk18jjjnl()
		{
			return null;
		}

		// Token: 0x04002408 RID: 9224
		private static readonly MessageParser<AcquaintanceListRequest> _parser;

		// Token: 0x04002409 RID: 9225
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400240A RID: 9226
		internal static AcquaintanceListRequest RxpqQ1JfPYLb7egN4gHv;
	}
}
