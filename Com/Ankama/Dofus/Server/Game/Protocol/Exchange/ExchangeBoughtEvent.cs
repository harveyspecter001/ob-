using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000785 RID: 1925
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBoughtEvent : IMessage<ExchangeBoughtEvent>, IMessage, IEquatable<ExchangeBoughtEvent>, IDeepCloneable<ExchangeBoughtEvent>, IBufferMessage
	{
		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x0021D27C File Offset: 0x0021B47C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBoughtEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x0021D28C File Offset: 0x0021B48C
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

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x0021D29C File Offset: 0x0021B49C
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

		// Token: 0x06005E6C RID: 24172 RVA: 0x0021D2AC File Offset: 0x0021B4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBoughtEvent()
		{
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x0021D2BC File Offset: 0x0021B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBoughtEvent(ExchangeBoughtEvent other)
		{
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x0021D2CC File Offset: 0x0021B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBoughtEvent Clone()
		{
			return null;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x0021D2DC File Offset: 0x0021B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x0021D2EC File Offset: 0x0021B4EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBoughtEvent other)
		{
			return true;
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x0021D2FC File Offset: 0x0021B4FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x0021D30C File Offset: 0x0021B50C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x0021D31C File Offset: 0x0021B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x0021D32C File Offset: 0x0021B52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x0021D33C File Offset: 0x0021B53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x0021D34C File Offset: 0x0021B54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBoughtEvent other)
		{
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x0021D35C File Offset: 0x0021B55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x0021D36C File Offset: 0x0021B56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x0021D37C File Offset: 0x0021B57C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBoughtEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					ExchangeBoughtEvent._parser = new MessageParser<ExchangeBoughtEvent>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x0021D448 File Offset: 0x0021B648
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A46uebOZPjVVJTyNdtLS()
		{
			return true;
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x0021D450 File Offset: 0x0021B650
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBoughtEvent Nji66aOZSVa8SmMnxoId()
		{
			return null;
		}

		// Token: 0x0400213A RID: 8506
		private static readonly MessageParser<ExchangeBoughtEvent> _parser;

		// Token: 0x0400213B RID: 8507
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400213C RID: 8508
		internal static ExchangeBoughtEvent yMWX8MOZit9veyPsa8Ed;
	}
}
