using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001BA RID: 442
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStepInformationEvent : IMessage<QuestStepInformationEvent>, IMessage, IEquatable<QuestStepInformationEvent>, IDeepCloneable<QuestStepInformationEvent>, IBufferMessage
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x001A5D74 File Offset: 0x001A3F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestStepInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x001A5D84 File Offset: 0x001A3F84
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x001A5D94 File Offset: 0x001A3F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x001A5DA4 File Offset: 0x001A3FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationEvent()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x001A5DB4 File Offset: 0x001A3FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationEvent(QuestStepInformationEvent other)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x001A5DC4 File Offset: 0x001A3FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x001A5DD4 File Offset: 0x001A3FD4
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x001A5DE4 File Offset: 0x001A3FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActive Information
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x001A5DF4 File Offset: 0x001A3FF4
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x001A5E04 File Offset: 0x001A4004
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x001A5E14 File Offset: 0x001A4014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasPlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x001A5E24 File Offset: 0x001A4024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPlayerId()
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x001A5E34 File Offset: 0x001A4034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x001A5E44 File Offset: 0x001A4044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStepInformationEvent other)
		{
			return true;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x001A5E54 File Offset: 0x001A4054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x001A5E64 File Offset: 0x001A4064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x001A5E74 File Offset: 0x001A4074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x001A5E84 File Offset: 0x001A4084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x001A5E94 File Offset: 0x001A4094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x001A5EA4 File Offset: 0x001A40A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStepInformationEvent other)
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x001A5EB4 File Offset: 0x001A40B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x001A5EC4 File Offset: 0x001A40C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x001A5ED4 File Offset: 0x001A40D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStepInformationEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					QuestStepInformationEvent._parser = new MessageParser<QuestStepInformationEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					QuestStepInformationEvent.PlayerIdDefaultValue = 0L;
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x001A5FCC File Offset: 0x001A41CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QZtLHkOo8LP4QFq59l2W()
		{
			return true;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x001A5FD4 File Offset: 0x001A41D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStepInformationEvent FVelAEOoZZxg8lnx0OVI()
		{
			return null;
		}

		// Token: 0x0400075E RID: 1886
		private static readonly MessageParser<QuestStepInformationEvent> _parser;

		// Token: 0x0400075F RID: 1887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000760 RID: 1888
		private int _hasBits0;

		// Token: 0x04000761 RID: 1889
		public const int InformationFieldNumber = 1;

		// Token: 0x04000762 RID: 1890
		private QuestActive information_;

		// Token: 0x04000763 RID: 1891
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000764 RID: 1892
		private static readonly long PlayerIdDefaultValue;

		// Token: 0x04000765 RID: 1893
		private long playerId_;

		// Token: 0x04000766 RID: 1894
		private static QuestStepInformationEvent FB0cMUOou2iDYh4OW6cJ;
	}
}
