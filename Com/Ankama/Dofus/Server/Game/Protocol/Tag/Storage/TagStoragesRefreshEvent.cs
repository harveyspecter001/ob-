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
	// Token: 0x020000F6 RID: 246
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TagStoragesRefreshEvent : IMessage<TagStoragesRefreshEvent>, IMessage, IEquatable<TagStoragesRefreshEvent>, IDeepCloneable<TagStoragesRefreshEvent>, IBufferMessage
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00195244 File Offset: 0x00193444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TagStoragesRefreshEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00195254 File Offset: 0x00193454
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00195264 File Offset: 0x00193464
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

		// Token: 0x06000B2B RID: 2859 RVA: 0x00195274 File Offset: 0x00193474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStoragesRefreshEvent()
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00195284 File Offset: 0x00193484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStoragesRefreshEvent(TagStoragesRefreshEvent other)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00195294 File Offset: 0x00193494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStoragesRefreshEvent Clone()
		{
			return null;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x001952A4 File Offset: 0x001934A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TagInformation> TagInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x001952B4 File Offset: 0x001934B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x001952C4 File Offset: 0x001934C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TagStoragesRefreshEvent other)
		{
			return true;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x001952D4 File Offset: 0x001934D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x001952E4 File Offset: 0x001934E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x001952F4 File Offset: 0x001934F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00195304 File Offset: 0x00193504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00195314 File Offset: 0x00193514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00195324 File Offset: 0x00193524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TagStoragesRefreshEvent other)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00195334 File Offset: 0x00193534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00195344 File Offset: 0x00193544
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00195354 File Offset: 0x00193554
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TagStoragesRefreshEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TagStoragesRefreshEvent._parser = new MessageParser<TagStoragesRefreshEvent>(() => null);
					num2 = 5;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				case 5:
					TagStoragesRefreshEvent._repeated_tagInformation_codec = FieldCodec.ForMessage<TagInformation>(10U, JM2aJy1mSspRICq7Ojk.XVInXhlssT(JM2aJy1mSspRICq7Ojk.FRw1A5FLrI));
					num2 = 4;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00195444 File Offset: 0x00193644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dvJLCbOlcOjiuH3IMYEf()
		{
			return true;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0019544C File Offset: 0x0019364C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TagStoragesRefreshEvent jmn62WOlUYE6K5ymibGO()
		{
			return null;
		}

		// Token: 0x04000411 RID: 1041
		private static readonly MessageParser<TagStoragesRefreshEvent> _parser;

		// Token: 0x04000412 RID: 1042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000413 RID: 1043
		public const int TagInformationFieldNumber = 1;

		// Token: 0x04000414 RID: 1044
		private static readonly FieldCodec<TagInformation> _repeated_tagInformation_codec;

		// Token: 0x04000415 RID: 1045
		private readonly RepeatedField<TagInformation> tagInformation_;

		// Token: 0x04000416 RID: 1046
		internal static TagStoragesRefreshEvent GnMRR9OllkaEipHMCWfh;
	}
}
