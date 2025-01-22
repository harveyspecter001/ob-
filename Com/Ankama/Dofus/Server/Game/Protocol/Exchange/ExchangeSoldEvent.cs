using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000787 RID: 1927
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeSoldEvent : IMessage<ExchangeSoldEvent>, IMessage, IEquatable<ExchangeSoldEvent>, IDeepCloneable<ExchangeSoldEvent>, IBufferMessage
	{
		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x0021D458 File Offset: 0x0021B658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeSoldEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06005E82 RID: 24194 RVA: 0x0021D468 File Offset: 0x0021B668
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

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x0021D478 File Offset: 0x0021B678
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

		// Token: 0x06005E84 RID: 24196 RVA: 0x0021D488 File Offset: 0x0021B688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSoldEvent()
		{
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x0021D498 File Offset: 0x0021B698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSoldEvent(ExchangeSoldEvent other)
		{
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x0021D4A8 File Offset: 0x0021B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSoldEvent Clone()
		{
			return null;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x0021D4B8 File Offset: 0x0021B6B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x0021D4C8 File Offset: 0x0021B6C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeSoldEvent other)
		{
			return true;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0021D4D8 File Offset: 0x0021B6D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0021D4E8 File Offset: 0x0021B6E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0021D4F8 File Offset: 0x0021B6F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0021D508 File Offset: 0x0021B708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0021D518 File Offset: 0x0021B718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0021D528 File Offset: 0x0021B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeSoldEvent other)
		{
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0021D538 File Offset: 0x0021B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0021D548 File Offset: 0x0021B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0021D558 File Offset: 0x0021B758
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeSoldEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ExchangeSoldEvent._parser = new MessageParser<ExchangeSoldEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0021D650 File Offset: 0x0021B850
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GiuB0tOZu0tNkDgIAlx4()
		{
			return true;
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0021D658 File Offset: 0x0021B858
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeSoldEvent uWcVnkOZ8LI10TiUWop9()
		{
			return null;
		}

		// Token: 0x0400213F RID: 8511
		private static readonly MessageParser<ExchangeSoldEvent> _parser;

		// Token: 0x04002140 RID: 8512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002141 RID: 8513
		private static ExchangeSoldEvent Mvoa28OZMwt5ROnEAeYo;
	}
}
