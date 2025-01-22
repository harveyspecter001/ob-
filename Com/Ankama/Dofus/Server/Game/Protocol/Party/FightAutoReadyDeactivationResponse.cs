using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002CC RID: 716
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyDeactivationResponse : IMessage<FightAutoReadyDeactivationResponse>, IMessage, IEquatable<FightAutoReadyDeactivationResponse>, IDeepCloneable<FightAutoReadyDeactivationResponse>, IBufferMessage
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x001BAE34 File Offset: 0x001B9034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightAutoReadyDeactivationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x001BAE44 File Offset: 0x001B9044
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

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x001BAE54 File Offset: 0x001B9054
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

		// Token: 0x0600212A RID: 8490 RVA: 0x001BAE64 File Offset: 0x001B9064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationResponse()
		{
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x001BAE74 File Offset: 0x001B9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationResponse(FightAutoReadyDeactivationResponse other)
		{
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x001BAE84 File Offset: 0x001B9084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationResponse Clone()
		{
			return null;
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x001BAE94 File Offset: 0x001B9094
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x001BAEA8 File Offset: 0x001B90A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightAutoReadyDeactivationResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightAutoReadyDeactivationResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x001BAEB8 File Offset: 0x001B90B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x001BAEC8 File Offset: 0x001B90C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyDeactivationResponse other)
		{
			return true;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x001BAED8 File Offset: 0x001B90D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x001BAEE8 File Offset: 0x001B90E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x001BAEF8 File Offset: 0x001B90F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x001BAF08 File Offset: 0x001B9108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x001BAF18 File Offset: 0x001B9118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x001BAF28 File Offset: 0x001B9128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyDeactivationResponse other)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x001BAF38 File Offset: 0x001B9138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x001BAF48 File Offset: 0x001B9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x001BAF58 File Offset: 0x001B9158
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyDeactivationResponse()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightAutoReadyDeactivationResponse._parser = new MessageParser<FightAutoReadyDeactivationResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x001BB024 File Offset: 0x001B9224
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BC2fwtO6CsKBjwyuQWh9()
		{
			return true;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x001BB02C File Offset: 0x001B922C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyDeactivationResponse C9HwUmO6DqYkHtnYujFq()
		{
			return null;
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly MessageParser<FightAutoReadyDeactivationResponse> _parser;

		// Token: 0x04000B96 RID: 2966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B97 RID: 2967
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B98 RID: 2968
		private FightAutoReadyDeactivationResponse.Types.Result result_;

		// Token: 0x04000B99 RID: 2969
		private static FightAutoReadyDeactivationResponse DgxhlwO60pqdQt4u9HX8;

		// Token: 0x020002CD RID: 717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600213C RID: 8508 RVA: 0x002B503C File Offset: 0x002B323C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002CE RID: 718
			public enum Result
			{
				// Token: 0x04000B9B RID: 2971
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B9C RID: 2972
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
