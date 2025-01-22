using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x0200034D RID: 845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayEmoteOnNpcEvent : IMessage<PlayEmoteOnNpcEvent>, IMessage, IEquatable<PlayEmoteOnNpcEvent>, IDeepCloneable<PlayEmoteOnNpcEvent>, IBufferMessage
	{
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x001C429C File Offset: 0x001C249C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayEmoteOnNpcEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x001C42AC File Offset: 0x001C24AC
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x001C42BC File Offset: 0x001C24BC
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

		// Token: 0x060027AE RID: 10158 RVA: 0x001C42CC File Offset: 0x001C24CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayEmoteOnNpcEvent()
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x001C42DC File Offset: 0x001C24DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayEmoteOnNpcEvent(PlayEmoteOnNpcEvent other)
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x001C42EC File Offset: 0x001C24EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayEmoteOnNpcEvent Clone()
		{
			return null;
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x001C42FC File Offset: 0x001C24FC
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x001C430C File Offset: 0x001C250C
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

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x001C431C File Offset: 0x001C251C
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x001C432C File Offset: 0x001C252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EmoteId
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

		// Token: 0x060027B5 RID: 10165 RVA: 0x001C433C File Offset: 0x001C253C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x001C434C File Offset: 0x001C254C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayEmoteOnNpcEvent other)
		{
			return true;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x001C435C File Offset: 0x001C255C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x001C436C File Offset: 0x001C256C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x001C437C File Offset: 0x001C257C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x001C438C File Offset: 0x001C258C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x001C439C File Offset: 0x001C259C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x001C43AC File Offset: 0x001C25AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayEmoteOnNpcEvent other)
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x001C43BC File Offset: 0x001C25BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x001C43CC File Offset: 0x001C25CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x001C43DC File Offset: 0x001C25DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayEmoteOnNpcEvent()
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
					default:
						return;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
						{
							num2 = 2;
						}
						break;
					case 2:
						PlayEmoteOnNpcEvent._parser = new MessageParser<PlayEmoteOnNpcEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						goto IL_36;
					}
				}
				IL_36:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x001C44C4 File Offset: 0x001C26C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gVwIp8Oh9pSbH8nseuYs()
		{
			return true;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x001C44CC File Offset: 0x001C26CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayEmoteOnNpcEvent u3pvKCOh26Rjy3EGi2D2()
		{
			return null;
		}

		// Token: 0x04000E23 RID: 3619
		private static readonly MessageParser<PlayEmoteOnNpcEvent> _parser;

		// Token: 0x04000E24 RID: 3620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E25 RID: 3621
		public const int NpcIdFieldNumber = 1;

		// Token: 0x04000E26 RID: 3622
		private int npcId_;

		// Token: 0x04000E27 RID: 3623
		public const int EmoteIdFieldNumber = 2;

		// Token: 0x04000E28 RID: 3624
		private int emoteId_;

		// Token: 0x04000E29 RID: 3625
		internal static PlayEmoteOnNpcEvent U3cyUiOhd0wJS8w6mSLg;
	}
}
