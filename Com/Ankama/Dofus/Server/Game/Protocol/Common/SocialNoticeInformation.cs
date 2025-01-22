using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B84 RID: 2948
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialNoticeInformation : IMessage<SocialNoticeInformation>, IMessage, IEquatable<SocialNoticeInformation>, IDeepCloneable<SocialNoticeInformation>, IBufferMessage
	{
		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x0026AAD8 File Offset: 0x00268CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialNoticeInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06008D6A RID: 36202 RVA: 0x0026AAE8 File Offset: 0x00268CE8
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

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06008D6B RID: 36203 RVA: 0x0026AAF8 File Offset: 0x00268CF8
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

		// Token: 0x06008D6C RID: 36204 RVA: 0x0026AB08 File Offset: 0x00268D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialNoticeInformation()
		{
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x0026AB18 File Offset: 0x00268D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialNoticeInformation(SocialNoticeInformation other)
		{
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x0026AB28 File Offset: 0x00268D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialNoticeInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06008D6F RID: 36207 RVA: 0x0026AB38 File Offset: 0x00268D38
		// (set) Token: 0x06008D70 RID: 36208 RVA: 0x0026AB48 File Offset: 0x00268D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
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

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06008D71 RID: 36209 RVA: 0x0026AB58 File Offset: 0x00268D58
		// (set) Token: 0x06008D72 RID: 36210 RVA: 0x0026AB68 File Offset: 0x00268D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timestamp
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

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06008D73 RID: 36211 RVA: 0x0026AB78 File Offset: 0x00268D78
		// (set) Token: 0x06008D74 RID: 36212 RVA: 0x0026AB88 File Offset: 0x00268D88
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

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06008D75 RID: 36213 RVA: 0x0026AB98 File Offset: 0x00268D98
		// (set) Token: 0x06008D76 RID: 36214 RVA: 0x0026ABA8 File Offset: 0x00268DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MemberName
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

		// Token: 0x06008D77 RID: 36215 RVA: 0x0026ABB8 File Offset: 0x00268DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0026ABC8 File Offset: 0x00268DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SocialNoticeInformation other)
		{
			return true;
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0026ABD8 File Offset: 0x00268DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0026ABE8 File Offset: 0x00268DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x0026ABF8 File Offset: 0x00268DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0026AC08 File Offset: 0x00268E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0026AC18 File Offset: 0x00268E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x0026AC28 File Offset: 0x00268E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SocialNoticeInformation other)
		{
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x0026AC38 File Offset: 0x00268E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0026AC48 File Offset: 0x00268E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x0026AC58 File Offset: 0x00268E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SocialNoticeInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					SocialNoticeInformation._parser = new MessageParser<SocialNoticeInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0026AD3C File Offset: 0x00268F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UOLA4MJ95JLHn4iY8t9v()
		{
			return true;
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x0026AD44 File Offset: 0x00268F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SocialNoticeInformation AuIn8MJ9yKA7JVaN0JRs()
		{
			return null;
		}

		// Token: 0x04003465 RID: 13413
		private static readonly MessageParser<SocialNoticeInformation> _parser;

		// Token: 0x04003466 RID: 13414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003467 RID: 13415
		public const int ContentFieldNumber = 1;

		// Token: 0x04003468 RID: 13416
		private string content_;

		// Token: 0x04003469 RID: 13417
		public const int TimestampFieldNumber = 2;

		// Token: 0x0400346A RID: 13418
		private long timestamp_;

		// Token: 0x0400346B RID: 13419
		public const int MemberIdFieldNumber = 3;

		// Token: 0x0400346C RID: 13420
		private long memberId_;

		// Token: 0x0400346D RID: 13421
		public const int MemberNameFieldNumber = 4;

		// Token: 0x0400346E RID: 13422
		private string memberName_;

		// Token: 0x0400346F RID: 13423
		private static SocialNoticeInformation tUDgWdJ9a8ME6CFq6yPi;
	}
}
