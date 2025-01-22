using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000069 RID: 105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TitlesAndOrnamentsRequest : IMessage<TitlesAndOrnamentsRequest>, IMessage, IEquatable<TitlesAndOrnamentsRequest>, IDeepCloneable<TitlesAndOrnamentsRequest>, IBufferMessage
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00188B70 File Offset: 0x00186D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TitlesAndOrnamentsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00188B80 File Offset: 0x00186D80
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00188B90 File Offset: 0x00186D90
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

		// Token: 0x06000408 RID: 1032 RVA: 0x00188BA0 File Offset: 0x00186DA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsRequest()
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00188BB0 File Offset: 0x00186DB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsRequest(TitlesAndOrnamentsRequest other)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00188BC0 File Offset: 0x00186DC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TitlesAndOrnamentsRequest Clone()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00188BD0 File Offset: 0x00186DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00188BE0 File Offset: 0x00186DE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TitlesAndOrnamentsRequest other)
		{
			return true;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00188BF0 File Offset: 0x00186DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00188C00 File Offset: 0x00186E00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00188C10 File Offset: 0x00186E10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00188C20 File Offset: 0x00186E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00188C30 File Offset: 0x00186E30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00188C40 File Offset: 0x00186E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TitlesAndOrnamentsRequest other)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00188C50 File Offset: 0x00186E50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00188C60 File Offset: 0x00186E60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00188C70 File Offset: 0x00186E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TitlesAndOrnamentsRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				TitlesAndOrnamentsRequest._parser = new MessageParser<TitlesAndOrnamentsRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00188D3C File Offset: 0x00186F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CYKsV4OKexRImnsWA669()
		{
			return true;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00188D44 File Offset: 0x00186F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TitlesAndOrnamentsRequest BOX1q6OK3gUIosuOd8lF()
		{
			return null;
		}

		// Token: 0x040001A7 RID: 423
		private static readonly MessageParser<TitlesAndOrnamentsRequest> _parser;

		// Token: 0x040001A8 RID: 424
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001A9 RID: 425
		internal static TitlesAndOrnamentsRequest sm8F40OKBqUZ2Rm8Ae8Z;
	}
}
