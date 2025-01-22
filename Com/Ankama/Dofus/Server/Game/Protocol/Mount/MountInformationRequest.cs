using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000369 RID: 873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountInformationRequest : IMessage<MountInformationRequest>, IMessage, IEquatable<MountInformationRequest>, IDeepCloneable<MountInformationRequest>, IBufferMessage
	{
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x001C71B4 File Offset: 0x001C53B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x001C71C4 File Offset: 0x001C53C4
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

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x001C71D4 File Offset: 0x001C53D4
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

		// Token: 0x060028F2 RID: 10482 RVA: 0x001C71E4 File Offset: 0x001C53E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationRequest()
		{
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x001C71F4 File Offset: 0x001C53F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationRequest(MountInformationRequest other)
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x001C7204 File Offset: 0x001C5404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x001C7214 File Offset: 0x001C5414
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x001C7224 File Offset: 0x001C5424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MountId
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

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x001C7234 File Offset: 0x001C5434
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x001C7244 File Offset: 0x001C5444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x001C7254 File Offset: 0x001C5454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x001C7264 File Offset: 0x001C5464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountInformationRequest other)
		{
			return true;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x001C7274 File Offset: 0x001C5474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x001C7284 File Offset: 0x001C5484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x001C7294 File Offset: 0x001C5494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x001C72A4 File Offset: 0x001C54A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x001C72B4 File Offset: 0x001C54B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x001C72C4 File Offset: 0x001C54C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountInformationRequest other)
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x001C72D4 File Offset: 0x001C54D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x001C72E4 File Offset: 0x001C54E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x001C72F4 File Offset: 0x001C54F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MountInformationRequest._parser = new MessageParser<MountInformationRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x001C73C0 File Offset: 0x001C55C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vtoWlVOhuMeTlsgBKw5f()
		{
			return true;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x001C73C8 File Offset: 0x001C55C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountInformationRequest j8vnNvOh8XhEI1h6po9G()
		{
			return null;
		}

		// Token: 0x04000E89 RID: 3721
		private static readonly MessageParser<MountInformationRequest> _parser;

		// Token: 0x04000E8A RID: 3722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E8B RID: 3723
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000E8C RID: 3724
		private int mountId_;

		// Token: 0x04000E8D RID: 3725
		public const int TimeFieldNumber = 2;

		// Token: 0x04000E8E RID: 3726
		private long time_;

		// Token: 0x04000E8F RID: 3727
		internal static MountInformationRequest gjAxe0OhM9taCOvxZHqh;
	}
}
