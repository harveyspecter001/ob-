using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly
{
	// Token: 0x02000CE6 RID: 3302
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AnomalyStateEvent : IMessage<AnomalyStateEvent>, IMessage, IEquatable<AnomalyStateEvent>, IDeepCloneable<AnomalyStateEvent>, IBufferMessage
	{
		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x00284784 File Offset: 0x00282984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AnomalyStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x00284794 File Offset: 0x00282994
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

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06009EED RID: 40685 RVA: 0x002847A4 File Offset: 0x002829A4
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

		// Token: 0x06009EEE RID: 40686 RVA: 0x002847B4 File Offset: 0x002829B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyStateEvent()
		{
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x002847C4 File Offset: 0x002829C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyStateEvent(AnomalyStateEvent other)
		{
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x002847D4 File Offset: 0x002829D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyStateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x002847E4 File Offset: 0x002829E4
		// (set) Token: 0x06009EF2 RID: 40690 RVA: 0x002847F4 File Offset: 0x002829F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x00284804 File Offset: 0x00282A04
		// (set) Token: 0x06009EF4 RID: 40692 RVA: 0x00284814 File Offset: 0x00282A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x00284824 File Offset: 0x00282A24
		// (set) Token: 0x06009EF6 RID: 40694 RVA: 0x00284834 File Offset: 0x00282A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClosingTime
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

		// Token: 0x06009EF7 RID: 40695 RVA: 0x00284844 File Offset: 0x00282A44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x00284854 File Offset: 0x00282A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AnomalyStateEvent other)
		{
			return true;
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x00284864 File Offset: 0x00282A64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x00284874 File Offset: 0x00282A74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x00284884 File Offset: 0x00282A84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x00284894 File Offset: 0x00282A94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x002848A4 File Offset: 0x00282AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x002848B4 File Offset: 0x00282AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AnomalyStateEvent other)
		{
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x002848C4 File Offset: 0x00282AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x002848D4 File Offset: 0x00282AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x002848E4 File Offset: 0x00282AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnomalyStateEvent()
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
					num2 = 2;
					continue;
				case 2:
					AnomalyStateEvent._parser = new MessageParser<AnomalyStateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
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
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x002849B0 File Offset: 0x00282BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ViIxxlJjs8qFMjiwtoj9()
		{
			return true;
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x002849B8 File Offset: 0x00282BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AnomalyStateEvent YyhA87JjdNQ4tUJWkJJV()
		{
			return null;
		}

		// Token: 0x04003AE0 RID: 15072
		private static readonly MessageParser<AnomalyStateEvent> _parser;

		// Token: 0x04003AE1 RID: 15073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AE2 RID: 15074
		public const int SubareaIdFieldNumber = 1;

		// Token: 0x04003AE3 RID: 15075
		private int subareaId_;

		// Token: 0x04003AE4 RID: 15076
		public const int OpenFieldNumber = 2;

		// Token: 0x04003AE5 RID: 15077
		private bool open_;

		// Token: 0x04003AE6 RID: 15078
		public const int ClosingTimeFieldNumber = 3;

		// Token: 0x04003AE7 RID: 15079
		private long closingTime_;

		// Token: 0x04003AE8 RID: 15080
		private static AnomalyStateEvent OeeTbAJjgl9nl5I2mlEp;
	}
}
