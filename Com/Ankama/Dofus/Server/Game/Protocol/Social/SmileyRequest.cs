using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200012F RID: 303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SmileyRequest : IMessage<SmileyRequest>, IMessage, IEquatable<SmileyRequest>, IDeepCloneable<SmileyRequest>, IBufferMessage
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0019ADF0 File Offset: 0x00198FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SmileyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0019AE00 File Offset: 0x00199000
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0019AE10 File Offset: 0x00199010
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

		// Token: 0x06000DBA RID: 3514 RVA: 0x0019AE20 File Offset: 0x00199020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyRequest()
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0019AE30 File Offset: 0x00199030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyRequest(SmileyRequest other)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0019AE40 File Offset: 0x00199040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0019AE50 File Offset: 0x00199050
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x0019AE60 File Offset: 0x00199060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SmileyId
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

		// Token: 0x06000DBF RID: 3519 RVA: 0x0019AE70 File Offset: 0x00199070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0019AE80 File Offset: 0x00199080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SmileyRequest other)
		{
			return true;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0019AE90 File Offset: 0x00199090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0019AEA0 File Offset: 0x001990A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0019AEB0 File Offset: 0x001990B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0019AEC0 File Offset: 0x001990C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0019AED0 File Offset: 0x001990D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0019AEE0 File Offset: 0x001990E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SmileyRequest other)
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0019AEF0 File Offset: 0x001990F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0019AF00 File Offset: 0x00199100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0019AF10 File Offset: 0x00199110
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SmileyRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					SmileyRequest._parser = new MessageParser<SmileyRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0019AFDC File Offset: 0x001991DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wmFO3ROcpTTimls1MY9Y()
		{
			return true;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0019AFE4 File Offset: 0x001991E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SmileyRequest M25kgVOcHJUXYpJK16sc()
		{
			return null;
		}

		// Token: 0x04000504 RID: 1284
		private static readonly MessageParser<SmileyRequest> _parser;

		// Token: 0x04000505 RID: 1285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000506 RID: 1286
		public const int SmileyIdFieldNumber = 1;

		// Token: 0x04000507 RID: 1287
		private int smileyId_;

		// Token: 0x04000508 RID: 1288
		internal static SmileyRequest UbmjUOOcTewYUv8sSu20;
	}
}
