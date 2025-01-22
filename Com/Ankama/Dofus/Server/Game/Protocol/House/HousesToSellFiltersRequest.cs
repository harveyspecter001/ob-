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
	// Token: 0x0200045D RID: 1117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HousesToSellFiltersRequest : IMessage<HousesToSellFiltersRequest>, IMessage, IEquatable<HousesToSellFiltersRequest>, IDeepCloneable<HousesToSellFiltersRequest>, IBufferMessage
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x001DBAA0 File Offset: 0x001D9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HousesToSellFiltersRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x001DBAB0 File Offset: 0x001D9CB0
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x001DBAC0 File Offset: 0x001D9CC0
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

		// Token: 0x06003529 RID: 13609 RVA: 0x001DBAD0 File Offset: 0x001D9CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellFiltersRequest()
		{
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x001DBAE0 File Offset: 0x001D9CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellFiltersRequest(HousesToSellFiltersRequest other)
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x001DBAF0 File Offset: 0x001D9CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HousesToSellFiltersRequest Clone()
		{
			return null;
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x001DBB00 File Offset: 0x001D9D00
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x001DBB10 File Offset: 0x001D9D10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AreaId
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x001DBB20 File Offset: 0x001D9D20
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x001DBB30 File Offset: 0x001D9D30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AtLeastRoomNumber
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

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x001DBB40 File Offset: 0x001D9D40
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x001DBB50 File Offset: 0x001D9D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AtLeastChestNumber
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x001DBB60 File Offset: 0x001D9D60
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x001DBB70 File Offset: 0x001D9D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillRequested
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

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x001DBB80 File Offset: 0x001D9D80
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x001DBB90 File Offset: 0x001D9D90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PriceMax
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x001DBBA0 File Offset: 0x001D9DA0
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x001DBBB4 File Offset: 0x001D9DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RealEstateOrder OrderBy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (RealEstateOrder)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x001DBBC4 File Offset: 0x001D9DC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x001DBBD4 File Offset: 0x001D9DD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HousesToSellFiltersRequest other)
		{
			return true;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x001DBBE4 File Offset: 0x001D9DE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x001DBBF4 File Offset: 0x001D9DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x001DBC04 File Offset: 0x001D9E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x001DBC14 File Offset: 0x001D9E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x001DBC24 File Offset: 0x001D9E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x001DBC34 File Offset: 0x001D9E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HousesToSellFiltersRequest other)
		{
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x001DBC44 File Offset: 0x001D9E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x001DBC54 File Offset: 0x001D9E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x001DBC64 File Offset: 0x001D9E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HousesToSellFiltersRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					HousesToSellFiltersRequest._parser = new MessageParser<HousesToSellFiltersRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x001DBD5C File Offset: 0x001D9F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oFn1UsOtXBD1cPUCGln0()
		{
			return true;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x001DBD64 File Offset: 0x001D9F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HousesToSellFiltersRequest A5NOeUOtN1hoYqqN0b3T()
		{
			return null;
		}

		// Token: 0x0400128B RID: 4747
		private static readonly MessageParser<HousesToSellFiltersRequest> _parser;

		// Token: 0x0400128C RID: 4748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400128D RID: 4749
		public const int AreaIdFieldNumber = 1;

		// Token: 0x0400128E RID: 4750
		private int areaId_;

		// Token: 0x0400128F RID: 4751
		public const int AtLeastRoomNumberFieldNumber = 2;

		// Token: 0x04001290 RID: 4752
		private int atLeastRoomNumber_;

		// Token: 0x04001291 RID: 4753
		public const int AtLeastChestNumberFieldNumber = 3;

		// Token: 0x04001292 RID: 4754
		private int atLeastChestNumber_;

		// Token: 0x04001293 RID: 4755
		public const int SkillRequestedFieldNumber = 4;

		// Token: 0x04001294 RID: 4756
		private int skillRequested_;

		// Token: 0x04001295 RID: 4757
		public const int PriceMaxFieldNumber = 5;

		// Token: 0x04001296 RID: 4758
		private long priceMax_;

		// Token: 0x04001297 RID: 4759
		public const int OrderByFieldNumber = 6;

		// Token: 0x04001298 RID: 4760
		private RealEstateOrder orderBy_;

		// Token: 0x04001299 RID: 4761
		internal static HousesToSellFiltersRequest kOaFq8OtEH34UUkNGafg;
	}
}
