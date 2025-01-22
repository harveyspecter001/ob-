using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200048D RID: 1165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagInvitationAnswerRequest : IMessage<HavenBagInvitationAnswerRequest>, IMessage, IEquatable<HavenBagInvitationAnswerRequest>, IDeepCloneable<HavenBagInvitationAnswerRequest>, IBufferMessage
	{
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x001DFB3C File Offset: 0x001DDD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagInvitationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060037C9 RID: 14281 RVA: 0x001DFB4C File Offset: 0x001DDD4C
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x001DFB5C File Offset: 0x001DDD5C
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

		// Token: 0x060037CB RID: 14283 RVA: 0x001DFB6C File Offset: 0x001DDD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationAnswerRequest()
		{
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x001DFB7C File Offset: 0x001DDD7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationAnswerRequest(HavenBagInvitationAnswerRequest other)
		{
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x001DFB8C File Offset: 0x001DDD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x001DFB9C File Offset: 0x001DDD9C
		// (set) Token: 0x060037CF RID: 14287 RVA: 0x001DFBAC File Offset: 0x001DDDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accepted
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

		// Token: 0x060037D0 RID: 14288 RVA: 0x001DFBBC File Offset: 0x001DDDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x001DFBCC File Offset: 0x001DDDCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagInvitationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x001DFBDC File Offset: 0x001DDDDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x001DFBEC File Offset: 0x001DDDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x001DFBFC File Offset: 0x001DDDFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x001DFC0C File Offset: 0x001DDE0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x001DFC1C File Offset: 0x001DDE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x001DFC2C File Offset: 0x001DDE2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagInvitationAnswerRequest other)
		{
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x001DFC3C File Offset: 0x001DDE3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x001DFC4C File Offset: 0x001DDE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x001DFC5C File Offset: 0x001DDE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagInvitationAnswerRequest()
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
						return;
					case 2:
						goto IL_98;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					HavenBagInvitationAnswerRequest._parser = new MessageParser<HavenBagInvitationAnswerRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
					}
				}
				IL_98:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x001DFD44 File Offset: 0x001DDF44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tIL9ylOwkbiKR3k0UXsa()
		{
			return true;
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x001DFD4C File Offset: 0x001DDF4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagInvitationAnswerRequest JyT60sOwlojTBYVxmnw3()
		{
			return null;
		}

		// Token: 0x0400137F RID: 4991
		private static readonly MessageParser<HavenBagInvitationAnswerRequest> _parser;

		// Token: 0x04001380 RID: 4992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001381 RID: 4993
		public const int AcceptedFieldNumber = 1;

		// Token: 0x04001382 RID: 4994
		private bool accepted_;

		// Token: 0x04001383 RID: 4995
		private static HavenBagInvitationAnswerRequest cPnjlVOwIM7cnWFIayTe;
	}
}
