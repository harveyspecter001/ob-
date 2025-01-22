using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000939 RID: 2361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterLoadingCompleteEvent : IMessage<CharacterLoadingCompleteEvent>, IMessage, IEquatable<CharacterLoadingCompleteEvent>, IDeepCloneable<CharacterLoadingCompleteEvent>, IBufferMessage
	{
		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x0023D6C8 File Offset: 0x0023B8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterLoadingCompleteEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x0023D6D8 File Offset: 0x0023B8D8
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06007258 RID: 29272 RVA: 0x0023D6E8 File Offset: 0x0023B8E8
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

		// Token: 0x06007259 RID: 29273 RVA: 0x0023D6F8 File Offset: 0x0023B8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLoadingCompleteEvent()
		{
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x0023D708 File Offset: 0x0023B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLoadingCompleteEvent(CharacterLoadingCompleteEvent other)
		{
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x0023D718 File Offset: 0x0023B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLoadingCompleteEvent Clone()
		{
			return null;
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x0023D728 File Offset: 0x0023B928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x0023D738 File Offset: 0x0023B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterLoadingCompleteEvent other)
		{
			return true;
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x0023D748 File Offset: 0x0023B948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x0023D758 File Offset: 0x0023B958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x0023D768 File Offset: 0x0023B968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x0023D778 File Offset: 0x0023B978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x0023D788 File Offset: 0x0023B988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x0023D798 File Offset: 0x0023B998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterLoadingCompleteEvent other)
		{
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x0023D7A8 File Offset: 0x0023B9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x0023D7B8 File Offset: 0x0023B9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x0023D7C8 File Offset: 0x0023B9C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterLoadingCompleteEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						CharacterLoadingCompleteEvent._parser = new MessageParser<CharacterLoadingCompleteEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
						{
							num2 = 1;
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
				IL_49:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
				continue;
				goto IL_49;
			}
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x0023D898 File Offset: 0x0023BA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e9wi0uJePEsZadjBo1bg()
		{
			return true;
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x0023D8A0 File Offset: 0x0023BAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterLoadingCompleteEvent eOqJrgJeSdo6M4DqZrue()
		{
			return null;
		}

		// Token: 0x04002806 RID: 10246
		private static readonly MessageParser<CharacterLoadingCompleteEvent> _parser;

		// Token: 0x04002807 RID: 10247
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002808 RID: 10248
		private static CharacterLoadingCompleteEvent KVEMnfJeiOBu0S0cfGyu;
	}
}
