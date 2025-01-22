using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000EC RID: 236
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveTagObjectRequest : IMessage<RemoveTagObjectRequest>, IMessage, IEquatable<RemoveTagObjectRequest>, IDeepCloneable<RemoveTagObjectRequest>, IBufferMessage
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0019478C File Offset: 0x0019298C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveTagObjectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0019479C File Offset: 0x0019299C
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x001947AC File Offset: 0x001929AC
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

		// Token: 0x06000AA9 RID: 2729 RVA: 0x001947BC File Offset: 0x001929BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectRequest()
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x001947CC File Offset: 0x001929CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectRequest(RemoveTagObjectRequest other)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x001947DC File Offset: 0x001929DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagObjectRequest Clone()
		{
			return null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x001947EC File Offset: 0x001929EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TagObjectUpdateContent> TagObjectUpdateContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x001947FC File Offset: 0x001929FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0019480C File Offset: 0x00192A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveTagObjectRequest other)
		{
			return true;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0019481C File Offset: 0x00192A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0019482C File Offset: 0x00192A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0019483C File Offset: 0x00192A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0019484C File Offset: 0x00192A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0019485C File Offset: 0x00192A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0019486C File Offset: 0x00192A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveTagObjectRequest other)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0019487C File Offset: 0x00192A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0019488C File Offset: 0x00192A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0019489C File Offset: 0x00192A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveTagObjectRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					RemoveTagObjectRequest._repeated_tagObjectUpdateContent_codec = FieldCodec.ForMessage<TagObjectUpdateContent>(10U, C0EwKkouUZnBXceLuXD.XVInXhlssT(C0EwKkouUZnBXceLuXD.GcYo8ERmhW));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					RemoveTagObjectRequest._parser = new MessageParser<RemoveTagObjectRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0019498C File Offset: 0x00192B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool juAmU8OlgxWra6lK5y8T()
		{
			return true;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00194994 File Offset: 0x00192B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveTagObjectRequest d9Xu5kOlsxPvFhi0HfIn()
		{
			return null;
		}

		// Token: 0x040003EA RID: 1002
		private static readonly MessageParser<RemoveTagObjectRequest> _parser;

		// Token: 0x040003EB RID: 1003
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003EC RID: 1004
		public const int TagObjectUpdateContentFieldNumber = 1;

		// Token: 0x040003ED RID: 1005
		private static readonly FieldCodec<TagObjectUpdateContent> _repeated_tagObjectUpdateContent_codec;

		// Token: 0x040003EE RID: 1006
		private readonly RepeatedField<TagObjectUpdateContent> tagObjectUpdateContent_;

		// Token: 0x040003EF RID: 1007
		private static RemoveTagObjectRequest K2naUEOlG2ew5l82xpHx;
	}
}
