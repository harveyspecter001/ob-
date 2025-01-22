using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000884 RID: 2180
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactLevelUpEvent : IMessage<ContactLevelUpEvent>, IMessage, IEquatable<ContactLevelUpEvent>, IDeepCloneable<ContactLevelUpEvent>, IBufferMessage
	{
		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060069C1 RID: 27073 RVA: 0x0022EEF0 File Offset: 0x0022D0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContactLevelUpEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060069C2 RID: 27074 RVA: 0x0022EF00 File Offset: 0x0022D100
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

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060069C3 RID: 27075 RVA: 0x0022EF10 File Offset: 0x0022D110
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

		// Token: 0x060069C4 RID: 27076 RVA: 0x0022EF20 File Offset: 0x0022D120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLevelUpEvent()
		{
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x0022EF30 File Offset: 0x0022D130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLevelUpEvent(ContactLevelUpEvent other)
		{
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x0022EF40 File Offset: 0x0022D140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactLevelUpEvent Clone()
		{
			return null;
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x0022EF50 File Offset: 0x0022D150
		// (set) Token: 0x060069C8 RID: 27080 RVA: 0x0022EF60 File Offset: 0x0022D160
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x0022EF70 File Offset: 0x0022D170
		// (set) Token: 0x060069CA RID: 27082 RVA: 0x0022EF80 File Offset: 0x0022D180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060069CB RID: 27083 RVA: 0x0022EF90 File Offset: 0x0022D190
		// (set) Token: 0x060069CC RID: 27084 RVA: 0x0022EFA0 File Offset: 0x0022D1A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060069CD RID: 27085 RVA: 0x0022EFB0 File Offset: 0x0022D1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x0022EFC0 File Offset: 0x0022D1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactLevelUpEvent other)
		{
			return true;
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0022EFD0 File Offset: 0x0022D1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x0022EFE0 File Offset: 0x0022D1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x0022EFF0 File Offset: 0x0022D1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x0022F000 File Offset: 0x0022D200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x0022F010 File Offset: 0x0022D210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x0022F020 File Offset: 0x0022D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactLevelUpEvent other)
		{
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x0022F030 File Offset: 0x0022D230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x0022F040 File Offset: 0x0022D240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x0022F050 File Offset: 0x0022D250
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactLevelUpEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ContactLevelUpEvent._parser = new MessageParser<ContactLevelUpEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x0022F134 File Offset: 0x0022D334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aCixu5JnMxsfKHWQwbHu()
		{
			return true;
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x0022F13C File Offset: 0x0022D33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactLevelUpEvent aBRXUBJnuU8aVeNuiqOn()
		{
			return null;
		}

		// Token: 0x040024F0 RID: 9456
		private static readonly MessageParser<ContactLevelUpEvent> _parser;

		// Token: 0x040024F1 RID: 9457
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024F2 RID: 9458
		public const int NameFieldNumber = 1;

		// Token: 0x040024F3 RID: 9459
		private string name_;

		// Token: 0x040024F4 RID: 9460
		public const int CharacterIdFieldNumber = 2;

		// Token: 0x040024F5 RID: 9461
		private long characterId_;

		// Token: 0x040024F6 RID: 9462
		public const int LevelFieldNumber = 3;

		// Token: 0x040024F7 RID: 9463
		private int level_;

		// Token: 0x040024F8 RID: 9464
		private static ContactLevelUpEvent f2lFJuJnSuJZNYIJTAgU;
	}
}
