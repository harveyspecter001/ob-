using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000560 RID: 1376
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationPresenceRequest : IMessage<GuildApplicationPresenceRequest>, IMessage, IEquatable<GuildApplicationPresenceRequest>, IDeepCloneable<GuildApplicationPresenceRequest>, IBufferMessage
	{
		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x001F19E4 File Offset: 0x001EFBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationPresenceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x001F19F4 File Offset: 0x001EFBF4
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

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x001F1A04 File Offset: 0x001EFC04
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

		// Token: 0x06004235 RID: 16949 RVA: 0x001F1A14 File Offset: 0x001EFC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceRequest()
		{
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001F1A24 File Offset: 0x001EFC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceRequest(GuildApplicationPresenceRequest other)
		{
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x001F1A34 File Offset: 0x001EFC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceRequest Clone()
		{
			return null;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x001F1A44 File Offset: 0x001EFC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001F1A54 File Offset: 0x001EFC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationPresenceRequest other)
		{
			return true;
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x001F1A64 File Offset: 0x001EFC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x001F1A74 File Offset: 0x001EFC74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x001F1A84 File Offset: 0x001EFC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x001F1A94 File Offset: 0x001EFC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x001F1AA4 File Offset: 0x001EFCA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x001F1AB4 File Offset: 0x001EFCB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationPresenceRequest other)
		{
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x001F1AC4 File Offset: 0x001EFCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x001F1AD4 File Offset: 0x001EFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x001F1AE4 File Offset: 0x001EFCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationPresenceRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_87;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						GuildApplicationPresenceRequest._parser = new MessageParser<GuildApplicationPresenceRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					return;
				}
				IL_87:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x001F1BCC File Offset: 0x001EFDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kWl8syOHIEwkuvwMwj6w()
		{
			return true;
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x001F1BD4 File Offset: 0x001EFDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationPresenceRequest EAiUsCOHkjJORduTSf9m()
		{
			return null;
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly MessageParser<GuildApplicationPresenceRequest> _parser;

		// Token: 0x040016DA RID: 5850
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016DB RID: 5851
		private static GuildApplicationPresenceRequest mEtSGiOHKXVNesorHMNk;
	}
}
