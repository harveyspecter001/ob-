using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000850 RID: 2128
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendAddedEvent : IMessage<FriendAddedEvent>, IMessage, IEquatable<FriendAddedEvent>, IDeepCloneable<FriendAddedEvent>, IBufferMessage
	{
		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x0022D05C File Offset: 0x0022B25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x0022D06C File Offset: 0x0022B26C
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

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x0022D07C File Offset: 0x0022B27C
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

		// Token: 0x06006779 RID: 26489 RVA: 0x0022D08C File Offset: 0x0022B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddedEvent()
		{
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x0022D09C File Offset: 0x0022B29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddedEvent(FriendAddedEvent other)
		{
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x0022D0AC File Offset: 0x0022B2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x0022D0BC File Offset: 0x0022B2BC
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x0022D0CC File Offset: 0x0022B2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendInformation Friend
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

		// Token: 0x0600677E RID: 26494 RVA: 0x0022D0DC File Offset: 0x0022B2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x0022D0EC File Offset: 0x0022B2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendAddedEvent other)
		{
			return true;
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x0022D0FC File Offset: 0x0022B2FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x0022D10C File Offset: 0x0022B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x0022D11C File Offset: 0x0022B31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x0022D12C File Offset: 0x0022B32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x0022D13C File Offset: 0x0022B33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x0022D14C File Offset: 0x0022B34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendAddedEvent other)
		{
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x0022D15C File Offset: 0x0022B35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x0022D16C File Offset: 0x0022B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x0022D17C File Offset: 0x0022B37C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					FriendAddedEvent._parser = new MessageParser<FriendAddedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x0022D274 File Offset: 0x0022B474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yqSk7QJndXHOS7mN93I2()
		{
			return true;
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x0022D27C File Offset: 0x0022B47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendAddedEvent alep1MJn9T65nYlw3lRb()
		{
			return null;
		}

		// Token: 0x0400243D RID: 9277
		private static readonly MessageParser<FriendAddedEvent> _parser;

		// Token: 0x0400243E RID: 9278
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400243F RID: 9279
		public const int FriendFieldNumber = 1;

		// Token: 0x04002440 RID: 9280
		private FriendInformation friend_;

		// Token: 0x04002441 RID: 9281
		private static FriendAddedEvent JWGpnMJnsP9OIu1JuPuL;
	}
}
