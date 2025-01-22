using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x0200069B RID: 1691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsCancelRequest : IMessage<FightPlacementSwapPositionsCancelRequest>, IMessage, IEquatable<FightPlacementSwapPositionsCancelRequest>, IDeepCloneable<FightPlacementSwapPositionsCancelRequest>, IBufferMessage
	{
		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x00208758 File Offset: 0x00206958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightPlacementSwapPositionsCancelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x00208768 File Offset: 0x00206968
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

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x00208778 File Offset: 0x00206978
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

		// Token: 0x06005275 RID: 21109 RVA: 0x00208788 File Offset: 0x00206988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelRequest()
		{
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00208798 File Offset: 0x00206998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelRequest(FightPlacementSwapPositionsCancelRequest other)
		{
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x002087A8 File Offset: 0x002069A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsCancelRequest Clone()
		{
			return null;
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x002087B8 File Offset: 0x002069B8
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x002087C8 File Offset: 0x002069C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600527A RID: 21114 RVA: 0x002087D8 File Offset: 0x002069D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x002087E8 File Offset: 0x002069E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsCancelRequest other)
		{
			return true;
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x002087F8 File Offset: 0x002069F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00208808 File Offset: 0x00206A08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x00208818 File Offset: 0x00206A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00208828 File Offset: 0x00206A28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00208838 File Offset: 0x00206A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00208848 File Offset: 0x00206A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsCancelRequest other)
		{
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00208858 File Offset: 0x00206A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00208868 File Offset: 0x00206A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00208878 File Offset: 0x00206A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsCancelRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					FightPlacementSwapPositionsCancelRequest._parser = new MessageParser<FightPlacementSwapPositionsCancelRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0020895C File Offset: 0x00206B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AR6hwZOPQAHlFbV1wjl5()
		{
			return true;
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00208964 File Offset: 0x00206B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsCancelRequest sMypklOP7j4TOff1HPWJ()
		{
			return null;
		}

		// Token: 0x04001D0F RID: 7439
		private static readonly MessageParser<FightPlacementSwapPositionsCancelRequest> _parser;

		// Token: 0x04001D10 RID: 7440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D11 RID: 7441
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04001D12 RID: 7442
		private int requestId_;

		// Token: 0x04001D13 RID: 7443
		internal static FightPlacementSwapPositionsCancelRequest QSOOP2OPwtvaacJjq7vA;
	}
}
