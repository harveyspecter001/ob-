using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D40 RID: 3392
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMembershipEvent : IMessage<AllianceMembershipEvent>, IMessage, IEquatable<AllianceMembershipEvent>, IDeepCloneable<AllianceMembershipEvent>, IBufferMessage
	{
		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x0028C6C4 File Offset: 0x0028A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceMembershipEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x0028C6D4 File Offset: 0x0028A8D4
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

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x0028C6E4 File Offset: 0x0028A8E4
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

		// Token: 0x0600A360 RID: 41824 RVA: 0x0028C6F4 File Offset: 0x0028A8F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMembershipEvent()
		{
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x0028C704 File Offset: 0x0028A904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMembershipEvent(AllianceMembershipEvent other)
		{
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x0028C714 File Offset: 0x0028A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMembershipEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600A363 RID: 41827 RVA: 0x0028C724 File Offset: 0x0028A924
		// (set) Token: 0x0600A364 RID: 41828 RVA: 0x0028C734 File Offset: 0x0028A934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceInformation AllianceInformation
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

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x0028C744 File Offset: 0x0028A944
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x0028C754 File Offset: 0x0028A954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankId
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

		// Token: 0x0600A367 RID: 41831 RVA: 0x0028C764 File Offset: 0x0028A964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x0028C774 File Offset: 0x0028A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMembershipEvent other)
		{
			return true;
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x0028C784 File Offset: 0x0028A984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x0028C794 File Offset: 0x0028A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x0028C7A4 File Offset: 0x0028A9A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x0028C7B4 File Offset: 0x0028A9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0028C7C4 File Offset: 0x0028A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x0028C7D4 File Offset: 0x0028A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMembershipEvent other)
		{
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x0028C7E4 File Offset: 0x0028A9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x0028C7F4 File Offset: 0x0028A9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x0028C804 File Offset: 0x0028AA04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMembershipEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_82;
					case 4:
						return;
					}
					AllianceMembershipEvent._parser = new MessageParser<AllianceMembershipEvent>(() => null);
					num2 = 4;
				}
				IL_82:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x0028C8D4 File Offset: 0x0028AAD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yaZtA8JIcuuOn9g071lD()
		{
			return true;
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x0028C8DC File Offset: 0x0028AADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMembershipEvent Lw0NN0JIULsQ5NrEnvnN()
		{
			return null;
		}

		// Token: 0x04003C40 RID: 15424
		private static readonly MessageParser<AllianceMembershipEvent> _parser;

		// Token: 0x04003C41 RID: 15425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C42 RID: 15426
		public const int AllianceInformationFieldNumber = 1;

		// Token: 0x04003C43 RID: 15427
		private AllianceInformation allianceInformation_;

		// Token: 0x04003C44 RID: 15428
		public const int RankIdFieldNumber = 2;

		// Token: 0x04003C45 RID: 15429
		private int rankId_;

		// Token: 0x04003C46 RID: 15430
		internal static AllianceMembershipEvent yQLxxFJIlDFh8bjiAosm;
	}
}
