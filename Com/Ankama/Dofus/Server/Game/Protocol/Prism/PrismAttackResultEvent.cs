using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001D9 RID: 473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismAttackResultEvent : IMessage<PrismAttackResultEvent>, IMessage, IEquatable<PrismAttackResultEvent>, IDeepCloneable<PrismAttackResultEvent>, IBufferMessage
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x001A7D9C File Offset: 0x001A5F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismAttackResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x001A7DAC File Offset: 0x001A5FAC
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x001A7DBC File Offset: 0x001A5FBC
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

		// Token: 0x0600161C RID: 5660 RVA: 0x001A7DCC File Offset: 0x001A5FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackResultEvent()
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x001A7DDC File Offset: 0x001A5FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackResultEvent(PrismAttackResultEvent other)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x001A7DEC File Offset: 0x001A5FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismAttackResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x001A7DFC File Offset: 0x001A5FFC
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x001A7E0C File Offset: 0x001A600C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrismLocalizedInformation PrismLocalizedInformation
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x001A7E1C File Offset: 0x001A601C
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x001A7E30 File Offset: 0x001A6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrismAttackResultEvent.Types.PrismAttackResult PrismAttackResult
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PrismAttackResultEvent.Types.PrismAttackResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x001A7E40 File Offset: 0x001A6040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x001A7E50 File Offset: 0x001A6050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismAttackResultEvent other)
		{
			return true;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x001A7E60 File Offset: 0x001A6060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x001A7E70 File Offset: 0x001A6070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x001A7E80 File Offset: 0x001A6080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x001A7E90 File Offset: 0x001A6090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x001A7EA0 File Offset: 0x001A60A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x001A7EB0 File Offset: 0x001A60B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismAttackResultEvent other)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x001A7EC0 File Offset: 0x001A60C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x001A7ED0 File Offset: 0x001A60D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x001A7EE0 File Offset: 0x001A60E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismAttackResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PrismAttackResultEvent._parser = new MessageParser<PrismAttackResultEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x001A7FAC File Offset: 0x001A61AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ukSL0mO1638JZfIsnakk()
		{
			return true;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x001A7FB4 File Offset: 0x001A61B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismAttackResultEvent BrV3DxO1Lay8XcxG0DDr()
		{
			return null;
		}

		// Token: 0x040007CE RID: 1998
		private static readonly MessageParser<PrismAttackResultEvent> _parser;

		// Token: 0x040007CF RID: 1999
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007D0 RID: 2000
		public const int PrismLocalizedInformationFieldNumber = 1;

		// Token: 0x040007D1 RID: 2001
		private PrismLocalizedInformation prismLocalizedInformation_;

		// Token: 0x040007D2 RID: 2002
		public const int PrismAttackResultFieldNumber = 2;

		// Token: 0x040007D3 RID: 2003
		private PrismAttackResultEvent.Types.PrismAttackResult prismAttackResult_;

		// Token: 0x040007D4 RID: 2004
		private static PrismAttackResultEvent HUbiIuO1yYDGKb64lHIP;

		// Token: 0x020001DA RID: 474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001630 RID: 5680 RVA: 0x002B01C8 File Offset: 0x002AE3C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001DB RID: 475
			public enum PrismAttackResult
			{
				// Token: 0x040007D6 RID: 2006
				[OriginalName("DEFENDERS_WIN")]
				DefendersWin,
				// Token: 0x040007D7 RID: 2007
				[OriginalName("ATTACKERS_WIN")]
				AttackersWin
			}
		}
	}
}
