using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006D6 RID: 1750
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferAllFromInventoryRequest : IMessage<ExchangeObjectTransferAllFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferAllFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferAllFromInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x00212A28 File Offset: 0x00210C28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectTransferAllFromInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x0600559A RID: 21914 RVA: 0x00212A38 File Offset: 0x00210C38
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

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x00212A48 File Offset: 0x00210C48
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

		// Token: 0x0600559C RID: 21916 RVA: 0x00212A58 File Offset: 0x00210C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllFromInventoryRequest()
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00212A68 File Offset: 0x00210C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllFromInventoryRequest(ExchangeObjectTransferAllFromInventoryRequest other)
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00212A78 File Offset: 0x00210C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllFromInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00212A88 File Offset: 0x00210C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00212A98 File Offset: 0x00210C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferAllFromInventoryRequest other)
		{
			return true;
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00212AA8 File Offset: 0x00210CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00212AB8 File Offset: 0x00210CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x00212AC8 File Offset: 0x00210CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00212AD8 File Offset: 0x00210CD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00212AE8 File Offset: 0x00210CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00212AF8 File Offset: 0x00210CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferAllFromInventoryRequest other)
		{
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00212B08 File Offset: 0x00210D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00212B18 File Offset: 0x00210D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00212B28 File Offset: 0x00210D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferAllFromInventoryRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					ExchangeObjectTransferAllFromInventoryRequest._parser = new MessageParser<ExchangeObjectTransferAllFromInventoryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00212C20 File Offset: 0x00210E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zHh7l9OMgQM1qb4J178V()
		{
			return true;
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00212C28 File Offset: 0x00210E28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferAllFromInventoryRequest AYniXvOMs2hJKTY7AFVR()
		{
			return null;
		}

		// Token: 0x04001E17 RID: 7703
		private static readonly MessageParser<ExchangeObjectTransferAllFromInventoryRequest> _parser;

		// Token: 0x04001E18 RID: 7704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E19 RID: 7705
		private static ExchangeObjectTransferAllFromInventoryRequest HaEd3wOMGB6s1APydDRr;
	}
}
