using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000DD RID: 221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorFightRequest : IMessage<TaxCollectorFightRequest>, IMessage, IEquatable<TaxCollectorFightRequest>, IDeepCloneable<TaxCollectorFightRequest>, IBufferMessage
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00192D68 File Offset: 0x00190F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorFightRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00192D78 File Offset: 0x00190F78
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00192D88 File Offset: 0x00190F88
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

		// Token: 0x060009F1 RID: 2545 RVA: 0x00192D98 File Offset: 0x00190F98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorFightRequest()
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00192DA8 File Offset: 0x00190FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorFightRequest(TaxCollectorFightRequest other)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00192DB8 File Offset: 0x00190FB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorFightRequest Clone()
		{
			return null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00192DC8 File Offset: 0x00190FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00192DD8 File Offset: 0x00190FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorFightRequest other)
		{
			return true;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00192DE8 File Offset: 0x00190FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00192DF8 File Offset: 0x00190FF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00192E08 File Offset: 0x00191008
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00192E18 File Offset: 0x00191018
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00192E28 File Offset: 0x00191028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00192E38 File Offset: 0x00191038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorFightRequest other)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00192E48 File Offset: 0x00191048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00192E58 File Offset: 0x00191058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00192E68 File Offset: 0x00191068
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorFightRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TaxCollectorFightRequest._parser = new MessageParser<TaxCollectorFightRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00192F60 File Offset: 0x00191160
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hvMDbQOkHfl8bJa5qNmT()
		{
			return true;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00192F68 File Offset: 0x00191168
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorFightRequest tt8tbUOkYcOyrDniu8RH()
		{
			return null;
		}

		// Token: 0x040003B5 RID: 949
		private static readonly MessageParser<TaxCollectorFightRequest> _parser;

		// Token: 0x040003B6 RID: 950
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003B7 RID: 951
		internal static TaxCollectorFightRequest W1uBbiOkp0oKfpNWXp2M;
	}
}
