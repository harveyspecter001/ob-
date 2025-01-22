using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004FA RID: 1274
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildJoinAutomaticallyRequest : IMessage<GuildJoinAutomaticallyRequest>, IMessage, IEquatable<GuildJoinAutomaticallyRequest>, IDeepCloneable<GuildJoinAutomaticallyRequest>, IBufferMessage
	{
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x001E9494 File Offset: 0x001E7694
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildJoinAutomaticallyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x001E94A4 File Offset: 0x001E76A4
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

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x001E94B4 File Offset: 0x001E76B4
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

		// Token: 0x06003CED RID: 15597 RVA: 0x001E94C4 File Offset: 0x001E76C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinAutomaticallyRequest()
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x001E94D4 File Offset: 0x001E76D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinAutomaticallyRequest(GuildJoinAutomaticallyRequest other)
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x001E94E4 File Offset: 0x001E76E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildJoinAutomaticallyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x001E94F4 File Offset: 0x001E76F4
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x001E9504 File Offset: 0x001E7704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GuildId
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

		// Token: 0x06003CF2 RID: 15602 RVA: 0x001E9514 File Offset: 0x001E7714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x001E9524 File Offset: 0x001E7724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildJoinAutomaticallyRequest other)
		{
			return true;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x001E9534 File Offset: 0x001E7734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x001E9544 File Offset: 0x001E7744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x001E9554 File Offset: 0x001E7754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x001E9564 File Offset: 0x001E7764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x001E9574 File Offset: 0x001E7774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x001E9584 File Offset: 0x001E7784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildJoinAutomaticallyRequest other)
		{
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x001E9594 File Offset: 0x001E7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x001E95A4 File Offset: 0x001E77A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x001E95B4 File Offset: 0x001E77B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildJoinAutomaticallyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					GuildJoinAutomaticallyRequest._parser = new MessageParser<GuildJoinAutomaticallyRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x001E96AC File Offset: 0x001E78AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fsk5ZRO7u73QVJ2E86u6()
		{
			return true;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x001E96B4 File Offset: 0x001E78B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildJoinAutomaticallyRequest LBc17aO78xgO3xjVVFg7()
		{
			return null;
		}

		// Token: 0x04001529 RID: 5417
		private static readonly MessageParser<GuildJoinAutomaticallyRequest> _parser;

		// Token: 0x0400152A RID: 5418
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400152B RID: 5419
		public const int GuildIdFieldNumber = 1;

		// Token: 0x0400152C RID: 5420
		private int guildId_;

		// Token: 0x0400152D RID: 5421
		private static GuildJoinAutomaticallyRequest iB9j4UO7MRaC1xNelDsr;
	}
}
