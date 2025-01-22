using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E07 RID: 3591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IdentificationRequest : IMessage<IdentificationRequest>, IMessage, IEquatable<IdentificationRequest>, IDeepCloneable<IdentificationRequest>, IBufferMessage
	{
		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600ACD5 RID: 44245 RVA: 0x0029EEB0 File Offset: 0x0029D0B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IdentificationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x0029EEC0 File Offset: 0x0029D0C0
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

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x0600ACD7 RID: 44247 RVA: 0x0029EED0 File Offset: 0x0029D0D0
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

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x0029EEE0 File Offset: 0x0029D0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest()
		{
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x0029EEF0 File Offset: 0x0029D0F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest(IdentificationRequest other)
		{
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x0029EF00 File Offset: 0x0029D100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationRequest Clone()
		{
			return null;
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x0600ACDB RID: 44251 RVA: 0x0029EF10 File Offset: 0x0029D110
		// (set) Token: 0x0600ACDC RID: 44252 RVA: 0x0029EF20 File Offset: 0x0029D120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceIdentifier
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

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x0600ACDD RID: 44253 RVA: 0x0029EF30 File Offset: 0x0029D130
		// (set) Token: 0x0600ACDE RID: 44254 RVA: 0x0029EF40 File Offset: 0x0029D140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientVersion
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

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x0600ACDF RID: 44255 RVA: 0x0029EF50 File Offset: 0x0029D150
		// (set) Token: 0x0600ACE0 RID: 44256 RVA: 0x0029EF60 File Offset: 0x0029D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenRequest TokenRequest
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

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x0600ACE1 RID: 44257 RVA: 0x0029EF70 File Offset: 0x0029D170
		// (set) Token: 0x0600ACE2 RID: 44258 RVA: 0x0029EF80 File Offset: 0x0029D180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest LoginRequest
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

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x0600ACE3 RID: 44259 RVA: 0x0029EF90 File Offset: 0x0029D190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdentificationRequest.IdentificationTypeOneofCase IdentificationTypeCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (IdentificationRequest.IdentificationTypeOneofCase)null;
			}
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x0029EFA4 File Offset: 0x0029D1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearIdentificationType()
		{
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x0029EFB4 File Offset: 0x0029D1B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x0029EFC4 File Offset: 0x0029D1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IdentificationRequest other)
		{
			return true;
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x0029EFD4 File Offset: 0x0029D1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x0029EFE4 File Offset: 0x0029D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x0029EFF4 File Offset: 0x0029D1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x0029F004 File Offset: 0x0029D204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x0029F014 File Offset: 0x0029D214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x0029F024 File Offset: 0x0029D224
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(IdentificationRequest other)
		{
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x0029F034 File Offset: 0x0029D234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x0029F044 File Offset: 0x0029D244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x0029F054 File Offset: 0x0029D254
		[MethodImpl(MethodImplOptions.NoInlining)]
		static IdentificationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					IdentificationRequest._parser = new MessageParser<IdentificationRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x0029F138 File Offset: 0x0029D338
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool snoseSJUDb8iHHjCNAq8()
		{
			return true;
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x0029F140 File Offset: 0x0029D340
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IdentificationRequest x9fT4wJUta6CBTeGN52S()
		{
			return null;
		}

		// Token: 0x04003F7E RID: 16254
		private static readonly MessageParser<IdentificationRequest> _parser;

		// Token: 0x04003F7F RID: 16255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F80 RID: 16256
		public const int DeviceIdentifierFieldNumber = 1;

		// Token: 0x04003F81 RID: 16257
		private string deviceIdentifier_;

		// Token: 0x04003F82 RID: 16258
		public const int ClientVersionFieldNumber = 5;

		// Token: 0x04003F83 RID: 16259
		private string clientVersion_;

		// Token: 0x04003F84 RID: 16260
		public const int TokenRequestFieldNumber = 3;

		// Token: 0x04003F85 RID: 16261
		public const int LoginRequestFieldNumber = 4;

		// Token: 0x04003F86 RID: 16262
		private object identificationType_;

		// Token: 0x04003F87 RID: 16263
		private IdentificationRequest.IdentificationTypeOneofCase identificationTypeCase_;

		// Token: 0x04003F88 RID: 16264
		private static IdentificationRequest XoPKFWJUCg817nfSrBwr;

		// Token: 0x02000E08 RID: 3592
		public enum IdentificationTypeOneofCase
		{
			// Token: 0x04003F8A RID: 16266
			None,
			// Token: 0x04003F8B RID: 16267
			TokenRequest = 3,
			// Token: 0x04003F8C RID: 16268
			LoginRequest
		}
	}
}
