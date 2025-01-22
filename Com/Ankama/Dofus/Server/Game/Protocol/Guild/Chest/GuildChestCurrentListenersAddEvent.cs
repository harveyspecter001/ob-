using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200054D RID: 1357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestCurrentListenersAddEvent : IMessage<GuildChestCurrentListenersAddEvent>, IMessage, IEquatable<GuildChestCurrentListenersAddEvent>, IDeepCloneable<GuildChestCurrentListenersAddEvent>, IBufferMessage
	{
		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x001EF5F0 File Offset: 0x001ED7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestCurrentListenersAddEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x001EF600 File Offset: 0x001ED800
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x001EF610 File Offset: 0x001ED810
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

		// Token: 0x0600412D RID: 16685 RVA: 0x001EF620 File Offset: 0x001ED820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersAddEvent()
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x001EF630 File Offset: 0x001ED830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersAddEvent(GuildChestCurrentListenersAddEvent other)
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x001EF640 File Offset: 0x001ED840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestCurrentListenersAddEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x001EF650 File Offset: 0x001ED850
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x001EF660 File Offset: 0x001ED860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Players
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

		// Token: 0x06004132 RID: 16690 RVA: 0x001EF670 File Offset: 0x001ED870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001EF680 File Offset: 0x001ED880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestCurrentListenersAddEvent other)
		{
			return true;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001EF690 File Offset: 0x001ED890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x001EF6A0 File Offset: 0x001ED8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x001EF6B0 File Offset: 0x001ED8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001EF6C0 File Offset: 0x001ED8C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x001EF6D0 File Offset: 0x001ED8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001EF6E0 File Offset: 0x001ED8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestCurrentListenersAddEvent other)
		{
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x001EF6F0 File Offset: 0x001ED8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x001EF700 File Offset: 0x001ED900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x001EF710 File Offset: 0x001ED910
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestCurrentListenersAddEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GuildChestCurrentListenersAddEvent._parser = new MessageParser<GuildChestCurrentListenersAddEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x001EF7DC File Offset: 0x001ED9DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cp9fSGOpMaJm7KX1Ol4G()
		{
			return true;
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x001EF7E4 File Offset: 0x001ED9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestCurrentListenersAddEvent skbPknOpuGctRvPU2eLA()
		{
			return null;
		}

		// Token: 0x0400167E RID: 5758
		private static readonly MessageParser<GuildChestCurrentListenersAddEvent> _parser;

		// Token: 0x0400167F RID: 5759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001680 RID: 5760
		public const int PlayersFieldNumber = 1;

		// Token: 0x04001681 RID: 5761
		private string players_;

		// Token: 0x04001682 RID: 5762
		private static GuildChestCurrentListenersAddEvent p9udFtOpSWHRcBkVRsn7;
	}
}
