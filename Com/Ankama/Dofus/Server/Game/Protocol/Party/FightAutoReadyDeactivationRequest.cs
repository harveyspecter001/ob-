using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002CA RID: 714
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyDeactivationRequest : IMessage<FightAutoReadyDeactivationRequest>, IMessage, IEquatable<FightAutoReadyDeactivationRequest>, IDeepCloneable<FightAutoReadyDeactivationRequest>, IBufferMessage
	{
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x001BAC40 File Offset: 0x001B8E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoReadyDeactivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x001BAC50 File Offset: 0x001B8E50
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

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x001BAC60 File Offset: 0x001B8E60
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

		// Token: 0x06002112 RID: 8466 RVA: 0x001BAC70 File Offset: 0x001B8E70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationRequest()
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x001BAC80 File Offset: 0x001B8E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationRequest(FightAutoReadyDeactivationRequest other)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x001BAC90 File Offset: 0x001B8E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyDeactivationRequest Clone()
		{
			return null;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x001BACA0 File Offset: 0x001B8EA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x001BACB0 File Offset: 0x001B8EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyDeactivationRequest other)
		{
			return true;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x001BACC0 File Offset: 0x001B8EC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x001BACD0 File Offset: 0x001B8ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x001BACE0 File Offset: 0x001B8EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x001BACF0 File Offset: 0x001B8EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x001BAD00 File Offset: 0x001B8F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x001BAD10 File Offset: 0x001B8F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyDeactivationRequest other)
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x001BAD20 File Offset: 0x001B8F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x001BAD30 File Offset: 0x001B8F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x001BAD40 File Offset: 0x001B8F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyDeactivationRequest()
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
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					FightAutoReadyDeactivationRequest._parser = new MessageParser<FightAutoReadyDeactivationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x001BAE24 File Offset: 0x001B9024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QoMKBNO6rYfo5RkAXmV9()
		{
			return true;
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x001BAE2C File Offset: 0x001B902C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyDeactivationRequest psqloKO6VfPPVSU8tEF4()
		{
			return null;
		}

		// Token: 0x04000B90 RID: 2960
		private static readonly MessageParser<FightAutoReadyDeactivationRequest> _parser;

		// Token: 0x04000B91 RID: 2961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B92 RID: 2962
		internal static FightAutoReadyDeactivationRequest FQI0H8O6hdmkGYRNigae;
	}
}
