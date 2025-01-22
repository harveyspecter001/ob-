using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005A1 RID: 1441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameRolePlayShowActorsEvent : IMessage<GameRolePlayShowActorsEvent>, IMessage, IEquatable<GameRolePlayShowActorsEvent>, IDeepCloneable<GameRolePlayShowActorsEvent>, IBufferMessage
	{
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x001F7DDC File Offset: 0x001F5FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameRolePlayShowActorsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x001F7DEC File Offset: 0x001F5FEC
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

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x001F7DFC File Offset: 0x001F5FFC
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

		// Token: 0x06004594 RID: 17812 RVA: 0x001F7E0C File Offset: 0x001F600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameRolePlayShowActorsEvent()
		{
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x001F7E1C File Offset: 0x001F601C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameRolePlayShowActorsEvent(GameRolePlayShowActorsEvent other)
		{
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x001F7E2C File Offset: 0x001F602C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameRolePlayShowActorsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x001F7E3C File Offset: 0x001F603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActorPositionInformation> Actors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x001F7E4C File Offset: 0x001F604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x001F7E5C File Offset: 0x001F605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameRolePlayShowActorsEvent other)
		{
			return true;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x001F7E6C File Offset: 0x001F606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x001F7E7C File Offset: 0x001F607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x001F7E8C File Offset: 0x001F608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x001F7E9C File Offset: 0x001F609C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x001F7EAC File Offset: 0x001F60AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x001F7EBC File Offset: 0x001F60BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameRolePlayShowActorsEvent other)
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x001F7ECC File Offset: 0x001F60CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x001F7EDC File Offset: 0x001F60DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x001F7EEC File Offset: 0x001F60EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameRolePlayShowActorsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					GameRolePlayShowActorsEvent._repeated_actors_codec = FieldCodec.ForMessage<ActorPositionInformation>(10U, qqeH7gmD07JZLA3m1WUC.XVInXhlssT(qqeH7gmD07JZLA3m1WUC.Nt8mDCI6NhO));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
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
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				GameRolePlayShowActorsEvent._parser = new MessageParser<GameRolePlayShowActorsEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x001F7FDC File Offset: 0x001F61DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bVCeJ9OYSOFRcpHIjMei()
		{
			return true;
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x001F7FE4 File Offset: 0x001F61E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameRolePlayShowActorsEvent OhBnqrOYMZWsFl7ltqPn()
		{
			return null;
		}

		// Token: 0x0400180A RID: 6154
		private static readonly MessageParser<GameRolePlayShowActorsEvent> _parser;

		// Token: 0x0400180B RID: 6155
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400180C RID: 6156
		public const int ActorsFieldNumber = 1;

		// Token: 0x0400180D RID: 6157
		private static readonly FieldCodec<ActorPositionInformation> _repeated_actors_codec;

		// Token: 0x0400180E RID: 6158
		private readonly RepeatedField<ActorPositionInformation> actors_;

		// Token: 0x0400180F RID: 6159
		private static GameRolePlayShowActorsEvent WhidF2OYP8nqclL4YOnU;
	}
}
