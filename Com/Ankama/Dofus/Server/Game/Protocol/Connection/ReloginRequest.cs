using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x02000895 RID: 2197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReloginRequest : IMessage<ReloginRequest>, IMessage, IEquatable<ReloginRequest>, IDeepCloneable<ReloginRequest>, IBufferMessage
	{
		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x0023016C File Offset: 0x0022E36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReloginRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x0023017C File Offset: 0x0022E37C
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

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x0023018C File Offset: 0x0022E38C
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

		// Token: 0x06006AB6 RID: 27318 RVA: 0x0023019C File Offset: 0x0022E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginRequest()
		{
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x002301AC File Offset: 0x0022E3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginRequest(ReloginRequest other)
		{
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x002301BC File Offset: 0x0022E3BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReloginRequest Clone()
		{
			return null;
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x002301CC File Offset: 0x0022E3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x002301DC File Offset: 0x0022E3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ReloginRequest other)
		{
			return true;
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x002301EC File Offset: 0x0022E3EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x002301FC File Offset: 0x0022E3FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0023020C File Offset: 0x0022E40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0023021C File Offset: 0x0022E41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0023022C File Offset: 0x0022E42C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x0023023C File Offset: 0x0022E43C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ReloginRequest other)
		{
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x0023024C File Offset: 0x0022E44C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x0023025C File Offset: 0x0022E45C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x0023026C File Offset: 0x0022E46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReloginRequest()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ReloginRequest._parser = new MessageParser<ReloginRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
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

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00230350 File Offset: 0x0022E550
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I8Jl9pJmgQuNjRtasdkG()
		{
			return true;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00230358 File Offset: 0x0022E558
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReloginRequest CsYUrWJms5voYTfDGhLx()
		{
			return null;
		}

		// Token: 0x04002559 RID: 9561
		private static readonly MessageParser<ReloginRequest> _parser;

		// Token: 0x0400255A RID: 9562
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400255B RID: 9563
		private static ReloginRequest rJeYDoJmGbAwLJjdO92U;
	}
}
