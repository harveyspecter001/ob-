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
	// Token: 0x0200051C RID: 1308
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildPaddockBoughtEvent : IMessage<GuildPaddockBoughtEvent>, IMessage, IEquatable<GuildPaddockBoughtEvent>, IDeepCloneable<GuildPaddockBoughtEvent>, IBufferMessage
	{
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x001EBA50 File Offset: 0x001E9C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildPaddockBoughtEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x001EBA60 File Offset: 0x001E9C60
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

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x001EBA70 File Offset: 0x001E9C70
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

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001EBA80 File Offset: 0x001E9C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockBoughtEvent()
		{
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x001EBA90 File Offset: 0x001E9C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockBoughtEvent(GuildPaddockBoughtEvent other)
		{
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x001EBAA0 File Offset: 0x001E9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockBoughtEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x001EBAB0 File Offset: 0x001E9CB0
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x001EBAC0 File Offset: 0x001E9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PaddockInformation Paddock
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

		// Token: 0x06003EC8 RID: 16072 RVA: 0x001EBAD0 File Offset: 0x001E9CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x001EBAE0 File Offset: 0x001E9CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildPaddockBoughtEvent other)
		{
			return true;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x001EBAF0 File Offset: 0x001E9CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x001EBB00 File Offset: 0x001E9D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x001EBB10 File Offset: 0x001E9D10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x001EBB20 File Offset: 0x001E9D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x001EBB30 File Offset: 0x001E9D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x001EBB40 File Offset: 0x001E9D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildPaddockBoughtEvent other)
		{
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x001EBB50 File Offset: 0x001E9D50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x001EBB60 File Offset: 0x001E9D60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x001EBB70 File Offset: 0x001E9D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildPaddockBoughtEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						goto IL_B0;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						goto IL_36;
					case 4:
						GuildPaddockBoughtEvent._parser = new MessageParser<GuildPaddockBoughtEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_36:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
				continue;
				IL_B0:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x001EBC44 File Offset: 0x001E9E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WptwUFOTQ9YFVwS2wyuK()
		{
			return true;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x001EBC4C File Offset: 0x001E9E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildPaddockBoughtEvent Y1jxx9OT76175QGTZLPQ()
		{
			return null;
		}

		// Token: 0x040015C4 RID: 5572
		private static readonly MessageParser<GuildPaddockBoughtEvent> _parser;

		// Token: 0x040015C5 RID: 5573
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015C6 RID: 5574
		public const int PaddockFieldNumber = 1;

		// Token: 0x040015C7 RID: 5575
		private PaddockInformation paddock_;

		// Token: 0x040015C8 RID: 5576
		internal static GuildPaddockBoughtEvent HmjublOTw35cvxVbIrgY;
	}
}
