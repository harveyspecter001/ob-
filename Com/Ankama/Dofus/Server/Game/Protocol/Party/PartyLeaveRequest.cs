using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000298 RID: 664
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyLeaveRequest : IMessage<PartyLeaveRequest>, IMessage, IEquatable<PartyLeaveRequest>, IDeepCloneable<PartyLeaveRequest>, IBufferMessage
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x001B8340 File Offset: 0x001B6540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyLeaveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x001B8350 File Offset: 0x001B6550
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x001B8360 File Offset: 0x001B6560
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

		// Token: 0x06001F05 RID: 7941 RVA: 0x001B8370 File Offset: 0x001B6570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveRequest()
		{
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x001B8380 File Offset: 0x001B6580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveRequest(PartyLeaveRequest other)
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x001B8390 File Offset: 0x001B6590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLeaveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x001B83A0 File Offset: 0x001B65A0
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x001B83B0 File Offset: 0x001B65B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06001F0A RID: 7946 RVA: 0x001B83C0 File Offset: 0x001B65C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x001B83D0 File Offset: 0x001B65D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyLeaveRequest other)
		{
			return true;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x001B83E0 File Offset: 0x001B65E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x001B83F0 File Offset: 0x001B65F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x001B8400 File Offset: 0x001B6600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x001B8410 File Offset: 0x001B6610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x001B8420 File Offset: 0x001B6620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x001B8430 File Offset: 0x001B6630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyLeaveRequest other)
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x001B8440 File Offset: 0x001B6640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x001B8450 File Offset: 0x001B6650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x001B8460 File Offset: 0x001B6660
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyLeaveRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyLeaveRequest._parser = new MessageParser<PartyLeaveRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x001B8544 File Offset: 0x001B6744
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KE6algOy04WxANc4hwbY()
		{
			return true;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x001B854C File Offset: 0x001B674C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyLeaveRequest bod1KhOyCbofleW4CruF()
		{
			return null;
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly MessageParser<PartyLeaveRequest> _parser;

		// Token: 0x04000AF6 RID: 2806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AF7 RID: 2807
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AF8 RID: 2808
		private int partyId_;

		// Token: 0x04000AF9 RID: 2809
		internal static PartyLeaveRequest QlnAmqOyVQRGXOe09CuS;
	}
}
