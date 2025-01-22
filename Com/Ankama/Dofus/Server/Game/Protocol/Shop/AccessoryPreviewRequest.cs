using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop
{
	// Token: 0x0200015A RID: 346
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccessoryPreviewRequest : IMessage<AccessoryPreviewRequest>, IMessage, IEquatable<AccessoryPreviewRequest>, IDeepCloneable<AccessoryPreviewRequest>, IBufferMessage
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0019D828 File Offset: 0x0019BA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccessoryPreviewRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0019D838 File Offset: 0x0019BA38
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0019D848 File Offset: 0x0019BA48
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

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0019D858 File Offset: 0x0019BA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewRequest()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0019D868 File Offset: 0x0019BA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewRequest(AccessoryPreviewRequest other)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0019D878 File Offset: 0x0019BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewRequest Clone()
		{
			return null;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0019D888 File Offset: 0x0019BA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectGid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0019D898 File Offset: 0x0019BA98
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x0019D8A8 File Offset: 0x0019BAA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool ShowCurrentObjects
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

		// Token: 0x06000FED RID: 4077 RVA: 0x0019D8B8 File Offset: 0x0019BAB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0019D8C8 File Offset: 0x0019BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccessoryPreviewRequest other)
		{
			return true;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0019D8D8 File Offset: 0x0019BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0019D8E8 File Offset: 0x0019BAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0019D8F8 File Offset: 0x0019BAF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0019D908 File Offset: 0x0019BB08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0019D918 File Offset: 0x0019BB18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0019D928 File Offset: 0x0019BB28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccessoryPreviewRequest other)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0019D938 File Offset: 0x0019BB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0019D948 File Offset: 0x0019BB48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0019D958 File Offset: 0x0019BB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccessoryPreviewRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AccessoryPreviewRequest._parser = new MessageParser<AccessoryPreviewRequest>(() => null);
					num2 = 5;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					AccessoryPreviewRequest._repeated_objectGid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					break;
				}
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0019DA58 File Offset: 0x0019BC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kco6GAOU0Z3h4xQYPZNC()
		{
			return true;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0019DA60 File Offset: 0x0019BC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccessoryPreviewRequest qsSZRdOUCaG7NNja32Sk()
		{
			return null;
		}

		// Token: 0x040005CA RID: 1482
		private static readonly MessageParser<AccessoryPreviewRequest> _parser;

		// Token: 0x040005CB RID: 1483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005CC RID: 1484
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x040005CD RID: 1485
		private static readonly FieldCodec<int> _repeated_objectGid_codec;

		// Token: 0x040005CE RID: 1486
		private readonly RepeatedField<int> objectGid_;

		// Token: 0x040005CF RID: 1487
		public const int ShowCurrentObjectsFieldNumber = 2;

		// Token: 0x040005D0 RID: 1488
		private bool showCurrentObjects_;

		// Token: 0x040005D1 RID: 1489
		internal static AccessoryPreviewRequest YqQW5nOUVdDhKSG5EfWf;
	}
}
