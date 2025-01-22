using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000319 RID: 793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockBuyResultEvent : IMessage<PaddockBuyResultEvent>, IMessage, IEquatable<PaddockBuyResultEvent>, IDeepCloneable<PaddockBuyResultEvent>, IBufferMessage
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x001C0DF4 File Offset: 0x001BEFF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockBuyResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x001C0E04 File Offset: 0x001BF004
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x001C0E14 File Offset: 0x001BF014
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

		// Token: 0x06002549 RID: 9545 RVA: 0x001C0E24 File Offset: 0x001BF024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyResultEvent()
		{
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x001C0E34 File Offset: 0x001BF034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyResultEvent(PaddockBuyResultEvent other)
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x001C0E44 File Offset: 0x001BF044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x001C0E54 File Offset: 0x001BF054
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x001C0E64 File Offset: 0x001BF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PaddockId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x001C0E74 File Offset: 0x001BF074
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x001C0E84 File Offset: 0x001BF084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Bought
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x001C0E94 File Offset: 0x001BF094
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x001C0EA4 File Offset: 0x001BF0A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x001C0EB4 File Offset: 0x001BF0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x001C0EC4 File Offset: 0x001BF0C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockBuyResultEvent other)
		{
			return true;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x001C0ED4 File Offset: 0x001BF0D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x001C0EE4 File Offset: 0x001BF0E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x001C0EF4 File Offset: 0x001BF0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x001C0F04 File Offset: 0x001BF104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x001C0F14 File Offset: 0x001BF114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x001C0F24 File Offset: 0x001BF124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockBuyResultEvent other)
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x001C0F34 File Offset: 0x001BF134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x001C0F44 File Offset: 0x001BF144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x001C0F54 File Offset: 0x001BF154
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockBuyResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						goto IL_36;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						break;
					case 4:
						PaddockBuyResultEvent._parser = new MessageParser<PaddockBuyResultEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_36:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x001C1024 File Offset: 0x001BF224
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g7YdgZOWlR2xPRnZZwNO()
		{
			return true;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x001C102C File Offset: 0x001BF22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockBuyResultEvent mGv0eiOWcFtxtiygBe73()
		{
			return null;
		}

		// Token: 0x04000D39 RID: 3385
		private static readonly MessageParser<PaddockBuyResultEvent> _parser;

		// Token: 0x04000D3A RID: 3386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D3B RID: 3387
		public const int PaddockIdFieldNumber = 1;

		// Token: 0x04000D3C RID: 3388
		private long paddockId_;

		// Token: 0x04000D3D RID: 3389
		public const int BoughtFieldNumber = 2;

		// Token: 0x04000D3E RID: 3390
		private bool bought_;

		// Token: 0x04000D3F RID: 3391
		public const int PriceFieldNumber = 3;

		// Token: 0x04000D40 RID: 3392
		private long price_;

		// Token: 0x04000D41 RID: 3393
		private static PaddockBuyResultEvent P0FT3bOWkOq91hAJIZRK;
	}
}
