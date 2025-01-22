using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000315 RID: 789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockObjectAddedEvent : IMessage<PaddockObjectAddedEvent>, IMessage, IEquatable<PaddockObjectAddedEvent>, IDeepCloneable<PaddockObjectAddedEvent>, IBufferMessage
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x001C09E8 File Offset: 0x001BEBE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockObjectAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x001C09F8 File Offset: 0x001BEBF8
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x001C0A08 File Offset: 0x001BEC08
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

		// Token: 0x06002516 RID: 9494 RVA: 0x001C0A18 File Offset: 0x001BEC18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAddedEvent()
		{
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x001C0A28 File Offset: 0x001BEC28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAddedEvent(PaddockObjectAddedEvent other)
		{
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x001C0A38 File Offset: 0x001BEC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x001C0A48 File Offset: 0x001BEC48
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x001C0A58 File Offset: 0x001BEC58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectInRolePlay PaddockItem
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

		// Token: 0x0600251B RID: 9499 RVA: 0x001C0A68 File Offset: 0x001BEC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x001C0A78 File Offset: 0x001BEC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockObjectAddedEvent other)
		{
			return true;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x001C0A88 File Offset: 0x001BEC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x001C0A98 File Offset: 0x001BEC98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x001C0AA8 File Offset: 0x001BECA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x001C0AB8 File Offset: 0x001BECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x001C0AC8 File Offset: 0x001BECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x001C0AD8 File Offset: 0x001BECD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockObjectAddedEvent other)
		{
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x001C0AE8 File Offset: 0x001BECE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x001C0AF8 File Offset: 0x001BECF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x001C0B08 File Offset: 0x001BED08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockObjectAddedEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					PaddockObjectAddedEvent._parser = new MessageParser<PaddockObjectAddedEvent>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x001C0BD4 File Offset: 0x001BEDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sJGjEfOWx8ec7E07YpBv()
		{
			return true;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x001C0BDC File Offset: 0x001BEDDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockObjectAddedEvent nSYVZKOW4OU3GwW30Oy5()
		{
			return null;
		}

		// Token: 0x04000D2A RID: 3370
		private static readonly MessageParser<PaddockObjectAddedEvent> _parser;

		// Token: 0x04000D2B RID: 3371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D2C RID: 3372
		public const int PaddockItemFieldNumber = 1;

		// Token: 0x04000D2D RID: 3373
		private ObjectInRolePlay paddockItem_;

		// Token: 0x04000D2E RID: 3374
		internal static PaddockObjectAddedEvent A6km4bOWNbeI6qUtGCB1;
	}
}
