using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006B9 RID: 1721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightHumanReadyStateEvent : IMessage<FightHumanReadyStateEvent>, IMessage, IEquatable<FightHumanReadyStateEvent>, IDeepCloneable<FightHumanReadyStateEvent>, IBufferMessage
	{
		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06005421 RID: 21537 RVA: 0x0020A984 File Offset: 0x00208B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightHumanReadyStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x0020A994 File Offset: 0x00208B94
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

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06005423 RID: 21539 RVA: 0x0020A9A4 File Offset: 0x00208BA4
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

		// Token: 0x06005424 RID: 21540 RVA: 0x0020A9B4 File Offset: 0x00208BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightHumanReadyStateEvent()
		{
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0020A9C4 File Offset: 0x00208BC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightHumanReadyStateEvent(FightHumanReadyStateEvent other)
		{
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0020A9D4 File Offset: 0x00208BD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightHumanReadyStateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x0020A9E4 File Offset: 0x00208BE4
		// (set) Token: 0x06005428 RID: 21544 RVA: 0x0020A9F4 File Offset: 0x00208BF4
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

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x0020AA04 File Offset: 0x00208C04
		// (set) Token: 0x0600542A RID: 21546 RVA: 0x0020AA14 File Offset: 0x00208C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0020AA24 File Offset: 0x00208C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x0020AA34 File Offset: 0x00208C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightHumanReadyStateEvent other)
		{
			return true;
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0020AA44 File Offset: 0x00208C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0020AA54 File Offset: 0x00208C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0020AA64 File Offset: 0x00208C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0020AA74 File Offset: 0x00208C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x0020AA84 File Offset: 0x00208C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0020AA94 File Offset: 0x00208C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightHumanReadyStateEvent other)
		{
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x0020AAA4 File Offset: 0x00208CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0020AAB4 File Offset: 0x00208CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x0020AAC4 File Offset: 0x00208CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightHumanReadyStateEvent()
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
						num2 = 4;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				IL_9C:
				FightHumanReadyStateEvent._parser = new MessageParser<FightHumanReadyStateEvent>(() => null);
				num = 3;
				continue;
				goto IL_9C;
			}
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x0020AB94 File Offset: 0x00208D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aPJ81bOSv0LLbeh8kUIw()
		{
			return true;
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0020AB9C File Offset: 0x00208D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightHumanReadyStateEvent dOYl1qOSoyI0LUw84po0()
		{
			return null;
		}

		// Token: 0x04001DA7 RID: 7591
		private static readonly MessageParser<FightHumanReadyStateEvent> _parser;

		// Token: 0x04001DA8 RID: 7592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DA9 RID: 7593
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04001DAA RID: 7594
		private long characterId_;

		// Token: 0x04001DAB RID: 7595
		public const int IsReadyFieldNumber = 2;

		// Token: 0x04001DAC RID: 7596
		private bool isReady_;

		// Token: 0x04001DAD RID: 7597
		private static FightHumanReadyStateEvent kmG8bTOSUyK6oKsns1qV;
	}
}
