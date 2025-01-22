using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004FE RID: 1278
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMotdSetRequest : IMessage<GuildMotdSetRequest>, IMessage, IEquatable<GuildMotdSetRequest>, IDeepCloneable<GuildMotdSetRequest>, IBufferMessage
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x001E98B8 File Offset: 0x001E7AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMotdSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x001E98C8 File Offset: 0x001E7AC8
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

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x001E98D8 File Offset: 0x001E7AD8
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

		// Token: 0x06003D21 RID: 15649 RVA: 0x001E98E8 File Offset: 0x001E7AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetRequest()
		{
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x001E98F8 File Offset: 0x001E7AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetRequest(GuildMotdSetRequest other)
		{
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x001E9908 File Offset: 0x001E7B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x001E9918 File Offset: 0x001E7B18
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x001E9928 File Offset: 0x001E7B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
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

		// Token: 0x06003D26 RID: 15654 RVA: 0x001E9938 File Offset: 0x001E7B38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x001E9948 File Offset: 0x001E7B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMotdSetRequest other)
		{
			return true;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x001E9958 File Offset: 0x001E7B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x001E9968 File Offset: 0x001E7B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x001E9978 File Offset: 0x001E7B78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001E9988 File Offset: 0x001E7B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001E9998 File Offset: 0x001E7B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x001E99A8 File Offset: 0x001E7BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMotdSetRequest other)
		{
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x001E99B8 File Offset: 0x001E7BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001E99C8 File Offset: 0x001E7BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x001E99D8 File Offset: 0x001E7BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMotdSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				GuildMotdSetRequest._parser = new MessageParser<GuildMotdSetRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001E9ABC File Offset: 0x001E7CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KPpNufOTfCgcwbpFXa6L()
		{
			return true;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x001E9AC4 File Offset: 0x001E7CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMotdSetRequest mXEgPsOTnR32pNk8Mivw()
		{
			return null;
		}

		// Token: 0x04001537 RID: 5431
		private static readonly MessageParser<GuildMotdSetRequest> _parser;

		// Token: 0x04001538 RID: 5432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001539 RID: 5433
		public const int ContentFieldNumber = 1;

		// Token: 0x0400153A RID: 5434
		private string content_;

		// Token: 0x0400153B RID: 5435
		internal static GuildMotdSetRequest VRaiVIO7zkxPQJBH312v;
	}
}
