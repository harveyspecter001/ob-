using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003FB RID: 1019
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectDroppedEvent : IMessage<ObjectDroppedEvent>, IMessage, IEquatable<ObjectDroppedEvent>, IDeepCloneable<ObjectDroppedEvent>, IBufferMessage
	{
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x001D3368 File Offset: 0x001D1568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectDroppedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x001D3378 File Offset: 0x001D1578
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

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x001D3388 File Offset: 0x001D1588
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

		// Token: 0x0600300C RID: 12300 RVA: 0x001D3398 File Offset: 0x001D1598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDroppedEvent()
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x001D33A8 File Offset: 0x001D15A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDroppedEvent(ObjectDroppedEvent other)
		{
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x001D33B8 File Offset: 0x001D15B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDroppedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x001D33C8 File Offset: 0x001D15C8
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x001D33D8 File Offset: 0x001D15D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectInRolePlay Object
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

		// Token: 0x06003011 RID: 12305 RVA: 0x001D33E8 File Offset: 0x001D15E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x001D33F8 File Offset: 0x001D15F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectDroppedEvent other)
		{
			return true;
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x001D3408 File Offset: 0x001D1608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x001D3418 File Offset: 0x001D1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x001D3428 File Offset: 0x001D1628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x001D3438 File Offset: 0x001D1638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x001D3448 File Offset: 0x001D1648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x001D3458 File Offset: 0x001D1658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectDroppedEvent other)
		{
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x001D3468 File Offset: 0x001D1668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x001D3478 File Offset: 0x001D1678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x001D3488 File Offset: 0x001D1688
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectDroppedEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_5E;
					}
					ObjectDroppedEvent._parser = new MessageParser<ObjectDroppedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
					}
				}
				IL_5E:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x001D3570 File Offset: 0x001D1770
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool heJObNO0PR9Ea5nVdXB7()
		{
			return true;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x001D3578 File Offset: 0x001D1778
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectDroppedEvent hLMLbGO0SeRXBDxWSQLm()
		{
			return null;
		}

		// Token: 0x040010E0 RID: 4320
		private static readonly MessageParser<ObjectDroppedEvent> _parser;

		// Token: 0x040010E1 RID: 4321
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010E2 RID: 4322
		public const int ObjectFieldNumber = 1;

		// Token: 0x040010E3 RID: 4323
		private ObjectInRolePlay object_;

		// Token: 0x040010E4 RID: 4324
		private static ObjectDroppedEvent ki1f12O0iZWCKW6B5M3m;
	}
}
