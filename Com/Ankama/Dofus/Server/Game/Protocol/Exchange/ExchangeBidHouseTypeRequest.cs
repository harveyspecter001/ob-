using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000709 RID: 1801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseTypeRequest : IMessage<ExchangeBidHouseTypeRequest>, IMessage, IEquatable<ExchangeBidHouseTypeRequest>, IDeepCloneable<ExchangeBidHouseTypeRequest>, IBufferMessage
	{
		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06005813 RID: 22547 RVA: 0x00215AB0 File Offset: 0x00213CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseTypeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x00215AC0 File Offset: 0x00213CC0
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

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06005815 RID: 22549 RVA: 0x00215AD0 File Offset: 0x00213CD0
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

		// Token: 0x06005816 RID: 22550 RVA: 0x00215AE0 File Offset: 0x00213CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseTypeRequest()
		{
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00215AF0 File Offset: 0x00213CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseTypeRequest(ExchangeBidHouseTypeRequest other)
		{
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00215B00 File Offset: 0x00213D00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseTypeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06005819 RID: 22553 RVA: 0x00215B10 File Offset: 0x00213D10
		// (set) Token: 0x0600581A RID: 22554 RVA: 0x00215B20 File Offset: 0x00213D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TypeId
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

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x0600581B RID: 22555 RVA: 0x00215B30 File Offset: 0x00213D30
		// (set) Token: 0x0600581C RID: 22556 RVA: 0x00215B40 File Offset: 0x00213D40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Follow
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

		// Token: 0x0600581D RID: 22557 RVA: 0x00215B50 File Offset: 0x00213D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00215B60 File Offset: 0x00213D60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseTypeRequest other)
		{
			return true;
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00215B70 File Offset: 0x00213D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00215B80 File Offset: 0x00213D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x00215B90 File Offset: 0x00213D90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x00215BA0 File Offset: 0x00213DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00215BB0 File Offset: 0x00213DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x00215BC0 File Offset: 0x00213DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseTypeRequest other)
		{
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00215BD0 File Offset: 0x00213DD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00215BE0 File Offset: 0x00213DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00215BF0 File Offset: 0x00213DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseTypeRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					ExchangeBidHouseTypeRequest._parser = new MessageParser<ExchangeBidHouseTypeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x00215CD4 File Offset: 0x00213ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NkN4E9OuNPp2FpOSHifs()
		{
			return true;
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00215CDC File Offset: 0x00213EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseTypeRequest g0qD8JOux87w6mJiyuD0()
		{
			return null;
		}

		// Token: 0x04001EE3 RID: 7907
		private static readonly MessageParser<ExchangeBidHouseTypeRequest> _parser;

		// Token: 0x04001EE4 RID: 7908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EE5 RID: 7909
		public const int TypeIdFieldNumber = 1;

		// Token: 0x04001EE6 RID: 7910
		private int typeId_;

		// Token: 0x04001EE7 RID: 7911
		public const int FollowFieldNumber = 2;

		// Token: 0x04001EE8 RID: 7912
		private bool follow_;

		// Token: 0x04001EE9 RID: 7913
		private static ExchangeBidHouseTypeRequest olIbtnOuXgjjjXn7HHTe;
	}
}
