using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000943 RID: 2371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterForceSelectionEvent : IMessage<CharacterForceSelectionEvent>, IMessage, IEquatable<CharacterForceSelectionEvent>, IDeepCloneable<CharacterForceSelectionEvent>, IBufferMessage
	{
		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x0023DF58 File Offset: 0x0023C158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterForceSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060072C4 RID: 29380 RVA: 0x0023DF68 File Offset: 0x0023C168
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x0023DF78 File Offset: 0x0023C178
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

		// Token: 0x060072C6 RID: 29382 RVA: 0x0023DF88 File Offset: 0x0023C188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionEvent()
		{
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x0023DF98 File Offset: 0x0023C198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionEvent(CharacterForceSelectionEvent other)
		{
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x0023DFA8 File Offset: 0x0023C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x0023DFB8 File Offset: 0x0023C1B8
		// (set) Token: 0x060072CA RID: 29386 RVA: 0x0023DFC8 File Offset: 0x0023C1C8
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

		// Token: 0x060072CB RID: 29387 RVA: 0x0023DFD8 File Offset: 0x0023C1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x0023DFE8 File Offset: 0x0023C1E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterForceSelectionEvent other)
		{
			return true;
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x0023DFF8 File Offset: 0x0023C1F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x0023E008 File Offset: 0x0023C208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x0023E018 File Offset: 0x0023C218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x0023E028 File Offset: 0x0023C228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x0023E038 File Offset: 0x0023C238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x0023E048 File Offset: 0x0023C248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterForceSelectionEvent other)
		{
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x0023E058 File Offset: 0x0023C258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x0023E068 File Offset: 0x0023C268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x0023E078 File Offset: 0x0023C278
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterForceSelectionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterForceSelectionEvent._parser = new MessageParser<CharacterForceSelectionEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x0023E15C File Offset: 0x0023C35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k4Z7MvJ3AUQTpq4fjKTh()
		{
			return true;
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x0023E164 File Offset: 0x0023C364
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterForceSelectionEvent B0KTkcJ3BPgPGpslvfEg()
		{
			return null;
		}

		// Token: 0x04002829 RID: 10281
		private static readonly MessageParser<CharacterForceSelectionEvent> _parser;

		// Token: 0x0400282A RID: 10282
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400282B RID: 10283
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400282C RID: 10284
		private long characterId_;

		// Token: 0x0400282D RID: 10285
		internal static CharacterForceSelectionEvent dOrN0mJ3mvpoB48d4yT2;
	}
}
