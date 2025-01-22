using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000558 RID: 1368
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationListenRequest : IMessage<GuildApplicationListenRequest>, IMessage, IEquatable<GuildApplicationListenRequest>, IDeepCloneable<GuildApplicationListenRequest>, IBufferMessage
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x001F11B8 File Offset: 0x001EF3B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationListenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x001F11C8 File Offset: 0x001EF3C8
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

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x001F11D8 File Offset: 0x001EF3D8
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

		// Token: 0x060041CB RID: 16843 RVA: 0x001F11E8 File Offset: 0x001EF3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationListenRequest()
		{
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x001F11F8 File Offset: 0x001EF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationListenRequest(GuildApplicationListenRequest other)
		{
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x001F1208 File Offset: 0x001EF408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationListenRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x001F1218 File Offset: 0x001EF418
		// (set) Token: 0x060041CF RID: 16847 RVA: 0x001F1228 File Offset: 0x001EF428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Listen
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

		// Token: 0x060041D0 RID: 16848 RVA: 0x001F1238 File Offset: 0x001EF438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x001F1248 File Offset: 0x001EF448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationListenRequest other)
		{
			return true;
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x001F1258 File Offset: 0x001EF458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x001F1268 File Offset: 0x001EF468
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x001F1278 File Offset: 0x001EF478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x001F1288 File Offset: 0x001EF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x001F1298 File Offset: 0x001EF498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x001F12A8 File Offset: 0x001EF4A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationListenRequest other)
		{
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x001F12B8 File Offset: 0x001EF4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x001F12C8 File Offset: 0x001EF4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x001F12D8 File Offset: 0x001EF4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationListenRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						GuildApplicationListenRequest._parser = new MessageParser<GuildApplicationListenRequest>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_AC;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x001F13A8 File Offset: 0x001EF5A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GhsRb6OHgODMRAyAbUVb()
		{
			return true;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x001F13B0 File Offset: 0x001EF5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationListenRequest cnh3VrOHscvTE9nTbXOr()
		{
			return null;
		}

		// Token: 0x040016BB RID: 5819
		private static readonly MessageParser<GuildApplicationListenRequest> _parser;

		// Token: 0x040016BC RID: 5820
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016BD RID: 5821
		public const int ListenFieldNumber = 1;

		// Token: 0x040016BE RID: 5822
		private bool listen_;

		// Token: 0x040016BF RID: 5823
		private static GuildApplicationListenRequest l9FtR7OHGFRBnbZhX11Z;
	}
}
