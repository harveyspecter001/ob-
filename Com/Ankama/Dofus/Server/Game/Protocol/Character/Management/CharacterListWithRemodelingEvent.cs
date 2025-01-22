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
	// Token: 0x02000935 RID: 2357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterListWithRemodelingEvent : IMessage<CharacterListWithRemodelingEvent>, IMessage, IEquatable<CharacterListWithRemodelingEvent>, IDeepCloneable<CharacterListWithRemodelingEvent>, IBufferMessage
	{
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06007223 RID: 29219 RVA: 0x0023D21C File Offset: 0x0023B41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterListWithRemodelingEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06007224 RID: 29220 RVA: 0x0023D22C File Offset: 0x0023B42C
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

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06007225 RID: 29221 RVA: 0x0023D23C File Offset: 0x0023B43C
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

		// Token: 0x06007226 RID: 29222 RVA: 0x0023D24C File Offset: 0x0023B44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListWithRemodelingEvent()
		{
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x0023D25C File Offset: 0x0023B45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListWithRemodelingEvent(CharacterListWithRemodelingEvent other)
		{
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0023D26C File Offset: 0x0023B46C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListWithRemodelingEvent Clone()
		{
			return null;
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x0023D27C File Offset: 0x0023B47C
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

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x0600722A RID: 29226 RVA: 0x0023D28C File Offset: 0x0023B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Character> CharactersToRemodel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x0023D29C File Offset: 0x0023B49C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x0023D2AC File Offset: 0x0023B4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterListWithRemodelingEvent other)
		{
			return true;
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x0023D2BC File Offset: 0x0023B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x0023D2CC File Offset: 0x0023B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x0023D2DC File Offset: 0x0023B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x0023D2EC File Offset: 0x0023B4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x0023D2FC File Offset: 0x0023B4FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x0023D30C File Offset: 0x0023B50C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterListWithRemodelingEvent other)
		{
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x0023D31C File Offset: 0x0023B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x0023D32C File Offset: 0x0023B52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x0023D33C File Offset: 0x0023B53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterListWithRemodelingEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					CharacterListWithRemodelingEvent._repeated_charactersToRemodel_codec = FieldCodec.ForMessage<Character>(18U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					CharacterListWithRemodelingEvent._parser = new MessageParser<CharacterListWithRemodelingEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 4;
					}
					break;
				case 6:
					CharacterListWithRemodelingEvent._repeated_characters_codec = FieldCodec.ForMessage<Character>(10U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x0023D4A4 File Offset: 0x0023B6A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XN5pmHJeTktCSnTPNyO2()
		{
			return true;
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x0023D4AC File Offset: 0x0023B6AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterListWithRemodelingEvent WWH0sEJepiBCrvdASsnk()
		{
			return null;
		}

		// Token: 0x040027F3 RID: 10227
		private static readonly MessageParser<CharacterListWithRemodelingEvent> _parser;

		// Token: 0x040027F4 RID: 10228
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F5 RID: 10229
		public const int CharactersFieldNumber = 1;

		// Token: 0x040027F6 RID: 10230
		private static readonly FieldCodec<Character> _repeated_characters_codec;

		// Token: 0x040027F7 RID: 10231
		private readonly RepeatedField<Character> characters_;

		// Token: 0x040027F8 RID: 10232
		public const int CharactersToRemodelFieldNumber = 2;

		// Token: 0x040027F9 RID: 10233
		private static readonly FieldCodec<Character> _repeated_charactersToRemodel_codec;

		// Token: 0x040027FA RID: 10234
		private readonly RepeatedField<Character> charactersToRemodel_;

		// Token: 0x040027FB RID: 10235
		private static CharacterListWithRemodelingEvent iMjhqQJe7ueyoP11pMZE;
	}
}
