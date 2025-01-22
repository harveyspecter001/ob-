using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000292 RID: 658
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyFollowMemberRequest : IMessage<PartyFollowMemberRequest>, IMessage, IEquatable<PartyFollowMemberRequest>, IDeepCloneable<PartyFollowMemberRequest>, IBufferMessage
	{
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x001B7C5C File Offset: 0x001B5E5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyFollowMemberRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x001B7C6C File Offset: 0x001B5E6C
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x001B7C7C File Offset: 0x001B5E7C
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

		// Token: 0x06001EAF RID: 7855 RVA: 0x001B7C8C File Offset: 0x001B5E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowMemberRequest()
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x001B7C9C File Offset: 0x001B5E9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowMemberRequest(PartyFollowMemberRequest other)
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x001B7CAC File Offset: 0x001B5EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyFollowMemberRequest Clone()
		{
			return null;
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x001B7CBC File Offset: 0x001B5EBC
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x001B7CCC File Offset: 0x001B5ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartyId
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x001B7CDC File Offset: 0x001B5EDC
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x001B7CEC File Offset: 0x001B5EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x001B7CFC File Offset: 0x001B5EFC
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x001B7D0C File Offset: 0x001B5F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enabled
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x001B7D1C File Offset: 0x001B5F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x001B7D2C File Offset: 0x001B5F2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEnabled()
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x001B7D3C File Offset: 0x001B5F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x001B7D4C File Offset: 0x001B5F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyFollowMemberRequest other)
		{
			return true;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x001B7D5C File Offset: 0x001B5F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x001B7D6C File Offset: 0x001B5F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x001B7D7C File Offset: 0x001B5F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x001B7D8C File Offset: 0x001B5F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x001B7D9C File Offset: 0x001B5F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x001B7DAC File Offset: 0x001B5FAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyFollowMemberRequest other)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x001B7DBC File Offset: 0x001B5FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x001B7DCC File Offset: 0x001B5FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x001B7DDC File Offset: 0x001B5FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyFollowMemberRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				case 5:
					PartyFollowMemberRequest._parser = new MessageParser<PartyFollowMemberRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyFollowMemberRequest.EnabledDefaultValue = false;
				num2 = 4;
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x001B7ED4 File Offset: 0x001B60D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YX1AjGOyaWF4gqtDdTox()
		{
			return true;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x001B7EDC File Offset: 0x001B60DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyFollowMemberRequest QDYmQ0Oy5DZgZhg9J8mB()
		{
			return null;
		}

		// Token: 0x04000AD8 RID: 2776
		private static readonly MessageParser<PartyFollowMemberRequest> _parser;

		// Token: 0x04000AD9 RID: 2777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ADA RID: 2778
		private int _hasBits0;

		// Token: 0x04000ADB RID: 2779
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000ADC RID: 2780
		private int partyId_;

		// Token: 0x04000ADD RID: 2781
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000ADE RID: 2782
		private long playerId_;

		// Token: 0x04000ADF RID: 2783
		public const int EnabledFieldNumber = 3;

		// Token: 0x04000AE0 RID: 2784
		private static readonly bool EnabledDefaultValue;

		// Token: 0x04000AE1 RID: 2785
		private bool enabled_;

		// Token: 0x04000AE2 RID: 2786
		private static PartyFollowMemberRequest HgQfOEOy1IslqjFapSDg;
	}
}
