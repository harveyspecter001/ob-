using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C8B RID: 3211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdateBreedRequest : IMessage<CharacterUpdateBreedRequest>, IMessage, IEquatable<CharacterUpdateBreedRequest>, IDeepCloneable<CharacterUpdateBreedRequest>, IBufferMessage
	{
		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x0027CB98 File Offset: 0x0027AD98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUpdateBreedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06009A3E RID: 39486 RVA: 0x0027CBA8 File Offset: 0x0027ADA8
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

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x0027CBB8 File Offset: 0x0027ADB8
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

		// Token: 0x06009A40 RID: 39488 RVA: 0x0027CBC8 File Offset: 0x0027ADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateBreedRequest()
		{
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x0027CBD8 File Offset: 0x0027ADD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateBreedRequest(CharacterUpdateBreedRequest other)
		{
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x0027CBE8 File Offset: 0x0027ADE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateBreedRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x0027CBF8 File Offset: 0x0027ADF8
		// (set) Token: 0x06009A44 RID: 39492 RVA: 0x0027CC08 File Offset: 0x0027AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BreedId
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

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x0027CC18 File Offset: 0x0027AE18
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x0027CC2C File Offset: 0x0027AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x0027CC3C File Offset: 0x0027AE3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06009A48 RID: 39496 RVA: 0x0027CC4C File Offset: 0x0027AE4C
		// (set) Token: 0x06009A49 RID: 39497 RVA: 0x0027CC5C File Offset: 0x0027AE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CosmeticId
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

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x0027CC6C File Offset: 0x0027AE6C
		// (set) Token: 0x06009A4B RID: 39499 RVA: 0x0027CC7C File Offset: 0x0027AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x06009A4C RID: 39500 RVA: 0x0027CC8C File Offset: 0x0027AE8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x0027CC9C File Offset: 0x0027AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdateBreedRequest other)
		{
			return true;
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x0027CCAC File Offset: 0x0027AEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x0027CCBC File Offset: 0x0027AEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x0027CCCC File Offset: 0x0027AECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x0027CCDC File Offset: 0x0027AEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x0027CCEC File Offset: 0x0027AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x0027CCFC File Offset: 0x0027AEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdateBreedRequest other)
		{
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x0027CD0C File Offset: 0x0027AF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x0027CD1C File Offset: 0x0027AF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x0027CD2C File Offset: 0x0027AF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdateBreedRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterUpdateBreedRequest._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				CharacterUpdateBreedRequest._parser = new MessageParser<CharacterUpdateBreedRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x0027CE44 File Offset: 0x0027B044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FD2i3GJxGWaUjUTqjqQb()
		{
			return true;
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x0027CE4C File Offset: 0x0027B04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdateBreedRequest VWYolQJxgJON8uTxSrv3()
		{
			return null;
		}

		// Token: 0x04003931 RID: 14641
		private static readonly MessageParser<CharacterUpdateBreedRequest> _parser;

		// Token: 0x04003932 RID: 14642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003933 RID: 14643
		public const int BreedIdFieldNumber = 1;

		// Token: 0x04003934 RID: 14644
		private int breedId_;

		// Token: 0x04003935 RID: 14645
		public const int GenderFieldNumber = 2;

		// Token: 0x04003936 RID: 14646
		private Gender gender_;

		// Token: 0x04003937 RID: 14647
		public const int ColorsFieldNumber = 3;

		// Token: 0x04003938 RID: 14648
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x04003939 RID: 14649
		private readonly RepeatedField<int> colors_;

		// Token: 0x0400393A RID: 14650
		public const int CosmeticIdFieldNumber = 4;

		// Token: 0x0400393B RID: 14651
		private int cosmeticId_;

		// Token: 0x0400393C RID: 14652
		public const int NameFieldNumber = 5;

		// Token: 0x0400393D RID: 14653
		private string name_;

		// Token: 0x0400393E RID: 14654
		private static CharacterUpdateBreedRequest dAqYpoJxJwW3RVebAKAV;
	}
}
