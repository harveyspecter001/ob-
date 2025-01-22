using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D74 RID: 3444
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMotdSetErrorEvent : IMessage<AllianceMotdSetErrorEvent>, IMessage, IEquatable<AllianceMotdSetErrorEvent>, IDeepCloneable<AllianceMotdSetErrorEvent>, IBufferMessage
	{
		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x00291430 File Offset: 0x0028F630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceMotdSetErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600A602 RID: 42498 RVA: 0x00291440 File Offset: 0x0028F640
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

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x00291450 File Offset: 0x0028F650
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

		// Token: 0x0600A604 RID: 42500 RVA: 0x00291460 File Offset: 0x0028F660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetErrorEvent()
		{
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x00291470 File Offset: 0x0028F670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetErrorEvent(AllianceMotdSetErrorEvent other)
		{
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x00291480 File Offset: 0x0028F680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x0600A607 RID: 42503 RVA: 0x00291490 File Offset: 0x0028F690
		// (set) Token: 0x0600A608 RID: 42504 RVA: 0x002914A4 File Offset: 0x0028F6A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialNoticeError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialNoticeError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x002914B4 File Offset: 0x0028F6B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x002914C4 File Offset: 0x0028F6C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMotdSetErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x002914D4 File Offset: 0x0028F6D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x002914E4 File Offset: 0x0028F6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x002914F4 File Offset: 0x0028F6F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x00291504 File Offset: 0x0028F704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A60F RID: 42511 RVA: 0x00291514 File Offset: 0x0028F714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x00291524 File Offset: 0x0028F724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMotdSetErrorEvent other)
		{
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x00291534 File Offset: 0x0028F734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x00291544 File Offset: 0x0028F744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x00291554 File Offset: 0x0028F754
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMotdSetErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AllianceMotdSetErrorEvent._parser = new MessageParser<AllianceMotdSetErrorEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x00291638 File Offset: 0x0028F838
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fE73yQJkVATiyyvCN9dc()
		{
			return true;
		}

		// Token: 0x0600A615 RID: 42517 RVA: 0x00291640 File Offset: 0x0028F840
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMotdSetErrorEvent FkAO6JJk0lnngeq9D2tB()
		{
			return null;
		}

		// Token: 0x04003D32 RID: 15666
		private static readonly MessageParser<AllianceMotdSetErrorEvent> _parser;

		// Token: 0x04003D33 RID: 15667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D34 RID: 15668
		public const int ReasonFieldNumber = 1;

		// Token: 0x04003D35 RID: 15669
		private SocialNoticeError reason_;

		// Token: 0x04003D36 RID: 15670
		private static AllianceMotdSetErrorEvent dt27XpJkrDHnmxrw1T1u;
	}
}
