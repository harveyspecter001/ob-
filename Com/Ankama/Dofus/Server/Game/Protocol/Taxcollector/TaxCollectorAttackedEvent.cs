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
	// Token: 0x020000C3 RID: 195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorAttackedEvent : IMessage<TaxCollectorAttackedEvent>, IMessage, IEquatable<TaxCollectorAttackedEvent>, IDeepCloneable<TaxCollectorAttackedEvent>, IBufferMessage
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00191370 File Offset: 0x0018F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorAttackedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00191380 File Offset: 0x0018F580
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00191390 File Offset: 0x0018F590
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

		// Token: 0x060008AC RID: 2220 RVA: 0x001913A0 File Offset: 0x0018F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackedEvent()
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x001913B0 File Offset: 0x0018F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackedEvent(TaxCollectorAttackedEvent other)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x001913C0 File Offset: 0x0018F5C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAttackedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x001913D0 File Offset: 0x0018F5D0
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x001913E0 File Offset: 0x0018F5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x001913F0 File Offset: 0x0018F5F0
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00191400 File Offset: 0x0018F600
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00191410 File Offset: 0x0018F610
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00191420 File Offset: 0x0018F620
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00191430 File Offset: 0x0018F630
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00191440 File Offset: 0x0018F640
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00191450 File Offset: 0x0018F650
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00191460 File Offset: 0x0018F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060008B9 RID: 2233 RVA: 0x00191470 File Offset: 0x0018F670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00191480 File Offset: 0x0018F680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorAttackedEvent other)
		{
			return true;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00191490 File Offset: 0x0018F690
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x001914A0 File Offset: 0x0018F6A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x001914B0 File Offset: 0x0018F6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x001914C0 File Offset: 0x0018F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x001914D0 File Offset: 0x0018F6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x001914E0 File Offset: 0x0018F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorAttackedEvent other)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x001914F0 File Offset: 0x0018F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00191500 File Offset: 0x0018F700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00191510 File Offset: 0x0018F710
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorAttackedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					TaxCollectorAttackedEvent._parser = new MessageParser<TaxCollectorAttackedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x001915F4 File Offset: 0x0018F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mln5etOkEwH9jfpcj1up()
		{
			return true;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x001915FC File Offset: 0x0018F7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorAttackedEvent n8xWUCOkXbUitTHSl4jV()
		{
			return null;
		}

		// Token: 0x04000329 RID: 809
		private static readonly MessageParser<TaxCollectorAttackedEvent> _parser;

		// Token: 0x0400032A RID: 810
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400032B RID: 811
		public const int FirstNameIdFieldNumber = 1;

		// Token: 0x0400032C RID: 812
		private int firstNameId_;

		// Token: 0x0400032D RID: 813
		public const int LastNameIdFieldNumber = 2;

		// Token: 0x0400032E RID: 814
		private int lastNameId_;

		// Token: 0x0400032F RID: 815
		public const int CoordinatesFieldNumber = 3;

		// Token: 0x04000330 RID: 816
		private MapExtendedCoordinates coordinates_;

		// Token: 0x04000331 RID: 817
		public const int AllianceUidFieldNumber = 4;

		// Token: 0x04000332 RID: 818
		private string allianceUid_;

		// Token: 0x04000333 RID: 819
		public const int AllianceTagFieldNumber = 5;

		// Token: 0x04000334 RID: 820
		private string allianceTag_;

		// Token: 0x04000335 RID: 821
		internal static TaxCollectorAttackedEvent eKrNJ2Ok2A0pdTZOIOiB;
	}
}
