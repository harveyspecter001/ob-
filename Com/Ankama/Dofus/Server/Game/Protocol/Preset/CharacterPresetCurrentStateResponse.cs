using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000281 RID: 641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetCurrentStateResponse : IMessage<CharacterPresetCurrentStateResponse>, IMessage, IEquatable<CharacterPresetCurrentStateResponse>, IDeepCloneable<CharacterPresetCurrentStateResponse>, IBufferMessage
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x001B3830 File Offset: 0x001B1A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetCurrentStateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x001B3840 File Offset: 0x001B1A40
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x001B3850 File Offset: 0x001B1A50
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

		// Token: 0x06001DEF RID: 7663 RVA: 0x001B3860 File Offset: 0x001B1A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateResponse()
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x001B3870 File Offset: 0x001B1A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateResponse(CharacterPresetCurrentStateResponse other)
		{
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x001B3880 File Offset: 0x001B1A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateResponse Clone()
		{
			return null;
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x001B3890 File Offset: 0x001B1A90
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x001B38A0 File Offset: 0x001B1AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterPresetInfo Preset
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

		// Token: 0x06001DF4 RID: 7668 RVA: 0x001B38B0 File Offset: 0x001B1AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x001B38C0 File Offset: 0x001B1AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetCurrentStateResponse other)
		{
			return true;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x001B38D0 File Offset: 0x001B1AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x001B38E0 File Offset: 0x001B1AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x001B38F0 File Offset: 0x001B1AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x001B3900 File Offset: 0x001B1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x001B3910 File Offset: 0x001B1B10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x001B3920 File Offset: 0x001B1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetCurrentStateResponse other)
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x001B3930 File Offset: 0x001B1B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x001B3940 File Offset: 0x001B1B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x001B3950 File Offset: 0x001B1B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetCurrentStateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					CharacterPresetCurrentStateResponse._parser = new MessageParser<CharacterPresetCurrentStateResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x001B3A34 File Offset: 0x001B1C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iel0bYOynOeplUJo32B6()
		{
			return true;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x001B3A3C File Offset: 0x001B1C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetCurrentStateResponse G7mlWLOymAAmCasHZO8N()
		{
			return null;
		}

		// Token: 0x04000A95 RID: 2709
		private static readonly MessageParser<CharacterPresetCurrentStateResponse> _parser;

		// Token: 0x04000A96 RID: 2710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A97 RID: 2711
		public const int PresetFieldNumber = 1;

		// Token: 0x04000A98 RID: 2712
		private CharacterPresetInfo preset_;

		// Token: 0x04000A99 RID: 2713
		private static CharacterPresetCurrentStateResponse cEjwuwOyf9ZQbYDdpvnP;
	}
}
