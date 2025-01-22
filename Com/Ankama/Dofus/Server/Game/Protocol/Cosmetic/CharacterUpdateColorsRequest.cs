using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C83 RID: 3203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdateColorsRequest : IMessage<CharacterUpdateColorsRequest>, IMessage, IEquatable<CharacterUpdateColorsRequest>, IDeepCloneable<CharacterUpdateColorsRequest>, IBufferMessage
	{
		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x060099CA RID: 39370 RVA: 0x0027C234 File Offset: 0x0027A434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUpdateColorsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x060099CB RID: 39371 RVA: 0x0027C244 File Offset: 0x0027A444
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

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x060099CC RID: 39372 RVA: 0x0027C254 File Offset: 0x0027A454
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

		// Token: 0x060099CD RID: 39373 RVA: 0x0027C264 File Offset: 0x0027A464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateColorsRequest()
		{
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x0027C274 File Offset: 0x0027A474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateColorsRequest(CharacterUpdateColorsRequest other)
		{
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x0027C284 File Offset: 0x0027A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateColorsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x0027C294 File Offset: 0x0027A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x060099D1 RID: 39377 RVA: 0x0027C2A4 File Offset: 0x0027A4A4
		// (set) Token: 0x060099D2 RID: 39378 RVA: 0x0027C2B4 File Offset: 0x0027A4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Slot
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

		// Token: 0x060099D3 RID: 39379 RVA: 0x0027C2C4 File Offset: 0x0027A4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x0027C2D4 File Offset: 0x0027A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdateColorsRequest other)
		{
			return true;
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x0027C2E4 File Offset: 0x0027A4E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x0027C2F4 File Offset: 0x0027A4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x0027C304 File Offset: 0x0027A504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x0027C314 File Offset: 0x0027A514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x0027C324 File Offset: 0x0027A524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x0027C334 File Offset: 0x0027A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdateColorsRequest other)
		{
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x0027C344 File Offset: 0x0027A544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x0027C354 File Offset: 0x0027A554
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x0027C364 File Offset: 0x0027A564
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdateColorsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_4E;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					case 5:
						CharacterUpdateColorsRequest._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					CharacterUpdateColorsRequest._parser = new MessageParser<CharacterUpdateColorsRequest>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 3;
					}
				}
				IL_4E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x0027C468 File Offset: 0x0027A668
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UdqPbcJNF2XiWyQXFvuS()
		{
			return true;
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x0027C470 File Offset: 0x0027A670
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdateColorsRequest rsJQ4NJNzAKifTx9ZHmv()
		{
			return null;
		}

		// Token: 0x04003904 RID: 14596
		private static readonly MessageParser<CharacterUpdateColorsRequest> _parser;

		// Token: 0x04003905 RID: 14597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003906 RID: 14598
		public const int ColorsFieldNumber = 1;

		// Token: 0x04003907 RID: 14599
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x04003908 RID: 14600
		private readonly RepeatedField<int> colors_;

		// Token: 0x04003909 RID: 14601
		public const int SlotFieldNumber = 2;

		// Token: 0x0400390A RID: 14602
		private int slot_;

		// Token: 0x0400390B RID: 14603
		private static CharacterUpdateColorsRequest R2rAmTJNqxbqE1LZn4Qc;
	}
}
