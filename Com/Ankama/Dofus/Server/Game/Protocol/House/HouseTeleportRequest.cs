using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x0200045F RID: 1119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseTeleportRequest : IMessage<HouseTeleportRequest>, IMessage, IEquatable<HouseTeleportRequest>, IDeepCloneable<HouseTeleportRequest>, IBufferMessage
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x001DBD6C File Offset: 0x001D9F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseTeleportRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x001DBD7C File Offset: 0x001D9F7C
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x001DBD8C File Offset: 0x001D9F8C
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

		// Token: 0x0600354D RID: 13645 RVA: 0x001DBD9C File Offset: 0x001D9F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseTeleportRequest()
		{
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x001DBDAC File Offset: 0x001D9FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseTeleportRequest(HouseTeleportRequest other)
		{
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x001DBDBC File Offset: 0x001D9FBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseTeleportRequest Clone()
		{
			return null;
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x001DBDCC File Offset: 0x001D9FCC
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x001DBDDC File Offset: 0x001D9FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HouseId
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x001DBDEC File Offset: 0x001D9FEC
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x001DBDFC File Offset: 0x001D9FFC
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

		// Token: 0x06003554 RID: 13652 RVA: 0x001DBE0C File Offset: 0x001DA00C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x001DBE1C File Offset: 0x001DA01C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseTeleportRequest other)
		{
			return true;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x001DBE2C File Offset: 0x001DA02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x001DBE3C File Offset: 0x001DA03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x001DBE4C File Offset: 0x001DA04C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x001DBE5C File Offset: 0x001DA05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x001DBE6C File Offset: 0x001DA06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x001DBE7C File Offset: 0x001DA07C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseTeleportRequest other)
		{
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x001DBE8C File Offset: 0x001DA08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x001DBE9C File Offset: 0x001DA09C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x001DBEAC File Offset: 0x001DA0AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseTeleportRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					HouseTeleportRequest._parser = new MessageParser<HouseTeleportRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x001DBF78 File Offset: 0x001DA178
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FTMvU6Ot4ostV8ELRQf8()
		{
			return true;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x001DBF80 File Offset: 0x001DA180
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseTeleportRequest wELGGOOtjkxRZEcbuw6F()
		{
			return null;
		}

		// Token: 0x0400129C RID: 4764
		private static readonly MessageParser<HouseTeleportRequest> _parser;

		// Token: 0x0400129D RID: 4765
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400129E RID: 4766
		public const int HouseIdFieldNumber = 1;

		// Token: 0x0400129F RID: 4767
		private int houseId_;

		// Token: 0x040012A0 RID: 4768
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040012A1 RID: 4769
		private int instanceId_;

		// Token: 0x040012A2 RID: 4770
		internal static HouseTeleportRequest wBEwXfOtxeRL3bs0oIaR;
	}
}
