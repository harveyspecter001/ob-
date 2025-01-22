using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000562 RID: 1378
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationDeletedEvent : IMessage<GuildApplicationDeletedEvent>, IMessage, IEquatable<GuildApplicationDeletedEvent>, IDeepCloneable<GuildApplicationDeletedEvent>, IBufferMessage
	{
		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x001F1BDC File Offset: 0x001EFDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildApplicationDeletedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x001F1BEC File Offset: 0x001EFDEC
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

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x001F1BFC File Offset: 0x001EFDFC
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

		// Token: 0x0600424D RID: 16973 RVA: 0x001F1C0C File Offset: 0x001EFE0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeletedEvent()
		{
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x001F1C1C File Offset: 0x001EFE1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeletedEvent(GuildApplicationDeletedEvent other)
		{
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x001F1C2C File Offset: 0x001EFE2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeletedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x001F1C3C File Offset: 0x001EFE3C
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x001F1C4C File Offset: 0x001EFE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deleted
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

		// Token: 0x06004252 RID: 16978 RVA: 0x001F1C5C File Offset: 0x001EFE5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x001F1C6C File Offset: 0x001EFE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationDeletedEvent other)
		{
			return true;
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x001F1C7C File Offset: 0x001EFE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x001F1C8C File Offset: 0x001EFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x001F1C9C File Offset: 0x001EFE9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x001F1CAC File Offset: 0x001EFEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x001F1CBC File Offset: 0x001EFEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x001F1CCC File Offset: 0x001EFECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationDeletedEvent other)
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x001F1CDC File Offset: 0x001EFEDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x001F1CEC File Offset: 0x001EFEEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x001F1CFC File Offset: 0x001EFEFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationDeletedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					GuildApplicationDeletedEvent._parser = new MessageParser<GuildApplicationDeletedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x001F1DE0 File Offset: 0x001EFFE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M0VMIgOHcUQpxAjj0NNC()
		{
			return true;
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x001F1DE8 File Offset: 0x001EFFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationDeletedEvent WKGXA3OHUt6BB5FNGIDC()
		{
			return null;
		}

		// Token: 0x040016DE RID: 5854
		private static readonly MessageParser<GuildApplicationDeletedEvent> _parser;

		// Token: 0x040016DF RID: 5855
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016E0 RID: 5856
		public const int DeletedFieldNumber = 1;

		// Token: 0x040016E1 RID: 5857
		private bool deleted_;

		// Token: 0x040016E2 RID: 5858
		internal static GuildApplicationDeletedEvent oxxRlwOHlTphliwGX0JQ;
	}
}
