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
	// Token: 0x02000D78 RID: 3448
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceBulletinEvent : IMessage<AllianceBulletinEvent>, IMessage, IEquatable<AllianceBulletinEvent>, IDeepCloneable<AllianceBulletinEvent>, IBufferMessage
	{
		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x0600A635 RID: 42549 RVA: 0x00291844 File Offset: 0x0028FA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceBulletinEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x0600A636 RID: 42550 RVA: 0x00291854 File Offset: 0x0028FA54
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

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x0600A637 RID: 42551 RVA: 0x00291864 File Offset: 0x0028FA64
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

		// Token: 0x0600A638 RID: 42552 RVA: 0x00291874 File Offset: 0x0028FA74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinEvent()
		{
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x00291884 File Offset: 0x0028FA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinEvent(AllianceBulletinEvent other)
		{
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x00291894 File Offset: 0x0028FA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinEvent Clone()
		{
			return null;
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x002918A4 File Offset: 0x0028FAA4
		// (set) Token: 0x0600A63C RID: 42556 RVA: 0x002918B4 File Offset: 0x0028FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialNoticeInformation BulletinInfo
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

		// Token: 0x0600A63D RID: 42557 RVA: 0x002918C4 File Offset: 0x0028FAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x002918D4 File Offset: 0x0028FAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceBulletinEvent other)
		{
			return true;
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x002918E4 File Offset: 0x0028FAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x002918F4 File Offset: 0x0028FAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x00291904 File Offset: 0x0028FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00291914 File Offset: 0x0028FB14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x00291924 File Offset: 0x0028FB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x00291934 File Offset: 0x0028FB34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceBulletinEvent other)
		{
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x00291944 File Offset: 0x0028FB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x00291954 File Offset: 0x0028FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x00291964 File Offset: 0x0028FB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceBulletinEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					AllianceBulletinEvent._parser = new MessageParser<AllianceBulletinEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x00291A5C File Offset: 0x0028FC5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O2oPDBJkQoaa1jBCiXN6()
		{
			return true;
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x00291A64 File Offset: 0x0028FC64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceBulletinEvent mKLSpmJk7rwXNUyft70l()
		{
			return null;
		}

		// Token: 0x04003D40 RID: 15680
		private static readonly MessageParser<AllianceBulletinEvent> _parser;

		// Token: 0x04003D41 RID: 15681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D42 RID: 15682
		public const int BulletinInfoFieldNumber = 1;

		// Token: 0x04003D43 RID: 15683
		private SocialNoticeInformation bulletinInfo_;

		// Token: 0x04003D44 RID: 15684
		private static AllianceBulletinEvent VgDGFeJkwF188gYX2BuD;
	}
}
