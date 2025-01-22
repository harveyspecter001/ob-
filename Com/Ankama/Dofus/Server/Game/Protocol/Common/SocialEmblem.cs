using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B82 RID: 2946
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialEmblem : IMessage<SocialEmblem>, IMessage, IEquatable<SocialEmblem>, IDeepCloneable<SocialEmblem>, IBufferMessage
	{
		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x0026A850 File Offset: 0x00268A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialEmblem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06008D4A RID: 36170 RVA: 0x0026A860 File Offset: 0x00268A60
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x0026A870 File Offset: 0x00268A70
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

		// Token: 0x06008D4C RID: 36172 RVA: 0x0026A880 File Offset: 0x00268A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialEmblem()
		{
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x0026A890 File Offset: 0x00268A90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialEmblem(SocialEmblem other)
		{
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x0026A8A0 File Offset: 0x00268AA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialEmblem Clone()
		{
			return null;
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06008D4F RID: 36175 RVA: 0x0026A8B0 File Offset: 0x00268AB0
		// (set) Token: 0x06008D50 RID: 36176 RVA: 0x0026A8C0 File Offset: 0x00268AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SymbolShapeId
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

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06008D51 RID: 36177 RVA: 0x0026A8D0 File Offset: 0x00268AD0
		// (set) Token: 0x06008D52 RID: 36178 RVA: 0x0026A8E0 File Offset: 0x00268AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SymbolColor
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

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x0026A8F0 File Offset: 0x00268AF0
		// (set) Token: 0x06008D54 RID: 36180 RVA: 0x0026A900 File Offset: 0x00268B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackgroundShapeId
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x0026A910 File Offset: 0x00268B10
		// (set) Token: 0x06008D56 RID: 36182 RVA: 0x0026A920 File Offset: 0x00268B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackgroundColor
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

		// Token: 0x06008D57 RID: 36183 RVA: 0x0026A930 File Offset: 0x00268B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x0026A940 File Offset: 0x00268B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SocialEmblem other)
		{
			return true;
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x0026A950 File Offset: 0x00268B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008D5A RID: 36186 RVA: 0x0026A960 File Offset: 0x00268B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x0026A970 File Offset: 0x00268B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x0026A980 File Offset: 0x00268B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008D5D RID: 36189 RVA: 0x0026A990 File Offset: 0x00268B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x0026A9A0 File Offset: 0x00268BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SocialEmblem other)
		{
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0026A9B0 File Offset: 0x00268BB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x0026A9C0 File Offset: 0x00268BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x0026A9D0 File Offset: 0x00268BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SocialEmblem()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					SocialEmblem._parser = new MessageParser<SocialEmblem>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x0026AAC8 File Offset: 0x00268CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Re5aKKJ9o3DorWcClLA4()
		{
			return true;
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0026AAD0 File Offset: 0x00268CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SocialEmblem nUpT1tJ91x22FuH1maXB()
		{
			return null;
		}

		// Token: 0x04003458 RID: 13400
		private static readonly MessageParser<SocialEmblem> _parser;

		// Token: 0x04003459 RID: 13401
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400345A RID: 13402
		public const int SymbolShapeIdFieldNumber = 1;

		// Token: 0x0400345B RID: 13403
		private int symbolShapeId_;

		// Token: 0x0400345C RID: 13404
		public const int SymbolColorFieldNumber = 2;

		// Token: 0x0400345D RID: 13405
		private int symbolColor_;

		// Token: 0x0400345E RID: 13406
		public const int BackgroundShapeIdFieldNumber = 3;

		// Token: 0x0400345F RID: 13407
		private int backgroundShapeId_;

		// Token: 0x04003460 RID: 13408
		public const int BackgroundColorFieldNumber = 4;

		// Token: 0x04003461 RID: 13409
		private int backgroundColor_;

		// Token: 0x04003462 RID: 13410
		internal static SocialEmblem LXLTobJ9v9p4ijkErQm9;
	}
}
