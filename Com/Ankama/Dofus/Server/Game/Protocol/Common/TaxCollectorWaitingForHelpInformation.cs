using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B96 RID: 2966
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorWaitingForHelpInformation : IMessage<TaxCollectorWaitingForHelpInformation>, IMessage, IEquatable<TaxCollectorWaitingForHelpInformation>, IDeepCloneable<TaxCollectorWaitingForHelpInformation>, IBufferMessage
	{
		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x0026BB64 File Offset: 0x00269D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorWaitingForHelpInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06008E72 RID: 36466 RVA: 0x0026BB74 File Offset: 0x00269D74
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

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x0026BB84 File Offset: 0x00269D84
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

		// Token: 0x06008E74 RID: 36468 RVA: 0x0026BB94 File Offset: 0x00269D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorWaitingForHelpInformation()
		{
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x0026BBA4 File Offset: 0x00269DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorWaitingForHelpInformation(TaxCollectorWaitingForHelpInformation other)
		{
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x0026BBB4 File Offset: 0x00269DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorWaitingForHelpInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06008E77 RID: 36471 RVA: 0x0026BBC4 File Offset: 0x00269DC4
		// (set) Token: 0x06008E78 RID: 36472 RVA: 0x0026BBD4 File Offset: 0x00269DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimeLeftBeforeFight
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

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x0026BBE4 File Offset: 0x00269DE4
		// (set) Token: 0x06008E7A RID: 36474 RVA: 0x0026BBF4 File Offset: 0x00269DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlacementTimeLeft
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

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06008E7B RID: 36475 RVA: 0x0026BC04 File Offset: 0x00269E04
		// (set) Token: 0x06008E7C RID: 36476 RVA: 0x0026BC14 File Offset: 0x00269E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DefenderSlotsLeft
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

		// Token: 0x06008E7D RID: 36477 RVA: 0x0026BC24 File Offset: 0x00269E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x0026BC34 File Offset: 0x00269E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorWaitingForHelpInformation other)
		{
			return true;
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x0026BC44 File Offset: 0x00269E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x0026BC54 File Offset: 0x00269E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x0026BC64 File Offset: 0x00269E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x0026BC74 File Offset: 0x00269E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x0026BC84 File Offset: 0x00269E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x0026BC94 File Offset: 0x00269E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorWaitingForHelpInformation other)
		{
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x0026BCA4 File Offset: 0x00269EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x0026BCB4 File Offset: 0x00269EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x0026BCC4 File Offset: 0x00269EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorWaitingForHelpInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						TaxCollectorWaitingForHelpInformation._parser = new MessageParser<TaxCollectorWaitingForHelpInformation>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_73;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_73:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x0026BD94 File Offset: 0x00269F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wb12JZJ9YXPl2WpeOL2C()
		{
			return true;
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x0026BD9C File Offset: 0x00269F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorWaitingForHelpInformation bw90WRJ9bwuSTC15Q8Eq()
		{
			return null;
		}

		// Token: 0x040034E0 RID: 13536
		private static readonly MessageParser<TaxCollectorWaitingForHelpInformation> _parser;

		// Token: 0x040034E1 RID: 13537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034E2 RID: 13538
		public const int TimeLeftBeforeFightFieldNumber = 1;

		// Token: 0x040034E3 RID: 13539
		private long timeLeftBeforeFight_;

		// Token: 0x040034E4 RID: 13540
		public const int PlacementTimeLeftFieldNumber = 2;

		// Token: 0x040034E5 RID: 13541
		private long placementTimeLeft_;

		// Token: 0x040034E6 RID: 13542
		public const int DefenderSlotsLeftFieldNumber = 3;

		// Token: 0x040034E7 RID: 13543
		private int defenderSlotsLeft_;

		// Token: 0x040034E8 RID: 13544
		private static TaxCollectorWaitingForHelpInformation VM2esLJ9HB6XlQl7nd8W;
	}
}
