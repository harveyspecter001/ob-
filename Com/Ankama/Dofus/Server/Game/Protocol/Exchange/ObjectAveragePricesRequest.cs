using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000711 RID: 1809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectAveragePricesRequest : IMessage<ObjectAveragePricesRequest>, IMessage, IEquatable<ObjectAveragePricesRequest>, IDeepCloneable<ObjectAveragePricesRequest>, IBufferMessage
	{
		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x00216334 File Offset: 0x00214534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectAveragePricesRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06005882 RID: 22658 RVA: 0x00216344 File Offset: 0x00214544
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

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x00216354 File Offset: 0x00214554
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

		// Token: 0x06005884 RID: 22660 RVA: 0x00216364 File Offset: 0x00214564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesRequest()
		{
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x00216374 File Offset: 0x00214574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesRequest(ObjectAveragePricesRequest other)
		{
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x00216384 File Offset: 0x00214584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesRequest Clone()
		{
			return null;
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x00216394 File Offset: 0x00214594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x002163A4 File Offset: 0x002145A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectAveragePricesRequest other)
		{
			return true;
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x002163B4 File Offset: 0x002145B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x002163C4 File Offset: 0x002145C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x002163D4 File Offset: 0x002145D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x002163E4 File Offset: 0x002145E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x002163F4 File Offset: 0x002145F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00216404 File Offset: 0x00214604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectAveragePricesRequest other)
		{
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00216414 File Offset: 0x00214614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00216424 File Offset: 0x00214624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00216434 File Offset: 0x00214634
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectAveragePricesRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					ObjectAveragePricesRequest._parser = new MessageParser<ObjectAveragePricesRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x0021652C File Offset: 0x0021472C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cxw4JsOu1MvcLxPIDeq1()
		{
			return true;
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00216534 File Offset: 0x00214734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectAveragePricesRequest MS15RkOuaagc7RjpbJ3i()
		{
			return null;
		}

		// Token: 0x04001F05 RID: 7941
		private static readonly MessageParser<ObjectAveragePricesRequest> _parser;

		// Token: 0x04001F06 RID: 7942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F07 RID: 7943
		internal static ObjectAveragePricesRequest lSlL8kOuo47vu6t3x1VX;
	}
}
