using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000975 RID: 2421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachKickRequest : IMessage<BreachKickRequest>, IMessage, IEquatable<BreachKickRequest>, IDeepCloneable<BreachKickRequest>, IBufferMessage
	{
		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06007536 RID: 30006 RVA: 0x002429F4 File Offset: 0x00240BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x00242A04 File Offset: 0x00240C04
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

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06007538 RID: 30008 RVA: 0x00242A14 File Offset: 0x00240C14
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

		// Token: 0x06007539 RID: 30009 RVA: 0x00242A24 File Offset: 0x00240C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachKickRequest()
		{
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00242A34 File Offset: 0x00240C34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachKickRequest(BreachKickRequest other)
		{
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x00242A44 File Offset: 0x00240C44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachKickRequest Clone()
		{
			return null;
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600753C RID: 30012 RVA: 0x00242A54 File Offset: 0x00240C54
		// (set) Token: 0x0600753D RID: 30013 RVA: 0x00242A64 File Offset: 0x00240C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x0600753E RID: 30014 RVA: 0x00242A74 File Offset: 0x00240C74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x00242A84 File Offset: 0x00240C84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachKickRequest other)
		{
			return true;
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00242A94 File Offset: 0x00240C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00242AA4 File Offset: 0x00240CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00242AB4 File Offset: 0x00240CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00242AC4 File Offset: 0x00240CC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00242AD4 File Offset: 0x00240CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00242AE4 File Offset: 0x00240CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachKickRequest other)
		{
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x00242AF4 File Offset: 0x00240CF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x00242B04 File Offset: 0x00240D04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x00242B14 File Offset: 0x00240D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachKickRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					BreachKickRequest._parser = new MessageParser<BreachKickRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00242BF8 File Offset: 0x00240DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J7ySPVJRxjQPShE5KJlh()
		{
			return true;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x00242C00 File Offset: 0x00240E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachKickRequest gD34gNJR4V1fLwmap6ax()
		{
			return null;
		}

		// Token: 0x040028D6 RID: 10454
		private static readonly MessageParser<BreachKickRequest> _parser;

		// Token: 0x040028D7 RID: 10455
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D8 RID: 10456
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040028D9 RID: 10457
		private long playerId_;

		// Token: 0x040028DA RID: 10458
		private static BreachKickRequest egDtgGJRNwsuXMi8a8P2;
	}
}
