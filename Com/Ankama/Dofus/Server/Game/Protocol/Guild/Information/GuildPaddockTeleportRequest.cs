using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004FC RID: 1276
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildPaddockTeleportRequest : IMessage<GuildPaddockTeleportRequest>, IMessage, IEquatable<GuildPaddockTeleportRequest>, IDeepCloneable<GuildPaddockTeleportRequest>, IBufferMessage
	{
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x001E96BC File Offset: 0x001E78BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildPaddockTeleportRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x001E96CC File Offset: 0x001E78CC
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

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x001E96DC File Offset: 0x001E78DC
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

		// Token: 0x06003D07 RID: 15623 RVA: 0x001E96EC File Offset: 0x001E78EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockTeleportRequest()
		{
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x001E96FC File Offset: 0x001E78FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockTeleportRequest(GuildPaddockTeleportRequest other)
		{
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x001E970C File Offset: 0x001E790C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildPaddockTeleportRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x001E971C File Offset: 0x001E791C
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x001E972C File Offset: 0x001E792C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PaddockId
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

		// Token: 0x06003D0C RID: 15628 RVA: 0x001E973C File Offset: 0x001E793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x001E974C File Offset: 0x001E794C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildPaddockTeleportRequest other)
		{
			return true;
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x001E975C File Offset: 0x001E795C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x001E976C File Offset: 0x001E796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x001E977C File Offset: 0x001E797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x001E978C File Offset: 0x001E798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x001E979C File Offset: 0x001E799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x001E97AC File Offset: 0x001E79AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildPaddockTeleportRequest other)
		{
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x001E97BC File Offset: 0x001E79BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x001E97CC File Offset: 0x001E79CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x001E97DC File Offset: 0x001E79DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildPaddockTeleportRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					GuildPaddockTeleportRequest._parser = new MessageParser<GuildPaddockTeleportRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x001E98A8 File Offset: 0x001E7AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HMt1kpO7qQAr7Q5mljQc()
		{
			return true;
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x001E98B0 File Offset: 0x001E7AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildPaddockTeleportRequest gXWKUMO7FhTwkkiAC323()
		{
			return null;
		}

		// Token: 0x04001530 RID: 5424
		private static readonly MessageParser<GuildPaddockTeleportRequest> _parser;

		// Token: 0x04001531 RID: 5425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001532 RID: 5426
		public const int PaddockIdFieldNumber = 1;

		// Token: 0x04001533 RID: 5427
		private long paddockId_;

		// Token: 0x04001534 RID: 5428
		internal static GuildPaddockTeleportRequest K30eAkO7ZgEq7gAfomgd;
	}
}
