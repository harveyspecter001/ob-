using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000556 RID: 1366
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationDeleteRequest : IMessage<GuildApplicationDeleteRequest>, IMessage, IEquatable<GuildApplicationDeleteRequest>, IDeepCloneable<GuildApplicationDeleteRequest>, IBufferMessage
	{
		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x001F0FD8 File Offset: 0x001EF1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationDeleteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x001F0FE8 File Offset: 0x001EF1E8
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x001F0FF8 File Offset: 0x001EF1F8
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

		// Token: 0x060041B3 RID: 16819 RVA: 0x001F1008 File Offset: 0x001EF208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeleteRequest()
		{
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x001F1018 File Offset: 0x001EF218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeleteRequest(GuildApplicationDeleteRequest other)
		{
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x001F1028 File Offset: 0x001EF228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationDeleteRequest Clone()
		{
			return null;
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x001F1038 File Offset: 0x001EF238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x001F1048 File Offset: 0x001EF248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationDeleteRequest other)
		{
			return true;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x001F1058 File Offset: 0x001EF258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x001F1068 File Offset: 0x001EF268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x001F1078 File Offset: 0x001EF278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x001F1088 File Offset: 0x001EF288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x001F1098 File Offset: 0x001EF298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x001F10A8 File Offset: 0x001EF2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationDeleteRequest other)
		{
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x001F10B8 File Offset: 0x001EF2B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x001F10C8 File Offset: 0x001EF2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x001F10D8 File Offset: 0x001EF2D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationDeleteRequest()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						goto IL_5E;
					case 4:
						GuildApplicationDeleteRequest._parser = new MessageParser<GuildApplicationDeleteRequest>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
				}
				IL_5E:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x001F11A8 File Offset: 0x001EF3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mCZA0SOHOMopY3H5kq3M()
		{
			return true;
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x001F11B0 File Offset: 0x001EF3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationDeleteRequest MM6OgWOHJeA4De9sXbcK()
		{
			return null;
		}

		// Token: 0x040016B6 RID: 5814
		private static readonly MessageParser<GuildApplicationDeleteRequest> _parser;

		// Token: 0x040016B7 RID: 5815
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016B8 RID: 5816
		internal static GuildApplicationDeleteRequest s21V7MOHREcSeIM5OdjD;
	}
}
