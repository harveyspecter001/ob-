using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x0200005D RID: 93
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntFinishedEvent : IMessage<TreasureHuntFinishedEvent>, IMessage, IEquatable<TreasureHuntFinishedEvent>, IDeepCloneable<TreasureHuntFinishedEvent>, IBufferMessage
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00187D88 File Offset: 0x00185F88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntFinishedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00187D98 File Offset: 0x00185F98
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00187DA8 File Offset: 0x00185FA8
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

		// Token: 0x060003AA RID: 938 RVA: 0x00187DB8 File Offset: 0x00185FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFinishedEvent()
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00187DC8 File Offset: 0x00185FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFinishedEvent(TreasureHuntFinishedEvent other)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00187DD8 File Offset: 0x00185FD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntFinishedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00187DE8 File Offset: 0x00185FE8
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00187DFC File Offset: 0x00185FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntType QuestType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00187E0C File Offset: 0x0018600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00187E1C File Offset: 0x0018601C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntFinishedEvent other)
		{
			return true;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00187E2C File Offset: 0x0018602C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00187E3C File Offset: 0x0018603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00187E4C File Offset: 0x0018604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00187E5C File Offset: 0x0018605C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00187E6C File Offset: 0x0018606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00187E7C File Offset: 0x0018607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntFinishedEvent other)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00187E8C File Offset: 0x0018608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00187E9C File Offset: 0x0018609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00187EAC File Offset: 0x001860AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntFinishedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					TreasureHuntFinishedEvent._parser = new MessageParser<TreasureHuntFinishedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00187F90 File Offset: 0x00186190
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a7NlQAOjiVxUxYPwrO6t()
		{
			return true;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00187F98 File Offset: 0x00186198
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntFinishedEvent vS98oWOjPm5TeP9OVjFy()
		{
			return null;
		}

		// Token: 0x04000172 RID: 370
		private static readonly MessageParser<TreasureHuntFinishedEvent> _parser;

		// Token: 0x04000173 RID: 371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000174 RID: 372
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x04000175 RID: 373
		private TreasureHuntType questType_;

		// Token: 0x04000176 RID: 374
		internal static TreasureHuntFinishedEvent SKvPg8Ojbtp4uFdSCArX;
	}
}
