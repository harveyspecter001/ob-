using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006DE RID: 1758
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMoveKamaRequest : IMessage<ExchangeMoveKamaRequest>, IMessage, IEquatable<ExchangeMoveKamaRequest>, IDeepCloneable<ExchangeMoveKamaRequest>, IBufferMessage
	{
		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x00213270 File Offset: 0x00211470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMoveKamaRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x00213280 File Offset: 0x00211480
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

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x00213290 File Offset: 0x00211490
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

		// Token: 0x060055FF RID: 22015 RVA: 0x002132A0 File Offset: 0x002114A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoveKamaRequest()
		{
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x002132B0 File Offset: 0x002114B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoveKamaRequest(ExchangeMoveKamaRequest other)
		{
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x002132C0 File Offset: 0x002114C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMoveKamaRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x002132D0 File Offset: 0x002114D0
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x002132E0 File Offset: 0x002114E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Quantity
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

		// Token: 0x06005604 RID: 22020 RVA: 0x002132F0 File Offset: 0x002114F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00213300 File Offset: 0x00211500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMoveKamaRequest other)
		{
			return true;
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x00213310 File Offset: 0x00211510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00213320 File Offset: 0x00211520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00213330 File Offset: 0x00211530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00213340 File Offset: 0x00211540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00213350 File Offset: 0x00211550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00213360 File Offset: 0x00211560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMoveKamaRequest other)
		{
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x00213370 File Offset: 0x00211570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00213380 File Offset: 0x00211580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00213390 File Offset: 0x00211590
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMoveKamaRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				ExchangeMoveKamaRequest._parser = new MessageParser<ExchangeMoveKamaRequest>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x00213474 File Offset: 0x00211674
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FRIgeAOMIUMBPUpeSgPo()
		{
			return true;
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x0021347C File Offset: 0x0021167C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMoveKamaRequest dtRWUpOMkhlR7fmJ4fcU()
		{
			return null;
		}

		// Token: 0x04001E30 RID: 7728
		private static readonly MessageParser<ExchangeMoveKamaRequest> _parser;

		// Token: 0x04001E31 RID: 7729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E32 RID: 7730
		public const int QuantityFieldNumber = 1;

		// Token: 0x04001E33 RID: 7731
		private long quantity_;

		// Token: 0x04001E34 RID: 7732
		private static ExchangeMoveKamaRequest Cg8ljaOMKlOcUdgAdS3a;
	}
}
