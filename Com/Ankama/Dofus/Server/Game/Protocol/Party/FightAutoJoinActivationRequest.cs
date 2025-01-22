using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002B2 RID: 690
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinActivationRequest : IMessage<FightAutoJoinActivationRequest>, IMessage, IEquatable<FightAutoJoinActivationRequest>, IDeepCloneable<FightAutoJoinActivationRequest>, IBufferMessage
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x001B9A38 File Offset: 0x001B7C38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightAutoJoinActivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x001B9A48 File Offset: 0x001B7C48
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x001B9A58 File Offset: 0x001B7C58
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

		// Token: 0x0600202B RID: 8235 RVA: 0x001B9A68 File Offset: 0x001B7C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationRequest()
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x001B9A78 File Offset: 0x001B7C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationRequest(FightAutoJoinActivationRequest other)
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x001B9A88 File Offset: 0x001B7C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationRequest Clone()
		{
			return null;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x001B9A98 File Offset: 0x001B7C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x001B9AA8 File Offset: 0x001B7CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinActivationRequest other)
		{
			return true;
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x001B9AB8 File Offset: 0x001B7CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x001B9AC8 File Offset: 0x001B7CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x001B9AD8 File Offset: 0x001B7CD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x001B9AE8 File Offset: 0x001B7CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x001B9AF8 File Offset: 0x001B7CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x001B9B08 File Offset: 0x001B7D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinActivationRequest other)
		{
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x001B9B18 File Offset: 0x001B7D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x001B9B28 File Offset: 0x001B7D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x001B9B38 File Offset: 0x001B7D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinActivationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					FightAutoJoinActivationRequest._parser = new MessageParser<FightAutoJoinActivationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x001B9C1C File Offset: 0x001B7E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YARggWO6gNbAQCjWAiT2()
		{
			return true;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x001B9C24 File Offset: 0x001B7E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinActivationRequest vqO48qO6sFvZj8Bjl68M()
		{
			return null;
		}

		// Token: 0x04000B4E RID: 2894
		private static readonly MessageParser<FightAutoJoinActivationRequest> _parser;

		// Token: 0x04000B4F RID: 2895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B50 RID: 2896
		private static FightAutoJoinActivationRequest qKrcxpO6GiiWPTppZTNj;
	}
}
