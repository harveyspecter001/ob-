using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000658 RID: 1624
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DetailedStatistics : IMessage<DetailedStatistics>, IMessage, IEquatable<DetailedStatistics>, IDeepCloneable<DetailedStatistics>, IBufferMessage
	{
		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x00204198 File Offset: 0x00202398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetailedStatistics> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x002041A8 File Offset: 0x002023A8
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

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x002041B8 File Offset: 0x002023B8
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

		// Token: 0x06004ED0 RID: 20176 RVA: 0x002041C8 File Offset: 0x002023C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedStatistics()
		{
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x002041D8 File Offset: 0x002023D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedStatistics(DetailedStatistics other)
		{
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x002041E8 File Offset: 0x002023E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedStatistics Clone()
		{
			return null;
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x002041F8 File Offset: 0x002023F8
		// (set) Token: 0x06004ED4 RID: 20180 RVA: 0x00204208 File Offset: 0x00202408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.DamageDone DamageDone
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

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x00204218 File Offset: 0x00202418
		// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x00204228 File Offset: 0x00202428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.DamageTaken DamageTaken
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

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x00204238 File Offset: 0x00202438
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x00204248 File Offset: 0x00202448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.HealDone HealDone
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

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x00204258 File Offset: 0x00202458
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x00204268 File Offset: 0x00202468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.HealTaken HealTaken
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

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x00204278 File Offset: 0x00202478
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x00204288 File Offset: 0x00202488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.ShieldDone ShieldDone
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

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x00204298 File Offset: 0x00202498
		// (set) Token: 0x06004EDE RID: 20190 RVA: 0x002042A8 File Offset: 0x002024A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.ShieldTaken ShieldTaken
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

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x002042B8 File Offset: 0x002024B8
		// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x002042C8 File Offset: 0x002024C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.Point ActionPoint
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

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x002042D8 File Offset: 0x002024D8
		// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x002042E8 File Offset: 0x002024E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.Point MovementPoint
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x002042F8 File Offset: 0x002024F8
		// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x00204308 File Offset: 0x00202508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetailedStatistics.Types.Kill Kill
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

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x00204318 File Offset: 0x00202518
		// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x00204328 File Offset: 0x00202528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterIdentity Identity
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

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00204338 File Offset: 0x00202538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00204348 File Offset: 0x00202548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DetailedStatistics other)
		{
			return true;
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00204358 File Offset: 0x00202558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00204368 File Offset: 0x00202568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00204378 File Offset: 0x00202578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00204388 File Offset: 0x00202588
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x00204398 File Offset: 0x00202598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x002043A8 File Offset: 0x002025A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DetailedStatistics other)
		{
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x002043B8 File Offset: 0x002025B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x002043C8 File Offset: 0x002025C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x002043D8 File Offset: 0x002025D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DetailedStatistics()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					DetailedStatistics._parser = new MessageParser<DetailedStatistics>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x002044D0 File Offset: 0x002026D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aDguuVOirhVJ6wokugFF()
		{
			return true;
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x002044D8 File Offset: 0x002026D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DetailedStatistics B1EC71OiV1Q3pW191l3j()
		{
			return null;
		}

		// Token: 0x04001B93 RID: 7059
		private static readonly MessageParser<DetailedStatistics> _parser;

		// Token: 0x04001B94 RID: 7060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B95 RID: 7061
		public const int DamageDoneFieldNumber = 1;

		// Token: 0x04001B96 RID: 7062
		private DetailedStatistics.Types.DamageDone damageDone_;

		// Token: 0x04001B97 RID: 7063
		public const int DamageTakenFieldNumber = 2;

		// Token: 0x04001B98 RID: 7064
		private DetailedStatistics.Types.DamageTaken damageTaken_;

		// Token: 0x04001B99 RID: 7065
		public const int HealDoneFieldNumber = 3;

		// Token: 0x04001B9A RID: 7066
		private DetailedStatistics.Types.HealDone healDone_;

		// Token: 0x04001B9B RID: 7067
		public const int HealTakenFieldNumber = 4;

		// Token: 0x04001B9C RID: 7068
		private DetailedStatistics.Types.HealTaken healTaken_;

		// Token: 0x04001B9D RID: 7069
		public const int ShieldDoneFieldNumber = 5;

		// Token: 0x04001B9E RID: 7070
		private DetailedStatistics.Types.ShieldDone shieldDone_;

		// Token: 0x04001B9F RID: 7071
		public const int ShieldTakenFieldNumber = 6;

		// Token: 0x04001BA0 RID: 7072
		private DetailedStatistics.Types.ShieldTaken shieldTaken_;

		// Token: 0x04001BA1 RID: 7073
		public const int ActionPointFieldNumber = 7;

		// Token: 0x04001BA2 RID: 7074
		private DetailedStatistics.Types.Point actionPoint_;

		// Token: 0x04001BA3 RID: 7075
		public const int MovementPointFieldNumber = 8;

		// Token: 0x04001BA4 RID: 7076
		private DetailedStatistics.Types.Point movementPoint_;

		// Token: 0x04001BA5 RID: 7077
		public const int KillFieldNumber = 9;

		// Token: 0x04001BA6 RID: 7078
		private DetailedStatistics.Types.Kill kill_;

		// Token: 0x04001BA7 RID: 7079
		public const int IdentityFieldNumber = 10;

		// Token: 0x04001BA8 RID: 7080
		private FighterIdentity identity_;

		// Token: 0x04001BA9 RID: 7081
		private static DetailedStatistics SY6MDjOihmgrOmVmAeZI;

		// Token: 0x02000659 RID: 1625
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06004EF4 RID: 20212 RVA: 0x002C9D80 File Offset: 0x002C7F80
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200065A RID: 1626
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DamageDone : IMessage<DetailedStatistics.Types.DamageDone>, IMessage, IEquatable<DetailedStatistics.Types.DamageDone>, IDeepCloneable<DetailedStatistics.Types.DamageDone>, IBufferMessage
			{
				// Token: 0x17000E4C RID: 3660
				// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x00302A6C File Offset: 0x00300C6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DetailedStatistics.Types.DamageDone> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E4D RID: 3661
				// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x00302A7C File Offset: 0x00300C7C
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

				// Token: 0x17000E4E RID: 3662
				// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x00302A8C File Offset: 0x00300C8C
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

				// Token: 0x06004EF8 RID: 20216 RVA: 0x00302A9C File Offset: 0x00300C9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DamageDone()
				{
				}

				// Token: 0x06004EF9 RID: 20217 RVA: 0x00302AAC File Offset: 0x00300CAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DamageDone(DetailedStatistics.Types.DamageDone other)
				{
				}

				// Token: 0x06004EFA RID: 20218 RVA: 0x00302ABC File Offset: 0x00300CBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.DamageDone Clone()
				{
					return null;
				}

				// Token: 0x17000E4F RID: 3663
				// (get) Token: 0x06004EFB RID: 20219 RVA: 0x00302ACC File Offset: 0x00300CCC
				// (set) Token: 0x06004EFC RID: 20220 RVA: 0x00302ADC File Offset: 0x00300CDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Total
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

				// Token: 0x17000E50 RID: 3664
				// (get) Token: 0x06004EFD RID: 20221 RVA: 0x00302AEC File Offset: 0x00300CEC
				// (set) Token: 0x06004EFE RID: 20222 RVA: 0x00302AFC File Offset: 0x00300CFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ByPoison
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

				// Token: 0x17000E51 RID: 3665
				// (get) Token: 0x06004EFF RID: 20223 RVA: 0x00302B0C File Offset: 0x00300D0C
				// (set) Token: 0x06004F00 RID: 20224 RVA: 0x00302B1C File Offset: 0x00300D1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ByPush
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

				// Token: 0x17000E52 RID: 3666
				// (get) Token: 0x06004F01 RID: 20225 RVA: 0x00302B2C File Offset: 0x00300D2C
				// (set) Token: 0x06004F02 RID: 20226 RVA: 0x00302B3C File Offset: 0x00300D3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ByObject
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

				// Token: 0x17000E53 RID: 3667
				// (get) Token: 0x06004F03 RID: 20227 RVA: 0x00302B4C File Offset: 0x00300D4C
				// (set) Token: 0x06004F04 RID: 20228 RVA: 0x00302B5C File Offset: 0x00300D5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int BySummon
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

				// Token: 0x17000E54 RID: 3668
				// (get) Token: 0x06004F05 RID: 20229 RVA: 0x00302B6C File Offset: 0x00300D6C
				// (set) Token: 0x06004F06 RID: 20230 RVA: 0x00302B7C File Offset: 0x00300D7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int OnShield
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

				// Token: 0x17000E55 RID: 3669
				// (get) Token: 0x06004F07 RID: 20231 RVA: 0x00302B8C File Offset: 0x00300D8C
				// (set) Token: 0x06004F08 RID: 20232 RVA: 0x00302B9C File Offset: 0x00300D9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float ByActionPoint
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E56 RID: 3670
				// (get) Token: 0x06004F09 RID: 20233 RVA: 0x00302BAC File Offset: 0x00300DAC
				// (set) Token: 0x06004F0A RID: 20234 RVA: 0x00302BBC File Offset: 0x00300DBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E57 RID: 3671
				// (get) Token: 0x06004F0B RID: 20235 RVA: 0x00302BCC File Offset: 0x00300DCC
				// (set) Token: 0x06004F0C RID: 20236 RVA: 0x00302BDC File Offset: 0x00300DDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Erosion
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

				// Token: 0x06004F0D RID: 20237 RVA: 0x00302BEC File Offset: 0x00300DEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004F0E RID: 20238 RVA: 0x00302BFC File Offset: 0x00300DFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.DamageDone other)
				{
					return true;
				}

				// Token: 0x06004F0F RID: 20239 RVA: 0x00302C0C File Offset: 0x00300E0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004F10 RID: 20240 RVA: 0x00302C1C File Offset: 0x00300E1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004F11 RID: 20241 RVA: 0x00302C2C File Offset: 0x00300E2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004F12 RID: 20242 RVA: 0x00302C3C File Offset: 0x00300E3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004F13 RID: 20243 RVA: 0x00302C4C File Offset: 0x00300E4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004F14 RID: 20244 RVA: 0x00302C5C File Offset: 0x00300E5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.DamageDone other)
				{
				}

				// Token: 0x06004F15 RID: 20245 RVA: 0x00302C6C File Offset: 0x00300E6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004F16 RID: 20246 RVA: 0x00302C7C File Offset: 0x00300E7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004F17 RID: 20247 RVA: 0x00302C8C File Offset: 0x00300E8C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DamageDone()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							DetailedStatistics.Types.DamageDone._parser = new MessageParser<DetailedStatistics.Types.DamageDone>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06004F18 RID: 20248 RVA: 0x00302D84 File Offset: 0x00300F84
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool EJ8V9OGPEmUKIP4ETBZd()
				{
					return true;
				}

				// Token: 0x06004F19 RID: 20249 RVA: 0x00302D8C File Offset: 0x00300F8C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.DamageDone xkD2G3GPXH4C6bnolWtx()
				{
					return null;
				}

				// Token: 0x04001BAA RID: 7082
				private static readonly MessageParser<DetailedStatistics.Types.DamageDone> _parser;

				// Token: 0x04001BAB RID: 7083
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BAC RID: 7084
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BAD RID: 7085
				private int total_;

				// Token: 0x04001BAE RID: 7086
				public const int ByPoisonFieldNumber = 2;

				// Token: 0x04001BAF RID: 7087
				private int byPoison_;

				// Token: 0x04001BB0 RID: 7088
				public const int ByPushFieldNumber = 3;

				// Token: 0x04001BB1 RID: 7089
				private int byPush_;

				// Token: 0x04001BB2 RID: 7090
				public const int ByObjectFieldNumber = 4;

				// Token: 0x04001BB3 RID: 7091
				private int byObject_;

				// Token: 0x04001BB4 RID: 7092
				public const int BySummonFieldNumber = 5;

				// Token: 0x04001BB5 RID: 7093
				private int bySummon_;

				// Token: 0x04001BB6 RID: 7094
				public const int OnShieldFieldNumber = 6;

				// Token: 0x04001BB7 RID: 7095
				private int onShield_;

				// Token: 0x04001BB8 RID: 7096
				public const int ByActionPointFieldNumber = 7;

				// Token: 0x04001BB9 RID: 7097
				private float byActionPoint_;

				// Token: 0x04001BBA RID: 7098
				public const int ByTurnFieldNumber = 8;

				// Token: 0x04001BBB RID: 7099
				private float byTurn_;

				// Token: 0x04001BBC RID: 7100
				public const int ErosionFieldNumber = 9;

				// Token: 0x04001BBD RID: 7101
				private int erosion_;

				// Token: 0x04001BBE RID: 7102
				internal static DetailedStatistics.Types.DamageDone lGDKAcGP26bWZKfXtMRZ;
			}

			// Token: 0x0200065C RID: 1628
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DamageTaken : IMessage<DetailedStatistics.Types.DamageTaken>, IMessage, IEquatable<DetailedStatistics.Types.DamageTaken>, IDeepCloneable<DetailedStatistics.Types.DamageTaken>, IBufferMessage
			{
				// Token: 0x17000E58 RID: 3672
				// (get) Token: 0x06004F1F RID: 20255 RVA: 0x00302D94 File Offset: 0x00300F94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<DetailedStatistics.Types.DamageTaken> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E59 RID: 3673
				// (get) Token: 0x06004F20 RID: 20256 RVA: 0x00302DA4 File Offset: 0x00300FA4
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

				// Token: 0x17000E5A RID: 3674
				// (get) Token: 0x06004F21 RID: 20257 RVA: 0x00302DB4 File Offset: 0x00300FB4
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

				// Token: 0x06004F22 RID: 20258 RVA: 0x00302DC4 File Offset: 0x00300FC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DamageTaken()
				{
				}

				// Token: 0x06004F23 RID: 20259 RVA: 0x00302DD4 File Offset: 0x00300FD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DamageTaken(DetailedStatistics.Types.DamageTaken other)
				{
				}

				// Token: 0x06004F24 RID: 20260 RVA: 0x00302DE4 File Offset: 0x00300FE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.DamageTaken Clone()
				{
					return null;
				}

				// Token: 0x17000E5B RID: 3675
				// (get) Token: 0x06004F25 RID: 20261 RVA: 0x00302DF4 File Offset: 0x00300FF4
				// (set) Token: 0x06004F26 RID: 20262 RVA: 0x00302E04 File Offset: 0x00301004
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Total
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

				// Token: 0x17000E5C RID: 3676
				// (get) Token: 0x06004F27 RID: 20263 RVA: 0x00302E14 File Offset: 0x00301014
				// (set) Token: 0x06004F28 RID: 20264 RVA: 0x00302E24 File Offset: 0x00301024
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ByPoison
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

				// Token: 0x17000E5D RID: 3677
				// (get) Token: 0x06004F29 RID: 20265 RVA: 0x00302E34 File Offset: 0x00301034
				// (set) Token: 0x06004F2A RID: 20266 RVA: 0x00302E44 File Offset: 0x00301044
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ByPush
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

				// Token: 0x17000E5E RID: 3678
				// (get) Token: 0x06004F2B RID: 20267 RVA: 0x00302E54 File Offset: 0x00301054
				// (set) Token: 0x06004F2C RID: 20268 RVA: 0x00302E64 File Offset: 0x00301064
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ByObject
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

				// Token: 0x17000E5F RID: 3679
				// (get) Token: 0x06004F2D RID: 20269 RVA: 0x00302E74 File Offset: 0x00301074
				// (set) Token: 0x06004F2E RID: 20270 RVA: 0x00302E84 File Offset: 0x00301084
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int BySummon
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

				// Token: 0x17000E60 RID: 3680
				// (get) Token: 0x06004F2F RID: 20271 RVA: 0x00302E94 File Offset: 0x00301094
				// (set) Token: 0x06004F30 RID: 20272 RVA: 0x00302EA4 File Offset: 0x003010A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int OnShield
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

				// Token: 0x17000E61 RID: 3681
				// (get) Token: 0x06004F31 RID: 20273 RVA: 0x00302EB4 File Offset: 0x003010B4
				// (set) Token: 0x06004F32 RID: 20274 RVA: 0x00302EC4 File Offset: 0x003010C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E62 RID: 3682
				// (get) Token: 0x06004F33 RID: 20275 RVA: 0x00302ED4 File Offset: 0x003010D4
				// (set) Token: 0x06004F34 RID: 20276 RVA: 0x00302EE4 File Offset: 0x003010E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Erosion
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

				// Token: 0x06004F35 RID: 20277 RVA: 0x00302EF4 File Offset: 0x003010F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004F36 RID: 20278 RVA: 0x00302F04 File Offset: 0x00301104
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.DamageTaken other)
				{
					return true;
				}

				// Token: 0x06004F37 RID: 20279 RVA: 0x00302F14 File Offset: 0x00301114
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004F38 RID: 20280 RVA: 0x00302F24 File Offset: 0x00301124
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004F39 RID: 20281 RVA: 0x00302F34 File Offset: 0x00301134
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004F3A RID: 20282 RVA: 0x00302F44 File Offset: 0x00301144
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004F3B RID: 20283 RVA: 0x00302F54 File Offset: 0x00301154
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004F3C RID: 20284 RVA: 0x00302F64 File Offset: 0x00301164
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.DamageTaken other)
				{
				}

				// Token: 0x06004F3D RID: 20285 RVA: 0x00302F74 File Offset: 0x00301174
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004F3E RID: 20286 RVA: 0x00302F84 File Offset: 0x00301184
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004F3F RID: 20287 RVA: 0x00302F94 File Offset: 0x00301194
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DamageTaken()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							DetailedStatistics.Types.DamageTaken._parser = new MessageParser<DetailedStatistics.Types.DamageTaken>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
					}
				}

				// Token: 0x06004F40 RID: 20288 RVA: 0x00303078 File Offset: 0x00301278
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool dTLG9DGPxxF1wddl5rbS()
				{
					return true;
				}

				// Token: 0x06004F41 RID: 20289 RVA: 0x00303080 File Offset: 0x00301280
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.DamageTaken CcyWJEGP4Q5Trtg6HPuR()
				{
					return null;
				}

				// Token: 0x04001BC1 RID: 7105
				private static readonly MessageParser<DetailedStatistics.Types.DamageTaken> _parser;

				// Token: 0x04001BC2 RID: 7106
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BC3 RID: 7107
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BC4 RID: 7108
				private int total_;

				// Token: 0x04001BC5 RID: 7109
				public const int ByPoisonFieldNumber = 2;

				// Token: 0x04001BC6 RID: 7110
				private int byPoison_;

				// Token: 0x04001BC7 RID: 7111
				public const int ByPushFieldNumber = 3;

				// Token: 0x04001BC8 RID: 7112
				private int byPush_;

				// Token: 0x04001BC9 RID: 7113
				public const int ByObjectFieldNumber = 4;

				// Token: 0x04001BCA RID: 7114
				private int byObject_;

				// Token: 0x04001BCB RID: 7115
				public const int BySummonFieldNumber = 5;

				// Token: 0x04001BCC RID: 7116
				private int bySummon_;

				// Token: 0x04001BCD RID: 7117
				public const int OnShieldFieldNumber = 6;

				// Token: 0x04001BCE RID: 7118
				private int onShield_;

				// Token: 0x04001BCF RID: 7119
				public const int ByTurnFieldNumber = 7;

				// Token: 0x04001BD0 RID: 7120
				private float byTurn_;

				// Token: 0x04001BD1 RID: 7121
				public const int ErosionFieldNumber = 8;

				// Token: 0x04001BD2 RID: 7122
				private int erosion_;

				// Token: 0x04001BD3 RID: 7123
				internal static DetailedStatistics.Types.DamageTaken xywPjRGPNNu5duggQdXj;
			}

			// Token: 0x0200065E RID: 1630
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HealDone : IMessage<DetailedStatistics.Types.HealDone>, IMessage, IEquatable<DetailedStatistics.Types.HealDone>, IDeepCloneable<DetailedStatistics.Types.HealDone>, IBufferMessage
			{
				// Token: 0x17000E63 RID: 3683
				// (get) Token: 0x06004F47 RID: 20295 RVA: 0x00303088 File Offset: 0x00301288
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DetailedStatistics.Types.HealDone> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E64 RID: 3684
				// (get) Token: 0x06004F48 RID: 20296 RVA: 0x00303098 File Offset: 0x00301298
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

				// Token: 0x17000E65 RID: 3685
				// (get) Token: 0x06004F49 RID: 20297 RVA: 0x003030A8 File Offset: 0x003012A8
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

				// Token: 0x06004F4A RID: 20298 RVA: 0x003030B8 File Offset: 0x003012B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HealDone()
				{
				}

				// Token: 0x06004F4B RID: 20299 RVA: 0x003030C8 File Offset: 0x003012C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HealDone(DetailedStatistics.Types.HealDone other)
				{
				}

				// Token: 0x06004F4C RID: 20300 RVA: 0x003030D8 File Offset: 0x003012D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.HealDone Clone()
				{
					return null;
				}

				// Token: 0x17000E66 RID: 3686
				// (get) Token: 0x06004F4D RID: 20301 RVA: 0x003030E8 File Offset: 0x003012E8
				// (set) Token: 0x06004F4E RID: 20302 RVA: 0x003030F8 File Offset: 0x003012F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Total
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

				// Token: 0x17000E67 RID: 3687
				// (get) Token: 0x06004F4F RID: 20303 RVA: 0x00303108 File Offset: 0x00301308
				// (set) Token: 0x06004F50 RID: 20304 RVA: 0x00303118 File Offset: 0x00301318
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int BySummon
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

				// Token: 0x17000E68 RID: 3688
				// (get) Token: 0x06004F51 RID: 20305 RVA: 0x00303128 File Offset: 0x00301328
				// (set) Token: 0x06004F52 RID: 20306 RVA: 0x00303138 File Offset: 0x00301338
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float ByActionPoint
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E69 RID: 3689
				// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00303148 File Offset: 0x00301348
				// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00303158 File Offset: 0x00301358
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004F55 RID: 20309 RVA: 0x00303168 File Offset: 0x00301368
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004F56 RID: 20310 RVA: 0x00303178 File Offset: 0x00301378
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.HealDone other)
				{
					return true;
				}

				// Token: 0x06004F57 RID: 20311 RVA: 0x00303188 File Offset: 0x00301388
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004F58 RID: 20312 RVA: 0x00303198 File Offset: 0x00301398
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004F59 RID: 20313 RVA: 0x003031A8 File Offset: 0x003013A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004F5A RID: 20314 RVA: 0x003031B8 File Offset: 0x003013B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004F5B RID: 20315 RVA: 0x003031C8 File Offset: 0x003013C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004F5C RID: 20316 RVA: 0x003031D8 File Offset: 0x003013D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.HealDone other)
				{
				}

				// Token: 0x06004F5D RID: 20317 RVA: 0x003031E8 File Offset: 0x003013E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004F5E RID: 20318 RVA: 0x003031F8 File Offset: 0x003013F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004F5F RID: 20319 RVA: 0x00303208 File Offset: 0x00301408
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HealDone()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							DetailedStatistics.Types.HealDone._parser = new MessageParser<DetailedStatistics.Types.HealDone>(() => null);
							num2 = 2;
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06004F60 RID: 20320 RVA: 0x003032D4 File Offset: 0x003014D4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool nqfn4LGPK8mPC3kWG9W8()
				{
					return true;
				}

				// Token: 0x06004F61 RID: 20321 RVA: 0x003032DC File Offset: 0x003014DC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.HealDone OuGIoMGPIZPjT82dwGjS()
				{
					return null;
				}

				// Token: 0x04001BD6 RID: 7126
				private static readonly MessageParser<DetailedStatistics.Types.HealDone> _parser;

				// Token: 0x04001BD7 RID: 7127
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BD8 RID: 7128
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BD9 RID: 7129
				private int total_;

				// Token: 0x04001BDA RID: 7130
				public const int BySummonFieldNumber = 2;

				// Token: 0x04001BDB RID: 7131
				private int bySummon_;

				// Token: 0x04001BDC RID: 7132
				public const int ByActionPointFieldNumber = 3;

				// Token: 0x04001BDD RID: 7133
				private float byActionPoint_;

				// Token: 0x04001BDE RID: 7134
				public const int ByTurnFieldNumber = 4;

				// Token: 0x04001BDF RID: 7135
				private float byTurn_;

				// Token: 0x04001BE0 RID: 7136
				private static DetailedStatistics.Types.HealDone JILILXGPjtMexfo28By3;
			}

			// Token: 0x02000660 RID: 1632
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HealTaken : IMessage<DetailedStatistics.Types.HealTaken>, IMessage, IEquatable<DetailedStatistics.Types.HealTaken>, IDeepCloneable<DetailedStatistics.Types.HealTaken>, IBufferMessage
			{
				// Token: 0x17000E6A RID: 3690
				// (get) Token: 0x06004F67 RID: 20327 RVA: 0x003032E4 File Offset: 0x003014E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DetailedStatistics.Types.HealTaken> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E6B RID: 3691
				// (get) Token: 0x06004F68 RID: 20328 RVA: 0x003032F4 File Offset: 0x003014F4
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

				// Token: 0x17000E6C RID: 3692
				// (get) Token: 0x06004F69 RID: 20329 RVA: 0x00303304 File Offset: 0x00301504
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

				// Token: 0x06004F6A RID: 20330 RVA: 0x00303314 File Offset: 0x00301514
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HealTaken()
				{
				}

				// Token: 0x06004F6B RID: 20331 RVA: 0x00303324 File Offset: 0x00301524
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public HealTaken(DetailedStatistics.Types.HealTaken other)
				{
				}

				// Token: 0x06004F6C RID: 20332 RVA: 0x00303334 File Offset: 0x00301534
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.HealTaken Clone()
				{
					return null;
				}

				// Token: 0x17000E6D RID: 3693
				// (get) Token: 0x06004F6D RID: 20333 RVA: 0x00303344 File Offset: 0x00301544
				// (set) Token: 0x06004F6E RID: 20334 RVA: 0x00303354 File Offset: 0x00301554
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Total
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

				// Token: 0x17000E6E RID: 3694
				// (get) Token: 0x06004F6F RID: 20335 RVA: 0x00303364 File Offset: 0x00301564
				// (set) Token: 0x06004F70 RID: 20336 RVA: 0x00303374 File Offset: 0x00301574
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int BySummon
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

				// Token: 0x17000E6F RID: 3695
				// (get) Token: 0x06004F71 RID: 20337 RVA: 0x00303384 File Offset: 0x00301584
				// (set) Token: 0x06004F72 RID: 20338 RVA: 0x00303394 File Offset: 0x00301594
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004F73 RID: 20339 RVA: 0x003033A4 File Offset: 0x003015A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004F74 RID: 20340 RVA: 0x003033B4 File Offset: 0x003015B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.HealTaken other)
				{
					return true;
				}

				// Token: 0x06004F75 RID: 20341 RVA: 0x003033C4 File Offset: 0x003015C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004F76 RID: 20342 RVA: 0x003033D4 File Offset: 0x003015D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004F77 RID: 20343 RVA: 0x003033E4 File Offset: 0x003015E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004F78 RID: 20344 RVA: 0x003033F4 File Offset: 0x003015F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004F79 RID: 20345 RVA: 0x00303404 File Offset: 0x00301604
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004F7A RID: 20346 RVA: 0x00303414 File Offset: 0x00301614
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.HealTaken other)
				{
				}

				// Token: 0x06004F7B RID: 20347 RVA: 0x00303424 File Offset: 0x00301624
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004F7C RID: 20348 RVA: 0x00303434 File Offset: 0x00301634
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004F7D RID: 20349 RVA: 0x00303444 File Offset: 0x00301644
				[MethodImpl(MethodImplOptions.NoInlining)]
				static HealTaken()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							DetailedStatistics.Types.HealTaken._parser = new MessageParser<DetailedStatistics.Types.HealTaken>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
							{
								num2 = 4;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							break;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x06004F7E RID: 20350 RVA: 0x00303528 File Offset: 0x00301728
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ASFbQTGPlfjx1jKoniyB()
				{
					return true;
				}

				// Token: 0x06004F7F RID: 20351 RVA: 0x00303530 File Offset: 0x00301730
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.HealTaken S9ByaPGPcLIUlOjgJHVG()
				{
					return null;
				}

				// Token: 0x04001BE3 RID: 7139
				private static readonly MessageParser<DetailedStatistics.Types.HealTaken> _parser;

				// Token: 0x04001BE4 RID: 7140
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BE5 RID: 7141
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BE6 RID: 7142
				private int total_;

				// Token: 0x04001BE7 RID: 7143
				public const int BySummonFieldNumber = 2;

				// Token: 0x04001BE8 RID: 7144
				private int bySummon_;

				// Token: 0x04001BE9 RID: 7145
				public const int ByTurnFieldNumber = 3;

				// Token: 0x04001BEA RID: 7146
				private float byTurn_;

				// Token: 0x04001BEB RID: 7147
				private static DetailedStatistics.Types.HealTaken zgTgZMGPkvHBYY12k4Y1;
			}

			// Token: 0x02000662 RID: 1634
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ShieldDone : IMessage<DetailedStatistics.Types.ShieldDone>, IMessage, IEquatable<DetailedStatistics.Types.ShieldDone>, IDeepCloneable<DetailedStatistics.Types.ShieldDone>, IBufferMessage
			{
				// Token: 0x17000E70 RID: 3696
				// (get) Token: 0x06004F85 RID: 20357 RVA: 0x00303538 File Offset: 0x00301738
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DetailedStatistics.Types.ShieldDone> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E71 RID: 3697
				// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00303548 File Offset: 0x00301748
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

				// Token: 0x17000E72 RID: 3698
				// (get) Token: 0x06004F87 RID: 20359 RVA: 0x00303558 File Offset: 0x00301758
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

				// Token: 0x06004F88 RID: 20360 RVA: 0x00303568 File Offset: 0x00301768
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ShieldDone()
				{
				}

				// Token: 0x06004F89 RID: 20361 RVA: 0x00303578 File Offset: 0x00301778
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ShieldDone(DetailedStatistics.Types.ShieldDone other)
				{
				}

				// Token: 0x06004F8A RID: 20362 RVA: 0x00303588 File Offset: 0x00301788
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.ShieldDone Clone()
				{
					return null;
				}

				// Token: 0x17000E73 RID: 3699
				// (get) Token: 0x06004F8B RID: 20363 RVA: 0x00303598 File Offset: 0x00301798
				// (set) Token: 0x06004F8C RID: 20364 RVA: 0x003035A8 File Offset: 0x003017A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Total
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

				// Token: 0x17000E74 RID: 3700
				// (get) Token: 0x06004F8D RID: 20365 RVA: 0x003035B8 File Offset: 0x003017B8
				// (set) Token: 0x06004F8E RID: 20366 RVA: 0x003035C8 File Offset: 0x003017C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int BySummon
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

				// Token: 0x17000E75 RID: 3701
				// (get) Token: 0x06004F8F RID: 20367 RVA: 0x003035D8 File Offset: 0x003017D8
				// (set) Token: 0x06004F90 RID: 20368 RVA: 0x003035E8 File Offset: 0x003017E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004F91 RID: 20369 RVA: 0x003035F8 File Offset: 0x003017F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004F92 RID: 20370 RVA: 0x00303608 File Offset: 0x00301808
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.ShieldDone other)
				{
					return true;
				}

				// Token: 0x06004F93 RID: 20371 RVA: 0x00303618 File Offset: 0x00301818
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004F94 RID: 20372 RVA: 0x00303628 File Offset: 0x00301828
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004F95 RID: 20373 RVA: 0x00303638 File Offset: 0x00301838
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004F96 RID: 20374 RVA: 0x00303648 File Offset: 0x00301848
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004F97 RID: 20375 RVA: 0x00303658 File Offset: 0x00301858
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004F98 RID: 20376 RVA: 0x00303668 File Offset: 0x00301868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.ShieldDone other)
				{
				}

				// Token: 0x06004F99 RID: 20377 RVA: 0x00303678 File Offset: 0x00301878
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004F9A RID: 20378 RVA: 0x00303688 File Offset: 0x00301888
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004F9B RID: 20379 RVA: 0x00303698 File Offset: 0x00301898
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ShieldDone()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							DetailedStatistics.Types.ShieldDone._parser = new MessageParser<DetailedStatistics.Types.ShieldDone>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004F9C RID: 20380 RVA: 0x0030377C File Offset: 0x0030197C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool y33DIDGPvrKUdkPblhJy()
				{
					return true;
				}

				// Token: 0x06004F9D RID: 20381 RVA: 0x00303784 File Offset: 0x00301984
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.ShieldDone GXnInOGPoVL2gqPefUsa()
				{
					return null;
				}

				// Token: 0x04001BEE RID: 7150
				private static readonly MessageParser<DetailedStatistics.Types.ShieldDone> _parser;

				// Token: 0x04001BEF RID: 7151
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BF0 RID: 7152
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BF1 RID: 7153
				private int total_;

				// Token: 0x04001BF2 RID: 7154
				public const int BySummonFieldNumber = 2;

				// Token: 0x04001BF3 RID: 7155
				private int bySummon_;

				// Token: 0x04001BF4 RID: 7156
				public const int ByTurnFieldNumber = 3;

				// Token: 0x04001BF5 RID: 7157
				private float byTurn_;

				// Token: 0x04001BF6 RID: 7158
				internal static DetailedStatistics.Types.ShieldDone pQcaTiGPU47bKmw9oBO5;
			}

			// Token: 0x02000664 RID: 1636
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ShieldTaken : IMessage<DetailedStatistics.Types.ShieldTaken>, IMessage, IEquatable<DetailedStatistics.Types.ShieldTaken>, IDeepCloneable<DetailedStatistics.Types.ShieldTaken>, IBufferMessage
			{
				// Token: 0x17000E76 RID: 3702
				// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x0030378C File Offset: 0x0030198C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DetailedStatistics.Types.ShieldTaken> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E77 RID: 3703
				// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0030379C File Offset: 0x0030199C
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

				// Token: 0x17000E78 RID: 3704
				// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x003037AC File Offset: 0x003019AC
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

				// Token: 0x06004FA6 RID: 20390 RVA: 0x003037BC File Offset: 0x003019BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ShieldTaken()
				{
				}

				// Token: 0x06004FA7 RID: 20391 RVA: 0x003037CC File Offset: 0x003019CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ShieldTaken(DetailedStatistics.Types.ShieldTaken other)
				{
				}

				// Token: 0x06004FA8 RID: 20392 RVA: 0x003037DC File Offset: 0x003019DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.ShieldTaken Clone()
				{
					return null;
				}

				// Token: 0x17000E79 RID: 3705
				// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x003037EC File Offset: 0x003019EC
				// (set) Token: 0x06004FAA RID: 20394 RVA: 0x003037FC File Offset: 0x003019FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Total
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

				// Token: 0x17000E7A RID: 3706
				// (get) Token: 0x06004FAB RID: 20395 RVA: 0x0030380C File Offset: 0x00301A0C
				// (set) Token: 0x06004FAC RID: 20396 RVA: 0x0030381C File Offset: 0x00301A1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int BySummon
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

				// Token: 0x17000E7B RID: 3707
				// (get) Token: 0x06004FAD RID: 20397 RVA: 0x0030382C File Offset: 0x00301A2C
				// (set) Token: 0x06004FAE RID: 20398 RVA: 0x0030383C File Offset: 0x00301A3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float ByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004FAF RID: 20399 RVA: 0x0030384C File Offset: 0x00301A4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004FB0 RID: 20400 RVA: 0x0030385C File Offset: 0x00301A5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.ShieldTaken other)
				{
					return true;
				}

				// Token: 0x06004FB1 RID: 20401 RVA: 0x0030386C File Offset: 0x00301A6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004FB2 RID: 20402 RVA: 0x0030387C File Offset: 0x00301A7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004FB3 RID: 20403 RVA: 0x0030388C File Offset: 0x00301A8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004FB4 RID: 20404 RVA: 0x0030389C File Offset: 0x00301A9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004FB5 RID: 20405 RVA: 0x003038AC File Offset: 0x00301AAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004FB6 RID: 20406 RVA: 0x003038BC File Offset: 0x00301ABC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.ShieldTaken other)
				{
				}

				// Token: 0x06004FB7 RID: 20407 RVA: 0x003038CC File Offset: 0x00301ACC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004FB8 RID: 20408 RVA: 0x003038DC File Offset: 0x00301ADC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004FB9 RID: 20409 RVA: 0x003038EC File Offset: 0x00301AEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ShieldTaken()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							DetailedStatistics.Types.ShieldTaken._parser = new MessageParser<DetailedStatistics.Types.ShieldTaken>(() => null);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06004FBA RID: 20410 RVA: 0x003039E4 File Offset: 0x00301BE4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool rmOMHLGPalrtFjyxOXdm()
				{
					return true;
				}

				// Token: 0x06004FBB RID: 20411 RVA: 0x003039EC File Offset: 0x00301BEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.ShieldTaken yc7KOlGP5YqCkGtwDqNu()
				{
					return null;
				}

				// Token: 0x04001BF9 RID: 7161
				private static readonly MessageParser<DetailedStatistics.Types.ShieldTaken> _parser;

				// Token: 0x04001BFA RID: 7162
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001BFB RID: 7163
				public const int TotalFieldNumber = 1;

				// Token: 0x04001BFC RID: 7164
				private int total_;

				// Token: 0x04001BFD RID: 7165
				public const int BySummonFieldNumber = 2;

				// Token: 0x04001BFE RID: 7166
				private int bySummon_;

				// Token: 0x04001BFF RID: 7167
				public const int ByTurnFieldNumber = 3;

				// Token: 0x04001C00 RID: 7168
				private float byTurn_;

				// Token: 0x04001C01 RID: 7169
				internal static DetailedStatistics.Types.ShieldTaken IwYqVbGP19GeDCo3HgIq;
			}

			// Token: 0x02000666 RID: 1638
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Point : IMessage<DetailedStatistics.Types.Point>, IMessage, IEquatable<DetailedStatistics.Types.Point>, IDeepCloneable<DetailedStatistics.Types.Point>, IBufferMessage
			{
				// Token: 0x17000E7C RID: 3708
				// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x003039F4 File Offset: 0x00301BF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<DetailedStatistics.Types.Point> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E7D RID: 3709
				// (get) Token: 0x06004FC2 RID: 20418 RVA: 0x00303A04 File Offset: 0x00301C04
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

				// Token: 0x17000E7E RID: 3710
				// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x00303A14 File Offset: 0x00301C14
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

				// Token: 0x06004FC4 RID: 20420 RVA: 0x00303A24 File Offset: 0x00301C24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Point()
				{
				}

				// Token: 0x06004FC5 RID: 20421 RVA: 0x00303A34 File Offset: 0x00301C34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Point(DetailedStatistics.Types.Point other)
				{
				}

				// Token: 0x06004FC6 RID: 20422 RVA: 0x00303A44 File Offset: 0x00301C44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.Point Clone()
				{
					return null;
				}

				// Token: 0x17000E7F RID: 3711
				// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x00303A54 File Offset: 0x00301C54
				// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x00303A64 File Offset: 0x00301C64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Dodged
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

				// Token: 0x17000E80 RID: 3712
				// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x00303A74 File Offset: 0x00301C74
				// (set) Token: 0x06004FCA RID: 20426 RVA: 0x00303A84 File Offset: 0x00301C84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int NotDodged
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

				// Token: 0x17000E81 RID: 3713
				// (get) Token: 0x06004FCB RID: 20427 RVA: 0x00303A94 File Offset: 0x00301C94
				// (set) Token: 0x06004FCC RID: 20428 RVA: 0x00303AA4 File Offset: 0x00301CA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Removed
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

				// Token: 0x17000E82 RID: 3714
				// (get) Token: 0x06004FCD RID: 20429 RVA: 0x00303AB4 File Offset: 0x00301CB4
				// (set) Token: 0x06004FCE RID: 20430 RVA: 0x00303AC4 File Offset: 0x00301CC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float DodgedByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E83 RID: 3715
				// (get) Token: 0x06004FCF RID: 20431 RVA: 0x00303AD4 File Offset: 0x00301CD4
				// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x00303AE4 File Offset: 0x00301CE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float NotDodgedByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E84 RID: 3716
				// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x00303AF4 File Offset: 0x00301CF4
				// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x00303B04 File Offset: 0x00301D04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float RemovedByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000E85 RID: 3717
				// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x00303B14 File Offset: 0x00301D14
				// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x00303B24 File Offset: 0x00301D24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float SpentByTurn
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004FD5 RID: 20437 RVA: 0x00303B34 File Offset: 0x00301D34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004FD6 RID: 20438 RVA: 0x00303B44 File Offset: 0x00301D44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.Point other)
				{
					return true;
				}

				// Token: 0x06004FD7 RID: 20439 RVA: 0x00303B54 File Offset: 0x00301D54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004FD8 RID: 20440 RVA: 0x00303B64 File Offset: 0x00301D64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004FD9 RID: 20441 RVA: 0x00303B74 File Offset: 0x00301D74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004FDA RID: 20442 RVA: 0x00303B84 File Offset: 0x00301D84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004FDB RID: 20443 RVA: 0x00303B94 File Offset: 0x00301D94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004FDC RID: 20444 RVA: 0x00303BA4 File Offset: 0x00301DA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.Point other)
				{
				}

				// Token: 0x06004FDD RID: 20445 RVA: 0x00303BB4 File Offset: 0x00301DB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004FDE RID: 20446 RVA: 0x00303BC4 File Offset: 0x00301DC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004FDF RID: 20447 RVA: 0x00303BD4 File Offset: 0x00301DD4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Point()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						}
						DetailedStatistics.Types.Point._parser = new MessageParser<DetailedStatistics.Types.Point>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06004FE0 RID: 20448 RVA: 0x00303CCC File Offset: 0x00301ECC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool koIhuZGP6TYsxFAYw5qf()
				{
					return true;
				}

				// Token: 0x06004FE1 RID: 20449 RVA: 0x00303CD4 File Offset: 0x00301ED4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.Point UOBTpoGPLwV7UXJLf7nJ()
				{
					return null;
				}

				// Token: 0x04001C04 RID: 7172
				private static readonly MessageParser<DetailedStatistics.Types.Point> _parser;

				// Token: 0x04001C05 RID: 7173
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001C06 RID: 7174
				public const int DodgedFieldNumber = 1;

				// Token: 0x04001C07 RID: 7175
				private int dodged_;

				// Token: 0x04001C08 RID: 7176
				public const int NotDodgedFieldNumber = 2;

				// Token: 0x04001C09 RID: 7177
				private int notDodged_;

				// Token: 0x04001C0A RID: 7178
				public const int RemovedFieldNumber = 3;

				// Token: 0x04001C0B RID: 7179
				private int removed_;

				// Token: 0x04001C0C RID: 7180
				public const int DodgedByTurnFieldNumber = 4;

				// Token: 0x04001C0D RID: 7181
				private float dodgedByTurn_;

				// Token: 0x04001C0E RID: 7182
				public const int NotDodgedByTurnFieldNumber = 5;

				// Token: 0x04001C0F RID: 7183
				private float notDodgedByTurn_;

				// Token: 0x04001C10 RID: 7184
				public const int RemovedByTurnFieldNumber = 6;

				// Token: 0x04001C11 RID: 7185
				private float removedByTurn_;

				// Token: 0x04001C12 RID: 7186
				public const int SpentByTurnFieldNumber = 7;

				// Token: 0x04001C13 RID: 7187
				private float spentByTurn_;

				// Token: 0x04001C14 RID: 7188
				private static DetailedStatistics.Types.Point atJj3xGPyE2JssgYsXFG;
			}

			// Token: 0x02000668 RID: 1640
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Kill : IMessage<DetailedStatistics.Types.Kill>, IMessage, IEquatable<DetailedStatistics.Types.Kill>, IDeepCloneable<DetailedStatistics.Types.Kill>, IBufferMessage
			{
				// Token: 0x17000E86 RID: 3718
				// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x00303CDC File Offset: 0x00301EDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<DetailedStatistics.Types.Kill> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E87 RID: 3719
				// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x00303CEC File Offset: 0x00301EEC
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

				// Token: 0x17000E88 RID: 3720
				// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x00303CFC File Offset: 0x00301EFC
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

				// Token: 0x06004FEA RID: 20458 RVA: 0x00303D0C File Offset: 0x00301F0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Kill()
				{
				}

				// Token: 0x06004FEB RID: 20459 RVA: 0x00303D1C File Offset: 0x00301F1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Kill(DetailedStatistics.Types.Kill other)
				{
				}

				// Token: 0x06004FEC RID: 20460 RVA: 0x00303D2C File Offset: 0x00301F2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DetailedStatistics.Types.Kill Clone()
				{
					return null;
				}

				// Token: 0x17000E89 RID: 3721
				// (get) Token: 0x06004FED RID: 20461 RVA: 0x00303D3C File Offset: 0x00301F3C
				// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00303D4C File Offset: 0x00301F4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Total
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

				// Token: 0x17000E8A RID: 3722
				// (get) Token: 0x06004FEF RID: 20463 RVA: 0x00303D5C File Offset: 0x00301F5C
				// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x00303D6C File Offset: 0x00301F6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int NonSummon
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

				// Token: 0x17000E8B RID: 3723
				// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x00303D7C File Offset: 0x00301F7C
				// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x00303D8C File Offset: 0x00301F8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Summon
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

				// Token: 0x06004FF3 RID: 20467 RVA: 0x00303D9C File Offset: 0x00301F9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004FF4 RID: 20468 RVA: 0x00303DAC File Offset: 0x00301FAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DetailedStatistics.Types.Kill other)
				{
					return true;
				}

				// Token: 0x06004FF5 RID: 20469 RVA: 0x00303DBC File Offset: 0x00301FBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004FF6 RID: 20470 RVA: 0x00303DCC File Offset: 0x00301FCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004FF7 RID: 20471 RVA: 0x00303DDC File Offset: 0x00301FDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004FF8 RID: 20472 RVA: 0x00303DEC File Offset: 0x00301FEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004FF9 RID: 20473 RVA: 0x00303DFC File Offset: 0x00301FFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004FFA RID: 20474 RVA: 0x00303E0C File Offset: 0x0030200C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DetailedStatistics.Types.Kill other)
				{
				}

				// Token: 0x06004FFB RID: 20475 RVA: 0x00303E1C File Offset: 0x0030201C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004FFC RID: 20476 RVA: 0x00303E2C File Offset: 0x0030202C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004FFD RID: 20477 RVA: 0x00303E3C File Offset: 0x0030203C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Kill()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							DetailedStatistics.Types.Kill._parser = new MessageParser<DetailedStatistics.Types.Kill>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						}
						break;
					}
				}

				// Token: 0x06004FFE RID: 20478 RVA: 0x00303F20 File Offset: 0x00302120
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool NKoG6vGPhdJS9oo6wk7I()
				{
					return true;
				}

				// Token: 0x06004FFF RID: 20479 RVA: 0x00303F28 File Offset: 0x00302128
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DetailedStatistics.Types.Kill JBPQ03GPrdFeDkxdH2as()
				{
					return null;
				}

				// Token: 0x04001C17 RID: 7191
				private static readonly MessageParser<DetailedStatistics.Types.Kill> _parser;

				// Token: 0x04001C18 RID: 7192
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001C19 RID: 7193
				public const int TotalFieldNumber = 1;

				// Token: 0x04001C1A RID: 7194
				private int total_;

				// Token: 0x04001C1B RID: 7195
				public const int NonSummonFieldNumber = 2;

				// Token: 0x04001C1C RID: 7196
				private int nonSummon_;

				// Token: 0x04001C1D RID: 7197
				public const int SummonFieldNumber = 3;

				// Token: 0x04001C1E RID: 7198
				private int summon_;

				// Token: 0x04001C1F RID: 7199
				private static DetailedStatistics.Types.Kill Q1yHyEGPWRJf5NC73D7F;
			}
		}
	}
}
