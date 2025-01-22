using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008F1 RID: 2289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterLevelUpEvent : IMessage<CharacterLevelUpEvent>, IMessage, IEquatable<CharacterLevelUpEvent>, IDeepCloneable<CharacterLevelUpEvent>, IBufferMessage
	{
		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x002387D8 File Offset: 0x002369D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterLevelUpEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x002387E8 File Offset: 0x002369E8
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

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06006F4A RID: 28490 RVA: 0x002387F8 File Offset: 0x002369F8
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

		// Token: 0x06006F4B RID: 28491 RVA: 0x00238808 File Offset: 0x00236A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLevelUpEvent()
		{
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00238818 File Offset: 0x00236A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLevelUpEvent(CharacterLevelUpEvent other)
		{
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00238828 File Offset: 0x00236A28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLevelUpEvent Clone()
		{
			return null;
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x00238838 File Offset: 0x00236A38
		// (set) Token: 0x06006F4F RID: 28495 RVA: 0x00238848 File Offset: 0x00236A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewLevel
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

		// Token: 0x06006F50 RID: 28496 RVA: 0x00238858 File Offset: 0x00236A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x00238868 File Offset: 0x00236A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterLevelUpEvent other)
		{
			return true;
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x00238878 File Offset: 0x00236A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x00238888 File Offset: 0x00236A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00238898 File Offset: 0x00236A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x002388A8 File Offset: 0x00236AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x002388B8 File Offset: 0x00236AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x002388C8 File Offset: 0x00236AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterLevelUpEvent other)
		{
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x002388D8 File Offset: 0x00236AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x002388E8 File Offset: 0x00236AE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x002388F8 File Offset: 0x00236AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterLevelUpEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					CharacterLevelUpEvent._parser = new MessageParser<CharacterLevelUpEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x002389C4 File Offset: 0x00236BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DHgxuFJBvcl97akaZLPr()
		{
			return true;
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x002389CC File Offset: 0x00236BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterLevelUpEvent GLD0iPJBoA16IlU25RZG()
		{
			return null;
		}

		// Token: 0x040026F7 RID: 9975
		private static readonly MessageParser<CharacterLevelUpEvent> _parser;

		// Token: 0x040026F8 RID: 9976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F9 RID: 9977
		public const int NewLevelFieldNumber = 1;

		// Token: 0x040026FA RID: 9978
		private int newLevel_;

		// Token: 0x040026FB RID: 9979
		internal static CharacterLevelUpEvent sjnNnqJBUBlY1F2bjYaG;
	}
}
