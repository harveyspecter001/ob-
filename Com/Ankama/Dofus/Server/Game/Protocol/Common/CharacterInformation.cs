using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A5D RID: 2653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterInformation : IMessage<CharacterInformation>, IMessage, IEquatable<CharacterInformation>, IDeepCloneable<CharacterInformation>, IBufferMessage
	{
		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x0025E1B0 File Offset: 0x0025C3B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06007E91 RID: 32401 RVA: 0x0025E1C0 File Offset: 0x0025C3C0
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x0025E1D0 File Offset: 0x0025C3D0
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

		// Token: 0x06007E93 RID: 32403 RVA: 0x0025E1E0 File Offset: 0x0025C3E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation()
		{
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0025E1F0 File Offset: 0x0025C3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation(CharacterInformation other)
		{
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x0025E200 File Offset: 0x0025C400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation Clone()
		{
			return null;
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06007E96 RID: 32406 RVA: 0x0025E210 File Offset: 0x0025C410
		// (set) Token: 0x06007E97 RID: 32407 RVA: 0x0025E220 File Offset: 0x0025C420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharacterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06007E98 RID: 32408 RVA: 0x0025E230 File Offset: 0x0025C430
		// (set) Token: 0x06007E99 RID: 32409 RVA: 0x0025E240 File Offset: 0x0025C440
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

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x0025E250 File Offset: 0x0025C450
		// (set) Token: 0x06007E9B RID: 32411 RVA: 0x0025E260 File Offset: 0x0025C460
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

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x0025E270 File Offset: 0x0025C470
		// (set) Token: 0x06007E9D RID: 32413 RVA: 0x0025E284 File Offset: 0x0025C484
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

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x0025E294 File Offset: 0x0025C494
		// (set) Token: 0x06007E9F RID: 32415 RVA: 0x0025E2A4 File Offset: 0x0025C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x0025E2B4 File Offset: 0x0025C4B4
		// (set) Token: 0x06007EA1 RID: 32417 RVA: 0x0025E2C4 File Offset: 0x0025C4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x0025E2D4 File Offset: 0x0025C4D4
		// (set) Token: 0x06007EA3 RID: 32419 RVA: 0x0025E2E4 File Offset: 0x0025C4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AccountTag
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

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0025E2F4 File Offset: 0x0025C4F4
		// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x0025E304 File Offset: 0x0025C504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AccountNickname
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

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x0025E314 File Offset: 0x0025C514
		// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x0025E324 File Offset: 0x0025C524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterStatus Status
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

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0025E334 File Offset: 0x0025C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0025E344 File Offset: 0x0025C544
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterInformation other)
		{
			return true;
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0025E354 File Offset: 0x0025C554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0025E364 File Offset: 0x0025C564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x0025E374 File Offset: 0x0025C574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x0025E384 File Offset: 0x0025C584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0025E394 File Offset: 0x0025C594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x0025E3A4 File Offset: 0x0025C5A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterInformation other)
		{
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0025E3B4 File Offset: 0x0025C5B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x0025E3C4 File Offset: 0x0025C5C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0025E3D4 File Offset: 0x0025C5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				CharacterInformation._parser = new MessageParser<CharacterInformation>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0025E4B8 File Offset: 0x0025C6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EdiEfoJG77gdL9wa82Mp()
		{
			return true;
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0025E4C0 File Offset: 0x0025C6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterInformation rkLFBHJGTXNSVwcPvcDp()
		{
			return null;
		}

		// Token: 0x04002DC0 RID: 11712
		private static readonly MessageParser<CharacterInformation> _parser;

		// Token: 0x04002DC1 RID: 11713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC2 RID: 11714
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002DC3 RID: 11715
		private long characterId_;

		// Token: 0x04002DC4 RID: 11716
		public const int NameFieldNumber = 2;

		// Token: 0x04002DC5 RID: 11717
		private string name_;

		// Token: 0x04002DC6 RID: 11718
		public const int BreedIdFieldNumber = 3;

		// Token: 0x04002DC7 RID: 11719
		private int breedId_;

		// Token: 0x04002DC8 RID: 11720
		public const int GenderFieldNumber = 4;

		// Token: 0x04002DC9 RID: 11721
		private Gender gender_;

		// Token: 0x04002DCA RID: 11722
		public const int LevelFieldNumber = 5;

		// Token: 0x04002DCB RID: 11723
		private int level_;

		// Token: 0x04002DCC RID: 11724
		public const int AccountIdFieldNumber = 6;

		// Token: 0x04002DCD RID: 11725
		private long accountId_;

		// Token: 0x04002DCE RID: 11726
		public const int AccountTagFieldNumber = 7;

		// Token: 0x04002DCF RID: 11727
		private string accountTag_;

		// Token: 0x04002DD0 RID: 11728
		public const int AccountNicknameFieldNumber = 8;

		// Token: 0x04002DD1 RID: 11729
		private string accountNickname_;

		// Token: 0x04002DD2 RID: 11730
		public const int StatusFieldNumber = 9;

		// Token: 0x04002DD3 RID: 11731
		private CharacterStatus status_;

		// Token: 0x04002DD4 RID: 11732
		internal static CharacterInformation t7mCqfJGQ0KVrdoidA0Y;
	}
}
