using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B7C RID: 2940
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismCristal : IMessage<PrismCristal>, IMessage, IEquatable<PrismCristal>, IDeepCloneable<PrismCristal>, IBufferMessage
	{
		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06008CFE RID: 36094 RVA: 0x0026A29C File Offset: 0x0026849C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismCristal> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06008CFF RID: 36095 RVA: 0x0026A2AC File Offset: 0x002684AC
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

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06008D00 RID: 36096 RVA: 0x0026A2BC File Offset: 0x002684BC
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

		// Token: 0x06008D01 RID: 36097 RVA: 0x0026A2CC File Offset: 0x002684CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismCristal()
		{
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x0026A2DC File Offset: 0x002684DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismCristal(PrismCristal other)
		{
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x0026A2EC File Offset: 0x002684EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismCristal Clone()
		{
			return null;
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06008D04 RID: 36100 RVA: 0x0026A2FC File Offset: 0x002684FC
		// (set) Token: 0x06008D05 RID: 36101 RVA: 0x0026A30C File Offset: 0x0026850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectItemInventory CristalObject
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

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06008D06 RID: 36102 RVA: 0x0026A31C File Offset: 0x0026851C
		// (set) Token: 0x06008D07 RID: 36103 RVA: 0x0026A330 File Offset: 0x00268530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrismCristal.Types.PrismCristalType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PrismCristal.Types.PrismCristalType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008D08 RID: 36104 RVA: 0x0026A340 File Offset: 0x00268540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x0026A350 File Offset: 0x00268550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismCristal other)
		{
			return true;
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x0026A360 File Offset: 0x00268560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008D0B RID: 36107 RVA: 0x0026A370 File Offset: 0x00268570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x0026A380 File Offset: 0x00268580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x0026A390 File Offset: 0x00268590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x0026A3A0 File Offset: 0x002685A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x0026A3B0 File Offset: 0x002685B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismCristal other)
		{
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x0026A3C0 File Offset: 0x002685C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x0026A3D0 File Offset: 0x002685D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x0026A3E0 File Offset: 0x002685E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismCristal()
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
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					PrismCristal._parser = new MessageParser<PrismCristal>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x0026A4AC File Offset: 0x002686AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OWSVnCJ9IvbgNQqQ1Zyh()
		{
			return true;
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x0026A4B4 File Offset: 0x002686B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismCristal uHtevnJ9kyD0BiLMosAU()
		{
			return null;
		}

		// Token: 0x0400342C RID: 13356
		private static readonly MessageParser<PrismCristal> _parser;

		// Token: 0x0400342D RID: 13357
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400342E RID: 13358
		public const int CristalObjectFieldNumber = 1;

		// Token: 0x0400342F RID: 13359
		private ObjectItemInventory cristalObject_;

		// Token: 0x04003430 RID: 13360
		public const int TypeFieldNumber = 2;

		// Token: 0x04003431 RID: 13361
		private PrismCristal.Types.PrismCristalType type_;

		// Token: 0x04003432 RID: 13362
		internal static PrismCristal AVQ89cJ9KxTEyGZ9tlcN;

		// Token: 0x02000B7D RID: 2941
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008D15 RID: 36117 RVA: 0x002E4598 File Offset: 0x002E2798
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B7E RID: 2942
			public enum PrismCristalType
			{
				// Token: 0x04003434 RID: 13364
				[OriginalName("NO_CRISTAL")]
				NoCristal,
				// Token: 0x04003435 RID: 13365
				[OriginalName("PROTECTIVE")]
				Protective,
				// Token: 0x04003436 RID: 13366
				[OriginalName("INHIBITOR")]
				Inhibitor
			}
		}
	}
}
