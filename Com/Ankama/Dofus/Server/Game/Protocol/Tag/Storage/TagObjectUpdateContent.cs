using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000F0 RID: 240
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TagObjectUpdateContent : IMessage<TagObjectUpdateContent>, IMessage, IEquatable<TagObjectUpdateContent>, IDeepCloneable<TagObjectUpdateContent>, IBufferMessage
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00194BE8 File Offset: 0x00192DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TagObjectUpdateContent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00194BF8 File Offset: 0x00192DF8
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00194C08 File Offset: 0x00192E08
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

		// Token: 0x06000ADB RID: 2779 RVA: 0x00194C18 File Offset: 0x00192E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectUpdateContent()
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00194C28 File Offset: 0x00192E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectUpdateContent(TagObjectUpdateContent other)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00194C38 File Offset: 0x00192E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagObjectUpdateContent Clone()
		{
			return null;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00194C48 File Offset: 0x00192E48
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00194C58 File Offset: 0x00192E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TagStorageUuid
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00194C68 File Offset: 0x00192E68
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00194C78 File Offset: 0x00192E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectId
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

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00194C88 File Offset: 0x00192E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00194C98 File Offset: 0x00192E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TagObjectUpdateContent other)
		{
			return true;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00194CA8 File Offset: 0x00192EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00194CB8 File Offset: 0x00192EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00194CC8 File Offset: 0x00192EC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00194CD8 File Offset: 0x00192ED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00194CE8 File Offset: 0x00192EE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00194CF8 File Offset: 0x00192EF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TagObjectUpdateContent other)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00194D08 File Offset: 0x00192F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00194D18 File Offset: 0x00192F18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00194D28 File Offset: 0x00192F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TagObjectUpdateContent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				TagObjectUpdateContent._parser = new MessageParser<TagObjectUpdateContent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00194E0C File Offset: 0x0019300C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QUTWDwOlXpVnEgNpRJgB()
		{
			return true;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00194E14 File Offset: 0x00193014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TagObjectUpdateContent G6GPwcOlNpw12U6eOCu3()
		{
			return null;
		}

		// Token: 0x040003FA RID: 1018
		private static readonly MessageParser<TagObjectUpdateContent> _parser;

		// Token: 0x040003FB RID: 1019
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003FC RID: 1020
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x040003FD RID: 1021
		private string tagStorageUuid_;

		// Token: 0x040003FE RID: 1022
		public const int ObjectIdFieldNumber = 2;

		// Token: 0x040003FF RID: 1023
		private int objectId_;

		// Token: 0x04000400 RID: 1024
		private static TagObjectUpdateContent kBmEpYOlEdYoirxH0fly;
	}
}
