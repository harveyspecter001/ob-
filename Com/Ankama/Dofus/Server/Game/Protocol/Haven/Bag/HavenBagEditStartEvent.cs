using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000499 RID: 1177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagEditStartEvent : IMessage<HavenBagEditStartEvent>, IMessage, IEquatable<HavenBagEditStartEvent>, IDeepCloneable<HavenBagEditStartEvent>, IBufferMessage
	{
		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x001E03D4 File Offset: 0x001DE5D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagEditStartEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x001E03E4 File Offset: 0x001DE5E4
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

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x001E03F4 File Offset: 0x001DE5F4
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

		// Token: 0x06003850 RID: 14416 RVA: 0x001E0404 File Offset: 0x001DE604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditStartEvent()
		{
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x001E0414 File Offset: 0x001DE614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditStartEvent(HavenBagEditStartEvent other)
		{
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x001E0424 File Offset: 0x001DE624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditStartEvent Clone()
		{
			return null;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x001E0434 File Offset: 0x001DE634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x001E0444 File Offset: 0x001DE644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagEditStartEvent other)
		{
			return true;
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x001E0454 File Offset: 0x001DE654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x001E0464 File Offset: 0x001DE664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x001E0474 File Offset: 0x001DE674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x001E0484 File Offset: 0x001DE684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x001E0494 File Offset: 0x001DE694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x001E04A4 File Offset: 0x001DE6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagEditStartEvent other)
		{
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x001E04B4 File Offset: 0x001DE6B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x001E04C4 File Offset: 0x001DE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x001E04D4 File Offset: 0x001DE6D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagEditStartEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagEditStartEvent._parser = new MessageParser<HavenBagEditStartEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
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

		// Token: 0x0600385E RID: 14430 RVA: 0x001E05B8 File Offset: 0x001DE7B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J3IA4ZOwWbLTk2xVDZ9H()
		{
			return true;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x001E05C0 File Offset: 0x001DE7C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagEditStartEvent LYZYdUOwhUUPq8GwvykQ()
		{
			return null;
		}

		// Token: 0x040013AB RID: 5035
		private static readonly MessageParser<HavenBagEditStartEvent> _parser;

		// Token: 0x040013AC RID: 5036
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013AD RID: 5037
		private static HavenBagEditStartEvent uwWJk1OwLNr7lEudbays;
	}
}
