using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B98 RID: 2968
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorOrderedSpell : IMessage<TaxCollectorOrderedSpell>, IMessage, IEquatable<TaxCollectorOrderedSpell>, IDeepCloneable<TaxCollectorOrderedSpell>, IBufferMessage
	{
		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06008E8F RID: 36495 RVA: 0x0026BDA4 File Offset: 0x00269FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorOrderedSpell> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x0026BDB4 File Offset: 0x00269FB4
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

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06008E91 RID: 36497 RVA: 0x0026BDC4 File Offset: 0x00269FC4
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

		// Token: 0x06008E92 RID: 36498 RVA: 0x0026BDD4 File Offset: 0x00269FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpell()
		{
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x0026BDE4 File Offset: 0x00269FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpell(TaxCollectorOrderedSpell other)
		{
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x0026BDF4 File Offset: 0x00269FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpell Clone()
		{
			return null;
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06008E95 RID: 36501 RVA: 0x0026BE04 File Offset: 0x0026A004
		// (set) Token: 0x06008E96 RID: 36502 RVA: 0x0026BE14 File Offset: 0x0026A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellId
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

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06008E97 RID: 36503 RVA: 0x0026BE24 File Offset: 0x0026A024
		// (set) Token: 0x06008E98 RID: 36504 RVA: 0x0026BE34 File Offset: 0x0026A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
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

		// Token: 0x06008E99 RID: 36505 RVA: 0x0026BE44 File Offset: 0x0026A044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x0026BE54 File Offset: 0x0026A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorOrderedSpell other)
		{
			return true;
		}

		// Token: 0x06008E9B RID: 36507 RVA: 0x0026BE64 File Offset: 0x0026A064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x0026BE74 File Offset: 0x0026A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x0026BE84 File Offset: 0x0026A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x0026BE94 File Offset: 0x0026A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x0026BEA4 File Offset: 0x0026A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x0026BEB4 File Offset: 0x0026A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorOrderedSpell other)
		{
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x0026BEC4 File Offset: 0x0026A0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x0026BED4 File Offset: 0x0026A0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x0026BEE4 File Offset: 0x0026A0E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorOrderedSpell()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					TaxCollectorOrderedSpell._parser = new MessageParser<TaxCollectorOrderedSpell>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x0026BFC8 File Offset: 0x0026A1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V4flWpJ9PaXqIDxQHoXX()
		{
			return true;
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x0026BFD0 File Offset: 0x0026A1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorOrderedSpell qyD3KMJ9SfJhqO09sM3X()
		{
			return null;
		}

		// Token: 0x040034EB RID: 13547
		private static readonly MessageParser<TaxCollectorOrderedSpell> _parser;

		// Token: 0x040034EC RID: 13548
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034ED RID: 13549
		public const int SpellIdFieldNumber = 1;

		// Token: 0x040034EE RID: 13550
		private int spellId_;

		// Token: 0x040034EF RID: 13551
		public const int SlotIdFieldNumber = 2;

		// Token: 0x040034F0 RID: 13552
		private int slotId_;

		// Token: 0x040034F1 RID: 13553
		private static TaxCollectorOrderedSpell baHfWIJ9ihwqg8OF9E8V;
	}
}
