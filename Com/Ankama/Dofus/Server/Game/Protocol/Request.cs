using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol
{
	// Token: 0x02000029 RID: 41
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IBufferMessage
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016B RID: 363 RVA: 0x001845C8 File Offset: 0x001827C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Request> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016C RID: 364 RVA: 0x001845D8 File Offset: 0x001827D8
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600016D RID: 365 RVA: 0x001845E8 File Offset: 0x001827E8
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

		// Token: 0x0600016E RID: 366 RVA: 0x001845F8 File Offset: 0x001827F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00184608 File Offset: 0x00182808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request(Request other)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00184618 File Offset: 0x00182818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request Clone()
		{
			return null;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00184628 File Offset: 0x00182828
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00184638 File Offset: 0x00182838
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00184648 File Offset: 0x00182848
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00184658 File Offset: 0x00182858
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

		// Token: 0x06000175 RID: 373 RVA: 0x00184668 File Offset: 0x00182868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00184678 File Offset: 0x00182878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Request other)
		{
			return true;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00184688 File Offset: 0x00182888
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00184698 File Offset: 0x00182898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x001846A8 File Offset: 0x001828A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x001846B8 File Offset: 0x001828B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x001846C8 File Offset: 0x001828C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x001846D8 File Offset: 0x001828D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Request other)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x001846E8 File Offset: 0x001828E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x001846F8 File Offset: 0x001828F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00184708 File Offset: 0x00182908
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Request()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					Request._parser = new MessageParser<Request>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x001847EC File Offset: 0x001829EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xpbkOtOjBNFa5O24En3g()
		{
			return true;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x001847F4 File Offset: 0x001829F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Request sGTs10OjeyEu9fUMecD2()
		{
			return null;
		}

		// Token: 0x0400009D RID: 157
		private static readonly MessageParser<Request> _parser;

		// Token: 0x0400009E RID: 158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400009F RID: 159
		public const int UidFieldNumber = 1;

		// Token: 0x040000A0 RID: 160
		private int uid_;

		// Token: 0x040000A1 RID: 161
		public const int ContentFieldNumber = 2;

		// Token: 0x040000A2 RID: 162
		private Any content_;

		// Token: 0x040000A3 RID: 163
		internal static Request TOpVk0OjANyS01IgwrX3;
	}
}
