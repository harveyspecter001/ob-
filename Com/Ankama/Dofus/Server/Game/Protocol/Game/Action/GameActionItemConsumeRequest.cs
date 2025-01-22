using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005B7 RID: 1463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionItemConsumeRequest : IMessage<GameActionItemConsumeRequest>, IMessage, IEquatable<GameActionItemConsumeRequest>, IDeepCloneable<GameActionItemConsumeRequest>, IBufferMessage
	{
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x001FD344 File Offset: 0x001FB544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameActionItemConsumeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x001FD354 File Offset: 0x001FB554
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x001FD364 File Offset: 0x001FB564
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

		// Token: 0x06004681 RID: 18049 RVA: 0x001FD374 File Offset: 0x001FB574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeRequest()
		{
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x001FD384 File Offset: 0x001FB584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeRequest(GameActionItemConsumeRequest other)
		{
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x001FD394 File Offset: 0x001FB594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItemConsumeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x001FD3A4 File Offset: 0x001FB5A4
		// (set) Token: 0x06004685 RID: 18053 RVA: 0x001FD3B4 File Offset: 0x001FB5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x001FD3C4 File Offset: 0x001FB5C4
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x001FD3D4 File Offset: 0x001FB5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06004688 RID: 18056 RVA: 0x001FD3E4 File Offset: 0x001FB5E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x001FD3F4 File Offset: 0x001FB5F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionItemConsumeRequest other)
		{
			return true;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x001FD404 File Offset: 0x001FB604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x001FD414 File Offset: 0x001FB614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x001FD424 File Offset: 0x001FB624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x001FD434 File Offset: 0x001FB634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x001FD444 File Offset: 0x001FB644
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x001FD454 File Offset: 0x001FB654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionItemConsumeRequest other)
		{
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x001FD464 File Offset: 0x001FB664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x001FD474 File Offset: 0x001FB674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x001FD484 File Offset: 0x001FB684
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionItemConsumeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GameActionItemConsumeRequest._parser = new MessageParser<GameActionItemConsumeRequest>(() => null);
					num2 = 3;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x001FD550 File Offset: 0x001FB750
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nTU0yHObleQi8l8FX7Ra()
		{
			return true;
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x001FD558 File Offset: 0x001FB758
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionItemConsumeRequest CDEHUvObcIk4UdrZxO9x()
		{
			return null;
		}

		// Token: 0x04001873 RID: 6259
		private static readonly MessageParser<GameActionItemConsumeRequest> _parser;

		// Token: 0x04001874 RID: 6260
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001875 RID: 6261
		public const int ActionIdFieldNumber = 1;

		// Token: 0x04001876 RID: 6262
		private int actionId_;

		// Token: 0x04001877 RID: 6263
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04001878 RID: 6264
		private long playerId_;

		// Token: 0x04001879 RID: 6265
		internal static GameActionItemConsumeRequest GPe1MgObk6okRXMcpIxM;
	}
}
