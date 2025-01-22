using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000813 RID: 2067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextRemoveElementEvent : IMessage<ContextRemoveElementEvent>, IMessage, IEquatable<ContextRemoveElementEvent>, IDeepCloneable<ContextRemoveElementEvent>, IBufferMessage
	{
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x00226BF4 File Offset: 0x00224DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextRemoveElementEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600648A RID: 25738 RVA: 0x00226C04 File Offset: 0x00224E04
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x00226C14 File Offset: 0x00224E14
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

		// Token: 0x0600648C RID: 25740 RVA: 0x00226C24 File Offset: 0x00224E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementEvent()
		{
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00226C34 File Offset: 0x00224E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementEvent(ContextRemoveElementEvent other)
		{
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00226C44 File Offset: 0x00224E44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementEvent Clone()
		{
			return null;
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600648F RID: 25743 RVA: 0x00226C54 File Offset: 0x00224E54
		// (set) Token: 0x06006490 RID: 25744 RVA: 0x00226C64 File Offset: 0x00224E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ElementId
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

		// Token: 0x06006491 RID: 25745 RVA: 0x00226C74 File Offset: 0x00224E74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x00226C84 File Offset: 0x00224E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextRemoveElementEvent other)
		{
			return true;
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00226C94 File Offset: 0x00224E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00226CA4 File Offset: 0x00224EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00226CB4 File Offset: 0x00224EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x00226CC4 File Offset: 0x00224EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x00226CD4 File Offset: 0x00224ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x00226CE4 File Offset: 0x00224EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextRemoveElementEvent other)
		{
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00226CF4 File Offset: 0x00224EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00226D04 File Offset: 0x00224F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00226D14 File Offset: 0x00224F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextRemoveElementEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ContextRemoveElementEvent._parser = new MessageParser<ContextRemoveElementEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00226E0C File Offset: 0x0022500C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y5kwAGOzT6Bijb1CyYHa()
		{
			return true;
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00226E14 File Offset: 0x00225014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextRemoveElementEvent pJAephOzpyMJRbta9fwj()
		{
			return null;
		}

		// Token: 0x04002351 RID: 9041
		private static readonly MessageParser<ContextRemoveElementEvent> _parser;

		// Token: 0x04002352 RID: 9042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002353 RID: 9043
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04002354 RID: 9044
		private long elementId_;

		// Token: 0x04002355 RID: 9045
		internal static ContextRemoveElementEvent w0SeY4Oz7ue3d7D5NeuK;
	}
}
