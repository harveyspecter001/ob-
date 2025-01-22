using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000518 RID: 1304
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildGeneralInformationEvent : IMessage<GuildGeneralInformationEvent>, IMessage, IEquatable<GuildGeneralInformationEvent>, IDeepCloneable<GuildGeneralInformationEvent>, IBufferMessage
	{
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x001EB514 File Offset: 0x001E9714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildGeneralInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x001EB524 File Offset: 0x001E9724
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x001EB534 File Offset: 0x001E9734
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

		// Token: 0x06003E80 RID: 16000 RVA: 0x001EB544 File Offset: 0x001E9744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildGeneralInformationEvent()
		{
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001EB554 File Offset: 0x001E9754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildGeneralInformationEvent(GuildGeneralInformationEvent other)
		{
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001EB564 File Offset: 0x001E9764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildGeneralInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x001EB574 File Offset: 0x001E9774
		// (set) Token: 0x06003E84 RID: 16004 RVA: 0x001EB584 File Offset: 0x001E9784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AbandonedPaddock
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

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x001EB594 File Offset: 0x001E9794
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x001EB5A4 File Offset: 0x001E97A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x001EB5B4 File Offset: 0x001E97B4
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x001EB5C4 File Offset: 0x001E97C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ExpLevelFloor
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

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x001EB5D4 File Offset: 0x001E97D4
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x001EB5E4 File Offset: 0x001E97E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Experience
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x001EB5F4 File Offset: 0x001E97F4
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x001EB604 File Offset: 0x001E9804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpLevelNextFloor
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x001EB614 File Offset: 0x001E9814
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x001EB624 File Offset: 0x001E9824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CreationDate
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

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x001EB634 File Offset: 0x001E9834
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x001EB644 File Offset: 0x001E9844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MembersCount
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

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x001EB654 File Offset: 0x001E9854
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x001EB664 File Offset: 0x001E9864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
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

		// Token: 0x06003E93 RID: 16019 RVA: 0x001EB674 File Offset: 0x001E9874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001EB684 File Offset: 0x001E9884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildGeneralInformationEvent other)
		{
			return true;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x001EB694 File Offset: 0x001E9894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x001EB6A4 File Offset: 0x001E98A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x001EB6B4 File Offset: 0x001E98B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x001EB6C4 File Offset: 0x001E98C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001EB6D4 File Offset: 0x001E98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001EB6E4 File Offset: 0x001E98E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildGeneralInformationEvent other)
		{
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x001EB6F4 File Offset: 0x001E98F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x001EB704 File Offset: 0x001E9904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x001EB714 File Offset: 0x001E9914
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildGeneralInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildGeneralInformationEvent._parser = new MessageParser<GuildGeneralInformationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x001EB7F8 File Offset: 0x001E99F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V6l5mDOTVKkcrLooZe4q()
		{
			return true;
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x001EB800 File Offset: 0x001E9A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildGeneralInformationEvent A9CjNCOT0iQvkUOaTISa()
		{
			return null;
		}

		// Token: 0x040015A5 RID: 5541
		private static readonly MessageParser<GuildGeneralInformationEvent> _parser;

		// Token: 0x040015A6 RID: 5542
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015A7 RID: 5543
		public const int AbandonedPaddockFieldNumber = 1;

		// Token: 0x040015A8 RID: 5544
		private bool abandonedPaddock_;

		// Token: 0x040015A9 RID: 5545
		public const int LevelFieldNumber = 2;

		// Token: 0x040015AA RID: 5546
		private int level_;

		// Token: 0x040015AB RID: 5547
		public const int ExpLevelFloorFieldNumber = 3;

		// Token: 0x040015AC RID: 5548
		private long expLevelFloor_;

		// Token: 0x040015AD RID: 5549
		public const int ExperienceFieldNumber = 4;

		// Token: 0x040015AE RID: 5550
		private long experience_;

		// Token: 0x040015AF RID: 5551
		public const int ExpLevelNextFloorFieldNumber = 5;

		// Token: 0x040015B0 RID: 5552
		private long expLevelNextFloor_;

		// Token: 0x040015B1 RID: 5553
		public const int CreationDateFieldNumber = 6;

		// Token: 0x040015B2 RID: 5554
		private string creationDate_;

		// Token: 0x040015B3 RID: 5555
		public const int MembersCountFieldNumber = 7;

		// Token: 0x040015B4 RID: 5556
		private int membersCount_;

		// Token: 0x040015B5 RID: 5557
		public const int ScoreFieldNumber = 8;

		// Token: 0x040015B6 RID: 5558
		private int score_;

		// Token: 0x040015B7 RID: 5559
		private static GuildGeneralInformationEvent uGi0swOTrZ3j1yMvZk1u;
	}
}
