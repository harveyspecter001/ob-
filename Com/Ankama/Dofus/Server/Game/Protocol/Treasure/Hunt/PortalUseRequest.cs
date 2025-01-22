using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000040 RID: 64
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PortalUseRequest : IMessage<PortalUseRequest>, IMessage, IEquatable<PortalUseRequest>, IDeepCloneable<PortalUseRequest>, IBufferMessage
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600026A RID: 618 RVA: 0x001873F8 File Offset: 0x001855F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PortalUseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00187408 File Offset: 0x00185608
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00187418 File Offset: 0x00185618
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

		// Token: 0x0600026D RID: 621 RVA: 0x00187428 File Offset: 0x00185628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalUseRequest()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00187438 File Offset: 0x00185638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalUseRequest(PortalUseRequest other)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00187448 File Offset: 0x00185648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PortalUseRequest Clone()
		{
			return null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00187458 File Offset: 0x00185658
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00187468 File Offset: 0x00185668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortalId
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

		// Token: 0x06000272 RID: 626 RVA: 0x00187478 File Offset: 0x00185678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00187488 File Offset: 0x00185688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PortalUseRequest other)
		{
			return true;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00187498 File Offset: 0x00185698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x001874A8 File Offset: 0x001856A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x001874B8 File Offset: 0x001856B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x001874C8 File Offset: 0x001856C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x001874D8 File Offset: 0x001856D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x001874E8 File Offset: 0x001856E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PortalUseRequest other)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x001874F8 File Offset: 0x001856F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00187508 File Offset: 0x00185708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00187518 File Offset: 0x00185718
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PortalUseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					return;
				case 2:
					PortalUseRequest._parser = new MessageParser<PortalUseRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00187610 File Offset: 0x00185810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GZwQBMOj0Dssnr7yWOIP()
		{
			return true;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00187618 File Offset: 0x00185818
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PortalUseRequest z5pSQxOjCbNsqo4laQ4c()
		{
			return null;
		}

		// Token: 0x040000F7 RID: 247
		private static readonly MessageParser<PortalUseRequest> _parser;

		// Token: 0x040000F8 RID: 248
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000F9 RID: 249
		public const int PortalIdFieldNumber = 1;

		// Token: 0x040000FA RID: 250
		private int portalId_;

		// Token: 0x040000FB RID: 251
		private static PortalUseRequest wfhkAIOjV3yPsjMYMlos;
	}
}
