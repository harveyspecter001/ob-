using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x02000100 RID: 256
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WrapperObjectDissociateRequest : IMessage<WrapperObjectDissociateRequest>, IMessage, IEquatable<WrapperObjectDissociateRequest>, IDeepCloneable<WrapperObjectDissociateRequest>, IBufferMessage
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00195FD8 File Offset: 0x001941D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WrapperObjectDissociateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00195FE8 File Offset: 0x001941E8
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00195FF8 File Offset: 0x001941F8
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x00196008 File Offset: 0x00194208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperObjectDissociateRequest()
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00196018 File Offset: 0x00194218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperObjectDissociateRequest(WrapperObjectDissociateRequest other)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00196028 File Offset: 0x00194228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperObjectDissociateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00196038 File Offset: 0x00194238
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00196048 File Offset: 0x00194248
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00196058 File Offset: 0x00194258
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00196068 File Offset: 0x00194268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPosition
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

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00196078 File Offset: 0x00194278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00196088 File Offset: 0x00194288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WrapperObjectDissociateRequest other)
		{
			return true;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00196098 File Offset: 0x00194298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x001960A8 File Offset: 0x001942A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x001960B8 File Offset: 0x001942B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x001960C8 File Offset: 0x001942C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x001960D8 File Offset: 0x001942D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x001960E8 File Offset: 0x001942E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WrapperObjectDissociateRequest other)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x001960F8 File Offset: 0x001942F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00196108 File Offset: 0x00194308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00196118 File Offset: 0x00194318
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperObjectDissociateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				WrapperObjectDissociateRequest._parser = new MessageParser<WrapperObjectDissociateRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00196210 File Offset: 0x00194410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jysWYjOlwUKf5dWoQMK4()
		{
			return true;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00196218 File Offset: 0x00194418
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperObjectDissociateRequest HDZbDgOlQf7GNT2vcYeI()
		{
			return null;
		}

		// Token: 0x0400043E RID: 1086
		private static readonly MessageParser<WrapperObjectDissociateRequest> _parser;

		// Token: 0x0400043F RID: 1087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000440 RID: 1088
		public const int HostUidFieldNumber = 1;

		// Token: 0x04000441 RID: 1089
		private int hostUid_;

		// Token: 0x04000442 RID: 1090
		public const int HostPositionFieldNumber = 2;

		// Token: 0x04000443 RID: 1091
		private int hostPosition_;

		// Token: 0x04000444 RID: 1092
		internal static WrapperObjectDissociateRequest MxO8LSOltKAUKitqf863;
	}
}
