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
	// Token: 0x02000C87 RID: 3207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdateGenderRequest : IMessage<CharacterUpdateGenderRequest>, IMessage, IEquatable<CharacterUpdateGenderRequest>, IDeepCloneable<CharacterUpdateGenderRequest>, IBufferMessage
	{
		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06009A00 RID: 39424 RVA: 0x0027C6A8 File Offset: 0x0027A8A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUpdateGenderRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x0027C6B8 File Offset: 0x0027A8B8
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

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06009A02 RID: 39426 RVA: 0x0027C6C8 File Offset: 0x0027A8C8
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

		// Token: 0x06009A03 RID: 39427 RVA: 0x0027C6D8 File Offset: 0x0027A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateGenderRequest()
		{
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x0027C6E8 File Offset: 0x0027A8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateGenderRequest(CharacterUpdateGenderRequest other)
		{
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x0027C6F8 File Offset: 0x0027A8F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateGenderRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06009A06 RID: 39430 RVA: 0x0027C708 File Offset: 0x0027A908
		// (set) Token: 0x06009A07 RID: 39431 RVA: 0x0027C71C File Offset: 0x0027A91C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06009A08 RID: 39432 RVA: 0x0027C72C File Offset: 0x0027A92C
		// (set) Token: 0x06009A09 RID: 39433 RVA: 0x0027C73C File Offset: 0x0027A93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06009A0A RID: 39434 RVA: 0x0027C74C File Offset: 0x0027A94C
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

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x0027C75C File Offset: 0x0027A95C
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x0027C76C File Offset: 0x0027A96C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06009A0D RID: 39437 RVA: 0x0027C77C File Offset: 0x0027A97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x0027C78C File Offset: 0x0027A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdateGenderRequest other)
		{
			return true;
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x0027C79C File Offset: 0x0027A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x0027C7AC File Offset: 0x0027A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x0027C7BC File Offset: 0x0027A9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x0027C7CC File Offset: 0x0027A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x0027C7DC File Offset: 0x0027A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x0027C7EC File Offset: 0x0027A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdateGenderRequest other)
		{
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x0027C7FC File Offset: 0x0027A9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x0027C80C File Offset: 0x0027AA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x0027C81C File Offset: 0x0027AA1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdateGenderRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CharacterUpdateGenderRequest._parser = new MessageParser<CharacterUpdateGenderRequest>(() => null);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					CharacterUpdateGenderRequest._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x0027C91C File Offset: 0x0027AB1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hG0tGCJxBCaiNWT9Ihbh()
		{
			return true;
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x0027C924 File Offset: 0x0027AB24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdateGenderRequest sIyCd6JxeIFL6PfF8Rvr()
		{
			return null;
		}

		// Token: 0x04003918 RID: 14616
		private static readonly MessageParser<CharacterUpdateGenderRequest> _parser;

		// Token: 0x04003919 RID: 14617
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400391A RID: 14618
		public const int GenderFieldNumber = 1;

		// Token: 0x0400391B RID: 14619
		private Gender gender_;

		// Token: 0x0400391C RID: 14620
		public const int CosmeticIdFieldNumber = 2;

		// Token: 0x0400391D RID: 14621
		private int cosmeticId_;

		// Token: 0x0400391E RID: 14622
		public const int ColorsFieldNumber = 3;

		// Token: 0x0400391F RID: 14623
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x04003920 RID: 14624
		private readonly RepeatedField<int> colors_;

		// Token: 0x04003921 RID: 14625
		public const int NameFieldNumber = 4;

		// Token: 0x04003922 RID: 14626
		private string name_;

		// Token: 0x04003923 RID: 14627
		internal static CharacterUpdateGenderRequest fJSGk9JxAiAQj3yA2sFI;
	}
}
