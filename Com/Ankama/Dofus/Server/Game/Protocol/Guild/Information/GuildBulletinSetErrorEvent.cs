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
	// Token: 0x02000526 RID: 1318
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildBulletinSetErrorEvent : IMessage<GuildBulletinSetErrorEvent>, IMessage, IEquatable<GuildBulletinSetErrorEvent>, IDeepCloneable<GuildBulletinSetErrorEvent>, IBufferMessage
	{
		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x001EC454 File Offset: 0x001EA654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildBulletinSetErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x001EC464 File Offset: 0x001EA664
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x001EC474 File Offset: 0x001EA674
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

		// Token: 0x06003F45 RID: 16197 RVA: 0x001EC484 File Offset: 0x001EA684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetErrorEvent()
		{
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x001EC494 File Offset: 0x001EA694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetErrorEvent(GuildBulletinSetErrorEvent other)
		{
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x001EC4A4 File Offset: 0x001EA6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x001EC4B4 File Offset: 0x001EA6B4
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x001EC4C8 File Offset: 0x001EA6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialNoticeError Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialNoticeError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x001EC4D8 File Offset: 0x001EA6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x001EC4E8 File Offset: 0x001EA6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildBulletinSetErrorEvent other)
		{
			return true;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x001EC4F8 File Offset: 0x001EA6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x001EC508 File Offset: 0x001EA708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x001EC518 File Offset: 0x001EA718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x001EC528 File Offset: 0x001EA728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x001EC538 File Offset: 0x001EA738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001EC548 File Offset: 0x001EA748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildBulletinSetErrorEvent other)
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x001EC558 File Offset: 0x001EA758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x001EC568 File Offset: 0x001EA768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x001EC578 File Offset: 0x001EA778
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildBulletinSetErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				GuildBulletinSetErrorEvent._parser = new MessageParser<GuildBulletinSetErrorEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x001EC644 File Offset: 0x001EA844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xn7xLjOTFEtb19yp2CvE()
		{
			return true;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x001EC64C File Offset: 0x001EA84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildBulletinSetErrorEvent nkbQ96OTzwCKMWy1MOy2()
		{
			return null;
		}

		// Token: 0x040015E7 RID: 5607
		private static readonly MessageParser<GuildBulletinSetErrorEvent> _parser;

		// Token: 0x040015E8 RID: 5608
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015E9 RID: 5609
		public const int ErrorFieldNumber = 1;

		// Token: 0x040015EA RID: 5610
		private SocialNoticeError error_;

		// Token: 0x040015EB RID: 5611
		private static GuildBulletinSetErrorEvent h5k6KoOTqKeGAKdOAwDx;
	}
}
