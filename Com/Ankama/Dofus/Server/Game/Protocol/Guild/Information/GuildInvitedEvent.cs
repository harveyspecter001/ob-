using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000512 RID: 1298
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInvitedEvent : IMessage<GuildInvitedEvent>, IMessage, IEquatable<GuildInvitedEvent>, IDeepCloneable<GuildInvitedEvent>, IBufferMessage
	{
		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x001EAE84 File Offset: 0x001E9084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildInvitedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x001EAE94 File Offset: 0x001E9094
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

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x001EAEA4 File Offset: 0x001E90A4
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x001EAEB4 File Offset: 0x001E90B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitedEvent()
		{
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x001EAEC4 File Offset: 0x001E90C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitedEvent(GuildInvitedEvent other)
		{
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x001EAED4 File Offset: 0x001E90D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x001EAEE4 File Offset: 0x001E90E4
		// (set) Token: 0x06003E30 RID: 15920 RVA: 0x001EAEF4 File Offset: 0x001E90F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RecruiterName
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

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x001EAF04 File Offset: 0x001E9104
		// (set) Token: 0x06003E32 RID: 15922 RVA: 0x001EAF14 File Offset: 0x001E9114
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation GuildInformation
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

		// Token: 0x06003E33 RID: 15923 RVA: 0x001EAF24 File Offset: 0x001E9124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x001EAF34 File Offset: 0x001E9134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInvitedEvent other)
		{
			return true;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x001EAF44 File Offset: 0x001E9144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x001EAF54 File Offset: 0x001E9154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x001EAF64 File Offset: 0x001E9164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x001EAF74 File Offset: 0x001E9174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001EAF84 File Offset: 0x001E9184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x001EAF94 File Offset: 0x001E9194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInvitedEvent other)
		{
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x001EAFA4 File Offset: 0x001E91A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x001EAFB4 File Offset: 0x001E91B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x001EAFC4 File Offset: 0x001E91C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInvitedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildInvitedEvent._parser = new MessageParser<GuildInvitedEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x001EB0A8 File Offset: 0x001E92A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MIo6qYOT1M4BxD5VwcLb()
		{
			return true;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x001EB0B0 File Offset: 0x001E92B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInvitedEvent OprUtDOTatdCQEXeEbBC()
		{
			return null;
		}

		// Token: 0x0400158A RID: 5514
		private static readonly MessageParser<GuildInvitedEvent> _parser;

		// Token: 0x0400158B RID: 5515
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400158C RID: 5516
		public const int RecruiterNameFieldNumber = 1;

		// Token: 0x0400158D RID: 5517
		private string recruiterName_;

		// Token: 0x0400158E RID: 5518
		public const int GuildInformationFieldNumber = 2;

		// Token: 0x0400158F RID: 5519
		private GuildInformation guildInformation_;

		// Token: 0x04001590 RID: 5520
		internal static GuildInvitedEvent A7BFBtOToSnWPohQiRmF;
	}
}
