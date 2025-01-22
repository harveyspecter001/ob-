using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BBA RID: 3002
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoAmIRequest : IMessage<WhoAmIRequest>, IMessage, IEquatable<WhoAmIRequest>, IDeepCloneable<WhoAmIRequest>, IBufferMessage
	{
		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x0600906A RID: 36970 RVA: 0x0026E648 File Offset: 0x0026C848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WhoAmIRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600906B RID: 36971 RVA: 0x0026E658 File Offset: 0x0026C858
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600906C RID: 36972 RVA: 0x0026E668 File Offset: 0x0026C868
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

		// Token: 0x0600906D RID: 36973 RVA: 0x0026E678 File Offset: 0x0026C878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoAmIRequest()
		{
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0026E688 File Offset: 0x0026C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoAmIRequest(WhoAmIRequest other)
		{
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x0026E698 File Offset: 0x0026C898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoAmIRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06009070 RID: 36976 RVA: 0x0026E6A8 File Offset: 0x0026C8A8
		// (set) Token: 0x06009071 RID: 36977 RVA: 0x0026E6B8 File Offset: 0x0026C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Verbose
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

		// Token: 0x06009072 RID: 36978 RVA: 0x0026E6C8 File Offset: 0x0026C8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x0026E6D8 File Offset: 0x0026C8D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoAmIRequest other)
		{
			return true;
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x0026E6E8 File Offset: 0x0026C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x0026E6F8 File Offset: 0x0026C8F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x0026E708 File Offset: 0x0026C908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009077 RID: 36983 RVA: 0x0026E718 File Offset: 0x0026C918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x0026E728 File Offset: 0x0026C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x0026E738 File Offset: 0x0026C938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoAmIRequest other)
		{
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x0026E748 File Offset: 0x0026C948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0026E758 File Offset: 0x0026C958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0026E768 File Offset: 0x0026C968
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoAmIRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				WhoAmIRequest._parser = new MessageParser<WhoAmIRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0026E84C File Offset: 0x0026CA4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P9SCnKJ2jQsGguo5JLsT()
		{
			return true;
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x0026E854 File Offset: 0x0026CA54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoAmIRequest xtLnDPJ2KLDOATP0FbN9()
		{
			return null;
		}

		// Token: 0x040035C6 RID: 13766
		private static readonly MessageParser<WhoAmIRequest> _parser;

		// Token: 0x040035C7 RID: 13767
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C8 RID: 13768
		public const int VerboseFieldNumber = 1;

		// Token: 0x040035C9 RID: 13769
		private bool verbose_;

		// Token: 0x040035CA RID: 13770
		internal static WhoAmIRequest ykVkhEJ24SZ3jti2ITPq;
	}
}
