using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D2D RID: 3373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRankChangeRequest : IMessage<AllianceRankChangeRequest>, IMessage, IEquatable<AllianceRankChangeRequest>, IDeepCloneable<AllianceRankChangeRequest>, IBufferMessage
	{
		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x0028AA68 File Offset: 0x00288C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRankChangeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600A26A RID: 41578 RVA: 0x0028AA78 File Offset: 0x00288C78
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

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x0028AA88 File Offset: 0x00288C88
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

		// Token: 0x0600A26C RID: 41580 RVA: 0x0028AA98 File Offset: 0x00288C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankChangeRequest()
		{
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x0028AAA8 File Offset: 0x00288CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankChangeRequest(AllianceRankChangeRequest other)
		{
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x0028AAB8 File Offset: 0x00288CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankChangeRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x0600A26F RID: 41583 RVA: 0x0028AAC8 File Offset: 0x00288CC8
		// (set) Token: 0x0600A270 RID: 41584 RVA: 0x0028AAD8 File Offset: 0x00288CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MemberId
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

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600A271 RID: 41585 RVA: 0x0028AAE8 File Offset: 0x00288CE8
		// (set) Token: 0x0600A272 RID: 41586 RVA: 0x0028AAF8 File Offset: 0x00288CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RankId
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

		// Token: 0x0600A273 RID: 41587 RVA: 0x0028AB08 File Offset: 0x00288D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x0028AB18 File Offset: 0x00288D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRankChangeRequest other)
		{
			return true;
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x0028AB28 File Offset: 0x00288D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x0028AB38 File Offset: 0x00288D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x0028AB48 File Offset: 0x00288D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x0028AB58 File Offset: 0x00288D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x0028AB68 File Offset: 0x00288D68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x0028AB78 File Offset: 0x00288D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRankChangeRequest other)
		{
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x0028AB88 File Offset: 0x00288D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x0028AB98 File Offset: 0x00288D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x0028ABA8 File Offset: 0x00288DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRankChangeRequest()
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
						goto IL_87;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
					}
				}
				IL_87:
				AllianceRankChangeRequest._parser = new MessageParser<AllianceRankChangeRequest>(() => null);
				num = 2;
			}
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x0028AC90 File Offset: 0x00288E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qTZqs9JKZRy7L98FIAei()
		{
			return true;
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x0028AC98 File Offset: 0x00288E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRankChangeRequest WbKONfJKqfxbEBXPWTp6()
		{
			return null;
		}

		// Token: 0x04003BF5 RID: 15349
		private static readonly MessageParser<AllianceRankChangeRequest> _parser;

		// Token: 0x04003BF6 RID: 15350
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF7 RID: 15351
		public const int MemberIdFieldNumber = 1;

		// Token: 0x04003BF8 RID: 15352
		private long memberId_;

		// Token: 0x04003BF9 RID: 15353
		public const int RankIdFieldNumber = 2;

		// Token: 0x04003BFA RID: 15354
		private int rankId_;

		// Token: 0x04003BFB RID: 15355
		internal static AllianceRankChangeRequest cEe1qSJK8DnJ0HFr1Cs9;
	}
}
