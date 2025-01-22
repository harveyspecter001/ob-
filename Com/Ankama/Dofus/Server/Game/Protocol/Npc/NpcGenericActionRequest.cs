using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000329 RID: 809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcGenericActionRequest : IMessage<NpcGenericActionRequest>, IMessage, IEquatable<NpcGenericActionRequest>, IDeepCloneable<NpcGenericActionRequest>, IBufferMessage
	{
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x001C295C File Offset: 0x001C0B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NpcGenericActionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x001C296C File Offset: 0x001C0B6C
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

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x001C297C File Offset: 0x001C0B7C
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

		// Token: 0x060025FF RID: 9727 RVA: 0x001C298C File Offset: 0x001C0B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionRequest()
		{
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x001C299C File Offset: 0x001C0B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionRequest(NpcGenericActionRequest other)
		{
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x001C29AC File Offset: 0x001C0BAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionRequest Clone()
		{
			return null;
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x001C29BC File Offset: 0x001C0BBC
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x001C29CC File Offset: 0x001C0BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcId
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x001C29DC File Offset: 0x001C0BDC
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x001C29EC File Offset: 0x001C0BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcActionId
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x001C29FC File Offset: 0x001C0BFC
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x001C2A0C File Offset: 0x001C0C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long NpcMapId
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

		// Token: 0x06002608 RID: 9736 RVA: 0x001C2A1C File Offset: 0x001C0C1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x001C2A2C File Offset: 0x001C0C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcGenericActionRequest other)
		{
			return true;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x001C2A3C File Offset: 0x001C0C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x001C2A4C File Offset: 0x001C0C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x001C2A5C File Offset: 0x001C0C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x001C2A6C File Offset: 0x001C0C6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x001C2A7C File Offset: 0x001C0C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x001C2A8C File Offset: 0x001C0C8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcGenericActionRequest other)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x001C2A9C File Offset: 0x001C0C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x001C2AAC File Offset: 0x001C0CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x001C2ABC File Offset: 0x001C0CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcGenericActionRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					NpcGenericActionRequest._parser = new MessageParser<NpcGenericActionRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x001C2B88 File Offset: 0x001C0D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HDB2qaOWtNw4fBBTC8Sy()
		{
			return true;
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x001C2B90 File Offset: 0x001C0D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcGenericActionRequest g44aRrOWwG8sT6RfJAjJ()
		{
			return null;
		}

		// Token: 0x04000D80 RID: 3456
		private static readonly MessageParser<NpcGenericActionRequest> _parser;

		// Token: 0x04000D81 RID: 3457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D82 RID: 3458
		public const int NpcIdFieldNumber = 1;

		// Token: 0x04000D83 RID: 3459
		private int npcId_;

		// Token: 0x04000D84 RID: 3460
		public const int NpcActionIdFieldNumber = 2;

		// Token: 0x04000D85 RID: 3461
		private int npcActionId_;

		// Token: 0x04000D86 RID: 3462
		public const int NpcMapIdFieldNumber = 3;

		// Token: 0x04000D87 RID: 3463
		private long npcMapId_;

		// Token: 0x04000D88 RID: 3464
		private static NpcGenericActionRequest JNrhVHOWDx02FoOYXtuQ;
	}
}
