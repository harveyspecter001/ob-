using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006F6 RID: 1782
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBuyRequest : IMessage<ExchangeBuyRequest>, IMessage, IEquatable<ExchangeBuyRequest>, IDeepCloneable<ExchangeBuyRequest>, IBufferMessage
	{
		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06005738 RID: 22328 RVA: 0x00214B78 File Offset: 0x00212D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBuyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x00214B88 File Offset: 0x00212D88
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

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x0600573A RID: 22330 RVA: 0x00214B98 File Offset: 0x00212D98
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

		// Token: 0x0600573B RID: 22331 RVA: 0x00214BA8 File Offset: 0x00212DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBuyRequest()
		{
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00214BB8 File Offset: 0x00212DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBuyRequest(ExchangeBuyRequest other)
		{
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x00214BC8 File Offset: 0x00212DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBuyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x0600573E RID: 22334 RVA: 0x00214BD8 File Offset: 0x00212DD8
		// (set) Token: 0x0600573F RID: 22335 RVA: 0x00214BE8 File Offset: 0x00212DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06005740 RID: 22336 RVA: 0x00214BF8 File Offset: 0x00212DF8
		// (set) Token: 0x06005741 RID: 22337 RVA: 0x00214C08 File Offset: 0x00212E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quantity
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

		// Token: 0x06005742 RID: 22338 RVA: 0x00214C18 File Offset: 0x00212E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00214C28 File Offset: 0x00212E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBuyRequest other)
		{
			return true;
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00214C38 File Offset: 0x00212E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00214C48 File Offset: 0x00212E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00214C58 File Offset: 0x00212E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00214C68 File Offset: 0x00212E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x00214C78 File Offset: 0x00212E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x00214C88 File Offset: 0x00212E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBuyRequest other)
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00214C98 File Offset: 0x00212E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00214CA8 File Offset: 0x00212EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00214CB8 File Offset: 0x00212EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBuyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ExchangeBuyRequest._parser = new MessageParser<ExchangeBuyRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x00214D9C File Offset: 0x00212F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n6jSZuOMqsQsi2CScj8I()
		{
			return true;
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00214DA4 File Offset: 0x00212FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBuyRequest lVQ2bNOMFoGPU9KjmbjD()
		{
			return null;
		}

		// Token: 0x04001E88 RID: 7816
		private static readonly MessageParser<ExchangeBuyRequest> _parser;

		// Token: 0x04001E89 RID: 7817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E8A RID: 7818
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001E8B RID: 7819
		private int objectUid_;

		// Token: 0x04001E8C RID: 7820
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001E8D RID: 7821
		private int quantity_;

		// Token: 0x04001E8E RID: 7822
		internal static ExchangeBuyRequest nmHqO8OMZWcurMOPfv7Q;
	}
}
