using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200040D RID: 1037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectDeletedEvent : IMessage<ObjectDeletedEvent>, IMessage, IEquatable<ObjectDeletedEvent>, IDeepCloneable<ObjectDeletedEvent>, IBufferMessage
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x001D46A0 File Offset: 0x001D28A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectDeletedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x001D46B0 File Offset: 0x001D28B0
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

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x001D46C0 File Offset: 0x001D28C0
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

		// Token: 0x060030F7 RID: 12535 RVA: 0x001D46D0 File Offset: 0x001D28D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeletedEvent()
		{
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x001D46E0 File Offset: 0x001D28E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeletedEvent(ObjectDeletedEvent other)
		{
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x001D46F0 File Offset: 0x001D28F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeletedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x001D4700 File Offset: 0x001D2900
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x001D4710 File Offset: 0x001D2910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectUid
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

		// Token: 0x060030FC RID: 12540 RVA: 0x001D4720 File Offset: 0x001D2920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x001D4730 File Offset: 0x001D2930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectDeletedEvent other)
		{
			return true;
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x001D4740 File Offset: 0x001D2940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x001D4750 File Offset: 0x001D2950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x001D4760 File Offset: 0x001D2960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x001D4770 File Offset: 0x001D2970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x001D4780 File Offset: 0x001D2980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x001D4790 File Offset: 0x001D2990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectDeletedEvent other)
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x001D47A0 File Offset: 0x001D29A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x001D47B0 File Offset: 0x001D29B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x001D47C0 File Offset: 0x001D29C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectDeletedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				ObjectDeletedEvent._parser = new MessageParser<ObjectDeletedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x001D48A4 File Offset: 0x001D2AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gV7QQxOCNPympuyBLvQy()
		{
			return true;
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x001D48AC File Offset: 0x001D2AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectDeletedEvent uDU2DpOCxAFt5iAFN5fc()
		{
			return null;
		}

		// Token: 0x04001126 RID: 4390
		private static readonly MessageParser<ObjectDeletedEvent> _parser;

		// Token: 0x04001127 RID: 4391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001128 RID: 4392
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001129 RID: 4393
		private int objectUid_;

		// Token: 0x0400112A RID: 4394
		private static ObjectDeletedEvent vt2DZWOCXkdRi2VHLa5I;
	}
}
