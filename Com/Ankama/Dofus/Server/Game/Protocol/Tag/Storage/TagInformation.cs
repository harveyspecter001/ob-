using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000F8 RID: 248
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TagInformation : IMessage<TagInformation>, IMessage, IEquatable<TagInformation>, IDeepCloneable<TagInformation>, IBufferMessage
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00195454 File Offset: 0x00193654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TagInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00195464 File Offset: 0x00193664
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00195474 File Offset: 0x00193674
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

		// Token: 0x06000B44 RID: 2884 RVA: 0x00195484 File Offset: 0x00193684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagInformation()
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00195494 File Offset: 0x00193694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagInformation(TagInformation other)
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x001954A4 File Offset: 0x001936A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagInformation Clone()
		{
			return null;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x001954B4 File Offset: 0x001936B4
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x001954C4 File Offset: 0x001936C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagStorageData TagStorageData
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x001954D4 File Offset: 0x001936D4
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x001954E4 File Offset: 0x001936E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagObjectData TagObjectData
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

		// Token: 0x06000B4B RID: 2891 RVA: 0x001954F4 File Offset: 0x001936F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00195504 File Offset: 0x00193704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TagInformation other)
		{
			return true;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00195514 File Offset: 0x00193714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00195524 File Offset: 0x00193724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00195534 File Offset: 0x00193734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00195544 File Offset: 0x00193744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00195554 File Offset: 0x00193754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00195564 File Offset: 0x00193764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TagInformation other)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00195574 File Offset: 0x00193774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00195584 File Offset: 0x00193784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00195594 File Offset: 0x00193794
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TagInformation()
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
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					TagInformation._parser = new MessageParser<TagInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
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

		// Token: 0x06000B56 RID: 2902 RVA: 0x00195660 File Offset: 0x00193860
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O5ZxDwOlodO19i487GWn()
		{
			return true;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00195668 File Offset: 0x00193868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TagInformation dTtnaNOl1EUfmGknTM3h()
		{
			return null;
		}

		// Token: 0x04000419 RID: 1049
		private static readonly MessageParser<TagInformation> _parser;

		// Token: 0x0400041A RID: 1050
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400041B RID: 1051
		public const int TagStorageDataFieldNumber = 1;

		// Token: 0x0400041C RID: 1052
		private TagStorageData tagStorageData_;

		// Token: 0x0400041D RID: 1053
		public const int TagObjectDataFieldNumber = 2;

		// Token: 0x0400041E RID: 1054
		private TagObjectData tagObjectData_;

		// Token: 0x0400041F RID: 1055
		private static TagInformation KlCiSKOlvfhWTrDkyXMY;
	}
}
