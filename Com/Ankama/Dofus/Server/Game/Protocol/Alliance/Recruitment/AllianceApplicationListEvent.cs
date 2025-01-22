using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D1A RID: 3354
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationListEvent : IMessage<AllianceApplicationListEvent>, IMessage, IEquatable<AllianceApplicationListEvent>, IDeepCloneable<AllianceApplicationListEvent>, IBufferMessage
	{
		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x0600A16D RID: 41325 RVA: 0x00288FBC File Offset: 0x002871BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceApplicationListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x00288FCC File Offset: 0x002871CC
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

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x00288FDC File Offset: 0x002871DC
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

		// Token: 0x0600A170 RID: 41328 RVA: 0x00288FEC File Offset: 0x002871EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListEvent()
		{
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x00288FFC File Offset: 0x002871FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListEvent(AllianceApplicationListEvent other)
		{
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x0028900C File Offset: 0x0028720C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x0028901C File Offset: 0x0028721C
		// (set) Token: 0x0600A174 RID: 41332 RVA: 0x0028902C File Offset: 0x0028722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Offset
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

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0028903C File Offset: 0x0028723C
		// (set) Token: 0x0600A176 RID: 41334 RVA: 0x0028904C File Offset: 0x0028724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Count
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

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600A177 RID: 41335 RVA: 0x0028905C File Offset: 0x0028725C
		// (set) Token: 0x0600A178 RID: 41336 RVA: 0x0028906C File Offset: 0x0028726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Total
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

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x0600A179 RID: 41337 RVA: 0x0028907C File Offset: 0x0028727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialApplicationInformation> Applies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x0028908C File Offset: 0x0028728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x0028909C File Offset: 0x0028729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationListEvent other)
		{
			return true;
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x002890AC File Offset: 0x002872AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x002890BC File Offset: 0x002872BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x002890CC File Offset: 0x002872CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x002890DC File Offset: 0x002872DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x002890EC File Offset: 0x002872EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x002890FC File Offset: 0x002872FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationListEvent other)
		{
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x0028910C File Offset: 0x0028730C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x0028911C File Offset: 0x0028731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x0028912C File Offset: 0x0028732C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AllianceApplicationListEvent._repeated_applies_codec = FieldCodec.ForMessage<SocialApplicationInformation>(34U, OeGwygmLwyeIVI4T1DZs.XVInXhlssT(OeGwygmLwyeIVI4T1DZs.brlmLQUlYs9));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					AllianceApplicationListEvent._parser = new MessageParser<AllianceApplicationListEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x00289248 File Offset: 0x00287448
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z3T2TGJKvpPmQ7qnUNhr()
		{
			return true;
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x00289250 File Offset: 0x00287450
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationListEvent AR8VS6JKovjOj3wAtjoj()
		{
			return null;
		}

		// Token: 0x04003BA2 RID: 15266
		private static readonly MessageParser<AllianceApplicationListEvent> _parser;

		// Token: 0x04003BA3 RID: 15267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA4 RID: 15268
		public const int OffsetFieldNumber = 1;

		// Token: 0x04003BA5 RID: 15269
		private long offset_;

		// Token: 0x04003BA6 RID: 15270
		public const int CountFieldNumber = 2;

		// Token: 0x04003BA7 RID: 15271
		private long count_;

		// Token: 0x04003BA8 RID: 15272
		public const int TotalFieldNumber = 3;

		// Token: 0x04003BA9 RID: 15273
		private long total_;

		// Token: 0x04003BAA RID: 15274
		public const int AppliesFieldNumber = 4;

		// Token: 0x04003BAB RID: 15275
		private static readonly FieldCodec<SocialApplicationInformation> _repeated_applies_codec;

		// Token: 0x04003BAC RID: 15276
		private readonly RepeatedField<SocialApplicationInformation> applies_;

		// Token: 0x04003BAD RID: 15277
		private static AllianceApplicationListEvent LxZRXfJKUCEulm4GHfvS;
	}
}
