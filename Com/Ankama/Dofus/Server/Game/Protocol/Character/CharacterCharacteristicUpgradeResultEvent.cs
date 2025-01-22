using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008FF RID: 2303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicUpgradeResultEvent : IMessage<CharacterCharacteristicUpgradeResultEvent>, IMessage, IEquatable<CharacterCharacteristicUpgradeResultEvent>, IDeepCloneable<CharacterCharacteristicUpgradeResultEvent>, IBufferMessage
	{
		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x002394A8 File Offset: 0x002376A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCharacteristicUpgradeResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06006FF0 RID: 28656 RVA: 0x002394B8 File Offset: 0x002376B8
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

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06006FF1 RID: 28657 RVA: 0x002394C8 File Offset: 0x002376C8
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

		// Token: 0x06006FF2 RID: 28658 RVA: 0x002394D8 File Offset: 0x002376D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeResultEvent()
		{
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x002394E8 File Offset: 0x002376E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeResultEvent(CharacterCharacteristicUpgradeResultEvent other)
		{
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x002394F8 File Offset: 0x002376F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicUpgradeResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x00239508 File Offset: 0x00237708
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x0023951C File Offset: 0x0023771C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterCharacteristicUpgradeResultEvent.Types.CharacteristicUpgradeResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterCharacteristicUpgradeResultEvent.Types.CharacteristicUpgradeResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x0023952C File Offset: 0x0023772C
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x0023953C File Offset: 0x0023773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Points
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

		// Token: 0x06006FF9 RID: 28665 RVA: 0x0023954C File Offset: 0x0023774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x0023955C File Offset: 0x0023775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicUpgradeResultEvent other)
		{
			return true;
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x0023956C File Offset: 0x0023776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x0023957C File Offset: 0x0023777C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x0023958C File Offset: 0x0023778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x0023959C File Offset: 0x0023779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x002395AC File Offset: 0x002377AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x002395BC File Offset: 0x002377BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicUpgradeResultEvent other)
		{
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x002395CC File Offset: 0x002377CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x002395DC File Offset: 0x002377DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x002395EC File Offset: 0x002377EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicUpgradeResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_72;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					CharacterCharacteristicUpgradeResultEvent._parser = new MessageParser<CharacterCharacteristicUpgradeResultEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 1;
					}
				}
				IL_72:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x002396BC File Offset: 0x002378BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool stnqogJB7OE6giKZIHGU()
		{
			return true;
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x002396C4 File Offset: 0x002378C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicUpgradeResultEvent dPKfkMJBTt3TE4vObbSN()
		{
			return null;
		}

		// Token: 0x0400272F RID: 10031
		private static readonly MessageParser<CharacterCharacteristicUpgradeResultEvent> _parser;

		// Token: 0x04002730 RID: 10032
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002731 RID: 10033
		public const int ResultFieldNumber = 1;

		// Token: 0x04002732 RID: 10034
		private CharacterCharacteristicUpgradeResultEvent.Types.CharacteristicUpgradeResult result_;

		// Token: 0x04002733 RID: 10035
		public const int PointsFieldNumber = 2;

		// Token: 0x04002734 RID: 10036
		private int points_;

		// Token: 0x04002735 RID: 10037
		private static CharacterCharacteristicUpgradeResultEvent fMQyKaJBQ5nc8G3YpGn6;

		// Token: 0x02000900 RID: 2304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007006 RID: 28678 RVA: 0x002DA96C File Offset: 0x002D8B6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000901 RID: 2305
			public enum CharacteristicUpgradeResult
			{
				// Token: 0x04002737 RID: 10039
				[OriginalName("NONE")]
				None,
				// Token: 0x04002738 RID: 10040
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04002739 RID: 10041
				[OriginalName("GUEST")]
				Guest,
				// Token: 0x0400273A RID: 10042
				[OriginalName("IN_FIGHT")]
				InFight,
				// Token: 0x0400273B RID: 10043
				[OriginalName("NOT_ENOUGH_POINT")]
				NotEnoughPoint
			}
		}
	}
}
