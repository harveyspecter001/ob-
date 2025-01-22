using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000FA RID: 250
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TagStorageData : IMessage<TagStorageData>, IMessage, IEquatable<TagStorageData>, IDeepCloneable<TagStorageData>, IBufferMessage
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00195670 File Offset: 0x00193870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TagStorageData> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00195680 File Offset: 0x00193880
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00195690 File Offset: 0x00193890
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

		// Token: 0x06000B60 RID: 2912 RVA: 0x001956A0 File Offset: 0x001938A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStorageData()
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x001956B0 File Offset: 0x001938B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStorageData(TagStorageData other)
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x001956C0 File Offset: 0x001938C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagStorageData Clone()
		{
			return null;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x001956D0 File Offset: 0x001938D0
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x001956E0 File Offset: 0x001938E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x001956F0 File Offset: 0x001938F0
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00195700 File Offset: 0x00193900
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00195710 File Offset: 0x00193910
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00195720 File Offset: 0x00193920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Picto
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x00195730 File Offset: 0x00193930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00195740 File Offset: 0x00193940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TagStorageData other)
		{
			return true;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00195750 File Offset: 0x00193950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00195760 File Offset: 0x00193960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00195770 File Offset: 0x00193970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00195780 File Offset: 0x00193980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00195790 File Offset: 0x00193990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x001957A0 File Offset: 0x001939A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TagStorageData other)
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x001957B0 File Offset: 0x001939B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x001957C0 File Offset: 0x001939C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x001957D0 File Offset: 0x001939D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TagStorageData()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
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
					TagStorageData._parser = new MessageParser<TagStorageData>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0019589C File Offset: 0x00193A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z04FM4Ol5HVmroyCx8Q3()
		{
			return true;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x001958A4 File Offset: 0x00193AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TagStorageData vIMdeUOlyKKCVPSvy9sr()
		{
			return null;
		}

		// Token: 0x04000422 RID: 1058
		private static readonly MessageParser<TagStorageData> _parser;

		// Token: 0x04000423 RID: 1059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000424 RID: 1060
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x04000425 RID: 1061
		private string tagStorageUuid_;

		// Token: 0x04000426 RID: 1062
		public const int NameFieldNumber = 2;

		// Token: 0x04000427 RID: 1063
		private string name_;

		// Token: 0x04000428 RID: 1064
		public const int PictoFieldNumber = 3;

		// Token: 0x04000429 RID: 1065
		private int picto_;

		// Token: 0x0400042A RID: 1066
		private static TagStorageData Eyrk2ROlaiRwoAyS6MfT;
	}
}
