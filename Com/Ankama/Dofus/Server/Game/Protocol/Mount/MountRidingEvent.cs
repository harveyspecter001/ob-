using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000389 RID: 905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountRidingEvent : IMessage<MountRidingEvent>, IMessage, IEquatable<MountRidingEvent>, IDeepCloneable<MountRidingEvent>, IBufferMessage
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x001C8E74 File Offset: 0x001C7074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountRidingEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x001C8E84 File Offset: 0x001C7084
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x001C8E94 File Offset: 0x001C7094
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

		// Token: 0x06002A60 RID: 10848 RVA: 0x001C8EA4 File Offset: 0x001C70A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRidingEvent()
		{
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x001C8EB4 File Offset: 0x001C70B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRidingEvent(MountRidingEvent other)
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x001C8EC4 File Offset: 0x001C70C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRidingEvent Clone()
		{
			return null;
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x001C8ED4 File Offset: 0x001C70D4
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x001C8EE4 File Offset: 0x001C70E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsRiding
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

		// Token: 0x06002A65 RID: 10853 RVA: 0x001C8EF4 File Offset: 0x001C70F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x001C8F04 File Offset: 0x001C7104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountRidingEvent other)
		{
			return true;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x001C8F14 File Offset: 0x001C7114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x001C8F24 File Offset: 0x001C7124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x001C8F34 File Offset: 0x001C7134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x001C8F44 File Offset: 0x001C7144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x001C8F54 File Offset: 0x001C7154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x001C8F64 File Offset: 0x001C7164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountRidingEvent other)
		{
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x001C8F74 File Offset: 0x001C7174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x001C8F84 File Offset: 0x001C7184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x001C8F94 File Offset: 0x001C7194
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountRidingEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				MountRidingEvent._parser = new MessageParser<MountRidingEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x001C9078 File Offset: 0x001C7278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GVTjx6OrW2sxNEdQL205()
		{
			return true;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x001C9080 File Offset: 0x001C7280
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountRidingEvent PRvGJYOrhay1apRvwPCd()
		{
			return null;
		}

		// Token: 0x04000EF4 RID: 3828
		private static readonly MessageParser<MountRidingEvent> _parser;

		// Token: 0x04000EF5 RID: 3829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EF6 RID: 3830
		public const int IsRidingFieldNumber = 1;

		// Token: 0x04000EF7 RID: 3831
		private bool isRiding_;

		// Token: 0x04000EF8 RID: 3832
		private static MountRidingEvent QqShUXOrL348EJWchxQP;
	}
}
