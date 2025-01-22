using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x02000122 RID: 290
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellDeletionEvent : IMessage<ForgettableSpellDeletionEvent>, IMessage, IEquatable<ForgettableSpellDeletionEvent>, IDeepCloneable<ForgettableSpellDeletionEvent>, IBufferMessage
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00199130 File Offset: 0x00197330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellDeletionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00199140 File Offset: 0x00197340
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00199150 File Offset: 0x00197350
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x00199160 File Offset: 0x00197360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellDeletionEvent()
		{
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00199170 File Offset: 0x00197370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellDeletionEvent(ForgettableSpellDeletionEvent other)
		{
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00199180 File Offset: 0x00197380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellDeletionEvent Clone()
		{
			return null;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00199190 File Offset: 0x00197390
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x001991A4 File Offset: 0x001973A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellDeletionEvent.Types.DeletionReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForgettableSpellDeletionEvent.Types.DeletionReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x001991B4 File Offset: 0x001973B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Spells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x001991C4 File Offset: 0x001973C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x001991D4 File Offset: 0x001973D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellDeletionEvent other)
		{
			return true;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x001991E4 File Offset: 0x001973E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x001991F4 File Offset: 0x001973F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00199204 File Offset: 0x00197404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00199214 File Offset: 0x00197414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00199224 File Offset: 0x00197424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00199234 File Offset: 0x00197434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellDeletionEvent other)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00199244 File Offset: 0x00197444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00199254 File Offset: 0x00197454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00199264 File Offset: 0x00197464
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellDeletionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						ForgettableSpellDeletionEvent._repeated_spells_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						return;
					case 2:
						ForgettableSpellDeletionEvent._parser = new MessageParser<ForgettableSpellDeletionEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						goto IL_AB;
					case 4:
						goto IL_69;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 4;
						}
						break;
					}
				}
				IL_69:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				IL_AB:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0019936C File Offset: 0x0019756C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K3g05nOcy79x4V0q3aoj()
		{
			return true;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00199374 File Offset: 0x00197574
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellDeletionEvent AdLeiKOc64V1NPWB6ZgK()
		{
			return null;
		}

		// Token: 0x040004CB RID: 1227
		private static readonly MessageParser<ForgettableSpellDeletionEvent> _parser;

		// Token: 0x040004CC RID: 1228
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004CD RID: 1229
		public const int ReasonFieldNumber = 1;

		// Token: 0x040004CE RID: 1230
		private ForgettableSpellDeletionEvent.Types.DeletionReason reason_;

		// Token: 0x040004CF RID: 1231
		public const int SpellsFieldNumber = 2;

		// Token: 0x040004D0 RID: 1232
		private static readonly FieldCodec<int> _repeated_spells_codec;

		// Token: 0x040004D1 RID: 1233
		private readonly RepeatedField<int> spells_;

		// Token: 0x040004D2 RID: 1234
		internal static ForgettableSpellDeletionEvent WPtkIWOc5Rgj1s0sLmVe;

		// Token: 0x02000123 RID: 291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06000D55 RID: 3413 RVA: 0x002ABA28 File Offset: 0x002A9C28
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000124 RID: 292
			public enum DeletionReason
			{
				// Token: 0x040004D4 RID: 1236
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x040004D5 RID: 1237
				[OriginalName("ADMIN_COMMAND_REQUEST")]
				AdminCommandRequest,
				// Token: 0x040004D6 RID: 1238
				[OriginalName("FORGOTTEN")]
				Forgotten,
				// Token: 0x040004D7 RID: 1239
				[OriginalName("DISABLED")]
				Disabled,
				// Token: 0x040004D8 RID: 1240
				[OriginalName("NOT_FOUND")]
				NotFound
			}
		}
	}
}
