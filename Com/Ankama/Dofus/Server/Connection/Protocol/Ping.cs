using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E01 RID: 3585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Ping : IMessage<Ping>, IMessage, IEquatable<Ping>, IDeepCloneable<Ping>, IBufferMessage
	{
		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x0029E8B8 File Offset: 0x0029CAB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Ping> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x0029E8C8 File Offset: 0x0029CAC8
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

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x0029E8D8 File Offset: 0x0029CAD8
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

		// Token: 0x0600AC8E RID: 44174 RVA: 0x0029E8E8 File Offset: 0x0029CAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ping()
		{
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x0029E8F8 File Offset: 0x0029CAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ping(Ping other)
		{
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x0029E908 File Offset: 0x0029CB08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ping Clone()
		{
			return null;
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x0029E918 File Offset: 0x0029CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x0029E928 File Offset: 0x0029CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Ping other)
		{
			return true;
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x0029E938 File Offset: 0x0029CB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x0029E948 File Offset: 0x0029CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x0029E958 File Offset: 0x0029CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x0029E968 File Offset: 0x0029CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x0029E978 File Offset: 0x0029CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x0029E988 File Offset: 0x0029CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Ping other)
		{
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x0029E998 File Offset: 0x0029CB98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x0029E9A8 File Offset: 0x0029CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x0029E9B8 File Offset: 0x0029CBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Ping()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					Ping._parser = new MessageParser<Ping>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x0029EAB0 File Offset: 0x0029CCB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sQ6EJBJUyfuQcLSBEvTi()
		{
			return true;
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x0029EAB8 File Offset: 0x0029CCB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Ping jCCm17JU6xow43WYsMRA()
		{
			return null;
		}

		// Token: 0x04003F6D RID: 16237
		private static readonly MessageParser<Ping> _parser;

		// Token: 0x04003F6E RID: 16238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6F RID: 16239
		private static Ping aBFW44JU5OurN128Oyqu;
	}
}
