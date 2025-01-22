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
	// Token: 0x0200044A RID: 1098
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveElementUpdatedEvent : IMessage<InteractiveElementUpdatedEvent>, IMessage, IEquatable<InteractiveElementUpdatedEvent>, IDeepCloneable<InteractiveElementUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x001D91A0 File Offset: 0x001D73A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<InteractiveElementUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x001D91B0 File Offset: 0x001D73B0
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x001D91C0 File Offset: 0x001D73C0
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

		// Token: 0x06003433 RID: 13363 RVA: 0x001D91D0 File Offset: 0x001D73D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElementUpdatedEvent()
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x001D91E0 File Offset: 0x001D73E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElementUpdatedEvent(InteractiveElementUpdatedEvent other)
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x001D91F0 File Offset: 0x001D73F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElementUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x001D9200 File Offset: 0x001D7400
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x001D9210 File Offset: 0x001D7410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public InteractiveElement InteractiveElement
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

		// Token: 0x06003438 RID: 13368 RVA: 0x001D9220 File Offset: 0x001D7420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x001D9230 File Offset: 0x001D7430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveElementUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x001D9240 File Offset: 0x001D7440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x001D9250 File Offset: 0x001D7450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x001D9260 File Offset: 0x001D7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x001D9270 File Offset: 0x001D7470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x001D9280 File Offset: 0x001D7480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x001D9290 File Offset: 0x001D7490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveElementUpdatedEvent other)
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x001D92A0 File Offset: 0x001D74A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x001D92B0 File Offset: 0x001D74B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x001D92C0 File Offset: 0x001D74C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveElementUpdatedEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
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
					InteractiveElementUpdatedEvent._parser = new MessageParser<InteractiveElementUpdatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x001D93A4 File Offset: 0x001D75A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u1xCl3ODHCUB5TYABaDZ()
		{
			return true;
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x001D93AC File Offset: 0x001D75AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveElementUpdatedEvent d414TGODYktp8FH7wc1w()
		{
			return null;
		}

		// Token: 0x04001242 RID: 4674
		private static readonly MessageParser<InteractiveElementUpdatedEvent> _parser;

		// Token: 0x04001243 RID: 4675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001244 RID: 4676
		public const int InteractiveElementFieldNumber = 1;

		// Token: 0x04001245 RID: 4677
		private InteractiveElement interactiveElement_;

		// Token: 0x04001246 RID: 4678
		internal static InteractiveElementUpdatedEvent hPKnQMODpOJywMYf6Ntc;
	}
}
