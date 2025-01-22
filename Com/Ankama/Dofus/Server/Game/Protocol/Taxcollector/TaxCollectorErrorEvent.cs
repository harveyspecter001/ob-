using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000D1 RID: 209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorErrorEvent : IMessage<TaxCollectorErrorEvent>, IMessage, IEquatable<TaxCollectorErrorEvent>, IDeepCloneable<TaxCollectorErrorEvent>, IBufferMessage
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00192288 File Offset: 0x00190488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00192298 File Offset: 0x00190498
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x001922A8 File Offset: 0x001904A8
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

		// Token: 0x0600096D RID: 2413 RVA: 0x001922B8 File Offset: 0x001904B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorErrorEvent()
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x001922C8 File Offset: 0x001904C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorErrorEvent(TaxCollectorErrorEvent other)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x001922D8 File Offset: 0x001904D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x001922E8 File Offset: 0x001904E8
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x001922FC File Offset: 0x001904FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorErrorEvent.Types.TaxCollectorErrorReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TaxCollectorErrorEvent.Types.TaxCollectorErrorReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0019230C File Offset: 0x0019050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0019231C File Offset: 0x0019051C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorErrorEvent other)
		{
			return true;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0019232C File Offset: 0x0019052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0019233C File Offset: 0x0019053C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0019234C File Offset: 0x0019054C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0019235C File Offset: 0x0019055C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0019236C File Offset: 0x0019056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0019237C File Offset: 0x0019057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorErrorEvent other)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0019238C File Offset: 0x0019058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0019239C File Offset: 0x0019059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x001923AC File Offset: 0x001905AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					TaxCollectorErrorEvent._parser = new MessageParser<TaxCollectorErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00192490 File Offset: 0x00190690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xUjCSvOk6H5vLl2WZgn0()
		{
			return true;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00192498 File Offset: 0x00190698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorErrorEvent PWWdocOkL2y3GC9xkGTS()
		{
			return null;
		}

		// Token: 0x04000381 RID: 897
		private static readonly MessageParser<TaxCollectorErrorEvent> _parser;

		// Token: 0x04000382 RID: 898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000383 RID: 899
		public const int ReasonFieldNumber = 1;

		// Token: 0x04000384 RID: 900
		private TaxCollectorErrorEvent.Types.TaxCollectorErrorReason reason_;

		// Token: 0x04000385 RID: 901
		internal static TaxCollectorErrorEvent IhcsUIOkydCffEgwxrFN;

		// Token: 0x020000D2 RID: 210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600097F RID: 2431 RVA: 0x002A976C File Offset: 0x002A796C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020000D3 RID: 211
			public enum TaxCollectorErrorReason
			{
				// Token: 0x04000387 RID: 903
				[OriginalName("TAX_COLLECTOR_ERROR_UNKNOWN")]
				TaxCollectorErrorUnknown,
				// Token: 0x04000388 RID: 904
				[OriginalName("TAX_COLLECTOR_NOT_FOUND")]
				TaxCollectorNotFound,
				// Token: 0x04000389 RID: 905
				[OriginalName("TAX_COLLECTOR_NOT_OWNED")]
				TaxCollectorNotOwned,
				// Token: 0x0400038A RID: 906
				[OriginalName("TAX_COLLECTOR_NO_RIGHTS")]
				TaxCollectorNoRights,
				// Token: 0x0400038B RID: 907
				[OriginalName("TAX_COLLECTOR_MAX_REACHED")]
				TaxCollectorMaxReached,
				// Token: 0x0400038C RID: 908
				[OriginalName("TAX_COLLECTOR_ALREADY_ONE")]
				TaxCollectorAlreadyOne,
				// Token: 0x0400038D RID: 909
				[OriginalName("TAX_COLLECTOR_CANT_HIRE_YET")]
				TaxCollectorCantHireYet,
				// Token: 0x0400038E RID: 910
				[OriginalName("TAX_COLLECTOR_CANT_HIRE_HERE")]
				TaxCollectorCantHireHere,
				// Token: 0x0400038F RID: 911
				[OriginalName("TAX_COLLECTOR_NOT_ENOUGH_KAMAS")]
				TaxCollectorNotEnoughKamas
			}
		}
	}
}
