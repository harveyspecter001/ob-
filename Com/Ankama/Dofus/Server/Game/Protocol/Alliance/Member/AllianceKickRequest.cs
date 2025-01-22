using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D38 RID: 3384
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceKickRequest : IMessage<AllianceKickRequest>, IMessage, IEquatable<AllianceKickRequest>, IDeepCloneable<AllianceKickRequest>, IBufferMessage
	{
		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x0028BE5C File Offset: 0x0028A05C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x0028BE6C File Offset: 0x0028A06C
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

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x0028BE7C File Offset: 0x0028A07C
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

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x0028BE8C File Offset: 0x0028A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceKickRequest()
		{
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x0028BE9C File Offset: 0x0028A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceKickRequest(AllianceKickRequest other)
		{
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x0028BEAC File Offset: 0x0028A0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceKickRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x0028BEBC File Offset: 0x0028A0BC
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x0028BECC File Offset: 0x0028A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KickedId
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

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x0028BEDC File Offset: 0x0028A0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x0028BEEC File Offset: 0x0028A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceKickRequest other)
		{
			return true;
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x0028BEFC File Offset: 0x0028A0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0028BF0C File Offset: 0x0028A10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x0028BF1C File Offset: 0x0028A11C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x0028BF2C File Offset: 0x0028A12C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x0028BF3C File Offset: 0x0028A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x0028BF4C File Offset: 0x0028A14C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceKickRequest other)
		{
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x0028BF5C File Offset: 0x0028A15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x0028BF6C File Offset: 0x0028A16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x0028BF7C File Offset: 0x0028A17C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceKickRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AllianceKickRequest._parser = new MessageParser<AllianceKickRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0028C048 File Offset: 0x0028A248
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vZIwfpJI9DIT0NdJJbfQ()
		{
			return true;
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0028C050 File Offset: 0x0028A250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceKickRequest yVt8NwJI29ohdiNJlb4F()
		{
			return null;
		}

		// Token: 0x04003C20 RID: 15392
		private static readonly MessageParser<AllianceKickRequest> _parser;

		// Token: 0x04003C21 RID: 15393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C22 RID: 15394
		public const int KickedIdFieldNumber = 1;

		// Token: 0x04003C23 RID: 15395
		private long kickedId_;

		// Token: 0x04003C24 RID: 15396
		private static AllianceKickRequest QuYuaMJIdZTXUVgM8QD2;
	}
}
