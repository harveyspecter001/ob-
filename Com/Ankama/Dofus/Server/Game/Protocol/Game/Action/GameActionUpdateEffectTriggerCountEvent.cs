using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x0200061E RID: 1566
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionUpdateEffectTriggerCountEvent : IMessage<GameActionUpdateEffectTriggerCountEvent>, IMessage, IEquatable<GameActionUpdateEffectTriggerCountEvent>, IDeepCloneable<GameActionUpdateEffectTriggerCountEvent>, IBufferMessage
	{
		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x001FEAFC File Offset: 0x001FCCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionUpdateEffectTriggerCountEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x001FEB0C File Offset: 0x001FCD0C
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x001FEB1C File Offset: 0x001FCD1C
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

		// Token: 0x06004C03 RID: 19459 RVA: 0x001FEB2C File Offset: 0x001FCD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionUpdateEffectTriggerCountEvent()
		{
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x001FEB3C File Offset: 0x001FCD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionUpdateEffectTriggerCountEvent(GameActionUpdateEffectTriggerCountEvent other)
		{
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x001FEB4C File Offset: 0x001FCD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionUpdateEffectTriggerCountEvent Clone()
		{
			return null;
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x001FEB5C File Offset: 0x001FCD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount> EffectsCountOnTarget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x001FEB6C File Offset: 0x001FCD6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x001FEB7C File Offset: 0x001FCD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionUpdateEffectTriggerCountEvent other)
		{
			return true;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x001FEB8C File Offset: 0x001FCD8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x001FEB9C File Offset: 0x001FCD9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x001FEBAC File Offset: 0x001FCDAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x001FEBBC File Offset: 0x001FCDBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x001FEBCC File Offset: 0x001FCDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x001FEBDC File Offset: 0x001FCDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionUpdateEffectTriggerCountEvent other)
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x001FEBEC File Offset: 0x001FCDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x001FEBFC File Offset: 0x001FCDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x001FEC0C File Offset: 0x001FCE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionUpdateEffectTriggerCountEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_39;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						GameActionUpdateEffectTriggerCountEvent._parser = new MessageParser<GameActionUpdateEffectTriggerCountEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						break;
					case 5:
						return;
					}
				}
				IL_39:
				GameActionUpdateEffectTriggerCountEvent._repeated_effectsCountOnTarget_codec = FieldCodec.ForMessage<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount>(10U, dc4Y62m7rIqdNOC1FK6s.XVInXhlssT(dc4Y62m7rIqdNOC1FK6s.RlJm7VS46Fs));
				num = 5;
			}
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x001FED00 File Offset: 0x001FCF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xXxG0nObiTmOUOGRcuQ5()
		{
			return true;
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x001FED08 File Offset: 0x001FCF08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionUpdateEffectTriggerCountEvent VYiHeTObPjnTHbGxKkwk()
		{
			return null;
		}

		// Token: 0x04001A85 RID: 6789
		private static readonly MessageParser<GameActionUpdateEffectTriggerCountEvent> _parser;

		// Token: 0x04001A86 RID: 6790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A87 RID: 6791
		public const int EffectsCountOnTargetFieldNumber = 1;

		// Token: 0x04001A88 RID: 6792
		private static readonly FieldCodec<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount> _repeated_effectsCountOnTarget_codec;

		// Token: 0x04001A89 RID: 6793
		private readonly RepeatedField<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount> effectsCountOnTarget_;

		// Token: 0x04001A8A RID: 6794
		private static GameActionUpdateEffectTriggerCountEvent kMI9OlObbPpfQXMpswjq;

		// Token: 0x0200061F RID: 1567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06004C14 RID: 19476 RVA: 0x002C8F98 File Offset: 0x002C7198
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000620 RID: 1568
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FightEffectTriggerCount : IMessage<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount>, IMessage, IEquatable<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount>, IDeepCloneable<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount>, IBufferMessage
			{
				// Token: 0x17000DB5 RID: 3509
				// (get) Token: 0x06004C15 RID: 19477 RVA: 0x00301418 File Offset: 0x002FF618
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DB6 RID: 3510
				// (get) Token: 0x06004C16 RID: 19478 RVA: 0x00301428 File Offset: 0x002FF628
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

				// Token: 0x17000DB7 RID: 3511
				// (get) Token: 0x06004C17 RID: 19479 RVA: 0x00301438 File Offset: 0x002FF638
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

				// Token: 0x06004C18 RID: 19480 RVA: 0x00301448 File Offset: 0x002FF648
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightEffectTriggerCount()
				{
				}

				// Token: 0x06004C19 RID: 19481 RVA: 0x00301458 File Offset: 0x002FF658
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightEffectTriggerCount(GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount other)
				{
				}

				// Token: 0x06004C1A RID: 19482 RVA: 0x00301468 File Offset: 0x002FF668
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount Clone()
				{
					return null;
				}

				// Token: 0x17000DB8 RID: 3512
				// (get) Token: 0x06004C1B RID: 19483 RVA: 0x00301478 File Offset: 0x002FF678
				// (set) Token: 0x06004C1C RID: 19484 RVA: 0x00301488 File Offset: 0x002FF688
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int EffectId
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

				// Token: 0x17000DB9 RID: 3513
				// (get) Token: 0x06004C1D RID: 19485 RVA: 0x00301498 File Offset: 0x002FF698
				// (set) Token: 0x06004C1E RID: 19486 RVA: 0x003014A8 File Offset: 0x002FF6A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long TargetId
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

				// Token: 0x17000DBA RID: 3514
				// (get) Token: 0x06004C1F RID: 19487 RVA: 0x003014B8 File Offset: 0x002FF6B8
				// (set) Token: 0x06004C20 RID: 19488 RVA: 0x003014C8 File Offset: 0x002FF6C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Count
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

				// Token: 0x06004C21 RID: 19489 RVA: 0x003014D8 File Offset: 0x002FF6D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004C22 RID: 19490 RVA: 0x003014E8 File Offset: 0x002FF6E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount other)
				{
					return true;
				}

				// Token: 0x06004C23 RID: 19491 RVA: 0x003014F8 File Offset: 0x002FF6F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004C24 RID: 19492 RVA: 0x00301508 File Offset: 0x002FF708
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004C25 RID: 19493 RVA: 0x00301518 File Offset: 0x002FF718
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004C26 RID: 19494 RVA: 0x00301528 File Offset: 0x002FF728
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004C27 RID: 19495 RVA: 0x00301538 File Offset: 0x002FF738
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004C28 RID: 19496 RVA: 0x00301548 File Offset: 0x002FF748
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount other)
				{
				}

				// Token: 0x06004C29 RID: 19497 RVA: 0x00301558 File Offset: 0x002FF758
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004C2A RID: 19498 RVA: 0x00301568 File Offset: 0x002FF768
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004C2B RID: 19499 RVA: 0x00301578 File Offset: 0x002FF778
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FightEffectTriggerCount()
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
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount._parser = new MessageParser<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06004C2C RID: 19500 RVA: 0x00301644 File Offset: 0x002FF844
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool WLcwquGiplW2AJotuJPa()
				{
					return true;
				}

				// Token: 0x06004C2D RID: 19501 RVA: 0x0030164C File Offset: 0x002FF84C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount lgc2qGGiHmbZ1R2JSh35()
				{
					return null;
				}

				// Token: 0x04001A8B RID: 6795
				private static readonly MessageParser<GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount> _parser;

				// Token: 0x04001A8C RID: 6796
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A8D RID: 6797
				public const int EffectIdFieldNumber = 1;

				// Token: 0x04001A8E RID: 6798
				private int effectId_;

				// Token: 0x04001A8F RID: 6799
				public const int TargetIdFieldNumber = 2;

				// Token: 0x04001A90 RID: 6800
				private long targetId_;

				// Token: 0x04001A91 RID: 6801
				public const int CountFieldNumber = 3;

				// Token: 0x04001A92 RID: 6802
				private int count_;

				// Token: 0x04001A93 RID: 6803
				private static GameActionUpdateEffectTriggerCountEvent.Types.FightEffectTriggerCount v35Q0KGiTnksxdrMFG5Q;
			}
		}
	}
}
