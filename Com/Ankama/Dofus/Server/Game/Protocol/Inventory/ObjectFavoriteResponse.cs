using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000417 RID: 1047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectFavoriteResponse : IMessage<ObjectFavoriteResponse>, IMessage, IEquatable<ObjectFavoriteResponse>, IDeepCloneable<ObjectFavoriteResponse>, IBufferMessage
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x001D5124 File Offset: 0x001D3324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectFavoriteResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x001D5134 File Offset: 0x001D3334
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

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x001D5144 File Offset: 0x001D3344
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

		// Token: 0x06003179 RID: 12665 RVA: 0x001D5154 File Offset: 0x001D3354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteResponse()
		{
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x001D5164 File Offset: 0x001D3364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteResponse(ObjectFavoriteResponse other)
		{
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x001D5174 File Offset: 0x001D3374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFavoriteResponse Clone()
		{
			return null;
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x001D5184 File Offset: 0x001D3384
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x001D5194 File Offset: 0x001D3394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x001D51A4 File Offset: 0x001D33A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x001D51B4 File Offset: 0x001D33B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectFavoriteResponse other)
		{
			return true;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x001D51C4 File Offset: 0x001D33C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x001D51D4 File Offset: 0x001D33D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x001D51E4 File Offset: 0x001D33E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x001D51F4 File Offset: 0x001D33F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x001D5204 File Offset: 0x001D3404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x001D5214 File Offset: 0x001D3414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectFavoriteResponse other)
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x001D5224 File Offset: 0x001D3424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x001D5234 File Offset: 0x001D3434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x001D5244 File Offset: 0x001D3444
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectFavoriteResponse()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ObjectFavoriteResponse._parser = new MessageParser<ObjectFavoriteResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x001D5310 File Offset: 0x001D3510
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rseQx8OCyhrAYhw7NySc()
		{
			return true;
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x001D5318 File Offset: 0x001D3518
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectFavoriteResponse RpffEWOC6cryJIX2KQhw()
		{
			return null;
		}

		// Token: 0x0400114D RID: 4429
		private static readonly MessageParser<ObjectFavoriteResponse> _parser;

		// Token: 0x0400114E RID: 4430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400114F RID: 4431
		public const int ResultFieldNumber = 1;

		// Token: 0x04001150 RID: 4432
		private bool result_;

		// Token: 0x04001151 RID: 4433
		internal static ObjectFavoriteResponse vfxRa0OC5XnduM2Irrve;
	}
}
