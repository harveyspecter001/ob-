using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000457 RID: 1111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseBuyRequest : IMessage<HouseBuyRequest>, IMessage, IEquatable<HouseBuyRequest>, IDeepCloneable<HouseBuyRequest>, IBufferMessage
	{
		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x001DB478 File Offset: 0x001D9678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseBuyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x001DB488 File Offset: 0x001D9688
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x001DB498 File Offset: 0x001D9698
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

		// Token: 0x060034DB RID: 13531 RVA: 0x001DB4A8 File Offset: 0x001D96A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyRequest()
		{
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x001DB4B8 File Offset: 0x001D96B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyRequest(HouseBuyRequest other)
		{
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x001DB4C8 File Offset: 0x001D96C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseBuyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x001DB4D8 File Offset: 0x001D96D8
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x001DB4E8 File Offset: 0x001D96E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ProposedPrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x001DB4F8 File Offset: 0x001D96F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x001DB508 File Offset: 0x001D9708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseBuyRequest other)
		{
			return true;
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x001DB518 File Offset: 0x001D9718
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x001DB528 File Offset: 0x001D9728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x001DB538 File Offset: 0x001D9738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x001DB548 File Offset: 0x001D9748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x001DB558 File Offset: 0x001D9758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x001DB568 File Offset: 0x001D9768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseBuyRequest other)
		{
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x001DB578 File Offset: 0x001D9778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x001DB588 File Offset: 0x001D9788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x001DB598 File Offset: 0x001D9798
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseBuyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				HouseBuyRequest._parser = new MessageParser<HouseBuyRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x001DB664 File Offset: 0x001D9864
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JLgKkGOtOPRxMI32KgnN()
		{
			return true;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x001DB66C File Offset: 0x001D986C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseBuyRequest uak45MOtJKNA1Ze5gqfT()
		{
			return null;
		}

		// Token: 0x04001276 RID: 4726
		private static readonly MessageParser<HouseBuyRequest> _parser;

		// Token: 0x04001277 RID: 4727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001278 RID: 4728
		public const int ProposedPriceFieldNumber = 1;

		// Token: 0x04001279 RID: 4729
		private long proposedPrice_;

		// Token: 0x0400127A RID: 4730
		private static HouseBuyRequest TXAOgcOtR8PGPw3t72WP;
	}
}
