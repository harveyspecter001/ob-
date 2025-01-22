using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200096F RID: 2415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRewardBuyRequest : IMessage<BreachRewardBuyRequest>, IMessage, IEquatable<BreachRewardBuyRequest>, IDeepCloneable<BreachRewardBuyRequest>, IBufferMessage
	{
		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x002423A4 File Offset: 0x002405A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachRewardBuyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x002423B4 File Offset: 0x002405B4
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

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x002423C4 File Offset: 0x002405C4
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

		// Token: 0x060074EC RID: 29932 RVA: 0x002423D4 File Offset: 0x002405D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBuyRequest()
		{
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x002423E4 File Offset: 0x002405E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBuyRequest(BreachRewardBuyRequest other)
		{
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x002423F4 File Offset: 0x002405F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRewardBuyRequest Clone()
		{
			return null;
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060074EF RID: 29935 RVA: 0x00242404 File Offset: 0x00240604
		// (set) Token: 0x060074F0 RID: 29936 RVA: 0x00242414 File Offset: 0x00240614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RewardId
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

		// Token: 0x060074F1 RID: 29937 RVA: 0x00242424 File Offset: 0x00240624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00242434 File Offset: 0x00240634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRewardBuyRequest other)
		{
			return true;
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00242444 File Offset: 0x00240644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00242454 File Offset: 0x00240654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00242464 File Offset: 0x00240664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00242474 File Offset: 0x00240674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00242484 File Offset: 0x00240684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00242494 File Offset: 0x00240694
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRewardBuyRequest other)
		{
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x002424A4 File Offset: 0x002406A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x002424B4 File Offset: 0x002406B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x002424C4 File Offset: 0x002406C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRewardBuyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					BreachRewardBuyRequest._parser = new MessageParser<BreachRewardBuyRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x002425A8 File Offset: 0x002407A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UMJMfcJRGeuyt6yixkup()
		{
			return true;
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x002425B0 File Offset: 0x002407B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRewardBuyRequest Hg1Fg9JRg3UmsdL5N8xM()
		{
			return null;
		}

		// Token: 0x040028C0 RID: 10432
		private static readonly MessageParser<BreachRewardBuyRequest> _parser;

		// Token: 0x040028C1 RID: 10433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C2 RID: 10434
		public const int RewardIdFieldNumber = 1;

		// Token: 0x040028C3 RID: 10435
		private int rewardId_;

		// Token: 0x040028C4 RID: 10436
		internal static BreachRewardBuyRequest cerEJdJRJqCXmMZY5YS5;
	}
}
