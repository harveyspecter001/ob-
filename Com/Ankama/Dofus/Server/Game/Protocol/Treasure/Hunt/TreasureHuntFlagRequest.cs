using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x0200003A RID: 58
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntFlagRequest : IMessage<TreasureHuntFlagRequest>, IMessage, IEquatable<TreasureHuntFlagRequest>, IDeepCloneable<TreasureHuntFlagRequest>, IBufferMessage
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00186D9C File Offset: 0x00184F9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntFlagRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00186DAC File Offset: 0x00184FAC
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00186DBC File Offset: 0x00184FBC
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

		// Token: 0x0600021B RID: 539 RVA: 0x00186DCC File Offset: 0x00184FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRequest()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00186DDC File Offset: 0x00184FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRequest(TreasureHuntFlagRequest other)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00186DEC File Offset: 0x00184FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFlagRequest Clone()
		{
			return null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00186DFC File Offset: 0x00184FFC
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00186E10 File Offset: 0x00185010
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00186E20 File Offset: 0x00185020
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00186E30 File Offset: 0x00185030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Index
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

		// Token: 0x06000222 RID: 546 RVA: 0x00186E40 File Offset: 0x00185040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00186E50 File Offset: 0x00185050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntFlagRequest other)
		{
			return true;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00186E60 File Offset: 0x00185060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00186E70 File Offset: 0x00185070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00186E80 File Offset: 0x00185080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00186E90 File Offset: 0x00185090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00186EA0 File Offset: 0x001850A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00186EB0 File Offset: 0x001850B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntFlagRequest other)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00186EC0 File Offset: 0x001850C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00186ED0 File Offset: 0x001850D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00186EE0 File Offset: 0x001850E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntFlagRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TreasureHuntFlagRequest._parser = new MessageParser<TreasureHuntFlagRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00186FAC File Offset: 0x001851AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bp1pu5OjaJTh2Exxsqdx()
		{
			return true;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00186FB4 File Offset: 0x001851B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntFlagRequest oPsIOfOj5YgMkXeuSOP9()
		{
			return null;
		}

		// Token: 0x040000DE RID: 222
		private static readonly MessageParser<TreasureHuntFlagRequest> _parser;

		// Token: 0x040000DF RID: 223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000E0 RID: 224
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x040000E1 RID: 225
		private TreasureHuntType questType_;

		// Token: 0x040000E2 RID: 226
		public const int IndexFieldNumber = 2;

		// Token: 0x040000E3 RID: 227
		private int index_;

		// Token: 0x040000E4 RID: 228
		internal static TreasureHuntFlagRequest sF1ujxOj1DrFZgRpIcPs;
	}
}
