using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000677 RID: 1655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightScenarioEvent : IMessage<FightScenarioEvent>, IMessage, IEquatable<FightScenarioEvent>, IDeepCloneable<FightScenarioEvent>, IBufferMessage
	{
		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x00205220 File Offset: 0x00203420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightScenarioEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x00205230 File Offset: 0x00203430
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

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x00205240 File Offset: 0x00203440
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

		// Token: 0x060050B3 RID: 20659 RVA: 0x00205250 File Offset: 0x00203450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightScenarioEvent()
		{
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00205260 File Offset: 0x00203460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightScenarioEvent(FightScenarioEvent other)
		{
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00205270 File Offset: 0x00203470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightScenarioEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x00205280 File Offset: 0x00203480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightScenarioEvent.Types.ScenarioEntity> Scenarios
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00205290 File Offset: 0x00203490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x002052A0 File Offset: 0x002034A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightScenarioEvent other)
		{
			return true;
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x002052B0 File Offset: 0x002034B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x002052C0 File Offset: 0x002034C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x002052D0 File Offset: 0x002034D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x002052E0 File Offset: 0x002034E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x002052F0 File Offset: 0x002034F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00205300 File Offset: 0x00203500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightScenarioEvent other)
		{
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00205310 File Offset: 0x00203510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00205320 File Offset: 0x00203520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00205330 File Offset: 0x00203530
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightScenarioEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightScenarioEvent._parser = new MessageParser<FightScenarioEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					FightScenarioEvent._repeated_scenarios_codec = FieldCodec.ForMessage<FightScenarioEvent.Types.ScenarioEntity>(10U, HpU4tYmuFVQqF28axbEu.XVInXhlssT(HpU4tYmuFVQqF28axbEu.BEUmuzd7qgV));
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 5;
			}
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00205438 File Offset: 0x00203638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xPtDd4OiqxapvfH9N28q()
		{
			return true;
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00205440 File Offset: 0x00203640
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightScenarioEvent zAlRcxOiFFMrBWSVf4xy()
		{
			return null;
		}

		// Token: 0x04001C5C RID: 7260
		private static readonly MessageParser<FightScenarioEvent> _parser;

		// Token: 0x04001C5D RID: 7261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C5E RID: 7262
		public const int ScenariosFieldNumber = 1;

		// Token: 0x04001C5F RID: 7263
		private static readonly FieldCodec<FightScenarioEvent.Types.ScenarioEntity> _repeated_scenarios_codec;

		// Token: 0x04001C60 RID: 7264
		private readonly RepeatedField<FightScenarioEvent.Types.ScenarioEntity> scenarios_;

		// Token: 0x04001C61 RID: 7265
		internal static FightScenarioEvent gqaiIrOiZ2Bmo8bmTPlT;

		// Token: 0x02000678 RID: 1656
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060050C4 RID: 20676 RVA: 0x002CA434 File Offset: 0x002C8634
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000679 RID: 1657
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ScenarioEntity : IMessage<FightScenarioEvent.Types.ScenarioEntity>, IMessage, IEquatable<FightScenarioEvent.Types.ScenarioEntity>, IDeepCloneable<FightScenarioEvent.Types.ScenarioEntity>, IBufferMessage
			{
				// Token: 0x17000EAE RID: 3758
				// (get) Token: 0x060050C5 RID: 20677 RVA: 0x00303F30 File Offset: 0x00302130
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FightScenarioEvent.Types.ScenarioEntity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000EAF RID: 3759
				// (get) Token: 0x060050C6 RID: 20678 RVA: 0x00303F40 File Offset: 0x00302140
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

				// Token: 0x17000EB0 RID: 3760
				// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00303F50 File Offset: 0x00302150
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

				// Token: 0x060050C8 RID: 20680 RVA: 0x00303F60 File Offset: 0x00302160
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ScenarioEntity()
				{
				}

				// Token: 0x060050C9 RID: 20681 RVA: 0x00303F70 File Offset: 0x00302170
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ScenarioEntity(FightScenarioEvent.Types.ScenarioEntity other)
				{
				}

				// Token: 0x060050CA RID: 20682 RVA: 0x00303F80 File Offset: 0x00302180
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightScenarioEvent.Types.ScenarioEntity Clone()
				{
					return null;
				}

				// Token: 0x17000EB1 RID: 3761
				// (get) Token: 0x060050CB RID: 20683 RVA: 0x00303F90 File Offset: 0x00302190
				// (set) Token: 0x060050CC RID: 20684 RVA: 0x00303FA0 File Offset: 0x003021A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long ActorId
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

				// Token: 0x17000EB2 RID: 3762
				// (get) Token: 0x060050CD RID: 20685 RVA: 0x00303FB0 File Offset: 0x003021B0
				// (set) Token: 0x060050CE RID: 20686 RVA: 0x00303FC0 File Offset: 0x003021C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int ScenarioId
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

				// Token: 0x060050CF RID: 20687 RVA: 0x00303FD0 File Offset: 0x003021D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060050D0 RID: 20688 RVA: 0x00303FE0 File Offset: 0x003021E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightScenarioEvent.Types.ScenarioEntity other)
				{
					return true;
				}

				// Token: 0x060050D1 RID: 20689 RVA: 0x00303FF0 File Offset: 0x003021F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060050D2 RID: 20690 RVA: 0x00304000 File Offset: 0x00302200
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060050D3 RID: 20691 RVA: 0x00304010 File Offset: 0x00302210
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060050D4 RID: 20692 RVA: 0x00304020 File Offset: 0x00302220
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060050D5 RID: 20693 RVA: 0x00304030 File Offset: 0x00302230
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060050D6 RID: 20694 RVA: 0x00304040 File Offset: 0x00302240
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightScenarioEvent.Types.ScenarioEntity other)
				{
				}

				// Token: 0x060050D7 RID: 20695 RVA: 0x00304050 File Offset: 0x00302250
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060050D8 RID: 20696 RVA: 0x00304060 File Offset: 0x00302260
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060050D9 RID: 20697 RVA: 0x00304070 File Offset: 0x00302270
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ScenarioEntity()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						FightScenarioEvent.Types.ScenarioEntity._parser = new MessageParser<FightScenarioEvent.Types.ScenarioEntity>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x060050DA RID: 20698 RVA: 0x00304168 File Offset: 0x00302368
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool btpRqAGP0w1mCxlvynuO()
				{
					return true;
				}

				// Token: 0x060050DB RID: 20699 RVA: 0x00304170 File Offset: 0x00302370
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightScenarioEvent.Types.ScenarioEntity bdrCYqGPCOO2kpGWAIEU()
				{
					return null;
				}

				// Token: 0x04001C62 RID: 7266
				private static readonly MessageParser<FightScenarioEvent.Types.ScenarioEntity> _parser;

				// Token: 0x04001C63 RID: 7267
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001C64 RID: 7268
				public const int ActorIdFieldNumber = 1;

				// Token: 0x04001C65 RID: 7269
				private long actorId_;

				// Token: 0x04001C66 RID: 7270
				public const int ScenarioIdFieldNumber = 2;

				// Token: 0x04001C67 RID: 7271
				private int scenarioId_;

				// Token: 0x04001C68 RID: 7272
				private static FightScenarioEvent.Types.ScenarioEntity PpNi3vGPVrgTHLHrUEvE;
			}
		}
	}
}
