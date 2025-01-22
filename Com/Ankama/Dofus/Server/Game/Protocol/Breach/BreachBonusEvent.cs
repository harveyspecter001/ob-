using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000987 RID: 2439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachBonusEvent : IMessage<BreachBonusEvent>, IMessage, IEquatable<BreachBonusEvent>, IDeepCloneable<BreachBonusEvent>, IBufferMessage
	{
		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x00243AEC File Offset: 0x00241CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachBonusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x00243AFC File Offset: 0x00241CFC
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x00243B0C File Offset: 0x00241D0C
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

		// Token: 0x0600760E RID: 30222 RVA: 0x00243B1C File Offset: 0x00241D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBonusEvent()
		{
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00243B2C File Offset: 0x00241D2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBonusEvent(BreachBonusEvent other)
		{
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00243B3C File Offset: 0x00241D3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBonusEvent Clone()
		{
			return null;
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06007611 RID: 30225 RVA: 0x00243B4C File Offset: 0x00241D4C
		// (set) Token: 0x06007612 RID: 30226 RVA: 0x00243B5C File Offset: 0x00241D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectEffect Bonus
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

		// Token: 0x06007613 RID: 30227 RVA: 0x00243B6C File Offset: 0x00241D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00243B7C File Offset: 0x00241D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachBonusEvent other)
		{
			return true;
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00243B8C File Offset: 0x00241D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00243B9C File Offset: 0x00241D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00243BAC File Offset: 0x00241DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00243BBC File Offset: 0x00241DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00243BCC File Offset: 0x00241DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00243BDC File Offset: 0x00241DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachBonusEvent other)
		{
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00243BEC File Offset: 0x00241DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00243BFC File Offset: 0x00241DFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00243C0C File Offset: 0x00241E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachBonusEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					BreachBonusEvent._parser = new MessageParser<BreachBonusEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00243CF0 File Offset: 0x00241EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p9MTICJRtJh08T6pKpin()
		{
			return true;
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00243CF8 File Offset: 0x00241EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachBonusEvent r7Jc1vJRwtXcC93OW39U()
		{
			return null;
		}

		// Token: 0x04002919 RID: 10521
		private static readonly MessageParser<BreachBonusEvent> _parser;

		// Token: 0x0400291A RID: 10522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400291B RID: 10523
		public const int BonusFieldNumber = 1;

		// Token: 0x0400291C RID: 10524
		private ObjectEffect bonus_;

		// Token: 0x0400291D RID: 10525
		private static BreachBonusEvent MWC2ytJRDgawGTTnNjwv;
	}
}
