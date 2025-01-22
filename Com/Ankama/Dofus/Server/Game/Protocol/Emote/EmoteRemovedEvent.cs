using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007BF RID: 1983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmoteRemovedEvent : IMessage<EmoteRemovedEvent>, IMessage, IEquatable<EmoteRemovedEvent>, IDeepCloneable<EmoteRemovedEvent>, IBufferMessage
	{
		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600612A RID: 24874 RVA: 0x00220A20 File Offset: 0x0021EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EmoteRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x00220A30 File Offset: 0x0021EC30
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

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600612C RID: 24876 RVA: 0x00220A40 File Offset: 0x0021EC40
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

		// Token: 0x0600612D RID: 24877 RVA: 0x00220A50 File Offset: 0x0021EC50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteRemovedEvent()
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00220A60 File Offset: 0x0021EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteRemovedEvent(EmoteRemovedEvent other)
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00220A70 File Offset: 0x0021EC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmoteRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06006130 RID: 24880 RVA: 0x00220A80 File Offset: 0x0021EC80
		// (set) Token: 0x06006131 RID: 24881 RVA: 0x00220A90 File Offset: 0x0021EC90
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

		// Token: 0x06006132 RID: 24882 RVA: 0x00220AA0 File Offset: 0x0021ECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00220AB0 File Offset: 0x0021ECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmoteRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00220AC0 File Offset: 0x0021ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00220AD0 File Offset: 0x0021ECD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x00220AE0 File Offset: 0x0021ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00220AF0 File Offset: 0x0021ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x00220B00 File Offset: 0x0021ED00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x00220B10 File Offset: 0x0021ED10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmoteRemovedEvent other)
		{
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x00220B20 File Offset: 0x0021ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x00220B30 File Offset: 0x0021ED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00220B40 File Offset: 0x0021ED40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmoteRemovedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					EmoteRemovedEvent._parser = new MessageParser<EmoteRemovedEvent>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x00220C0C File Offset: 0x0021EE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TGcfSIOFnFckG9By27A6()
		{
			return true;
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00220C14 File Offset: 0x0021EE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmoteRemovedEvent DDZZjnOFmLFtG4hYwA7L()
		{
			return null;
		}

		// Token: 0x04002226 RID: 8742
		private static readonly MessageParser<EmoteRemovedEvent> _parser;

		// Token: 0x04002227 RID: 8743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002228 RID: 8744
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04002229 RID: 8745
		private int emoteId_;

		// Token: 0x0400222A RID: 8746
		internal static EmoteRemovedEvent CaBg8qOFf8178CWl2XI2;
	}
}
