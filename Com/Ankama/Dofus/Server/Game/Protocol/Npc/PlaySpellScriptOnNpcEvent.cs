using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000349 RID: 841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlaySpellScriptOnNpcEvent : IMessage<PlaySpellScriptOnNpcEvent>, IMessage, IEquatable<PlaySpellScriptOnNpcEvent>, IDeepCloneable<PlaySpellScriptOnNpcEvent>, IBufferMessage
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x001C3E4C File Offset: 0x001C204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlaySpellScriptOnNpcEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x001C3E5C File Offset: 0x001C205C
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x001C3E6C File Offset: 0x001C206C
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

		// Token: 0x06002776 RID: 10102 RVA: 0x001C3E7C File Offset: 0x001C207C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptOnNpcEvent()
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x001C3E8C File Offset: 0x001C208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptOnNpcEvent(PlaySpellScriptOnNpcEvent other)
		{
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x001C3E9C File Offset: 0x001C209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptOnNpcEvent Clone()
		{
			return null;
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x001C3EAC File Offset: 0x001C20AC
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x001C3EBC File Offset: 0x001C20BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NpcId
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x001C3ECC File Offset: 0x001C20CC
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x001C3EDC File Offset: 0x001C20DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScriptId
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

		// Token: 0x0600277D RID: 10109 RVA: 0x001C3EEC File Offset: 0x001C20EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x001C3EFC File Offset: 0x001C20FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlaySpellScriptOnNpcEvent other)
		{
			return true;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x001C3F0C File Offset: 0x001C210C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x001C3F1C File Offset: 0x001C211C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x001C3F2C File Offset: 0x001C212C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x001C3F3C File Offset: 0x001C213C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x001C3F4C File Offset: 0x001C214C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x001C3F5C File Offset: 0x001C215C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlaySpellScriptOnNpcEvent other)
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x001C3F6C File Offset: 0x001C216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x001C3F7C File Offset: 0x001C217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x001C3F8C File Offset: 0x001C218C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlaySpellScriptOnNpcEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					PlaySpellScriptOnNpcEvent._parser = new MessageParser<PlaySpellScriptOnNpcEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x001C4058 File Offset: 0x001C2258
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cc1NKWOhOKM4DRyewN28()
		{
			return true;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x001C4060 File Offset: 0x001C2260
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlaySpellScriptOnNpcEvent YwMAurOhJMdxR0UXHgr7()
		{
			return null;
		}

		// Token: 0x04000E11 RID: 3601
		private static readonly MessageParser<PlaySpellScriptOnNpcEvent> _parser;

		// Token: 0x04000E12 RID: 3602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E13 RID: 3603
		public const int NpcIdFieldNumber = 1;

		// Token: 0x04000E14 RID: 3604
		private int npcId_;

		// Token: 0x04000E15 RID: 3605
		public const int ScriptIdFieldNumber = 2;

		// Token: 0x04000E16 RID: 3606
		private int scriptId_;

		// Token: 0x04000E17 RID: 3607
		internal static PlaySpellScriptOnNpcEvent bEiJvQOhRNV9aoFVWff2;
	}
}
