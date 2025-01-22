using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200021C RID: 540
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetSetResponse : IMessage<CharacterPresetSetResponse>, IMessage, IEquatable<CharacterPresetSetResponse>, IDeepCloneable<CharacterPresetSetResponse>, IBufferMessage
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x001AECC0 File Offset: 0x001ACEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetSetResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x001AECD0 File Offset: 0x001ACED0
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x001AECE0 File Offset: 0x001ACEE0
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

		// Token: 0x06001924 RID: 6436 RVA: 0x001AECF0 File Offset: 0x001ACEF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetResponse()
		{
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x001AED00 File Offset: 0x001ACF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetResponse(CharacterPresetSetResponse other)
		{
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x001AED10 File Offset: 0x001ACF10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetSetResponse Clone()
		{
			return null;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x001AED20 File Offset: 0x001ACF20
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x001AED30 File Offset: 0x001ACF30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x001AED40 File Offset: 0x001ACF40
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x001AED50 File Offset: 0x001ACF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterPresetInfo PresetInfo
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

		// Token: 0x0600192B RID: 6443 RVA: 0x001AED60 File Offset: 0x001ACF60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x001AED70 File Offset: 0x001ACF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetSetResponse other)
		{
			return true;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x001AED80 File Offset: 0x001ACF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x001AED90 File Offset: 0x001ACF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x001AEDA0 File Offset: 0x001ACFA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x001AEDB0 File Offset: 0x001ACFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x001AEDC0 File Offset: 0x001ACFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x001AEDD0 File Offset: 0x001ACFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetSetResponse other)
		{
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x001AEDE0 File Offset: 0x001ACFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x001AEDF0 File Offset: 0x001ACFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x001AEE00 File Offset: 0x001AD000
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetSetResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
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
				CharacterPresetSetResponse._parser = new MessageParser<CharacterPresetSetResponse>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x001AEEE4 File Offset: 0x001AD0E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yIqi52OaI3cbdRc4gpL1()
		{
			return true;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x001AEEEC File Offset: 0x001AD0EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetSetResponse TMWWcwOakX4q6rNF0IiL()
		{
			return null;
		}

		// Token: 0x040008F9 RID: 2297
		private static readonly MessageParser<CharacterPresetSetResponse> _parser;

		// Token: 0x040008FA RID: 2298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008FB RID: 2299
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x040008FC RID: 2300
		private bool isSuccess_;

		// Token: 0x040008FD RID: 2301
		public const int PresetInfoFieldNumber = 2;

		// Token: 0x040008FE RID: 2302
		private CharacterPresetInfo presetInfo_;

		// Token: 0x040008FF RID: 2303
		private static CharacterPresetSetResponse an9bjSOaKZLPO7p3aAVK;
	}
}
