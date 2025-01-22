using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DCD RID: 3533
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementFinishedInformationEvent : IMessage<AchievementFinishedInformationEvent>, IMessage, IEquatable<AchievementFinishedInformationEvent>, IDeepCloneable<AchievementFinishedInformationEvent>, IBufferMessage
	{
		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600AA36 RID: 43574 RVA: 0x00298A4C File Offset: 0x00296C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementFinishedInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600AA37 RID: 43575 RVA: 0x00298A5C File Offset: 0x00296C5C
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

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x0600AA38 RID: 43576 RVA: 0x00298A6C File Offset: 0x00296C6C
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

		// Token: 0x0600AA39 RID: 43577 RVA: 0x00298A7C File Offset: 0x00296C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedInformationEvent()
		{
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x00298A8C File Offset: 0x00296C8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedInformationEvent(AchievementFinishedInformationEvent other)
		{
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x00298A9C File Offset: 0x00296C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x0600AA3C RID: 43580 RVA: 0x00298AAC File Offset: 0x00296CAC
		// (set) Token: 0x0600AA3D RID: 43581 RVA: 0x00298ABC File Offset: 0x00296CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AchievedAchievement Achievement
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

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600AA3E RID: 43582 RVA: 0x00298ACC File Offset: 0x00296CCC
		// (set) Token: 0x0600AA3F RID: 43583 RVA: 0x00298ADC File Offset: 0x00296CDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PlayerName
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

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x00298AEC File Offset: 0x00296CEC
		// (set) Token: 0x0600AA41 RID: 43585 RVA: 0x00298AFC File Offset: 0x00296CFC
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

		// Token: 0x0600AA42 RID: 43586 RVA: 0x00298B0C File Offset: 0x00296D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x00298B1C File Offset: 0x00296D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementFinishedInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x00298B2C File Offset: 0x00296D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x00298B3C File Offset: 0x00296D3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x00298B4C File Offset: 0x00296D4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x00298B5C File Offset: 0x00296D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x00298B6C File Offset: 0x00296D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x00298B7C File Offset: 0x00296D7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementFinishedInformationEvent other)
		{
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x00298B8C File Offset: 0x00296D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x00298B9C File Offset: 0x00296D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x00298BAC File Offset: 0x00296DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementFinishedInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AchievementFinishedInformationEvent._parser = new MessageParser<AchievementFinishedInformationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x00298C90 File Offset: 0x00296E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wDq1OnJcLt0BHX6QFDLH()
		{
			return true;
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x00298C98 File Offset: 0x00296E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementFinishedInformationEvent CThqhUJcWYpHerWPNvSG()
		{
			return null;
		}

		// Token: 0x04003E7F RID: 15999
		private static readonly MessageParser<AchievementFinishedInformationEvent> _parser;

		// Token: 0x04003E80 RID: 16000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E81 RID: 16001
		public const int AchievementFieldNumber = 1;

		// Token: 0x04003E82 RID: 16002
		private AchievedAchievement achievement_;

		// Token: 0x04003E83 RID: 16003
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x04003E84 RID: 16004
		private string playerName_;

		// Token: 0x04003E85 RID: 16005
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04003E86 RID: 16006
		private long playerId_;

		// Token: 0x04003E87 RID: 16007
		internal static AchievementFinishedInformationEvent YWXurxJc6XhDj2L0SYHx;
	}
}
