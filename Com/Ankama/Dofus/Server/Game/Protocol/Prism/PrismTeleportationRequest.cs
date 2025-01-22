using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001C9 RID: 457
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismTeleportationRequest : IMessage<PrismTeleportationRequest>, IMessage, IEquatable<PrismTeleportationRequest>, IDeepCloneable<PrismTeleportationRequest>, IBufferMessage
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x001A6D54 File Offset: 0x001A4F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismTeleportationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x001A6D64 File Offset: 0x001A4F64
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x001A6D74 File Offset: 0x001A4F74
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

		// Token: 0x06001555 RID: 5461 RVA: 0x001A6D84 File Offset: 0x001A4F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismTeleportationRequest()
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x001A6D94 File Offset: 0x001A4F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismTeleportationRequest(PrismTeleportationRequest other)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x001A6DA4 File Offset: 0x001A4FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismTeleportationRequest Clone()
		{
			return null;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x001A6DB4 File Offset: 0x001A4FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x001A6DC4 File Offset: 0x001A4FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismTeleportationRequest other)
		{
			return true;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x001A6DD4 File Offset: 0x001A4FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x001A6DE4 File Offset: 0x001A4FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x001A6DF4 File Offset: 0x001A4FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x001A6E04 File Offset: 0x001A5004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x001A6E14 File Offset: 0x001A5014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x001A6E24 File Offset: 0x001A5024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismTeleportationRequest other)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x001A6E34 File Offset: 0x001A5034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x001A6E44 File Offset: 0x001A5044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x001A6E54 File Offset: 0x001A5054
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismTeleportationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					PrismTeleportationRequest._parser = new MessageParser<PrismTeleportationRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x001A6F38 File Offset: 0x001A5138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kHt1ARO1Gv19R8wlsDXf()
		{
			return true;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x001A6F40 File Offset: 0x001A5140
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismTeleportationRequest L8Sb6WO1gJ51hkpDduBt()
		{
			return null;
		}

		// Token: 0x0400079D RID: 1949
		private static readonly MessageParser<PrismTeleportationRequest> _parser;

		// Token: 0x0400079E RID: 1950
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400079F RID: 1951
		internal static PrismTeleportationRequest S3BnLCO1JywrGXtEiaEk;
	}
}
