using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A54 RID: 2644
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristic : IMessage<CharacterCharacteristic>, IMessage, IEquatable<CharacterCharacteristic>, IDeepCloneable<CharacterCharacteristic>, IBufferMessage
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007E0A RID: 32266 RVA: 0x0025D780 File Offset: 0x0025B980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterCharacteristic> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x0025D790 File Offset: 0x0025B990
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

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06007E0C RID: 32268 RVA: 0x0025D7A0 File Offset: 0x0025B9A0
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

		// Token: 0x06007E0D RID: 32269 RVA: 0x0025D7B0 File Offset: 0x0025B9B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristic()
		{
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x0025D7C0 File Offset: 0x0025B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristic(CharacterCharacteristic other)
		{
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0025D7D0 File Offset: 0x0025B9D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristic Clone()
		{
			return null;
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06007E10 RID: 32272 RVA: 0x0025D7E0 File Offset: 0x0025B9E0
		// (set) Token: 0x06007E11 RID: 32273 RVA: 0x0025D7F0 File Offset: 0x0025B9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CharacteristicId
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

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06007E12 RID: 32274 RVA: 0x0025D800 File Offset: 0x0025BA00
		// (set) Token: 0x06007E13 RID: 32275 RVA: 0x0025D810 File Offset: 0x0025BA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterCharacteristicValue Value
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

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06007E14 RID: 32276 RVA: 0x0025D820 File Offset: 0x0025BA20
		// (set) Token: 0x06007E15 RID: 32277 RVA: 0x0025D830 File Offset: 0x0025BA30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterCharacteristicDetailed Detailed
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

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x0025D840 File Offset: 0x0025BA40
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x0025D850 File Offset: 0x0025BA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterCharacteristicDetailedUsable Usable
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

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x0025D860 File Offset: 0x0025BA60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterCharacteristic.CharacterCharacteristicOneofCase CharacterCharacteristicCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterCharacteristic.CharacterCharacteristicOneofCase)null;
			}
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x0025D874 File Offset: 0x0025BA74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCharacterCharacteristic()
		{
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x0025D884 File Offset: 0x0025BA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x0025D894 File Offset: 0x0025BA94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristic other)
		{
			return true;
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x0025D8A4 File Offset: 0x0025BAA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0025D8B4 File Offset: 0x0025BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0025D8C4 File Offset: 0x0025BAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x0025D8D4 File Offset: 0x0025BAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x0025D8E4 File Offset: 0x0025BAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x0025D8F4 File Offset: 0x0025BAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristic other)
		{
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0025D904 File Offset: 0x0025BB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007E23 RID: 32291 RVA: 0x0025D914 File Offset: 0x0025BB14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x0025D924 File Offset: 0x0025BB24
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristic()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				CharacterCharacteristic._parser = new MessageParser<CharacterCharacteristic>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x0025DA1C File Offset: 0x0025BC1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SQJ9jdJG6OCSXpxmIicm()
		{
			return true;
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x0025DA24 File Offset: 0x0025BC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristic FOOtTnJGLvvhjAhF3sfe()
		{
			return null;
		}

		// Token: 0x04002D84 RID: 11652
		private static readonly MessageParser<CharacterCharacteristic> _parser;

		// Token: 0x04002D85 RID: 11653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D86 RID: 11654
		public const int CharacteristicIdFieldNumber = 1;

		// Token: 0x04002D87 RID: 11655
		private int characteristicId_;

		// Token: 0x04002D88 RID: 11656
		public const int ValueFieldNumber = 2;

		// Token: 0x04002D89 RID: 11657
		public const int DetailedFieldNumber = 3;

		// Token: 0x04002D8A RID: 11658
		public const int UsableFieldNumber = 4;

		// Token: 0x04002D8B RID: 11659
		private object characterCharacteristic_;

		// Token: 0x04002D8C RID: 11660
		private CharacterCharacteristic.CharacterCharacteristicOneofCase characterCharacteristicCase_;

		// Token: 0x04002D8D RID: 11661
		internal static CharacterCharacteristic zcqmA8JGysn4ptKs8lV7;

		// Token: 0x02000A55 RID: 2645
		public enum CharacterCharacteristicOneofCase
		{
			// Token: 0x04002D8F RID: 11663
			None,
			// Token: 0x04002D90 RID: 11664
			Value = 2,
			// Token: 0x04002D91 RID: 11665
			Detailed,
			// Token: 0x04002D92 RID: 11666
			Usable
		}
	}
}
