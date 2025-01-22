using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002A6 RID: 678
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowActivatedEvent : IMessage<AutoFollowActivatedEvent>, IMessage, IEquatable<AutoFollowActivatedEvent>, IDeepCloneable<AutoFollowActivatedEvent>, IBufferMessage
	{
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x001B8FB8 File Offset: 0x001B71B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AutoFollowActivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x001B8FC8 File Offset: 0x001B71C8
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x001B8FD8 File Offset: 0x001B71D8
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

		// Token: 0x06001FA6 RID: 8102 RVA: 0x001B8FE8 File Offset: 0x001B71E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivatedEvent()
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x001B8FF8 File Offset: 0x001B71F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivatedEvent(AutoFollowActivatedEvent other)
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x001B9008 File Offset: 0x001B7208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x001B9018 File Offset: 0x001B7218
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x001B9028 File Offset: 0x001B7228
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

		// Token: 0x06001FAB RID: 8107 RVA: 0x001B9038 File Offset: 0x001B7238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x001B9048 File Offset: 0x001B7248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowActivatedEvent other)
		{
			return true;
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x001B9058 File Offset: 0x001B7258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x001B9068 File Offset: 0x001B7268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x001B9078 File Offset: 0x001B7278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x001B9088 File Offset: 0x001B7288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x001B9098 File Offset: 0x001B7298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x001B90A8 File Offset: 0x001B72A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowActivatedEvent other)
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x001B90B8 File Offset: 0x001B72B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x001B90C8 File Offset: 0x001B72C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x001B90D8 File Offset: 0x001B72D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowActivatedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AutoFollowActivatedEvent._parser = new MessageParser<AutoFollowActivatedEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x001B91D0 File Offset: 0x001B73D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a8HJR9OyZACRqnSBE4es()
		{
			return true;
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x001B91D8 File Offset: 0x001B73D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowActivatedEvent XFooFHOyq8Tnamm7E4mI()
		{
			return null;
		}

		// Token: 0x04000B26 RID: 2854
		private static readonly MessageParser<AutoFollowActivatedEvent> _parser;

		// Token: 0x04000B27 RID: 2855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B28 RID: 2856
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B29 RID: 2857
		private long playerId_;

		// Token: 0x04000B2A RID: 2858
		internal static AutoFollowActivatedEvent bBaIBnOy8uE3C6leKdIh;
	}
}
