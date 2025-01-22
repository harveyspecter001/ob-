using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BC8 RID: 3016
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlmanachCalendarDateEvent : IMessage<AlmanachCalendarDateEvent>, IMessage, IEquatable<AlmanachCalendarDateEvent>, IDeepCloneable<AlmanachCalendarDateEvent>, IBufferMessage
	{
		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06009128 RID: 37160 RVA: 0x0026F538 File Offset: 0x0026D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlmanachCalendarDateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x0026F548 File Offset: 0x0026D748
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x0600912A RID: 37162 RVA: 0x0026F558 File Offset: 0x0026D758
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

		// Token: 0x0600912B RID: 37163 RVA: 0x0026F568 File Offset: 0x0026D768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlmanachCalendarDateEvent()
		{
		}

		// Token: 0x0600912C RID: 37164 RVA: 0x0026F578 File Offset: 0x0026D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlmanachCalendarDateEvent(AlmanachCalendarDateEvent other)
		{
		}

		// Token: 0x0600912D RID: 37165 RVA: 0x0026F588 File Offset: 0x0026D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlmanachCalendarDateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x0600912E RID: 37166 RVA: 0x0026F598 File Offset: 0x0026D798
		// (set) Token: 0x0600912F RID: 37167 RVA: 0x0026F5A8 File Offset: 0x0026D7A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DateId
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

		// Token: 0x06009130 RID: 37168 RVA: 0x0026F5B8 File Offset: 0x0026D7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x0026F5C8 File Offset: 0x0026D7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlmanachCalendarDateEvent other)
		{
			return true;
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x0026F5D8 File Offset: 0x0026D7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x0026F5E8 File Offset: 0x0026D7E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x0026F5F8 File Offset: 0x0026D7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x0026F608 File Offset: 0x0026D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x0026F618 File Offset: 0x0026D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x0026F628 File Offset: 0x0026D828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlmanachCalendarDateEvent other)
		{
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x0026F638 File Offset: 0x0026D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x0026F648 File Offset: 0x0026D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600913A RID: 37178 RVA: 0x0026F658 File Offset: 0x0026D858
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlmanachCalendarDateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 2;
						}
						break;
					case 2:
						AlmanachCalendarDateEvent._parser = new MessageParser<AlmanachCalendarDateEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						goto IL_98;
					}
				}
				IL_98:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x0026F740 File Offset: 0x0026D940
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pvcedZJ2DPi44Cms26oR()
		{
			return true;
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x0026F748 File Offset: 0x0026D948
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlmanachCalendarDateEvent mvVgyBJ2tkjXqiVtBVL2()
		{
			return null;
		}

		// Token: 0x040035FF RID: 13823
		private static readonly MessageParser<AlmanachCalendarDateEvent> _parser;

		// Token: 0x04003600 RID: 13824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003601 RID: 13825
		public const int DateIdFieldNumber = 1;

		// Token: 0x04003602 RID: 13826
		private int dateId_;

		// Token: 0x04003603 RID: 13827
		internal static AlmanachCalendarDateEvent rPM43wJ2CX5YnGVqog3R;
	}
}
