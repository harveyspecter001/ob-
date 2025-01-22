using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200098B RID: 2443
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachSavedEvent : IMessage<BreachSavedEvent>, IMessage, IEquatable<BreachSavedEvent>, IDeepCloneable<BreachSavedEvent>, IBufferMessage
	{
		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600763F RID: 30271 RVA: 0x00243F14 File Offset: 0x00242114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachSavedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x00243F24 File Offset: 0x00242124
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

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06007641 RID: 30273 RVA: 0x00243F34 File Offset: 0x00242134
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

		// Token: 0x06007642 RID: 30274 RVA: 0x00243F44 File Offset: 0x00242144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachSavedEvent()
		{
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00243F54 File Offset: 0x00242154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachSavedEvent(BreachSavedEvent other)
		{
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00243F64 File Offset: 0x00242164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachSavedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06007645 RID: 30277 RVA: 0x00243F74 File Offset: 0x00242174
		// (set) Token: 0x06007646 RID: 30278 RVA: 0x00243F84 File Offset: 0x00242184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Saved
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

		// Token: 0x06007647 RID: 30279 RVA: 0x00243F94 File Offset: 0x00242194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00243FA4 File Offset: 0x002421A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachSavedEvent other)
		{
			return true;
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00243FB4 File Offset: 0x002421B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00243FC4 File Offset: 0x002421C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00243FD4 File Offset: 0x002421D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00243FE4 File Offset: 0x002421E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00243FF4 File Offset: 0x002421F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00244004 File Offset: 0x00242204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachSavedEvent other)
		{
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00244014 File Offset: 0x00242214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00244024 File Offset: 0x00242224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00244034 File Offset: 0x00242234
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachSavedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						BreachSavedEvent._parser = new MessageParser<BreachSavedEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 3:
						goto IL_AC;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00244104 File Offset: 0x00242304
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rc4s9SJRHWIXbqGRHNG5()
		{
			return true;
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x0024410C File Offset: 0x0024230C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachSavedEvent IJPWHGJRYuQ5RpHLEB5v()
		{
			return null;
		}

		// Token: 0x04002927 RID: 10535
		private static readonly MessageParser<BreachSavedEvent> _parser;

		// Token: 0x04002928 RID: 10536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002929 RID: 10537
		public const int SavedFieldNumber = 1;

		// Token: 0x0400292A RID: 10538
		private bool saved_;

		// Token: 0x0400292B RID: 10539
		private static BreachSavedEvent kg1wX3JRpEhe6UeYVxWg;
	}
}
