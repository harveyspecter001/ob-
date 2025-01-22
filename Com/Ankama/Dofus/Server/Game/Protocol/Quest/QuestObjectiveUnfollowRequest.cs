using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001A7 RID: 423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestObjectiveUnfollowRequest : IMessage<QuestObjectiveUnfollowRequest>, IMessage, IEquatable<QuestObjectiveUnfollowRequest>, IDeepCloneable<QuestObjectiveUnfollowRequest>, IBufferMessage
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x001A4BC8 File Offset: 0x001A2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestObjectiveUnfollowRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x001A4BD8 File Offset: 0x001A2DD8
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x001A4BE8 File Offset: 0x001A2DE8
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

		// Token: 0x060013AD RID: 5037 RVA: 0x001A4BF8 File Offset: 0x001A2DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveUnfollowRequest()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x001A4C08 File Offset: 0x001A2E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveUnfollowRequest(QuestObjectiveUnfollowRequest other)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x001A4C18 File Offset: 0x001A2E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveUnfollowRequest Clone()
		{
			return null;
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x001A4C28 File Offset: 0x001A2E28
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x001A4C38 File Offset: 0x001A2E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x001A4C48 File Offset: 0x001A2E48
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x001A4C58 File Offset: 0x001A2E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060013B4 RID: 5044 RVA: 0x001A4C68 File Offset: 0x001A2E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x001A4C78 File Offset: 0x001A2E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestObjectiveUnfollowRequest other)
		{
			return true;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x001A4C88 File Offset: 0x001A2E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x001A4C98 File Offset: 0x001A2E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x001A4CA8 File Offset: 0x001A2EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x001A4CB8 File Offset: 0x001A2EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x001A4CC8 File Offset: 0x001A2EC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x001A4CD8 File Offset: 0x001A2ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestObjectiveUnfollowRequest other)
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x001A4CE8 File Offset: 0x001A2EE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x001A4CF8 File Offset: 0x001A2EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x001A4D08 File Offset: 0x001A2F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestObjectiveUnfollowRequest()
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
					default:
						goto IL_35;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						break;
					case 4:
						return;
					}
				}
				IL_35:
				QuestObjectiveUnfollowRequest._parser = new MessageParser<QuestObjectiveUnfollowRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x001A4DD8 File Offset: 0x001A2FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zqp1YOOoyKYti5otBTdy()
		{
			return true;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x001A4DE0 File Offset: 0x001A2FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestObjectiveUnfollowRequest NVZWi1Oo6jOy9ecZi3VY()
		{
			return null;
		}

		// Token: 0x04000709 RID: 1801
		private static readonly MessageParser<QuestObjectiveUnfollowRequest> _parser;

		// Token: 0x0400070A RID: 1802
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400070B RID: 1803
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400070C RID: 1804
		private int questId_;

		// Token: 0x0400070D RID: 1805
		public const int ObjectiveIdFieldNumber = 2;

		// Token: 0x0400070E RID: 1806
		private int objectiveId_;

		// Token: 0x0400070F RID: 1807
		internal static QuestObjectiveUnfollowRequest i3y92pOo5bKuDX3Qv0BW;
	}
}
