using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x02000446 RID: 1094
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveMapUpdateEvent : IMessage<InteractiveMapUpdateEvent>, IMessage, IEquatable<InteractiveMapUpdateEvent>, IDeepCloneable<InteractiveMapUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x001D8D3C File Offset: 0x001D6F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractiveMapUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060033FF RID: 13311 RVA: 0x001D8D4C File Offset: 0x001D6F4C
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x001D8D5C File Offset: 0x001D6F5C
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

		// Token: 0x06003401 RID: 13313 RVA: 0x001D8D6C File Offset: 0x001D6F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveMapUpdateEvent()
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x001D8D7C File Offset: 0x001D6F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveMapUpdateEvent(InteractiveMapUpdateEvent other)
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x001D8D8C File Offset: 0x001D6F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveMapUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x001D8D9C File Offset: 0x001D6F9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<InteractiveElement> InteractiveElements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x001D8DAC File Offset: 0x001D6FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x001D8DBC File Offset: 0x001D6FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveMapUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x001D8DCC File Offset: 0x001D6FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x001D8DDC File Offset: 0x001D6FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x001D8DEC File Offset: 0x001D6FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x001D8DFC File Offset: 0x001D6FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x001D8E0C File Offset: 0x001D700C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x001D8E1C File Offset: 0x001D701C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveMapUpdateEvent other)
		{
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x001D8E2C File Offset: 0x001D702C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x001D8E3C File Offset: 0x001D703C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x001D8E4C File Offset: 0x001D704C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveMapUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					InteractiveMapUpdateEvent._repeated_interactiveElements_codec = FieldCodec.ForMessage<InteractiveElement>(10U, AVc6eFmm5J4Y7UUcgCBr.XVInXhlssT(AVc6eFmm5J4Y7UUcgCBr.gmlmmyBRi7i));
					num2 = 3;
					continue;
				}
				InteractiveMapUpdateEvent._parser = new MessageParser<InteractiveMapUpdateEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x001D8F54 File Offset: 0x001D7154
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rfQk7CODtVpqkXvZ5xCr()
		{
			return true;
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x001D8F5C File Offset: 0x001D715C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveMapUpdateEvent RoMVMAODwbMeXsBhLAFd()
		{
			return null;
		}

		// Token: 0x04001232 RID: 4658
		private static readonly MessageParser<InteractiveMapUpdateEvent> _parser;

		// Token: 0x04001233 RID: 4659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001234 RID: 4660
		public const int InteractiveElementsFieldNumber = 1;

		// Token: 0x04001235 RID: 4661
		private static readonly FieldCodec<InteractiveElement> _repeated_interactiveElements_codec;

		// Token: 0x04001236 RID: 4662
		private readonly RepeatedField<InteractiveElement> interactiveElements_;

		// Token: 0x04001237 RID: 4663
		internal static InteractiveMapUpdateEvent qs2O2lODDLDhHFsBmDEJ;
	}
}
