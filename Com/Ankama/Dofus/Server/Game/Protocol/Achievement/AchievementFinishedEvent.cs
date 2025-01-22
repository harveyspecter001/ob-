using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DCB RID: 3531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementFinishedEvent : IMessage<AchievementFinishedEvent>, IMessage, IEquatable<AchievementFinishedEvent>, IDeepCloneable<AchievementFinishedEvent>, IBufferMessage
	{
		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600AA1C RID: 43548 RVA: 0x00298850 File Offset: 0x00296A50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AchievementFinishedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600AA1D RID: 43549 RVA: 0x00298860 File Offset: 0x00296A60
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

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0600AA1E RID: 43550 RVA: 0x00298870 File Offset: 0x00296A70
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

		// Token: 0x0600AA1F RID: 43551 RVA: 0x00298880 File Offset: 0x00296A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedEvent()
		{
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x00298890 File Offset: 0x00296A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedEvent(AchievementFinishedEvent other)
		{
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x002988A0 File Offset: 0x00296AA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementFinishedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600AA22 RID: 43554 RVA: 0x002988B0 File Offset: 0x00296AB0
		// (set) Token: 0x0600AA23 RID: 43555 RVA: 0x002988C0 File Offset: 0x00296AC0
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

		// Token: 0x0600AA24 RID: 43556 RVA: 0x002988D0 File Offset: 0x00296AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x002988E0 File Offset: 0x00296AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementFinishedEvent other)
		{
			return true;
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x002988F0 File Offset: 0x00296AF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x00298900 File Offset: 0x00296B00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x00298910 File Offset: 0x00296B10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x00298920 File Offset: 0x00296B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x00298930 File Offset: 0x00296B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x00298940 File Offset: 0x00296B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementFinishedEvent other)
		{
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x00298950 File Offset: 0x00296B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x00298960 File Offset: 0x00296B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x00298970 File Offset: 0x00296B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementFinishedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				AchievementFinishedEvent._parser = new MessageParser<AchievementFinishedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x00298A3C File Offset: 0x00296C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FhEEUGJc5HRj1sSPHHpS()
		{
			return true;
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x00298A44 File Offset: 0x00296C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementFinishedEvent ql0sZKJcyN3UQJNWklQR()
		{
			return null;
		}

		// Token: 0x04003E78 RID: 15992
		private static readonly MessageParser<AchievementFinishedEvent> _parser;

		// Token: 0x04003E79 RID: 15993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E7A RID: 15994
		public const int AchievementFieldNumber = 1;

		// Token: 0x04003E7B RID: 15995
		private AchievedAchievement achievement_;

		// Token: 0x04003E7C RID: 15996
		internal static AchievementFinishedEvent mrFUW9Jca8nFeTKPOEVE;
	}
}
