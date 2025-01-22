using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B8F RID: 2959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorStaticInformation : IMessage<TaxCollectorStaticInformation>, IMessage, IEquatable<TaxCollectorStaticInformation>, IDeepCloneable<TaxCollectorStaticInformation>, IBufferMessage
	{
		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x0026B434 File Offset: 0x00269634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorStaticInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x0026B444 File Offset: 0x00269644
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

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x0026B454 File Offset: 0x00269654
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

		// Token: 0x06008E18 RID: 36376 RVA: 0x0026B464 File Offset: 0x00269664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStaticInformation()
		{
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x0026B474 File Offset: 0x00269674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStaticInformation(TaxCollectorStaticInformation other)
		{
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x0026B484 File Offset: 0x00269684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStaticInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x0026B494 File Offset: 0x00269694
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x0026B4A4 File Offset: 0x002696A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uid
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

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x0026B4B4 File Offset: 0x002696B4
		// (set) Token: 0x06008E1E RID: 36382 RVA: 0x0026B4C4 File Offset: 0x002696C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06008E1F RID: 36383 RVA: 0x0026B4D4 File Offset: 0x002696D4
		// (set) Token: 0x06008E20 RID: 36384 RVA: 0x0026B4E4 File Offset: 0x002696E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x0026B4F4 File Offset: 0x002696F4
		// (set) Token: 0x06008E22 RID: 36386 RVA: 0x0026B504 File Offset: 0x00269704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation Alliance
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

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06008E23 RID: 36387 RVA: 0x0026B514 File Offset: 0x00269714
		// (set) Token: 0x06008E24 RID: 36388 RVA: 0x0026B524 File Offset: 0x00269724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CallerId
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

		// Token: 0x06008E25 RID: 36389 RVA: 0x0026B534 File Offset: 0x00269734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x0026B544 File Offset: 0x00269744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorStaticInformation other)
		{
			return true;
		}

		// Token: 0x06008E27 RID: 36391 RVA: 0x0026B554 File Offset: 0x00269754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x0026B564 File Offset: 0x00269764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x0026B574 File Offset: 0x00269774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x0026B584 File Offset: 0x00269784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x0026B594 File Offset: 0x00269794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008E2C RID: 36396 RVA: 0x0026B5A4 File Offset: 0x002697A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorStaticInformation other)
		{
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x0026B5B4 File Offset: 0x002697B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008E2E RID: 36398 RVA: 0x0026B5C4 File Offset: 0x002697C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x0026B5D4 File Offset: 0x002697D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorStaticInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					TaxCollectorStaticInformation._parser = new MessageParser<TaxCollectorStaticInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x0026B6CC File Offset: 0x002698CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Knjk8PJ9CuEgqLxcEHJ2()
		{
			return true;
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x0026B6D4 File Offset: 0x002698D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorStaticInformation XliYdlJ9DlD8fWdaetdH()
		{
			return null;
		}

		// Token: 0x040034BB RID: 13499
		private static readonly MessageParser<TaxCollectorStaticInformation> _parser;

		// Token: 0x040034BC RID: 13500
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034BD RID: 13501
		public const int UidFieldNumber = 1;

		// Token: 0x040034BE RID: 13502
		private string uid_;

		// Token: 0x040034BF RID: 13503
		public const int FirstNameIdFieldNumber = 2;

		// Token: 0x040034C0 RID: 13504
		private int firstNameId_;

		// Token: 0x040034C1 RID: 13505
		public const int LastNameIdFieldNumber = 3;

		// Token: 0x040034C2 RID: 13506
		private int lastNameId_;

		// Token: 0x040034C3 RID: 13507
		public const int AllianceFieldNumber = 4;

		// Token: 0x040034C4 RID: 13508
		private AllianceInformation alliance_;

		// Token: 0x040034C5 RID: 13509
		public const int CallerIdFieldNumber = 5;

		// Token: 0x040034C6 RID: 13510
		private long callerId_;

		// Token: 0x040034C7 RID: 13511
		internal static TaxCollectorStaticInformation PLpDCcJ90uUG3asxxqD7;
	}
}
