using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008AA RID: 2218
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerSessionReadyEvent : IMessage<ServerSessionReadyEvent>, IMessage, IEquatable<ServerSessionReadyEvent>, IDeepCloneable<ServerSessionReadyEvent>, IBufferMessage
	{
		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06006BBA RID: 27578 RVA: 0x00231A74 File Offset: 0x0022FC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerSessionReadyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x00231A84 File Offset: 0x0022FC84
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

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06006BBC RID: 27580 RVA: 0x00231A94 File Offset: 0x0022FC94
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

		// Token: 0x06006BBD RID: 27581 RVA: 0x00231AA4 File Offset: 0x0022FCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionReadyEvent()
		{
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00231AB4 File Offset: 0x0022FCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionReadyEvent(ServerSessionReadyEvent other)
		{
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00231AC4 File Offset: 0x0022FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerSessionReadyEvent Clone()
		{
			return null;
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00231AD4 File Offset: 0x0022FCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00231AE4 File Offset: 0x0022FCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerSessionReadyEvent other)
		{
			return true;
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00231AF4 File Offset: 0x0022FCF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00231B04 File Offset: 0x0022FD04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00231B14 File Offset: 0x0022FD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00231B24 File Offset: 0x0022FD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00231B34 File Offset: 0x0022FD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x00231B44 File Offset: 0x0022FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerSessionReadyEvent other)
		{
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x00231B54 File Offset: 0x0022FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00231B64 File Offset: 0x0022FD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00231B74 File Offset: 0x0022FD74
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerSessionReadyEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					ServerSessionReadyEvent._parser = new MessageParser<ServerSessionReadyEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00231C40 File Offset: 0x0022FE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kNZassJmwm7T979N9TTj()
		{
			return true;
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00231C48 File Offset: 0x0022FE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerSessionReadyEvent kfOpAhJmQvj9Tyky1dTb()
		{
			return null;
		}

		// Token: 0x040025A2 RID: 9634
		private static readonly MessageParser<ServerSessionReadyEvent> _parser;

		// Token: 0x040025A3 RID: 9635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A4 RID: 9636
		internal static ServerSessionReadyEvent cfTxWSJmt3vZX8NLg6oT;
	}
}
