using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006BB RID: 1723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightLeaveEvent : IMessage<FightLeaveEvent>, IMessage, IEquatable<FightLeaveEvent>, IDeepCloneable<FightLeaveEvent>, IBufferMessage
	{
		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x0020ABA4 File Offset: 0x00208DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightLeaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x0020ABB4 File Offset: 0x00208DB4
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

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x0020ABC4 File Offset: 0x00208DC4
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

		// Token: 0x06005440 RID: 21568 RVA: 0x0020ABD4 File Offset: 0x00208DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightLeaveEvent()
		{
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0020ABE4 File Offset: 0x00208DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightLeaveEvent(FightLeaveEvent other)
		{
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0020ABF4 File Offset: 0x00208DF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightLeaveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x0020AC04 File Offset: 0x00208E04
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x0020AC14 File Offset: 0x00208E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06005445 RID: 21573 RVA: 0x0020AC24 File Offset: 0x00208E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x0020AC34 File Offset: 0x00208E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightLeaveEvent other)
		{
			return true;
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x0020AC44 File Offset: 0x00208E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x0020AC54 File Offset: 0x00208E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x0020AC64 File Offset: 0x00208E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x0020AC74 File Offset: 0x00208E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x0020AC84 File Offset: 0x00208E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0020AC94 File Offset: 0x00208E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightLeaveEvent other)
		{
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0020ACA4 File Offset: 0x00208EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0020ACB4 File Offset: 0x00208EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x0020ACC4 File Offset: 0x00208EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightLeaveEvent()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						goto IL_36;
					}
					goto Block_1;
				}
				IL_36:
				FightLeaveEvent._parser = new MessageParser<FightLeaveEvent>(() => null);
				num = 3;
				continue;
				IL_B0:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				Block_1:
				goto IL_B0;
			}
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0020AD98 File Offset: 0x00208F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nOOy5cOSaFxS0TX86MxD()
		{
			return true;
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0020ADA0 File Offset: 0x00208FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightLeaveEvent xW2uWfOS5ui9KnMZQAAI()
		{
			return null;
		}

		// Token: 0x04001DB0 RID: 7600
		private static readonly MessageParser<FightLeaveEvent> _parser;

		// Token: 0x04001DB1 RID: 7601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DB2 RID: 7602
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04001DB3 RID: 7603
		private long characterId_;

		// Token: 0x04001DB4 RID: 7604
		private static FightLeaveEvent CJmePsOS1gxeCNDMNsj6;
	}
}
