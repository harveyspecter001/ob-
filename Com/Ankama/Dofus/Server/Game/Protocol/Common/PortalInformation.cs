using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B70 RID: 2928
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PortalInformation : IMessage<PortalInformation>, IMessage, IEquatable<PortalInformation>, IDeepCloneable<PortalInformation>, IBufferMessage
	{
		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x00269878 File Offset: 0x00267A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PortalInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x00269888 File Offset: 0x00267A88
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

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x00269898 File Offset: 0x00267A98
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

		// Token: 0x06008C79 RID: 35961 RVA: 0x002698A8 File Offset: 0x00267AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalInformation()
		{
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x002698B8 File Offset: 0x00267AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalInformation(PortalInformation other)
		{
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x002698C8 File Offset: 0x00267AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06008C7C RID: 35964 RVA: 0x002698D8 File Offset: 0x00267AD8
		// (set) Token: 0x06008C7D RID: 35965 RVA: 0x002698E8 File Offset: 0x00267AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortalId
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06008C7E RID: 35966 RVA: 0x002698F8 File Offset: 0x00267AF8
		// (set) Token: 0x06008C7F RID: 35967 RVA: 0x00269908 File Offset: 0x00267B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AreaId
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

		// Token: 0x06008C80 RID: 35968 RVA: 0x00269918 File Offset: 0x00267B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00269928 File Offset: 0x00267B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PortalInformation other)
		{
			return true;
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00269938 File Offset: 0x00267B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x00269948 File Offset: 0x00267B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00269958 File Offset: 0x00267B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x00269968 File Offset: 0x00267B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x00269978 File Offset: 0x00267B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00269988 File Offset: 0x00267B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PortalInformation other)
		{
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00269998 File Offset: 0x00267B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x002699A8 File Offset: 0x00267BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x002699B8 File Offset: 0x00267BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PortalInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					PortalInformation._parser = new MessageParser<PortalInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00269A84 File Offset: 0x00267C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cHicGcJ9g0jHCDSJp62D()
		{
			return true;
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x00269A8C File Offset: 0x00267C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PortalInformation zcmrAMJ9sn1i4EFj81QA()
		{
			return null;
		}

		// Token: 0x040033E8 RID: 13288
		private static readonly MessageParser<PortalInformation> _parser;

		// Token: 0x040033E9 RID: 13289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033EA RID: 13290
		public const int PortalIdFieldNumber = 1;

		// Token: 0x040033EB RID: 13291
		private int portalId_;

		// Token: 0x040033EC RID: 13292
		public const int AreaIdFieldNumber = 2;

		// Token: 0x040033ED RID: 13293
		private int areaId_;

		// Token: 0x040033EE RID: 13294
		internal static PortalInformation RJxDbHJ9G5W526clZGBp;
	}
}
