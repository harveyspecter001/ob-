using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D48 RID: 3400
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMemberUpdateEvent : IMessage<AllianceMemberUpdateEvent>, IMessage, IEquatable<AllianceMemberUpdateEvent>, IDeepCloneable<AllianceMemberUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x0028CF40 File Offset: 0x0028B140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceMemberUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x0028CF50 File Offset: 0x0028B150
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

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x0028CF60 File Offset: 0x0028B160
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

		// Token: 0x0600A3CC RID: 41932 RVA: 0x0028CF70 File Offset: 0x0028B170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberUpdateEvent()
		{
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x0028CF80 File Offset: 0x0028B180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberUpdateEvent(AllianceMemberUpdateEvent other)
		{
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x0028CF90 File Offset: 0x0028B190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMemberUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x0028CFA0 File Offset: 0x0028B1A0
		// (set) Token: 0x0600A3D0 RID: 41936 RVA: 0x0028CFB0 File Offset: 0x0028B1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceMemberInformation Member
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

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x0028CFC0 File Offset: 0x0028B1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x0028CFD0 File Offset: 0x0028B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMemberUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x0028CFE0 File Offset: 0x0028B1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x0028CFF0 File Offset: 0x0028B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x0028D000 File Offset: 0x0028B200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x0028D010 File Offset: 0x0028B210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x0028D020 File Offset: 0x0028B220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x0028D030 File Offset: 0x0028B230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMemberUpdateEvent other)
		{
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x0028D040 File Offset: 0x0028B240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x0028D050 File Offset: 0x0028B250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x0028D060 File Offset: 0x0028B260
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMemberUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				AllianceMemberUpdateEvent._parser = new MessageParser<AllianceMemberUpdateEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x0028D12C File Offset: 0x0028B32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eC87x3JIrgMHXDWye51S()
		{
			return true;
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x0028D134 File Offset: 0x0028B334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMemberUpdateEvent u0GnXQJIVQcp2o8CAkOw()
		{
			return null;
		}

		// Token: 0x04003C60 RID: 15456
		private static readonly MessageParser<AllianceMemberUpdateEvent> _parser;

		// Token: 0x04003C61 RID: 15457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C62 RID: 15458
		public const int MemberFieldNumber = 1;

		// Token: 0x04003C63 RID: 15459
		private AllianceMemberInformation member_;

		// Token: 0x04003C64 RID: 15460
		internal static AllianceMemberUpdateEvent zIG0EwJIhJHVAsKlOo9N;
	}
}
