using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200066F RID: 1647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnEvent : IMessage<FightTurnEvent>, IMessage, IEquatable<FightTurnEvent>, IDeepCloneable<FightTurnEvent>, IBufferMessage
	{
		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x00204944 File Offset: 0x00202B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTurnEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600503F RID: 20543 RVA: 0x00204954 File Offset: 0x00202B54
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

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x00204964 File Offset: 0x00202B64
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

		// Token: 0x06005041 RID: 20545 RVA: 0x00204974 File Offset: 0x00202B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEvent()
		{
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00204984 File Offset: 0x00202B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEvent(FightTurnEvent other)
		{
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00204994 File Offset: 0x00202B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x002049A4 File Offset: 0x00202BA4
		// (set) Token: 0x06005045 RID: 20549 RVA: 0x002049B4 File Offset: 0x00202BB4
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x002049C4 File Offset: 0x00202BC4
		// (set) Token: 0x06005047 RID: 20551 RVA: 0x002049D4 File Offset: 0x00202BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BaseTime
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

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06005048 RID: 20552 RVA: 0x002049E4 File Offset: 0x00202BE4
		// (set) Token: 0x06005049 RID: 20553 RVA: 0x002049F4 File Offset: 0x00202BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ExtraTime
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

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x00204A04 File Offset: 0x00202C04
		// (set) Token: 0x0600504B RID: 20555 RVA: 0x00204A14 File Offset: 0x00202C14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RemainingTime
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

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x00204A24 File Offset: 0x00202C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasRemainingTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00204A34 File Offset: 0x00202C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearRemainingTime()
		{
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00204A44 File Offset: 0x00202C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00204A54 File Offset: 0x00202C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnEvent other)
		{
			return true;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00204A64 File Offset: 0x00202C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00204A74 File Offset: 0x00202C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00204A84 File Offset: 0x00202C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00204A94 File Offset: 0x00202C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00204AA4 File Offset: 0x00202CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00204AB4 File Offset: 0x00202CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnEvent other)
		{
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00204AC4 File Offset: 0x00202CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00204AD4 File Offset: 0x00202CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x00204AE4 File Offset: 0x00202CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnEvent()
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
						FightTurnEvent._parser = new MessageParser<FightTurnEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					case 5:
						goto IL_4D;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 1;
					}
				}
				IL_4D:
				FightTurnEvent.RemainingTimeDefaultValue = 0;
				num = 2;
			}
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00204BE0 File Offset: 0x00202DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DlV1D5OiTp926svBfAFk()
		{
			return true;
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00204BE8 File Offset: 0x00202DE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnEvent Hgx6KJOipf9ClcPuRGTe()
		{
			return null;
		}

		// Token: 0x04001C36 RID: 7222
		private static readonly MessageParser<FightTurnEvent> _parser;

		// Token: 0x04001C37 RID: 7223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C38 RID: 7224
		private int _hasBits0;

		// Token: 0x04001C39 RID: 7225
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04001C3A RID: 7226
		private long characterId_;

		// Token: 0x04001C3B RID: 7227
		public const int BaseTimeFieldNumber = 2;

		// Token: 0x04001C3C RID: 7228
		private int baseTime_;

		// Token: 0x04001C3D RID: 7229
		public const int ExtraTimeFieldNumber = 3;

		// Token: 0x04001C3E RID: 7230
		private int extraTime_;

		// Token: 0x04001C3F RID: 7231
		public const int RemainingTimeFieldNumber = 4;

		// Token: 0x04001C40 RID: 7232
		private static readonly int RemainingTimeDefaultValue;

		// Token: 0x04001C41 RID: 7233
		private int remainingTime_;

		// Token: 0x04001C42 RID: 7234
		internal static FightTurnEvent mRYBE0Oi78yaGmCuXMaD;
	}
}
