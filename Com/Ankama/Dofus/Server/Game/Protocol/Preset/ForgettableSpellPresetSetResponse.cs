using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000220 RID: 544
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetSetResponse : IMessage<ForgettableSpellPresetSetResponse>, IMessage, IEquatable<ForgettableSpellPresetSetResponse>, IDeepCloneable<ForgettableSpellPresetSetResponse>, IBufferMessage
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x001AF128 File Offset: 0x001AD328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForgettableSpellPresetSetResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x001AF138 File Offset: 0x001AD338
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x001AF148 File Offset: 0x001AD348
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

		// Token: 0x0600195C RID: 6492 RVA: 0x001AF158 File Offset: 0x001AD358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetResponse()
		{
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x001AF168 File Offset: 0x001AD368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetResponse(ForgettableSpellPresetSetResponse other)
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x001AF178 File Offset: 0x001AD378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetSetResponse Clone()
		{
			return null;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x001AF188 File Offset: 0x001AD388
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x001AF198 File Offset: 0x001AD398
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x001AF1A8 File Offset: 0x001AD3A8
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x001AF1B8 File Offset: 0x001AD3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellPresetInfo PresetInfo
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

		// Token: 0x06001963 RID: 6499 RVA: 0x001AF1C8 File Offset: 0x001AD3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x001AF1D8 File Offset: 0x001AD3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetSetResponse other)
		{
			return true;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x001AF1E8 File Offset: 0x001AD3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x001AF1F8 File Offset: 0x001AD3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x001AF208 File Offset: 0x001AD408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x001AF218 File Offset: 0x001AD418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x001AF228 File Offset: 0x001AD428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x001AF238 File Offset: 0x001AD438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetSetResponse other)
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x001AF248 File Offset: 0x001AD448
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x001AF258 File Offset: 0x001AD458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x001AF268 File Offset: 0x001AD468
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetSetResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ForgettableSpellPresetSetResponse._parser = new MessageParser<ForgettableSpellPresetSetResponse>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x001AF34C File Offset: 0x001AD54C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YKwxVROaowBu6EfTpvYq()
		{
			return true;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x001AF354 File Offset: 0x001AD554
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetSetResponse Dh1dV4Oa1FujN5tQXKUV()
		{
			return null;
		}

		// Token: 0x0400090B RID: 2315
		private static readonly MessageParser<ForgettableSpellPresetSetResponse> _parser;

		// Token: 0x0400090C RID: 2316
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400090D RID: 2317
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x0400090E RID: 2318
		private bool isSuccess_;

		// Token: 0x0400090F RID: 2319
		public const int PresetInfoFieldNumber = 2;

		// Token: 0x04000910 RID: 2320
		private ForgettableSpellPresetInfo presetInfo_;

		// Token: 0x04000911 RID: 2321
		internal static ForgettableSpellPresetSetResponse kLgDKWOavnxQvPXBxIMW;
	}
}
