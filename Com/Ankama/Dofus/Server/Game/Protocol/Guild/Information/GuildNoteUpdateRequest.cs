using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000504 RID: 1284
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildNoteUpdateRequest : IMessage<GuildNoteUpdateRequest>, IMessage, IEquatable<GuildNoteUpdateRequest>, IDeepCloneable<GuildNoteUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x001E9EE0 File Offset: 0x001E80E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildNoteUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x001E9EF0 File Offset: 0x001E80F0
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

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x001E9F00 File Offset: 0x001E8100
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

		// Token: 0x06003D6F RID: 15727 RVA: 0x001E9F10 File Offset: 0x001E8110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildNoteUpdateRequest()
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x001E9F20 File Offset: 0x001E8120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildNoteUpdateRequest(GuildNoteUpdateRequest other)
		{
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x001E9F30 File Offset: 0x001E8130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildNoteUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x001E9F40 File Offset: 0x001E8140
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x001E9F50 File Offset: 0x001E8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x001E9F60 File Offset: 0x001E8160
		// (set) Token: 0x06003D75 RID: 15733 RVA: 0x001E9F70 File Offset: 0x001E8170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Note
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

		// Token: 0x06003D76 RID: 15734 RVA: 0x001E9F80 File Offset: 0x001E8180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x001E9F90 File Offset: 0x001E8190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildNoteUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x001E9FA0 File Offset: 0x001E81A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x001E9FB0 File Offset: 0x001E81B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001E9FC0 File Offset: 0x001E81C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x001E9FD0 File Offset: 0x001E81D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x001E9FE0 File Offset: 0x001E81E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x001E9FF0 File Offset: 0x001E81F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildNoteUpdateRequest other)
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x001EA000 File Offset: 0x001E8200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x001EA010 File Offset: 0x001E8210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x001EA020 File Offset: 0x001E8220
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildNoteUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5E;
					case 3:
						return;
					case 4:
						goto IL_36;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 2;
					}
				}
				IL_36:
				GuildNoteUpdateRequest._parser = new MessageParser<GuildNoteUpdateRequest>(() => null);
				num = 3;
				continue;
				IL_5E:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x001EA0F4 File Offset: 0x001E82F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ShALgbOTJ9vQJoMrkg4g()
		{
			return true;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x001EA0FC File Offset: 0x001E82FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildNoteUpdateRequest J2H9HaOTGGUFSFoeSZ2T()
		{
			return null;
		}

		// Token: 0x0400154C RID: 5452
		private static readonly MessageParser<GuildNoteUpdateRequest> _parser;

		// Token: 0x0400154D RID: 5453
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400154E RID: 5454
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400154F RID: 5455
		private long playerId_;

		// Token: 0x04001550 RID: 5456
		public const int NoteFieldNumber = 2;

		// Token: 0x04001551 RID: 5457
		private string note_;

		// Token: 0x04001552 RID: 5458
		private static GuildNoteUpdateRequest vqyIg4OTOu2RLIY9dUnL;
	}
}
