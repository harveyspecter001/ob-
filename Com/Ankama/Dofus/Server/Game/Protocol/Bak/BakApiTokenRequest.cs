using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BF4 RID: 3060
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakApiTokenRequest : IMessage<BakApiTokenRequest>, IMessage, IEquatable<BakApiTokenRequest>, IDeepCloneable<BakApiTokenRequest>, IBufferMessage
	{
		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x00272AB8 File Offset: 0x00270CB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BakApiTokenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06009333 RID: 37683 RVA: 0x00272AC8 File Offset: 0x00270CC8
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

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06009334 RID: 37684 RVA: 0x00272AD8 File Offset: 0x00270CD8
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

		// Token: 0x06009335 RID: 37685 RVA: 0x00272AE8 File Offset: 0x00270CE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiTokenRequest()
		{
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00272AF8 File Offset: 0x00270CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiTokenRequest(BakApiTokenRequest other)
		{
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x00272B08 File Offset: 0x00270D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiTokenRequest Clone()
		{
			return null;
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x00272B18 File Offset: 0x00270D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x00272B28 File Offset: 0x00270D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakApiTokenRequest other)
		{
			return true;
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x00272B38 File Offset: 0x00270D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x00272B48 File Offset: 0x00270D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x00272B58 File Offset: 0x00270D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x00272B68 File Offset: 0x00270D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00272B78 File Offset: 0x00270D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x00272B88 File Offset: 0x00270D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakApiTokenRequest other)
		{
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x00272B98 File Offset: 0x00270D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009341 RID: 37697 RVA: 0x00272BA8 File Offset: 0x00270DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009342 RID: 37698 RVA: 0x00272BB8 File Offset: 0x00270DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakApiTokenRequest()
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
					num2 = 2;
					continue;
				case 2:
					BakApiTokenRequest._parser = new MessageParser<BakApiTokenRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06009343 RID: 37699 RVA: 0x00272C84 File Offset: 0x00270E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kovv0JJE0yPl4K9snJRK()
		{
			return true;
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x00272C8C File Offset: 0x00270E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakApiTokenRequest dT71yoJEC1c8auth2vbY()
		{
			return null;
		}

		// Token: 0x040036D5 RID: 14037
		private static readonly MessageParser<BakApiTokenRequest> _parser;

		// Token: 0x040036D6 RID: 14038
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D7 RID: 14039
		internal static BakApiTokenRequest EV289cJEVEx4sSV8cIs1;
	}
}
