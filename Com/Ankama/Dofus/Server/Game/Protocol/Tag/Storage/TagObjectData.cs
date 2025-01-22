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
	// Token: 0x020000FC RID: 252
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TagObjectData : IMessage<TagObjectData>, IMessage, IEquatable<TagObjectData>, IDeepCloneable<TagObjectData>, IBufferMessage
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x001958AC File Offset: 0x00193AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TagObjectData> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x001958BC File Offset: 0x00193ABC
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x001958CC File Offset: 0x00193ACC
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

		// Token: 0x06000B7E RID: 2942 RVA: 0x001958DC File Offset: 0x00193ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectData()
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x001958EC File Offset: 0x00193AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectData(TagObjectData other)
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x001958FC File Offset: 0x00193AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectData Clone()
		{
			return null;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0019590C File Offset: 0x00193B0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> TagObjectUuids
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0019591C File Offset: 0x00193B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0019592C File Offset: 0x00193B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TagObjectData other)
		{
			return true;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0019593C File Offset: 0x00193B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0019594C File Offset: 0x00193B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0019595C File Offset: 0x00193B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0019596C File Offset: 0x00193B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0019597C File Offset: 0x00193B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0019598C File Offset: 0x00193B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TagObjectData other)
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0019599C File Offset: 0x00193B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x001959AC File Offset: 0x00193BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x001959BC File Offset: 0x00193BBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TagObjectData()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					TagObjectData._parser = new MessageParser<TagObjectData>(() => null);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					TagObjectData._repeated_tagObjectUuids_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00195AA8 File Offset: 0x00193CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oFeNhFOlLmrIlI3hdet1()
		{
			return true;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00195AB0 File Offset: 0x00193CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TagObjectData oZenrLOlWVBdtSoTCh0O()
		{
			return null;
		}

		// Token: 0x0400042D RID: 1069
		private static readonly MessageParser<TagObjectData> _parser;

		// Token: 0x0400042E RID: 1070
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400042F RID: 1071
		public const int TagObjectUuidsFieldNumber = 1;

		// Token: 0x04000430 RID: 1072
		private static readonly FieldCodec<int> _repeated_tagObjectUuids_codec;

		// Token: 0x04000431 RID: 1073
		private readonly RepeatedField<int> tagObjectUuids_;

		// Token: 0x04000432 RID: 1074
		internal static TagObjectData u78SJnOl6mGoTjuV4Mpr;
	}
}
