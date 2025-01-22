using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000184 RID: 388
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AggressionEvent : IMessage<AggressionEvent>, IMessage, IEquatable<AggressionEvent>, IDeepCloneable<AggressionEvent>, IBufferMessage
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x001A1540 File Offset: 0x0019F740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AggressionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x001A1550 File Offset: 0x0019F750
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x001A1560 File Offset: 0x0019F760
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

		// Token: 0x060011CB RID: 4555 RVA: 0x001A1570 File Offset: 0x0019F770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AggressionEvent()
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x001A1580 File Offset: 0x0019F780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AggressionEvent(AggressionEvent other)
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x001A1590 File Offset: 0x0019F790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AggressionEvent Clone()
		{
			return null;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x001A15A0 File Offset: 0x0019F7A0
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x001A15B0 File Offset: 0x0019F7B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AttackerId
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x001A15C0 File Offset: 0x0019F7C0
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x001A15D0 File Offset: 0x0019F7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long DefenderId
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

		// Token: 0x060011D2 RID: 4562 RVA: 0x001A15E0 File Offset: 0x0019F7E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x001A15F0 File Offset: 0x0019F7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AggressionEvent other)
		{
			return true;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x001A1600 File Offset: 0x0019F800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x001A1610 File Offset: 0x0019F810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x001A1620 File Offset: 0x0019F820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x001A1630 File Offset: 0x0019F830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x001A1640 File Offset: 0x0019F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x001A1650 File Offset: 0x0019F850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AggressionEvent other)
		{
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x001A1660 File Offset: 0x0019F860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x001A1670 File Offset: 0x0019F870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x001A1680 File Offset: 0x0019F880
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AggressionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_35;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					AggressionEvent._parser = new MessageParser<AggressionEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 3;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x001A1768 File Offset: 0x0019F968
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b6o5EIOvCsQAE2WIDsbe()
		{
			return true;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x001A1770 File Offset: 0x0019F970
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AggressionEvent aDEV44OvDj5PJqDwrdv8()
		{
			return null;
		}

		// Token: 0x0400066C RID: 1644
		private static readonly MessageParser<AggressionEvent> _parser;

		// Token: 0x0400066D RID: 1645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400066E RID: 1646
		public const int AttackerIdFieldNumber = 1;

		// Token: 0x0400066F RID: 1647
		private long attackerId_;

		// Token: 0x04000670 RID: 1648
		public const int DefenderIdFieldNumber = 2;

		// Token: 0x04000671 RID: 1649
		private long defenderId_;

		// Token: 0x04000672 RID: 1650
		internal static AggressionEvent SnT90hOv09rNKQuc4500;
	}
}
