using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200053A RID: 1338
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestContributionStartRequest : IMessage<GuildChestContributionStartRequest>, IMessage, IEquatable<GuildChestContributionStartRequest>, IDeepCloneable<GuildChestContributionStartRequest>, IBufferMessage
	{
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x001EE544 File Offset: 0x001EC744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestContributionStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x001EE554 File Offset: 0x001EC754
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

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x001EE564 File Offset: 0x001EC764
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

		// Token: 0x06004040 RID: 16448 RVA: 0x001EE574 File Offset: 0x001EC774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStartRequest()
		{
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x001EE584 File Offset: 0x001EC784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStartRequest(GuildChestContributionStartRequest other)
		{
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x001EE594 File Offset: 0x001EC794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStartRequest Clone()
		{
			return null;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x001EE5A4 File Offset: 0x001EC7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x001EE5B4 File Offset: 0x001EC7B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestContributionStartRequest other)
		{
			return true;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x001EE5C4 File Offset: 0x001EC7C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x001EE5D4 File Offset: 0x001EC7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x001EE5E4 File Offset: 0x001EC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x001EE5F4 File Offset: 0x001EC7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x001EE604 File Offset: 0x001EC804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x001EE614 File Offset: 0x001EC814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestContributionStartRequest other)
		{
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x001EE624 File Offset: 0x001EC824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x001EE634 File Offset: 0x001EC834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x001EE644 File Offset: 0x001EC844
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestContributionStartRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					GuildChestContributionStartRequest._parser = new MessageParser<GuildChestContributionStartRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x001EE728 File Offset: 0x001EC928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WDTjGcOpaZ3GsFSvnAhl()
		{
			return true;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x001EE730 File Offset: 0x001EC930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestContributionStartRequest jXnWRPOp5ltsbuF5KCq7()
		{
			return null;
		}

		// Token: 0x04001639 RID: 5689
		private static readonly MessageParser<GuildChestContributionStartRequest> _parser;

		// Token: 0x0400163A RID: 5690
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400163B RID: 5691
		internal static GuildChestContributionStartRequest Jk3Yv3Op14JmBad4X89u;
	}
}
