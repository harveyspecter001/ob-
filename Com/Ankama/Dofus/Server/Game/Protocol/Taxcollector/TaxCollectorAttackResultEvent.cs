using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000C5 RID: 197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorAttackResultEvent : IMessage<TaxCollectorAttackResultEvent>, IMessage, IEquatable<TaxCollectorAttackResultEvent>, IDeepCloneable<TaxCollectorAttackResultEvent>, IBufferMessage
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00191604 File Offset: 0x0018F804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorAttackResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00191614 File Offset: 0x0018F814
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00191624 File Offset: 0x0018F824
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

		// Token: 0x060008CE RID: 2254 RVA: 0x00191634 File Offset: 0x0018F834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackResultEvent()
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00191644 File Offset: 0x0018F844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackResultEvent(TaxCollectorAttackResultEvent other)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00191654 File Offset: 0x0018F854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00191664 File Offset: 0x0018F864
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00191674 File Offset: 0x0018F874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Dead
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00191684 File Offset: 0x0018F884
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00191694 File Offset: 0x0018F894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstNameId
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x001916A4 File Offset: 0x0018F8A4
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x001916B4 File Offset: 0x0018F8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LastNameId
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x001916C4 File Offset: 0x0018F8C4
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x001916D4 File Offset: 0x0018F8D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MapExtendedCoordinates Coordinates
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x001916E4 File Offset: 0x0018F8E4
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x001916F4 File Offset: 0x0018F8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AllianceUid
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00191704 File Offset: 0x0018F904
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00191714 File Offset: 0x0018F914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceTag
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

		// Token: 0x060008DD RID: 2269 RVA: 0x00191724 File Offset: 0x0018F924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00191734 File Offset: 0x0018F934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorAttackResultEvent other)
		{
			return true;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00191744 File Offset: 0x0018F944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00191754 File Offset: 0x0018F954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00191764 File Offset: 0x0018F964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00191774 File Offset: 0x0018F974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00191784 File Offset: 0x0018F984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00191794 File Offset: 0x0018F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorAttackResultEvent other)
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x001917A4 File Offset: 0x0018F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x001917B4 File Offset: 0x0018F9B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x001917C4 File Offset: 0x0018F9C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorAttackResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TaxCollectorAttackResultEvent._parser = new MessageParser<TaxCollectorAttackResultEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x001918BC File Offset: 0x0018FABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vnyyX0OkxqoXLD83J6cY()
		{
			return true;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x001918C4 File Offset: 0x0018FAC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorAttackResultEvent RD4x5nOk4eId7g8WD2AP()
		{
			return null;
		}

		// Token: 0x04000338 RID: 824
		private static readonly MessageParser<TaxCollectorAttackResultEvent> _parser;

		// Token: 0x04000339 RID: 825
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400033A RID: 826
		public const int DeadFieldNumber = 1;

		// Token: 0x0400033B RID: 827
		private bool dead_;

		// Token: 0x0400033C RID: 828
		public const int FirstNameIdFieldNumber = 2;

		// Token: 0x0400033D RID: 829
		private int firstNameId_;

		// Token: 0x0400033E RID: 830
		public const int LastNameIdFieldNumber = 3;

		// Token: 0x0400033F RID: 831
		private int lastNameId_;

		// Token: 0x04000340 RID: 832
		public const int CoordinatesFieldNumber = 4;

		// Token: 0x04000341 RID: 833
		private MapExtendedCoordinates coordinates_;

		// Token: 0x04000342 RID: 834
		public const int AllianceUidFieldNumber = 5;

		// Token: 0x04000343 RID: 835
		private string allianceUid_;

		// Token: 0x04000344 RID: 836
		public const int AllianceTagFieldNumber = 6;

		// Token: 0x04000345 RID: 837
		private string allianceTag_;

		// Token: 0x04000346 RID: 838
		private static TaxCollectorAttackResultEvent oL93DlOkNUy1hZTlHEUY;
	}
}
