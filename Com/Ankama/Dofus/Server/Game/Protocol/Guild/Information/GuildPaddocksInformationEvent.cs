using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x0200051A RID: 1306
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildPaddocksInformationEvent : IMessage<GuildPaddocksInformationEvent>, IMessage, IEquatable<GuildPaddocksInformationEvent>, IDeepCloneable<GuildPaddocksInformationEvent>, IBufferMessage
	{
		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x001EB808 File Offset: 0x001E9A08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildPaddocksInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x001EB818 File Offset: 0x001E9A18
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x001EB828 File Offset: 0x001E9A28
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

		// Token: 0x06003EA8 RID: 16040 RVA: 0x001EB838 File Offset: 0x001E9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddocksInformationEvent()
		{
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x001EB848 File Offset: 0x001E9A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddocksInformationEvent(GuildPaddocksInformationEvent other)
		{
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x001EB858 File Offset: 0x001E9A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddocksInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x001EB868 File Offset: 0x001E9A68
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x001EB878 File Offset: 0x001E9A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxPaddockNumber
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

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x001EB888 File Offset: 0x001E9A88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PaddockInformation> PaddockInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x001EB898 File Offset: 0x001E9A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x001EB8A8 File Offset: 0x001E9AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildPaddocksInformationEvent other)
		{
			return true;
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x001EB8B8 File Offset: 0x001E9AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x001EB8C8 File Offset: 0x001E9AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x001EB8D8 File Offset: 0x001E9AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x001EB8E8 File Offset: 0x001E9AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x001EB8F8 File Offset: 0x001E9AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x001EB908 File Offset: 0x001E9B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildPaddocksInformationEvent other)
		{
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001EB918 File Offset: 0x001E9B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001EB928 File Offset: 0x001E9B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001EB938 File Offset: 0x001E9B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildPaddocksInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					GuildPaddocksInformationEvent._parser = new MessageParser<GuildPaddocksInformationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				GuildPaddocksInformationEvent._repeated_paddockInformation_codec = FieldCodec.ForMessage<PaddockInformation>(18U, RKVgUGmcFBiycWD6aGXR.XVInXhlssT(RKVgUGmcFBiycWD6aGXR.Ulsmczx66C3));
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x001EBA40 File Offset: 0x001E9C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zJ7oFaOTD2tv55yJkUsI()
		{
			return true;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x001EBA48 File Offset: 0x001E9C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildPaddocksInformationEvent Pa6JxPOTtUx5vOcqyaIM()
		{
			return null;
		}

		// Token: 0x040015BA RID: 5562
		private static readonly MessageParser<GuildPaddocksInformationEvent> _parser;

		// Token: 0x040015BB RID: 5563
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015BC RID: 5564
		public const int MaxPaddockNumberFieldNumber = 1;

		// Token: 0x040015BD RID: 5565
		private int maxPaddockNumber_;

		// Token: 0x040015BE RID: 5566
		public const int PaddockInformationFieldNumber = 2;

		// Token: 0x040015BF RID: 5567
		private static readonly FieldCodec<PaddockInformation> _repeated_paddockInformation_codec;

		// Token: 0x040015C0 RID: 5568
		private readonly RepeatedField<PaddockInformation> paddockInformation_;

		// Token: 0x040015C1 RID: 5569
		private static GuildPaddocksInformationEvent vRN0DwOTC2yFsh4EJaTk;
	}
}
