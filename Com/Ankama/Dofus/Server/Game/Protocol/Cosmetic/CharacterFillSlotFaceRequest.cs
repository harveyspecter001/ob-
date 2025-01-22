using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C6B RID: 3179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFillSlotFaceRequest : IMessage<CharacterFillSlotFaceRequest>, IMessage, IEquatable<CharacterFillSlotFaceRequest>, IDeepCloneable<CharacterFillSlotFaceRequest>, IBufferMessage
	{
		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x060098BA RID: 39098 RVA: 0x0027B514 File Offset: 0x00279714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterFillSlotFaceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x060098BB RID: 39099 RVA: 0x0027B524 File Offset: 0x00279724
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

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x060098BC RID: 39100 RVA: 0x0027B534 File Offset: 0x00279734
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

		// Token: 0x060098BD RID: 39101 RVA: 0x0027B544 File Offset: 0x00279744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceRequest()
		{
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x0027B554 File Offset: 0x00279754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceRequest(CharacterFillSlotFaceRequest other)
		{
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0027B564 File Offset: 0x00279764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceRequest Clone()
		{
			return null;
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x060098C0 RID: 39104 RVA: 0x0027B574 File Offset: 0x00279774
		// (set) Token: 0x060098C1 RID: 39105 RVA: 0x0027B584 File Offset: 0x00279784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Face
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

		// Token: 0x060098C2 RID: 39106 RVA: 0x0027B594 File Offset: 0x00279794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x0027B5A4 File Offset: 0x002797A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFillSlotFaceRequest other)
		{
			return true;
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x0027B5B4 File Offset: 0x002797B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x0027B5C4 File Offset: 0x002797C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0027B5D4 File Offset: 0x002797D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0027B5E4 File Offset: 0x002797E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x0027B5F4 File Offset: 0x002797F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x0027B604 File Offset: 0x00279804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFillSlotFaceRequest other)
		{
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x0027B614 File Offset: 0x00279814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x0027B624 File Offset: 0x00279824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x0027B634 File Offset: 0x00279834
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFillSlotFaceRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CharacterFillSlotFaceRequest._parser = new MessageParser<CharacterFillSlotFaceRequest>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x0027B718 File Offset: 0x00279918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IesbPVJNDjmE08kRqiNF()
		{
			return true;
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x0027B720 File Offset: 0x00279920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFillSlotFaceRequest RXHFTmJNteiNOg9BWcQD()
		{
			return null;
		}

		// Token: 0x040038AC RID: 14508
		private static readonly MessageParser<CharacterFillSlotFaceRequest> _parser;

		// Token: 0x040038AD RID: 14509
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038AE RID: 14510
		public const int FaceFieldNumber = 1;

		// Token: 0x040038AF RID: 14511
		private int face_;

		// Token: 0x040038B0 RID: 14512
		private static CharacterFillSlotFaceRequest cV3ia5JNCsMVkua0A9cH;
	}
}
