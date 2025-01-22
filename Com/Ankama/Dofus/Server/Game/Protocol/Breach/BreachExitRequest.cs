using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200096D RID: 2413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachExitRequest : IMessage<BreachExitRequest>, IMessage, IEquatable<BreachExitRequest>, IDeepCloneable<BreachExitRequest>, IBufferMessage
	{
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060074D1 RID: 29905 RVA: 0x002421C8 File Offset: 0x002403C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachExitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060074D2 RID: 29906 RVA: 0x002421D8 File Offset: 0x002403D8
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

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060074D3 RID: 29907 RVA: 0x002421E8 File Offset: 0x002403E8
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

		// Token: 0x060074D4 RID: 29908 RVA: 0x002421F8 File Offset: 0x002403F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitRequest()
		{
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00242208 File Offset: 0x00240408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitRequest(BreachExitRequest other)
		{
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x00242218 File Offset: 0x00240418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitRequest Clone()
		{
			return null;
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00242228 File Offset: 0x00240428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00242238 File Offset: 0x00240438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachExitRequest other)
		{
			return true;
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00242248 File Offset: 0x00240448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00242258 File Offset: 0x00240458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00242268 File Offset: 0x00240468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00242278 File Offset: 0x00240478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00242288 File Offset: 0x00240488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00242298 File Offset: 0x00240498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachExitRequest other)
		{
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x002422A8 File Offset: 0x002404A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x002422B8 File Offset: 0x002404B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x002422C8 File Offset: 0x002404C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachExitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					BreachExitRequest._parser = new MessageParser<BreachExitRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00242394 File Offset: 0x00240594
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAOw18JRRBWuWilsmEVy()
		{
			return true;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x0024239C File Offset: 0x0024059C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachExitRequest tharceJROlV4j8n0TVX1()
		{
			return null;
		}

		// Token: 0x040028BB RID: 10427
		private static readonly MessageParser<BreachExitRequest> _parser;

		// Token: 0x040028BC RID: 10428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028BD RID: 10429
		internal static BreachExitRequest FMgE4gJR3A4HB5xN6TXX;
	}
}
