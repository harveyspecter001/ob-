using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001CB RID: 459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismAttackRequest : IMessage<PrismAttackRequest>, IMessage, IEquatable<PrismAttackRequest>, IDeepCloneable<PrismAttackRequest>, IBufferMessage
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x001A6F48 File Offset: 0x001A5148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismAttackRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x001A6F58 File Offset: 0x001A5158
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x001A6F68 File Offset: 0x001A5168
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

		// Token: 0x0600156D RID: 5485 RVA: 0x001A6F78 File Offset: 0x001A5178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackRequest()
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x001A6F88 File Offset: 0x001A5188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackRequest(PrismAttackRequest other)
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x001A6F98 File Offset: 0x001A5198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackRequest Clone()
		{
			return null;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x001A6FA8 File Offset: 0x001A51A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x001A6FB8 File Offset: 0x001A51B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismAttackRequest other)
		{
			return true;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x001A6FC8 File Offset: 0x001A51C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x001A6FD8 File Offset: 0x001A51D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x001A6FE8 File Offset: 0x001A51E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x001A6FF8 File Offset: 0x001A51F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x001A7008 File Offset: 0x001A5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x001A7018 File Offset: 0x001A5218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismAttackRequest other)
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x001A7028 File Offset: 0x001A5228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x001A7038 File Offset: 0x001A5238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x001A7048 File Offset: 0x001A5248
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismAttackRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PrismAttackRequest._parser = new MessageParser<PrismAttackRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x001A712C File Offset: 0x001A532C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TeI0bjO1dDNFcvZZeNmP()
		{
			return true;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x001A7134 File Offset: 0x001A5334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismAttackRequest H4kAvrO19xV3E4dSR6HI()
		{
			return null;
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly MessageParser<PrismAttackRequest> _parser;

		// Token: 0x040007A3 RID: 1955
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007A4 RID: 1956
		internal static PrismAttackRequest l50g5TO1s5QMReI2F6Dr;
	}
}
