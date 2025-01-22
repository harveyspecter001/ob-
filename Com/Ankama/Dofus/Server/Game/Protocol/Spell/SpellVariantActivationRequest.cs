using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x02000114 RID: 276
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellVariantActivationRequest : IMessage<SpellVariantActivationRequest>, IMessage, IEquatable<SpellVariantActivationRequest>, IDeepCloneable<SpellVariantActivationRequest>, IBufferMessage
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00198438 File Offset: 0x00196638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellVariantActivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00198448 File Offset: 0x00196648
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00198458 File Offset: 0x00196658
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

		// Token: 0x06000C99 RID: 3225 RVA: 0x00198468 File Offset: 0x00196668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationRequest()
		{
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00198478 File Offset: 0x00196678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationRequest(SpellVariantActivationRequest other)
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00198488 File Offset: 0x00196688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellVariantActivationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00198498 File Offset: 0x00196698
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x001984A8 File Offset: 0x001966A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
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

		// Token: 0x06000C9E RID: 3230 RVA: 0x001984B8 File Offset: 0x001966B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x001984C8 File Offset: 0x001966C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellVariantActivationRequest other)
		{
			return true;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x001984D8 File Offset: 0x001966D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x001984E8 File Offset: 0x001966E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x001984F8 File Offset: 0x001966F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00198508 File Offset: 0x00196708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00198518 File Offset: 0x00196718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00198528 File Offset: 0x00196728
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellVariantActivationRequest other)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00198538 File Offset: 0x00196738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00198548 File Offset: 0x00196748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00198558 File Offset: 0x00196758
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellVariantActivationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					SpellVariantActivationRequest._parser = new MessageParser<SpellVariantActivationRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00198650 File Offset: 0x00196850
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DijZcTOc2D7t3vAvkkDc()
		{
			return true;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00198658 File Offset: 0x00196858
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellVariantActivationRequest kFwto7OcETZoL7vyD272()
		{
			return null;
		}

		// Token: 0x04000491 RID: 1169
		private static readonly MessageParser<SpellVariantActivationRequest> _parser;

		// Token: 0x04000492 RID: 1170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000493 RID: 1171
		public const int SpellIdFieldNumber = 1;

		// Token: 0x04000494 RID: 1172
		private int spellId_;

		// Token: 0x04000495 RID: 1173
		private static SpellVariantActivationRequest M0HfKhOc94ap6ZjlT2lS;
	}
}
