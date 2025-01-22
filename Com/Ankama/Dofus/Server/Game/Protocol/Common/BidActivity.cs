using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x0200099C RID: 2460
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BidActivity : IMessage<BidActivity>, IMessage, IEquatable<BidActivity>, IDeepCloneable<BidActivity>, IBufferMessage
	{
		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06007712 RID: 30482 RVA: 0x0024543C File Offset: 0x0024363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BidActivity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06007713 RID: 30483 RVA: 0x0024544C File Offset: 0x0024364C
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

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x0024545C File Offset: 0x0024365C
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

		// Token: 0x06007715 RID: 30485 RVA: 0x0024546C File Offset: 0x0024366C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivity()
		{
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x0024547C File Offset: 0x0024367C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivity(BidActivity other)
		{
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x0024548C File Offset: 0x0024368C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidActivity Clone()
		{
			return null;
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x0024549C File Offset: 0x0024369C
		// (set) Token: 0x06007719 RID: 30489 RVA: 0x002454AC File Offset: 0x002436AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BidId
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

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x0600771A RID: 30490 RVA: 0x002454BC File Offset: 0x002436BC
		// (set) Token: 0x0600771B RID: 30491 RVA: 0x002454D0 File Offset: 0x002436D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BidActivity.Types.Type Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BidActivity.Types.Type)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600771C RID: 30492 RVA: 0x002454E0 File Offset: 0x002436E0
		// (set) Token: 0x0600771D RID: 30493 RVA: 0x002454F0 File Offset: 0x002436F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CreatedAt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00245500 File Offset: 0x00243700
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x00245510 File Offset: 0x00243710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemMinimalInformation Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x00245520 File Offset: 0x00243720
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x00245530 File Offset: 0x00243730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
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

		// Token: 0x06007722 RID: 30498 RVA: 0x00245540 File Offset: 0x00243740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00245550 File Offset: 0x00243750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BidActivity other)
		{
			return true;
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00245560 File Offset: 0x00243760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00245570 File Offset: 0x00243770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00245580 File Offset: 0x00243780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00245590 File Offset: 0x00243790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x002455A0 File Offset: 0x002437A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x002455B0 File Offset: 0x002437B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BidActivity other)
		{
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x002455C0 File Offset: 0x002437C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x002455D0 File Offset: 0x002437D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x002455E0 File Offset: 0x002437E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BidActivity()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BidActivity._parser = new MessageParser<BidActivity>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x002456AC File Offset: 0x002438AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wKJZAIJO9neTBCjkjL2y()
		{
			return true;
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x002456B4 File Offset: 0x002438B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BidActivity p2tegQJO2gDt3NOZLR3g()
		{
			return null;
		}

		// Token: 0x04002966 RID: 10598
		private static readonly MessageParser<BidActivity> _parser;

		// Token: 0x04002967 RID: 10599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002968 RID: 10600
		public const int BidIdFieldNumber = 1;

		// Token: 0x04002969 RID: 10601
		private int bidId_;

		// Token: 0x0400296A RID: 10602
		public const int TypeFieldNumber = 2;

		// Token: 0x0400296B RID: 10603
		private BidActivity.Types.Type type_;

		// Token: 0x0400296C RID: 10604
		public const int CreatedAtFieldNumber = 3;

		// Token: 0x0400296D RID: 10605
		private string createdAt_;

		// Token: 0x0400296E RID: 10606
		public const int ObjectFieldNumber = 4;

		// Token: 0x0400296F RID: 10607
		private ItemMinimalInformation object_;

		// Token: 0x04002970 RID: 10608
		public const int PriceFieldNumber = 5;

		// Token: 0x04002971 RID: 10609
		private long price_;

		// Token: 0x04002972 RID: 10610
		private static BidActivity jM4OuvJOdUABpZCuHkY7;

		// Token: 0x0200099D RID: 2461
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600772F RID: 30511 RVA: 0x002DEAE4 File Offset: 0x002DCCE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200099E RID: 2462
			public enum Type
			{
				// Token: 0x04002974 RID: 10612
				[OriginalName("SELL")]
				Sell,
				// Token: 0x04002975 RID: 10613
				[OriginalName("BUY")]
				Buy,
				// Token: 0x04002976 RID: 10614
				[OriginalName("EXPIRE")]
				Expire
			}
		}
	}
}
