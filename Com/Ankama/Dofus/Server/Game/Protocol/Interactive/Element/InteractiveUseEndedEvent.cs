using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x02000444 RID: 1092
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveUseEndedEvent : IMessage<InteractiveUseEndedEvent>, IMessage, IEquatable<InteractiveUseEndedEvent>, IDeepCloneable<InteractiveUseEndedEvent>, IBufferMessage
	{
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x001D8B20 File Offset: 0x001D6D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractiveUseEndedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x001D8B30 File Offset: 0x001D6D30
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x001D8B40 File Offset: 0x001D6D40
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

		// Token: 0x060033E5 RID: 13285 RVA: 0x001D8B50 File Offset: 0x001D6D50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseEndedEvent()
		{
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x001D8B60 File Offset: 0x001D6D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseEndedEvent(InteractiveUseEndedEvent other)
		{
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x001D8B70 File Offset: 0x001D6D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseEndedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x001D8B80 File Offset: 0x001D6D80
		// (set) Token: 0x060033E9 RID: 13289 RVA: 0x001D8B90 File Offset: 0x001D6D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementId
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

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x001D8BA0 File Offset: 0x001D6DA0
		// (set) Token: 0x060033EB RID: 13291 RVA: 0x001D8BB0 File Offset: 0x001D6DB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkillId
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

		// Token: 0x060033EC RID: 13292 RVA: 0x001D8BC0 File Offset: 0x001D6DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x001D8BD0 File Offset: 0x001D6DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveUseEndedEvent other)
		{
			return true;
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x001D8BE0 File Offset: 0x001D6DE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x001D8BF0 File Offset: 0x001D6DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x001D8C00 File Offset: 0x001D6E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x001D8C10 File Offset: 0x001D6E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x001D8C20 File Offset: 0x001D6E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x001D8C30 File Offset: 0x001D6E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveUseEndedEvent other)
		{
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x001D8C40 File Offset: 0x001D6E40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x001D8C50 File Offset: 0x001D6E50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x001D8C60 File Offset: 0x001D6E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveUseEndedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					InteractiveUseEndedEvent._parser = new MessageParser<InteractiveUseEndedEvent>(() => null);
					num2 = 3;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x001D8D2C File Offset: 0x001D6F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iMghBKOD0yXPuP8og7nF()
		{
			return true;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x001D8D34 File Offset: 0x001D6F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveUseEndedEvent LVCkfYODCa1Jl4Dsxwec()
		{
			return null;
		}

		// Token: 0x04001229 RID: 4649
		private static readonly MessageParser<InteractiveUseEndedEvent> _parser;

		// Token: 0x0400122A RID: 4650
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400122B RID: 4651
		public const int ElementIdFieldNumber = 1;

		// Token: 0x0400122C RID: 4652
		private int elementId_;

		// Token: 0x0400122D RID: 4653
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400122E RID: 4654
		private int skillId_;

		// Token: 0x0400122F RID: 4655
		internal static InteractiveUseEndedEvent niG8bhODVDGjX6EZqXSt;
	}
}
