using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf.Reflection;

namespace Google.Protobuf
{
	// Token: 0x02000023 RID: 35
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>, IBufferMessage
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00183C04 File Offset: 0x00181E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Any> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00183C14 File Offset: 0x00181E14
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00183C24 File Offset: 0x00181E24
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

		// Token: 0x0600012E RID: 302 RVA: 0x00183C34 File Offset: 0x00181E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Any()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00183C44 File Offset: 0x00181E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Any(Any other)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00183C54 File Offset: 0x00181E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Any Clone()
		{
			return null;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00183C64 File Offset: 0x00181E64
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00183C74 File Offset: 0x00181E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeUrl
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00183C84 File Offset: 0x00181E84
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00183C94 File Offset: 0x00181E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Value
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

		// Token: 0x06000135 RID: 309 RVA: 0x00183CA4 File Offset: 0x00181EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00183CB4 File Offset: 0x00181EB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Any other)
		{
			return true;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00183CC4 File Offset: 0x00181EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00183CD4 File Offset: 0x00181ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00183CE4 File Offset: 0x00181EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00183CF4 File Offset: 0x00181EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00183D04 File Offset: 0x00181F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00183D14 File Offset: 0x00181F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Any other)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00183D24 File Offset: 0x00181F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00183D34 File Offset: 0x00181F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00183D44 File Offset: 0x00181F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Any()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					Any._parser = new MessageParser<Any>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00183E3C File Offset: 0x0018203C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C4lDhKO48aVLBGTqNIfK()
		{
			return true;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00183E44 File Offset: 0x00182044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Any u4MJnCO4Z44b54DWdQHl()
		{
			return null;
		}

		// Token: 0x04000083 RID: 131
		private static readonly MessageParser<Any> _parser;

		// Token: 0x04000084 RID: 132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000085 RID: 133
		public const int TypeUrlFieldNumber = 1;

		// Token: 0x04000086 RID: 134
		private string typeUrl_;

		// Token: 0x04000087 RID: 135
		public const int ValueFieldNumber = 2;

		// Token: 0x04000088 RID: 136
		private ByteString value_;

		// Token: 0x04000089 RID: 137
		private static Any kH0VInO4uOHRvwptsGQV;
	}
}
