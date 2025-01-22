using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200026D RID: 621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetInfoResponse : IMessage<ForgettableSpellPresetInfoResponse>, IMessage, IEquatable<ForgettableSpellPresetInfoResponse>, IDeepCloneable<ForgettableSpellPresetInfoResponse>, IBufferMessage
	{
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x001B2A90 File Offset: 0x001B0C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellPresetInfoResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x001B2AA0 File Offset: 0x001B0CA0
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x001B2AB0 File Offset: 0x001B0CB0
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

		// Token: 0x06001CF4 RID: 7412 RVA: 0x001B2AC0 File Offset: 0x001B0CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoResponse()
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x001B2AD0 File Offset: 0x001B0CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoResponse(ForgettableSpellPresetInfoResponse other)
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x001B2AE0 File Offset: 0x001B0CE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfoResponse Clone()
		{
			return null;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x001B2AF0 File Offset: 0x001B0CF0
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x001B2B00 File Offset: 0x001B0D00
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x001B2B10 File Offset: 0x001B0D10
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x001B2B20 File Offset: 0x001B0D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellPresetInfo Info
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

		// Token: 0x06001CFB RID: 7419 RVA: 0x001B2B30 File Offset: 0x001B0D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x001B2B40 File Offset: 0x001B0D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetInfoResponse other)
		{
			return true;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x001B2B50 File Offset: 0x001B0D50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x001B2B60 File Offset: 0x001B0D60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x001B2B70 File Offset: 0x001B0D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x001B2B80 File Offset: 0x001B0D80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x001B2B90 File Offset: 0x001B0D90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x001B2BA0 File Offset: 0x001B0DA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetInfoResponse other)
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x001B2BB0 File Offset: 0x001B0DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x001B2BC0 File Offset: 0x001B0DC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x001B2BD0 File Offset: 0x001B0DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetInfoResponse()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				ForgettableSpellPresetInfoResponse._parser = new MessageParser<ForgettableSpellPresetInfoResponse>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x001B2C9C File Offset: 0x001B0E9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QvybFpO5Qr3CpXbLkgnT()
		{
			return true;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x001B2CA4 File Offset: 0x001B0EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetInfoResponse xTtT7EO57ZGDxDtWbdI2()
		{
			return null;
		}

		// Token: 0x04000A42 RID: 2626
		private static readonly MessageParser<ForgettableSpellPresetInfoResponse> _parser;

		// Token: 0x04000A43 RID: 2627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A44 RID: 2628
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000A45 RID: 2629
		private bool isSuccess_;

		// Token: 0x04000A46 RID: 2630
		public const int InfoFieldNumber = 2;

		// Token: 0x04000A47 RID: 2631
		private ForgettableSpellPresetInfo info_;

		// Token: 0x04000A48 RID: 2632
		internal static ForgettableSpellPresetInfoResponse A7lnAmO5wPUwYQi3H27D;
	}
}
