using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D6C RID: 3436
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFactsEvent : IMessage<AllianceFactsEvent>, IMessage, IEquatable<AllianceFactsEvent>, IDeepCloneable<AllianceFactsEvent>, IBufferMessage
	{
		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600A58E RID: 42382 RVA: 0x00290AF0 File Offset: 0x0028ECF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFactsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x00290B00 File Offset: 0x0028ED00
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

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600A590 RID: 42384 RVA: 0x00290B10 File Offset: 0x0028ED10
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

		// Token: 0x0600A591 RID: 42385 RVA: 0x00290B20 File Offset: 0x0028ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsEvent()
		{
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x00290B30 File Offset: 0x0028ED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsEvent(AllianceFactsEvent other)
		{
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x00290B40 File Offset: 0x0028ED40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600A594 RID: 42388 RVA: 0x00290B50 File Offset: 0x0028ED50
		// (set) Token: 0x0600A595 RID: 42389 RVA: 0x00290B60 File Offset: 0x0028ED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600A596 RID: 42390 RVA: 0x00290B70 File Offset: 0x0028ED70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Character> Members
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x00290B80 File Offset: 0x0028ED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ControlledSubareaIds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600A598 RID: 42392 RVA: 0x00290B90 File Offset: 0x0028ED90
		// (set) Token: 0x0600A599 RID: 42393 RVA: 0x00290BA0 File Offset: 0x0028EDA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long LeaderId
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

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600A59A RID: 42394 RVA: 0x00290BB0 File Offset: 0x0028EDB0
		// (set) Token: 0x0600A59B RID: 42395 RVA: 0x00290BC0 File Offset: 0x0028EDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LeaderName
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

		// Token: 0x0600A59C RID: 42396 RVA: 0x00290BD0 File Offset: 0x0028EDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x00290BE0 File Offset: 0x0028EDE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFactsEvent other)
		{
			return true;
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x00290BF0 File Offset: 0x0028EDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x00290C00 File Offset: 0x0028EE00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x00290C10 File Offset: 0x0028EE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x00290C20 File Offset: 0x0028EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x00290C30 File Offset: 0x0028EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x00290C40 File Offset: 0x0028EE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFactsEvent other)
		{
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x00290C50 File Offset: 0x0028EE50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x00290C60 File Offset: 0x0028EE60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x00290C70 File Offset: 0x0028EE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFactsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceFactsEvent._parser = new MessageParser<AllianceFactsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AllianceFactsEvent._repeated_controlledSubareaIds_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				AllianceFactsEvent._repeated_members_codec = FieldCodec.ForMessage<Character>(18U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
				num2 = 2;
			}
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x00290D80 File Offset: 0x0028EF80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QUQcDEJkUpoCrusE0myY()
		{
			return true;
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x00290D88 File Offset: 0x0028EF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFactsEvent vWPC1uJkvUmw5RCdaeVP()
		{
			return null;
		}

		// Token: 0x04003D05 RID: 15621
		private static readonly MessageParser<AllianceFactsEvent> _parser;

		// Token: 0x04003D06 RID: 15622
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D07 RID: 15623
		public const int AllianceInformationFieldNumber = 1;

		// Token: 0x04003D08 RID: 15624
		private AllianceInformation allianceInformation_;

		// Token: 0x04003D09 RID: 15625
		public const int MembersFieldNumber = 2;

		// Token: 0x04003D0A RID: 15626
		private static readonly FieldCodec<Character> _repeated_members_codec;

		// Token: 0x04003D0B RID: 15627
		private readonly RepeatedField<Character> members_;

		// Token: 0x04003D0C RID: 15628
		public const int ControlledSubareaIdsFieldNumber = 3;

		// Token: 0x04003D0D RID: 15629
		private static readonly FieldCodec<int> _repeated_controlledSubareaIds_codec;

		// Token: 0x04003D0E RID: 15630
		private readonly RepeatedField<int> controlledSubareaIds_;

		// Token: 0x04003D0F RID: 15631
		public const int LeaderIdFieldNumber = 4;

		// Token: 0x04003D10 RID: 15632
		private long leaderId_;

		// Token: 0x04003D11 RID: 15633
		public const int LeaderNameFieldNumber = 5;

		// Token: 0x04003D12 RID: 15634
		private string leaderName_;

		// Token: 0x04003D13 RID: 15635
		internal static AllianceFactsEvent bUu1LsJkcwBk3jfguNMN;
	}
}
