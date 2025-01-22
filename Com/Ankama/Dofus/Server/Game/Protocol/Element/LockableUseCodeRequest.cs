using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007C8 RID: 1992
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockableUseCodeRequest : IMessage<LockableUseCodeRequest>, IMessage, IEquatable<LockableUseCodeRequest>, IDeepCloneable<LockableUseCodeRequest>, IBufferMessage
	{
		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x0600619F RID: 24991 RVA: 0x00221A78 File Offset: 0x0021FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockableUseCodeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x00221A88 File Offset: 0x0021FC88
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

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x00221A98 File Offset: 0x0021FC98
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

		// Token: 0x060061A2 RID: 24994 RVA: 0x00221AA8 File Offset: 0x0021FCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableUseCodeRequest()
		{
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x00221AB8 File Offset: 0x0021FCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableUseCodeRequest(LockableUseCodeRequest other)
		{
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x00221AC8 File Offset: 0x0021FCC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableUseCodeRequest Clone()
		{
			return null;
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x060061A5 RID: 24997 RVA: 0x00221AD8 File Offset: 0x0021FCD8
		// (set) Token: 0x060061A6 RID: 24998 RVA: 0x00221AE8 File Offset: 0x0021FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Code
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

		// Token: 0x060061A7 RID: 24999 RVA: 0x00221AF8 File Offset: 0x0021FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00221B08 File Offset: 0x0021FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LockableUseCodeRequest other)
		{
			return true;
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00221B18 File Offset: 0x0021FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00221B28 File Offset: 0x0021FD28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00221B38 File Offset: 0x0021FD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00221B48 File Offset: 0x0021FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x00221B58 File Offset: 0x0021FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x00221B68 File Offset: 0x0021FD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LockableUseCodeRequest other)
		{
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x00221B78 File Offset: 0x0021FD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00221B88 File Offset: 0x0021FD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00221B98 File Offset: 0x0021FD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LockableUseCodeRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					LockableUseCodeRequest._parser = new MessageParser<LockableUseCodeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x00221C7C File Offset: 0x0021FE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jlj107OFEpemDC2akEfU()
		{
			return true;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00221C84 File Offset: 0x0021FE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LockableUseCodeRequest hcytYZOFXBTR1M0XICbi()
		{
			return null;
		}

		// Token: 0x0400224F RID: 8783
		private static readonly MessageParser<LockableUseCodeRequest> _parser;

		// Token: 0x04002250 RID: 8784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002251 RID: 8785
		public const int CodeFieldNumber = 1;

		// Token: 0x04002252 RID: 8786
		private string code_;

		// Token: 0x04002253 RID: 8787
		private static LockableUseCodeRequest kS0ZFSOF2GtQnUme3mWQ;
	}
}
