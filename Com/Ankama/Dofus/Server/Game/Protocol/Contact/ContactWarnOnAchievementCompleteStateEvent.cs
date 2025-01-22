using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000846 RID: 2118
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContactWarnOnAchievementCompleteStateEvent : IMessage<ContactWarnOnAchievementCompleteStateEvent>, IMessage, IEquatable<ContactWarnOnAchievementCompleteStateEvent>, IDeepCloneable<ContactWarnOnAchievementCompleteStateEvent>, IBufferMessage
	{
		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x0022C598 File Offset: 0x0022A798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ContactWarnOnAchievementCompleteStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060066EF RID: 26351 RVA: 0x0022C5A8 File Offset: 0x0022A7A8
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

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x0022C5B8 File Offset: 0x0022A7B8
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

		// Token: 0x060066F1 RID: 26353 RVA: 0x0022C5C8 File Offset: 0x0022A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteStateEvent()
		{
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x0022C5D8 File Offset: 0x0022A7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteStateEvent(ContactWarnOnAchievementCompleteStateEvent other)
		{
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x0022C5E8 File Offset: 0x0022A7E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContactWarnOnAchievementCompleteStateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x060066F4 RID: 26356 RVA: 0x0022C5F8 File Offset: 0x0022A7F8
		// (set) Token: 0x060066F5 RID: 26357 RVA: 0x0022C608 File Offset: 0x0022A808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
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

		// Token: 0x060066F6 RID: 26358 RVA: 0x0022C618 File Offset: 0x0022A818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x0022C628 File Offset: 0x0022A828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContactWarnOnAchievementCompleteStateEvent other)
		{
			return true;
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x0022C638 File Offset: 0x0022A838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x0022C648 File Offset: 0x0022A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x0022C658 File Offset: 0x0022A858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x0022C668 File Offset: 0x0022A868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x0022C678 File Offset: 0x0022A878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x0022C688 File Offset: 0x0022A888
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContactWarnOnAchievementCompleteStateEvent other)
		{
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x0022C698 File Offset: 0x0022A898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x0022C6A8 File Offset: 0x0022A8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x0022C6B8 File Offset: 0x0022A8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContactWarnOnAchievementCompleteStateEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ContactWarnOnAchievementCompleteStateEvent._parser = new MessageParser<ContactWarnOnAchievementCompleteStateEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x0022C784 File Offset: 0x0022A984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kTR6GMJfFLu5JmQXHl2R()
		{
			return true;
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x0022C78C File Offset: 0x0022A98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContactWarnOnAchievementCompleteStateEvent PB6vl8JfzywP7tGoQslc()
		{
			return null;
		}

		// Token: 0x04002414 RID: 9236
		private static readonly MessageParser<ContactWarnOnAchievementCompleteStateEvent> _parser;

		// Token: 0x04002415 RID: 9237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002416 RID: 9238
		public const int EnableFieldNumber = 1;

		// Token: 0x04002417 RID: 9239
		private bool enable_;

		// Token: 0x04002418 RID: 9240
		internal static ContactWarnOnAchievementCompleteStateEvent sGpADmJfqw73VvFKU8Cy;
	}
}
