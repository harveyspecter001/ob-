using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000594 RID: 1428
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapFightCountEvent : IMessage<MapFightCountEvent>, IMessage, IEquatable<MapFightCountEvent>, IDeepCloneable<MapFightCountEvent>, IBufferMessage
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x001F6DBC File Offset: 0x001F4FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapFightCountEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x001F6DCC File Offset: 0x001F4FCC
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x001F6DDC File Offset: 0x001F4FDC
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

		// Token: 0x060044DF RID: 17631 RVA: 0x001F6DEC File Offset: 0x001F4FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapFightCountEvent()
		{
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x001F6DFC File Offset: 0x001F4FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapFightCountEvent(MapFightCountEvent other)
		{
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x001F6E0C File Offset: 0x001F500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapFightCountEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x001F6E1C File Offset: 0x001F501C
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x001F6E2C File Offset: 0x001F502C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightCount
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

		// Token: 0x060044E4 RID: 17636 RVA: 0x001F6E3C File Offset: 0x001F503C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001F6E4C File Offset: 0x001F504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapFightCountEvent other)
		{
			return true;
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001F6E5C File Offset: 0x001F505C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001F6E6C File Offset: 0x001F506C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001F6E7C File Offset: 0x001F507C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x001F6E8C File Offset: 0x001F508C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001F6E9C File Offset: 0x001F509C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001F6EAC File Offset: 0x001F50AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapFightCountEvent other)
		{
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001F6EBC File Offset: 0x001F50BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001F6ECC File Offset: 0x001F50CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x001F6EDC File Offset: 0x001F50DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapFightCountEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					MapFightCountEvent._parser = new MessageParser<MapFightCountEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x001F6FC0 File Offset: 0x001F51C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V2AC3aOYWHWdxWO8DYHv()
		{
			return true;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x001F6FC8 File Offset: 0x001F51C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapFightCountEvent vbnfvSOYhRgoIayARQhR()
		{
			return null;
		}

		// Token: 0x040017AB RID: 6059
		private static readonly MessageParser<MapFightCountEvent> _parser;

		// Token: 0x040017AC RID: 6060
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017AD RID: 6061
		public const int FightCountFieldNumber = 1;

		// Token: 0x040017AE RID: 6062
		private int fightCount_;

		// Token: 0x040017AF RID: 6063
		private static MapFightCountEvent OQAhJ9OYLRlVP9YxOaFv;
	}
}
