using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200050A RID: 1290
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCreationStartedEvent : IMessage<GuildCreationStartedEvent>, IMessage, IEquatable<GuildCreationStartedEvent>, IDeepCloneable<GuildCreationStartedEvent>, IBufferMessage
	{
		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x001EA618 File Offset: 0x001E8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildCreationStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x001EA628 File Offset: 0x001E8828
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

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x001EA638 File Offset: 0x001E8838
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

		// Token: 0x06003DC4 RID: 15812 RVA: 0x001EA648 File Offset: 0x001E8848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationStartedEvent()
		{
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x001EA658 File Offset: 0x001E8858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationStartedEvent(GuildCreationStartedEvent other)
		{
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x001EA668 File Offset: 0x001E8868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x001EA678 File Offset: 0x001E8878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x001EA688 File Offset: 0x001E8888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCreationStartedEvent other)
		{
			return true;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x001EA698 File Offset: 0x001E8898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x001EA6A8 File Offset: 0x001E88A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x001EA6B8 File Offset: 0x001E88B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x001EA6C8 File Offset: 0x001E88C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x001EA6D8 File Offset: 0x001E88D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x001EA6E8 File Offset: 0x001E88E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCreationStartedEvent other)
		{
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x001EA6F8 File Offset: 0x001E88F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001EA708 File Offset: 0x001E8908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x001EA718 File Offset: 0x001E8918
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCreationStartedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				GuildCreationStartedEvent._parser = new MessageParser<GuildCreationStartedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001EA7FC File Offset: 0x001E89FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jX17EwOTNK4C2QYvsBpK()
		{
			return true;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x001EA804 File Offset: 0x001E8A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCreationStartedEvent yi1GLoOTxQtF2XhWEKO6()
		{
			return null;
		}

		// Token: 0x0400156E RID: 5486
		private static readonly MessageParser<GuildCreationStartedEvent> _parser;

		// Token: 0x0400156F RID: 5487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001570 RID: 5488
		internal static GuildCreationStartedEvent o2IgVAOTXNq03CAsBoZg;
	}
}
