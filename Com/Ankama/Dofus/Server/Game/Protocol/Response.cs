using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol
{
	// Token: 0x0200002B RID: 43
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IBufferMessage
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000187 RID: 391 RVA: 0x001847FC File Offset: 0x001829FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Response> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0018480C File Offset: 0x00182A0C
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0018481C File Offset: 0x00182A1C
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

		// Token: 0x0600018A RID: 394 RVA: 0x0018482C File Offset: 0x00182A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0018483C File Offset: 0x00182A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response(Response other)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0018484C File Offset: 0x00182A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response Clone()
		{
			return null;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0018485C File Offset: 0x00182A5C
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0018486C File Offset: 0x00182A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Uid
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0018487C File Offset: 0x00182A7C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0018488C File Offset: 0x00182A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Content
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

		// Token: 0x06000191 RID: 401 RVA: 0x0018489C File Offset: 0x00182A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x001848AC File Offset: 0x00182AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Response other)
		{
			return true;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x001848BC File Offset: 0x00182ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x001848CC File Offset: 0x00182ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x001848DC File Offset: 0x00182ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x001848EC File Offset: 0x00182AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x001848FC File Offset: 0x00182AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0018490C File Offset: 0x00182B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Response other)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0018491C File Offset: 0x00182B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0018492C File Offset: 0x00182B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0018493C File Offset: 0x00182B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Response()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				Response._parser = new MessageParser<Response>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00184A08 File Offset: 0x00182C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zUId7QOjRlml1x6qfjRh()
		{
			return true;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00184A10 File Offset: 0x00182C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Response nPOfuDOjOo4lyFaoGxw3()
		{
			return null;
		}

		// Token: 0x040000A6 RID: 166
		private static readonly MessageParser<Response> _parser;

		// Token: 0x040000A7 RID: 167
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000A8 RID: 168
		public const int UidFieldNumber = 1;

		// Token: 0x040000A9 RID: 169
		private int uid_;

		// Token: 0x040000AA RID: 170
		public const int ContentFieldNumber = 2;

		// Token: 0x040000AB RID: 171
		private Any content_;

		// Token: 0x040000AC RID: 172
		internal static Response EpB0KeOj3ojvsXCtUVsV;
	}
}
