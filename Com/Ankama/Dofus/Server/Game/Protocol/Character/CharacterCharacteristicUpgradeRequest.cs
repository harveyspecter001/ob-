using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008E9 RID: 2281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicUpgradeRequest : IMessage<CharacterCharacteristicUpgradeRequest>, IMessage, IEquatable<CharacterCharacteristicUpgradeRequest>, IDeepCloneable<CharacterCharacteristicUpgradeRequest>, IBufferMessage
	{
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x00237EC8 File Offset: 0x002360C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterCharacteristicUpgradeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06006ED5 RID: 28373 RVA: 0x00237ED8 File Offset: 0x002360D8
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

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x00237EE8 File Offset: 0x002360E8
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

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00237EF8 File Offset: 0x002360F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeRequest()
		{
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x00237F08 File Offset: 0x00236108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeRequest(CharacterCharacteristicUpgradeRequest other)
		{
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00237F18 File Offset: 0x00236118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeRequest Clone()
		{
			return null;
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x00237F28 File Offset: 0x00236128
		// (set) Token: 0x06006EDB RID: 28379 RVA: 0x00237F38 File Offset: 0x00236138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Strength
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x00237F48 File Offset: 0x00236148
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x00237F58 File Offset: 0x00236158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Vitality
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

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x00237F68 File Offset: 0x00236168
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x00237F78 File Offset: 0x00236178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Wisdom
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x00237F88 File Offset: 0x00236188
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x00237F98 File Offset: 0x00236198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Chance
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

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x00237FA8 File Offset: 0x002361A8
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x00237FB8 File Offset: 0x002361B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Agility
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

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x00237FC8 File Offset: 0x002361C8
		// (set) Token: 0x06006EE5 RID: 28389 RVA: 0x00237FD8 File Offset: 0x002361D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Intelligence
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

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00237FE8 File Offset: 0x002361E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x00237FF8 File Offset: 0x002361F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicUpgradeRequest other)
		{
			return true;
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00238008 File Offset: 0x00236208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00238018 File Offset: 0x00236218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00238028 File Offset: 0x00236228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x00238038 File Offset: 0x00236238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00238048 File Offset: 0x00236248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00238058 File Offset: 0x00236258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicUpgradeRequest other)
		{
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x00238068 File Offset: 0x00236268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x00238078 File Offset: 0x00236278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x00238088 File Offset: 0x00236288
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicUpgradeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					CharacterCharacteristicUpgradeRequest._parser = new MessageParser<CharacterCharacteristicUpgradeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x0023816C File Offset: 0x0023636C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mc5bMVJBE3E5AtRO88J0()
		{
			return true;
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x00238174 File Offset: 0x00236374
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicUpgradeRequest oS7aF9JBX3jFCS2EebD6()
		{
			return null;
		}

		// Token: 0x040026CF RID: 9935
		private static readonly MessageParser<CharacterCharacteristicUpgradeRequest> _parser;

		// Token: 0x040026D0 RID: 9936
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026D1 RID: 9937
		public const int StrengthFieldNumber = 1;

		// Token: 0x040026D2 RID: 9938
		private int strength_;

		// Token: 0x040026D3 RID: 9939
		public const int VitalityFieldNumber = 2;

		// Token: 0x040026D4 RID: 9940
		private int vitality_;

		// Token: 0x040026D5 RID: 9941
		public const int WisdomFieldNumber = 3;

		// Token: 0x040026D6 RID: 9942
		private int wisdom_;

		// Token: 0x040026D7 RID: 9943
		public const int ChanceFieldNumber = 4;

		// Token: 0x040026D8 RID: 9944
		private int chance_;

		// Token: 0x040026D9 RID: 9945
		public const int AgilityFieldNumber = 5;

		// Token: 0x040026DA RID: 9946
		private int agility_;

		// Token: 0x040026DB RID: 9947
		public const int IntelligenceFieldNumber = 6;

		// Token: 0x040026DC RID: 9948
		private int intelligence_;

		// Token: 0x040026DD RID: 9949
		private static CharacterCharacteristicUpgradeRequest FGhFp7JB2aL0Z08FH81N;
	}
}
