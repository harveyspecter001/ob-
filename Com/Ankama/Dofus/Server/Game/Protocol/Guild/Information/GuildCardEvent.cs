using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200052A RID: 1322
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCardEvent : IMessage<GuildCardEvent>, IMessage, IEquatable<GuildCardEvent>, IDeepCloneable<GuildCardEvent>, IBufferMessage
	{
		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x001EC850 File Offset: 0x001EAA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildCardEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x001EC860 File Offset: 0x001EAA60
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x001EC870 File Offset: 0x001EAA70
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

		// Token: 0x06003F79 RID: 16249 RVA: 0x001EC880 File Offset: 0x001EAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardEvent()
		{
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x001EC890 File Offset: 0x001EAA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardEvent(GuildCardEvent other)
		{
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x001EC8A0 File Offset: 0x001EAAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06003F7C RID: 16252 RVA: 0x001EC8B0 File Offset: 0x001EAAB0
		// (set) Token: 0x06003F7D RID: 16253 RVA: 0x001EC8C0 File Offset: 0x001EAAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildInformation Info
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

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x001EC8D0 File Offset: 0x001EAAD0
		// (set) Token: 0x06003F7F RID: 16255 RVA: 0x001EC8E0 File Offset: 0x001EAAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CreationDate
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

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x001EC8F0 File Offset: 0x001EAAF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Character> Members
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x001EC900 File Offset: 0x001EAB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x001EC910 File Offset: 0x001EAB10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCardEvent other)
		{
			return true;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x001EC920 File Offset: 0x001EAB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x001EC930 File Offset: 0x001EAB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x001EC940 File Offset: 0x001EAB40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x001EC950 File Offset: 0x001EAB50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x001EC960 File Offset: 0x001EAB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x001EC970 File Offset: 0x001EAB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCardEvent other)
		{
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x001EC980 File Offset: 0x001EAB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x001EC990 File Offset: 0x001EAB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x001EC9A0 File Offset: 0x001EABA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCardEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GuildCardEvent._repeated_members_codec = FieldCodec.ForMessage<Character>(26U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					GuildCardEvent._parser = new MessageParser<GuildCardEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x001ECABC File Offset: 0x001EACBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gEHlNKOpBB4mUY6pv1qJ()
		{
			return true;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x001ECAC4 File Offset: 0x001EACC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCardEvent pPmdrrOpewYwrSx8AQls()
		{
			return null;
		}

		// Token: 0x040015F5 RID: 5621
		private static readonly MessageParser<GuildCardEvent> _parser;

		// Token: 0x040015F6 RID: 5622
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015F7 RID: 5623
		public const int InfoFieldNumber = 1;

		// Token: 0x040015F8 RID: 5624
		private GuildInformation info_;

		// Token: 0x040015F9 RID: 5625
		public const int CreationDateFieldNumber = 2;

		// Token: 0x040015FA RID: 5626
		private int creationDate_;

		// Token: 0x040015FB RID: 5627
		public const int MembersFieldNumber = 3;

		// Token: 0x040015FC RID: 5628
		private static readonly FieldCodec<Character> _repeated_members_codec;

		// Token: 0x040015FD RID: 5629
		private readonly RepeatedField<Character> members_;

		// Token: 0x040015FE RID: 5630
		private static GuildCardEvent tRNswfOpAQS8aRjWUtj2;
	}
}
