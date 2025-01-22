using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000459 RID: 1113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseLockFromInsideRequest : IMessage<HouseLockFromInsideRequest>, IMessage, IEquatable<HouseLockFromInsideRequest>, IDeepCloneable<HouseLockFromInsideRequest>, IBufferMessage
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x001DB674 File Offset: 0x001D9874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseLockFromInsideRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x001DB684 File Offset: 0x001D9884
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

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x001DB694 File Offset: 0x001D9894
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

		// Token: 0x060034F5 RID: 13557 RVA: 0x001DB6A4 File Offset: 0x001D98A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseLockFromInsideRequest()
		{
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x001DB6B4 File Offset: 0x001D98B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseLockFromInsideRequest(HouseLockFromInsideRequest other)
		{
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x001DB6C4 File Offset: 0x001D98C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseLockFromInsideRequest Clone()
		{
			return null;
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x001DB6D4 File Offset: 0x001D98D4
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x001DB6E4 File Offset: 0x001D98E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Code
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

		// Token: 0x060034FA RID: 13562 RVA: 0x001DB6F4 File Offset: 0x001D98F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x001DB704 File Offset: 0x001D9904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseLockFromInsideRequest other)
		{
			return true;
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x001DB714 File Offset: 0x001D9914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x001DB724 File Offset: 0x001D9924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x001DB734 File Offset: 0x001D9934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x001DB744 File Offset: 0x001D9944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x001DB754 File Offset: 0x001D9954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x001DB764 File Offset: 0x001D9964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseLockFromInsideRequest other)
		{
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x001DB774 File Offset: 0x001D9974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x001DB784 File Offset: 0x001D9984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x001DB794 File Offset: 0x001D9994
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseLockFromInsideRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_5F:
				HouseLockFromInsideRequest._parser = new MessageParser<HouseLockFromInsideRequest>(() => null);
				num = 4;
				continue;
				goto IL_5F;
			}
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x001DB87C File Offset: 0x001D9A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D8Ee0TOtgGQdSox1mOdP()
		{
			return true;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x001DB884 File Offset: 0x001D9A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseLockFromInsideRequest VOLD9KOtsMWlaJTO3xn4()
		{
			return null;
		}

		// Token: 0x0400127D RID: 4733
		private static readonly MessageParser<HouseLockFromInsideRequest> _parser;

		// Token: 0x0400127E RID: 4734
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400127F RID: 4735
		public const int CodeFieldNumber = 1;

		// Token: 0x04001280 RID: 4736
		private string code_;

		// Token: 0x04001281 RID: 4737
		internal static HouseLockFromInsideRequest roONFQOtGWsnJjtfDBpW;
	}
}
