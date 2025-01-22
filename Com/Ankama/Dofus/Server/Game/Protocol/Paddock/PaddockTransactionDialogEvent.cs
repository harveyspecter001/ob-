using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x0200031D RID: 797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockTransactionDialogEvent : IMessage<PaddockTransactionDialogEvent>, IMessage, IEquatable<PaddockTransactionDialogEvent>, IDeepCloneable<PaddockTransactionDialogEvent>, IBufferMessage
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x001C124C File Offset: 0x001BF44C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockTransactionDialogEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x001C125C File Offset: 0x001BF45C
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

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x001C126C File Offset: 0x001BF46C
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

		// Token: 0x06002581 RID: 9601 RVA: 0x001C127C File Offset: 0x001BF47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockTransactionDialogEvent()
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x001C128C File Offset: 0x001BF48C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockTransactionDialogEvent(PaddockTransactionDialogEvent other)
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x001C129C File Offset: 0x001BF49C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockTransactionDialogEvent Clone()
		{
			return null;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x001C12AC File Offset: 0x001BF4AC
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x001C12C0 File Offset: 0x001BF4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PaddockTransactionDialogEvent.Types.Transaction Transaction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PaddockTransactionDialogEvent.Types.Transaction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x001C12D0 File Offset: 0x001BF4D0
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x001C12E0 File Offset: 0x001BF4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerId
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x001C12F0 File Offset: 0x001BF4F0
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x001C1300 File Offset: 0x001BF500
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

		// Token: 0x0600258A RID: 9610 RVA: 0x001C1310 File Offset: 0x001BF510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x001C1320 File Offset: 0x001BF520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockTransactionDialogEvent other)
		{
			return true;
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x001C1330 File Offset: 0x001BF530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x001C1340 File Offset: 0x001BF540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x001C1350 File Offset: 0x001BF550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x001C1360 File Offset: 0x001BF560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x001C1370 File Offset: 0x001BF570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x001C1380 File Offset: 0x001BF580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockTransactionDialogEvent other)
		{
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x001C1390 File Offset: 0x001BF590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x001C13A0 File Offset: 0x001BF5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x001C13B0 File Offset: 0x001BF5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockTransactionDialogEvent()
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
					PaddockTransactionDialogEvent._parser = new MessageParser<PaddockTransactionDialogEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x001C1494 File Offset: 0x001BF694
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool plvussOWawNsK4bUSRjZ()
		{
			return true;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x001C149C File Offset: 0x001BF69C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockTransactionDialogEvent OrgQdTOW5tiHLIOpkstc()
		{
			return null;
		}

		// Token: 0x04000D4B RID: 3403
		private static readonly MessageParser<PaddockTransactionDialogEvent> _parser;

		// Token: 0x04000D4C RID: 3404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D4D RID: 3405
		public const int TransactionFieldNumber = 1;

		// Token: 0x04000D4E RID: 3406
		private PaddockTransactionDialogEvent.Types.Transaction transaction_;

		// Token: 0x04000D4F RID: 3407
		public const int OwnerIdFieldNumber = 2;

		// Token: 0x04000D50 RID: 3408
		private int ownerId_;

		// Token: 0x04000D51 RID: 3409
		public const int PriceFieldNumber = 3;

		// Token: 0x04000D52 RID: 3410
		private long price_;

		// Token: 0x04000D53 RID: 3411
		private static PaddockTransactionDialogEvent i4NDQYOW1uGa9LH0wPPd;

		// Token: 0x0200031E RID: 798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002597 RID: 9623 RVA: 0x002B7430 File Offset: 0x002B5630
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200031F RID: 799
			public enum Transaction
			{
				// Token: 0x04000D55 RID: 3413
				[OriginalName("BUY")]
				Buy,
				// Token: 0x04000D56 RID: 3414
				[OriginalName("SELL")]
				Sell
			}
		}
	}
}
