using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008D4 RID: 2260
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatChannelMessageRequest : IMessage<ChatChannelMessageRequest>, IMessage, IEquatable<ChatChannelMessageRequest>, IDeepCloneable<ChatChannelMessageRequest>, IBufferMessage
	{
		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x00235B04 File Offset: 0x00233D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatChannelMessageRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x00235B14 File Offset: 0x00233D14
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

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x00235B24 File Offset: 0x00233D24
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

		// Token: 0x06006DCC RID: 28108 RVA: 0x00235B34 File Offset: 0x00233D34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageRequest()
		{
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00235B44 File Offset: 0x00233D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageRequest(ChatChannelMessageRequest other)
		{
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00235B54 File Offset: 0x00233D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageRequest Clone()
		{
			return null;
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x00235B64 File Offset: 0x00233D64
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x00235B74 File Offset: 0x00233D74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x00235B84 File Offset: 0x00233D84
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x00235B98 File Offset: 0x00233D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Channel Channel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Channel)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x00235BA8 File Offset: 0x00233DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x00235BB8 File Offset: 0x00233DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x00235BC8 File Offset: 0x00233DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatChannelMessageRequest other)
		{
			return true;
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x00235BD8 File Offset: 0x00233DD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x00235BE8 File Offset: 0x00233DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x00235BF8 File Offset: 0x00233DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x00235C08 File Offset: 0x00233E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x00235C18 File Offset: 0x00233E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00235C28 File Offset: 0x00233E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatChannelMessageRequest other)
		{
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00235C38 File Offset: 0x00233E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x00235C48 File Offset: 0x00233E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x00235C58 File Offset: 0x00233E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatChannelMessageRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ChatChannelMessageRequest._parser = new MessageParser<ChatChannelMessageRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				ChatChannelMessageRequest._repeated_object_codec = FieldCodec.ForMessage<ObjectItemInventory>(26U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
				num2 = 2;
			}
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x00235D48 File Offset: 0x00233F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PK3SPWJAp3S23nKgYmfw()
		{
			return true;
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x00235D50 File Offset: 0x00233F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatChannelMessageRequest G6v6SOJAHIRuROIimqHe()
		{
			return null;
		}

		// Token: 0x04002662 RID: 9826
		private static readonly MessageParser<ChatChannelMessageRequest> _parser;

		// Token: 0x04002663 RID: 9827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002664 RID: 9828
		public const int ContentFieldNumber = 1;

		// Token: 0x04002665 RID: 9829
		private string content_;

		// Token: 0x04002666 RID: 9830
		public const int ChannelFieldNumber = 2;

		// Token: 0x04002667 RID: 9831
		private Channel channel_;

		// Token: 0x04002668 RID: 9832
		public const int ObjectFieldNumber = 3;

		// Token: 0x04002669 RID: 9833
		private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

		// Token: 0x0400266A RID: 9834
		private readonly RepeatedField<ObjectItemInventory> object_;

		// Token: 0x0400266B RID: 9835
		private static ChatChannelMessageRequest bcMWThJATErKy7XQshK8;
	}
}
