using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200093D RID: 2365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterNameGenerationFailedEvent : IMessage<CharacterNameGenerationFailedEvent>, IMessage, IEquatable<CharacterNameGenerationFailedEvent>, IDeepCloneable<CharacterNameGenerationFailedEvent>, IBufferMessage
	{
		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x0023DAA4 File Offset: 0x0023BCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterNameGenerationFailedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x0023DAB4 File Offset: 0x0023BCB4
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

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x0023DAC4 File Offset: 0x0023BCC4
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

		// Token: 0x0600728B RID: 29323 RVA: 0x0023DAD4 File Offset: 0x0023BCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameGenerationFailedEvent()
		{
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x0023DAE4 File Offset: 0x0023BCE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameGenerationFailedEvent(CharacterNameGenerationFailedEvent other)
		{
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x0023DAF4 File Offset: 0x0023BCF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameGenerationFailedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x0023DB04 File Offset: 0x0023BD04
		// (set) Token: 0x0600728F RID: 29327 RVA: 0x0023DB18 File Offset: 0x0023BD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterNameGenerationFailedEvent.Types.NameGenerationFailureReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterNameGenerationFailedEvent.Types.NameGenerationFailureReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x0023DB28 File Offset: 0x0023BD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x0023DB38 File Offset: 0x0023BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterNameGenerationFailedEvent other)
		{
			return true;
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x0023DB48 File Offset: 0x0023BD48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x0023DB58 File Offset: 0x0023BD58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x0023DB68 File Offset: 0x0023BD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x0023DB78 File Offset: 0x0023BD78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x0023DB88 File Offset: 0x0023BD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x0023DB98 File Offset: 0x0023BD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterNameGenerationFailedEvent other)
		{
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x0023DBA8 File Offset: 0x0023BDA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x0023DBB8 File Offset: 0x0023BDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x0023DBC8 File Offset: 0x0023BDC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterNameGenerationFailedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					CharacterNameGenerationFailedEvent._parser = new MessageParser<CharacterNameGenerationFailedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x0023DCC0 File Offset: 0x0023BEC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DQtLaJJeq4D68ICekjic()
		{
			return true;
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x0023DCC8 File Offset: 0x0023BEC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterNameGenerationFailedEvent BPCcUHJeFxVJ7r5fpbj8()
		{
			return null;
		}

		// Token: 0x04002812 RID: 10258
		private static readonly MessageParser<CharacterNameGenerationFailedEvent> _parser;

		// Token: 0x04002813 RID: 10259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002814 RID: 10260
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002815 RID: 10261
		private CharacterNameGenerationFailedEvent.Types.NameGenerationFailureReason reason_;

		// Token: 0x04002816 RID: 10262
		private static CharacterNameGenerationFailedEvent CSJKIMJeZ76NW4rVO4Xk;

		// Token: 0x0200093E RID: 2366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600729D RID: 29341 RVA: 0x002DC034 File Offset: 0x002DA234
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200093F RID: 2367
			public enum NameGenerationFailureReason
			{
				// Token: 0x04002818 RID: 10264
				[OriginalName("NAME_GENERATOR_RETRY_TOO_SHORT")]
				NameGeneratorRetryTooShort,
				// Token: 0x04002819 RID: 10265
				[OriginalName("NAME_GENERATOR_UNAVAILABLE")]
				NameGeneratorUnavailable
			}
		}
	}
}
