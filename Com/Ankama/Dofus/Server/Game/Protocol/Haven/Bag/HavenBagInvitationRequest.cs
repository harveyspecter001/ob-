using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200048F RID: 1167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagInvitationRequest : IMessage<HavenBagInvitationRequest>, IMessage, IEquatable<HavenBagInvitationRequest>, IDeepCloneable<HavenBagInvitationRequest>, IBufferMessage
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x001DFD54 File Offset: 0x001DDF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagInvitationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x001DFD64 File Offset: 0x001DDF64
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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x001DFD74 File Offset: 0x001DDF74
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

		// Token: 0x060037E5 RID: 14309 RVA: 0x001DFD84 File Offset: 0x001DDF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationRequest()
		{
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x001DFD94 File Offset: 0x001DDF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationRequest(HavenBagInvitationRequest other)
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x001DFDA4 File Offset: 0x001DDFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x001DFDB4 File Offset: 0x001DDFB4
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x001DFDC4 File Offset: 0x001DDFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long GuestId
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

		// Token: 0x060037EA RID: 14314 RVA: 0x001DFDD4 File Offset: 0x001DDFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x001DFDE4 File Offset: 0x001DDFE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagInvitationRequest other)
		{
			return true;
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x001DFDF4 File Offset: 0x001DDFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x001DFE04 File Offset: 0x001DE004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x001DFE14 File Offset: 0x001DE014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x001DFE24 File Offset: 0x001DE024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x001DFE34 File Offset: 0x001DE034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x001DFE44 File Offset: 0x001DE044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagInvitationRequest other)
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x001DFE54 File Offset: 0x001DE054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x001DFE64 File Offset: 0x001DE064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x001DFE74 File Offset: 0x001DE074
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagInvitationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				case 4:
					HavenBagInvitationRequest._parser = new MessageParser<HavenBagInvitationRequest>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x001DFF58 File Offset: 0x001DE158
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HH1y7gOwU2vATNOSmejF()
		{
			return true;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x001DFF60 File Offset: 0x001DE160
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagInvitationRequest gq57FwOwv4OtKlFPGd8S()
		{
			return null;
		}

		// Token: 0x04001386 RID: 4998
		private static readonly MessageParser<HavenBagInvitationRequest> _parser;

		// Token: 0x04001387 RID: 4999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001388 RID: 5000
		public const int GuestIdFieldNumber = 1;

		// Token: 0x04001389 RID: 5001
		private long guestId_;

		// Token: 0x0400138A RID: 5002
		private static HavenBagInvitationRequest BePfAmOwc6FJ9U18KHQu;
	}
}
