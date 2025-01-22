using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly
{
	// Token: 0x02000CE8 RID: 3304
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AnomalyOpenedEvent : IMessage<AnomalyOpenedEvent>, IMessage, IEquatable<AnomalyOpenedEvent>, IDeepCloneable<AnomalyOpenedEvent>, IBufferMessage
	{
		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06009F09 RID: 40713 RVA: 0x002849C0 File Offset: 0x00282BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AnomalyOpenedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06009F0A RID: 40714 RVA: 0x002849D0 File Offset: 0x00282BD0
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

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x002849E0 File Offset: 0x00282BE0
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

		// Token: 0x06009F0C RID: 40716 RVA: 0x002849F0 File Offset: 0x00282BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyOpenedEvent()
		{
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x00284A00 File Offset: 0x00282C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyOpenedEvent(AnomalyOpenedEvent other)
		{
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x00284A10 File Offset: 0x00282C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalyOpenedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06009F0F RID: 40719 RVA: 0x00284A20 File Offset: 0x00282C20
		// (set) Token: 0x06009F10 RID: 40720 RVA: 0x00284A30 File Offset: 0x00282C30
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

		// Token: 0x06009F11 RID: 40721 RVA: 0x00284A40 File Offset: 0x00282C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F12 RID: 40722 RVA: 0x00284A50 File Offset: 0x00282C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AnomalyOpenedEvent other)
		{
			return true;
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x00284A60 File Offset: 0x00282C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x00284A70 File Offset: 0x00282C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x00284A80 File Offset: 0x00282C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x00284A90 File Offset: 0x00282C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x00284AA0 File Offset: 0x00282CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x00284AB0 File Offset: 0x00282CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AnomalyOpenedEvent other)
		{
		}

		// Token: 0x06009F19 RID: 40729 RVA: 0x00284AC0 File Offset: 0x00282CC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F1A RID: 40730 RVA: 0x00284AD0 File Offset: 0x00282CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00284AE0 File Offset: 0x00282CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnomalyOpenedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AnomalyOpenedEvent._parser = new MessageParser<AnomalyOpenedEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x00284BAC File Offset: 0x00282DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J5bZAZJj24EjU57SZOWP()
		{
			return true;
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x00284BB4 File Offset: 0x00282DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AnomalyOpenedEvent htB01HJjEnsqO0gVcs1E()
		{
			return null;
		}

		// Token: 0x04003AEB RID: 15083
		private static readonly MessageParser<AnomalyOpenedEvent> _parser;

		// Token: 0x04003AEC RID: 15084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AED RID: 15085
		public const int SubareaIdFieldNumber = 1;

		// Token: 0x04003AEE RID: 15086
		private int subareaId_;

		// Token: 0x04003AEF RID: 15087
		private static AnomalyOpenedEvent SIy8qOJj9Irp4yQ8pM3F;
	}
}
