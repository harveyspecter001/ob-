using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D4F RID: 3407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceNameAndTagModificationValidRequest : IMessage<AllianceNameAndTagModificationValidRequest>, IMessage, IEquatable<AllianceNameAndTagModificationValidRequest>, IDeepCloneable<AllianceNameAndTagModificationValidRequest>, IBufferMessage
	{
		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x0600A41F RID: 42015 RVA: 0x0028EDE0 File Offset: 0x0028CFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceNameAndTagModificationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x0600A420 RID: 42016 RVA: 0x0028EDF0 File Offset: 0x0028CFF0
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

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x0600A421 RID: 42017 RVA: 0x0028EE00 File Offset: 0x0028D000
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

		// Token: 0x0600A422 RID: 42018 RVA: 0x0028EE10 File Offset: 0x0028D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceNameAndTagModificationValidRequest()
		{
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x0028EE20 File Offset: 0x0028D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceNameAndTagModificationValidRequest(AllianceNameAndTagModificationValidRequest other)
		{
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x0028EE30 File Offset: 0x0028D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceNameAndTagModificationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x0028EE40 File Offset: 0x0028D040
		// (set) Token: 0x0600A426 RID: 42022 RVA: 0x0028EE50 File Offset: 0x0028D050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AllianceName
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

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600A427 RID: 42023 RVA: 0x0028EE60 File Offset: 0x0028D060
		// (set) Token: 0x0600A428 RID: 42024 RVA: 0x0028EE70 File Offset: 0x0028D070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceTag
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

		// Token: 0x0600A429 RID: 42025 RVA: 0x0028EE80 File Offset: 0x0028D080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x0028EE90 File Offset: 0x0028D090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceNameAndTagModificationValidRequest other)
		{
			return true;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x0028EEA0 File Offset: 0x0028D0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x0028EEB0 File Offset: 0x0028D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x0028EEC0 File Offset: 0x0028D0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x0028EED0 File Offset: 0x0028D0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x0028EEE0 File Offset: 0x0028D0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x0028EEF0 File Offset: 0x0028D0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceNameAndTagModificationValidRequest other)
		{
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x0028EF00 File Offset: 0x0028D100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x0028EF10 File Offset: 0x0028D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x0028EF20 File Offset: 0x0028D120
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceNameAndTagModificationValidRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AllianceNameAndTagModificationValidRequest._parser = new MessageParser<AllianceNameAndTagModificationValidRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x0028EFEC File Offset: 0x0028D1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LbQRTGJIYwpykZDHdcES()
		{
			return true;
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x0028EFF4 File Offset: 0x0028D1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceNameAndTagModificationValidRequest Ff8QrtJIb9PKimjtGoXg()
		{
			return null;
		}

		// Token: 0x04003C7B RID: 15483
		private static readonly MessageParser<AllianceNameAndTagModificationValidRequest> _parser;

		// Token: 0x04003C7C RID: 15484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C7D RID: 15485
		public const int AllianceNameFieldNumber = 1;

		// Token: 0x04003C7E RID: 15486
		private string allianceName_;

		// Token: 0x04003C7F RID: 15487
		public const int AllianceTagFieldNumber = 2;

		// Token: 0x04003C80 RID: 15488
		private string allianceTag_;

		// Token: 0x04003C81 RID: 15489
		private static AllianceNameAndTagModificationValidRequest ceGB3eJIH5idaor0yGPN;
	}
}
