using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000DFE RID: 3582
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Event : IMessage<Event>, IMessage, IEquatable<Event>, IDeepCloneable<Event>, IBufferMessage
	{
		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x0600AC6D RID: 44141 RVA: 0x0029E678 File Offset: 0x0029C878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Event> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x0029E688 File Offset: 0x0029C888
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x0029E698 File Offset: 0x0029C898
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

		// Token: 0x0600AC70 RID: 44144 RVA: 0x0029E6A8 File Offset: 0x0029C8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event()
		{
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x0029E6B8 File Offset: 0x0029C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event(Event other)
		{
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x0029E6C8 File Offset: 0x0029C8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event Clone()
		{
			return null;
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x0029E6D8 File Offset: 0x0029C8D8
		// (set) Token: 0x0600AC74 RID: 44148 RVA: 0x0029E6E8 File Offset: 0x0029C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Server Server
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

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x0029E6F8 File Offset: 0x0029C8F8
		// (set) Token: 0x0600AC76 RID: 44150 RVA: 0x0029E708 File Offset: 0x0029C908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerEvent UpdateServerEvent
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

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x0029E718 File Offset: 0x0029C918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Event.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Event.ContentOneofCase)null;
			}
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x0029E72C File Offset: 0x0029C92C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x0029E73C File Offset: 0x0029C93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x0029E74C File Offset: 0x0029C94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Event other)
		{
			return true;
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x0029E75C File Offset: 0x0029C95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x0029E76C File Offset: 0x0029C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x0029E77C File Offset: 0x0029C97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x0029E78C File Offset: 0x0029C98C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x0029E79C File Offset: 0x0029C99C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x0029E7AC File Offset: 0x0029C9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Event other)
		{
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x0029E7BC File Offset: 0x0029C9BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x0029E7CC File Offset: 0x0029C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x0029E7DC File Offset: 0x0029C9DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Event()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
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
					Event._parser = new MessageParser<Event>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x0029E8A8 File Offset: 0x0029CAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nINoXXJU1MjI9nxUg4lV()
		{
			return true;
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x0029E8B0 File Offset: 0x0029CAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Event Kf66sbJUa9H16bJf9nyH()
		{
			return null;
		}

		// Token: 0x04003F60 RID: 16224
		private static readonly MessageParser<Event> _parser;

		// Token: 0x04003F61 RID: 16225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F62 RID: 16226
		public const int ServerFieldNumber = 1;

		// Token: 0x04003F63 RID: 16227
		public const int UpdateServerEventFieldNumber = 2;

		// Token: 0x04003F64 RID: 16228
		private object content_;

		// Token: 0x04003F65 RID: 16229
		private Event.ContentOneofCase contentCase_;

		// Token: 0x04003F66 RID: 16230
		internal static Event PVEANGJUom9OIkUqAOZp;

		// Token: 0x02000DFF RID: 3583
		public enum ContentOneofCase
		{
			// Token: 0x04003F68 RID: 16232
			None,
			// Token: 0x04003F69 RID: 16233
			Server,
			// Token: 0x04003F6A RID: 16234
			UpdateServerEvent
		}
	}
}
