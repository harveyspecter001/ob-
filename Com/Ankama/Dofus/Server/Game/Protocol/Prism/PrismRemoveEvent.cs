using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001D5 RID: 469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismRemoveEvent : IMessage<PrismRemoveEvent>, IMessage, IEquatable<PrismRemoveEvent>, IDeepCloneable<PrismRemoveEvent>, IBufferMessage
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x001A7960 File Offset: 0x001A5B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x001A7970 File Offset: 0x001A5B70
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x001A7980 File Offset: 0x001A5B80
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

		// Token: 0x060015E8 RID: 5608 RVA: 0x001A7990 File Offset: 0x001A5B90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRemoveEvent()
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x001A79A0 File Offset: 0x001A5BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRemoveEvent(PrismRemoveEvent other)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x001A79B0 File Offset: 0x001A5BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x001A79C0 File Offset: 0x001A5BC0
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x001A79D0 File Offset: 0x001A5BD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubareaId
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

		// Token: 0x060015ED RID: 5613 RVA: 0x001A79E0 File Offset: 0x001A5BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x001A79F0 File Offset: 0x001A5BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismRemoveEvent other)
		{
			return true;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x001A7A00 File Offset: 0x001A5C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x001A7A10 File Offset: 0x001A5C10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x001A7A20 File Offset: 0x001A5C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x001A7A30 File Offset: 0x001A5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x001A7A40 File Offset: 0x001A5C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x001A7A50 File Offset: 0x001A5C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismRemoveEvent other)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x001A7A60 File Offset: 0x001A5C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x001A7A70 File Offset: 0x001A5C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x001A7A80 File Offset: 0x001A5C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismRemoveEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					PrismRemoveEvent._parser = new MessageParser<PrismRemoveEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x001A7B78 File Offset: 0x001A5D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cs32T0O1veV5E317VFAJ()
		{
			return true;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x001A7B80 File Offset: 0x001A5D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismRemoveEvent qbIaDjO1ojft3hkostYO()
		{
			return null;
		}

		// Token: 0x040007C0 RID: 1984
		private static readonly MessageParser<PrismRemoveEvent> _parser;

		// Token: 0x040007C1 RID: 1985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007C2 RID: 1986
		public const int SubareaIdFieldNumber = 1;

		// Token: 0x040007C3 RID: 1987
		private int subareaId_;

		// Token: 0x040007C4 RID: 1988
		internal static PrismRemoveEvent xBXdHCO1UNmKoxtI0LEV;
	}
}
