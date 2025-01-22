using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200022A RID: 554
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetResetRequest : IMessage<ForgettableSpellPresetResetRequest>, IMessage, IEquatable<ForgettableSpellPresetResetRequest>, IDeepCloneable<ForgettableSpellPresetResetRequest>, IBufferMessage
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x001AFBD4 File Offset: 0x001ADDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellPresetResetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x001AFBE4 File Offset: 0x001ADDE4
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x001AFBF4 File Offset: 0x001ADDF4
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

		// Token: 0x060019E4 RID: 6628 RVA: 0x001AFC04 File Offset: 0x001ADE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetRequest()
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x001AFC14 File Offset: 0x001ADE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetRequest(ForgettableSpellPresetResetRequest other)
		{
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x001AFC24 File Offset: 0x001ADE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetResetRequest Clone()
		{
			return null;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x001AFC34 File Offset: 0x001ADE34
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x001AFC44 File Offset: 0x001ADE44
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

		// Token: 0x060019E9 RID: 6633 RVA: 0x001AFC54 File Offset: 0x001ADE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x001AFC64 File Offset: 0x001ADE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetResetRequest other)
		{
			return true;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x001AFC74 File Offset: 0x001ADE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x001AFC84 File Offset: 0x001ADE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x001AFC94 File Offset: 0x001ADE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x001AFCA4 File Offset: 0x001ADEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x001AFCB4 File Offset: 0x001ADEB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x001AFCC4 File Offset: 0x001ADEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetResetRequest other)
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x001AFCD4 File Offset: 0x001ADED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x001AFCE4 File Offset: 0x001ADEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x001AFCF4 File Offset: 0x001ADEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetResetRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					ForgettableSpellPresetResetRequest._parser = new MessageParser<ForgettableSpellPresetResetRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x001AFDC0 File Offset: 0x001ADFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nMIL0pOaww3W97WdpSm2()
		{
			return true;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x001AFDC8 File Offset: 0x001ADFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetResetRequest YyiGZUOaQ0nfYFksh62g()
		{
			return null;
		}

		// Token: 0x04000934 RID: 2356
		private static readonly MessageParser<ForgettableSpellPresetResetRequest> _parser;

		// Token: 0x04000935 RID: 2357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000936 RID: 2358
		public const int UuidFieldNumber = 1;

		// Token: 0x04000937 RID: 2359
		private string uuid_;

		// Token: 0x04000938 RID: 2360
		internal static ForgettableSpellPresetResetRequest EXquFYOatsdpcBdOabLc;
	}
}
