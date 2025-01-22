using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000701 RID: 1793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeHandleMountsRequest : IMessage<ExchangeHandleMountsRequest>, IMessage, IEquatable<ExchangeHandleMountsRequest>, IDeepCloneable<ExchangeHandleMountsRequest>, IBufferMessage
	{
		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x00215440 File Offset: 0x00213640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeHandleMountsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x00215450 File Offset: 0x00213650
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x00215460 File Offset: 0x00213660
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

		// Token: 0x060057C2 RID: 22466 RVA: 0x00215470 File Offset: 0x00213670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeHandleMountsRequest()
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00215480 File Offset: 0x00213680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeHandleMountsRequest(ExchangeHandleMountsRequest other)
		{
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00215490 File Offset: 0x00213690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeHandleMountsRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x002154A0 File Offset: 0x002136A0
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x002154B4 File Offset: 0x002136B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHandleMountsRequest.Types.ExchangeHandleMountStableType ActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeHandleMountsRequest.Types.ExchangeHandleMountStableType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x002154C4 File Offset: 0x002136C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> RidesId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x002154D4 File Offset: 0x002136D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x002154E4 File Offset: 0x002136E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeHandleMountsRequest other)
		{
			return true;
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x002154F4 File Offset: 0x002136F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00215504 File Offset: 0x00213704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00215514 File Offset: 0x00213714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00215524 File Offset: 0x00213724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00215534 File Offset: 0x00213734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00215544 File Offset: 0x00213744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeHandleMountsRequest other)
		{
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00215554 File Offset: 0x00213754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00215564 File Offset: 0x00213764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x00215574 File Offset: 0x00213774
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeHandleMountsRequest()
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
					num2 = 5;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ExchangeHandleMountsRequest._repeated_ridesId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					ExchangeHandleMountsRequest._parser = new MessageParser<ExchangeHandleMountsRequest>(() => null);
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x00215660 File Offset: 0x00213860
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TAUqhAOuJx9xnekaGFqK()
		{
			return true;
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00215668 File Offset: 0x00213868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeHandleMountsRequest y0HwytOuGbu0YcmIQJ6u()
		{
			return null;
		}

		// Token: 0x04001EB3 RID: 7859
		private static readonly MessageParser<ExchangeHandleMountsRequest> _parser;

		// Token: 0x04001EB4 RID: 7860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EB5 RID: 7861
		public const int ActionTypeFieldNumber = 1;

		// Token: 0x04001EB6 RID: 7862
		private ExchangeHandleMountsRequest.Types.ExchangeHandleMountStableType actionType_;

		// Token: 0x04001EB7 RID: 7863
		public const int RidesIdFieldNumber = 2;

		// Token: 0x04001EB8 RID: 7864
		private static readonly FieldCodec<int> _repeated_ridesId_codec;

		// Token: 0x04001EB9 RID: 7865
		private readonly RepeatedField<int> ridesId_;

		// Token: 0x04001EBA RID: 7866
		internal static ExchangeHandleMountsRequest JbjrFDOuOT8U90Z1Xy7F;

		// Token: 0x02000702 RID: 1794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060057D5 RID: 22485 RVA: 0x002CE298 File Offset: 0x002CC498
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000703 RID: 1795
			public enum ExchangeHandleMountStableType
			{
				// Token: 0x04001EBC RID: 7868
				[OriginalName("EXCHANGE_MOUNT_STABLES_PUT")]
				ExchangeMountStablesPut,
				// Token: 0x04001EBD RID: 7869
				[OriginalName("EXCHANGE_MOUNT_STABLES_GET")]
				ExchangeMountStablesGet,
				// Token: 0x04001EBE RID: 7870
				[OriginalName("EXCHANGE_MOUNT_STABLES_FREE")]
				ExchangeMountStablesFree,
				// Token: 0x04001EBF RID: 7871
				[OriginalName("EXCHANGE_MOUNT_STABLES_CERTIF")]
				ExchangeMountStablesCertif,
				// Token: 0x04001EC0 RID: 7872
				[OriginalName("EXCHANGE_MOUNT_STABLES_UNCERTIF")]
				ExchangeMountStablesUncertif,
				// Token: 0x04001EC1 RID: 7873
				[OriginalName("EXCHANGE_MOUNT_PADDOCK_PUT")]
				ExchangeMountPaddockPut,
				// Token: 0x04001EC2 RID: 7874
				[OriginalName("EXCHANGE_MOUNT_PADDOCK_GET")]
				ExchangeMountPaddockGet,
				// Token: 0x04001EC3 RID: 7875
				[OriginalName("EXCHANGE_MOUNT_PADDOCK_FREE")]
				ExchangeMountPaddockFree,
				// Token: 0x04001EC4 RID: 7876
				[OriginalName("EXCHANGE_EQUIPPED_MOUNT_PADDOCK_PUT")]
				ExchangeEquippedMountPaddockPut,
				// Token: 0x04001EC5 RID: 7877
				[OriginalName("EXCHANGE_EQUIPPED_MOUNT_PADDOCK_GET")]
				ExchangeEquippedMountPaddockGet,
				// Token: 0x04001EC6 RID: 7878
				[OriginalName("EXCHANGE_EQUIPPED_FREE")]
				ExchangeEquippedFree,
				// Token: 0x04001EC7 RID: 7879
				[OriginalName("EXCHANGE_CERTIFICATE_FREE")]
				ExchangeCertificateFree,
				// Token: 0x04001EC8 RID: 7880
				[OriginalName("EXCHANGE_EQUIPPED_CERTIF")]
				ExchangeEquippedCertif,
				// Token: 0x04001EC9 RID: 7881
				[OriginalName("EXCHANGE_MOUNT_PADDOCK_CERTIF")]
				ExchangeMountPaddockCertif,
				// Token: 0x04001ECA RID: 7882
				[OriginalName("EXCHANGE_UNCERTIF_TO_EQUIPPED")]
				ExchangeUncertifToEquipped,
				// Token: 0x04001ECB RID: 7883
				[OriginalName("EXCHANGE_UNCERTIF_TO_PADDOCK")]
				ExchangeUncertifToPaddock,
				// Token: 0x04001ECC RID: 7884
				[OriginalName("EXCHANGE_MOUNT_STABLES_STERILIZE")]
				ExchangeMountStablesSterilize,
				// Token: 0x04001ECD RID: 7885
				[OriginalName("EXCHANGE_EQUIPPED_STERILIZE")]
				ExchangeEquippedSterilize,
				// Token: 0x04001ECE RID: 7886
				[OriginalName("EXCHANGE_MOUNT_PADDOCK_STERILIZE")]
				ExchangeMountPaddockSterilize
			}
		}
	}
}
