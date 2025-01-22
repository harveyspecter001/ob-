using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move
{
	// Token: 0x02000635 RID: 1589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishMoveSetRequest : IMessage<FinishMoveSetRequest>, IMessage, IEquatable<FinishMoveSetRequest>, IDeepCloneable<FinishMoveSetRequest>, IBufferMessage
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x001FF9F0 File Offset: 0x001FDBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishMoveSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x001FFA00 File Offset: 0x001FDC00
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x001FFA10 File Offset: 0x001FDC10
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

		// Token: 0x06004D12 RID: 19730 RVA: 0x001FFA20 File Offset: 0x001FDC20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMoveSetRequest()
		{
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x001FFA30 File Offset: 0x001FDC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMoveSetRequest(FinishMoveSetRequest other)
		{
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x001FFA40 File Offset: 0x001FDC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMoveSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x001FFA50 File Offset: 0x001FDC50
		// (set) Token: 0x06004D16 RID: 19734 RVA: 0x001FFA60 File Offset: 0x001FDC60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FinishMoveId
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

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x001FFA70 File Offset: 0x001FDC70
		// (set) Token: 0x06004D18 RID: 19736 RVA: 0x001FFA80 File Offset: 0x001FDC80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Effective
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

		// Token: 0x06004D19 RID: 19737 RVA: 0x001FFA90 File Offset: 0x001FDC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x001FFAA0 File Offset: 0x001FDCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FinishMoveSetRequest other)
		{
			return true;
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x001FFAB0 File Offset: 0x001FDCB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x001FFAC0 File Offset: 0x001FDCC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x001FFAD0 File Offset: 0x001FDCD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x001FFAE0 File Offset: 0x001FDCE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x001FFAF0 File Offset: 0x001FDCF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x001FFB00 File Offset: 0x001FDD00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FinishMoveSetRequest other)
		{
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x001FFB10 File Offset: 0x001FDD10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x001FFB20 File Offset: 0x001FDD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001FFB30 File Offset: 0x001FDD30
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FinishMoveSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					FinishMoveSetRequest._parser = new MessageParser<FinishMoveSetRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x001FFC14 File Offset: 0x001FDE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kn144mOiO1vhiQGmyTuj()
		{
			return true;
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x001FFC1C File Offset: 0x001FDE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FinishMoveSetRequest QSYcdoOiJeBlxAn1yOHL()
		{
			return null;
		}

		// Token: 0x04001AE7 RID: 6887
		private static readonly MessageParser<FinishMoveSetRequest> _parser;

		// Token: 0x04001AE8 RID: 6888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AE9 RID: 6889
		public const int FinishMoveIdFieldNumber = 1;

		// Token: 0x04001AEA RID: 6890
		private int finishMoveId_;

		// Token: 0x04001AEB RID: 6891
		public const int EffectiveFieldNumber = 2;

		// Token: 0x04001AEC RID: 6892
		private bool effective_;

		// Token: 0x04001AED RID: 6893
		private static FinishMoveSetRequest BLVjr7OiR4HYtQ7ash2v;
	}
}
