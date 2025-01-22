using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BEC RID: 3052
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakTransactionValidationRequest : IMessage<BakTransactionValidationRequest>, IMessage, IEquatable<BakTransactionValidationRequest>, IDeepCloneable<BakTransactionValidationRequest>, IBufferMessage
	{
		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x00272450 File Offset: 0x00270650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakTransactionValidationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x060092DE RID: 37598 RVA: 0x00272460 File Offset: 0x00270660
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

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x060092DF RID: 37599 RVA: 0x00272470 File Offset: 0x00270670
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

		// Token: 0x060092E0 RID: 37600 RVA: 0x00272480 File Offset: 0x00270680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationRequest()
		{
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x00272490 File Offset: 0x00270690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationRequest(BakTransactionValidationRequest other)
		{
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x002724A0 File Offset: 0x002706A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakTransactionValidationRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x002724B0 File Offset: 0x002706B0
		// (set) Token: 0x060092E4 RID: 37604 RVA: 0x002724C0 File Offset: 0x002706C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TransactionUuid
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

		// Token: 0x060092E5 RID: 37605 RVA: 0x002724D0 File Offset: 0x002706D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x002724E0 File Offset: 0x002706E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakTransactionValidationRequest other)
		{
			return true;
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x002724F0 File Offset: 0x002706F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x00272500 File Offset: 0x00270700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060092E9 RID: 37609 RVA: 0x00272510 File Offset: 0x00270710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x00272520 File Offset: 0x00270720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00272530 File Offset: 0x00270730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00272540 File Offset: 0x00270740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakTransactionValidationRequest other)
		{
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00272550 File Offset: 0x00270750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00272560 File Offset: 0x00270760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00272570 File Offset: 0x00270770
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakTransactionValidationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_86;
					case 3:
						return;
					case 4:
						goto IL_5E;
					}
				}
				IL_5E:
				BakTransactionValidationRequest._parser = new MessageParser<BakTransactionValidationRequest>(() => null);
				num = 3;
				continue;
				IL_86:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x00272644 File Offset: 0x00270844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IAmSSsJEadRRIcovkO6i()
		{
			return true;
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x0027264C File Offset: 0x0027084C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakTransactionValidationRequest MJ8t2lJE5jf04jKvaw3f()
		{
			return null;
		}

		// Token: 0x040036AF RID: 13999
		private static readonly MessageParser<BakTransactionValidationRequest> _parser;

		// Token: 0x040036B0 RID: 14000
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B1 RID: 14001
		public const int TransactionUuidFieldNumber = 1;

		// Token: 0x040036B2 RID: 14002
		private string transactionUuid_;

		// Token: 0x040036B3 RID: 14003
		internal static BakTransactionValidationRequest L6ZYYQJE1fT3pQ9YgPNW;
	}
}
