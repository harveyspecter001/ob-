using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x0200069D RID: 1693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsAcceptRequest : IMessage<FightPlacementSwapPositionsAcceptRequest>, IMessage, IEquatable<FightPlacementSwapPositionsAcceptRequest>, IDeepCloneable<FightPlacementSwapPositionsAcceptRequest>, IBufferMessage
	{
		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x0020896C File Offset: 0x00206B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightPlacementSwapPositionsAcceptRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x0020897C File Offset: 0x00206B7C
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x0020898C File Offset: 0x00206B8C
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

		// Token: 0x0600528F RID: 21135 RVA: 0x0020899C File Offset: 0x00206B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsAcceptRequest()
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x002089AC File Offset: 0x00206BAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsAcceptRequest(FightPlacementSwapPositionsAcceptRequest other)
		{
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x002089BC File Offset: 0x00206BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsAcceptRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x002089CC File Offset: 0x00206BCC
		// (set) Token: 0x06005293 RID: 21139 RVA: 0x002089DC File Offset: 0x00206BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RequestId
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

		// Token: 0x06005294 RID: 21140 RVA: 0x002089EC File Offset: 0x00206BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x002089FC File Offset: 0x00206BFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsAcceptRequest other)
		{
			return true;
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00208A0C File Offset: 0x00206C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00208A1C File Offset: 0x00206C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00208A2C File Offset: 0x00206C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00208A3C File Offset: 0x00206C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00208A4C File Offset: 0x00206C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00208A5C File Offset: 0x00206C5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsAcceptRequest other)
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00208A6C File Offset: 0x00206C6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00208A7C File Offset: 0x00206C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00208A8C File Offset: 0x00206C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsAcceptRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						goto IL_83;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						FightPlacementSwapPositionsAcceptRequest._parser = new MessageParser<FightPlacementSwapPositionsAcceptRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						break;
					}
				}
				IL_83:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00208B5C File Offset: 0x00206D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SFjRguOPpoiSRcadENI1()
		{
			return true;
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00208B64 File Offset: 0x00206D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsAcceptRequest jvoX1nOPHEB8uYlUhcxn()
		{
			return null;
		}

		// Token: 0x04001D16 RID: 7446
		private static readonly MessageParser<FightPlacementSwapPositionsAcceptRequest> _parser;

		// Token: 0x04001D17 RID: 7447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D18 RID: 7448
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04001D19 RID: 7449
		private int requestId_;

		// Token: 0x04001D1A RID: 7450
		private static FightPlacementSwapPositionsAcceptRequest giC9Z2OPTeqZG49N7LgB;
	}
}
