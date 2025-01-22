using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug
{
	// Token: 0x020007ED RID: 2029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DumpedEntityStatsEvent : IMessage<DumpedEntityStatsEvent>, IMessage, IEquatable<DumpedEntityStatsEvent>, IDeepCloneable<DumpedEntityStatsEvent>, IBufferMessage
	{
		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x00224184 File Offset: 0x00222384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DumpedEntityStatsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x00224194 File Offset: 0x00222394
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x002241A4 File Offset: 0x002223A4
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

		// Token: 0x06006310 RID: 25360 RVA: 0x002241B4 File Offset: 0x002223B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DumpedEntityStatsEvent()
		{
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x002241C4 File Offset: 0x002223C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DumpedEntityStatsEvent(DumpedEntityStatsEvent other)
		{
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x002241D4 File Offset: 0x002223D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DumpedEntityStatsEvent Clone()
		{
			return null;
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06006313 RID: 25363 RVA: 0x002241E4 File Offset: 0x002223E4
		// (set) Token: 0x06006314 RID: 25364 RVA: 0x002241F4 File Offset: 0x002223F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06006315 RID: 25365 RVA: 0x00224204 File Offset: 0x00222404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterCharacteristic> Stats
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x00224214 File Offset: 0x00222414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x00224224 File Offset: 0x00222424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DumpedEntityStatsEvent other)
		{
			return true;
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x00224234 File Offset: 0x00222434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x00224244 File Offset: 0x00222444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x00224254 File Offset: 0x00222454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00224264 File Offset: 0x00222464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x00224274 File Offset: 0x00222474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x00224284 File Offset: 0x00222484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DumpedEntityStatsEvent other)
		{
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x00224294 File Offset: 0x00222494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x002242A4 File Offset: 0x002224A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x002242B4 File Offset: 0x002224B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DumpedEntityStatsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					DumpedEntityStatsEvent._parser = new MessageParser<DumpedEntityStatsEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					DumpedEntityStatsEvent._repeated_stats_codec = FieldCodec.ForMessage<CharacterCharacteristic>(18U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x002243D0 File Offset: 0x002225D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c8kt3wOzmjpvR8Sdqsjc()
		{
			return true;
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x002243D8 File Offset: 0x002225D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DumpedEntityStatsEvent VLe9iPOzA9I5ZcFSfDRt()
		{
			return null;
		}

		// Token: 0x040022CD RID: 8909
		private static readonly MessageParser<DumpedEntityStatsEvent> _parser;

		// Token: 0x040022CE RID: 8910
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022CF RID: 8911
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040022D0 RID: 8912
		private long entityId_;

		// Token: 0x040022D1 RID: 8913
		public const int StatsFieldNumber = 2;

		// Token: 0x040022D2 RID: 8914
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_stats_codec;

		// Token: 0x040022D3 RID: 8915
		private readonly RepeatedField<CharacterCharacteristic> stats_;

		// Token: 0x040022D4 RID: 8916
		private static DumpedEntityStatsEvent uM6D3COznengasCNnhvy;
	}
}
