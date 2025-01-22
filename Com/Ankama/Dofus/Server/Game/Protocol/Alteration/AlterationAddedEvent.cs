using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration
{
	// Token: 0x02000CED RID: 3309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlterationAddedEvent : IMessage<AlterationAddedEvent>, IMessage, IEquatable<AlterationAddedEvent>, IDeepCloneable<AlterationAddedEvent>, IBufferMessage
	{
		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06009F40 RID: 40768 RVA: 0x0028547C File Offset: 0x0028367C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AlterationAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x0028548C File Offset: 0x0028368C
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

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06009F42 RID: 40770 RVA: 0x0028549C File Offset: 0x0028369C
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

		// Token: 0x06009F43 RID: 40771 RVA: 0x002854AC File Offset: 0x002836AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationAddedEvent()
		{
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x002854BC File Offset: 0x002836BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationAddedEvent(AlterationAddedEvent other)
		{
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x002854CC File Offset: 0x002836CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06009F46 RID: 40774 RVA: 0x002854DC File Offset: 0x002836DC
		// (set) Token: 0x06009F47 RID: 40775 RVA: 0x002854EC File Offset: 0x002836EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Alteration Alteration
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

		// Token: 0x06009F48 RID: 40776 RVA: 0x002854FC File Offset: 0x002836FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x0028550C File Offset: 0x0028370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlterationAddedEvent other)
		{
			return true;
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x0028551C File Offset: 0x0028371C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x0028552C File Offset: 0x0028372C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x0028553C File Offset: 0x0028373C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x0028554C File Offset: 0x0028374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x0028555C File Offset: 0x0028375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x0028556C File Offset: 0x0028376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlterationAddedEvent other)
		{
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x0028557C File Offset: 0x0028377C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x0028558C File Offset: 0x0028378C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x0028559C File Offset: 0x0028379C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlterationAddedEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					AlterationAddedEvent._parser = new MessageParser<AlterationAddedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x00285680 File Offset: 0x00283880
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UGkl6PJjkuD7AR3MLvtY()
		{
			return true;
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x00285688 File Offset: 0x00283888
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlterationAddedEvent ScFEfNJjlUJNoU2YoU6r()
		{
			return null;
		}

		// Token: 0x04003AFC RID: 15100
		private static readonly MessageParser<AlterationAddedEvent> _parser;

		// Token: 0x04003AFD RID: 15101
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AFE RID: 15102
		public const int AlterationFieldNumber = 1;

		// Token: 0x04003AFF RID: 15103
		private Alteration alteration_;

		// Token: 0x04003B00 RID: 15104
		private static AlterationAddedEvent Y9Bex7JjISfv3qDm8yLU;
	}
}
