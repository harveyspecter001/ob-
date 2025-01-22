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
	// Token: 0x02000126 RID: 294
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellsEvent : IMessage<ForgettableSpellsEvent>, IMessage, IEquatable<ForgettableSpellsEvent>, IDeepCloneable<ForgettableSpellsEvent>, IBufferMessage
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0019937C File Offset: 0x0019757C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForgettableSpellsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0019938C File Offset: 0x0019758C
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0019939C File Offset: 0x0019759C
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

		// Token: 0x06000D5E RID: 3422 RVA: 0x001993AC File Offset: 0x001975AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellsEvent()
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x001993BC File Offset: 0x001975BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellsEvent(ForgettableSpellsEvent other)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x001993CC File Offset: 0x001975CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x001993DC File Offset: 0x001975DC
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x001993F0 File Offset: 0x001975F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellsEvent.Types.Action Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForgettableSpellsEvent.Types.Action)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00199400 File Offset: 0x00197600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpellItem> Spells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00199410 File Offset: 0x00197610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00199420 File Offset: 0x00197620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellsEvent other)
		{
			return true;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00199430 File Offset: 0x00197630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00199440 File Offset: 0x00197640
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00199450 File Offset: 0x00197650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00199460 File Offset: 0x00197660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00199470 File Offset: 0x00197670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00199480 File Offset: 0x00197680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellsEvent other)
		{
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00199490 File Offset: 0x00197690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x001994A0 File Offset: 0x001976A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x001994B0 File Offset: 0x001976B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellsEvent()
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
					case 1:
						ForgettableSpellsEvent._repeated_spells_codec = FieldCodec.ForMessage<SpellItem>(18U, rnJsxILsIw0B91mWIKF.XVInXhlssT(rnJsxILsIw0B91mWIKF.QiaLdxZkEv));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						ForgettableSpellsEvent._parser = new MessageParser<ForgettableSpellsEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 4:
						goto IL_72;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						continue;
					}
					return;
				}
				IL_72:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x001995A4 File Offset: 0x001977A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EpVc3LOcW7Q3XhnlnNhH()
		{
			return true;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x001995AC File Offset: 0x001977AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellsEvent HejbgbOchZsU2JXrkMf8()
		{
			return null;
		}

		// Token: 0x040004DB RID: 1243
		private static readonly MessageParser<ForgettableSpellsEvent> _parser;

		// Token: 0x040004DC RID: 1244
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004DD RID: 1245
		public const int ActionFieldNumber = 1;

		// Token: 0x040004DE RID: 1246
		private ForgettableSpellsEvent.Types.Action action_;

		// Token: 0x040004DF RID: 1247
		public const int SpellsFieldNumber = 2;

		// Token: 0x040004E0 RID: 1248
		private static readonly FieldCodec<SpellItem> _repeated_spells_codec;

		// Token: 0x040004E1 RID: 1249
		private readonly RepeatedField<SpellItem> spells_;

		// Token: 0x040004E2 RID: 1250
		private static ForgettableSpellsEvent z4TUKfOcLLVa8QEAC0bK;

		// Token: 0x02000127 RID: 295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06000D71 RID: 3441 RVA: 0x002ABB4C File Offset: 0x002A9D4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000128 RID: 296
			public enum Action
			{
				// Token: 0x040004E4 RID: 1252
				[OriginalName("DISPATCH")]
				Dispatch,
				// Token: 0x040004E5 RID: 1253
				[OriginalName("UPDATE")]
				Update
			}
		}
	}
}
