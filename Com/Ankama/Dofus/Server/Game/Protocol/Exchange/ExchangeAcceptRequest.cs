using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006EE RID: 1774
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeAcceptRequest : IMessage<ExchangeAcceptRequest>, IMessage, IEquatable<ExchangeAcceptRequest>, IDeepCloneable<ExchangeAcceptRequest>, IBufferMessage
	{
		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x002142E8 File Offset: 0x002124E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeAcceptRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060056CD RID: 22221 RVA: 0x002142F8 File Offset: 0x002124F8
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

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x00214308 File Offset: 0x00212508
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

		// Token: 0x060056CF RID: 22223 RVA: 0x00214318 File Offset: 0x00212518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeAcceptRequest()
		{
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00214328 File Offset: 0x00212528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeAcceptRequest(ExchangeAcceptRequest other)
		{
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00214338 File Offset: 0x00212538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeAcceptRequest Clone()
		{
			return null;
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00214348 File Offset: 0x00212548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00214358 File Offset: 0x00212558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeAcceptRequest other)
		{
			return true;
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00214368 File Offset: 0x00212568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00214378 File Offset: 0x00212578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00214388 File Offset: 0x00212588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00214398 File Offset: 0x00212598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x002143A8 File Offset: 0x002125A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x002143B8 File Offset: 0x002125B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeAcceptRequest other)
		{
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x002143C8 File Offset: 0x002125C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x002143D8 File Offset: 0x002125D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x002143E8 File Offset: 0x002125E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeAcceptRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeAcceptRequest._parser = new MessageParser<ExchangeAcceptRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x002144CC File Offset: 0x002126CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i5amUQOMTNqrY6Isyneh()
		{
			return true;
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x002144D4 File Offset: 0x002126D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeAcceptRequest nvOr76OMpldZuoWFrVme()
		{
			return null;
		}

		// Token: 0x04001E68 RID: 7784
		private static readonly MessageParser<ExchangeAcceptRequest> _parser;

		// Token: 0x04001E69 RID: 7785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E6A RID: 7786
		internal static ExchangeAcceptRequest HvdiZgOM7uhnuUSKFUuf;
	}
}
