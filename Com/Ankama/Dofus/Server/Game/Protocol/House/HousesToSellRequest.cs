using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x0200045B RID: 1115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HousesToSellRequest : IMessage<HousesToSellRequest>, IMessage, IEquatable<HousesToSellRequest>, IDeepCloneable<HousesToSellRequest>, IBufferMessage
	{
		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x001DB88C File Offset: 0x001D9A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HousesToSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x001DB89C File Offset: 0x001D9A9C
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x001DB8AC File Offset: 0x001D9AAC
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

		// Token: 0x0600350F RID: 13583 RVA: 0x001DB8BC File Offset: 0x001D9ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellRequest()
		{
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x001DB8CC File Offset: 0x001D9ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellRequest(HousesToSellRequest other)
		{
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x001DB8DC File Offset: 0x001D9ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellRequest Clone()
		{
			return null;
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x001DB8EC File Offset: 0x001D9AEC
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x001DB8FC File Offset: 0x001D9AFC
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

		// Token: 0x06003514 RID: 13588 RVA: 0x001DB90C File Offset: 0x001D9B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x001DB91C File Offset: 0x001D9B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HousesToSellRequest other)
		{
			return true;
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x001DB92C File Offset: 0x001D9B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x001DB93C File Offset: 0x001D9B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x001DB94C File Offset: 0x001D9B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x001DB95C File Offset: 0x001D9B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x001DB96C File Offset: 0x001D9B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x001DB97C File Offset: 0x001D9B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HousesToSellRequest other)
		{
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x001DB98C File Offset: 0x001D9B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x001DB99C File Offset: 0x001D9B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x001DB9AC File Offset: 0x001D9BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HousesToSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				HousesToSellRequest._parser = new MessageParser<HousesToSellRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x001DBA90 File Offset: 0x001D9C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SekcoHOt9YrxWChApifj()
		{
			return true;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x001DBA98 File Offset: 0x001D9C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HousesToSellRequest FKPmeeOt2vuaE60MtpY6()
		{
			return null;
		}

		// Token: 0x04001284 RID: 4740
		private static readonly MessageParser<HousesToSellRequest> _parser;

		// Token: 0x04001285 RID: 4741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001286 RID: 4742
		public const int PageIndexFieldNumber = 1;

		// Token: 0x04001287 RID: 4743
		private int pageIndex_;

		// Token: 0x04001288 RID: 4744
		internal static HousesToSellRequest TfjecKOtdpGv2GA1dcTG;
	}
}
