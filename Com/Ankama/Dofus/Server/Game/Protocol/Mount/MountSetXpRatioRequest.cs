using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000367 RID: 871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountSetXpRatioRequest : IMessage<MountSetXpRatioRequest>, IMessage, IEquatable<MountSetXpRatioRequest>, IDeepCloneable<MountSetXpRatioRequest>, IBufferMessage
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x001C6F9C File Offset: 0x001C519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountSetXpRatioRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x001C6FAC File Offset: 0x001C51AC
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x001C6FBC File Offset: 0x001C51BC
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

		// Token: 0x060028D8 RID: 10456 RVA: 0x001C6FCC File Offset: 0x001C51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSetXpRatioRequest()
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x001C6FDC File Offset: 0x001C51DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSetXpRatioRequest(MountSetXpRatioRequest other)
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x001C6FEC File Offset: 0x001C51EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSetXpRatioRequest Clone()
		{
			return null;
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x001C6FFC File Offset: 0x001C51FC
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x001C700C File Offset: 0x001C520C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int XpRatio
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

		// Token: 0x060028DD RID: 10461 RVA: 0x001C701C File Offset: 0x001C521C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x001C702C File Offset: 0x001C522C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountSetXpRatioRequest other)
		{
			return true;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x001C703C File Offset: 0x001C523C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x001C704C File Offset: 0x001C524C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x001C705C File Offset: 0x001C525C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x001C706C File Offset: 0x001C526C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x001C707C File Offset: 0x001C527C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x001C708C File Offset: 0x001C528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountSetXpRatioRequest other)
		{
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x001C709C File Offset: 0x001C529C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x001C70AC File Offset: 0x001C52AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x001C70BC File Offset: 0x001C52BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountSetXpRatioRequest()
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
					default:
						MountSetXpRatioRequest._parser = new MessageParser<MountSetXpRatioRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						return;
					case 2:
						goto IL_6E;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
						{
							num2 = 2;
						}
						break;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_6E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x001C71A4 File Offset: 0x001C53A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LyP81WOhPwVBrBEfXV7r()
		{
			return true;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x001C71AC File Offset: 0x001C53AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountSetXpRatioRequest DQ4XvTOhS6AOKvupTsVS()
		{
			return null;
		}

		// Token: 0x04000E82 RID: 3714
		private static readonly MessageParser<MountSetXpRatioRequest> _parser;

		// Token: 0x04000E83 RID: 3715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E84 RID: 3716
		public const int XpRatioFieldNumber = 1;

		// Token: 0x04000E85 RID: 3717
		private int xpRatio_;

		// Token: 0x04000E86 RID: 3718
		internal static MountSetXpRatioRequest IqjOpTOhieksCHn37O3M;
	}
}
