using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200066B RID: 1643
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightNewRoundEvent : IMessage<FightNewRoundEvent>, IMessage, IEquatable<FightNewRoundEvent>, IDeepCloneable<FightNewRoundEvent>, IBufferMessage
	{
		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x002044E0 File Offset: 0x002026E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightNewRoundEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600500B RID: 20491 RVA: 0x002044F0 File Offset: 0x002026F0
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

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x00204500 File Offset: 0x00202700
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

		// Token: 0x0600500D RID: 20493 RVA: 0x00204510 File Offset: 0x00202710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewRoundEvent()
		{
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00204520 File Offset: 0x00202720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewRoundEvent(FightNewRoundEvent other)
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00204530 File Offset: 0x00202730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewRoundEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x00204540 File Offset: 0x00202740
		// (set) Token: 0x06005011 RID: 20497 RVA: 0x00204550 File Offset: 0x00202750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RoundNumber
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

		// Token: 0x06005012 RID: 20498 RVA: 0x00204560 File Offset: 0x00202760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00204570 File Offset: 0x00202770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightNewRoundEvent other)
		{
			return true;
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00204580 File Offset: 0x00202780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00204590 File Offset: 0x00202790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x002045A0 File Offset: 0x002027A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x002045B0 File Offset: 0x002027B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x002045C0 File Offset: 0x002027C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x002045D0 File Offset: 0x002027D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightNewRoundEvent other)
		{
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x002045E0 File Offset: 0x002027E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x002045F0 File Offset: 0x002027F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00204600 File Offset: 0x00202800
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightNewRoundEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					FightNewRoundEvent._parser = new MessageParser<FightNewRoundEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x002046E4 File Offset: 0x002028E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xk8h6kOiCgu7gqLAwJA2()
		{
			return true;
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x002046EC File Offset: 0x002028EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightNewRoundEvent cyJiDiOiDa5JAjwoMdXr()
		{
			return null;
		}

		// Token: 0x04001C24 RID: 7204
		private static readonly MessageParser<FightNewRoundEvent> _parser;

		// Token: 0x04001C25 RID: 7205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C26 RID: 7206
		public const int RoundNumberFieldNumber = 1;

		// Token: 0x04001C27 RID: 7207
		private int roundNumber_;

		// Token: 0x04001C28 RID: 7208
		internal static FightNewRoundEvent QE8XSdOi0JMSYkQgmP1S;
	}
}
