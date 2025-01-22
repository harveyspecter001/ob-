using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200051E RID: 1310
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildPaddockRemovedEvent : IMessage<GuildPaddockRemovedEvent>, IMessage, IEquatable<GuildPaddockRemovedEvent>, IDeepCloneable<GuildPaddockRemovedEvent>, IBufferMessage
	{
		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x001EBC54 File Offset: 0x001E9E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildPaddockRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x001EBC64 File Offset: 0x001E9E64
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

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x001EBC74 File Offset: 0x001E9E74
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

		// Token: 0x06003EDD RID: 16093 RVA: 0x001EBC84 File Offset: 0x001E9E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockRemovedEvent()
		{
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x001EBC94 File Offset: 0x001E9E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockRemovedEvent(GuildPaddockRemovedEvent other)
		{
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x001EBCA4 File Offset: 0x001E9EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x001EBCB4 File Offset: 0x001E9EB4
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x001EBCC4 File Offset: 0x001E9EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PaddockId
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

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001EBCD4 File Offset: 0x001E9ED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x001EBCE4 File Offset: 0x001E9EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildPaddockRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x001EBCF4 File Offset: 0x001E9EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001EBD04 File Offset: 0x001E9F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x001EBD14 File Offset: 0x001E9F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x001EBD24 File Offset: 0x001E9F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x001EBD34 File Offset: 0x001E9F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x001EBD44 File Offset: 0x001E9F44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildPaddockRemovedEvent other)
		{
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x001EBD54 File Offset: 0x001E9F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x001EBD64 File Offset: 0x001E9F64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x001EBD74 File Offset: 0x001E9F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildPaddockRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildPaddockRemovedEvent._parser = new MessageParser<GuildPaddockRemovedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 1;
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
					continue;
				}
				break;
			}
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x001EBE40 File Offset: 0x001EA040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P9BgJKOTpuTllULm1Tq5()
		{
			return true;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x001EBE48 File Offset: 0x001EA048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildPaddockRemovedEvent PpJfyIOTHC3xjU8W4Mby()
		{
			return null;
		}

		// Token: 0x040015CB RID: 5579
		private static readonly MessageParser<GuildPaddockRemovedEvent> _parser;

		// Token: 0x040015CC RID: 5580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015CD RID: 5581
		public const int PaddockIdFieldNumber = 1;

		// Token: 0x040015CE RID: 5582
		private long paddockId_;

		// Token: 0x040015CF RID: 5583
		private static GuildPaddockRemovedEvent v4RfM5OTTU87tObMY3Te;
	}
}
