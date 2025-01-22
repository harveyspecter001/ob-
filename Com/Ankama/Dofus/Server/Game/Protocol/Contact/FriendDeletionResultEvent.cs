using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000852 RID: 2130
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendDeletionResultEvent : IMessage<FriendDeletionResultEvent>, IMessage, IEquatable<FriendDeletionResultEvent>, IDeepCloneable<FriendDeletionResultEvent>, IBufferMessage
	{
		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x0022D284 File Offset: 0x0022B484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendDeletionResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x0022D294 File Offset: 0x0022B494
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

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x0022D2A4 File Offset: 0x0022B4A4
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

		// Token: 0x06006793 RID: 26515 RVA: 0x0022D2B4 File Offset: 0x0022B4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeletionResultEvent()
		{
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x0022D2C4 File Offset: 0x0022B4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeletionResultEvent(FriendDeletionResultEvent other)
		{
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x0022D2D4 File Offset: 0x0022B4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendDeletionResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x0022D2E4 File Offset: 0x0022B4E4
		// (set) Token: 0x06006797 RID: 26519 RVA: 0x0022D2F4 File Offset: 0x0022B4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x0022D304 File Offset: 0x0022B504
		// (set) Token: 0x06006799 RID: 26521 RVA: 0x0022D314 File Offset: 0x0022B514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AccountTag AccountTag
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

		// Token: 0x0600679A RID: 26522 RVA: 0x0022D324 File Offset: 0x0022B524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x0022D334 File Offset: 0x0022B534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendDeletionResultEvent other)
		{
			return true;
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x0022D344 File Offset: 0x0022B544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x0022D354 File Offset: 0x0022B554
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x0022D364 File Offset: 0x0022B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x0022D374 File Offset: 0x0022B574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x0022D384 File Offset: 0x0022B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x0022D394 File Offset: 0x0022B594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendDeletionResultEvent other)
		{
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x0022D3A4 File Offset: 0x0022B5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x0022D3B4 File Offset: 0x0022B5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x0022D3C4 File Offset: 0x0022B5C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendDeletionResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				FriendDeletionResultEvent._parser = new MessageParser<FriendDeletionResultEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x0022D490 File Offset: 0x0022B690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EY055sJnEcvsLqP97Zq7()
		{
			return true;
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x0022D498 File Offset: 0x0022B698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendDeletionResultEvent hkGAqNJnXQSETar4qtga()
		{
			return null;
		}

		// Token: 0x04002444 RID: 9284
		private static readonly MessageParser<FriendDeletionResultEvent> _parser;

		// Token: 0x04002445 RID: 9285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002446 RID: 9286
		public const int SuccessFieldNumber = 1;

		// Token: 0x04002447 RID: 9287
		private bool success_;

		// Token: 0x04002448 RID: 9288
		public const int AccountTagFieldNumber = 2;

		// Token: 0x04002449 RID: 9289
		private AccountTag accountTag_;

		// Token: 0x0400244A RID: 9290
		internal static FriendDeletionResultEvent ftQnCbJn2LTElgk7axll;
	}
}
