using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x0200019F RID: 415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestObjectiveValidationRequest : IMessage<QuestObjectiveValidationRequest>, IMessage, IEquatable<QuestObjectiveValidationRequest>, IDeepCloneable<QuestObjectiveValidationRequest>, IBufferMessage
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x001A4388 File Offset: 0x001A2588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestObjectiveValidationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x001A4398 File Offset: 0x001A2598
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x001A43A8 File Offset: 0x001A25A8
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

		// Token: 0x06001345 RID: 4933 RVA: 0x001A43B8 File Offset: 0x001A25B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidationRequest()
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x001A43C8 File Offset: 0x001A25C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidationRequest(QuestObjectiveValidationRequest other)
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x001A43D8 File Offset: 0x001A25D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidationRequest Clone()
		{
			return null;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x001A43E8 File Offset: 0x001A25E8
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x001A43F8 File Offset: 0x001A25F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x001A4408 File Offset: 0x001A2608
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x001A4418 File Offset: 0x001A2618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectiveId
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

		// Token: 0x0600134C RID: 4940 RVA: 0x001A4428 File Offset: 0x001A2628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x001A4438 File Offset: 0x001A2638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestObjectiveValidationRequest other)
		{
			return true;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x001A4448 File Offset: 0x001A2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x001A4458 File Offset: 0x001A2658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x001A4468 File Offset: 0x001A2668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x001A4478 File Offset: 0x001A2678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x001A4488 File Offset: 0x001A2688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x001A4498 File Offset: 0x001A2698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestObjectiveValidationRequest other)
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x001A44A8 File Offset: 0x001A26A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x001A44B8 File Offset: 0x001A26B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x001A44C8 File Offset: 0x001A26C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestObjectiveValidationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					QuestObjectiveValidationRequest._parser = new MessageParser<QuestObjectiveValidationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x001A45AC File Offset: 0x001A27AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DmmTyDOojRqcK4EdLnf4()
		{
			return true;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x001A45B4 File Offset: 0x001A27B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestObjectiveValidationRequest MC8amoOoK95O2bDAPMY2()
		{
			return null;
		}

		// Token: 0x040006ED RID: 1773
		private static readonly MessageParser<QuestObjectiveValidationRequest> _parser;

		// Token: 0x040006EE RID: 1774
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006EF RID: 1775
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040006F0 RID: 1776
		private int questId_;

		// Token: 0x040006F1 RID: 1777
		public const int ObjectiveIdFieldNumber = 2;

		// Token: 0x040006F2 RID: 1778
		private int objectiveId_;

		// Token: 0x040006F3 RID: 1779
		internal static QuestObjectiveValidationRequest EWtwG5Oo4DG93vQjQyHG;
	}
}
