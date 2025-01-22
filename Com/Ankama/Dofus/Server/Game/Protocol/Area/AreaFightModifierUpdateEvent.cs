using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Area
{
	// Token: 0x02000C5C RID: 3164
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AreaFightModifierUpdateEvent : IMessage<AreaFightModifierUpdateEvent>, IMessage, IEquatable<AreaFightModifierUpdateEvent>, IDeepCloneable<AreaFightModifierUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x060097FA RID: 38906 RVA: 0x00279050 File Offset: 0x00277250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaFightModifierUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x060097FB RID: 38907 RVA: 0x00279060 File Offset: 0x00277260
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

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x060097FC RID: 38908 RVA: 0x00279070 File Offset: 0x00277270
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

		// Token: 0x060097FD RID: 38909 RVA: 0x00279080 File Offset: 0x00277280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AreaFightModifierUpdateEvent()
		{
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x00279090 File Offset: 0x00277290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AreaFightModifierUpdateEvent(AreaFightModifierUpdateEvent other)
		{
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x002790A0 File Offset: 0x002772A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AreaFightModifierUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06009800 RID: 38912 RVA: 0x002790B0 File Offset: 0x002772B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpellPairs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009801 RID: 38913 RVA: 0x002790C0 File Offset: 0x002772C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x002790D0 File Offset: 0x002772D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AreaFightModifierUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06009803 RID: 38915 RVA: 0x002790E0 File Offset: 0x002772E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x002790F0 File Offset: 0x002772F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009805 RID: 38917 RVA: 0x00279100 File Offset: 0x00277300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009806 RID: 38918 RVA: 0x00279110 File Offset: 0x00277310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x00279120 File Offset: 0x00277320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x00279130 File Offset: 0x00277330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AreaFightModifierUpdateEvent other)
		{
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x00279140 File Offset: 0x00277340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x00279150 File Offset: 0x00277350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x00279160 File Offset: 0x00277360
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AreaFightModifierUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					AreaFightModifierUpdateEvent._repeated_spellPairs_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AreaFightModifierUpdateEvent._parser = new MessageParser<AreaFightModifierUpdateEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x0600980C RID: 38924 RVA: 0x00279260 File Offset: 0x00277460
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rrrQv9JNNnu2xAfSpm0w()
		{
			return true;
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x00279268 File Offset: 0x00277468
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AreaFightModifierUpdateEvent SxbYW9JNxWPLAvixsex9()
		{
			return null;
		}

		// Token: 0x0400386B RID: 14443
		private static readonly MessageParser<AreaFightModifierUpdateEvent> _parser;

		// Token: 0x0400386C RID: 14444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400386D RID: 14445
		public const int SpellPairsFieldNumber = 1;

		// Token: 0x0400386E RID: 14446
		private static readonly FieldCodec<int> _repeated_spellPairs_codec;

		// Token: 0x0400386F RID: 14447
		private readonly RepeatedField<int> spellPairs_;

		// Token: 0x04003870 RID: 14448
		private static AreaFightModifierUpdateEvent CQLjPBJNX2MRQSIxatcv;
	}
}
