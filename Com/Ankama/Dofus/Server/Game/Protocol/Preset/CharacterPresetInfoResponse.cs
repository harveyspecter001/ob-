using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000269 RID: 617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetInfoResponse : IMessage<CharacterPresetInfoResponse>, IMessage, IEquatable<CharacterPresetInfoResponse>, IDeepCloneable<CharacterPresetInfoResponse>, IBufferMessage
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x001B2634 File Offset: 0x001B0834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterPresetInfoResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x001B2644 File Offset: 0x001B0844
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x001B2654 File Offset: 0x001B0854
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

		// Token: 0x06001CBE RID: 7358 RVA: 0x001B2664 File Offset: 0x001B0864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoResponse()
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x001B2674 File Offset: 0x001B0874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoResponse(CharacterPresetInfoResponse other)
		{
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x001B2684 File Offset: 0x001B0884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoResponse Clone()
		{
			return null;
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x001B2694 File Offset: 0x001B0894
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x001B26A4 File Offset: 0x001B08A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x001B26B4 File Offset: 0x001B08B4
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x001B26C4 File Offset: 0x001B08C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterPresetInfo Info
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

		// Token: 0x06001CC5 RID: 7365 RVA: 0x001B26D4 File Offset: 0x001B08D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x001B26E4 File Offset: 0x001B08E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetInfoResponse other)
		{
			return true;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x001B26F4 File Offset: 0x001B08F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x001B2704 File Offset: 0x001B0904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x001B2714 File Offset: 0x001B0914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x001B2724 File Offset: 0x001B0924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x001B2734 File Offset: 0x001B0934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x001B2744 File Offset: 0x001B0944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetInfoResponse other)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x001B2754 File Offset: 0x001B0954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x001B2764 File Offset: 0x001B0964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x001B2774 File Offset: 0x001B0974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetInfoResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					CharacterPresetInfoResponse._parser = new MessageParser<CharacterPresetInfoResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x001B286C File Offset: 0x001B0A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zklfgZO5Vp4TTFgsQ2ld()
		{
			return true;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x001B2874 File Offset: 0x001B0A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetInfoResponse kttvahO50tP1XHnPb9nI()
		{
			return null;
		}

		// Token: 0x04000A32 RID: 2610
		private static readonly MessageParser<CharacterPresetInfoResponse> _parser;

		// Token: 0x04000A33 RID: 2611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A34 RID: 2612
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000A35 RID: 2613
		private bool isSuccess_;

		// Token: 0x04000A36 RID: 2614
		public const int InfoFieldNumber = 2;

		// Token: 0x04000A37 RID: 2615
		private CharacterPresetInfo info_;

		// Token: 0x04000A38 RID: 2616
		private static CharacterPresetInfoResponse nrD2Y6O5rPQTGqnGTuiX;
	}
}
