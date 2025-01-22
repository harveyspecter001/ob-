using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008ED RID: 2285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerStatusUpdatedEvent : IMessage<PlayerStatusUpdatedEvent>, IMessage, IEquatable<PlayerStatusUpdatedEvent>, IDeepCloneable<PlayerStatusUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x00238370 File Offset: 0x00236570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerStatusUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06006F11 RID: 28433 RVA: 0x00238380 File Offset: 0x00236580
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

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x00238390 File Offset: 0x00236590
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

		// Token: 0x06006F13 RID: 28435 RVA: 0x002383A0 File Offset: 0x002365A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdatedEvent()
		{
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x002383B0 File Offset: 0x002365B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdatedEvent(PlayerStatusUpdatedEvent other)
		{
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x002383C0 File Offset: 0x002365C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x002383D0 File Offset: 0x002365D0
		// (set) Token: 0x06006F17 RID: 28439 RVA: 0x002383E0 File Offset: 0x002365E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AccountId
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

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x002383F0 File Offset: 0x002365F0
		// (set) Token: 0x06006F19 RID: 28441 RVA: 0x00238400 File Offset: 0x00236600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x00238410 File Offset: 0x00236610
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x00238420 File Offset: 0x00236620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterStatus Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00238430 File Offset: 0x00236630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00238440 File Offset: 0x00236640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerStatusUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00238450 File Offset: 0x00236650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00238460 File Offset: 0x00236660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00238470 File Offset: 0x00236670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00238480 File Offset: 0x00236680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00238490 File Offset: 0x00236690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x002384A0 File Offset: 0x002366A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerStatusUpdatedEvent other)
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x002384B0 File Offset: 0x002366B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x002384C0 File Offset: 0x002366C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x002384D0 File Offset: 0x002366D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerStatusUpdatedEvent()
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
						goto IL_98;
					case 2:
						PlayerStatusUpdatedEvent._parser = new MessageParser<PlayerStatusUpdatedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						break;
					}
				}
				IL_98:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x002385A0 File Offset: 0x002367A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oZRcABJBKYLG911pHKdI()
		{
			return true;
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x002385A8 File Offset: 0x002367A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerStatusUpdatedEvent DWSnmyJBI7npx2fPXxyF()
		{
			return null;
		}

		// Token: 0x040026E5 RID: 9957
		private static readonly MessageParser<PlayerStatusUpdatedEvent> _parser;

		// Token: 0x040026E6 RID: 9958
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E7 RID: 9959
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040026E8 RID: 9960
		private int accountId_;

		// Token: 0x040026E9 RID: 9961
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040026EA RID: 9962
		private long playerId_;

		// Token: 0x040026EB RID: 9963
		public const int StatusFieldNumber = 3;

		// Token: 0x040026EC RID: 9964
		private CharacterStatus status_;

		// Token: 0x040026ED RID: 9965
		private static PlayerStatusUpdatedEvent k3i9OuJBjBsw1PXTrkOI;
	}
}
