using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x0200044C RID: 1100
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StatedElementUpdatedEvent : IMessage<StatedElementUpdatedEvent>, IMessage, IEquatable<StatedElementUpdatedEvent>, IDeepCloneable<StatedElementUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x001D93B4 File Offset: 0x001D75B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StatedElementUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x001D93C4 File Offset: 0x001D75C4
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x001D93D4 File Offset: 0x001D75D4
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

		// Token: 0x0600344D RID: 13389 RVA: 0x001D93E4 File Offset: 0x001D75E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElementUpdatedEvent()
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x001D93F4 File Offset: 0x001D75F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElementUpdatedEvent(StatedElementUpdatedEvent other)
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x001D9404 File Offset: 0x001D7604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatedElementUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x001D9414 File Offset: 0x001D7614
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x001D9424 File Offset: 0x001D7624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public StatedElement StatedElement
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

		// Token: 0x06003452 RID: 13394 RVA: 0x001D9434 File Offset: 0x001D7634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x001D9444 File Offset: 0x001D7644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StatedElementUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x001D9454 File Offset: 0x001D7654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x001D9464 File Offset: 0x001D7664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x001D9474 File Offset: 0x001D7674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x001D9484 File Offset: 0x001D7684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x001D9494 File Offset: 0x001D7694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x001D94A4 File Offset: 0x001D76A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StatedElementUpdatedEvent other)
		{
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x001D94B4 File Offset: 0x001D76B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x001D94C4 File Offset: 0x001D76C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x001D94D4 File Offset: 0x001D76D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StatedElementUpdatedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					StatedElementUpdatedEvent._parser = new MessageParser<StatedElementUpdatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x001D95B8 File Offset: 0x001D77B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IUHcFhODig3xoMImfuhh()
		{
			return true;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x001D95C0 File Offset: 0x001D77C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StatedElementUpdatedEvent eZKynyODPXEFkAvTsLmg()
		{
			return null;
		}

		// Token: 0x04001249 RID: 4681
		private static readonly MessageParser<StatedElementUpdatedEvent> _parser;

		// Token: 0x0400124A RID: 4682
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400124B RID: 4683
		public const int StatedElementFieldNumber = 1;

		// Token: 0x0400124C RID: 4684
		private StatedElement statedElement_;

		// Token: 0x0400124D RID: 4685
		private static StatedElementUpdatedEvent YCLF45ODb5Q5t4vbo1BB;
	}
}
