using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200097B RID: 2427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRoomLockedEvent : IMessage<BreachRoomLockedEvent>, IMessage, IEquatable<BreachRoomLockedEvent>, IDeepCloneable<BreachRoomLockedEvent>, IBufferMessage
	{
		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x00243030 File Offset: 0x00241230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachRoomLockedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x00243040 File Offset: 0x00241240
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

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x00243050 File Offset: 0x00241250
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

		// Token: 0x06007587 RID: 30087 RVA: 0x00243060 File Offset: 0x00241260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomLockedEvent()
		{
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00243070 File Offset: 0x00241270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomLockedEvent(BreachRoomLockedEvent other)
		{
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00243080 File Offset: 0x00241280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomLockedEvent Clone()
		{
			return null;
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00243090 File Offset: 0x00241290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x002430A0 File Offset: 0x002412A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRoomLockedEvent other)
		{
			return true;
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x002430B0 File Offset: 0x002412B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x002430C0 File Offset: 0x002412C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x002430D0 File Offset: 0x002412D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x002430E0 File Offset: 0x002412E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x002430F0 File Offset: 0x002412F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00243100 File Offset: 0x00241300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRoomLockedEvent other)
		{
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00243110 File Offset: 0x00241310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00243120 File Offset: 0x00241320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00243130 File Offset: 0x00241330
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRoomLockedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					BreachRoomLockedEvent._parser = new MessageParser<BreachRoomLockedEvent>(() => null);
					num2 = 4;
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x002431FC File Offset: 0x002413FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FUNBE4JRvi5JH7wJSdfh()
		{
			return true;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00243204 File Offset: 0x00241404
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRoomLockedEvent PtTjsnJRoj2JI5GLVTgj()
		{
			return null;
		}

		// Token: 0x040028EB RID: 10475
		private static readonly MessageParser<BreachRoomLockedEvent> _parser;

		// Token: 0x040028EC RID: 10476
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028ED RID: 10477
		internal static BreachRoomLockedEvent oyHL6yJRUMvYi2kdJZxk;
	}
}
