using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CD3 RID: 3283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitsLoadedEvent : IMessage<OutfitsLoadedEvent>, IMessage, IEquatable<OutfitsLoadedEvent>, IDeepCloneable<OutfitsLoadedEvent>, IBufferMessage
	{
		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06009DEE RID: 40430 RVA: 0x00283570 File Offset: 0x00281770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitsLoadedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06009DEF RID: 40431 RVA: 0x00283580 File Offset: 0x00281780
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

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x00283590 File Offset: 0x00281790
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

		// Token: 0x06009DF1 RID: 40433 RVA: 0x002835A0 File Offset: 0x002817A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitsLoadedEvent()
		{
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x002835B0 File Offset: 0x002817B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitsLoadedEvent(OutfitsLoadedEvent other)
		{
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x002835C0 File Offset: 0x002817C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitsLoadedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x002835D0 File Offset: 0x002817D0
		// (set) Token: 0x06009DF5 RID: 40437 RVA: 0x002835E0 File Offset: 0x002817E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Outfit Current
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

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x002835F0 File Offset: 0x002817F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Outfit> Outfits
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x00283600 File Offset: 0x00281800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x00283610 File Offset: 0x00281810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitsLoadedEvent other)
		{
			return true;
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x00283620 File Offset: 0x00281820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x00283630 File Offset: 0x00281830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x00283640 File Offset: 0x00281840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x00283650 File Offset: 0x00281850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x00283660 File Offset: 0x00281860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x00283670 File Offset: 0x00281870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitsLoadedEvent other)
		{
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x00283680 File Offset: 0x00281880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x00283690 File Offset: 0x00281890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x002836A0 File Offset: 0x002818A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitsLoadedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OutfitsLoadedEvent._parser = new MessageParser<OutfitsLoadedEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					OutfitsLoadedEvent._repeated_outfits_codec = FieldCodec.ForMessage<Outfit>(18U, DwWfaGetDhbXqlssAVOh.XVInXhlssT(DwWfaGetDhbXqlssAVOh.rDbett68s2I));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x00283790 File Offset: 0x00281990
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MrvT7nJ4uVGYiAfZmmbi()
		{
			return true;
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x00283798 File Offset: 0x00281998
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitsLoadedEvent RDmyooJ48eMyoWd8NYuH()
		{
			return null;
		}

		// Token: 0x04003A7B RID: 14971
		private static readonly MessageParser<OutfitsLoadedEvent> _parser;

		// Token: 0x04003A7C RID: 14972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A7D RID: 14973
		public const int CurrentFieldNumber = 1;

		// Token: 0x04003A7E RID: 14974
		private Outfit current_;

		// Token: 0x04003A7F RID: 14975
		public const int OutfitsFieldNumber = 2;

		// Token: 0x04003A80 RID: 14976
		private static readonly FieldCodec<Outfit> _repeated_outfits_codec;

		// Token: 0x04003A81 RID: 14977
		private readonly RepeatedField<Outfit> outfits_;

		// Token: 0x04003A82 RID: 14978
		private static OutfitsLoadedEvent E4nrBZJ4MoK6wOEDo7dx;
	}
}
