using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000F2 RID: 242
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateTagStorageContentRequest : IMessage<UpdateTagStorageContentRequest>, IMessage, IEquatable<UpdateTagStorageContentRequest>, IDeepCloneable<UpdateTagStorageContentRequest>, IBufferMessage
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00194E1C File Offset: 0x0019301C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateTagStorageContentRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00194E2C File Offset: 0x0019302C
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00194E3C File Offset: 0x0019303C
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

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00194E4C File Offset: 0x0019304C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentRequest()
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00194E5C File Offset: 0x0019305C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentRequest(UpdateTagStorageContentRequest other)
		{
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00194E6C File Offset: 0x0019306C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentRequest Clone()
		{
			return null;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00194E7C File Offset: 0x0019307C
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00194E8C File Offset: 0x0019308C
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

		// Token: 0x06000AFC RID: 2812 RVA: 0x00194E9C File Offset: 0x0019309C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00194EAC File Offset: 0x001930AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UpdateTagStorageContentRequest other)
		{
			return true;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00194EBC File Offset: 0x001930BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00194ECC File Offset: 0x001930CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00194EDC File Offset: 0x001930DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00194EEC File Offset: 0x001930EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00194EFC File Offset: 0x001930FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00194F0C File Offset: 0x0019310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UpdateTagStorageContentRequest other)
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00194F1C File Offset: 0x0019311C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00194F2C File Offset: 0x0019312C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00194F3C File Offset: 0x0019313C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UpdateTagStorageContentRequest()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UpdateTagStorageContentRequest._parser = new MessageParser<UpdateTagStorageContentRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00195020 File Offset: 0x00193220
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DXY9yQOl4U7jxBjZdEhe()
		{
			return true;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00195028 File Offset: 0x00193228
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UpdateTagStorageContentRequest uW6KsEOljkDUS94GTBFH()
		{
			return null;
		}

		// Token: 0x04000403 RID: 1027
		private static readonly MessageParser<UpdateTagStorageContentRequest> _parser;

		// Token: 0x04000404 RID: 1028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000405 RID: 1029
		public const int TagStorageDataFieldNumber = 1;

		// Token: 0x04000406 RID: 1030
		private TagStorageData tagStorageData_;

		// Token: 0x04000407 RID: 1031
		internal static UpdateTagStorageContentRequest DRXV3KOlx6V0yk0XlYcU;
	}
}
