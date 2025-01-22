using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000751 RID: 1873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeLeaveEvent : IMessage<ExchangeLeaveEvent>, IMessage, IEquatable<ExchangeLeaveEvent>, IDeepCloneable<ExchangeLeaveEvent>, IBufferMessage
	{
		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x0021A8B4 File Offset: 0x00218AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeLeaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x0021A8C4 File Offset: 0x00218AC4
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

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x0021A8D4 File Offset: 0x00218AD4
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

		// Token: 0x06005BEA RID: 23530 RVA: 0x0021A8E4 File Offset: 0x00218AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeLeaveEvent()
		{
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x0021A8F4 File Offset: 0x00218AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeLeaveEvent(ExchangeLeaveEvent other)
		{
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x0021A904 File Offset: 0x00218B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeLeaveEvent Clone()
		{
			return null;
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005BED RID: 23533 RVA: 0x0021A914 File Offset: 0x00218B14
		// (set) Token: 0x06005BEE RID: 23534 RVA: 0x0021A928 File Offset: 0x00218B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DialogType DialogType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DialogType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005BEF RID: 23535 RVA: 0x0021A938 File Offset: 0x00218B38
		// (set) Token: 0x06005BF0 RID: 23536 RVA: 0x0021A948 File Offset: 0x00218B48
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

		// Token: 0x06005BF1 RID: 23537 RVA: 0x0021A958 File Offset: 0x00218B58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x0021A968 File Offset: 0x00218B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeLeaveEvent other)
		{
			return true;
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x0021A978 File Offset: 0x00218B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x0021A988 File Offset: 0x00218B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x0021A998 File Offset: 0x00218B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x0021A9A8 File Offset: 0x00218BA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x0021A9B8 File Offset: 0x00218BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x0021A9C8 File Offset: 0x00218BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeLeaveEvent other)
		{
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x0021A9D8 File Offset: 0x00218BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x0021A9E8 File Offset: 0x00218BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x0021A9F8 File Offset: 0x00218BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeLeaveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ExchangeLeaveEvent._parser = new MessageParser<ExchangeLeaveEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x0021AADC File Offset: 0x00218CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CFfFHuO8zP5ng6eqkUBQ()
		{
			return true;
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x0021AAE4 File Offset: 0x00218CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeLeaveEvent gZ04o5OZfC5kkZQ6MYFU()
		{
			return null;
		}

		// Token: 0x0400203B RID: 8251
		private static readonly MessageParser<ExchangeLeaveEvent> _parser;

		// Token: 0x0400203C RID: 8252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400203D RID: 8253
		public const int DialogTypeFieldNumber = 1;

		// Token: 0x0400203E RID: 8254
		private DialogType dialogType_;

		// Token: 0x0400203F RID: 8255
		public const int SuccessFieldNumber = 2;

		// Token: 0x04002040 RID: 8256
		private bool success_;

		// Token: 0x04002041 RID: 8257
		private static ExchangeLeaveEvent knedTrO8FUdjPyMkN88Q;
	}
}
