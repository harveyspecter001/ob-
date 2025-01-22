using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200070D RID: 1805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHousePriceRequest : IMessage<ExchangeBidHousePriceRequest>, IMessage, IEquatable<ExchangeBidHousePriceRequest>, IDeepCloneable<ExchangeBidHousePriceRequest>, IBufferMessage
	{
		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x0600584D RID: 22605 RVA: 0x00215F20 File Offset: 0x00214120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHousePriceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x00215F30 File Offset: 0x00214130
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x0600584F RID: 22607 RVA: 0x00215F40 File Offset: 0x00214140
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

		// Token: 0x06005850 RID: 22608 RVA: 0x00215F50 File Offset: 0x00214150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHousePriceRequest()
		{
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00215F60 File Offset: 0x00214160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHousePriceRequest(ExchangeBidHousePriceRequest other)
		{
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00215F70 File Offset: 0x00214170
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHousePriceRequest Clone()
		{
			return null;
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x00215F80 File Offset: 0x00214180
		// (set) Token: 0x06005854 RID: 22612 RVA: 0x00215F90 File Offset: 0x00214190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x06005855 RID: 22613 RVA: 0x00215FA0 File Offset: 0x002141A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00215FB0 File Offset: 0x002141B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHousePriceRequest other)
		{
			return true;
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00215FC0 File Offset: 0x002141C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00215FD0 File Offset: 0x002141D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x00215FE0 File Offset: 0x002141E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x00215FF0 File Offset: 0x002141F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x00216000 File Offset: 0x00214200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x00216010 File Offset: 0x00214210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHousePriceRequest other)
		{
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x00216020 File Offset: 0x00214220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x00216030 File Offset: 0x00214230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x00216040 File Offset: 0x00214240
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHousePriceRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeBidHousePriceRequest._parser = new MessageParser<ExchangeBidHousePriceRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x0021610C File Offset: 0x0021430C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pn7UaYOukWmRXAZTKQ8U()
		{
			return true;
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00216114 File Offset: 0x00214314
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHousePriceRequest S4u3TmOulim9dE01eoH8()
		{
			return null;
		}

		// Token: 0x04001EF7 RID: 7927
		private static readonly MessageParser<ExchangeBidHousePriceRequest> _parser;

		// Token: 0x04001EF8 RID: 7928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EF9 RID: 7929
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001EFA RID: 7930
		private int objectGid_;

		// Token: 0x04001EFB RID: 7931
		private static ExchangeBidHousePriceRequest sNgFEtOuI8X0tuw64k2G;
	}
}
