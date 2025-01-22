using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DD1 RID: 3537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsPioneerRanksRequest : IMessage<AchievementsPioneerRanksRequest>, IMessage, IEquatable<AchievementsPioneerRanksRequest>, IDeepCloneable<AchievementsPioneerRanksRequest>, IBufferMessage
	{
		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600AA70 RID: 43632 RVA: 0x00298EBC File Offset: 0x002970BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsPioneerRanksRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x00298ECC File Offset: 0x002970CC
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

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x00298EDC File Offset: 0x002970DC
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

		// Token: 0x0600AA73 RID: 43635 RVA: 0x00298EEC File Offset: 0x002970EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksRequest()
		{
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x00298EFC File Offset: 0x002970FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksRequest(AchievementsPioneerRanksRequest other)
		{
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x00298F0C File Offset: 0x0029710C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsPioneerRanksRequest Clone()
		{
			return null;
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x00298F1C File Offset: 0x0029711C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x00298F2C File Offset: 0x0029712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsPioneerRanksRequest other)
		{
			return true;
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x00298F3C File Offset: 0x0029713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x00298F4C File Offset: 0x0029714C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x00298F5C File Offset: 0x0029715C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x00298F6C File Offset: 0x0029716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x00298F7C File Offset: 0x0029717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x00298F8C File Offset: 0x0029718C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsPioneerRanksRequest other)
		{
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x00298F9C File Offset: 0x0029719C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x00298FAC File Offset: 0x002971AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x00298FBC File Offset: 0x002971BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsPioneerRanksRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AchievementsPioneerRanksRequest._parser = new MessageParser<AchievementsPioneerRanksRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x002990A0 File Offset: 0x002972A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VXe7myJcC1ZqeQdyaDmT()
		{
			return true;
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x002990A8 File Offset: 0x002972A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsPioneerRanksRequest YyVIgFJcDaedpQbjmcag()
		{
			return null;
		}

		// Token: 0x04003E93 RID: 16019
		private static readonly MessageParser<AchievementsPioneerRanksRequest> _parser;

		// Token: 0x04003E94 RID: 16020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E95 RID: 16021
		internal static AchievementsPioneerRanksRequest zj7BEDJc0oOgON5ANgPn;
	}
}
