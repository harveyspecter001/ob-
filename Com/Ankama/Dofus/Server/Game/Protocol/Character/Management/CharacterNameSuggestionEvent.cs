using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200093B RID: 2363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterNameSuggestionEvent : IMessage<CharacterNameSuggestionEvent>, IMessage, IEquatable<CharacterNameSuggestionEvent>, IDeepCloneable<CharacterNameSuggestionEvent>, IBufferMessage
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x0023D8A8 File Offset: 0x0023BAA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterNameSuggestionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600726F RID: 29295 RVA: 0x0023D8B8 File Offset: 0x0023BAB8
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x0023D8C8 File Offset: 0x0023BAC8
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

		// Token: 0x06007271 RID: 29297 RVA: 0x0023D8D8 File Offset: 0x0023BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionEvent()
		{
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x0023D8E8 File Offset: 0x0023BAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionEvent(CharacterNameSuggestionEvent other)
		{
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x0023D8F8 File Offset: 0x0023BAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x0023D908 File Offset: 0x0023BB08
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x0023D918 File Offset: 0x0023BB18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Suggestion
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

		// Token: 0x06007276 RID: 29302 RVA: 0x0023D928 File Offset: 0x0023BB28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x0023D938 File Offset: 0x0023BB38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterNameSuggestionEvent other)
		{
			return true;
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x0023D948 File Offset: 0x0023BB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x0023D958 File Offset: 0x0023BB58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x0023D968 File Offset: 0x0023BB68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x0023D978 File Offset: 0x0023BB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x0023D988 File Offset: 0x0023BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x0023D998 File Offset: 0x0023BB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterNameSuggestionEvent other)
		{
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x0023D9A8 File Offset: 0x0023BBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x0023D9B8 File Offset: 0x0023BBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x0023D9C8 File Offset: 0x0023BBC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterNameSuggestionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CharacterNameSuggestionEvent._parser = new MessageParser<CharacterNameSuggestionEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x0023DA94 File Offset: 0x0023BC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aOJsgrJeuTTsqtBMVANP()
		{
			return true;
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x0023DA9C File Offset: 0x0023BC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterNameSuggestionEvent BWb83DJe81uUeHEmL5H8()
		{
			return null;
		}

		// Token: 0x0400280B RID: 10251
		private static readonly MessageParser<CharacterNameSuggestionEvent> _parser;

		// Token: 0x0400280C RID: 10252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400280D RID: 10253
		public const int SuggestionFieldNumber = 1;

		// Token: 0x0400280E RID: 10254
		private string suggestion_;

		// Token: 0x0400280F RID: 10255
		private static CharacterNameSuggestionEvent lOJ3knJeMcg7Z1Fvu8u9;
	}
}
