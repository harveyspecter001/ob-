using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200021E RID: 542
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetSetRequest : IMessage<ForgettableSpellPresetSetRequest>, IMessage, IEquatable<ForgettableSpellPresetSetRequest>, IDeepCloneable<ForgettableSpellPresetSetRequest>, IBufferMessage
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x001AEEF4 File Offset: 0x001AD0F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForgettableSpellPresetSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x001AEF04 File Offset: 0x001AD104
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

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x001AEF14 File Offset: 0x001AD114
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

		// Token: 0x06001940 RID: 6464 RVA: 0x001AEF24 File Offset: 0x001AD124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetRequest()
		{
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x001AEF34 File Offset: 0x001AD134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetRequest(ForgettableSpellPresetSetRequest other)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x001AEF44 File Offset: 0x001AD144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x001AEF54 File Offset: 0x001AD154
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x001AEF64 File Offset: 0x001AD164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uuid
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x001AEF74 File Offset: 0x001AD174
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x001AEF84 File Offset: 0x001AD184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetOrigin Origin
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

		// Token: 0x06001947 RID: 6471 RVA: 0x001AEF94 File Offset: 0x001AD194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x001AEFA4 File Offset: 0x001AD1A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetSetRequest other)
		{
			return true;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x001AEFB4 File Offset: 0x001AD1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x001AEFC4 File Offset: 0x001AD1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x001AEFD4 File Offset: 0x001AD1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x001AEFE4 File Offset: 0x001AD1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x001AEFF4 File Offset: 0x001AD1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x001AF004 File Offset: 0x001AD204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetSetRequest other)
		{
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x001AF014 File Offset: 0x001AD214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x001AF024 File Offset: 0x001AD224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x001AF034 File Offset: 0x001AD234
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ForgettableSpellPresetSetRequest._parser = new MessageParser<ForgettableSpellPresetSetRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x001AF118 File Offset: 0x001AD318
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TJNIV5OacfGF1NJIl4gX()
		{
			return true;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x001AF120 File Offset: 0x001AD320
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetSetRequest SxIowfOaUUqeOyPF1MuJ()
		{
			return null;
		}

		// Token: 0x04000902 RID: 2306
		private static readonly MessageParser<ForgettableSpellPresetSetRequest> _parser;

		// Token: 0x04000903 RID: 2307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000904 RID: 2308
		public const int UuidFieldNumber = 1;

		// Token: 0x04000905 RID: 2309
		private string uuid_;

		// Token: 0x04000906 RID: 2310
		public const int OriginFieldNumber = 2;

		// Token: 0x04000907 RID: 2311
		private PresetOrigin origin_;

		// Token: 0x04000908 RID: 2312
		internal static ForgettableSpellPresetSetRequest mDnUxaOalncMlRJRBySc;
	}
}
