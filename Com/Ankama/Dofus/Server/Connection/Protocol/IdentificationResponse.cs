using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E11 RID: 3601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IdentificationResponse : IMessage<IdentificationResponse>, IMessage, IEquatable<IdentificationResponse>, IDeepCloneable<IdentificationResponse>, IBufferMessage
	{
		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x0029F590 File Offset: 0x0029D790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IdentificationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x0029F5A0 File Offset: 0x0029D7A0
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

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x0600AD4C RID: 44364 RVA: 0x0029F5B0 File Offset: 0x0029D7B0
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

		// Token: 0x0600AD4D RID: 44365 RVA: 0x0029F5C0 File Offset: 0x0029D7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationResponse()
		{
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x0029F5D0 File Offset: 0x0029D7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationResponse(IdentificationResponse other)
		{
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x0029F5E0 File Offset: 0x0029D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdentificationResponse Clone()
		{
			return null;
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x0029F5F0 File Offset: 0x0029D7F0
		// (set) Token: 0x0600AD51 RID: 44369 RVA: 0x0029F600 File Offset: 0x0029D800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdentificationResponse.Types.Success Success
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

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x0029F610 File Offset: 0x0029D810
		// (set) Token: 0x0600AD53 RID: 44371 RVA: 0x0029F620 File Offset: 0x0029D820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdentificationResponse.Types.Error Error
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

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600AD54 RID: 44372 RVA: 0x0029F630 File Offset: 0x0029D830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdentificationResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (IdentificationResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x0029F644 File Offset: 0x0029D844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x0029F654 File Offset: 0x0029D854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x0029F664 File Offset: 0x0029D864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IdentificationResponse other)
		{
			return true;
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x0029F674 File Offset: 0x0029D874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x0029F684 File Offset: 0x0029D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x0029F694 File Offset: 0x0029D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x0029F6A4 File Offset: 0x0029D8A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x0029F6B4 File Offset: 0x0029D8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x0029F6C4 File Offset: 0x0029D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(IdentificationResponse other)
		{
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x0029F6D4 File Offset: 0x0029D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x0029F6E4 File Offset: 0x0029D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x0029F6F4 File Offset: 0x0029D8F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static IdentificationResponse()
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
					num2 = 2;
					continue;
				case 2:
					IdentificationResponse._parser = new MessageParser<IdentificationResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x0029F7D8 File Offset: 0x0029D9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c3oi0uJUbcWrLPUxMjGk()
		{
			return true;
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x0029F7E0 File Offset: 0x0029D9E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IdentificationResponse NBwWPkJUiml7OCg27T64()
		{
			return null;
		}

		// Token: 0x04003FA8 RID: 16296
		private static readonly MessageParser<IdentificationResponse> _parser;

		// Token: 0x04003FA9 RID: 16297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FAA RID: 16298
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003FAB RID: 16299
		public const int ErrorFieldNumber = 2;

		// Token: 0x04003FAC RID: 16300
		private object result_;

		// Token: 0x04003FAD RID: 16301
		private IdentificationResponse.ResultOneofCase resultCase_;

		// Token: 0x04003FAE RID: 16302
		private static IdentificationResponse EJGaVcJUYVEEtVVHpAX6;

		// Token: 0x02000E12 RID: 3602
		public enum ResultOneofCase
		{
			// Token: 0x04003FB0 RID: 16304
			None,
			// Token: 0x04003FB1 RID: 16305
			Success,
			// Token: 0x04003FB2 RID: 16306
			Error
		}

		// Token: 0x02000E13 RID: 3603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AD63 RID: 44387 RVA: 0x002F3CE0 File Offset: 0x002F1EE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E14 RID: 3604
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<IdentificationResponse.Types.Success>, IMessage, IEquatable<IdentificationResponse.Types.Success>, IDeepCloneable<IdentificationResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17002022 RID: 8226
				// (get) Token: 0x0600AD64 RID: 44388 RVA: 0x0030F6B4 File Offset: 0x0030D8B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<IdentificationResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17002023 RID: 8227
				// (get) Token: 0x0600AD65 RID: 44389 RVA: 0x0030F6C4 File Offset: 0x0030D8C4
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

				// Token: 0x17002024 RID: 8228
				// (get) Token: 0x0600AD66 RID: 44390 RVA: 0x0030F6D4 File Offset: 0x0030D8D4
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

				// Token: 0x0600AD67 RID: 44391 RVA: 0x0030F6E4 File Offset: 0x0030D8E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600AD68 RID: 44392 RVA: 0x0030F6F4 File Offset: 0x0030D8F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(IdentificationResponse.Types.Success other)
				{
				}

				// Token: 0x0600AD69 RID: 44393 RVA: 0x0030F704 File Offset: 0x0030D904
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public IdentificationResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17002025 RID: 8229
				// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x0030F714 File Offset: 0x0030D914
				// (set) Token: 0x0600AD6B RID: 44395 RVA: 0x0030F724 File Offset: 0x0030D924
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x17002026 RID: 8230
				// (get) Token: 0x0600AD6C RID: 44396 RVA: 0x0030F734 File Offset: 0x0030D934
				// (set) Token: 0x0600AD6D RID: 44397 RVA: 0x0030F744 File Offset: 0x0030D944
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string AccountNickname
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

				// Token: 0x17002027 RID: 8231
				// (get) Token: 0x0600AD6E RID: 44398 RVA: 0x0030F754 File Offset: 0x0030D954
				// (set) Token: 0x0600AD6F RID: 44399 RVA: 0x0030F764 File Offset: 0x0030D964
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string AccountTag
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

				// Token: 0x17002028 RID: 8232
				// (get) Token: 0x0600AD70 RID: 44400 RVA: 0x0030F774 File Offset: 0x0030D974
				// (set) Token: 0x0600AD71 RID: 44401 RVA: 0x0030F784 File Offset: 0x0030D984
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ServerList ServerList
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

				// Token: 0x17002029 RID: 8233
				// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x0030F794 File Offset: 0x0030D994
				// (set) Token: 0x0600AD73 RID: 44403 RVA: 0x0030F7A4 File Offset: 0x0030D9A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string SubscriptionEndDate
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

				// Token: 0x1700202A RID: 8234
				// (get) Token: 0x0600AD74 RID: 44404 RVA: 0x0030F7B4 File Offset: 0x0030D9B4
				// (set) Token: 0x0600AD75 RID: 44405 RVA: 0x0030F7C4 File Offset: 0x0030D9C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public IdentificationResponse.Types.Success.Types.Rights Rights
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

				// Token: 0x1700202B RID: 8235
				// (get) Token: 0x0600AD76 RID: 44406 RVA: 0x0030F7D4 File Offset: 0x0030D9D4
				// (set) Token: 0x0600AD77 RID: 44407 RVA: 0x0030F7E4 File Offset: 0x0030D9E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FightReconnectionServerId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x1700202C RID: 8236
				// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x0030F7F4 File Offset: 0x0030D9F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasFightReconnectionServerId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x0600AD79 RID: 44409 RVA: 0x0030F804 File Offset: 0x0030DA04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearFightReconnectionServerId()
				{
				}

				// Token: 0x0600AD7A RID: 44410 RVA: 0x0030F814 File Offset: 0x0030DA14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AD7B RID: 44411 RVA: 0x0030F824 File Offset: 0x0030DA24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(IdentificationResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x0600AD7C RID: 44412 RVA: 0x0030F834 File Offset: 0x0030DA34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AD7D RID: 44413 RVA: 0x0030F844 File Offset: 0x0030DA44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AD7E RID: 44414 RVA: 0x0030F854 File Offset: 0x0030DA54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AD7F RID: 44415 RVA: 0x0030F864 File Offset: 0x0030DA64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AD80 RID: 44416 RVA: 0x0030F874 File Offset: 0x0030DA74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AD81 RID: 44417 RVA: 0x0030F884 File Offset: 0x0030DA84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(IdentificationResponse.Types.Success other)
				{
				}

				// Token: 0x0600AD82 RID: 44418 RVA: 0x0030F894 File Offset: 0x0030DA94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AD83 RID: 44419 RVA: 0x0030F8A4 File Offset: 0x0030DAA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AD84 RID: 44420 RVA: 0x0030F8B4 File Offset: 0x0030DAB4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 5;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						case 5:
							IdentificationResponse.Types.Success._parser = new MessageParser<IdentificationResponse.Types.Success>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						IdentificationResponse.Types.Success.FightReconnectionServerIdDefaultValue = 0;
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x0600AD85 RID: 44421 RVA: 0x0030F9C0 File Offset: 0x0030DBC0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool QangBtGqhiDthbAvaxfK()
				{
					return true;
				}

				// Token: 0x0600AD86 RID: 44422 RVA: 0x0030F9C8 File Offset: 0x0030DBC8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static IdentificationResponse.Types.Success U380mcGqrlkSp17GXFWO()
				{
					return null;
				}

				// Token: 0x04003FB3 RID: 16307
				private static readonly MessageParser<IdentificationResponse.Types.Success> _parser;

				// Token: 0x04003FB4 RID: 16308
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003FB5 RID: 16309
				private int _hasBits0;

				// Token: 0x04003FB6 RID: 16310
				public const int AccountIdFieldNumber = 1;

				// Token: 0x04003FB7 RID: 16311
				private long accountId_;

				// Token: 0x04003FB8 RID: 16312
				public const int AccountNicknameFieldNumber = 2;

				// Token: 0x04003FB9 RID: 16313
				private string accountNickname_;

				// Token: 0x04003FBA RID: 16314
				public const int AccountTagFieldNumber = 3;

				// Token: 0x04003FBB RID: 16315
				private string accountTag_;

				// Token: 0x04003FBC RID: 16316
				public const int ServerListFieldNumber = 4;

				// Token: 0x04003FBD RID: 16317
				private ServerList serverList_;

				// Token: 0x04003FBE RID: 16318
				public const int SubscriptionEndDateFieldNumber = 5;

				// Token: 0x04003FBF RID: 16319
				private string subscriptionEndDate_;

				// Token: 0x04003FC0 RID: 16320
				public const int RightsFieldNumber = 6;

				// Token: 0x04003FC1 RID: 16321
				private IdentificationResponse.Types.Success.Types.Rights rights_;

				// Token: 0x04003FC2 RID: 16322
				public const int FightReconnectionServerIdFieldNumber = 7;

				// Token: 0x04003FC3 RID: 16323
				private static readonly int FightReconnectionServerIdDefaultValue;

				// Token: 0x04003FC4 RID: 16324
				private int fightReconnectionServerId_;

				// Token: 0x04003FC5 RID: 16325
				private static IdentificationResponse.Types.Success L8YDJ2GqWKV4DTPgH25G;

				// Token: 0x02000E15 RID: 3605
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600AD87 RID: 44423 RVA: 0x0031AABC File Offset: 0x00318CBC
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000E16 RID: 3606
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Rights : IMessage<IdentificationResponse.Types.Success.Types.Rights>, IMessage, IEquatable<IdentificationResponse.Types.Success.Types.Rights>, IDeepCloneable<IdentificationResponse.Types.Success.Types.Rights>, IBufferMessage
					{
						// Token: 0x1700202D RID: 8237
						// (get) Token: 0x0600AD88 RID: 44424 RVA: 0x00320488 File Offset: 0x0031E688
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<IdentificationResponse.Types.Success.Types.Rights> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700202E RID: 8238
						// (get) Token: 0x0600AD89 RID: 44425 RVA: 0x00320498 File Offset: 0x0031E698
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

						// Token: 0x1700202F RID: 8239
						// (get) Token: 0x0600AD8A RID: 44426 RVA: 0x003204A8 File Offset: 0x0031E6A8
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

						// Token: 0x0600AD8B RID: 44427 RVA: 0x003204B8 File Offset: 0x0031E6B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Rights()
						{
						}

						// Token: 0x0600AD8C RID: 44428 RVA: 0x003204C8 File Offset: 0x0031E6C8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Rights(IdentificationResponse.Types.Success.Types.Rights other)
						{
						}

						// Token: 0x0600AD8D RID: 44429 RVA: 0x003204D8 File Offset: 0x0031E6D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public IdentificationResponse.Types.Success.Types.Rights Clone()
						{
							return null;
						}

						// Token: 0x17002030 RID: 8240
						// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x003204E8 File Offset: 0x0031E6E8
						// (set) Token: 0x0600AD8F RID: 44431 RVA: 0x003204F8 File Offset: 0x0031E6F8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool ShowForceAccount
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17002031 RID: 8241
						// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x00320508 File Offset: 0x0031E708
						// (set) Token: 0x0600AD91 RID: 44433 RVA: 0x00320518 File Offset: 0x0031E718
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool ShowConsole
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17002032 RID: 8242
						// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x00320528 File Offset: 0x0031E728
						// (set) Token: 0x0600AD93 RID: 44435 RVA: 0x00320538 File Offset: 0x0031E738
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public bool UnlimitedAccess
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17002033 RID: 8243
						// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x00320548 File Offset: 0x0031E748
						// (set) Token: 0x0600AD95 RID: 44437 RVA: 0x00320558 File Offset: 0x0031E758
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool InfiniteSubscription
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17002034 RID: 8244
						// (get) Token: 0x0600AD96 RID: 44438 RVA: 0x00320568 File Offset: 0x0031E768
						// (set) Token: 0x0600AD97 RID: 44439 RVA: 0x00320578 File Offset: 0x0031E778
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool Report
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return true;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x0600AD98 RID: 44440 RVA: 0x00320588 File Offset: 0x0031E788
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600AD99 RID: 44441 RVA: 0x00320598 File Offset: 0x0031E798
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(IdentificationResponse.Types.Success.Types.Rights other)
						{
							return true;
						}

						// Token: 0x0600AD9A RID: 44442 RVA: 0x003205A8 File Offset: 0x0031E7A8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600AD9B RID: 44443 RVA: 0x003205B8 File Offset: 0x0031E7B8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600AD9C RID: 44444 RVA: 0x003205C8 File Offset: 0x0031E7C8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600AD9D RID: 44445 RVA: 0x003205D8 File Offset: 0x0031E7D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600AD9E RID: 44446 RVA: 0x003205E8 File Offset: 0x0031E7E8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600AD9F RID: 44447 RVA: 0x003205F8 File Offset: 0x0031E7F8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(IdentificationResponse.Types.Success.Types.Rights other)
						{
						}

						// Token: 0x0600ADA0 RID: 44448 RVA: 0x00320608 File Offset: 0x0031E808
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600ADA1 RID: 44449 RVA: 0x00320618 File Offset: 0x0031E818
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600ADA2 RID: 44450 RVA: 0x00320628 File Offset: 0x0031E828
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Rights()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 2;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									return;
								case 1:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 4;
									break;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
									{
										num2 = 1;
									}
									break;
								case 3:
									IdentificationResponse.Types.Success.Types.Rights._parser = new MessageParser<IdentificationResponse.Types.Success.Types.Rights>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
									{
										num2 = 0;
									}
									break;
								case 4:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 3;
									break;
								}
							}
						}

						// Token: 0x0600ADA3 RID: 44451 RVA: 0x003206F4 File Offset: 0x0031E8F4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool I3RFkOgGYiC8hpQZT929()
						{
							return true;
						}

						// Token: 0x0600ADA4 RID: 44452 RVA: 0x003206FC File Offset: 0x0031E8FC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static IdentificationResponse.Types.Success.Types.Rights Ebsk64gGbJwAi5ImDBNn()
						{
							return null;
						}

						// Token: 0x04003FC6 RID: 16326
						private static readonly MessageParser<IdentificationResponse.Types.Success.Types.Rights> _parser;

						// Token: 0x04003FC7 RID: 16327
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003FC8 RID: 16328
						public const int ShowForceAccountFieldNumber = 1;

						// Token: 0x04003FC9 RID: 16329
						private bool showForceAccount_;

						// Token: 0x04003FCA RID: 16330
						public const int ShowConsoleFieldNumber = 2;

						// Token: 0x04003FCB RID: 16331
						private bool showConsole_;

						// Token: 0x04003FCC RID: 16332
						public const int UnlimitedAccessFieldNumber = 3;

						// Token: 0x04003FCD RID: 16333
						private bool unlimitedAccess_;

						// Token: 0x04003FCE RID: 16334
						public const int InfiniteSubscriptionFieldNumber = 4;

						// Token: 0x04003FCF RID: 16335
						private bool infiniteSubscription_;

						// Token: 0x04003FD0 RID: 16336
						public const int ReportFieldNumber = 5;

						// Token: 0x04003FD1 RID: 16337
						private bool report_;

						// Token: 0x04003FD2 RID: 16338
						internal static IdentificationResponse.Types.Success.Types.Rights VLhecGgGHkOLtym7PSjV;
					}
				}
			}

			// Token: 0x02000E19 RID: 3609
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<IdentificationResponse.Types.Error>, IMessage, IEquatable<IdentificationResponse.Types.Error>, IDeepCloneable<IdentificationResponse.Types.Error>, IBufferMessage
			{
				// Token: 0x17002035 RID: 8245
				// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x0030F9D0 File Offset: 0x0030DBD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<IdentificationResponse.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17002036 RID: 8246
				// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x0030F9E0 File Offset: 0x0030DBE0
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

				// Token: 0x17002037 RID: 8247
				// (get) Token: 0x0600ADB1 RID: 44465 RVA: 0x0030F9F0 File Offset: 0x0030DBF0
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

				// Token: 0x0600ADB2 RID: 44466 RVA: 0x0030FA00 File Offset: 0x0030DC00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x0600ADB3 RID: 44467 RVA: 0x0030FA10 File Offset: 0x0030DC10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(IdentificationResponse.Types.Error other)
				{
				}

				// Token: 0x0600ADB4 RID: 44468 RVA: 0x0030FA20 File Offset: 0x0030DC20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public IdentificationResponse.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x17002038 RID: 8248
				// (get) Token: 0x0600ADB5 RID: 44469 RVA: 0x0030FA30 File Offset: 0x0030DC30
				// (set) Token: 0x0600ADB6 RID: 44470 RVA: 0x0030FA44 File Offset: 0x0030DC44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public IdentificationResponse.Types.Error.Types.Reason Reason
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (IdentificationResponse.Types.Error.Types.Reason)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17002039 RID: 8249
				// (get) Token: 0x0600ADB7 RID: 44471 RVA: 0x0030FA54 File Offset: 0x0030DC54
				// (set) Token: 0x0600ADB8 RID: 44472 RVA: 0x0030FA64 File Offset: 0x0030DC64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string BanEndDate
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

				// Token: 0x1700203A RID: 8250
				// (get) Token: 0x0600ADB9 RID: 44473 RVA: 0x0030FA74 File Offset: 0x0030DC74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasBanEndDate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x0600ADBA RID: 44474 RVA: 0x0030FA84 File Offset: 0x0030DC84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearBanEndDate()
				{
				}

				// Token: 0x1700203B RID: 8251
				// (get) Token: 0x0600ADBB RID: 44475 RVA: 0x0030FA94 File Offset: 0x0030DC94
				// (set) Token: 0x0600ADBC RID: 44476 RVA: 0x0030FAA4 File Offset: 0x0030DCA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string RequiredVersion
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

				// Token: 0x1700203C RID: 8252
				// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x0030FAB4 File Offset: 0x0030DCB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasRequiredVersion
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x0600ADBE RID: 44478 RVA: 0x0030FAC4 File Offset: 0x0030DCC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearRequiredVersion()
				{
				}

				// Token: 0x0600ADBF RID: 44479 RVA: 0x0030FAD4 File Offset: 0x0030DCD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600ADC0 RID: 44480 RVA: 0x0030FAE4 File Offset: 0x0030DCE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(IdentificationResponse.Types.Error other)
				{
					return true;
				}

				// Token: 0x0600ADC1 RID: 44481 RVA: 0x0030FAF4 File Offset: 0x0030DCF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600ADC2 RID: 44482 RVA: 0x0030FB04 File Offset: 0x0030DD04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600ADC3 RID: 44483 RVA: 0x0030FB14 File Offset: 0x0030DD14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600ADC4 RID: 44484 RVA: 0x0030FB24 File Offset: 0x0030DD24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600ADC5 RID: 44485 RVA: 0x0030FB34 File Offset: 0x0030DD34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600ADC6 RID: 44486 RVA: 0x0030FB44 File Offset: 0x0030DD44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(IdentificationResponse.Types.Error other)
				{
				}

				// Token: 0x0600ADC7 RID: 44487 RVA: 0x0030FB54 File Offset: 0x0030DD54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600ADC8 RID: 44488 RVA: 0x0030FB64 File Offset: 0x0030DD64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600ADC9 RID: 44489 RVA: 0x0030FB74 File Offset: 0x0030DD74
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							IdentificationResponse.Types.Error.BanEndDateDefaultValue = "";
							num2 = 5;
							continue;
						case 3:
							IdentificationResponse.Types.Error._parser = new MessageParser<IdentificationResponse.Types.Error>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						case 5:
							IdentificationResponse.Types.Error.RequiredVersionDefaultValue = "";
							num2 = 4;
							continue;
						case 6:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
						{
							num2 = 6;
						}
					}
				}

				// Token: 0x0600ADCA RID: 44490 RVA: 0x0030FC9C File Offset: 0x0030DE9C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool mrOon2Gq0b9gRx9oVjcW()
				{
					return true;
				}

				// Token: 0x0600ADCB RID: 44491 RVA: 0x0030FCA4 File Offset: 0x0030DEA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static IdentificationResponse.Types.Error oTJtpLGqC8CXBen9RqVp()
				{
					return null;
				}

				// Token: 0x04003FD7 RID: 16343
				private static readonly MessageParser<IdentificationResponse.Types.Error> _parser;

				// Token: 0x04003FD8 RID: 16344
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003FD9 RID: 16345
				public const int ReasonFieldNumber = 1;

				// Token: 0x04003FDA RID: 16346
				private IdentificationResponse.Types.Error.Types.Reason reason_;

				// Token: 0x04003FDB RID: 16347
				public const int BanEndDateFieldNumber = 2;

				// Token: 0x04003FDC RID: 16348
				private static readonly string BanEndDateDefaultValue;

				// Token: 0x04003FDD RID: 16349
				private string banEndDate_;

				// Token: 0x04003FDE RID: 16350
				public const int RequiredVersionFieldNumber = 3;

				// Token: 0x04003FDF RID: 16351
				private static readonly string RequiredVersionDefaultValue;

				// Token: 0x04003FE0 RID: 16352
				private string requiredVersion_;

				// Token: 0x04003FE1 RID: 16353
				private static IdentificationResponse.Types.Error juM18QGqVpwVU6jJbuwV;

				// Token: 0x02000E1A RID: 3610
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600ADCC RID: 44492 RVA: 0x0031ABE0 File Offset: 0x00318DE0
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000E1B RID: 3611
					public enum Reason
					{
						// Token: 0x04003FE3 RID: 16355
						[OriginalName("UNKNOWN_AUTH_ERROR")]
						UnknownAuthError,
						// Token: 0x04003FE4 RID: 16356
						[OriginalName("ALREADY_CONNECTED")]
						AlreadyConnected,
						// Token: 0x04003FE5 RID: 16357
						[OriginalName("OTP_TIMEOUT")]
						OtpTimeout,
						// Token: 0x04003FE6 RID: 16358
						[OriginalName("BANNED")]
						Banned,
						// Token: 0x04003FE7 RID: 16359
						[OriginalName("INVALID_SHIELD_CERTIFICATE")]
						InvalidShieldCertificate,
						// Token: 0x04003FE8 RID: 16360
						[OriginalName("LOCKED")]
						Locked,
						// Token: 0x04003FE9 RID: 16361
						[OriginalName("CREDENTIALS_RESET")]
						CredentialsReset,
						// Token: 0x04003FEA RID: 16362
						[OriginalName("WRONG_CREDENTIALS")]
						WrongCredentials,
						// Token: 0x04003FEB RID: 16363
						[OriginalName("EMAIL_UNVALIDATED")]
						EmailUnvalidated,
						// Token: 0x04003FEC RID: 16364
						[OriginalName("ANONYMOUS_IP_FORBIDDEN")]
						AnonymousIpForbidden,
						// Token: 0x04003FED RID: 16365
						[OriginalName("NICKNAME_REGISTRATION")]
						NicknameRegistration,
						// Token: 0x04003FEE RID: 16366
						[OriginalName("UNAUTHORIZED")]
						Unauthorized,
						// Token: 0x04003FEF RID: 16367
						[OriginalName("INVALID_CLIENT_VERSION")]
						InvalidClientVersion,
						// Token: 0x04003FF0 RID: 16368
						[OriginalName("OUTDATED_CLIENT_VERSION")]
						OutdatedClientVersion
					}
				}
			}
		}
	}
}
