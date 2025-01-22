using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002A8 RID: 680
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowDeactivationRequest : IMessage<AutoFollowDeactivationRequest>, IMessage, IEquatable<AutoFollowDeactivationRequest>, IDeepCloneable<AutoFollowDeactivationRequest>, IBufferMessage
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x001B91E0 File Offset: 0x001B73E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AutoFollowDeactivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x001B91F0 File Offset: 0x001B73F0
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

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x001B9200 File Offset: 0x001B7400
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

		// Token: 0x06001FC0 RID: 8128 RVA: 0x001B9210 File Offset: 0x001B7410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationRequest()
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x001B9220 File Offset: 0x001B7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationRequest(AutoFollowDeactivationRequest other)
		{
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x001B9230 File Offset: 0x001B7430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationRequest Clone()
		{
			return null;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x001B9240 File Offset: 0x001B7440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x001B9250 File Offset: 0x001B7450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowDeactivationRequest other)
		{
			return true;
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x001B9260 File Offset: 0x001B7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x001B9270 File Offset: 0x001B7470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x001B9280 File Offset: 0x001B7480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x001B9290 File Offset: 0x001B7490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x001B92A0 File Offset: 0x001B74A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x001B92B0 File Offset: 0x001B74B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowDeactivationRequest other)
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x001B92C0 File Offset: 0x001B74C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x001B92D0 File Offset: 0x001B74D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x001B92E0 File Offset: 0x001B74E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowDeactivationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AutoFollowDeactivationRequest._parser = new MessageParser<AutoFollowDeactivationRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x001B93D8 File Offset: 0x001B75D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gi2FojOyzk0uVMv3PcSA()
		{
			return true;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x001B93E0 File Offset: 0x001B75E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowDeactivationRequest tB5SsiO6fiUXcrvnG8MT()
		{
			return null;
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly MessageParser<AutoFollowDeactivationRequest> _parser;

		// Token: 0x04000B2E RID: 2862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B2F RID: 2863
		internal static AutoFollowDeactivationRequest trkRSpOyFcdOgTQ4OOC9;
	}
}
