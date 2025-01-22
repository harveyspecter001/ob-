using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008FD RID: 2301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameOverEvent : IMessage<GameOverEvent>, IMessage, IEquatable<GameOverEvent>, IDeepCloneable<GameOverEvent>, IBufferMessage
	{
		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x002392A0 File Offset: 0x002374A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameOverEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06006FD8 RID: 28632 RVA: 0x002392B0 File Offset: 0x002374B0
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

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x002392C0 File Offset: 0x002374C0
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

		// Token: 0x06006FDA RID: 28634 RVA: 0x002392D0 File Offset: 0x002374D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameOverEvent()
		{
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x002392E0 File Offset: 0x002374E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameOverEvent(GameOverEvent other)
		{
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x002392F0 File Offset: 0x002374F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameOverEvent Clone()
		{
			return null;
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00239300 File Offset: 0x00237500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00239310 File Offset: 0x00237510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameOverEvent other)
		{
			return true;
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x00239320 File Offset: 0x00237520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00239330 File Offset: 0x00237530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00239340 File Offset: 0x00237540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00239350 File Offset: 0x00237550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00239360 File Offset: 0x00237560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00239370 File Offset: 0x00237570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameOverEvent other)
		{
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00239380 File Offset: 0x00237580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00239390 File Offset: 0x00237590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x002393A0 File Offset: 0x002375A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameOverEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GameOverEvent._parser = new MessageParser<GameOverEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00239498 File Offset: 0x00237698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U5Td4dJBtSReo1HvohSG()
		{
			return true;
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x002394A0 File Offset: 0x002376A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameOverEvent CC2ofdJBwA1hu3YWBlQI()
		{
			return null;
		}

		// Token: 0x0400272A RID: 10026
		private static readonly MessageParser<GameOverEvent> _parser;

		// Token: 0x0400272B RID: 10027
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400272C RID: 10028
		private static GameOverEvent PBrugjJBD1OOxFEtiefg;
	}
}
