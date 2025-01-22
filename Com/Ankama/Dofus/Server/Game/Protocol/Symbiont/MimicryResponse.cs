using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x02000104 RID: 260
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MimicryResponse : IMessage<MimicryResponse>, IMessage, IEquatable<MimicryResponse>, IDeepCloneable<MimicryResponse>, IBufferMessage
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0019643C File Offset: 0x0019463C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MimicryResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0019644C File Offset: 0x0019464C
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0019645C File Offset: 0x0019465C
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

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0019646C File Offset: 0x0019466C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryResponse()
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0019647C File Offset: 0x0019467C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryResponse(MimicryResponse other)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0019648C File Offset: 0x0019468C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryResponse Clone()
		{
			return null;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0019649C File Offset: 0x0019469C
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x001964B0 File Offset: 0x001946B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MimicryResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MimicryResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x001964C0 File Offset: 0x001946C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x001964D0 File Offset: 0x001946D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MimicryResponse other)
		{
			return true;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x001964E0 File Offset: 0x001946E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x001964F0 File Offset: 0x001946F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00196500 File Offset: 0x00194700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00196510 File Offset: 0x00194710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00196520 File Offset: 0x00194720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00196530 File Offset: 0x00194730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MimicryResponse other)
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00196540 File Offset: 0x00194740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00196550 File Offset: 0x00194750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00196560 File Offset: 0x00194760
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MimicryResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				MimicryResponse._parser = new MessageParser<MimicryResponse>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00196644 File Offset: 0x00194844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G4fVlxOlY5kFw4rkr4WB()
		{
			return true;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0019664C File Offset: 0x0019484C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MimicryResponse eBpcE7OlbYx2BJ8pUZCf()
		{
			return null;
		}

		// Token: 0x04000450 RID: 1104
		private static readonly MessageParser<MimicryResponse> _parser;

		// Token: 0x04000451 RID: 1105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000452 RID: 1106
		public const int ResultFieldNumber = 1;

		// Token: 0x04000453 RID: 1107
		private MimicryResult result_;

		// Token: 0x04000454 RID: 1108
		private static MimicryResponse LjlROjOlHFNH5l77q5DA;
	}
}
