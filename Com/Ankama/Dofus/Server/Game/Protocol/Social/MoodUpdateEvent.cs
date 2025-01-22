using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200013B RID: 315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MoodUpdateEvent : IMessage<MoodUpdateEvent>, IMessage, IEquatable<MoodUpdateEvent>, IDeepCloneable<MoodUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0019B930 File Offset: 0x00199B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoodUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0019B940 File Offset: 0x00199B40
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0019B950 File Offset: 0x00199B50
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

		// Token: 0x06000E48 RID: 3656 RVA: 0x0019B960 File Offset: 0x00199B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoodUpdateEvent()
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0019B970 File Offset: 0x00199B70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoodUpdateEvent(MoodUpdateEvent other)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0019B980 File Offset: 0x00199B80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoodUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0019B990 File Offset: 0x00199B90
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0019B9A0 File Offset: 0x00199BA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0019B9B0 File Offset: 0x00199BB0
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0019B9C0 File Offset: 0x00199BC0
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0019B9D0 File Offset: 0x00199BD0
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0019B9E0 File Offset: 0x00199BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SmileyId
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

		// Token: 0x06000E51 RID: 3665 RVA: 0x0019B9F0 File Offset: 0x00199BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0019BA00 File Offset: 0x00199C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MoodUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0019BA10 File Offset: 0x00199C10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0019BA20 File Offset: 0x00199C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0019BA30 File Offset: 0x00199C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0019BA40 File Offset: 0x00199C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0019BA50 File Offset: 0x00199C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0019BA60 File Offset: 0x00199C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MoodUpdateEvent other)
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0019BA70 File Offset: 0x00199C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0019BA80 File Offset: 0x00199C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0019BA90 File Offset: 0x00199C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MoodUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					MoodUpdateEvent._parser = new MessageParser<MoodUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0019BB74 File Offset: 0x00199D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xRetYUOUnKPuLUZgUYEI()
		{
			return true;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0019BB7C File Offset: 0x00199D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MoodUpdateEvent iv5CaROUmoRw5wPm2SA5()
		{
			return null;
		}

		// Token: 0x04000537 RID: 1335
		private static readonly MessageParser<MoodUpdateEvent> _parser;

		// Token: 0x04000538 RID: 1336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000539 RID: 1337
		public const int AccountIdFieldNumber = 1;

		// Token: 0x0400053A RID: 1338
		private long accountId_;

		// Token: 0x0400053B RID: 1339
		public const int CharacterIdFieldNumber = 2;

		// Token: 0x0400053C RID: 1340
		private long characterId_;

		// Token: 0x0400053D RID: 1341
		public const int SmileyIdFieldNumber = 3;

		// Token: 0x0400053E RID: 1342
		private int smileyId_;

		// Token: 0x0400053F RID: 1343
		internal static MoodUpdateEvent lFnGbBOUfPnauJadiIJ6;
	}
}
