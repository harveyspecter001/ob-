using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000502 RID: 1282
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCardRequest : IMessage<GuildCardRequest>, IMessage, IEquatable<GuildCardRequest>, IDeepCloneable<GuildCardRequest>, IBufferMessage
	{
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x001E9CE4 File Offset: 0x001E7EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildCardRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x001E9CF4 File Offset: 0x001E7EF4
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

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x001E9D04 File Offset: 0x001E7F04
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

		// Token: 0x06003D55 RID: 15701 RVA: 0x001E9D14 File Offset: 0x001E7F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardRequest()
		{
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x001E9D24 File Offset: 0x001E7F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardRequest(GuildCardRequest other)
		{
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x001E9D34 File Offset: 0x001E7F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCardRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x001E9D44 File Offset: 0x001E7F44
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x001E9D54 File Offset: 0x001E7F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GuildId
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

		// Token: 0x06003D5A RID: 15706 RVA: 0x001E9D64 File Offset: 0x001E7F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x001E9D74 File Offset: 0x001E7F74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCardRequest other)
		{
			return true;
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x001E9D84 File Offset: 0x001E7F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x001E9D94 File Offset: 0x001E7F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x001E9DA4 File Offset: 0x001E7FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x001E9DB4 File Offset: 0x001E7FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x001E9DC4 File Offset: 0x001E7FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x001E9DD4 File Offset: 0x001E7FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCardRequest other)
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x001E9DE4 File Offset: 0x001E7FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x001E9DF4 File Offset: 0x001E7FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x001E9E04 File Offset: 0x001E8004
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCardRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					GuildCardRequest._parser = new MessageParser<GuildCardRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x001E9ED0 File Offset: 0x001E80D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HSSXcCOT3c7NG9oBjyws()
		{
			return true;
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x001E9ED8 File Offset: 0x001E80D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCardRequest eZm6wLOTRpjaA6ZnWJ3h()
		{
			return null;
		}

		// Token: 0x04001545 RID: 5445
		private static readonly MessageParser<GuildCardRequest> _parser;

		// Token: 0x04001546 RID: 5446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001547 RID: 5447
		public const int GuildIdFieldNumber = 1;

		// Token: 0x04001548 RID: 5448
		private int guildId_;

		// Token: 0x04001549 RID: 5449
		private static GuildCardRequest aPXowHOTebyQh6R5YPHN;
	}
}
