using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007B9 RID: 1977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmotePlayRequest : IMessage<EmotePlayRequest>, IMessage, IEquatable<EmotePlayRequest>, IDeepCloneable<EmotePlayRequest>, IBufferMessage
	{
		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060060DB RID: 24795 RVA: 0x002203BC File Offset: 0x0021E5BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EmotePlayRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060060DC RID: 24796 RVA: 0x002203CC File Offset: 0x0021E5CC
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060060DD RID: 24797 RVA: 0x002203DC File Offset: 0x0021E5DC
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

		// Token: 0x060060DE RID: 24798 RVA: 0x002203EC File Offset: 0x0021E5EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayRequest()
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x002203FC File Offset: 0x0021E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayRequest(EmotePlayRequest other)
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x0022040C File Offset: 0x0021E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayRequest Clone()
		{
			return null;
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x0022041C File Offset: 0x0021E61C
		// (set) Token: 0x060060E2 RID: 24802 RVA: 0x0022042C File Offset: 0x0021E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EmoteId
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060060E3 RID: 24803 RVA: 0x0022043C File Offset: 0x0021E63C
		// (set) Token: 0x060060E4 RID: 24804 RVA: 0x0022044C File Offset: 0x0021E64C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool OnlyPlayEmote
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

		// Token: 0x060060E5 RID: 24805 RVA: 0x0022045C File Offset: 0x0021E65C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x0022046C File Offset: 0x0021E66C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmotePlayRequest other)
		{
			return true;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x0022047C File Offset: 0x0021E67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x0022048C File Offset: 0x0021E68C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x0022049C File Offset: 0x0021E69C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x002204AC File Offset: 0x0021E6AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x002204BC File Offset: 0x0021E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x002204CC File Offset: 0x0021E6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmotePlayRequest other)
		{
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x002204DC File Offset: 0x0021E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x002204EC File Offset: 0x0021E6EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x002204FC File Offset: 0x0021E6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmotePlayRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					EmotePlayRequest._parser = new MessageParser<EmotePlayRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x002205C8 File Offset: 0x0021E7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vTHG7UOqSNpFuJKkkeE6()
		{
			return true;
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x002205D0 File Offset: 0x0021E7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmotePlayRequest dxs2eKOqMrDbnFbkR4lK()
		{
			return null;
		}

		// Token: 0x0400220E RID: 8718
		private static readonly MessageParser<EmotePlayRequest> _parser;

		// Token: 0x0400220F RID: 8719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002210 RID: 8720
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04002211 RID: 8721
		private int emoteId_;

		// Token: 0x04002212 RID: 8722
		public const int OnlyPlayEmoteFieldNumber = 2;

		// Token: 0x04002213 RID: 8723
		private bool onlyPlayEmote_;

		// Token: 0x04002214 RID: 8724
		private static EmotePlayRequest dRIiZyOqPxlYNh6NAdP8;
	}
}
