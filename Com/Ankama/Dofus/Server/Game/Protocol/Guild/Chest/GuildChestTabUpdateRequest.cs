using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x02000536 RID: 1334
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestTabUpdateRequest : IMessage<GuildChestTabUpdateRequest>, IMessage, IEquatable<GuildChestTabUpdateRequest>, IDeepCloneable<GuildChestTabUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x001EE0B8 File Offset: 0x001EC2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestTabUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x001EE0C8 File Offset: 0x001EC2C8
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

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x001EE0D8 File Offset: 0x001EC2D8
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

		// Token: 0x06004009 RID: 16393 RVA: 0x001EE0E8 File Offset: 0x001EC2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabUpdateRequest()
		{
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x001EE0F8 File Offset: 0x001EC2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabUpdateRequest(GuildChestTabUpdateRequest other)
		{
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x001EE108 File Offset: 0x001EC308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestTabUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600400C RID: 16396 RVA: 0x001EE118 File Offset: 0x001EC318
		// (set) Token: 0x0600400D RID: 16397 RVA: 0x001EE128 File Offset: 0x001EC328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TabNumber
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

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600400E RID: 16398 RVA: 0x001EE138 File Offset: 0x001EC338
		// (set) Token: 0x0600400F RID: 16399 RVA: 0x001EE148 File Offset: 0x001EC348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06004010 RID: 16400 RVA: 0x001EE158 File Offset: 0x001EC358
		// (set) Token: 0x06004011 RID: 16401 RVA: 0x001EE168 File Offset: 0x001EC368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Picto
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

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x001EE178 File Offset: 0x001EC378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DropTypeLimitation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x001EE188 File Offset: 0x001EC388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x001EE198 File Offset: 0x001EC398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestTabUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x001EE1A8 File Offset: 0x001EC3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x001EE1B8 File Offset: 0x001EC3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x001EE1C8 File Offset: 0x001EC3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x001EE1D8 File Offset: 0x001EC3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x001EE1E8 File Offset: 0x001EC3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x001EE1F8 File Offset: 0x001EC3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestTabUpdateRequest other)
		{
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x001EE208 File Offset: 0x001EC408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x001EE218 File Offset: 0x001EC418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x001EE228 File Offset: 0x001EC428
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestTabUpdateRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					GuildChestTabUpdateRequest._repeated_dropTypeLimitation_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					continue;
				case 4:
					return;
				case 5:
					GuildChestTabUpdateRequest._parser = new MessageParser<GuildChestTabUpdateRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x001EE340 File Offset: 0x001EC540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I2Q1pmOplovoJ4rtj1pc()
		{
			return true;
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x001EE348 File Offset: 0x001EC548
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestTabUpdateRequest WQGYk8OpcrKjW9PNmbjX()
		{
			return null;
		}

		// Token: 0x04001626 RID: 5670
		private static readonly MessageParser<GuildChestTabUpdateRequest> _parser;

		// Token: 0x04001627 RID: 5671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001628 RID: 5672
		public const int TabNumberFieldNumber = 1;

		// Token: 0x04001629 RID: 5673
		private int tabNumber_;

		// Token: 0x0400162A RID: 5674
		public const int NameFieldNumber = 2;

		// Token: 0x0400162B RID: 5675
		private string name_;

		// Token: 0x0400162C RID: 5676
		public const int PictoFieldNumber = 3;

		// Token: 0x0400162D RID: 5677
		private int picto_;

		// Token: 0x0400162E RID: 5678
		public const int DropTypeLimitationFieldNumber = 4;

		// Token: 0x0400162F RID: 5679
		private static readonly FieldCodec<int> _repeated_dropTypeLimitation_codec;

		// Token: 0x04001630 RID: 5680
		private readonly RepeatedField<int> dropTypeLimitation_;

		// Token: 0x04001631 RID: 5681
		private static GuildChestTabUpdateRequest GRMnqrOpkjL2KT3ZpRVu;
	}
}
