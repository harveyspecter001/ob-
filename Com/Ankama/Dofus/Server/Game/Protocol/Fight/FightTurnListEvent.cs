using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200066D RID: 1645
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnListEvent : IMessage<FightTurnListEvent>, IMessage, IEquatable<FightTurnListEvent>, IDeepCloneable<FightTurnListEvent>, IBufferMessage
	{
		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x002046F4 File Offset: 0x002028F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTurnListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x00204704 File Offset: 0x00202904
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x00204714 File Offset: 0x00202914
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

		// Token: 0x06005027 RID: 20519 RVA: 0x00204724 File Offset: 0x00202924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnListEvent()
		{
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00204734 File Offset: 0x00202934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnListEvent(FightTurnListEvent other)
		{
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00204744 File Offset: 0x00202944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnListEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x00204754 File Offset: 0x00202954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> Ids
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600502B RID: 20523 RVA: 0x00204764 File Offset: 0x00202964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Slain
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x00204774 File Offset: 0x00202974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00204784 File Offset: 0x00202984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnListEvent other)
		{
			return true;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00204794 File Offset: 0x00202994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x002047A4 File Offset: 0x002029A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x002047B4 File Offset: 0x002029B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x002047C4 File Offset: 0x002029C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x002047D4 File Offset: 0x002029D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x002047E4 File Offset: 0x002029E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnListEvent other)
		{
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x002047F4 File Offset: 0x002029F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00204804 File Offset: 0x00202A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00204814 File Offset: 0x00202A14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightTurnListEvent._parser = new MessageParser<FightTurnListEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					FightTurnListEvent._repeated_ids_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				FightTurnListEvent._repeated_slain_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(18U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num2 = 3;
			}
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00204934 File Offset: 0x00202B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tAuVpTOiwYuG0l3anXXc()
		{
			return true;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x0020493C File Offset: 0x00202B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnListEvent w96VcQOiQTtc8da9Lady()
		{
			return null;
		}

		// Token: 0x04001C2B RID: 7211
		private static readonly MessageParser<FightTurnListEvent> _parser;

		// Token: 0x04001C2C RID: 7212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C2D RID: 7213
		public const int IdsFieldNumber = 1;

		// Token: 0x04001C2E RID: 7214
		private static readonly FieldCodec<long> _repeated_ids_codec;

		// Token: 0x04001C2F RID: 7215
		private readonly RepeatedField<long> ids_;

		// Token: 0x04001C30 RID: 7216
		public const int SlainFieldNumber = 2;

		// Token: 0x04001C31 RID: 7217
		private static readonly FieldCodec<long> _repeated_slain_codec;

		// Token: 0x04001C32 RID: 7218
		private readonly RepeatedField<long> slain_;

		// Token: 0x04001C33 RID: 7219
		internal static FightTurnListEvent H15WiDOitMTBSCeb2Mtu;
	}
}
