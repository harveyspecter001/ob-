using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol
{
	// Token: 0x0200002D RID: 45
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Event : IMessage<Event>, IMessage, IEquatable<Event>, IDeepCloneable<Event>, IBufferMessage
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00184A18 File Offset: 0x00182C18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Event> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00184A28 File Offset: 0x00182C28
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00184A38 File Offset: 0x00182C38
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

		// Token: 0x060001A6 RID: 422 RVA: 0x00184A48 File Offset: 0x00182C48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00184A58 File Offset: 0x00182C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event(Event other)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00184A68 File Offset: 0x00182C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Event Clone()
		{
			return null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00184A78 File Offset: 0x00182C78
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00184A88 File Offset: 0x00182C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Content
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

		// Token: 0x060001AB RID: 427 RVA: 0x00184A98 File Offset: 0x00182C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00184AA8 File Offset: 0x00182CA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Event other)
		{
			return true;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00184AB8 File Offset: 0x00182CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00184AC8 File Offset: 0x00182CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00184AD8 File Offset: 0x00182CD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00184AE8 File Offset: 0x00182CE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00184AF8 File Offset: 0x00182CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00184B08 File Offset: 0x00182D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Event other)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00184B18 File Offset: 0x00182D18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00184B28 File Offset: 0x00182D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00184B38 File Offset: 0x00182D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Event()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					Event._parser = new MessageParser<Event>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00184C30 File Offset: 0x00182E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IxJRsVOjGElYoLwHmXyR()
		{
			return true;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00184C38 File Offset: 0x00182E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Event JCv1SBOjgeEDgB5NcIaS()
		{
			return null;
		}

		// Token: 0x040000AF RID: 175
		private static readonly MessageParser<Event> _parser;

		// Token: 0x040000B0 RID: 176
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000B1 RID: 177
		public const int ContentFieldNumber = 1;

		// Token: 0x040000B2 RID: 178
		private Any content_;

		// Token: 0x040000B3 RID: 179
		private static Event hn6BYjOjJ6DZYWvtKdLJ;
	}
}
