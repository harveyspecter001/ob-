using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000941 RID: 2369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterDeletionPrepareEvent : IMessage<CharacterDeletionPrepareEvent>, IMessage, IEquatable<CharacterDeletionPrepareEvent>, IDeepCloneable<CharacterDeletionPrepareEvent>, IBufferMessage
	{
		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x0023DCD0 File Offset: 0x0023BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterDeletionPrepareEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x0023DCE0 File Offset: 0x0023BEE0
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

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x0023DCF0 File Offset: 0x0023BEF0
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

		// Token: 0x060072A6 RID: 29350 RVA: 0x0023DD00 File Offset: 0x0023BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionPrepareEvent()
		{
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x0023DD10 File Offset: 0x0023BF10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionPrepareEvent(CharacterDeletionPrepareEvent other)
		{
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x0023DD20 File Offset: 0x0023BF20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionPrepareEvent Clone()
		{
			return null;
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x0023DD30 File Offset: 0x0023BF30
		// (set) Token: 0x060072AA RID: 29354 RVA: 0x0023DD40 File Offset: 0x0023BF40
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x0023DD50 File Offset: 0x0023BF50
		// (set) Token: 0x060072AC RID: 29356 RVA: 0x0023DD60 File Offset: 0x0023BF60
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x060072AD RID: 29357 RVA: 0x0023DD70 File Offset: 0x0023BF70
		// (set) Token: 0x060072AE RID: 29358 RVA: 0x0023DD80 File Offset: 0x0023BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SecretQuestion
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x0023DD90 File Offset: 0x0023BF90
		// (set) Token: 0x060072B0 RID: 29360 RVA: 0x0023DDA0 File Offset: 0x0023BFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedSecretAnswer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x0023DDB0 File Offset: 0x0023BFB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x0023DDC0 File Offset: 0x0023BFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterDeletionPrepareEvent other)
		{
			return true;
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x0023DDD0 File Offset: 0x0023BFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x0023DDE0 File Offset: 0x0023BFE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x0023DDF0 File Offset: 0x0023BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x0023DE00 File Offset: 0x0023C000
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x0023DE10 File Offset: 0x0023C010
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x0023DE20 File Offset: 0x0023C020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterDeletionPrepareEvent other)
		{
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x0023DE30 File Offset: 0x0023C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x0023DE40 File Offset: 0x0023C040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x0023DE50 File Offset: 0x0023C050
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterDeletionPrepareEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterDeletionPrepareEvent._parser = new MessageParser<CharacterDeletionPrepareEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x0023DF48 File Offset: 0x0023C148
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YrmaaLJ3fELKlc0wjSB2()
		{
			return true;
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x0023DF50 File Offset: 0x0023C150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterDeletionPrepareEvent kuUJPMJ3nf5qxgIoNsPU()
		{
			return null;
		}

		// Token: 0x0400281C RID: 10268
		private static readonly MessageParser<CharacterDeletionPrepareEvent> _parser;

		// Token: 0x0400281D RID: 10269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400281E RID: 10270
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400281F RID: 10271
		private long characterId_;

		// Token: 0x04002820 RID: 10272
		public const int NameFieldNumber = 2;

		// Token: 0x04002821 RID: 10273
		private string name_;

		// Token: 0x04002822 RID: 10274
		public const int SecretQuestionFieldNumber = 3;

		// Token: 0x04002823 RID: 10275
		private string secretQuestion_;

		// Token: 0x04002824 RID: 10276
		public const int NeedSecretAnswerFieldNumber = 4;

		// Token: 0x04002825 RID: 10277
		private bool needSecretAnswer_;

		// Token: 0x04002826 RID: 10278
		internal static CharacterDeletionPrepareEvent iUsNucJeze3pdvRvHkjc;
	}
}
