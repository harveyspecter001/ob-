using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000856 RID: 2134
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WarnOnPermanentDeathStateEvent : IMessage<WarnOnPermanentDeathStateEvent>, IMessage, IEquatable<WarnOnPermanentDeathStateEvent>, IDeepCloneable<WarnOnPermanentDeathStateEvent>, IBufferMessage
	{
		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x0022D6B4 File Offset: 0x0022B8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<WarnOnPermanentDeathStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x0022D6C4 File Offset: 0x0022B8C4
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

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x0022D6D4 File Offset: 0x0022B8D4
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

		// Token: 0x060067C9 RID: 26569 RVA: 0x0022D6E4 File Offset: 0x0022B8E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WarnOnPermanentDeathStateEvent()
		{
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x0022D6F4 File Offset: 0x0022B8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WarnOnPermanentDeathStateEvent(WarnOnPermanentDeathStateEvent other)
		{
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x0022D704 File Offset: 0x0022B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WarnOnPermanentDeathStateEvent Clone()
		{
			return null;
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x0022D714 File Offset: 0x0022B914
		// (set) Token: 0x060067CD RID: 26573 RVA: 0x0022D724 File Offset: 0x0022B924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060067CE RID: 26574 RVA: 0x0022D734 File Offset: 0x0022B934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x0022D744 File Offset: 0x0022B944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WarnOnPermanentDeathStateEvent other)
		{
			return true;
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0022D754 File Offset: 0x0022B954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x0022D764 File Offset: 0x0022B964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x0022D774 File Offset: 0x0022B974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x0022D784 File Offset: 0x0022B984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x0022D794 File Offset: 0x0022B994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x0022D7A4 File Offset: 0x0022B9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WarnOnPermanentDeathStateEvent other)
		{
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x0022D7B4 File Offset: 0x0022B9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x0022D7C4 File Offset: 0x0022B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x0022D7D4 File Offset: 0x0022B9D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WarnOnPermanentDeathStateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					WarnOnPermanentDeathStateEvent._parser = new MessageParser<WarnOnPermanentDeathStateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x0022D8B8 File Offset: 0x0022BAB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xeJlIkJnKENHimjkVjiR()
		{
			return true;
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x0022D8C0 File Offset: 0x0022BAC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WarnOnPermanentDeathStateEvent zhGR6KJnI81UYGl7rAot()
		{
			return null;
		}

		// Token: 0x04002454 RID: 9300
		private static readonly MessageParser<WarnOnPermanentDeathStateEvent> _parser;

		// Token: 0x04002455 RID: 9301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002456 RID: 9302
		public const int EnableFieldNumber = 1;

		// Token: 0x04002457 RID: 9303
		private bool enable_;

		// Token: 0x04002458 RID: 9304
		internal static WarnOnPermanentDeathStateEvent SEh9WhJnjviRw0u3rv5x;
	}
}
