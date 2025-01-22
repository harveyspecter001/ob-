using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E0A RID: 3594
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TokenRequest : IMessage<TokenRequest>, IMessage, IEquatable<TokenRequest>, IDeepCloneable<TokenRequest>, IBufferMessage
	{
		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x0600ACF7 RID: 44279 RVA: 0x0029F148 File Offset: 0x0029D348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TokenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x0600ACF8 RID: 44280 RVA: 0x0029F158 File Offset: 0x0029D358
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

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600ACF9 RID: 44281 RVA: 0x0029F168 File Offset: 0x0029D368
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

		// Token: 0x0600ACFA RID: 44282 RVA: 0x0029F178 File Offset: 0x0029D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenRequest()
		{
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x0029F188 File Offset: 0x0029D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenRequest(TokenRequest other)
		{
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x0029F198 File Offset: 0x0029D398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenRequest Clone()
		{
			return null;
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x0029F1A8 File Offset: 0x0029D3A8
		// (set) Token: 0x0600ACFE RID: 44286 RVA: 0x0029F1B8 File Offset: 0x0029D3B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Token
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

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x0029F1C8 File Offset: 0x0029D3C8
		// (set) Token: 0x0600AD00 RID: 44288 RVA: 0x0029F1D8 File Offset: 0x0029D3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenRequest.Types.Shield Shield
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

		// Token: 0x0600AD01 RID: 44289 RVA: 0x0029F1E8 File Offset: 0x0029D3E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x0029F1F8 File Offset: 0x0029D3F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TokenRequest other)
		{
			return true;
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x0029F208 File Offset: 0x0029D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x0029F218 File Offset: 0x0029D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x0029F228 File Offset: 0x0029D428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x0029F238 File Offset: 0x0029D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x0029F248 File Offset: 0x0029D448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x0029F258 File Offset: 0x0029D458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TokenRequest other)
		{
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x0029F268 File Offset: 0x0029D468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x0029F278 File Offset: 0x0029D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x0029F288 File Offset: 0x0029D488
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TokenRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					TokenRequest._parser = new MessageParser<TokenRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x0029F36C File Offset: 0x0029D56C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y5br7nJUQtvKfVYQ7sY7()
		{
			return true;
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x0029F374 File Offset: 0x0029D574
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TokenRequest BgxkH6JU7wJjUqVlKFsg()
		{
			return null;
		}

		// Token: 0x04003F8F RID: 16271
		private static readonly MessageParser<TokenRequest> _parser;

		// Token: 0x04003F90 RID: 16272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F91 RID: 16273
		public const int TokenFieldNumber = 1;

		// Token: 0x04003F92 RID: 16274
		private string token_;

		// Token: 0x04003F93 RID: 16275
		public const int ShieldFieldNumber = 2;

		// Token: 0x04003F94 RID: 16276
		private TokenRequest.Types.Shield shield_;

		// Token: 0x04003F95 RID: 16277
		private static TokenRequest Qy84raJUwrRg5bFPAlq3;

		// Token: 0x02000E0B RID: 3595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AD0E RID: 44302 RVA: 0x002F3AD8 File Offset: 0x002F1CD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E0C RID: 3596
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Shield : IMessage<TokenRequest.Types.Shield>, IMessage, IEquatable<TokenRequest.Types.Shield>, IDeepCloneable<TokenRequest.Types.Shield>, IBufferMessage
			{
				// Token: 0x17002013 RID: 8211
				// (get) Token: 0x0600AD0F RID: 44303 RVA: 0x0030F480 File Offset: 0x0030D680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<TokenRequest.Types.Shield> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17002014 RID: 8212
				// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x0030F490 File Offset: 0x0030D690
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

				// Token: 0x17002015 RID: 8213
				// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x0030F4A0 File Offset: 0x0030D6A0
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

				// Token: 0x0600AD12 RID: 44306 RVA: 0x0030F4B0 File Offset: 0x0030D6B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Shield()
				{
				}

				// Token: 0x0600AD13 RID: 44307 RVA: 0x0030F4C0 File Offset: 0x0030D6C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Shield(TokenRequest.Types.Shield other)
				{
				}

				// Token: 0x0600AD14 RID: 44308 RVA: 0x0030F4D0 File Offset: 0x0030D6D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TokenRequest.Types.Shield Clone()
				{
					return null;
				}

				// Token: 0x17002016 RID: 8214
				// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x0030F4E0 File Offset: 0x0030D6E0
				// (set) Token: 0x0600AD16 RID: 44310 RVA: 0x0030F4F0 File Offset: 0x0030D6F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long CertificateId
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

				// Token: 0x17002017 RID: 8215
				// (get) Token: 0x0600AD17 RID: 44311 RVA: 0x0030F500 File Offset: 0x0030D700
				// (set) Token: 0x0600AD18 RID: 44312 RVA: 0x0030F510 File Offset: 0x0030D710
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string CertificateHash
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

				// Token: 0x0600AD19 RID: 44313 RVA: 0x0030F520 File Offset: 0x0030D720
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AD1A RID: 44314 RVA: 0x0030F530 File Offset: 0x0030D730
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(TokenRequest.Types.Shield other)
				{
					return true;
				}

				// Token: 0x0600AD1B RID: 44315 RVA: 0x0030F540 File Offset: 0x0030D740
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AD1C RID: 44316 RVA: 0x0030F550 File Offset: 0x0030D750
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AD1D RID: 44317 RVA: 0x0030F560 File Offset: 0x0030D760
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AD1E RID: 44318 RVA: 0x0030F570 File Offset: 0x0030D770
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AD1F RID: 44319 RVA: 0x0030F580 File Offset: 0x0030D780
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AD20 RID: 44320 RVA: 0x0030F590 File Offset: 0x0030D790
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(TokenRequest.Types.Shield other)
				{
				}

				// Token: 0x0600AD21 RID: 44321 RVA: 0x0030F5A0 File Offset: 0x0030D7A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AD22 RID: 44322 RVA: 0x0030F5B0 File Offset: 0x0030D7B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AD23 RID: 44323 RVA: 0x0030F5C0 File Offset: 0x0030D7C0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Shield()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							TokenRequest.Types.Shield._parser = new MessageParser<TokenRequest.Types.Shield>(() => null);
							num2 = 4;
							continue;
						case 4:
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x0600AD24 RID: 44324 RVA: 0x0030F6A4 File Offset: 0x0030D8A4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool rxuLTMGq6Bl8QEPmmSNf()
				{
					return true;
				}

				// Token: 0x0600AD25 RID: 44325 RVA: 0x0030F6AC File Offset: 0x0030D8AC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static TokenRequest.Types.Shield gbS5ZZGqLH8Ft7HqHlAM()
				{
					return null;
				}

				// Token: 0x04003F96 RID: 16278
				private static readonly MessageParser<TokenRequest.Types.Shield> _parser;

				// Token: 0x04003F97 RID: 16279
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003F98 RID: 16280
				public const int CertificateIdFieldNumber = 1;

				// Token: 0x04003F99 RID: 16281
				private long certificateId_;

				// Token: 0x04003F9A RID: 16282
				public const int CertificateHashFieldNumber = 2;

				// Token: 0x04003F9B RID: 16283
				private string certificateHash_;

				// Token: 0x04003F9C RID: 16284
				private static TokenRequest.Types.Shield BcrpvFGqyyRS4UD5HPZW;
			}
		}
	}
}
