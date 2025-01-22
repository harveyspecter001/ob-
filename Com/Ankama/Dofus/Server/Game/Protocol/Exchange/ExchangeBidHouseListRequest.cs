using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000707 RID: 1799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseListRequest : IMessage<ExchangeBidHouseListRequest>, IMessage, IEquatable<ExchangeBidHouseListRequest>, IDeepCloneable<ExchangeBidHouseListRequest>, IBufferMessage
	{
		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x0021588C File Offset: 0x00213A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHouseListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0021589C File Offset: 0x00213A9C
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

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060057F9 RID: 22521 RVA: 0x002158AC File Offset: 0x00213AAC
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

		// Token: 0x060057FA RID: 22522 RVA: 0x002158BC File Offset: 0x00213ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseListRequest()
		{
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x002158CC File Offset: 0x00213ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseListRequest(ExchangeBidHouseListRequest other)
		{
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x002158DC File Offset: 0x00213ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseListRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x002158EC File Offset: 0x00213AEC
		// (set) Token: 0x060057FE RID: 22526 RVA: 0x002158FC File Offset: 0x00213AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060057FF RID: 22527 RVA: 0x0021590C File Offset: 0x00213B0C
		// (set) Token: 0x06005800 RID: 22528 RVA: 0x0021591C File Offset: 0x00213B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Follow
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

		// Token: 0x06005801 RID: 22529 RVA: 0x0021592C File Offset: 0x00213B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x0021593C File Offset: 0x00213B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseListRequest other)
		{
			return true;
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x0021594C File Offset: 0x00213B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x0021595C File Offset: 0x00213B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x0021596C File Offset: 0x00213B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x0021597C File Offset: 0x00213B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x0021598C File Offset: 0x00213B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x0021599C File Offset: 0x00213B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseListRequest other)
		{
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x002159AC File Offset: 0x00213BAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x002159BC File Offset: 0x00213BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x002159CC File Offset: 0x00213BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						goto IL_35;
					case 4:
						ExchangeBidHouseListRequest._parser = new MessageParser<ExchangeBidHouseListRequest>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					goto Block_1;
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				IL_4E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				Block_1:
				goto IL_4E;
			}
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x00215AA0 File Offset: 0x00213CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YrX14POu273Q2tfHBKPQ()
		{
			return true;
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00215AA8 File Offset: 0x00213CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseListRequest ygFtkGOuEDYnQE2rDhc6()
		{
			return null;
		}

		// Token: 0x04001EDA RID: 7898
		private static readonly MessageParser<ExchangeBidHouseListRequest> _parser;

		// Token: 0x04001EDB RID: 7899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EDC RID: 7900
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001EDD RID: 7901
		private int objectGid_;

		// Token: 0x04001EDE RID: 7902
		public const int FollowFieldNumber = 2;

		// Token: 0x04001EDF RID: 7903
		private bool follow_;

		// Token: 0x04001EE0 RID: 7904
		internal static ExchangeBidHouseListRequest iXGKNEOu9t05m0Y0vAtS;
	}
}
