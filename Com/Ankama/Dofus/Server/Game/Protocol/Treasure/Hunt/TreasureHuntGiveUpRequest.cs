using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x0200003E RID: 62
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntGiveUpRequest : IMessage<TreasureHuntGiveUpRequest>, IMessage, IEquatable<TreasureHuntGiveUpRequest>, IDeepCloneable<TreasureHuntGiveUpRequest>, IBufferMessage
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000250 RID: 592 RVA: 0x001871E0 File Offset: 0x001853E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureHuntGiveUpRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000251 RID: 593 RVA: 0x001871F0 File Offset: 0x001853F0
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00187200 File Offset: 0x00185400
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

		// Token: 0x06000253 RID: 595 RVA: 0x00187210 File Offset: 0x00185410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntGiveUpRequest()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00187220 File Offset: 0x00185420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntGiveUpRequest(TreasureHuntGiveUpRequest other)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00187230 File Offset: 0x00185430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntGiveUpRequest Clone()
		{
			return null;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00187240 File Offset: 0x00185440
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00187254 File Offset: 0x00185454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TreasureHuntType QuestType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00187264 File Offset: 0x00185464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00187274 File Offset: 0x00185474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntGiveUpRequest other)
		{
			return true;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00187284 File Offset: 0x00185484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00187294 File Offset: 0x00185494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x001872A4 File Offset: 0x001854A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x001872B4 File Offset: 0x001854B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x001872C4 File Offset: 0x001854C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x001872D4 File Offset: 0x001854D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntGiveUpRequest other)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x001872E4 File Offset: 0x001854E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x001872F4 File Offset: 0x001854F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00187304 File Offset: 0x00185504
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntGiveUpRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 1;
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
				TreasureHuntGiveUpRequest._parser = new MessageParser<TreasureHuntGiveUpRequest>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x001873E8 File Offset: 0x001855E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DgMlwBOjhgFmVCVImEX0()
		{
			return true;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x001873F0 File Offset: 0x001855F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntGiveUpRequest x6gPO2OjrCWlMwKaQBZb()
		{
			return null;
		}

		// Token: 0x040000F0 RID: 240
		private static readonly MessageParser<TreasureHuntGiveUpRequest> _parser;

		// Token: 0x040000F1 RID: 241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000F2 RID: 242
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x040000F3 RID: 243
		private TreasureHuntType questType_;

		// Token: 0x040000F4 RID: 244
		private static TreasureHuntGiveUpRequest bRe3VtOjWF4UI0Ao2Tga;
	}
}
