using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E0F RID: 3599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>, IBufferMessage
	{
		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x0029F37C File Offset: 0x0029D57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LoginRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600AD31 RID: 44337 RVA: 0x0029F38C File Offset: 0x0029D58C
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

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x0029F39C File Offset: 0x0029D59C
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

		// Token: 0x0600AD33 RID: 44339 RVA: 0x0029F3AC File Offset: 0x0029D5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginRequest()
		{
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x0029F3BC File Offset: 0x0029D5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginRequest(LoginRequest other)
		{
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x0029F3CC File Offset: 0x0029D5CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginRequest Clone()
		{
			return null;
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x0029F3DC File Offset: 0x0029D5DC
		// (set) Token: 0x0600AD37 RID: 44343 RVA: 0x0029F3EC File Offset: 0x0029D5EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Login
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

		// Token: 0x0600AD38 RID: 44344 RVA: 0x0029F3FC File Offset: 0x0029D5FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x0029F40C File Offset: 0x0029D60C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LoginRequest other)
		{
			return true;
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x0029F41C File Offset: 0x0029D61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x0029F42C File Offset: 0x0029D62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x0029F43C File Offset: 0x0029D63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x0029F44C File Offset: 0x0029D64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x0029F45C File Offset: 0x0029D65C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x0029F46C File Offset: 0x0029D66C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LoginRequest other)
		{
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x0029F47C File Offset: 0x0029D67C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x0029F48C File Offset: 0x0029D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x0029F49C File Offset: 0x0029D69C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LoginRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					LoginRequest._parser = new MessageParser<LoginRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x0029F580 File Offset: 0x0029D780
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SuseMvJUpaQg4sLbMIAh()
		{
			return true;
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x0029F588 File Offset: 0x0029D788
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LoginRequest FRJ6V6JUH8KKMpb2n3o1()
		{
			return null;
		}

		// Token: 0x04003FA1 RID: 16289
		private static readonly MessageParser<LoginRequest> _parser;

		// Token: 0x04003FA2 RID: 16290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FA3 RID: 16291
		public const int LoginFieldNumber = 1;

		// Token: 0x04003FA4 RID: 16292
		private string login_;

		// Token: 0x04003FA5 RID: 16293
		internal static LoginRequest zVACMGJUTeYwsSJwtsO7;
	}
}
