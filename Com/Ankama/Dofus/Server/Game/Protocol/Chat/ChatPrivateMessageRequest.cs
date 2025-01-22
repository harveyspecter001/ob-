using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008CF RID: 2255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatPrivateMessageRequest : IMessage<ChatPrivateMessageRequest>, IMessage, IEquatable<ChatPrivateMessageRequest>, IDeepCloneable<ChatPrivateMessageRequest>, IBufferMessage
	{
		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06006D85 RID: 28037 RVA: 0x00235590 File Offset: 0x00233790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChatPrivateMessageRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06006D86 RID: 28038 RVA: 0x002355A0 File Offset: 0x002337A0
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

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x002355B0 File Offset: 0x002337B0
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

		// Token: 0x06006D88 RID: 28040 RVA: 0x002355C0 File Offset: 0x002337C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateMessageRequest()
		{
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x002355D0 File Offset: 0x002337D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateMessageRequest(ChatPrivateMessageRequest other)
		{
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x002355E0 File Offset: 0x002337E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateMessageRequest Clone()
		{
			return null;
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06006D8B RID: 28043 RVA: 0x002355F0 File Offset: 0x002337F0
		// (set) Token: 0x06006D8C RID: 28044 RVA: 0x00235600 File Offset: 0x00233800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
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

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06006D8D RID: 28045 RVA: 0x00235610 File Offset: 0x00233810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x00235620 File Offset: 0x00233820
		// (set) Token: 0x06006D8F RID: 28047 RVA: 0x00235630 File Offset: 0x00233830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x00235640 File Offset: 0x00233840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x00235650 File Offset: 0x00233850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearName()
		{
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x00235660 File Offset: 0x00233860
		// (set) Token: 0x06006D93 RID: 28051 RVA: 0x00235670 File Offset: 0x00233870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AccountTag Tag
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x00235680 File Offset: 0x00233880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ChatPrivateMessageRequest.TargetOneofCase TargetCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChatPrivateMessageRequest.TargetOneofCase)null;
			}
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x00235694 File Offset: 0x00233894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearTarget()
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x002356A4 File Offset: 0x002338A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x002356B4 File Offset: 0x002338B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatPrivateMessageRequest other)
		{
			return true;
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x002356C4 File Offset: 0x002338C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x002356D4 File Offset: 0x002338D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x002356E4 File Offset: 0x002338E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x002356F4 File Offset: 0x002338F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x00235704 File Offset: 0x00233904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x00235714 File Offset: 0x00233914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatPrivateMessageRequest other)
		{
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x00235724 File Offset: 0x00233924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x00235734 File Offset: 0x00233934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00235744 File Offset: 0x00233944
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatPrivateMessageRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ChatPrivateMessageRequest._repeated_object_codec = FieldCodec.ForMessage<ObjectItemInventory>(18U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 3;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				ChatPrivateMessageRequest._parser = new MessageParser<ChatPrivateMessageRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0023584C File Offset: 0x00233A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NLmMSGJAD84gg8DVme5m()
		{
			return true;
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00235854 File Offset: 0x00233A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatPrivateMessageRequest TS384vJAtEiS7f4baqjC()
		{
			return null;
		}

		// Token: 0x04002640 RID: 9792
		private static readonly MessageParser<ChatPrivateMessageRequest> _parser;

		// Token: 0x04002641 RID: 9793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002642 RID: 9794
		public const int ContentFieldNumber = 1;

		// Token: 0x04002643 RID: 9795
		private string content_;

		// Token: 0x04002644 RID: 9796
		public const int ObjectFieldNumber = 2;

		// Token: 0x04002645 RID: 9797
		private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

		// Token: 0x04002646 RID: 9798
		private readonly RepeatedField<ObjectItemInventory> object_;

		// Token: 0x04002647 RID: 9799
		public const int NameFieldNumber = 3;

		// Token: 0x04002648 RID: 9800
		public const int TagFieldNumber = 4;

		// Token: 0x04002649 RID: 9801
		private object target_;

		// Token: 0x0400264A RID: 9802
		private ChatPrivateMessageRequest.TargetOneofCase targetCase_;

		// Token: 0x0400264B RID: 9803
		private static ChatPrivateMessageRequest H8kvsOJACXsMv4xv8V9w;

		// Token: 0x020008D0 RID: 2256
		public enum TargetOneofCase
		{
			// Token: 0x0400264D RID: 9805
			None,
			// Token: 0x0400264E RID: 9806
			Name = 3,
			// Token: 0x0400264F RID: 9807
			Tag
		}
	}
}
