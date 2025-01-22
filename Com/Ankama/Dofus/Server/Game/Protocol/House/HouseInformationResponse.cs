using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000451 RID: 1105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseInformationResponse : IMessage<HouseInformationResponse>, IMessage, IEquatable<HouseInformationResponse>, IDeepCloneable<HouseInformationResponse>, IBufferMessage
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x001DADF0 File Offset: 0x001D8FF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseInformationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x001DAE00 File Offset: 0x001D9000
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x001DAE10 File Offset: 0x001D9010
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

		// Token: 0x06003487 RID: 13447 RVA: 0x001DAE20 File Offset: 0x001D9020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationResponse()
		{
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x001DAE30 File Offset: 0x001D9030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationResponse(HouseInformationResponse other)
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x001DAE40 File Offset: 0x001D9040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInformationResponse Clone()
		{
			return null;
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x001DAE50 File Offset: 0x001D9050
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x001DAE60 File Offset: 0x001D9060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HouseInstance HouseInformation
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

		// Token: 0x0600348C RID: 13452 RVA: 0x001DAE70 File Offset: 0x001D9070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x001DAE80 File Offset: 0x001D9080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseInformationResponse other)
		{
			return true;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x001DAE90 File Offset: 0x001D9090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x001DAEA0 File Offset: 0x001D90A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x001DAEB0 File Offset: 0x001D90B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x001DAEC0 File Offset: 0x001D90C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x001DAED0 File Offset: 0x001D90D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x001DAEE0 File Offset: 0x001D90E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseInformationResponse other)
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x001DAEF0 File Offset: 0x001D90F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x001DAF00 File Offset: 0x001D9100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x001DAF10 File Offset: 0x001D9110
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseInformationResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				HouseInformationResponse._parser = new MessageParser<HouseInformationResponse>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x001DAFF4 File Offset: 0x001D91F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IKLpaWODzfvEk1jBSqMT()
		{
			return true;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x001DAFFC File Offset: 0x001D91FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseInformationResponse LgbqctOtfFKquneaQxFu()
		{
			return null;
		}

		// Token: 0x0400125B RID: 4699
		private static readonly MessageParser<HouseInformationResponse> _parser;

		// Token: 0x0400125C RID: 4700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400125D RID: 4701
		public const int HouseInformationFieldNumber = 1;

		// Token: 0x0400125E RID: 4702
		private HouseInstance houseInformation_;

		// Token: 0x0400125F RID: 4703
		private static HouseInformationResponse ruyco6ODFk0Kt6PsK8rN;
	}
}
