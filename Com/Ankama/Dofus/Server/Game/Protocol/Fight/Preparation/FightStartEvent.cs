using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006BD RID: 1725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightStartEvent : IMessage<FightStartEvent>, IMessage, IEquatable<FightStartEvent>, IDeepCloneable<FightStartEvent>, IBufferMessage
	{
		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x0020ADA8 File Offset: 0x00208FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightStartEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x0020ADB8 File Offset: 0x00208FB8
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

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x0020ADC8 File Offset: 0x00208FC8
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

		// Token: 0x0600545A RID: 21594 RVA: 0x0020ADD8 File Offset: 0x00208FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartEvent()
		{
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x0020ADE8 File Offset: 0x00208FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartEvent(FightStartEvent other)
		{
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x0020ADF8 File Offset: 0x00208FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightStartEvent Clone()
		{
			return null;
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x0020AE08 File Offset: 0x00209008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x0020AE18 File Offset: 0x00209018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightStartEvent other)
		{
			return true;
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0020AE28 File Offset: 0x00209028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0020AE38 File Offset: 0x00209038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0020AE48 File Offset: 0x00209048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0020AE58 File Offset: 0x00209058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0020AE68 File Offset: 0x00209068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0020AE78 File Offset: 0x00209078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightStartEvent other)
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x0020AE88 File Offset: 0x00209088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x0020AE98 File Offset: 0x00209098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x0020AEA8 File Offset: 0x002090A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightStartEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					FightStartEvent._parser = new MessageParser<FightStartEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x0020AF8C File Offset: 0x0020918C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ey1imlOS6jbSw8BGESAR()
		{
			return true;
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x0020AF94 File Offset: 0x00209194
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightStartEvent lBSIMUOSLq3kddmMl51t()
		{
			return null;
		}

		// Token: 0x04001DB7 RID: 7607
		private static readonly MessageParser<FightStartEvent> _parser;

		// Token: 0x04001DB8 RID: 7608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DB9 RID: 7609
		internal static FightStartEvent GB1pCrOSykKQMSWmY9uA;
	}
}
