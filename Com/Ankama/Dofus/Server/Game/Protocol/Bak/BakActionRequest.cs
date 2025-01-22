using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BE8 RID: 3048
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakActionRequest : IMessage<BakActionRequest>, IMessage, IEquatable<BakActionRequest>, IDeepCloneable<BakActionRequest>, IBufferMessage
	{
		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x00271F58 File Offset: 0x00270158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BakActionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600929C RID: 37532 RVA: 0x00271F68 File Offset: 0x00270168
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

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x00271F78 File Offset: 0x00270178
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

		// Token: 0x0600929E RID: 37534 RVA: 0x00271F88 File Offset: 0x00270188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionRequest()
		{
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00271F98 File Offset: 0x00270198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionRequest(BakActionRequest other)
		{
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x00271FA8 File Offset: 0x002701A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x00271FB8 File Offset: 0x002701B8
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x00271FC8 File Offset: 0x002701C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Kamas
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x00271FD8 File Offset: 0x002701D8
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x00271FE8 File Offset: 0x002701E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Ogrines
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

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x00271FF8 File Offset: 0x002701F8
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x00272008 File Offset: 0x00270208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Rate
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

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x00272018 File Offset: 0x00270218
		// (set) Token: 0x060092A8 RID: 37544 RVA: 0x0027202C File Offset: 0x0027022C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BidAction BidAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BidAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x0027203C File Offset: 0x0027023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x0027204C File Offset: 0x0027024C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakActionRequest other)
		{
			return true;
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x0027205C File Offset: 0x0027025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x0027206C File Offset: 0x0027026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x0027207C File Offset: 0x0027027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x0027208C File Offset: 0x0027028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x0027209C File Offset: 0x0027029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x002720AC File Offset: 0x002702AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakActionRequest other)
		{
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x002720BC File Offset: 0x002702BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x002720CC File Offset: 0x002702CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x002720DC File Offset: 0x002702DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakActionRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					BakActionRequest._parser = new MessageParser<BakActionRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x002721C0 File Offset: 0x002703C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rXG55TJEl0KcS0k40DRm()
		{
			return true;
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x002721C8 File Offset: 0x002703C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakActionRequest FJZO0yJEceBnoS5F2OxP()
		{
			return null;
		}

		// Token: 0x04003693 RID: 13971
		private static readonly MessageParser<BakActionRequest> _parser;

		// Token: 0x04003694 RID: 13972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003695 RID: 13973
		public const int KamasFieldNumber = 1;

		// Token: 0x04003696 RID: 13974
		private long kamas_;

		// Token: 0x04003697 RID: 13975
		public const int OgrinesFieldNumber = 2;

		// Token: 0x04003698 RID: 13976
		private long ogrines_;

		// Token: 0x04003699 RID: 13977
		public const int RateFieldNumber = 3;

		// Token: 0x0400369A RID: 13978
		private int rate_;

		// Token: 0x0400369B RID: 13979
		public const int BidActionFieldNumber = 4;

		// Token: 0x0400369C RID: 13980
		private BidAction bidAction_;

		// Token: 0x0400369D RID: 13981
		private static BakActionRequest RsrAMZJEkTJqpXUOxD3e;
	}
}
