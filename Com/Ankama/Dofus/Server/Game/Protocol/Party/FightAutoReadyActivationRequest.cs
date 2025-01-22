using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002C2 RID: 706
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyActivationRequest : IMessage<FightAutoReadyActivationRequest>, IMessage, IEquatable<FightAutoReadyActivationRequest>, IDeepCloneable<FightAutoReadyActivationRequest>, IBufferMessage
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x001BA620 File Offset: 0x001B8820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoReadyActivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x001BA630 File Offset: 0x001B8830
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x001BA640 File Offset: 0x001B8840
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

		// Token: 0x060020C5 RID: 8389 RVA: 0x001BA650 File Offset: 0x001B8850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationRequest()
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x001BA660 File Offset: 0x001B8860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationRequest(FightAutoReadyActivationRequest other)
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x001BA670 File Offset: 0x001B8870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivationRequest Clone()
		{
			return null;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x001BA680 File Offset: 0x001B8880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x001BA690 File Offset: 0x001B8890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyActivationRequest other)
		{
			return true;
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x001BA6A0 File Offset: 0x001B88A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x001BA6B0 File Offset: 0x001B88B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x001BA6C0 File Offset: 0x001B88C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x001BA6D0 File Offset: 0x001B88D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x001BA6E0 File Offset: 0x001B88E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x001BA6F0 File Offset: 0x001B88F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyActivationRequest other)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x001BA700 File Offset: 0x001B8900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x001BA710 File Offset: 0x001B8910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x001BA720 File Offset: 0x001B8920
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyActivationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightAutoReadyActivationRequest._parser = new MessageParser<FightAutoReadyActivationRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x001BA804 File Offset: 0x001B8A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pn5OfGO6od3GHdeDuUtk()
		{
			return true;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x001BA80C File Offset: 0x001B8A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyActivationRequest MaTX2UO61b4ZT1vCRj4B()
		{
			return null;
		}

		// Token: 0x04000B7A RID: 2938
		private static readonly MessageParser<FightAutoReadyActivationRequest> _parser;

		// Token: 0x04000B7B RID: 2939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B7C RID: 2940
		internal static FightAutoReadyActivationRequest mr47rZO6vCAAPBbRNjCU;
	}
}
