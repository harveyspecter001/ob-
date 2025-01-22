using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E03 RID: 3587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Pong : IMessage<Pong>, IMessage, IEquatable<Pong>, IDeepCloneable<Pong>, IBufferMessage
	{
		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x0029EAC0 File Offset: 0x0029CCC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Pong> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x0029EAD0 File Offset: 0x0029CCD0
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

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x0600ACA5 RID: 44197 RVA: 0x0029EAE0 File Offset: 0x0029CCE0
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

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x0029EAF0 File Offset: 0x0029CCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pong()
		{
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x0029EB00 File Offset: 0x0029CD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pong(Pong other)
		{
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x0029EB10 File Offset: 0x0029CD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pong Clone()
		{
			return null;
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x0029EB20 File Offset: 0x0029CD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x0029EB30 File Offset: 0x0029CD30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Pong other)
		{
			return true;
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x0029EB40 File Offset: 0x0029CD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x0029EB50 File Offset: 0x0029CD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x0029EB60 File Offset: 0x0029CD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x0029EB70 File Offset: 0x0029CD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x0029EB80 File Offset: 0x0029CD80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x0029EB90 File Offset: 0x0029CD90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Pong other)
		{
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x0029EBA0 File Offset: 0x0029CDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x0029EBB0 File Offset: 0x0029CDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x0029EBC0 File Offset: 0x0029CDC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Pong()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
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
				Pong._parser = new MessageParser<Pong>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x0029ECA4 File Offset: 0x0029CEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V6ZAGJJUW9bLYJe34q4H()
		{
			return true;
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x0029ECAC File Offset: 0x0029CEAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Pong fdwr2TJUhmyISQ9b12o8()
		{
			return null;
		}

		// Token: 0x04003F72 RID: 16242
		private static readonly MessageParser<Pong> _parser;

		// Token: 0x04003F73 RID: 16243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F74 RID: 16244
		internal static Pong pBRGjnJULpcdT2nUFom5;
	}
}
