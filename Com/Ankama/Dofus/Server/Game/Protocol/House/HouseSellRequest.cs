using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000455 RID: 1109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseSellRequest : IMessage<HouseSellRequest>, IMessage, IEquatable<HouseSellRequest>, IDeepCloneable<HouseSellRequest>, IBufferMessage
	{
		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x001DB218 File Offset: 0x001D9418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x001DB228 File Offset: 0x001D9428
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x001DB238 File Offset: 0x001D9438
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

		// Token: 0x060034BB RID: 13499 RVA: 0x001DB248 File Offset: 0x001D9448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellRequest()
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x001DB258 File Offset: 0x001D9458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellRequest(HouseSellRequest other)
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x001DB268 File Offset: 0x001D9468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseSellRequest Clone()
		{
			return null;
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x001DB278 File Offset: 0x001D9478
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x001DB288 File Offset: 0x001D9488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x001DB298 File Offset: 0x001D9498
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x001DB2A8 File Offset: 0x001D94A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Amount
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x001DB2B8 File Offset: 0x001D94B8
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x001DB2C8 File Offset: 0x001D94C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool ForSale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x001DB2D8 File Offset: 0x001D94D8
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x001DB2E8 File Offset: 0x001D94E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInside
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x001DB2F8 File Offset: 0x001D94F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x001DB308 File Offset: 0x001D9508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseSellRequest other)
		{
			return true;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x001DB318 File Offset: 0x001D9518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x001DB328 File Offset: 0x001D9528
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x001DB338 File Offset: 0x001D9538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x001DB348 File Offset: 0x001D9548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x001DB358 File Offset: 0x001D9558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x001DB368 File Offset: 0x001D9568
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseSellRequest other)
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x001DB378 File Offset: 0x001D9578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x001DB388 File Offset: 0x001D9588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x001DB398 File Offset: 0x001D9598
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						HouseSellRequest._parser = new MessageParser<HouseSellRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_49;
					}
					return;
				}
				IL_49:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x001DB468 File Offset: 0x001D9668
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h45mfNOteE0SvX3DQwee()
		{
			return true;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x001DB470 File Offset: 0x001D9670
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseSellRequest vSNv3FOt35CEjCfNiAA9()
		{
			return null;
		}

		// Token: 0x04001269 RID: 4713
		private static readonly MessageParser<HouseSellRequest> _parser;

		// Token: 0x0400126A RID: 4714
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400126B RID: 4715
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x0400126C RID: 4716
		private int instanceId_;

		// Token: 0x0400126D RID: 4717
		public const int AmountFieldNumber = 2;

		// Token: 0x0400126E RID: 4718
		private long amount_;

		// Token: 0x0400126F RID: 4719
		public const int ForSaleFieldNumber = 3;

		// Token: 0x04001270 RID: 4720
		private bool forSale_;

		// Token: 0x04001271 RID: 4721
		public const int IsInsideFieldNumber = 4;

		// Token: 0x04001272 RID: 4722
		private bool isInside_;

		// Token: 0x04001273 RID: 4723
		internal static HouseSellRequest DWYUCwOtBff8y0JYnriZ;
	}
}
