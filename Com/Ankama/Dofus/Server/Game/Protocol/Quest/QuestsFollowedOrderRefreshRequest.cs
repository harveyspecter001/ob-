using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001A9 RID: 425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestsFollowedOrderRefreshRequest : IMessage<QuestsFollowedOrderRefreshRequest>, IMessage, IEquatable<QuestsFollowedOrderRefreshRequest>, IDeepCloneable<QuestsFollowedOrderRefreshRequest>, IBufferMessage
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x001A4DE8 File Offset: 0x001A2FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestsFollowedOrderRefreshRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x001A4DF8 File Offset: 0x001A2FF8
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x001A4E08 File Offset: 0x001A3008
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x001A4E18 File Offset: 0x001A3018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedOrderRefreshRequest()
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x001A4E28 File Offset: 0x001A3028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedOrderRefreshRequest(QuestsFollowedOrderRefreshRequest other)
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x001A4E38 File Offset: 0x001A3038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsFollowedOrderRefreshRequest Clone()
		{
			return null;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x001A4E48 File Offset: 0x001A3048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Quests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x001A4E58 File Offset: 0x001A3058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x001A4E68 File Offset: 0x001A3068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestsFollowedOrderRefreshRequest other)
		{
			return true;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x001A4E78 File Offset: 0x001A3078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x001A4E88 File Offset: 0x001A3088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x001A4E98 File Offset: 0x001A3098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x001A4EA8 File Offset: 0x001A30A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x001A4EB8 File Offset: 0x001A30B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x001A4EC8 File Offset: 0x001A30C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestsFollowedOrderRefreshRequest other)
		{
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x001A4ED8 File Offset: 0x001A30D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x001A4EE8 File Offset: 0x001A30E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x001A4EF8 File Offset: 0x001A30F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestsFollowedOrderRefreshRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					QuestsFollowedOrderRefreshRequest._repeated_quests_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				QuestsFollowedOrderRefreshRequest._parser = new MessageParser<QuestsFollowedOrderRefreshRequest>(() => null);
				num2 = 5;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x001A4FF8 File Offset: 0x001A31F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hCTAL9OoW84H307uWU6r()
		{
			return true;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x001A5000 File Offset: 0x001A3200
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestsFollowedOrderRefreshRequest mggSEbOohsX4qtlfuLk9()
		{
			return null;
		}

		// Token: 0x04000712 RID: 1810
		private static readonly MessageParser<QuestsFollowedOrderRefreshRequest> _parser;

		// Token: 0x04000713 RID: 1811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000714 RID: 1812
		public const int QuestsFieldNumber = 1;

		// Token: 0x04000715 RID: 1813
		private static readonly FieldCodec<int> _repeated_quests_codec;

		// Token: 0x04000716 RID: 1814
		private readonly RepeatedField<int> quests_;

		// Token: 0x04000717 RID: 1815
		private static QuestsFollowedOrderRefreshRequest VPkiwTOoLWxS5UPRginO;
	}
}
