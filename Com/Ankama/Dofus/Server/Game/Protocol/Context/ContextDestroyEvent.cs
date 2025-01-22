using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000811 RID: 2065
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextDestroyEvent : IMessage<ContextDestroyEvent>, IMessage, IEquatable<ContextDestroyEvent>, IDeepCloneable<ContextDestroyEvent>, IBufferMessage
	{
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x002269EC File Offset: 0x00224BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextDestroyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x002269FC File Offset: 0x00224BFC
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

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x00226A0C File Offset: 0x00224C0C
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

		// Token: 0x06006474 RID: 25716 RVA: 0x00226A1C File Offset: 0x00224C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextDestroyEvent()
		{
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x00226A2C File Offset: 0x00224C2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextDestroyEvent(ContextDestroyEvent other)
		{
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x00226A3C File Offset: 0x00224C3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextDestroyEvent Clone()
		{
			return null;
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x00226A4C File Offset: 0x00224C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x00226A5C File Offset: 0x00224C5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextDestroyEvent other)
		{
			return true;
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x00226A6C File Offset: 0x00224C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00226A7C File Offset: 0x00224C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00226A8C File Offset: 0x00224C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00226A9C File Offset: 0x00224C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00226AAC File Offset: 0x00224CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00226ABC File Offset: 0x00224CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextDestroyEvent other)
		{
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00226ACC File Offset: 0x00224CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00226ADC File Offset: 0x00224CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00226AEC File Offset: 0x00224CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextDestroyEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ContextDestroyEvent._parser = new MessageParser<ContextDestroyEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00226BE4 File Offset: 0x00224DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BSpM0sOzwiDmGxOcViDJ()
		{
			return true;
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00226BEC File Offset: 0x00224DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextDestroyEvent YFk9buOzQjowmAX1Z7mm()
		{
			return null;
		}

		// Token: 0x0400234C RID: 9036
		private static readonly MessageParser<ContextDestroyEvent> _parser;

		// Token: 0x0400234D RID: 9037
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400234E RID: 9038
		private static ContextDestroyEvent sjK9BLOztC3oDEHrpDM3;
	}
}
