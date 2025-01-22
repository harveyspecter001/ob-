using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000071 RID: 113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OrnamentGainedEvent : IMessage<OrnamentGainedEvent>, IMessage, IEquatable<OrnamentGainedEvent>, IDeepCloneable<OrnamentGainedEvent>, IBufferMessage
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x001893A8 File Offset: 0x001875A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OrnamentGainedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x001893B8 File Offset: 0x001875B8
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x001893C8 File Offset: 0x001875C8
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

		// Token: 0x0600046E RID: 1134 RVA: 0x001893D8 File Offset: 0x001875D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentGainedEvent()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x001893E8 File Offset: 0x001875E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentGainedEvent(OrnamentGainedEvent other)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x001893F8 File Offset: 0x001875F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentGainedEvent Clone()
		{
			return null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00189408 File Offset: 0x00187608
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00189418 File Offset: 0x00187618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00189428 File Offset: 0x00187628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00189438 File Offset: 0x00187638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OrnamentGainedEvent other)
		{
			return true;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00189448 File Offset: 0x00187648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00189458 File Offset: 0x00187658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00189468 File Offset: 0x00187668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00189478 File Offset: 0x00187678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00189488 File Offset: 0x00187688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00189498 File Offset: 0x00187698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OrnamentGainedEvent other)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x001894A8 File Offset: 0x001876A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x001894B8 File Offset: 0x001876B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x001894C8 File Offset: 0x001876C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OrnamentGainedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					OrnamentGainedEvent._parser = new MessageParser<OrnamentGainedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00189594 File Offset: 0x00187794
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ipOiDwOKXY86qr8X7TkB()
		{
			return true;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0018959C File Offset: 0x0018779C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OrnamentGainedEvent pEyRVhOKNo6cuEMabeij()
		{
			return null;
		}

		// Token: 0x040001C5 RID: 453
		private static readonly MessageParser<OrnamentGainedEvent> _parser;

		// Token: 0x040001C6 RID: 454
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001C7 RID: 455
		public const int OrnamentIdFieldNumber = 1;

		// Token: 0x040001C8 RID: 456
		private int ornamentId_;

		// Token: 0x040001C9 RID: 457
		private static OrnamentGainedEvent AmT6dPOKEdjL8g9ZqA24;
	}
}
