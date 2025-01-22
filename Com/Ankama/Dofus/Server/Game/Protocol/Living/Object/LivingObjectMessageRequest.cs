using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object
{
	// Token: 0x0200039C RID: 924
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LivingObjectMessageRequest : IMessage<LivingObjectMessageRequest>, IMessage, IEquatable<LivingObjectMessageRequest>, IDeepCloneable<LivingObjectMessageRequest>, IBufferMessage
	{
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x001CA56C File Offset: 0x001C876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivingObjectMessageRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x001CA57C File Offset: 0x001C877C
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

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x001CA58C File Offset: 0x001C878C
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

		// Token: 0x06002B44 RID: 11076 RVA: 0x001CA59C File Offset: 0x001C879C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageRequest()
		{
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x001CA5AC File Offset: 0x001C87AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageRequest(LivingObjectMessageRequest other)
		{
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x001CA5BC File Offset: 0x001C87BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectMessageRequest Clone()
		{
			return null;
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x001CA5CC File Offset: 0x001C87CC
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x001CA5DC File Offset: 0x001C87DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MessageId
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x001CA5EC File Offset: 0x001C87EC
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x001CA5FC File Offset: 0x001C87FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x06002B4B RID: 11083 RVA: 0x001CA60C File Offset: 0x001C880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x001CA61C File Offset: 0x001C881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LivingObjectMessageRequest other)
		{
			return true;
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x001CA62C File Offset: 0x001C882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x001CA63C File Offset: 0x001C883C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x001CA64C File Offset: 0x001C884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x001CA65C File Offset: 0x001C885C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x001CA66C File Offset: 0x001C886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x001CA67C File Offset: 0x001C887C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LivingObjectMessageRequest other)
		{
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x001CA68C File Offset: 0x001C888C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x001CA69C File Offset: 0x001C889C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x001CA6AC File Offset: 0x001C88AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LivingObjectMessageRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					LivingObjectMessageRequest._parser = new MessageParser<LivingObjectMessageRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x001CA7A4 File Offset: 0x001C89A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GkLcawOVn6DLkpfx4cUd()
		{
			return true;
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x001CA7AC File Offset: 0x001C89AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LivingObjectMessageRequest HXTrflOVmeFWLIOUZ9j5()
		{
			return null;
		}

		// Token: 0x04000F3D RID: 3901
		private static readonly MessageParser<LivingObjectMessageRequest> _parser;

		// Token: 0x04000F3E RID: 3902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F3F RID: 3903
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04000F40 RID: 3904
		private int messageId_;

		// Token: 0x04000F41 RID: 3905
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x04000F42 RID: 3906
		private int objectGid_;

		// Token: 0x04000F43 RID: 3907
		internal static LivingObjectMessageRequest at2Cb9OVfLWcAuFbRbnr;
	}
}
