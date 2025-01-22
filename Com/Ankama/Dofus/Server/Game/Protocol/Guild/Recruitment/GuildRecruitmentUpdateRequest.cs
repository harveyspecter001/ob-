using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment
{
	// Token: 0x020004B7 RID: 1207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRecruitmentUpdateRequest : IMessage<GuildRecruitmentUpdateRequest>, IMessage, IEquatable<GuildRecruitmentUpdateRequest>, IDeepCloneable<GuildRecruitmentUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x001E25A0 File Offset: 0x001E07A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildRecruitmentUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x001E25B0 File Offset: 0x001E07B0
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x001E25C0 File Offset: 0x001E07C0
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

		// Token: 0x060039AE RID: 14766 RVA: 0x001E25D0 File Offset: 0x001E07D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentUpdateRequest()
		{
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x001E25E0 File Offset: 0x001E07E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentUpdateRequest(GuildRecruitmentUpdateRequest other)
		{
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x001E25F0 File Offset: 0x001E07F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x001E2600 File Offset: 0x001E0800
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x001E2610 File Offset: 0x001E0810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildRecruitmentInformation Recruitment
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

		// Token: 0x060039B3 RID: 14771 RVA: 0x001E2620 File Offset: 0x001E0820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x001E2630 File Offset: 0x001E0830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRecruitmentUpdateRequest other)
		{
			return true;
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x001E2640 File Offset: 0x001E0840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x001E2650 File Offset: 0x001E0850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x001E2660 File Offset: 0x001E0860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x001E2670 File Offset: 0x001E0870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x001E2680 File Offset: 0x001E0880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x001E2690 File Offset: 0x001E0890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRecruitmentUpdateRequest other)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x001E26A0 File Offset: 0x001E08A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x001E26B0 File Offset: 0x001E08B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x001E26C0 File Offset: 0x001E08C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRecruitmentUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildRecruitmentUpdateRequest._parser = new MessageParser<GuildRecruitmentUpdateRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x001E27B8 File Offset: 0x001E09B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MMcXpROQxq4X9Is6NV9B()
		{
			return true;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x001E27C0 File Offset: 0x001E09C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRecruitmentUpdateRequest lqhB7dOQ4MmlFSZ0DJEE()
		{
			return null;
		}

		// Token: 0x04001413 RID: 5139
		private static readonly MessageParser<GuildRecruitmentUpdateRequest> _parser;

		// Token: 0x04001414 RID: 5140
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001415 RID: 5141
		public const int RecruitmentFieldNumber = 1;

		// Token: 0x04001416 RID: 5142
		private GuildRecruitmentInformation recruitment_;

		// Token: 0x04001417 RID: 5143
		private static GuildRecruitmentUpdateRequest BocajrOQNkNIhk2r9ZS7;
	}
}
