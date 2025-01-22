using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000937 RID: 2359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterListEvent : IMessage<CharacterListEvent>, IMessage, IEquatable<CharacterListEvent>, IDeepCloneable<CharacterListEvent>, IBufferMessage
	{
		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x0023D4B4 File Offset: 0x0023B6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600723E RID: 29246 RVA: 0x0023D4C4 File Offset: 0x0023B6C4
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x0600723F RID: 29247 RVA: 0x0023D4D4 File Offset: 0x0023B6D4
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

		// Token: 0x06007240 RID: 29248 RVA: 0x0023D4E4 File Offset: 0x0023B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListEvent()
		{
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x0023D4F4 File Offset: 0x0023B6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListEvent(CharacterListEvent other)
		{
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x0023D504 File Offset: 0x0023B704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListEvent Clone()
		{
			return null;
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x0023D514 File Offset: 0x0023B714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Character> Characters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x0023D524 File Offset: 0x0023B724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x0023D534 File Offset: 0x0023B734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterListEvent other)
		{
			return true;
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x0023D544 File Offset: 0x0023B744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x0023D554 File Offset: 0x0023B754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x0023D564 File Offset: 0x0023B764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x0023D574 File Offset: 0x0023B774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x0023D584 File Offset: 0x0023B784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x0023D594 File Offset: 0x0023B794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterListEvent other)
		{
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x0023D5A4 File Offset: 0x0023B7A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x0023D5B4 File Offset: 0x0023B7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x0023D5C4 File Offset: 0x0023B7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						CharacterListEvent._parser = new MessageParser<CharacterListEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 5;
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					case 5:
						goto IL_86;
					}
					CharacterListEvent._repeated_characters_codec = FieldCodec.ForMessage<Character>(10U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 1;
					}
				}
				IL_86:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x0023D6B8 File Offset: 0x0023B8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iT5QltJeYXCF3eqqcgJb()
		{
			return true;
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x0023D6C0 File Offset: 0x0023B8C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterListEvent hu6lfKJebLa9N4VdO8xD()
		{
			return null;
		}

		// Token: 0x040027FE RID: 10238
		private static readonly MessageParser<CharacterListEvent> _parser;

		// Token: 0x040027FF RID: 10239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002800 RID: 10240
		public const int CharactersFieldNumber = 1;

		// Token: 0x04002801 RID: 10241
		private static readonly FieldCodec<Character> _repeated_characters_codec;

		// Token: 0x04002802 RID: 10242
		private readonly RepeatedField<Character> characters_;

		// Token: 0x04002803 RID: 10243
		internal static CharacterListEvent xDsuTLJeHy5IrsShhbub;
	}
}
