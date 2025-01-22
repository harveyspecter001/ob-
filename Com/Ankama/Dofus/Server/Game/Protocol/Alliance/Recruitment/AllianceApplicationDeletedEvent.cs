using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D12 RID: 3346
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationDeletedEvent : IMessage<AllianceApplicationDeletedEvent>, IMessage, IEquatable<AllianceApplicationDeletedEvent>, IDeepCloneable<AllianceApplicationDeletedEvent>, IBufferMessage
	{
		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x0600A103 RID: 41219 RVA: 0x00288790 File Offset: 0x00286990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationDeletedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x002887A0 File Offset: 0x002869A0
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

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600A105 RID: 41221 RVA: 0x002887B0 File Offset: 0x002869B0
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

		// Token: 0x0600A106 RID: 41222 RVA: 0x002887C0 File Offset: 0x002869C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletedEvent()
		{
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x002887D0 File Offset: 0x002869D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletedEvent(AllianceApplicationDeletedEvent other)
		{
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x002887E0 File Offset: 0x002869E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationDeletedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x002887F0 File Offset: 0x002869F0
		// (set) Token: 0x0600A10A RID: 41226 RVA: 0x00288800 File Offset: 0x00286A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Success
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

		// Token: 0x0600A10B RID: 41227 RVA: 0x00288810 File Offset: 0x00286A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x00288820 File Offset: 0x00286A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationDeletedEvent other)
		{
			return true;
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x00288830 File Offset: 0x00286A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x00288840 File Offset: 0x00286A40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x00288850 File Offset: 0x00286A50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x00288860 File Offset: 0x00286A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x00288870 File Offset: 0x00286A70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x00288880 File Offset: 0x00286A80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationDeletedEvent other)
		{
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x00288890 File Offset: 0x00286A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x002888A0 File Offset: 0x00286AA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x002888B0 File Offset: 0x00286AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationDeletedEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					AllianceApplicationDeletedEvent._parser = new MessageParser<AllianceApplicationDeletedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x0028897C File Offset: 0x00286B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uIuaBZJKEWqWnDEvJnuj()
		{
			return true;
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x00288984 File Offset: 0x00286B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationDeletedEvent d9SJEZJKXGO0dyIr0ITt()
		{
			return null;
		}

		// Token: 0x04003B84 RID: 15236
		private static readonly MessageParser<AllianceApplicationDeletedEvent> _parser;

		// Token: 0x04003B85 RID: 15237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B86 RID: 15238
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003B87 RID: 15239
		private bool success_;

		// Token: 0x04003B88 RID: 15240
		internal static AllianceApplicationDeletedEvent INp0rxJK2N4GKDXbHcn6;
	}
}
