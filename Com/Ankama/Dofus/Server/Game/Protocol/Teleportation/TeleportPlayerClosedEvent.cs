using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200009B RID: 155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportPlayerClosedEvent : IMessage<TeleportPlayerClosedEvent>, IMessage, IEquatable<TeleportPlayerClosedEvent>, IDeepCloneable<TeleportPlayerClosedEvent>, IBufferMessage
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0018D048 File Offset: 0x0018B248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportPlayerClosedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0018D058 File Offset: 0x0018B258
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0018D068 File Offset: 0x0018B268
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

		// Token: 0x0600068F RID: 1679 RVA: 0x0018D078 File Offset: 0x0018B278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerClosedEvent()
		{
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0018D088 File Offset: 0x0018B288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerClosedEvent(TeleportPlayerClosedEvent other)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0018D098 File Offset: 0x0018B298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerClosedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0018D0A8 File Offset: 0x0018B2A8
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0018D0B8 File Offset: 0x0018B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0018D0C8 File Offset: 0x0018B2C8
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0018D0D8 File Offset: 0x0018B2D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long RequesterId
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

		// Token: 0x06000696 RID: 1686 RVA: 0x0018D0E8 File Offset: 0x0018B2E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0018D0F8 File Offset: 0x0018B2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportPlayerClosedEvent other)
		{
			return true;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0018D108 File Offset: 0x0018B308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0018D118 File Offset: 0x0018B318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0018D128 File Offset: 0x0018B328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0018D138 File Offset: 0x0018B338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0018D148 File Offset: 0x0018B348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0018D158 File Offset: 0x0018B358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportPlayerClosedEvent other)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0018D168 File Offset: 0x0018B368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0018D178 File Offset: 0x0018B378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0018D188 File Offset: 0x0018B388
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportPlayerClosedEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				IL_5E:
				TeleportPlayerClosedEvent._parser = new MessageParser<TeleportPlayerClosedEvent>(() => null);
				num = 2;
				continue;
				goto IL_5E;
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0018D270 File Offset: 0x0018B470
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SLgatUOIjhHfxWbHbIt2()
		{
			return true;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0018D278 File Offset: 0x0018B478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportPlayerClosedEvent fELKvWOIKfkZAVQT1E8G()
		{
			return null;
		}

		// Token: 0x04000274 RID: 628
		private static readonly MessageParser<TeleportPlayerClosedEvent> _parser;

		// Token: 0x04000275 RID: 629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000276 RID: 630
		public const int MapIdFieldNumber = 1;

		// Token: 0x04000277 RID: 631
		private long mapId_;

		// Token: 0x04000278 RID: 632
		public const int RequesterIdFieldNumber = 2;

		// Token: 0x04000279 RID: 633
		private long requesterId_;

		// Token: 0x0400027A RID: 634
		private static TeleportPlayerClosedEvent BHa6w7OI4LNMkOtFSpXl;
	}
}
