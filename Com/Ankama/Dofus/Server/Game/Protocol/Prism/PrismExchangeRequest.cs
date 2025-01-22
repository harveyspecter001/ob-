using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001CD RID: 461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismExchangeRequest : IMessage<PrismExchangeRequest>, IMessage, IEquatable<PrismExchangeRequest>, IDeepCloneable<PrismExchangeRequest>, IBufferMessage
	{
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x001A713C File Offset: 0x001A533C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismExchangeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x001A714C File Offset: 0x001A534C
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

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x001A715C File Offset: 0x001A535C
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

		// Token: 0x06001585 RID: 5509 RVA: 0x001A716C File Offset: 0x001A536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismExchangeRequest()
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x001A717C File Offset: 0x001A537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismExchangeRequest(PrismExchangeRequest other)
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x001A718C File Offset: 0x001A538C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismExchangeRequest Clone()
		{
			return null;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x001A719C File Offset: 0x001A539C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x001A71AC File Offset: 0x001A53AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismExchangeRequest other)
		{
			return true;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x001A71BC File Offset: 0x001A53BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x001A71CC File Offset: 0x001A53CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x001A71DC File Offset: 0x001A53DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x001A71EC File Offset: 0x001A53EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x001A71FC File Offset: 0x001A53FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x001A720C File Offset: 0x001A540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismExchangeRequest other)
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x001A721C File Offset: 0x001A541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x001A722C File Offset: 0x001A542C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x001A723C File Offset: 0x001A543C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismExchangeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PrismExchangeRequest._parser = new MessageParser<PrismExchangeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x001A7320 File Offset: 0x001A5520
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iesaVSO1EkyphRVeC6II()
		{
			return true;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x001A7328 File Offset: 0x001A5528
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismExchangeRequest Q4HOaVO1XQ3kCLMXt9j2()
		{
			return null;
		}

		// Token: 0x040007A7 RID: 1959
		private static readonly MessageParser<PrismExchangeRequest> _parser;

		// Token: 0x040007A8 RID: 1960
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007A9 RID: 1961
		private static PrismExchangeRequest R1xfD5O12V7RSWFAVEUH;
	}
}
