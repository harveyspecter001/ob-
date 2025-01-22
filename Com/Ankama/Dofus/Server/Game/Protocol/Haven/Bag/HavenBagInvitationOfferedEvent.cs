using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x020004A9 RID: 1193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagInvitationOfferedEvent : IMessage<HavenBagInvitationOfferedEvent>, IMessage, IEquatable<HavenBagInvitationOfferedEvent>, IDeepCloneable<HavenBagInvitationOfferedEvent>, IBufferMessage
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x001E1298 File Offset: 0x001DF498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagInvitationOfferedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x001E12A8 File Offset: 0x001DF4A8
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

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x001E12B8 File Offset: 0x001DF4B8
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

		// Token: 0x06003908 RID: 14600 RVA: 0x001E12C8 File Offset: 0x001DF4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationOfferedEvent()
		{
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x001E12D8 File Offset: 0x001DF4D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationOfferedEvent(HavenBagInvitationOfferedEvent other)
		{
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x001E12E8 File Offset: 0x001DF4E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationOfferedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x001E12F8 File Offset: 0x001DF4F8
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x001E1308 File Offset: 0x001DF508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character HostInformation
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

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x001E1318 File Offset: 0x001DF518
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x001E1328 File Offset: 0x001DF528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimeBeforeCancel
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

		// Token: 0x0600390F RID: 14607 RVA: 0x001E1338 File Offset: 0x001DF538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x001E1348 File Offset: 0x001DF548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagInvitationOfferedEvent other)
		{
			return true;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x001E1358 File Offset: 0x001DF558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x001E1368 File Offset: 0x001DF568
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x001E1378 File Offset: 0x001DF578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x001E1388 File Offset: 0x001DF588
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x001E1398 File Offset: 0x001DF598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x001E13A8 File Offset: 0x001DF5A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagInvitationOfferedEvent other)
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x001E13B8 File Offset: 0x001DF5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x001E13C8 File Offset: 0x001DF5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x001E13D8 File Offset: 0x001DF5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagInvitationOfferedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagInvitationOfferedEvent._parser = new MessageParser<HavenBagInvitationOfferedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x001E14BC File Offset: 0x001DF6BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GvD4WxOw8MKH4aQxVUId()
		{
			return true;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x001E14C4 File Offset: 0x001DF6C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagInvitationOfferedEvent doAjOVOwZAOPaFajXn4E()
		{
			return null;
		}

		// Token: 0x040013E3 RID: 5091
		private static readonly MessageParser<HavenBagInvitationOfferedEvent> _parser;

		// Token: 0x040013E4 RID: 5092
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013E5 RID: 5093
		public const int HostInformationFieldNumber = 1;

		// Token: 0x040013E6 RID: 5094
		private Character hostInformation_;

		// Token: 0x040013E7 RID: 5095
		public const int TimeBeforeCancelFieldNumber = 2;

		// Token: 0x040013E8 RID: 5096
		private long timeBeforeCancel_;

		// Token: 0x040013E9 RID: 5097
		internal static HavenBagInvitationOfferedEvent NyXNQsOwuynwMWZNX3qX;
	}
}
