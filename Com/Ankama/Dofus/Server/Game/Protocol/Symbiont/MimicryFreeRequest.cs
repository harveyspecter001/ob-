using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x02000106 RID: 262
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MimicryFreeRequest : IMessage<MimicryFreeRequest>, IMessage, IEquatable<MimicryFreeRequest>, IDeepCloneable<MimicryFreeRequest>, IBufferMessage
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00196654 File Offset: 0x00194854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MimicryFreeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00196664 File Offset: 0x00194864
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00196674 File Offset: 0x00194874
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00196684 File Offset: 0x00194884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeRequest()
		{
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00196694 File Offset: 0x00194894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeRequest(MimicryFreeRequest other)
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x001966A4 File Offset: 0x001948A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x001966B4 File Offset: 0x001948B4
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x001966C4 File Offset: 0x001948C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostUid
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

		// Token: 0x06000BF2 RID: 3058 RVA: 0x001966D4 File Offset: 0x001948D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x001966E4 File Offset: 0x001948E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MimicryFreeRequest other)
		{
			return true;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x001966F4 File Offset: 0x001948F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00196704 File Offset: 0x00194904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00196714 File Offset: 0x00194914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00196724 File Offset: 0x00194924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00196734 File Offset: 0x00194934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00196744 File Offset: 0x00194944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MimicryFreeRequest other)
		{
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00196754 File Offset: 0x00194954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00196764 File Offset: 0x00194964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00196774 File Offset: 0x00194974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MimicryFreeRequest()
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
						goto IL_35;
					case 1:
						goto IL_87;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_35:
				MimicryFreeRequest._parser = new MessageParser<MimicryFreeRequest>(() => null);
				num = 3;
				continue;
				IL_87:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00196848 File Offset: 0x00194A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nqdhUQOlPRvVTn0GLK4t()
		{
			return true;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00196850 File Offset: 0x00194A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MimicryFreeRequest M66jp0OlS57JH7AwHHXb()
		{
			return null;
		}

		// Token: 0x04000457 RID: 1111
		private static readonly MessageParser<MimicryFreeRequest> _parser;

		// Token: 0x04000458 RID: 1112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000459 RID: 1113
		public const int HostUidFieldNumber = 1;

		// Token: 0x0400045A RID: 1114
		private int hostUid_;

		// Token: 0x0400045B RID: 1115
		internal static MimicryFreeRequest SjqnIaOliKxL1qvxuLIE;
	}
}
