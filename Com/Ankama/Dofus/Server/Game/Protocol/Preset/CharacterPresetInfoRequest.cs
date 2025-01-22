using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000267 RID: 615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetInfoRequest : IMessage<CharacterPresetInfoRequest>, IMessage, IEquatable<CharacterPresetInfoRequest>, IDeepCloneable<CharacterPresetInfoRequest>, IBufferMessage
	{
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x001B2420 File Offset: 0x001B0620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterPresetInfoRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x001B2430 File Offset: 0x001B0630
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x001B2440 File Offset: 0x001B0640
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

		// Token: 0x06001CA4 RID: 7332 RVA: 0x001B2450 File Offset: 0x001B0650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoRequest()
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x001B2460 File Offset: 0x001B0660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoRequest(CharacterPresetInfoRequest other)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x001B2470 File Offset: 0x001B0670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfoRequest Clone()
		{
			return null;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x001B2480 File Offset: 0x001B0680
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x001B2490 File Offset: 0x001B0690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUuid
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

		// Token: 0x06001CA9 RID: 7337 RVA: 0x001B24A0 File Offset: 0x001B06A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x001B24B0 File Offset: 0x001B06B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetInfoRequest other)
		{
			return true;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x001B24C0 File Offset: 0x001B06C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x001B24D0 File Offset: 0x001B06D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x001B24E0 File Offset: 0x001B06E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x001B24F0 File Offset: 0x001B06F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x001B2500 File Offset: 0x001B0700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x001B2510 File Offset: 0x001B0710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetInfoRequest other)
		{
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x001B2520 File Offset: 0x001B0720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x001B2530 File Offset: 0x001B0730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x001B2540 File Offset: 0x001B0740
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetInfoRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					CharacterPresetInfoRequest._parser = new MessageParser<CharacterPresetInfoRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x001B2624 File Offset: 0x001B0824
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fHYdnyO5WHlZFaVZrnEW()
		{
			return true;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x001B262C File Offset: 0x001B082C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetInfoRequest GTxTLfO5h5dFMipApf9i()
		{
			return null;
		}

		// Token: 0x04000A2B RID: 2603
		private static readonly MessageParser<CharacterPresetInfoRequest> _parser;

		// Token: 0x04000A2C RID: 2604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A2D RID: 2605
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000A2E RID: 2606
		private string presetUuid_;

		// Token: 0x04000A2F RID: 2607
		private static CharacterPresetInfoRequest BV7NSDO5Ly7qfMTMC0Qt;
	}
}
