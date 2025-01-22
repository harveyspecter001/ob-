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
	// Token: 0x02000524 RID: 1316
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildBulletinEvent : IMessage<GuildBulletinEvent>, IMessage, IEquatable<GuildBulletinEvent>, IDeepCloneable<GuildBulletinEvent>, IBufferMessage
	{
		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x001EC254 File Offset: 0x001EA454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildBulletinEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x001EC264 File Offset: 0x001EA464
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x001EC274 File Offset: 0x001EA474
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

		// Token: 0x06003F2B RID: 16171 RVA: 0x001EC284 File Offset: 0x001EA484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinEvent()
		{
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x001EC294 File Offset: 0x001EA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinEvent(GuildBulletinEvent other)
		{
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x001EC2A4 File Offset: 0x001EA4A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x001EC2B4 File Offset: 0x001EA4B4
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x001EC2C4 File Offset: 0x001EA4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialNoticeInformation Bulletin
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

		// Token: 0x06003F30 RID: 16176 RVA: 0x001EC2D4 File Offset: 0x001EA4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x001EC2E4 File Offset: 0x001EA4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildBulletinEvent other)
		{
			return true;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x001EC2F4 File Offset: 0x001EA4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x001EC304 File Offset: 0x001EA504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x001EC314 File Offset: 0x001EA514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001EC324 File Offset: 0x001EA524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001EC334 File Offset: 0x001EA534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x001EC344 File Offset: 0x001EA544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildBulletinEvent other)
		{
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x001EC354 File Offset: 0x001EA554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x001EC364 File Offset: 0x001EA564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x001EC374 File Offset: 0x001EA574
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildBulletinEvent()
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
						GuildBulletinEvent._parser = new MessageParser<GuildBulletinEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x001EC444 File Offset: 0x001EA644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uUwV6UOT8gjOXQVaqVKR()
		{
			return true;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x001EC44C File Offset: 0x001EA64C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildBulletinEvent yf9VdhOTZ7BDQ9CVHfdd()
		{
			return null;
		}

		// Token: 0x040015E0 RID: 5600
		private static readonly MessageParser<GuildBulletinEvent> _parser;

		// Token: 0x040015E1 RID: 5601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015E2 RID: 5602
		public const int BulletinFieldNumber = 1;

		// Token: 0x040015E3 RID: 5603
		private SocialNoticeInformation bulletin_;

		// Token: 0x040015E4 RID: 5604
		private static GuildBulletinEvent qblPkbOTuwF8P8i5RflD;
	}
}
