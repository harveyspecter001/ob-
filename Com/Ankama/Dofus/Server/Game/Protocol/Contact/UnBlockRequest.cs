using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200083E RID: 2110
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnBlockRequest : IMessage<UnBlockRequest>, IMessage, IEquatable<UnBlockRequest>, IDeepCloneable<UnBlockRequest>, IBufferMessage
	{
		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600668A RID: 26250 RVA: 0x0022BDA4 File Offset: 0x00229FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<UnBlockRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x0022BDB4 File Offset: 0x00229FB4
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

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x0022BDC4 File Offset: 0x00229FC4
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

		// Token: 0x0600668D RID: 26253 RVA: 0x0022BDD4 File Offset: 0x00229FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockRequest()
		{
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x0022BDE4 File Offset: 0x00229FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockRequest(UnBlockRequest other)
		{
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x0022BDF4 File Offset: 0x00229FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockRequest Clone()
		{
			return null;
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x0022BE04 File Offset: 0x0022A004
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x0022BE14 File Offset: 0x0022A014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x0022BE24 File Offset: 0x0022A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0022BE34 File Offset: 0x0022A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UnBlockRequest other)
		{
			return true;
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0022BE44 File Offset: 0x0022A044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x0022BE54 File Offset: 0x0022A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x0022BE64 File Offset: 0x0022A064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x0022BE74 File Offset: 0x0022A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x0022BE84 File Offset: 0x0022A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0022BE94 File Offset: 0x0022A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UnBlockRequest other)
		{
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0022BEA4 File Offset: 0x0022A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x0022BEB4 File Offset: 0x0022A0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x0022BEC4 File Offset: 0x0022A0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnBlockRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UnBlockRequest._parser = new MessageParser<UnBlockRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0022BF90 File Offset: 0x0022A190
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hCkBFCJfpRafPtFNGLt5()
		{
			return true;
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x0022BF98 File Offset: 0x0022A198
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UnBlockRequest tDNS5rJfHLZp9OdQbegG()
		{
			return null;
		}

		// Token: 0x040023FC RID: 9212
		private static readonly MessageParser<UnBlockRequest> _parser;

		// Token: 0x040023FD RID: 9213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023FE RID: 9214
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040023FF RID: 9215
		private long accountId_;

		// Token: 0x04002400 RID: 9216
		private static UnBlockRequest q6nnRGJfTADb7Uw8ChWS;
	}
}
