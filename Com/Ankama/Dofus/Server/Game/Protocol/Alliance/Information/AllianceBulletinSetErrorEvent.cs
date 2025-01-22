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
	// Token: 0x02000D7A RID: 3450
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceBulletinSetErrorEvent : IMessage<AllianceBulletinSetErrorEvent>, IMessage, IEquatable<AllianceBulletinSetErrorEvent>, IDeepCloneable<AllianceBulletinSetErrorEvent>, IBufferMessage
	{
		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600A64F RID: 42575 RVA: 0x00291A6C File Offset: 0x0028FC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceBulletinSetErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x00291A7C File Offset: 0x0028FC7C
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

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x00291A8C File Offset: 0x0028FC8C
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

		// Token: 0x0600A652 RID: 42578 RVA: 0x00291A9C File Offset: 0x0028FC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetErrorEvent()
		{
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x00291AAC File Offset: 0x0028FCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetErrorEvent(AllianceBulletinSetErrorEvent other)
		{
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x00291ABC File Offset: 0x0028FCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600A655 RID: 42581 RVA: 0x00291ACC File Offset: 0x0028FCCC
		// (set) Token: 0x0600A656 RID: 42582 RVA: 0x00291AE0 File Offset: 0x0028FCE0
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

		// Token: 0x0600A657 RID: 42583 RVA: 0x00291AF0 File Offset: 0x0028FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x00291B00 File Offset: 0x0028FD00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceBulletinSetErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x00291B10 File Offset: 0x0028FD10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x00291B20 File Offset: 0x0028FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x00291B30 File Offset: 0x0028FD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x00291B40 File Offset: 0x0028FD40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x00291B50 File Offset: 0x0028FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x00291B60 File Offset: 0x0028FD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceBulletinSetErrorEvent other)
		{
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x00291B70 File Offset: 0x0028FD70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x00291B80 File Offset: 0x0028FD80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x00291B90 File Offset: 0x0028FD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceBulletinSetErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceBulletinSetErrorEvent._parser = new MessageParser<AllianceBulletinSetErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x00291C88 File Offset: 0x0028FE88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tFgAeXJkpfSRC3jnkZ4A()
		{
			return true;
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x00291C90 File Offset: 0x0028FE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceBulletinSetErrorEvent Q8ZFFyJkHU0aCsCTLhSt()
		{
			return null;
		}

		// Token: 0x04003D47 RID: 15687
		private static readonly MessageParser<AllianceBulletinSetErrorEvent> _parser;

		// Token: 0x04003D48 RID: 15688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D49 RID: 15689
		public const int ReasonFieldNumber = 1;

		// Token: 0x04003D4A RID: 15690
		private SocialNoticeError reason_;

		// Token: 0x04003D4B RID: 15691
		private static AllianceBulletinSetErrorEvent UOTYWiJkTvNHQoJQRXno;
	}
}
