using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001A5 RID: 421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestObjectiveFollowRequest : IMessage<QuestObjectiveFollowRequest>, IMessage, IEquatable<QuestObjectiveFollowRequest>, IDeepCloneable<QuestObjectiveFollowRequest>, IBufferMessage
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x001A49A8 File Offset: 0x001A2BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestObjectiveFollowRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x001A49B8 File Offset: 0x001A2BB8
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x001A49C8 File Offset: 0x001A2BC8
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

		// Token: 0x06001391 RID: 5009 RVA: 0x001A49D8 File Offset: 0x001A2BD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveFollowRequest()
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x001A49E8 File Offset: 0x001A2BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveFollowRequest(QuestObjectiveFollowRequest other)
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x001A49F8 File Offset: 0x001A2BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveFollowRequest Clone()
		{
			return null;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x001A4A08 File Offset: 0x001A2C08
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x001A4A18 File Offset: 0x001A2C18
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x001A4A28 File Offset: 0x001A2C28
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x001A4A38 File Offset: 0x001A2C38
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

		// Token: 0x06001398 RID: 5016 RVA: 0x001A4A48 File Offset: 0x001A2C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x001A4A58 File Offset: 0x001A2C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestObjectiveFollowRequest other)
		{
			return true;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x001A4A68 File Offset: 0x001A2C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x001A4A78 File Offset: 0x001A2C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x001A4A88 File Offset: 0x001A2C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x001A4A98 File Offset: 0x001A2C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x001A4AA8 File Offset: 0x001A2CA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x001A4AB8 File Offset: 0x001A2CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestObjectiveFollowRequest other)
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x001A4AC8 File Offset: 0x001A2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x001A4AD8 File Offset: 0x001A2CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x001A4AE8 File Offset: 0x001A2CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestObjectiveFollowRequest()
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
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
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
					break;
				}
				IL_5E:
				QuestObjectiveFollowRequest._parser = new MessageParser<QuestObjectiveFollowRequest>(() => null);
				num = 2;
				continue;
				goto IL_5E;
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x001A4BB8 File Offset: 0x001A2DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DXuDECOo19OOyt0KC527()
		{
			return true;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x001A4BC0 File Offset: 0x001A2DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestObjectiveFollowRequest P3VUehOoaBVctSDbijT8()
		{
			return null;
		}

		// Token: 0x04000700 RID: 1792
		private static readonly MessageParser<QuestObjectiveFollowRequest> _parser;

		// Token: 0x04000701 RID: 1793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000702 RID: 1794
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000703 RID: 1795
		private int questId_;

		// Token: 0x04000704 RID: 1796
		public const int ObjectiveIdFieldNumber = 2;

		// Token: 0x04000705 RID: 1797
		private int objectiveId_;

		// Token: 0x04000706 RID: 1798
		internal static QuestObjectiveFollowRequest sqVd8AOoo8vb2OpXIIdu;
	}
}
