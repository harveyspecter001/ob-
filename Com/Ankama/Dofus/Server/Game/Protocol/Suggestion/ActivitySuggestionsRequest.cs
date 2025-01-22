using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion
{
	// Token: 0x0200010B RID: 267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivitySuggestionsRequest : IMessage<ActivitySuggestionsRequest>, IMessage, IEquatable<ActivitySuggestionsRequest>, IDeepCloneable<ActivitySuggestionsRequest>, IBufferMessage
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00196EFC File Offset: 0x001950FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ActivitySuggestionsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00196F0C File Offset: 0x0019510C
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00196F1C File Offset: 0x0019511C
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

		// Token: 0x06000C25 RID: 3109 RVA: 0x00196F2C File Offset: 0x0019512C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsRequest()
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00196F3C File Offset: 0x0019513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsRequest(ActivitySuggestionsRequest other)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00196F4C File Offset: 0x0019514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivitySuggestionsRequest Clone()
		{
			return null;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00196F5C File Offset: 0x0019515C
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x00196F6C File Offset: 0x0019516C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinLevel
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

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00196F7C File Offset: 0x0019517C
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00196F8C File Offset: 0x0019518C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxLevel
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00196F9C File Offset: 0x0019519C
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x00196FAC File Offset: 0x001951AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AreaId
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00196FBC File Offset: 0x001951BC
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00196FCC File Offset: 0x001951CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ActivityCategoryId
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

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00196FDC File Offset: 0x001951DC
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00196FEC File Offset: 0x001951EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardsNumber
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

		// Token: 0x06000C32 RID: 3122 RVA: 0x00196FFC File Offset: 0x001951FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0019700C File Offset: 0x0019520C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ActivitySuggestionsRequest other)
		{
			return true;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0019701C File Offset: 0x0019521C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0019702C File Offset: 0x0019522C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0019703C File Offset: 0x0019523C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0019704C File Offset: 0x0019524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0019705C File Offset: 0x0019525C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0019706C File Offset: 0x0019526C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ActivitySuggestionsRequest other)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0019707C File Offset: 0x0019527C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0019708C File Offset: 0x0019528C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0019709C File Offset: 0x0019529C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ActivitySuggestionsRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					ActivitySuggestionsRequest._parser = new MessageParser<ActivitySuggestionsRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00197194 File Offset: 0x00195394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ExPv1COcfATQ7DNAxIfe()
		{
			return true;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0019719C File Offset: 0x0019539C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ActivitySuggestionsRequest rY9aVjOcniNqjn1ZcpVH()
		{
			return null;
		}

		// Token: 0x04000467 RID: 1127
		private static readonly MessageParser<ActivitySuggestionsRequest> _parser;

		// Token: 0x04000468 RID: 1128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000469 RID: 1129
		public const int MinLevelFieldNumber = 1;

		// Token: 0x0400046A RID: 1130
		private int minLevel_;

		// Token: 0x0400046B RID: 1131
		public const int MaxLevelFieldNumber = 2;

		// Token: 0x0400046C RID: 1132
		private int maxLevel_;

		// Token: 0x0400046D RID: 1133
		public const int AreaIdFieldNumber = 3;

		// Token: 0x0400046E RID: 1134
		private int areaId_;

		// Token: 0x0400046F RID: 1135
		public const int ActivityCategoryIdFieldNumber = 4;

		// Token: 0x04000470 RID: 1136
		private int activityCategoryId_;

		// Token: 0x04000471 RID: 1137
		public const int CardsNumberFieldNumber = 5;

		// Token: 0x04000472 RID: 1138
		private int cardsNumber_;

		// Token: 0x04000473 RID: 1139
		internal static ActivitySuggestionsRequest wT1HTDOlzZtU69luOdoI;
	}
}
